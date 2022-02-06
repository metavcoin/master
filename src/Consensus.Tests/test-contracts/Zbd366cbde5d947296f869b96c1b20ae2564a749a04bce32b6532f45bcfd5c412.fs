#light "off"
module Zbd366cbde5d947296f869b96c1b20ae2564a749a04bce32b6532f45bcfd5c412
open Prims
open FStar.Pervasives

let main = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( uu____96  :  'Auu____46 ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( command  :  'Auu____47 ) ( sender  :  metavcoin.Types.Main.sender ) ( messageBody  :  'Auu____48 ) ( wallet  :  'Auu____49 ) ( state  :  'Auu____50 ) -> (metavcoin.Cost.Realized.inc 312L 30L (metavcoin.Cost.Extracted.letBang 120L 192L (metavcoin.Crypto.parsePublicKey "03f307752a4f1f0fb0f7fcb3055a5a1977a173ec54007f48a78b498ff51307ee47"B) (fun ( pk  :  metavcoin.Types.Extracted.publicKey FStar.Pervasives.Native.option ) -> (match (sender) with
| metavcoin.Types.Main.PK (pk') -> begin
(match ((Prims.op_Equality (FStar.Pervasives.Native.Some (pk')) pk)) with
| true -> begin
(metavcoin.Cost.Extracted.letBang 64L 128L (metavcoin.Asset.getDefault contractId) (fun ( contractAsset  :  metavcoin.Types.Extracted.asset ) -> (metavcoin.Cost.Extracted.letBang 128L 0L (metavcoin.Cost.Realized.bind 64L 64L (metavcoin.TxSkeleton.mint (FStar.UInt64.uint_to_t 1L) contractAsset txSkeleton) (metavcoin.TxSkeleton.lockToContract contractAsset (FStar.UInt64.uint_to_t 1L) contractId)) (fun ( txSkeleton1  :  metavcoin.Types.Realized.txSkeleton ) -> (metavcoin.Base.op_At (metavcoin.ResultT.ok ()) {metavcoin.Types.Main.tx = txSkeleton1; metavcoin.Types.Main.message = FStar.Pervasives.Native.None; metavcoin.Types.Main.state = metavcoin.Types.Main.NoChange})))))
end
| uu____229 -> begin
(metavcoin.ResultT.autoFailw 192L "expected different pk"B)
end)
end
| uu____230 -> begin
(metavcoin.ResultT.autoFailw 192L "expected pk"B)
end)))))


let cf = (fun ( uu____314  :  'Auu____273 ) ( uu____315  :  'Auu____274 ) ( uu____316  :  'Auu____275 ) ( uu____317  :  'Auu____276 ) ( uu____318  :  'Auu____277 ) ( uu____319  :  'Auu____278 ) ( uu____320  :  'Auu____279 ) -> (metavcoin.Cost.Realized.inc 0L 15L (metavcoin.Base.op_Bar_Greater (metavcoin.Base.op_Bar_Greater 342L metavcoin.Base.cast) metavcoin.Cost.Realized.ret)))


let mainFunction : metavcoin.Types.Main.mainFunction = metavcoin.Types.Main.MainFunc (metavcoin.Types.Main.CostFunc (15L, cf), main)




