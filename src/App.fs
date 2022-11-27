module App

open Browser.Dom

// Mutable variable to count the number of times we clicked the button
let mutable count = 0

// Get a reference to our button and cast the Element to an HTMLButtonElement
let myButton =
    document.querySelector (".my-button") :?> Browser.Types.HTMLButtonElement

let myClicksDiv = document.getElementById ("clicks") :?> Browser.Types.HTMLDivElement

let buttonText count =
    $"you clicked: {count} time" + if count = 1 then "" else "s"

// Register our listener
myButton.onclick <-
    fun _ ->
        count <- count + 1
        myButton.innerText <- buttonText count
        let li = document.createElement "li"
        li.innerText <- $"{count}"
        myClicksDiv.appendChild li
