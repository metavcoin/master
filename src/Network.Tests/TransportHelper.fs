module Network.Tests.TransportHelper

open Network
open Network.Transport
open FsNetMQ

let tempDir () = System.IO.Path.Combine
                    [| System.IO.Path.GetTempPath(); System.IO.Path.GetRandomFileName() |]

let address = "127.0.0.1:5556"
let addressBook = AddressBook.create (tempDir ())

let startHost () =
    let transport = Transport.create true address 0ul

    transport

let startPeer () =
    let transport = Transport.create false address 0ul
    Transport.connect transport address

    transport

let stopPeer peer =
    (peer :> System.IDisposable).Dispose()

let recvConnectedMessage peer timeout =
    match Transport.tryRecv peer timeout with
    | Some (InProcMessage.Connected {peerId=peerId}) ->
        peerId
    | Some (InProcMessage.Disconnected _) ->
        failwithf "connect failed, disconnect"
    | Some x ->
        failwithf "connect failed, unexpected %A" x
    | None ->
        failwith "connect failed"

let waitForConnectedMessage peer timeout =
    recvConnectedMessage peer timeout |> ignore

let waitForDisconnectedMessage peer timeout =
    match Transport.tryRecv peer timeout with
    | Some (InProcMessage.Disconnected _) ->
        ()
    | Some _
    | None ->
        failwith "no disconnect message"

let waitForAcceptedMessage peer timeout =
    match Transport.tryRecv peer timeout with
    | Some (InProcMessage.Accepted _) ->
        ()
    | Some _
    | None ->
        failwith "waitForAcceptedMessage failed"

let tryRecvAddress peer timeout =
    match Transport.tryRecv peer timeout with
        | Some (InProcMessage.Addresses addresses) ->
            Serialization.Addresses.deserialize addresses.count addresses.addresses
            |> Option.map List.head
        | Some _
        | None ->
            None

let recvGetAddresses peer timeout =
    match Transport.tryRecv peer timeout with
    | Some (InProcMessage.GetAddresses peerId) ->
        peerId
    | Some _
    | None ->
        failwith "recvGetAddresses failed"

let recvAddresses peer timeout =
    match Transport.tryRecv peer timeout with
    | Some (InProcMessage.Addresses addresses) ->
        Serialization.Addresses.deserialize addresses.count addresses.addresses
        |> Option.get
    | Some _
    | None ->
        failwith "recvAddresses failed"