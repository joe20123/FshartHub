namespace Demo

module PigLatin = 
    let toPigLatin (word: string) =
        let isVowel (c: char) =
            match c with
                | 'a' | 'e' | 'i' | 'o' | 'u'
                | 'A' | 'E' | 'I' | 'O' | 'U' -> true
                |_ -> false

        if isVowel word.[0] then 
            word + "yay"
        else
            word.[1..] + string(word.[0]) + "ay"


module Immutability =
    let number =2

    let mutable otherNumber = 2
    printfn "'otherNumber' is %d" otherNumber
    
    otherNumber <- otherNumber + 1
    printfn "'otherNumber is %d" otherNumber

module IntegersAndNumbers =
    let sampleInteger = 176
    let sampleDouble = 4.2
    //let sampleInteger2 = (sampleInteger/4 + 5 -7) * 4 + int sampleDouble
    let sampleNumber = [0..100]
    let sampleTableOfSquares = [for i in 0..99 -> (i, i*i)]
    printfn "The table of squares from 0 to 99 is: \n%A" sampleTableOfSquares

