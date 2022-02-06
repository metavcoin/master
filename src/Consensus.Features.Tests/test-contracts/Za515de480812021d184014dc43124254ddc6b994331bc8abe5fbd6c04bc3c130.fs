#light "off"
module Za515de480812021d184014dc43124254ddc6b994331bc8abe5fbd6c04bc3c130
open Prims
open FStar.Pervasives

let buy : metavcoin.Types.Realized.txSkeleton  ->  metavcoin.Types.Extracted.contractId  ->  metavcoin.Types.Extracted.lock  ->  (metavcoin.Types.Main.contractResult, unit) metavcoin.Cost.Realized.cost = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( returnAddress  :  metavcoin.Types.Extracted.lock ) -> (metavcoin.Cost.Realized.inc 323L 23L (metavcoin.Cost.Extracted.letBang 64L 259L (metavcoin.Asset.getDefault contractId) (fun ( contractToken  :  metavcoin.Types.Extracted.asset ) -> (metavcoin.Cost.Extracted.letBang 64L 195L (metavcoin.TxSkeleton.getAvailableTokens metavcoin.Asset.metavcoinAsset txSkeleton) (fun ( amount  :  FStar.UInt64.t ) -> (metavcoin.Cost.Extracted.letBang 192L 3L (metavcoin.Cost.Realized.bind 128L 64L (metavcoin.Cost.Realized.bind 64L 64L (metavcoin.TxSkeleton.lockToContract metavcoin.Asset.metavcoinAsset amount contractId txSkeleton) (metavcoin.TxSkeleton.mint amount contractToken)) (metavcoin.TxSkeleton.lockToAddress contractToken amount returnAddress)) (fun ( txSkeleton1  :  metavcoin.Types.Realized.txSkeleton ) -> (metavcoin.ContractResult.ofTxSkel txSkeleton1)))))))))


let redeem : metavcoin.Types.Realized.txSkeleton  ->  metavcoin.Types.Extracted.contractId  ->  metavcoin.Types.Extracted.lock  ->  metavcoin.Types.Realized.wallet  ->  (metavcoin.Types.Main.contractResult, unit) metavcoin.Cost.Realized.cost = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( returnAddress  :  metavcoin.Types.Extracted.lock ) ( wallet  :  metavcoin.Types.Realized.wallet ) -> (metavcoin.Cost.Realized.inc (64L + (64L + ((128L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 3L))) 25L (metavcoin.Cost.Extracted.letBang 64L (64L + ((128L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 3L)) (metavcoin.Asset.getDefault contractId) (fun ( contractToken  :  metavcoin.Types.Extracted.asset ) -> (metavcoin.Cost.Extracted.letBang 64L ((128L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 3L) (metavcoin.TxSkeleton.getAvailableTokens contractToken txSkeleton) (fun ( amount  :  FStar.UInt64.t ) -> (metavcoin.Cost.Extracted.letBang (128L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) 3L (metavcoin.Cost.Realized.bind 128L ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L) (metavcoin.Cost.Realized.bind 64L 64L (metavcoin.TxSkeleton.destroy amount contractToken txSkeleton) (metavcoin.TxSkeleton.lockToAddress metavcoin.Asset.metavcoinAsset amount returnAddress)) (metavcoin.TxSkeleton.fromWallet metavcoin.Asset.metavcoinAsset amount contractId wallet)) (fun ( txSkeleton1  :  metavcoin.Types.Realized.txSkeleton FStar.Pervasives.Native.option ) -> (metavcoin.ContractResult.ofOptionTxSkel "contract doesn\'t have enough metavcoins tokens"B txSkeleton1)))))))))


let main = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( uu____316  :  'Auu____268 ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( command  :  Prims.string ) ( sender  :  'Auu____269 ) ( messageBody  :  metavcoin.Types.Data.data FStar.Pervasives.Native.option ) ( wallet  :  metavcoin.Types.Realized.wallet ) ( state  :  'Auu____270 ) -> (metavcoin.Cost.Realized.inc (70L + ((64L + (64L + ((128L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 3L))) + 25L)) 31L (metavcoin.Cost.Extracted.letBang 70L ((64L + (64L + ((128L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 3L))) + 25L) (metavcoin.Data.op_Greater_Question_Equals 68L 2L (metavcoin.Data.op_Greater_Question_Equals 4L 64L (metavcoin.Data.op_Greater_Bang_Equals 4L messageBody metavcoin.Data.tryDict) (metavcoin.Dictionary.tryFind "returnAddress"B)) metavcoin.Data.tryLock) (fun ( returnAddress  :  metavcoin.Types.Extracted.lock FStar.Pervasives.Native.option ) -> (match (returnAddress) with
| FStar.Pervasives.Native.Some (returnAddress1) -> begin
(match ((Prims.op_Equality command "redeem"B)) with
| true -> begin
(redeem txSkeleton contractId returnAddress1 wallet)
end
| uu____361 -> begin
(match (((Prims.op_Equality command ""B) || (Prims.op_Equality command "buy"B))) with
| true -> begin
(metavcoin.Base.op_Bar_Greater (buy txSkeleton contractId returnAddress1) (metavcoin.Cost.Extracted.autoInc 346L ((64L + (64L + ((128L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 3L))) + 25L)))
end
| uu____388 -> begin
(metavcoin.ResultT.autoFailw ((64L + (64L + ((128L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 3L))) + 25L) "unsupported command"B)
end)
end)
end
| FStar.Pervasives.Native.None -> begin
(metavcoin.ResultT.autoFailw ((64L + (64L + ((128L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 3L))) + 25L) "returnAddress is required"B)
end)))))


let cf = (fun ( uu____468  :  'Auu____428 ) ( uu____469  :  'Auu____429 ) ( uu____470  :  'Auu____430 ) ( uu____471  :  'Auu____431 ) ( uu____472  :  'Auu____432 ) ( wallet  :  metavcoin.Types.Realized.wallet ) ( uu____474  :  'Auu____433 ) -> (metavcoin.Cost.Realized.inc 0L 28L (metavcoin.Base.op_Bar_Greater ((70L + ((64L + (64L + ((128L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 3L))) + 25L)) + 31L) metavcoin.Cost.Realized.ret)))


let mainFunction : metavcoin.Types.Main.mainFunction = metavcoin.Types.Main.MainFunc (metavcoin.Types.Main.CostFunc (28L, cf), main)




