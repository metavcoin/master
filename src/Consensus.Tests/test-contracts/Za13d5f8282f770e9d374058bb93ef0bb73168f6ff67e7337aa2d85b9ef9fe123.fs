#light "off"
module Za13d5f8282f770e9d374058bb93ef0bb73168f6ff67e7337aa2d85b9ef9fe123
open Prims
open FStar.Pervasives

let main = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( uu____96  :  'Auu____45 ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( command  :  'Auu____46 ) ( sender  :  'Auu____47 ) ( messageBody  :  'Auu____48 ) ( wallet  :  'Auu____49 ) ( state  :  'Auu____50 ) -> (metavcoin.Cost.Realized.inc 128L 13L (metavcoin.Cost.Extracted.letBang 64L 64L (metavcoin.Asset.getDefault contractId) (fun ( asset  :  metavcoin.Types.Extracted.asset ) -> (metavcoin.Cost.Extracted.letBang 64L 0L (metavcoin.TxSkeleton.destroy (FStar.UInt64.uint_to_t 1000L) asset txSkeleton) (fun ( txSkeleton1  :  metavcoin.Types.Realized.txSkeleton ) -> (metavcoin.Base.op_At (metavcoin.ResultT.ok ()) {metavcoin.Types.Main.tx = txSkeleton1; metavcoin.Types.Main.message = FStar.Pervasives.Native.None; metavcoin.Types.Main.state = metavcoin.Types.Main.NoChange})))))))


let cf = (fun ( uu____244  :  'Auu____203 ) ( uu____245  :  'Auu____204 ) ( uu____246  :  'Auu____205 ) ( uu____247  :  'Auu____206 ) ( uu____248  :  'Auu____207 ) ( uu____249  :  'Auu____208 ) ( uu____250  :  'Auu____209 ) -> (metavcoin.Cost.Realized.inc 0L 11L (metavcoin.Base.op_Bar_Greater (metavcoin.Base.op_Bar_Greater 141L metavcoin.Base.cast) metavcoin.Cost.Realized.ret)))


let mainFunction : metavcoin.Types.Main.mainFunction = metavcoin.Types.Main.MainFunc (metavcoin.Types.Main.CostFunc (11L, cf), main)




