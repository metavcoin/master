#light "off"
module Ze523addca6083f6356ac6b86398bc5c32cc082a5de0b83a9ecab8c6f03ec31bb
open Prims
open FStar.Pervasives

let main = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( uu____100  :  'Auu____49 ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( command  :  'Auu____50 ) ( sender  :  'Auu____51 ) ( messageBody  :  'Auu____52 ) ( wallet  :  'Auu____53 ) ( state  :  'Auu____54 ) -> (metavcoin.Cost.Realized.inc 192L 25L (metavcoin.Cost.Extracted.letBang 64L 128L (metavcoin.Asset.getDefault contractId) (fun ( asset  :  metavcoin.Types.Extracted.asset ) -> (

let spend = {metavcoin.Types.Extracted.asset = asset; metavcoin.Types.Extracted.amount = (FStar.UInt64.uint_to_t 1000L)}
in (

let lock = metavcoin.Types.Extracted.ContractLock (contractId)
in (

let output = {metavcoin.Types.Extracted.lock = lock; metavcoin.Types.Extracted.spend = spend}
in (

let pInput = metavcoin.Types.Extracted.Mint (spend)
in (metavcoin.Cost.Extracted.letBang 128L 0L (metavcoin.Cost.Realized.bind 64L 64L (metavcoin.TxSkeleton.addInput pInput txSkeleton) (metavcoin.TxSkeleton.lockToContract spend.asset spend.amount contractId)) (fun ( txSkeleton1  :  metavcoin.Types.Realized.txSkeleton ) -> (metavcoin.Base.op_At (metavcoin.ResultT.ok ()) {metavcoin.Types.Main.tx = txSkeleton1; metavcoin.Types.Main.message = FStar.Pervasives.Native.None; metavcoin.Types.Main.state = metavcoin.Types.Main.NoChange})))))))))))


let cf = (fun ( uu____284  :  'Auu____243 ) ( uu____285  :  'Auu____244 ) ( uu____286  :  'Auu____245 ) ( uu____287  :  'Auu____246 ) ( uu____288  :  'Auu____247 ) ( uu____289  :  'Auu____248 ) ( uu____290  :  'Auu____249 ) -> (metavcoin.Cost.Realized.inc 0L 13L (metavcoin.Base.op_Bar_Greater (metavcoin.Base.op_Bar_Greater 217L metavcoin.Base.cast) metavcoin.Cost.Realized.ret)))


let mainFunction : metavcoin.Types.Main.mainFunction = metavcoin.Types.Main.MainFunc (metavcoin.Types.Main.CostFunc (13L, cf), main)




