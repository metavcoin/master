#light "off"
module Z057940919d3069153e500baa59a0499b0796f424fb68c2531b9fe7dfd6b57f36
open Prims
open FStar.Pervasives

let main = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( uu____99  :  'Auu____48 ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( command  :  'Auu____49 ) ( sender  :  'Auu____50 ) ( messageBody  :  'Auu____51 ) ( wallet  :  'Auu____52 ) ( state  :  'Auu____53 ) -> (metavcoin.Cost.Realized.inc 128L 20L (

let asset = metavcoin.Asset.metavcoinAsset
in (

let lock = metavcoin.Types.Extracted.ContractLock (contractId)
in (

let spend = {metavcoin.Types.Extracted.asset = asset; metavcoin.Types.Extracted.amount = (FStar.UInt64.uint_to_t 1000L)}
in (

let pInput = metavcoin.Types.Extracted.Mint (spend)
in (metavcoin.Cost.Extracted.letBang 128L 0L (metavcoin.Cost.Realized.bind 64L 64L (metavcoin.TxSkeleton.addInput pInput txSkeleton) (metavcoin.TxSkeleton.lockToContract spend.asset spend.amount contractId)) (fun ( txSkeleton1  :  metavcoin.Types.Realized.txSkeleton ) -> (metavcoin.Base.op_At (metavcoin.ResultT.ok ()) {metavcoin.Types.Main.tx = txSkeleton1; metavcoin.Types.Main.message = FStar.Pervasives.Native.None; metavcoin.Types.Main.state = metavcoin.Types.Main.NoChange})))))))))


let cf = (fun ( uu____259  :  'Auu____218 ) ( uu____260  :  'Auu____219 ) ( uu____261  :  'Auu____220 ) ( uu____262  :  'Auu____221 ) ( uu____263  :  'Auu____222 ) ( uu____264  :  'Auu____223 ) ( uu____265  :  'Auu____224 ) -> (metavcoin.Cost.Realized.inc 0L 9L (metavcoin.Base.op_Bar_Greater (metavcoin.Base.op_Bar_Greater 148L metavcoin.Base.cast) metavcoin.Cost.Realized.ret)))


let mainFunction : metavcoin.Types.Main.mainFunction = metavcoin.Types.Main.MainFunc (metavcoin.Types.Main.CostFunc (9L, cf), main)




