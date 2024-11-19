open System
//Zadanie 1

[<EntryPoint>]
let main argv =
    //Pobranie tekstu od użytkonwnika
    printfn "Podaj tekst: "
    let input = Console.ReadLine()

//Obliczanie liczby słów
let wordCount = input.Split([|' '; '\t';'\n';'\r'|]), StringSplitOptions.RemoveEmptyEntries.Length

//Obliczanie liczby znaków bez spacji
let charCount = input.Replace(" ", "").Length

//Wyświetlenie wyniku
printfn "Liczba słów: %d" wordCount
printfn "Liczba znaków (bez spacji): %d" charcount

//Zadanie 2
let isPalindrome (text:string) =
    let cleanedText = text.ToLower().Replace(" ", "").Replace("\t","")
    cleanedText = String(Array.rev (cleanedText.ToCharArray()))

let main argv = 
    printfn "Podaj tekst: "
    let input = Console.ReadLine()

if isPalindrome input then
    printfn "Podany tekst jest palindromem."
    else
    printfn "Podany tekst nie jest palindromem"

//Zadanie 5

let findLongestWord (text:string) = 
    let words = text.Split([|' '; '\t' '\n' '\r'|], StringSplitOptions.RemoveEmptyEntries)
    let longestWord = words |> Array.maxBy (fun word -> word.Length)
    (longestWord, longestWord.Length)

    let main argv = 
    printfn "Podaj tekst: "
    let input = Console.ReadLine()

    let (word,length) = findLongestWord input
    printfn "Najdłuższe słowo: \"%s\"" word
    printfn "Długość najdłuższego słowa: %d" length
    