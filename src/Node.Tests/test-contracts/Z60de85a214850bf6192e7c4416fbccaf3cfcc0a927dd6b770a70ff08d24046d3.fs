#light "off"
module Z60de85a214850bf6192e7c4416fbccaf3cfcc0a927dd6b770a70ff08d24046d3
open Prims
open FStar.Pervasives

let main = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( uu____98  :  'Auu____47 ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( command  :  'Auu____48 ) ( sender  :  'Auu____49 ) ( messageBody  :  'Auu____50 ) ( wallet  :  'Auu____51 ) ( state  :  'Auu____52 ) -> (metavcoin.Cost.Realized.inc 192L 22L (metavcoin.Cost.Extracted.letBang 64L 128L (metavcoin.Asset.getDefault contractId) (fun ( asset  :  metavcoin.Types.Extracted.asset ) -> (

let spend = {metavcoin.Types.Extracted.asset = asset; metavcoin.Types.Extracted.amount = (FStar.UInt64.uint_to_t 1000L)}
in (

let pInput = metavcoin.Types.Extracted.Mint (spend)
in (metavcoin.Cost.Extracted.letBang 128L 0L (metavcoin.Cost.Realized.bind 64L 64L (metavcoin.TxSkeleton.addInput pInput txSkeleton) (metavcoin.TxSkeleton.lockToContract spend.asset spend.amount contractId)) (fun ( txSkeleton1  :  metavcoin.Types.Realized.txSkeleton ) -> (metavcoin.Base.op_At (metavcoin.ResultT.ok ()) {metavcoin.Types.Main.tx = txSkeleton1; metavcoin.Types.Main.message = FStar.Pervasives.Native.None; metavcoin.Types.Main.state = metavcoin.Types.Main.NoChange})))))))))


let cf = (fun ( uu____266  :  'Auu____225 ) ( uu____267  :  'Auu____226 ) ( uu____268  :  'Auu____227 ) ( uu____269  :  'Auu____228 ) ( uu____270  :  'Auu____229 ) ( uu____271  :  'Auu____230 ) ( uu____272  :  'Auu____231 ) -> (metavcoin.Cost.Realized.inc 0L 13L (metavcoin.Base.op_Bar_Greater (metavcoin.Base.op_Bar_Greater 214L metavcoin.Base.cast) metavcoin.Cost.Realized.ret)))


let mainFunction : metavcoin.Types.Main.mainFunction = metavcoin.Types.Main.MainFunc (metavcoin.Types.Main.CostFunc (13L, cf), main)




