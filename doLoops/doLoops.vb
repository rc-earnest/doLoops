Option Explicit On
Option Strict On
Option Compare Text

Module doLoops

    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim userInput As String

        'Do
        '    Console.WriteLine("In the first loop. Loop while firstNumber <=3")
        '    firstNumber += 1
        '    Console.WriteLine($"FirstNumber is {firstNumber}!")
        '    Console.WriteLine()
        'Loop While firstNumber <= 3

        'Do
        '    Console.WriteLine("In the second loop. Loop while firstNumber <=3")
        '    firstNumber += 1
        '    Console.WriteLine($"FirstNumber is {firstNumber}!")
        '    Console.WriteLine()
        'Loop While firstNumber <= 3

        'Do Until firstNumber >= 3
        '    Console.WriteLine("In the third loop. Do until firstNumber >=3")
        '    firstNumber += 1
        '    Console.WriteLine($"FirstNumber is {firstNumber}!")
        '    Console.WriteLine()
        'Loop

        'Do While firstNumber >= 3
        '    Console.WriteLine("In the fourth loop. Do while firstNumber >=3")
        '    firstNumber -= 1
        '    Console.WriteLine($"FirstNumber is {firstNumber}!")
        '    Console.WriteLine()
        'Loop

        Do
            Do
                Console.WriteLine("Enter the first number")
                Console.WriteLine("Enter Q to quit")
                userInput = Console.ReadLine()
                Console.WriteLine($"you entered ""{userInput}""")

                Try
                    firstNumber = CInt(userInput)
                    Exit Do
                Catch ex As Exception
                    If userInput <> "Q" Then
                        Console.WriteLine($"{userInput} Is not a whole number!")
                    Else
                        Console.WriteLine($"You entered {userInput}, have a nice day!")
                        Exit Sub
                    End If
                End Try
                Console.WriteLine(StrDup(80, "*"))
                Console.WriteLine()
            Loop
            Console.WriteLine()
            Do
                Console.WriteLine("Enter the first number")
                Console.WriteLine("Enter Q to quit")
                userInput = Console.ReadLine()
                Console.WriteLine($"you entered ""{userInput}""")

                Try
                    secondNumber = CInt(userInput)
                    Exit Do
                Catch ex As Exception
                    If userInput <> "Q" Then
                        Console.WriteLine($"{userInput} Is not a whole number!")
                    Else
                        Console.WriteLine($"You entered {userInput}, have a nice day!")
                        Exit Sub
                    End If
                End Try
                Console.WriteLine(StrDup(80, "*"))
                Console.WriteLine()
            Loop









        Loop While userInput <> "Q"
    End Sub

End Module
