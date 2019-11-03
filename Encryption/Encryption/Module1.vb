Module Module1

    Sub Main()
        Dim word As String
        Dim Encryption As String

        Console.WriteLine("Please Enter a Word to encrypt")
        word = Console.ReadLine
        word = AddWord(word)
        Encryption = railway(word)
        Console.WriteLine(Encryption)
        Console.ReadKey()
    End Sub
    Function AddWord(ByRef word As String)
        Dim Letter As Char
        Do Until word.Length >= 30
            For i = 1 To word.Length
                Letter = Mid(word, i, 1)
                Select Case Letter
                    Case "a"
                        word += "%"
                    Case "b"
                        word += "6"
                    Case "c"
                        word += "h"
                    Case "d"
                        word += "^"
                    Case "e"
                        word += "9"
                    Case "f"
                        word += "q"
                    Case "g"
                        word += "4"
                    Case "h"
                        word += "£"
                    Case "i"
                        word += "j"
                    Case "j"
                        word += "5"
                    Case "k"
                        word += "z"
                    Case "l"
                        word += "7"
                    Case "m"
                        word += "!"
                    Case "n"
                        word += ")"
                    Case "o"
                        word += "2"
                    Case "p"
                        word += "0"
                    Case "q"
                        word += "?"
                    Case "r"
                        word += "c"
                    Case "s"
                        word += "<"
                    Case "t"
                        word += "@"
                    Case "u"
                        word += "#"
                    Case "v"
                        word += "{"
                    Case "w"
                        word += ":"
                    Case "x"
                        word += "|"
                    Case "y"
                        word += "0"
                    Case "z"
                        word += "."
                End Select
            Next
        Loop
        Return word
    End Function
    Function railway(ByRef word As String)
        Dim layer1(14) As Char
        Dim layer2(14) As Char
        Dim recursion As Integer
        Dim n As Integer = 0
        Dim Encryption As String
        Do Until recursion >= 10
            Encryption = ""
            For i = 1 To 29 Step 2
                layer1(n) = Mid(word, i, 1)
                n += 1
            Next
            n = 0
            For i = 2 To 30 Step 2
                layer2(n) = Mid(word, i, 1)
                n += 1
            Next
            For i = 0 To 14
                Encryption += layer1(i)
            Next
            For i = 0 To 14
                Encryption += layer2(i)
            Next
            word = Encryption
            recursion += 1
            n = 0
        Loop
        Return Encryption
    End Function
End Module
