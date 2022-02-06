#light "off"
module Z44af513a65616c543b1c3267bc97a12fe0071226725d443c392b7ae808b4e3e9
open Prims
open FStar.Pervasives

let main = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( uu____93  :  'Auu____43 ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( command  :  Prims.string ) ( sender  :  'Auu____44 ) ( messageBody  :  'Auu____45 ) ( wallet  :  'Auu____46 ) ( state  :  'Auu____47 ) -> (metavcoin.Cost.Realized.inc 192L 23L (match ((Prims.op_Equality command "contract2_test"B)) with
| true -> begin
(metavcoin.Cost.Extracted.letBang 64L 128L (metavcoin.Asset.getDefault contractId) (fun ( contractToken  :  metavcoin.Types.Extracted.asset ) -> (metavcoin.Cost.Extracted.letBang 128L 0L (metavcoin.Cost.Realized.bind 64L 64L (metavcoin.TxSkeleton.mint (FStar.UInt64.uint_to_t 50L) contractToken txSkeleton) (metavcoin.TxSkeleton.lockToContract contractToken (FStar.UInt64.uint_to_t 50L) contractId)) (fun ( txSkeleton1  :  metavcoin.Types.Realized.txSkeleton ) -> (metavcoin.Base.op_At (metavcoin.ResultT.ok ()) {metavcoin.Types.Main.tx = txSkeleton1; metavcoin.Types.Main.message = FStar.Pervasives.Native.None; metavcoin.Types.Main.state = metavcoin.Types.Main.NoChange})))))
end
| uu____190 -> begin
(metavcoin.ResultT.autoFailw 192L "unsupported command"B)
end)))


let cf = (fun ( uu____274  :  'Auu____233 ) ( uu____275  :  'Auu____234 ) ( uu____276  :  'Auu____235 ) ( uu____277  :  'Auu____236 ) ( uu____278  :  'Auu____237 ) ( uu____279  :  'Auu____238 ) ( uu____280  :  'Auu____239 ) -> (metavcoin.Cost.Realized.inc 0L 13L (metavcoin.Base.op_Bar_Greater (metavcoin.Base.op_Bar_Greater 215L metavcoin.Base.cast) metavcoin.Cost.Realized.ret)))


let mainFunction : metavcoin.Types.Main.mainFunction = metavcoin.Types.Main.MainFunc (metavcoin.Types.Main.CostFunc (13L, cf), main)




