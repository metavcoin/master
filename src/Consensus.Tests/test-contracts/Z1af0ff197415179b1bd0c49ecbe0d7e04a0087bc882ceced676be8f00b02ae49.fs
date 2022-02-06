#light "off"
module Z1af0ff197415179b1bd0c49ecbe0d7e04a0087bc882ceced676be8f00b02ae49
open Prims
open FStar.Pervasives

let maxOutputs : Prims.nat = 100L


let payoutBlock : Prims.nat = 10L


let intervalLength : Prims.nat = 100L


let rec tryMap = (fun ( n  :  Prims.nat ) ( f  :  'Aa  ->  ('Ab FStar.Pervasives.Native.option, unit) metavcoin.Cost.Realized.cost ) ( ls  :  'Aa Prims.list ) -> (metavcoin.Cost.Realized.inc (Prims.op_Star (Prims.length ls) (n + 20L)) 20L (match (ls) with
| Prims.Cons (hd, tl) -> begin
(metavcoin.Cost.Extracted.letBang n (((Prims.op_Star (Prims.length tl) (n + 20L)) + 20L) + 0L) (f hd) (fun ( hd'  :  'Ab FStar.Pervasives.Native.option ) -> (metavcoin.Cost.Extracted.letBang ((Prims.op_Star (Prims.length tl) (n + 20L)) + 20L) 0L (tryMap n f tl) (fun ( tl'  :  'Ab Prims.list FStar.Pervasives.Native.option ) -> (match (((hd'), (tl'))) with
| (FStar.Pervasives.Native.Some (hd'1), FStar.Pervasives.Native.Some (tl'1)) -> begin
(

let result = Prims.Cons (hd'1, tl'1)
in ((metavcoin.OptionT.some ()) result))
end
| uu____223 -> begin
(metavcoin.OptionT.none ())
end)))))
end
| Prims.Nil -> begin
(metavcoin.Base.op_Bar_Greater Prims.Nil (metavcoin.OptionT.incSome (Prims.op_Star (Prims.length ls) (n + 20L))))
end)))


