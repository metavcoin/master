#light "off"
module Z0ca41657cc75e5e40cb85c90a0d09706b22323276819cb5563415d83ccf12e68
open Prims
open FStar.Pervasives

let main = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( uu____99  :  'Auu____48 ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( command  :  'Auu____49 ) ( sender  :  'Auu____50 ) ( messageBody  :  'Auu____51 ) ( wallet  :  'Auu____52 ) ( state  :  'Auu____53 ) -> (metavcoin.Cost.Realized.inc 256L 28L (

let str = "Test"B
in (match (((FStar.String.length str) < 29L)) with
| true -> begin
(metavcoin.Cost.Extracted.letBang 64L 192L (metavcoin.Asset.fromSubtypeString contractId str) (fun ( assetString  :  metavcoin.Types.Extracted.asset ) -> (metavcoin.Cost.Extracted.letBang 64L 128L (metavcoin.Asset.fromSubtypeInt contractId (FStar.UInt32.uint_to_t 9999999L)) (fun ( assetInt  :  metavcoin.Types.Extracted.asset ) -> (metavcoin.Cost.Extracted.letBang 128L 0L (metavcoin.Cost.Realized.bind 64L 64L (metavcoin.TxSkeleton.mint (FStar.UInt64.uint_to_t 10L) assetInt txSkeleton) (metavcoin.TxSkeleton.mint (FStar.UInt64.uint_to_t 20L) assetString)) (fun ( txSkeleton1  :  metavcoin.Types.Realized.txSkeleton ) -> (metavcoin.Base.op_At (metavcoin.ResultT.ok ()) {metavcoin.Types.Main.tx = txSkeleton1; metavcoin.Types.Main.message = FStar.Pervasives.Native.None; metavcoin.Types.Main.state = metavcoin.Types.Main.NoChange})))))))
end
| uu____214 -> begin
(metavcoin.ResultT.autoFailw 256L "unexpected"B)
end))))


let cf = (fun ( uu____298  :  'Auu____257 ) ( uu____299  :  'Auu____258 ) ( uu____300  :  'Auu____259 ) ( uu____301  :  'Auu____260 ) ( uu____302  :  'Auu____261 ) ( uu____303  :  'Auu____262 ) ( uu____304  :  'Auu____263 ) -> (metavcoin.Cost.Realized.inc 0L 15L (metavcoin.Base.op_Bar_Greater (metavcoin.Base.op_Bar_Greater 284L metavcoin.Base.cast) metavcoin.Cost.Realized.ret)))


let mainFunction : metavcoin.Types.Main.mainFunction = metavcoin.Types.Main.MainFunc (metavcoin.Types.Main.CostFunc (15L, cf), main)




