module Testae5af2bf34a58745768c401d5c95060cd5cebc50a12d107b47e9517e0c7f8784

    open metavcoin.Types
    open metavcoin.Base
    open metavcoin.Cost
    open metavcoin.ResultT

    module C = metavcoin.Cost
    
    let main tx _ _ _ _ _ _ _ =
        ok @ { tx = tx; message = None; state = NoChange }

    let cf _ _ _ _ _ _ _ = 
        0 + 5
        |> cast nat
        |> C.ret
    