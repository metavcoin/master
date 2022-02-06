#light "off"
module Z8eaa8b1b500d6a5fa0f0d05b4eb5f627856024fe9545d932be7cb00a1e872ca2
open Prims
open FStar.Pervasives

let main = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( uu____93  :  'Auu____43 ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( command  :  'Auu____44 ) ( sender  :  'Auu____45 ) ( messageBody  :  'Auu____46 ) ( wallet  :  metavcoin.Types.Realized.wallet ) ( state  :  'Auu____47 ) -> (metavcoin.Cost.Realized.inc ((64L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 0L) 22L (metavcoin.Cost.Extracted.letBang (64L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) 0L (metavcoin.Cost.Realized.bind 64L ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L) (metavcoin.TxSkeleton.lockToPubKey metavcoin.Asset.metavcoinAsset (FStar.UInt64.uint_to_t 10L) metavcoin.Asset.zeroHash txSkeleton) (metavcoin.TxSkeleton.fromWallet metavcoin.Asset.metavcoinAsset (FStar.UInt64.uint_to_t 10L) contractId wallet)) (fun ( result  :  metavcoin.Types.Realized.txSkeleton FStar.Pervasives.Native.option ) -> (

let result' = (match (result) with
| FStar.Pervasives.Native.Some (tx) -> begin
(metavcoin.Base.op_At (fun ( _0_16  :  metavcoin.Types.Main.contractReturn ) -> FStar.Pervasives.Native.Some (_0_16)) {metavcoin.Types.Main.tx = tx; metavcoin.Types.Main.message = FStar.Pervasives.Native.None; metavcoin.Types.Main.state = metavcoin.Types.Main.NoChange})
end
| FStar.Pervasives.Native.None -> begin
FStar.Pervasives.Native.None
end)
in (metavcoin.ResultT.ofOption "not enough metavcoins"B result'))))))


let cf = (fun ( uu____212  :  'Auu____172 ) ( uu____213  :  'Auu____173 ) ( uu____214  :  'Auu____174 ) ( uu____215  :  'Auu____175 ) ( uu____216  :  'Auu____176 ) ( wallet  :  metavcoin.Types.Realized.wallet ) ( uu____218  :  'Auu____177 ) -> (metavcoin.Cost.Realized.inc 0L 12L (metavcoin.Cost.Realized.ret (((64L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 0L) + 22L))))


let mainFunction : metavcoin.Types.Main.mainFunction = metavcoin.Types.Main.MainFunc (metavcoin.Types.Main.CostFunc (12L, cf), main)




