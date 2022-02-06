module Consensus.Tests.Helper

open Consensus
open Crypto
open Wallet
open TestWallet
open Infrastructure
open Consensus.Types

let rootMnemonicPhrase = "feel muffin volcano click mercy abuse bachelor ginger limb tomorrow okay input spend athlete boring security document exclude liar dune usage camera ranch thought"

let rootExtendedKey = ExtendedKey.fromMnemonicPhrase rootMnemonicPhrase |> Result.get

let rootPublicKey = TestWallet.derivemetavcoinKey rootExtendedKey |> Result.get |> ExtendedKey.getPublicKey |> Result.get

let rootChangePublicKey = TestWallet.deriveChangemetavcoinKey rootExtendedKey |> Result.get |> ExtendedKey.getPublicKey |> Result.get

let rootPKHash = PublicKey.hash rootPublicKey

let rootChangePKHash = PublicKey.hash rootChangePublicKey

let private rng = new System.Security.Cryptography.RNGCryptoServiceProvider()

let create() : TestWallet.T * ExtendedKey.T  =

    let seed = Array.create 32 0uy
    rng.GetBytes (seed)

    let extendedKey = ExtendedKey.create seed                    |> Result.get
    let metavcoinKey = TestWallet.derivemetavcoinKey extendedKey             |> Result.get
    let metavcoinChangeKey = TestWallet.deriveChangemetavcoinKey extendedKey |> Result.get

    {
        deltas = List.empty
        outputs = Map.empty
        publicKey = ExtendedKey.getPublicKey metavcoinKey |> Result.get
        publicKeyChange = ExtendedKey.getPublicKey metavcoinChangeKey |> Result.get
        mempool = List.empty
        tip = Hash.zero
        blockNumber = 0ul
        cgp = CGP.empty
    }, extendedKey

let rootAccountData =
    {
        deltas = List.empty
        cgp = CGP.empty
        outputs = Map.empty
        publicKey = rootPublicKey
        publicKeyChange = rootChangePublicKey
        tip = Hash.zero
        mempool= List.empty
        blockNumber=0ul
    }, rootExtendedKey

let addTransaction txHash tx accountData =
    let account = addTransaction txHash tx (fst accountData)
    account, snd accountData

let rootAmount = 100_000_000_000UL

let rootTx =
    {
        version = Version0
        inputs=[];
        outputs=[{lock = PK rootPKHash; spend= {asset = Asset.metavcoin;amount=rootAmount}}];
        witnesses=[]
        contract=None
    }

let rootTxExtended = Transaction.toExtended rootTx

let rootTxHash = Transaction.hash rootTx

let createTestAccount () =
    rootAccountData
    |> addTransaction rootTxHash rootTx
    
let createTestAccounts numberOfAccount : List<TestWallet.T * ExtendedKey.T> =
    [0..numberOfAccount]
    |> List.map (fun _ -> create ())

let publicKeyHash account =
    PublicKey.hash account.publicKey
    
let publicKeyChangeHash account =
    PublicKey.hash account.publicKeyChange

let getSecretKey extendedKey = TestWallet.derivemetavcoinKey extendedKey |> Result.get |> ExtendedKey.getPrivateKey |> Result.get

let rootKeyPair =
    (TestWallet.derivemetavcoinKey rootExtendedKey |> Result.get |> ExtendedKey.getPrivateKey |> Result.get, rootPublicKey)

let rootChangeKeyPair =
    (TestWallet.deriveChangemetavcoinKey rootExtendedKey |> Result.get |> ExtendedKey.getPrivateKey |> Result.get, rootChangePublicKey)

