open metavcoin.Types
open metavcoin.Base
open metavcoin.Cost
open metavcoin.Asset
open metavcoin.Data

module D = metavcoin.Dictionary
module Tx = metavcoin.TxSkeleton
module C = metavcoin.Cost
module RT = metavcoin.ResultT

let cf _ _ _ _ _ wallet _ =
    4 + 64 + 2 + (64 + (metavcoin.Wallet.size wallet * 128 + 192) + 0 + 13) + (0 + 5) + 22
    |> C.ret #nat

let get txSkeleton contractId (wallet:wallet) returnAddress =
    Tx.lockToAddress metavcoinAsset 10000UL returnAddress txSkeleton
    >>= Tx.fromWallet metavcoinAsset 10000UL contractId wallet
    >>= RT.ofOption "contract doesn't have enough metavcoins to pay you"

let init txSkeleton contractId =
    let! tokens = Tx.getAvailableTokens metavcoinAsset txSkeleton in
    Tx.lockToContract metavcoinAsset tokens contractId txSkeleton

let main txSkeleton _ contractId command _ messageBody wallet _ =
    let open RT in

    begin
        if command <> "init" then
            messageBody
            >!= tryDict
            >?= D.tryFind "returnAddress"
            >?= tryLock
            |> RT.ofOptionT "returnAddress is required"
            >>= get txSkeleton contractId wallet
        else
            init txSkeleton contractId
            |> liftCost
            |> autoInc
    end
    >>= (fun tx -> RT.ok @ { tx = tx; message = None; state = NoChange })