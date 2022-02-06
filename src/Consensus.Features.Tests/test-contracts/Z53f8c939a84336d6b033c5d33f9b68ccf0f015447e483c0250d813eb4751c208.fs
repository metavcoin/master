#light "off"
module Z53f8c939a84336d6b033c5d33f9b68ccf0f015447e483c0250d813eb4751c208
open Prims
open FStar.Pervasives

let cf = (fun ( uu____80  :  'Auu____40 ) ( uu____81  :  'Auu____41 ) ( uu____82  :  'Auu____42 ) ( uu____83  :  'Auu____43 ) ( uu____84  :  'Auu____44 ) ( wallet  :  metavcoin.Types.Realized.wallet ) ( uu____86  :  'Auu____45 ) -> (metavcoin.Cost.Realized.inc 0L 26L (metavcoin.Base.op_Bar_Greater (((70L + (((64L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 0L) + 13L)) + 5L) + 22L) metavcoin.Cost.Realized.ret)))


let get : metavcoin.Types.Realized.txSkeleton  ->  metavcoin.Types.Extracted.contractId  ->  metavcoin.Types.Realized.wallet  ->  metavcoin.Types.Extracted.lock  ->  (metavcoin.Types.Realized.txSkeleton FStar.Pervasives.result, unit) metavcoin.Cost.Realized.cost = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( wallet  :  metavcoin.Types.Realized.wallet ) ( returnAddress  :  metavcoin.Types.Extracted.lock ) -> (metavcoin.Cost.Realized.inc ((64L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 0L) 13L (metavcoin.Cost.Realized.bind (64L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) 0L (metavcoin.Cost.Realized.bind 64L ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L) (metavcoin.TxSkeleton.lockToAddress metavcoin.Asset.metavcoinAsset (FStar.UInt64.uint_to_t 10000L) returnAddress txSkeleton) (metavcoin.TxSkeleton.fromWallet metavcoin.Asset.metavcoinAsset (FStar.UInt64.uint_to_t 10000L) contractId wallet)) (metavcoin.ResultT.ofOption "contract doesn\'t have enough metavcoins to pay you"B))))


let init : metavcoin.Types.Realized.txSkeleton  ->  metavcoin.Types.Extracted.contractId  ->  (metavcoin.Types.Realized.txSkeleton, unit) metavcoin.Cost.Realized.cost = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( contractId  :  metavcoin.Types.Extracted.contractId ) -> (metavcoin.Cost.Realized.inc 128L 8L (metavcoin.Cost.Extracted.letBang 64L 64L (metavcoin.TxSkeleton.getAvailableTokens metavcoin.Asset.metavcoinAsset txSkeleton) (fun ( tokens  :  FStar.UInt64.t ) -> (metavcoin.TxSkeleton.lockToContract metavcoin.Asset.metavcoinAsset tokens contractId txSkeleton)))))


let main = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( uu____271  :  'Auu____221 ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( command  :  Prims.string ) ( uu____274  :  'Auu____222 ) ( messageBody  :  metavcoin.Types.Data.data FStar.Pervasives.Native.option ) ( wallet  :  metavcoin.Types.Realized.wallet ) ( uu____277  :  'Auu____223 ) -> (metavcoin.Cost.Realized.inc ((70L + (((64L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 0L) + 13L)) + 5L) 22L (metavcoin.ResultT.op_Greater_Greater_Equals (70L + (((64L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 0L) + 13L)) 5L (match ((Prims.op_disEquality command "init"B)) with
| true -> begin
(metavcoin.ResultT.op_Greater_Greater_Equals 70L (((64L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 0L) + 13L) (metavcoin.Base.op_Bar_Greater (metavcoin.Data.op_Greater_Question_Equals 68L 2L (metavcoin.Data.op_Greater_Question_Equals 4L 64L (metavcoin.Data.op_Greater_Bang_Equals 4L messageBody metavcoin.Data.tryDict) (metavcoin.Dictionary.tryFind "returnAddress"B)) metavcoin.Data.tryLock) (metavcoin.ResultT.ofOptionT 70L "returnAddress is required"B)) (get txSkeleton contractId wallet))
end
| uu____310 -> begin
(metavcoin.Base.op_Bar_Greater (metavcoin.Base.op_Bar_Greater (init txSkeleton contractId) (metavcoin.ResultT.liftCost 136L)) (metavcoin.Cost.Extracted.autoInc 136L (70L + (((64L + ((Prims.op_Star (metavcoin.Wallet.size wallet) 128L) + 192L)) + 0L) + 13L))))
end) (fun ( tx  :  metavcoin.Types.Realized.txSkeleton ) -> (metavcoin.Cost.Realized.inc 0L 5L (metavcoin.Base.op_At (metavcoin.ResultT.ok ()) {metavcoin.Types.Main.tx = tx; metavcoin.Types.Main.message = FStar.Pervasives.Native.None; metavcoin.Types.Main.state = metavcoin.Types.Main.NoChange}))))))


let mainFunction : metavcoin.Types.Main.mainFunction = metavcoin.Types.Main.MainFunc (metavcoin.Types.Main.CostFunc (26L, cf), main)




