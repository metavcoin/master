#light "off"
module Zadd0e9396d8d6d65229fe90c5cf36fbd17c720b1cd29b17488184e0de5a51b71
open Prims
open FStar.Pervasives

let main = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( uu____96  :  'Auu____46 ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( command  :  Prims.string ) ( sender  :  metavcoin.Types.Main.sender ) ( messageBody  :  metavcoin.Types.Data.data FStar.Pervasives.Native.option ) ( wallet  :  'Auu____47 ) ( state  :  'Auu____48 ) -> (metavcoin.Cost.Realized.inc 332L 57L (match ((Prims.op_Equality command "mint"B)) with
| true -> begin
(match (sender) with
| metavcoin.Types.Main.Contract (contract') -> begin
(metavcoin.ResultT.autoFailw 332L "unexpected sender: Contract"B)
end
| metavcoin.Types.Main.PK (pk) -> begin
(metavcoin.ResultT.autoFailw 332L "unexpected sender: PK"B)
end
| metavcoin.Types.Main.Anonymous -> begin
(metavcoin.Cost.Extracted.letBang 70L 262L (metavcoin.Data.op_Greater_Question_Equals 68L 2L (metavcoin.Data.op_Greater_Question_Equals 4L 64L (metavcoin.Data.op_Greater_Bang_Equals 4L messageBody metavcoin.Data.tryDict) (metavcoin.Dictionary.tryFind "returnAddress"B)) metavcoin.Data.tryLock) (fun ( returnAddress  :  metavcoin.Types.Extracted.lock FStar.Pervasives.Native.option ) -> (metavcoin.Cost.Extracted.letBang 70L 192L (metavcoin.Data.op_Greater_Question_Equals 68L 2L (metavcoin.Data.op_Greater_Question_Equals 4L 64L (metavcoin.Data.op_Greater_Bang_Equals 4L messageBody metavcoin.Data.tryDict) (metavcoin.Dictionary.tryFind "amount"B)) metavcoin.Data.tryU64) (fun ( amount  :  FStar.UInt64.t FStar.Pervasives.Native.option ) -> (match (((returnAddress), (amount))) with
| (FStar.Pervasives.Native.Some (returnAddress1), FStar.Pervasives.Native.Some (amount1)) -> begin
(metavcoin.Cost.Extracted.letBang 64L 128L (metavcoin.Asset.getDefault contractId) (fun ( asset  :  metavcoin.Types.Extracted.asset ) -> (

let spend = {metavcoin.Types.Extracted.asset = asset; metavcoin.Types.Extracted.amount = amount1}
in (

let pInput = metavcoin.Types.Extracted.Mint (spend)
in (metavcoin.Cost.Extracted.letBang 128L 0L (metavcoin.Cost.Realized.bind 64L 64L (metavcoin.TxSkeleton.addInput pInput txSkeleton) (metavcoin.TxSkeleton.lockToAddress spend.asset spend.amount returnAddress1)) (fun ( txSkeleton1  :  metavcoin.Types.Realized.txSkeleton ) -> (metavcoin.Base.op_At (metavcoin.ResultT.ok ()) {metavcoin.Types.Main.tx = txSkeleton1; metavcoin.Types.Main.message = FStar.Pervasives.Native.None; metavcoin.Types.Main.state = metavcoin.Types.Main.NoChange})))))))
end
| uu____230 -> begin
(metavcoin.ResultT.autoFailw 192L "both returnAddress and amount are required"B)
end)))))
end)
end
| uu____239 -> begin
(metavcoin.ResultT.autoFailw 332L "unsupported command"B)
end)))


let cf = (fun ( uu____323  :  'Auu____282 ) ( uu____324  :  'Auu____283 ) ( uu____325  :  'Auu____284 ) ( uu____326  :  'Auu____285 ) ( uu____327  :  'Auu____286 ) ( uu____328  :  'Auu____287 ) ( uu____329  :  'Auu____288 ) -> (metavcoin.Cost.Realized.inc 0L 25L (metavcoin.Base.op_Bar_Greater (metavcoin.Base.op_Bar_Greater 389L metavcoin.Base.cast) metavcoin.Cost.Realized.ret)))


let mainFunction : metavcoin.Types.Main.mainFunction = metavcoin.Types.Main.MainFunc (metavcoin.Types.Main.CostFunc (25L, cf), main)




