#light "off"
module Testae5af2bf34a58745768c401d5c95060cd5cebc50a12d107b47e9517e0c7f8784
open Prims
open FStar.Pervasives

let main = (fun ( tx  :  metavcoin.Types.Realized.txSkeleton ) ( uu____94  :  'Auu____46 ) ( uu____95  :  'Auu____47 ) ( uu____96  :  'Auu____48 ) ( uu____97  :  'Auu____49 ) ( uu____98  :  'Auu____50 ) ( uu____99  :  'Auu____51 ) ( uu____100  :  'Auu____52 ) -> (metavcoin.Cost.Realized.inc 0L 5L (metavcoin.Base.op_At (metavcoin.ResultT.ok ()) {metavcoin.Types.Main.tx = tx; metavcoin.Types.Main.message = FStar.Pervasives.Native.None; metavcoin.Types.Main.state = metavcoin.Types.Main.NoChange})))


let cf = (fun ( uu____194  :  'Auu____153 ) ( uu____195  :  'Auu____154 ) ( uu____196  :  'Auu____155 ) ( uu____197  :  'Auu____156 ) ( uu____198  :  'Auu____157 ) ( uu____199  :  'Auu____158 ) ( uu____200  :  'Auu____159 ) -> (metavcoin.Cost.Realized.inc 0L 7L (metavcoin.Base.op_Bar_Greater (metavcoin.Base.op_Bar_Greater 5L metavcoin.Base.cast) metavcoin.Cost.Realized.ret)))


let mainFunction : metavcoin.Types.Main.mainFunction = metavcoin.Types.Main.MainFunc (metavcoin.Types.Main.CostFunc (7L, cf), main)




