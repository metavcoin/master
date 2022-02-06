#light "off"
module Zec488d5eb7466867e6e05b31cb900f0376c8fd96cb3e5e31062f1e6f5b43385d
open Prims
open FStar.Pervasives

let main = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( uu____100  :  'Auu____48 ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( command  :  'Auu____49 ) ( sender  :  'Auu____50 ) ( messageBody  :  metavcoin.Types.Data.data FStar.Pervasives.Native.option ) ( wallet  :  'Auu____51 ) ( state  :  'Auu____52 ) -> (metavcoin.Cost.Realized.inc 390L 44L (metavcoin.Cost.Extracted.letBang 70L 320L (metavcoin.Data.op_Greater_Question_Equals 68L 2L (metavcoin.Data.op_Greater_Question_Equals 4L 64L (metavcoin.Data.op_Greater_Bang_Equals 4L messageBody metavcoin.Data.tryDict) (metavcoin.Dictionary.tryFind "returnAddress"B)) metavcoin.Data.tryLock) (fun ( returnAddress  :  metavcoin.Types.Extracted.lock FStar.Pervasives.Native.option ) -> (match (returnAddress) with
| FStar.Pervasives.Native.Some (returnAddress1) -> begin
(metavcoin.Cost.Extracted.letBang 64L 256L (metavcoin.TxSkeleton.getAvailableTokens metavcoin.Asset.metavcoinAsset txSkeleton) (fun ( tokens  :  FStar.UInt64.t ) -> (metavcoin.Cost.Extracted.letBang 64L 192L (metavcoin.Asset.getDefault contractId) (fun ( asset  :  metavcoin.Types.Extracted.asset ) -> (metavcoin.Cost.Extracted.letBang 128L 64L (metavcoin.Cost.Realized.bind 64L 64L (metavcoin.TxSkeleton.mint tokens asset txSkeleton) (metavcoin.TxSkeleton.lockToAddress asset tokens returnAddress1)) (fun ( txSkeleton1  :  metavcoin.Types.Realized.txSkeleton ) -> (metavcoin.Cost.Extracted.letBang 64L 0L (metavcoin.ContractId.parse "00000000247fa9ec1dc70db512f46b837df5023c08562ea2ce897cebe531342e3880205e"B) (fun ( contractId1  :  metavcoin.Types.Extracted.contractId FStar.Pervasives.Native.option ) -> (match (contractId1) with
| FStar.Pervasives.Native.Some (contractId2) -> begin
(

let message = {metavcoin.Types.Main.recipient = contractId2; metavcoin.Types.Main.command = "contract2_test"B; metavcoin.Types.Main.body = messageBody}
in (metavcoin.Base.op_At (metavcoin.ResultT.ok ()) {metavcoin.Types.Main.tx = txSkeleton1; metavcoin.Types.Main.message = FStar.Pervasives.Native.Some (message); metavcoin.Types.Main.state = metavcoin.Types.Main.NoChange}))
end
| FStar.Pervasives.Native.None -> begin
(metavcoin.ResultT.autoFailw 0L "could not parse contractId from string"B)
end)))))))))
end
| FStar.Pervasives.Native.None -> begin
(metavcoin.ResultT.autoFailw 320L "returnAddress is required"B)
end)))))


let cf = (fun ( uu____332  :  'Auu____291 ) ( uu____333  :  'Auu____292 ) ( uu____334  :  'Auu____293 ) ( uu____335  :  'Auu____294 ) ( uu____336  :  'Auu____295 ) ( uu____337  :  'Auu____296 ) ( uu____338  :  'Auu____297 ) -> (metavcoin.Cost.Realized.inc 0L 23L (metavcoin.Base.op_Bar_Greater (metavcoin.Base.op_Bar_Greater 434L metavcoin.Base.cast) metavcoin.Cost.Realized.ret)))


let mainFunction : metavcoin.Types.Main.mainFunction = metavcoin.Types.Main.MainFunc (metavcoin.Types.Main.CostFunc (23L, cf), main)




