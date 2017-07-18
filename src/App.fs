module App

open Elmish
open Elmish.Browser.Navigation
open Elmish.React
open Fable.Helpers.React
open Fable.Helpers.React.Props

type Model = string

type Msg = HelloMsg | GoodByeMsg

let init () = "Press buttons!", [ ]

let view model dispatch =
    div
        [ ]
        [
            button [ OnClick (fun _ -> dispatch HelloMsg ) ] [ str "Hello" ]
            button [ OnClick (fun _ -> dispatch GoodByeMsg ) ] [ str "Goodbye" ]
            str model
        ]

let update msg model =
    match msg with
    | HelloMsg -> "Hello!", [ ]
    | GoodByeMsg -> "GoodBye!", [ ]

Program.mkProgram init update view
|> Program.withReact "sampleapp"
|> Program.run