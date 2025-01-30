Option Explicit On
Option Strict On
Option Compare Text

Module doLoops

    Sub Main()
        Dim firstNumber As Integer

        Do
            Console.WriteLine("In the first loop. Loop while firstNumber <=3")
            firstNumber += 1
            Console.WriteLine($"FirstNumber is {firstNumber}!")
            Console.WriteLine()
        Loop While firstNumber <= 3

        Do
            Console.WriteLine("In the second loop. Loop while firstNumber <=3")
            firstNumber += 1
            Console.WriteLine($"FirstNumber is {firstNumber}!")
            Console.WriteLine()
        Loop While firstNumber <= 3

        Do Until firstNumber >= 3
            Console.WriteLine("In the third loop. Do until firstNumber >=3")
            firstNumber += 1
            Console.WriteLine($"FirstNumber is {firstNumber}!")
            Console.WriteLine()
        Loop

        Do While firstNumber >= 3
            Console.WriteLine("In the fourth loop. Do while firstNumber >=3")
            firstNumber -= 1
            Console.WriteLine($"FirstNumber is {firstNumber}!")
            Console.WriteLine()
        Loop
    End Sub

End Module
