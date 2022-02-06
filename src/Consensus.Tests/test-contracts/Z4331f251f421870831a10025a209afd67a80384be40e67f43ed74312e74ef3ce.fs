#light "off"
module Z4331f251f421870831a10025a209afd67a80384be40e67f43ed74312e74ef3ce
open Prims
open FStar.Pervasives

let main = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( contractContext  :  metavcoin.Types.Main.context ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( command  :  'Auu____45 ) ( sender  :  'Auu____46 ) ( messageBody  :  'Auu____47 ) ( wallet  :  'Auu____48 ) ( state  :  'Auu____49 ) -> (metavcoin.Cost.Realized.inc 192L 24L (metavcoin.Cost.Extracted.letBang 64L 128L (metavcoin.Asset.getDefault contractId) (fun ( asset  :  metavcoin.Types.Extracted.asset ) -> (

let lock = metavcoin.Types.Extracted.ContractLock (contractId)
in (

let spend = {metavcoin.Types.Extracted.asset = asset; metavcoin.Types.Extracted.amount = contractContext.timestamp}
in (

let pInput = metavcoin.Types.Extracted.Mint (spend)
in (metavcoin.Cost.Extracted.letBang 128L 0L (metavcoin.Cost.Realized.bind 64L 64L (metavcoin.TxSkeleton.addInput pInput txSkeleton) (metavcoin.TxSkeleton.lockToContract spend.asset spend.amount contractId)) (fun ( txSkeleton1  :  metavcoin.Types.Realized.txSkeleton ) -> (metavcoin.Base.op_At (metavcoin.ResultT.ok ()) {metavcoin.Types.Main.tx = txSkeleton1; metavcoin.Types.Main.message = FStar.Pervasives.Native.None; metavcoin.Types.Main.state = metavcoin.Types.Main.NoChange}))))))))))


let cf = (fun ( uu____277  :  'Auu____236 ) ( uu____278  :  'Auu____237 ) ( uu____279  :  'Auu____238 ) ( uu____280  :  'Auu____239 ) ( uu____281  :  'Auu____240 ) ( uu____282  :  'Auu____241 ) ( uu____283  :  'Auu____242 ) -> (metavcoin.Cost.Realized.inc 0L 13L (metavcoin.Base.op_Bar_Greater (metavcoin.Base.op_Bar_Greater 216L metavcoin.Base.cast) metavcoin.Cost.Realized.ret)))


let mainFunction : metavcoin.Types.Main.mainFunction = metavcoin.Types.Main.MainFunc (metavcoin.Types.Main.CostFunc (13L, cf), main)