let rec tryFold = (fun ( n  :  Prims.nat ) ( f  :  'Ab  ->  'Aa  ->  ('Ab FStar.Pervasives.Native.option, unit) metavcoin.Cost.Realized.cost ) ( x  :  'Ab ) ( ls  :  'Aa Prims.list ) -> (metavcoin.Cost.Realized.inc (Prims.op_Star (Prims.length ls) (n + 12L)) 10L (match (ls) with
| Prims.Nil -> begin
(metavcoin.OptionT.incSome (Prims.op_Star (Prims.length ls) (n + 12L)) x)
end
| Prims.Cons (hd, tl) -> begin
(metavcoin.OptionT.op_Greater_Greater_Equals ((Prims.op_Star (Prims.length tl) (n + 12L)) + 10L) (n + 2L) (tryFold n f x tl) (fun ( r  :  'Ab ) -> (metavcoin.Cost.Realized.inc n 2L (f r hd))))
end)))


let parseDict : metavcoin.Types.Data.data FStar.Pervasives.Native.option  ->  (metavcoin.Types.Data.data metavcoin.Dictionary.t FStar.Pervasives.Native.option FStar.Pervasives.result, unit) metavcoin.Cost.Realized.cost = (fun ( data  :  metavcoin.Types.Data.data FStar.Pervasives.Native.option ) -> (metavcoin.Cost.Realized.inc 4L 11L (match (data) with
| FStar.Pervasives.Native.Some (data1) -> begin
(metavcoin.Base.op_Bar_Greater (metavcoin.Base.op_Bar_Greater (metavcoin.Base.op_Bar_Greater data1 metavcoin.Data.tryDict) (metavcoin.ResultT.ofOptionT 4L "Data parsing failed - the message body isn\'t a dictionary"B)) (metavcoin.ResultT.map 4L (fun ( _0_18  :  metavcoin.Types.Data.data metavcoin.Dictionary.t ) -> FStar.Pervasives.Native.Some (_0_18))))
end
| FStar.Pervasives.Native.None -> begin
(metavcoin.ResultT.incFailw 4L "Data parsing failed - the message body is empty"B)
end)))


let parseField = (fun ( uu____558  :  Prims.nat ) ( parser  :  metavcoin.Types.Data.data  ->  ('Auu____510 FStar.Pervasives.Native.option, unit) metavcoin.Cost.Realized.cost ) ( fieldName  :  Prims.string ) ( errMsg  :  Prims.string ) ( dict  :  metavcoin.Types.Data.data metavcoin.Dictionary.t FStar.Pervasives.Native.option ) -> (metavcoin.Cost.Realized.inc ((64L + uu____558) + 0L) 11L (metavcoin.Cost.Extracted.letBang (64L + uu____558) 0L (metavcoin.Data.op_Greater_Question_Equals 64L uu____558 (metavcoin.Data.op_Greater_Bang_Equals 64L dict (metavcoin.Dictionary.tryFind fieldName)) parser) (fun ( value  :  'Auu____510 FStar.Pervasives.Native.option ) -> (match (value) with
| FStar.Pervasives.Native.Some (value1) -> begin
((metavcoin.ResultT.ok ()) value1)
end
| FStar.Pervasives.Native.None -> begin
((metavcoin.ResultT.failw ()) errMsg)
end)))))


let extractSpend : metavcoin.Types.Data.data Prims.list  ->  (metavcoin.Types.Extracted.spend FStar.Pervasives.Native.option, unit) metavcoin.Cost.Realized.cost = (fun ( ls  :  metavcoin.Types.Data.data Prims.list ) -> (metavcoin.Cost.Realized.inc 73L 11L (match (ls) with
| Prims.Cons (asset', Prims.Cons (amount', Prims.Nil)) -> begin
(

let sAsset = (metavcoin.Data.tryString asset')
in (

let oAsset = (metavcoin.OptionT.op_Greater_Greater_Equals 2L 64L sAsset metavcoin.Asset.parse)
in (

let oAmount = (metavcoin.Data.tryU64 amount')
in (metavcoin.OptionT.op_Greater_Greater_Equals 66L 7L oAsset (fun ( asset  :  metavcoin.Types.Extracted.asset ) -> (metavcoin.Cost.Realized.inc 5L 2L (metavcoin.OptionT.op_Greater_Greater_Equals 2L 3L oAmount (fun ( amount  :  FStar.UInt64.t ) -> (metavcoin.Cost.Realized.inc 0L 3L ((metavcoin.OptionT.ret ()) {metavcoin.Types.Extracted.asset = asset; metavcoin.Types.Extracted.amount = amount}))))))))))
end
| uu____723 -> begin
(metavcoin.OptionT.incNone 73L)
end)))


let trySpend : metavcoin.Types.Data.data  ->  (metavcoin.Types.Extracted.spend FStar.Pervasives.Native.option, unit) metavcoin.Cost.Realized.cost = (fun ( d  :  metavcoin.Types.Data.data ) -> (metavcoin.Cost.Realized.inc 88L 3L (metavcoin.OptionT.op_Greater_Greater_Equals 4L 84L (metavcoin.Data.tryList d) extractSpend)))


let extractOutput : metavcoin.Types.Data.data Prims.list  ->  (metavcoin.Types.Extracted.output FStar.Pervasives.Native.option, unit) metavcoin.Cost.Realized.cost = (fun ( ls  :  metavcoin.Types.Data.data Prims.list ) -> (metavcoin.Cost.Realized.inc 98L 9L (match (ls) with
| Prims.Cons (lock', Prims.Cons (spend', Prims.Nil)) -> begin
(

let oLock = (metavcoin.Data.tryLock lock')
in (

let oSpend = (trySpend spend')
in (metavcoin.OptionT.op_Greater_Greater_Equals 2L 96L oLock (fun ( lock  :  metavcoin.Types.Extracted.lock ) -> (metavcoin.Cost.Realized.inc 94L 2L (metavcoin.OptionT.op_Greater_Greater_Equals 91L 3L oSpend (fun ( spend  :  metavcoin.Types.Extracted.spend ) -> (metavcoin.Cost.Realized.inc 0L 3L ((metavcoin.OptionT.ret ()) {metavcoin.Types.Extracted.lock = lock; metavcoin.Types.Extracted.spend = spend})))))))))
end
| uu____803 -> begin
(metavcoin.OptionT.incNone 98L)
end)))


let tryOutput : metavcoin.Types.Data.data  ->  (metavcoin.Types.Extracted.output FStar.Pervasives.Native.option, unit) metavcoin.Cost.Realized.cost = (fun ( d  :  metavcoin.Types.Data.data ) -> (metavcoin.Cost.Realized.inc 111L 3L (metavcoin.OptionT.op_Greater_Greater_Equals 4L 107L (metavcoin.Data.tryList d) extractOutput)))


let extractOutputList : metavcoin.Types.Data.data Prims.list  ->  (metavcoin.Types.Extracted.output Prims.list FStar.Pervasives.Native.option, unit) metavcoin.Cost.Realized.cost = (fun ( ls  :  metavcoin.Types.Data.data Prims.list ) -> (metavcoin.Cost.Realized.inc ((Prims.op_Star (Prims.length ls) 134L) + 20L) 2L (tryMap 114L tryOutput ls)))


let toBounded : Prims.nat  ->  metavcoin.Types.Data.data Prims.list  ->  (metavcoin.Types.Data.data Prims.list FStar.Pervasives.Native.option, unit) metavcoin.Cost.Realized.cost = (fun ( size1  :  Prims.nat ) ( ls  :  metavcoin.Types.Data.data Prims.list ) -> (metavcoin.Cost.Realized.inc 0L 7L (match (((Prims.length ls) <= size1)) with
| true -> begin
((metavcoin.OptionT.ret ()) ls)
end
| uu____902 -> begin
(metavcoin.OptionT.none ())
end)))


let extractOutputListBounded : Prims.nat  ->  metavcoin.Types.Data.data Prims.list  ->  (metavcoin.Types.Extracted.output Prims.list FStar.Pervasives.Native.option, unit) metavcoin.Cost.Realized.cost = (fun ( size1  :  Prims.nat ) ( ls  :  metavcoin.Types.Data.data Prims.list ) -> (metavcoin.Cost.Realized.inc ((Prims.op_Star size1 134L) + 22L) 11L (metavcoin.Base.op_Bar_Greater (metavcoin.OptionT.op_Dollar_Greater ((Prims.op_Star (Prims.length ls) 134L) + 22L) (extractOutputList ls) (fun ( ls'  :  metavcoin.Types.Extracted.output Prims.list ) -> ls')) (metavcoin.Cost.Realized.inc ((Prims.op_Star (Prims.length ls) 134L) + 22L) (Prims.op_Star (size1 - (Prims.length ls)) 134L)))))


let parseRawOutputs : metavcoin.Types.Data.data metavcoin.Dictionary.t FStar.Pervasives.Native.option  ->  (metavcoin.Types.Data.data Prims.list FStar.Pervasives.result, unit) metavcoin.Cost.Realized.cost = (fun ( dict  :  metavcoin.Types.Data.data metavcoin.Dictionary.t FStar.Pervasives.Native.option ) -> (metavcoin.Cost.Realized.inc 79L 4L (parseField 4L metavcoin.Data.tryList "Outputs"B "Couldn\'t parse Outputs"B dict)))


let parseOutputs : Prims.nat  ->  metavcoin.Types.Data.data metavcoin.Dictionary.t FStar.Pervasives.Native.option  ->  (metavcoin.Types.Extracted.output Prims.list FStar.Pervasives.result, unit) metavcoin.Cost.Realized.cost = (fun ( size1  :  Prims.nat ) ( dict  :  metavcoin.Types.Data.data metavcoin.Dictionary.t FStar.Pervasives.Native.option ) -> (metavcoin.Cost.Realized.inc (90L + (((Prims.op_Star size1 134L) + 22L) + 11L)) 15L (metavcoin.ResultT.op_Greater_Greater_Equals 90L (((Prims.op_Star size1 134L) + 22L) + 11L) (metavcoin.ResultT.op_Greater_Greater_Equals 83L 7L (metavcoin.ResultT.op_Greater_Greater_Equals 0L 83L ((metavcoin.ResultT.ret ()) dict) parseRawOutputs) (metavcoin.Base.op_Greater_Greater (toBounded size1) (metavcoin.ResultT.ofOptionT 7L "Outputs list is too long"B))) (metavcoin.Base.op_Greater_Greater (extractOutputListBounded size1) (metavcoin.ResultT.ofOptionT (((Prims.op_Star size1 134L) + 22L) + 11L) "Invalid outputs structure"B)))))


let lockOutput : metavcoin.Types.Extracted.contractId  ->  metavcoin.Types.Realized.wallet  ->  metavcoin.Types.Realized.txSkeleton  ->  metavcoin.Types.Extracted.output  ->  (metavcoin.Types.Realized.txSkeleton FStar.Pervasives.Native.option, unit) metavcoin.Cost.Realized.cost = (fun ( contractId  :  metavcoin.Types.Extracted.contractId ) ( w  :  metavcoin.Types.Realized.wallet ) ( txSkel  :  metavcoin.Types.Realized.txSkeleton ) ( outp  :  metavcoin.Types.Extracted.output ) -> (metavcoin.Cost.Realized.inc ((0L + ((Prims.op_Star (metavcoin.Wallet.size w) 128L) + 192L)) + 64L) 19L (

let asset = outp.spend.asset
in (

let amount = outp.spend.amount
in (metavcoin.OptionT.op_Greater_Greater_Equals (0L + ((Prims.op_Star (metavcoin.Wallet.size w) 128L) + 192L)) 64L (metavcoin.OptionT.op_Greater_Greater_Equals 0L ((Prims.op_Star (metavcoin.Wallet.size w) 128L) + 192L) ((metavcoin.OptionT.ret ()) txSkel) (metavcoin.TxSkeleton.fromWallet asset amount contractId w)) (metavcoin.Base.op_Greater_Greater (metavcoin.TxSkeleton.lockToAddress asset amount outp.lock) (metavcoin.OptionT.liftCost 64L)))))))


let lockOutputs : metavcoin.Types.Extracted.contractId  ->  metavcoin.Types.Realized.wallet  ->  metavcoin.Types.Realized.txSkeleton  ->  metavcoin.Types.Extracted.output Prims.list  ->  (metavcoin.Types.Realized.txSkeleton FStar.Pervasives.Native.option, unit) metavcoin.Cost.Realized.cost = (fun ( contractId  :  metavcoin.Types.Extracted.contractId ) ( w  :  metavcoin.Types.Realized.wallet ) ( txSkel  :  metavcoin.Types.Realized.txSkeleton ) ( ls  :  metavcoin.Types.Extracted.output Prims.list ) -> (metavcoin.Cost.Realized.inc ((Prims.op_Star (Prims.length ls) (((((Prims.op_Star (metavcoin.Wallet.size w) 128L) + 192L) + 64L) + 19L) + 12L)) + 10L) 5L (tryFold ((((Prims.op_Star (metavcoin.Wallet.size w) 128L) + 192L) + 64L) + 19L) (lockOutput contractId w) txSkel ls)))


let lockOutputsBounded : Prims.nat  ->  metavcoin.Types.Extracted.contractId  ->  metavcoin.Types.Realized.wallet  ->  metavcoin.Types.Realized.txSkeleton  ->  metavcoin.Types.Extracted.output Prims.list  ->  (metavcoin.Types.Realized.txSkeleton FStar.Pervasives.Native.option, unit) metavcoin.Cost.Realized.cost = (fun ( size1  :  Prims.nat ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( w  :  metavcoin.Types.Realized.wallet ) ( txSkel  :  metavcoin.Types.Realized.txSkeleton ) ( ls  :  metavcoin.Types.Extracted.output Prims.list ) -> (metavcoin.Cost.Realized.inc (((Prims.op_Star size1 (((((Prims.op_Star (metavcoin.Wallet.size w) 128L) + 192L) + 64L) + 19L) + 12L)) + 10L) + 5L) 23L (metavcoin.Base.op_Bar_Greater (lockOutputs contractId w txSkel ls) (metavcoin.Cost.Realized.inc (((Prims.op_Star (Prims.length ls) (((((Prims.op_Star (metavcoin.Wallet.size w) 128L) + 192L) + 64L) + 19L) + 12L)) + 10L) + 5L) (Prims.op_Star (size1 - (Prims.length ls)) (((((Prims.op_Star (metavcoin.Wallet.size w) 128L) + 192L) + 64L) + 19L) + 12L))))))


let isPayoutBlock : metavcoin.Types.Main.context  ->  (Prims.bool, unit) metavcoin.Cost.Realized.cost = (fun ( context  :  metavcoin.Types.Main.context ) -> (metavcoin.Cost.Realized.inc 0L 9L (

let r = (FStar.UInt32.rem context.blockNumber (FStar.UInt32.uint_to_t intervalLength))
in (metavcoin.Base.op_Bar_Greater (FStar.UInt32.eq r (FStar.UInt32.uint_to_t payoutBlock)) metavcoin.Cost.Realized.ret))))


let validateBlockNumber : metavcoin.Types.Main.context  ->  metavcoin.Types.Realized.txSkeleton  ->  (metavcoin.Types.Realized.txSkeleton FStar.Pervasives.result, unit) metavcoin.Cost.Realized.cost = (fun ( context  :  metavcoin.Types.Main.context ) ( txSkel  :  metavcoin.Types.Realized.txSkeleton ) -> (metavcoin.Cost.Realized.inc 9L 7L (metavcoin.Cost.Extracted.letBang 9L 0L (isPayoutBlock context) (fun ( b  :  Prims.bool ) -> (match (b) with
| true -> begin
((metavcoin.ResultT.ret ()) txSkel)
end
| uu____1532 -> begin
((metavcoin.ResultT.failw ()) "Not a payout block"B)
end)))))


let main = (fun ( txSkel  :  metavcoin.Types.Realized.txSkeleton ) ( context  :  metavcoin.Types.Main.context ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( command  :  'Auu____1569 ) ( sender  :  'Auu____1570 ) ( messageBody  :  metavcoin.Types.Data.data FStar.Pervasives.Native.option ) ( w  :  metavcoin.Types.Realized.wallet ) ( state  :  'Auu____1571 ) -> (metavcoin.Cost.Realized.inc ((((15L + ((90L + (((Prims.op_Star maxOutputs 134L) + 22L) + 11L)) + 15L)) + ((((Prims.op_Star maxOutputs (((((Prims.op_Star (metavcoin.Wallet.size w) 128L) + 192L) + 64L) + 19L) + 12L)) + 10L) + 5L) + 23L)) + 16L) + 3L) 20L (metavcoin.ResultT.op_Greater_Greater_Equals (((15L + ((90L + (((Prims.op_Star maxOutputs 134L) + 22L) + 11L)) + 15L)) + ((((Prims.op_Star maxOutputs (((((Prims.op_Star (metavcoin.Wallet.size w) 128L) + 192L) + 64L) + 19L) + 12L)) + 10L) + 5L) + 23L)) + 16L) 3L (metavcoin.ResultT.op_Greater_Greater_Equals ((15L + ((90L + (((Prims.op_Star maxOutputs 134L) + 22L) + 11L)) + 15L)) + ((((Prims.op_Star maxOutputs (((((Prims.op_Star (metavcoin.Wallet.size w) 128L) + 192L) + 64L) + 19L) + 12L)) + 10L) + 5L) + 23L)) 16L (metavcoin.ResultT.op_Greater_Greater_Equals (15L + ((90L + (((Prims.op_Star maxOutputs 134L) + 22L) + 11L)) + 15L)) ((((Prims.op_Star maxOutputs (((((Prims.op_Star (metavcoin.Wallet.size w) 128L) + 192L) + 64L) + 19L) + 12L)) + 10L) + 5L) + 23L) (metavcoin.ResultT.op_Greater_Greater_Equals 15L ((90L + (((Prims.op_Star maxOutputs 134L) + 22L) + 11L)) + 15L) (metavcoin.ResultT.op_Greater_Greater_Equals 0L 15L ((metavcoin.ResultT.ret ()) messageBody) parseDict) (parseOutputs maxOutputs)) (metavcoin.Base.op_Greater_Greater (lockOutputsBounded maxOutputs contractId w txSkel) (metavcoin.ResultT.ofOptionT ((((Prims.op_Star maxOutputs (((((Prims.op_Star (metavcoin.Wallet.size w) 128L) + 192L) + 64L) + 19L) + 12L)) + 10L) + 5L) + 23L) "Insufficient funds"B))) (validateBlockNumber context)) metavcoin.ContractResult.ofTxSkel)))


let cf : metavcoin.Types.Realized.txSkeleton  ->  metavcoin.Types.Main.context  ->  Prims.string  ->  metavcoin.Types.Main.sender  ->  metavcoin.Types.Data.data FStar.Pervasives.Native.option  ->  metavcoin.Types.Realized.wallet  ->  metavcoin.Types.Data.data FStar.Pervasives.Native.option  ->  (Prims.nat, unit) metavcoin.Cost.Realized.cost = (fun ( uu____1720  :  metavcoin.Types.Realized.txSkeleton ) ( uu____1721  :  metavcoin.Types.Main.context ) ( uu____1722  :  Prims.string ) ( uu____1723  :  metavcoin.Types.Main.sender ) ( uu____1724  :  metavcoin.Types.Data.data FStar.Pervasives.Native.option ) ( w  :  metavcoin.Types.Realized.wallet ) ( uu____1726  :  metavcoin.Types.Data.data FStar.Pervasives.Native.option ) -> (metavcoin.Cost.Realized.inc 0L 43L (metavcoin.Base.op_Bar_Greater (((((15L + ((90L + (((Prims.op_Star maxOutputs 134L) + 22L) + 11L)) + 15L)) + ((((Prims.op_Star maxOutputs (((((Prims.op_Star (metavcoin.Wallet.size w) 128L) + 192L) + 64L) + 19L) + 12L)) + 10L) + 5L) + 23L)) + 16L) + 3L) + 20L) metavcoin.Cost.Realized.ret)))


let mainFunction : metavcoin.Types.Main.mainFunction = metavcoin.Types.Main.MainFunc (metavcoin.Types.Main.CostFunc (43L, cf), main)




