module Helper

open Global
open Xamarin.Forms
open Xamarin.Essentials

[<Literal>]
let DebounceNo = 250

// let mutable syncContext = System.Threading.SynchronizationContext()

// let setSyncContext () =
//     syncContext <- System.Threading.SynchronizationContext()

let updateElement key newItem st =
    st
    |> List.mapi (fun i item ->
           if i = key then newItem
           else item)

let updateHead newItem st = updateElement 0 newItem st

let removeFirst (items : 'a list) =
    match items with
    | [] -> []
    | [ _ ] -> []
    | _ :: t -> t

type PageDetail<'a> =
    { Page : AppPage
      PageData : 'a }

type PageStack<'a> = PageDetail<'a> list
