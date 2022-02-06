module Consensus.Tests.AssetTests

open Consensus
open Consensus.Types
open Consensus.Tests
open NUnit.Framework
open FsCheck
open FsCheck.NUnit
open FsUnit
open TestsInfrastructure.Constraints

[<Property(Arbitrary=[| typeof<ConsensusGenerator> |])>]
let ``to and from string yield same asset``(asset:Asset) =
    let b16 = (Asset.toString asset)
    let asset' = Asset.fromString b16

    Some asset = asset'

[<Property(Arbitrary=[| typeof<ConsensusGenerator> |])>]
let ``to and from string with default subtype``(cHash:Hash.Hash) =
    let asset = Asset (ContractId (Version0, cHash),Hash.zero)

    let b16 = (Asset.toString asset)
    let asset' = Asset.fromString b16

    Some asset = asset'

[<Test>]
let ``from metavcoin special string``() =
    let asset = Asset.fromString "00"

    asset |> should equal (Some Asset.metavcoin)

[<Test>]
let ``metavcoin token to string yield 00``() =
    Asset.toString Asset.metavcoin |> should equal "00"