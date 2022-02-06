#light "off"
module Z9fe39f45f9c86018b980a5e584af955d8e94907d35ee0bb90288df4bbababc01
open Prims
open FStar.Pervasives

let main = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( uu____99  :  'Auu____48 ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( command  :  'Auu____49 ) ( sender  :  'Auu____50 ) ( messageBody  :  'Auu____51 ) ( wallet  :  'Auu____52 ) ( state  :  'Auu____53 ) -> (metavcoin.Cost.Realized.inc 192L 23L (metavcoin.Cost.Extracted.letBang 64L 128L (metavcoin.Asset.getDefault contractId) (fun ( asset  :  metavcoin.Types.Extracted.asset ) -> (

let lock = metavcoin.Types.Extracted.ContractLock (contractId)
in (

let spend = {metavcoin.Types.Extracted.asset = asset; metavcoin.Types.Extracted.amount = (FStar.UInt64.uint_to_t 1000L)}
in (

let pInput = metavcoin.Types.Extracted.Mint (spend)
in (metavcoin.Cost.Extracted.letBang 128L 0L (metavcoin.Cost.Realized.bind 64L 64L (metavcoin.TxSkeleton.addInput pInput txSkeleton) (metavcoin.TxSkeleton.lockToContract spend.asset spend.amount contractId)) (fun ( txSkeleton1  :  metavcoin.Types.Realized.txSkeleton ) -> (metavcoin.Base.op_At (metavcoin.ResultT.ok ()) {metavcoin.Types.Main.tx = txSkeleton1; metavcoin.Types.Main.message = FStar.Pervasives.Native.None; metavcoin.Types.Main.state = metavcoin.Types.Main.NoChange}))))))))))


let cf = (fun ( uu____281  :  'Auu____240 ) ( uu____282  :  'Auu____241 ) ( uu____283  :  'Auu____242 ) ( uu____284  :  'Auu____243 ) ( uu____285  :  'Auu____244 ) ( uu____286  :  'Auu____245 ) ( uu____287  :  'Auu____246 ) -> (metavcoin.Cost.Realized.inc 0L 13L (metavcoin.Base.op_Bar_Greater (metavcoin.Base.op_Bar_Greater 215L metavcoin.Base.cast) metavcoin.Cost.Realized.ret)))


let mainFunction : metavcoin.Types.Main.mainFunction = metavcoin.Types.Main.MainFunc (metavcoin.Types.Main.CostFunc (13L, cf), main)




