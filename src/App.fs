module App

open Browser.Dom

// Mutable variable to count the number of times we clicked the button
let mutable count = 0

// Get a reference to our button and cast the Element to an HTMLButtonElement
let myButton = document.querySelector(".my-button") :?> Browser.Types.HTMLButtonElement

let buttonText count = if count = 1 then "you clicked: 1 time" else $"you clicked: {count} times"

// Register our listener
myButton.onclick <- fun _ ->
    count <- count + 1
    myButton.innerText <- buttonText count
