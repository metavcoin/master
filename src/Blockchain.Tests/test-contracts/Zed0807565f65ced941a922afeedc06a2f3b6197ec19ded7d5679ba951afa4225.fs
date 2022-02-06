#light "off"
module Zed0807565f65ced941a922afeedc06a2f3b6197ec19ded7d5679ba951afa4225
open Prims
open FStar.Pervasives

let buy : metavcoin.Types.Realized.txSkeleton  ->  metavcoin.Types.Extracted.contractId  ->  metavcoin.Types.Extracted.lock  ->  (metavcoin.Types.Main.contractReturn FStar.Pervasives.result, unit) metavcoin.Cost.Realized.cost = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( returnAddress  :  metavcoin.Types.Extracted.lock ) -> (metavcoin.Cost.Realized.inc 320L 27L (metavcoin.Cost.Extracted.letBang 64L 256L (metavcoin.Asset.getDefault contractId) (fun ( contractToken  :  metavcoin.Types.Extracted.asset ) -> (metavcoin.Cost.Extracted.letBang 64L 192L (metavcoin.TxSkeleton.getAvailableTokens metavcoin.Asset.metavcoinAsset txSkeleton) (fun ( amount  :  FStar.UInt64.t ) -> (metavcoin.Cost.Extracted.letBang 192L 0L (metavcoin.Cost.Realized.bind 128L 64L (metavcoin.Cost.Realized.bind 64L 64L (metavcoin.TxSkeleton.lockToContract metavcoin.Asset.metavcoinAsset amount contractId txSkeleton) (metavcoin.TxSkeleton.mint amount contractToken)) (metavcoin.TxSkeleton.lockToAddress contractToken amount returnAddress)) (fun ( txSkeleton1  :  metavcoin.Types.Realized.txSkeleton ) -> (metavcoin.Base.op_At (metavcoin.ResultT.ok ()) {metavcoin.Types.Main.tx = txSkeleton1; metavcoin.Types.Main.message = FStar.Pervasives.Native.None; metavcoin.Types.Main.state = metavcoin.Types.Main.NoChange})))))))))


let redeem : metavcoin.Types.Realized.txSkeleton  ->  metavcoin.Types.Extracted.contractId  ->  metavcoin.Types.Extracted.lock  ->  metavcoin.Types.Realized.wallet  ->  (metavcoin.Types.Main.contractReturn FStar.Pervasives.result, unit) metavcoin.Cost.Realized.cost = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( returnAddress  :  metavcoin.Types.Extracted.lock ) ( wallet  :  metavcoin.Types.Realized.wallet ) -> (metavcoin.Cost.Realized.inc (64L + (64L + ((128L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 0L))) 33L (metavcoin.Cost.Extracted.letBang 64L (64L + ((128L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 0L)) (metavcoin.Asset.getDefault contractId) (fun ( contractToken  :  metavcoin.Types.Extracted.asset ) -> (metavcoin.Cost.Extracted.letBang 64L ((128L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 0L) (metavcoin.TxSkeleton.getAvailableTokens contractToken txSkeleton) (fun ( amount  :  FStar.UInt64.t ) -> (metavcoin.Cost.Extracted.letBang (128L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) 0L (metavcoin.Cost.Realized.bind 128L ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L) (metavcoin.Cost.Realized.bind 64L 64L (metavcoin.TxSkeleton.destroy amount contractToken txSkeleton) (metavcoin.TxSkeleton.lockToAddress metavcoin.Asset.metavcoinAsset amount returnAddress)) (metavcoin.TxSkeleton.fromWallet metavcoin.Asset.metavcoinAsset amount contractId wallet)) (fun ( txSkeleton1  :  metavcoin.Types.Realized.txSkeleton FStar.Pervasives.Native.option ) -> (

let result = (match (txSkeleton1) with
| FStar.Pervasives.Native.Some (tx) -> begin
(metavcoin.Base.op_At (fun ( _0_16  :  metavcoin.Types.Main.contractReturn ) -> FStar.Pervasives.Native.Some (_0_16)) {metavcoin.Types.Main.tx = tx; metavcoin.Types.Main.message = FStar.Pervasives.Native.None; metavcoin.Types.Main.state = metavcoin.Types.Main.NoChange})
end
| FStar.Pervasives.Native.None -> begin
FStar.Pervasives.Native.None
end)
in (metavcoin.ResultT.ofOption "contract doesn\'t have enough metavcoins tokens"B result))))))))))


let main = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( uu____357  :  'Auu____307 ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( command  :  Prims.string ) ( sender  :  'Auu____308 ) ( messageBody  :  metavcoin.Types.Data.data FStar.Pervasives.Native.option ) ( wallet  :  metavcoin.Types.Realized.wallet ) ( state  :  'Auu____309 ) -> (metavcoin.Cost.Realized.inc (70L + ((64L + (64L + ((128L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 0L))) + 33L)) 31L (metavcoin.Cost.Extracted.letBang 70L ((64L + (64L + ((128L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 0L))) + 33L) (metavcoin.Data.op_Greater_Question_Equals 68L 2L (metavcoin.Data.op_Greater_Question_Equals 4L 64L (metavcoin.Data.op_Greater_Bang_Equals 4L messageBody metavcoin.Data.tryDict) (metavcoin.Dictionary.tryFind "returnAddress"B)) metavcoin.Data.tryLock) (fun ( returnAddress  :  metavcoin.Types.Extracted.lock FStar.Pervasives.Native.option ) -> (match (returnAddress) with
| FStar.Pervasives.Native.Some (returnAddress1) -> begin
(match ((Prims.op_Equality command "redeem"B)) with
| true -> begin
(redeem txSkeleton contractId returnAddress1 wallet)
end
| uu____410 -> begin
(match (((Prims.op_Equality command ""B) || (Prims.op_Equality command "buy"B))) with
| true -> begin
(metavcoin.Base.op_Bar_Greater (buy txSkeleton contractId returnAddress1) (metavcoin.Cost.Extracted.autoInc 347L ((64L + (64L + ((128L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 0L))) + 33L)))
end
| uu____445 -> begin
(metavcoin.ResultT.autoFailw ((64L + (64L + ((128L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 0L))) + 33L) "unsupported command"B)
end)
end)
end
| FStar.Pervasives.Native.None -> begin
(metavcoin.ResultT.autoFailw ((64L + (64L + ((128L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 0L))) + 33L) "returnAddress is required"B)
end)))))


let cf = (fun ( uu____525  :  'Auu____485 ) ( uu____526  :  'Auu____486 ) ( uu____527  :  'Auu____487 ) ( uu____528  :  'Auu____488 ) ( uu____529  :  'Auu____489 ) ( wallet  :  metavcoin.Types.Realized.wallet ) ( uu____531  :  'Auu____490 ) -> (metavcoin.Cost.Realized.inc 0L 30L (metavcoin.Base.op_Bar_Greater (metavcoin.Base.op_Bar_Greater ((70L + ((64L + (64L + ((128L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 0L))) + 33L)) + 31L) metavcoin.Base.cast) metavcoin.Cost.Realized.ret)))


let mainFunction : metavcoin.Types.Main.mainFunction = metavcoin.Types.Main.MainFunc (metavcoin.Types.Main.CostFunc (30L, cf), main)




