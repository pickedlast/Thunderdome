Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Welcome to the Thunderdome, bitch!!!")
        Console.WriteLine("Please type your first name:")
        Dim firstName As String
        firstName = Console.ReadLine()
        Console.WriteLine("Please type your last name:")
        Dim lastName As String
        lastName = Console.ReadLine()
        Console.WriteLine("Howdy, {0} {1}!", firstName, lastName)
        Console.WriteLine()
        Console.WriteLine("Press ENTER to quit...")
        Console.ReadLine()
    End Sub
End Module
