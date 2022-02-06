module Infrastructure.Tests.ZFStar

open NUnit.Framework
open Infrastructure
open FsUnit
open Exception
open metavcoin.Types.Extracted
open metavcoin.Types.Realized
open metavcoin.TxSkeleton
open FStar.Pervasives
open Microsoft.FSharp.Core
open metavcoin.Cost.Realized
open System.Text
open Org.BouncyCastle.Crypto.Digests
open FsBech32
open metavcoin.Types.Main

let assemblyDirectory =
    System.IO.Path.Combine
        [| System.IO.Path.GetTempPath(); System.IO.Path.GetRandomFileName() |]

[<Literal>]
let rlimit = 2723280u

type Message = {
    cHash: byte[]
    command: string
}

let clean() =
    Platform.cleanDirectory assemblyDirectory

[<SetUp>]
let setup = fun () ->
    clean()

[<TearDown>]
let tearDown = fun () ->
    clean()

let shouldBeOk value = function
    | Ok value' -> should equal value value'
    | Error err -> failwith err

let shouldBeError err = function
    | Ok value' -> failwith (value'.ToString())
    | Error err' -> should equal err err'

let input : txSkeleton =
    emptyTxSkeleton

let computeHash bytes =
    let hash = Array.zeroCreate 32
    let sha3 = new Sha3Digest(256)
    sha3.BlockUpdate(bytes,0,Array.length bytes)
    sha3.DoFinal(hash, 0) |> ignore
    hash

let getModuleName (code : string) =
    code
    |> Encoding.UTF8.GetBytes
    |> computeHash
    |> Base16.encode
    |> (+) "Test"

let compile fstCode =
    let moduleName = getModuleName fstCode
    ZFStar.recordHints rlimit fstCode moduleName
    |> Result.bind (fun hints -> ZFStar.compile assemblyDirectory fstCode hints rlimit moduleName)
    |> Result.bind (fun _ -> ZFStar.load assemblyDirectory moduleName)

let fstCode = """
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
    """

[<Test>]
let ``Should record hints``() =
    ZFStar.recordHints rlimit fstCode (getModuleName fstCode)
    |> Result.map (fun _ -> ())
    |> shouldBeOk ()

[<Test>]
let ``Should compile``() =
    compile fstCode
    |> Result.map (fun _ -> ())
    |> shouldBeOk ()

[<Test>]
let ``Should get some metrics from hints module``() =
    ZFStar.recordHints rlimit fstCode (getModuleName fstCode)
    |> Result.bind ZFStar.calculateMetrics
    |> Result.map (fun (maxFuel, maxIFuel) -> maxFuel > 0 && maxIFuel > 0)
    |> shouldBeOk true
