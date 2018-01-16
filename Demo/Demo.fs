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

module Booleans =

    /// Booleans values are 'true' and 'false'.
    let boolean1 = true
    let boolean2 = false

    /// Operators on booleans are 'not', '&&' and '||'.
    let boolean3 = not boolean1 && (boolean2 || false)

    // This line uses '%b'to print a boolean value.  This is type-safe.
    printfn "The expression 'not boolean1 && (boolean2 || false)' is %b" boolean3


module StringManipulation = 

    /// Strings use double quotes.
    let string1 = "Hello"
    let string2  = "world"

    /// Strings can also use @ to create a verbatim string literal.
    /// This will ignore escape characters such as '\', '\n', '\t', etc.
    let string3 = @"C:\Program Files\"

    /// String literals can also use triple-quotes.
    let string4 = """The computer said "hello world" when I told it to!"""
    let string5 = """The computer said 'hello world' when I told it to!"""

    /// String concatenation is normally done with the '+' operator.
    let helloWorld = string1 + " " + string2 

    // This line uses '%s' to print a string value.  This is type-safe.
    printfn "%s" helloWorld

    /// Substrings use the indexer notation.  This line extracts the first 7 characters as a substring.
    /// Note that like many languages, Strings are zero-indexed in F#.
    let substring = helloWorld.[0..6]
    printfn "%s" substring

module Tuples =
    let tuple1 = (1,2,3)
    let swapElems (a, b) = (b,a)
    printfn "The result of swapping (1,2) is %A" (swapElems (1,2))

module PipelinesAndComposition =
    let square x = x*x
    let addOne x = x + 1
    let isOdd x = x % 2 <> 0
    let numbers = [1;2;3;4;5]
    let squareOddValuesAndAddOne values =
        List.map (square >> addOne) (values 
        |> List.filter isOdd)

module Lists =
    let daysList =
        [ for month in 1 .. 12 do
            for day in 1 .. System.DateTime.DaysInMonth(2018, month) do
                yield System.DateTime(2018, month, day)
            ]

module SingleCaseDU =
    type Address = Address of string
    type Name = Name of string
    type SSN = SSN of int

    // You can easily instantiate a single-case DU as follows.
    let address = Address "111 Alf Way"
    let name = Name "Alf"
    let ssn = SSN 1234567890

    /// When you need the value, you can unwrap the underlying value with a simple function.
    let unwrapAddress (Address a) = a
    let unwrapName (Name n) = n
    let unwrapSSN (SSN s) = s

    // Printing single-case DUs is simple with unwrapping functions.
    printfn "Address: %s, Name: %s, and SSN: %d" (address |> unwrapAddress) (name |> unwrapName) (ssn |> unwrapSSN)



module UnitOfMeasure =
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitNames
    let sampleValues1 =1600.0<meter>
    [<Measure>]
    type mile =
        static memeber asMeter = 1609.34<meter/mile>
    
    