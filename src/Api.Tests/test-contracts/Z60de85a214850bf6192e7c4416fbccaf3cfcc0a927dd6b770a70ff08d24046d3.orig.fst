module Z60de85a214850bf6192e7c4416fbccaf3cfcc0a927dd6b770a70ff08d24046d3

open metavcoin.Types
open metavcoin.Base
open metavcoin.Cost

module RT = metavcoin.ResultT
module Tx = metavcoin.TxSkeleton
module C = metavcoin.Cost

let main txSkeleton _ contractId command sender messageBody wallet state =
  let! asset = metavcoin.Asset.getDefault contractId in
  let spend = { asset=asset; amount=1000UL } in
  let pInput = Mint spend in

  let! txSkeleton =
    Tx.addInput pInput txSkeleton
    >>= Tx.lockToContract spend.asset spend.amount contractId in

  RT.ok @ { tx = txSkeleton; message = None; state = NoChange}

let cf _ _ _ _ _ _ _ =
    64 + (64 + 64 + 0) + 22
    |> cast nat
    |> C.ret
