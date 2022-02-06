#light "off"
module Ze13542340750a813a8ad1681541fa60b9e03edf3875ed770f8cc517dbbbca881
open Prims
open FStar.Pervasives

let main = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( uu____94  :  'Auu____43 ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( command  :  Prims.string ) ( sender  :  'Auu____44 ) ( messageBody  :  metavcoin.Types.Data.data FStar.Pervasives.Native.option ) ( wallet  :  'Auu____45 ) ( state  :  'Auu____46 ) -> (metavcoin.Cost.Realized.inc 256L 33L (match ((Prims.op_Equality command "contract1_test"B)) with
| true -> begin
(metavcoin.Cost.Extracted.letBang 64L 192L (metavcoin.Asset.getDefault contractId) (fun ( asset  :  metavcoin.Types.Extracted.asset ) -> (metavcoin.Cost.Extracted.letBang 128L 64L (metavcoin.Cost.Realized.bind 64L 64L (metavcoin.TxSkeleton.mint (FStar.UInt64.uint_to_t 25L) asset txSkeleton) (metavcoin.TxSkeleton.lockToContract asset (FStar.UInt64.uint_to_t 25L) contractId)) (fun ( txSkeleton1  :  metavcoin.Types.Realized.txSkeleton ) -> (metavcoin.Cost.Extracted.letBang 64L 0L (metavcoin.ContractId.parse "0000000044af513a65616c543b1c3267bc97a12fe0071226725d443c392b7ae808b4e3e9"B) (fun ( contractId1  :  metavcoin.Types.Extracted.contractId FStar.Pervasives.Native.option ) -> (match (contractId1) with
| FStar.Pervasives.Native.Some (contractId2) -> begin
(

let message = {metavcoin.Types.Main.recipient = contractId2; metavcoin.Types.Main.command = "contract2_test"B; metavcoin.Types.Main.body = messageBody}
in (metavcoin.Base.op_At (metavcoin.ResultT.ok ()) {metavcoin.Types.Main.tx = txSkeleton1; metavcoin.Types.Main.message = FStar.Pervasives.Native.Some (message); metavcoin.Types.Main.state = metavcoin.Types.Main.NoChange}))
end
| FStar.Pervasives.Native.None -> begin
(metavcoin.ResultT.autoFailw 0L "could not parse contractId from string"B)
end)))))))
end
| uu____225 -> begin
(metavcoin.ResultT.autoFailw 256L "unsupported command"B)
end)))


let cf = (fun ( uu____309  :  'Auu____268 ) ( uu____310  :  'Auu____269 ) ( uu____311  :  'Auu____270 ) ( uu____312  :  'Auu____271 ) ( uu____313  :  'Auu____272 ) ( uu____314  :  'Auu____273 ) ( uu____315  :  'Auu____274 ) -> (metavcoin.Cost.Realized.inc 0L 15L (metavcoin.Base.op_Bar_Greater (metavcoin.Base.op_Bar_Greater 289L metavcoin.Base.cast) metavcoin.Cost.Realized.ret)))


let mainFunction : metavcoin.Types.Main.mainFunction = metavcoin.Types.Main.MainFunc (metavcoin.Types.Main.CostFunc (15L, cf), main)




