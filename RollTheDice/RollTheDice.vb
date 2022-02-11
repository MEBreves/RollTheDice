'Miranda Breves
'RCET0265
'Spring 2022
'Roll The Dice
'url

Option Strict On
Option Explicit On

Module RollTheDice

    'Returns the equivalent sum of two dice being rolled.
    Function DoubleDiceRoll() As Integer

        'Declaring Function Variables
        Dim die1 As Integer = 0
        Dim die2 As Integer = 0

        'Initializing the Rnd() function to return different values
        Randomize()

        'Getting the dice values via a random number between 1 and 6
        die1 = CInt(Math.Floor((6 * Rnd())) + 1)
        die2 = CInt(Math.Floor((6 * Rnd())) + 1)

        Return die1 + die2

    End Function


    Sub Main()

        'Declaring Variables
        Dim rollValue As Integer
        Dim diceTotals(12) As Integer

        'Simulating dice roll and storing the sum values in diceTotals array
        For i As Integer = 1 To 1000
            rollValue = DoubleDiceRoll()
            diceTotals(rollValue) += 1
        Next

        'Formatting the output to show the numbers in a table style
        Console.WriteLine("Roll of The Dice".PadLeft(35))
        Console.WriteLine(StrDup(55, "-"))

        For j As Integer = 2 To 12
            Console.Write((CStr(j) & "|").PadLeft(5))
        Next

        'Seperating the first row from the second row
        Console.WriteLine(vbNewLine & StrDup(55, "-"))

        For k As Integer = 2 To 12
            Console.Write((CStr(diceTotals(k)) & "|").PadLeft(5))
        Next

        'Letting the user know the program has finished.
        Console.WriteLine(vbNewLine & vbNewLine & "Please press Enter to exit.")
        Console.ReadLine()
    End Sub

End Module
