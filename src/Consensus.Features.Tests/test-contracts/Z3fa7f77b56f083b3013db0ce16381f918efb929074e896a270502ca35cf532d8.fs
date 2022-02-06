#light "off"
module Z3fa7f77b56f083b3013db0ce16381f918efb929074e896a270502ca35cf532d8
open Prims
open FStar.Pervasives

let main = (fun ( txSkeleton  :  metavcoin.Types.Realized.txSkeleton ) ( uu____101  :  'Auu____49 ) ( contractId  :  metavcoin.Types.Extracted.contractId ) ( uu____103  :  'Auu____50 ) ( uu____104  :  'Auu____51 ) ( uu____105  :  'Auu____52 ) ( uu____106  :  'Auu____53 ) ( state  :  metavcoin.Types.Data.data FStar.Pervasives.Native.option ) -> (metavcoin.Cost.Realized.inc 194L 36L (metavcoin.Cost.Extracted.letBang 64L 130L (metavcoin.Asset.getDefault contractId) (fun ( asset  :  metavcoin.Types.Extracted.asset ) -> (

let spend = {metavcoin.Types.Extracted.asset = asset; metavcoin.Types.Extracted.amount = (FStar.UInt64.uint_to_t 1000L)}
in (

let lock = metavcoin.Types.Extracted.ContractLock (contractId)
in (

let output = {metavcoin.Types.Extracted.lock = lock; metavcoin.Types.Extracted.spend = spend}
in (

let pInput = metavcoin.Types.Extracted.Mint (spend)
in (metavcoin.Cost.Extracted.letBang 128L 2L (metavcoin.Cost.Realized.bind 64L 64L (metavcoin.TxSkeleton.addInput pInput txSkeleton) (metavcoin.TxSkeleton.lockToContract spend.asset spend.amount contractId)) (fun ( txSkeleton1  :  metavcoin.Types.Realized.txSkeleton ) -> (metavcoin.Cost.Extracted.letBang 2L 0L (metavcoin.Data.op_Greater_Bang_Equals 2L state metavcoin.Data.tryU32) (fun ( counter  :  FStar.UInt32.t FStar.Pervasives.Native.option ) -> (

let updatedCounter = (match (counter) with
| FStar.Pervasives.Native.Some (counter1) -> begin
(FStar.UInt32.add_mod counter1 (FStar.UInt32.uint_to_t 1L))
end
| FStar.Pervasives.Native.None -> begin
(FStar.UInt32.uint_to_t 10L)
end)
in (metavcoin.Base.op_At (metavcoin.ResultT.ok ()) {metavcoin.Types.Main.tx = txSkeleton1; metavcoin.Types.Main.message = FStar.Pervasives.Native.None; metavcoin.Types.Main.state = metavcoin.Types.Main.Update (metavcoin.Types.Data.U32 (updatedCounter))}))))))))))))))


let cf = (fun ( uu____298  :  'Auu____257 ) ( uu____299  :  'Auu____258 ) ( uu____300  :  'Auu____259 ) ( uu____301  :  'Auu____260 ) ( uu____302  :  'Auu____261 ) ( uu____303  :  'Auu____262 ) ( uu____304  :  'Auu____263 ) -> (metavcoin.Cost.Realized.inc 0L 15L (metavcoin.Base.op_Bar_Greater (metavcoin.Base.op_Bar_Greater 230L metavcoin.Base.cast) metavcoin.Cost.Realized.ret)))


let mainFunction : metavcoin.Types.Main.mainFunction = metavcoin.Types.Main.MainFunc (metavcoin.Types.Main.CostFunc (15L, cf), main)




