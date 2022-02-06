#light "off"
module Z247fa9ec1dc70db512f46b837df5023c08562ea2ce897cebe531342e3880205e
open Prims
open FStar.Pervasives

let main = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( uu____92  :  'Auu____43 ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( command  :  Prims.string ) ( sender  :  metavcoin.Types.Main.sender ) ( messageBody  :  'Auu____44 ) ( wallet  :  'Auu____45 ) ( state  :  'Auu____46 ) -> (metavcoin.Cost.Realized.inc 128L 27L (

let isFromContract = (match (sender) with
| metavcoin.Types.Main.Contract (contractId') -> begin
(Prims.op_disEquality contractId' contractId)
end
| uu____124 -> begin
false
end)
in (match ((isFromContract && (Prims.op_Equality command "contract2_test"B))) with
| true -> begin
(metavcoin.Cost.Extracted.letBang 64L 64L (metavcoin.TxSkeleton.getAvailableTokens metavcoin.Asset.metavcoinAsset txSkeleton) (fun ( tokens  :  FStar.UInt64.t ) -> (metavcoin.Cost.Extracted.letBang 64L 0L (metavcoin.TxSkeleton.lockToContract metavcoin.Asset.metavcoinAsset tokens contractId txSkeleton) (fun ( txSkeleton1  :  metavcoin.Types.Realized.txSkeleton ) -> (metavcoin.Base.op_At (metavcoin.ResultT.ok ()) {metavcoin.Types.Main.tx = txSkeleton1; metavcoin.Types.Main.message = FStar.Pervasives.Native.None; metavcoin.Types.Main.state = metavcoin.Types.Main.NoChange})))))
end
| uu____157 -> begin
(metavcoin.ResultT.autoFailw 128L "unsupported command"B)
end))))


let cf = (fun ( uu____241  :  'Auu____200 ) ( uu____242  :  'Auu____201 ) ( uu____243  :  'Auu____202 ) ( uu____244  :  'Auu____203 ) ( uu____245  :  'Auu____204 ) ( uu____246  :  'Auu____205 ) ( uu____247  :  'Auu____206 ) -> (metavcoin.Cost.Realized.inc 0L 11L (metavcoin.Base.op_Bar_Greater (metavcoin.Base.op_Bar_Greater 155L metavcoin.Base.cast) metavcoin.Cost.Realized.ret)))


let mainFunction : metavcoin.Types.Main.mainFunction = metavcoin.Types.Main.MainFunc (metavcoin.Types.Main.CostFunc (11L, cf), main)




