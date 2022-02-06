#light "off"
module Ze89738718a802a7d217941882efe8e585e20b20901391bc37af25fac2f22c8ab
open Prims
open FStar.Pervasives

let name : Prims.string = "Testnet Voting Contract"B


let main = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( uu____94  :  'Auu____46 ) ( contractId  :  'Auu____47 ) ( command  :  'Auu____48 ) ( sender  :  'Auu____49 ) ( messageBody  :  'Auu____50 ) ( wallet  :  'Auu____51 ) ( state  :  'Auu____52 ) -> (metavcoin.Cost.Realized.inc 0L 5L (metavcoin.Base.op_At (metavcoin.ResultT.ok ()) {metavcoin.Types.Main.tx = txSkeleton; metavcoin.Types.Main.message = FStar.Pervasives.Native.None; metavcoin.Types.Main.state = metavcoin.Types.Main.NoChange})))


let cf = (fun ( uu____194  :  'Auu____153 ) ( uu____195  :  'Auu____154 ) ( uu____196  :  'Auu____155 ) ( uu____197  :  'Auu____156 ) ( uu____198  :  'Auu____157 ) ( uu____199  :  'Auu____158 ) ( uu____200  :  'Auu____159 ) -> (metavcoin.Cost.Realized.inc 0L 5L (metavcoin.Base.op_Bar_Greater (metavcoin.Base.op_Bar_Greater 5L metavcoin.Base.cast) metavcoin.Cost.Realized.ret)))


let mainFunction : metavcoin.Types.Main.mainFunction = metavcoin.Types.Main.MainFunc (metavcoin.Types.Main.CostFunc (5L, cf), main)




