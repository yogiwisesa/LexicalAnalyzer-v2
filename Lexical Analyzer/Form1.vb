Public Class Form1
    Dim aToken(0) As Integer
    Dim token As String
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim sText As String ' sText stands for stringText - Deklarasi Variabel
        Dim i, length As Integer ' Deklarasi Variabel
        sText = txtInput.Text + " " 'Memeasukan isi TextBoxInput ke variabel string & fungsi ditambah spasi sebagai penanda agar token keluar karena setiap token dikeluarkan bila sText.chars(i) = " " 
        sText = sText.ToLower ' << set ke lower agar tidak case sensitive
        length = sText.Length
        i = 0

        lblToken.Text = ""
        token = ""
        'Public aToken(0) As Integer
        Dim j As Integer
        j = -1

        Dim stack As New Stack()
Space:
        'On Error Resume Next
        If i < length Then
            Select Case sText.Chars(i)
                Case "p", "q", "r", "s" ' PQRS
                    i = i + 1
                    Select Case sText.Chars(i)
                        Case " "

                            i = i + 1
                            token = token + " 1" ' Token dikeluarkan saat sText.chars(i) = " " agar mengetahui apakan suatu sintaks tidak ada lanjutannya, misal ifg agar menghasilkan error bukan 6error

                            j = j + 1
                            ReDim Preserve aToken(j)
                            aToken(aToken.GetUpperBound(0)) = 1
                            GoTo Space
                        Case Else
                            token = token + "error"
                    End Select
                Case "n" ' NOT
                    i = i + 1
                    Select Case sText.Chars(i)
                        Case "o"
                            i = i + 1
                            Select Case sText.Chars(i)
                                Case "t"
                                    i = i + 1
                                    Select Case sText.Chars(i)
                                        Case " "
                                            token = token + " 2"
                                            i = i + 1

                                            j = j + 1
                                            ReDim Preserve aToken(j)
                                            aToken(aToken.GetUpperBound(0)) = 2

                                            GoTo Space
                                        Case Else
                                            token = token + "error"
                                    End Select
                                Case Else
                                    token = token + "error"
                            End Select
                        Case Else
                            token = token + "error"
                    End Select
                Case "a" ' AND
                    i = i + 1
                    Select Case sText.Chars(i)
                        Case "n"
                            i = i + 1
                            Select Case sText.Chars(i)
                                Case "d"
                                    i = i + 1
                                    Select Case sText.Chars(i)
                                        Case " "
                                            token = token + " 3"
                                            i = i + 1


                                            j = j + 1
                                            ReDim Preserve aToken(j)
                                            aToken(aToken.GetUpperBound(0)) = 3
                                            GoTo Space
                                        Case Else
                                            token = token + "error"
                                    End Select
                                Case Else
                                    token = token + "error"
                            End Select
                        Case Else
                            token = token + "error"
                    End Select
                Case "o" ' OR
                    i = i + 1
                    Select Case sText.Chars(i)
                        Case "r"
                            i = i + 1
                            Select Case sText.Chars(i)
                                Case " "
                                    i = i + 1
                                    token = token + " 4"


                                    j = j + 1
                                    ReDim Preserve aToken(j)
                                    aToken(aToken.GetUpperBound(0)) = 4
                                    GoTo Space
                                Case Else
                                    token = token + "error"
                            End Select
                        Case Else
                            token = token + "error"
                    End Select
                Case "x" ' XOR
                    i = i + 1
                    Select Case sText.Chars(i)
                        Case "o"
                            i = i + 1
                            Select Case sText.Chars(i)
                                Case "r"
                                    i = i + 1
                                    Select Case sText.Chars(i)
                                        Case " "
                                            i = i + 1
                                            token = token + " 5"


                                            j = j + 1
                                            ReDim Preserve aToken(j)
                                            aToken(aToken.GetUpperBound(0)) = 5
                                            GoTo Space
                                        Case Else
                                            token = token + "error"
                                    End Select
                                Case Else
                                    token = token + "error"
                            End Select
                        Case Else
                            token = token + "error"
                    End Select
                Case "i" ' IF
                    i = i + 1
                    Select Case sText.Chars(i)
                        Case "f"
                            i = i + 1
                            Select Case sText.Chars(i)
                                Case " "
                                    i = i + 1
                                    token = token + " 6"

                                    j = j + 1
                                    ReDim Preserve aToken(j)
                                    aToken(aToken.GetUpperBound(0)) = 6
                                    GoTo Space
                                Case "f"
                                    i = i + 1
                                    Select Case sText.Chars(i)
                                        Case " "
                                            i = i + 1
                                            token = token + " 8"


                                            j = j + 1
                                            ReDim Preserve aToken(j)
                                            aToken(aToken.GetUpperBound(0)) = 8
                                            GoTo Space
                                        Case Else
                                            token = token + "error"
                                    End Select
                                Case Else
                                    token = token + "error"
                            End Select
                        Case Else
                            token = token + "error"
                    End Select
                Case "t" ' THEN
                    i = i + 1
                    Select Case sText.Chars(i)
                        Case "h"
                            i = i + 1
                            Select Case sText.Chars(i)
                                Case "e"
                                    i = i + 1
                                    Select Case sText.Chars(i)
                                        Case "n"
                                            i = i + 1
                                            token = token + " 7"


                                            j = j + 1
                                            ReDim Preserve aToken(j)
                                            aToken(aToken.GetUpperBound(0)) = 7

                                            Select Case sText.Chars(i)
                                                Case " "
                                                    i = i + 1
                                                    GoTo Space
                                                Case Else
                                                    token = token + "error"
                                            End Select
                                        Case Else
                                            token = token + "error"
                                    End Select
                                Case Else
                                    token = token + "error"
                            End Select
                        Case Else
                            token = token + "error"
                    End Select
                Case "(" ' GROUPING
                    i = i + 1
                    Select Case sText.Chars(i)
                        Case " "
                            token = token + " 9"
                            i = i + 1
                            j = j + 1
                            ReDim Preserve aToken(j)
                            aToken(aToken.GetUpperBound(0)) = 9
                            GoTo Space
                        Case Else
                            token = token + "error"
                    End Select

                Case ")" ' GROUPING JAGA- JAGA KALAU ADA GROUPING SETELAH GROUPING
                    i = i + 1
                    Select Case sText.Chars(i)
                        Case " "
                            token = token + " 10"
                            i = i + 1
                            j = j + 1
                            ReDim Preserve aToken(j)
                            aToken(aToken.GetUpperBound(0)) = 10
                            GoTo Space
                        Case Else
                            token = token + "error"
                    End Select
                Case " "
                    token = token
                Case Else
                    token = token + "error"
            End Select
        End If
        stack.Push(1)
        lblToken.Text = token 'Set LabelToken menjadi token

    End Sub

    Dim iV As Integer  ' iV = index untuk validasi
    Dim Stack As New Stack()
    Dim Valid As Boolean

    Private Sub BtnValid_Click(sender As Object, e As EventArgs) Handles BtnValid.Click
        If token.Contains("error") Then
            Label1.Text = "ERROR"
            Label1.ForeColor = Color.Red
        Else
            Stack.Push(99) '# diganti jadi 99 karena nanti int tidak bisa dibandingkan dengan char
            iV = -1
            q0()
            If Valid = True Then
                Label1.Text = "VALID"
                Label1.ForeColor = Color.Green
            Else
                Label1.Text = "TIDAK VALID"
                Label1.ForeColor = Color.Red
            End If
        End If


    End Sub

    Sub q0()
        iV = iV + 1
        If iV <= aToken.GetUpperBound(0) Then
            Select Case aToken(iV)
                Case 1
                    Stack.Push(1)
                    q1()
                Case 2
                    q3()
                Case 6
                    Stack.Push(6)
                    q3()
                Case 9
                    Stack.Push(9)
                    q0()
                Case Else
                    Valid = False
            End Select
        Else
            Valid = False
        End If
    End Sub

    Sub q1()
        iV = iV + 1
        If iV <= aToken.GetUpperBound(0) Then
            If aToken(iV) = 1 Then
                If Stack.Peek = 1 Then
                    Stack.Pop()
                    If Stack.Peek = 9 Then
                        Stack.Pop()
                        q6()
                    Else
                        Valid = False
                    End If
                Else
                    Valid = False
                End If
            ElseIf aToken(iV) = 10 Then
                If Stack.Peek = 1 Then
                    Stack.Pop()
                    If Stack.Peek = 9 Then
                        Stack.Pop()
                        q6()
                    Else
                        Valid = False
                    End If
                End If
            ElseIf aToken(iV) = 7 Then
                If Stack.Peek = 6 Then
                    Stack.Pop()
                    q4()
                Else
                    Valid = False
                End If
            ElseIf aToken(iV) <> 3 And aToken(iV) <> 4 And aToken(iV) <> 5 And aToken(iV) <> 8 Then
                Valid = False
            ElseIf Stack.Peek = 1 Then
                Stack.Pop()
                q5()
            Else
                Valid = False
            End If
        ElseIf Stack.Peek = 1 Then
            Stack.Pop()
            q8()
        Else
            Valid = False
        End If
    End Sub

    Sub q2()
        iV = iV + 1
        If iV <= aToken.GetUpperBound(0) Then
            Select Case aToken(iV)
                Case 1
                    Stack.Push(1)
                    q1()
                Case 9
                    Stack.Push(9)
                    q0()
                Case Else
                    Valid = False
            End Select
        Else
            Valid = False
        End If
    End Sub

    Sub q3()
        iV = iV + 1

        If iV <= aToken.GetUpperBound(0) Then
            Select Case aToken(iV)
                Case 1
                    q1()
                Case 9
                    Stack.Push(9)
                    q0()
                Case Else
                    Valid = False
            End Select
        Else
            Valid = False
        End If
    End Sub

    Sub q4()
        iV = iV + 1

        If iV <= aToken.GetUpperBound(0) Then
            Select Case aToken(iV)
                Case 1
                    q8()
                Case 2
                    q2()
                Case 9
                    Stack.Push(9)
                    q0()
                Case Else
                    Valid = False
            End Select
        Else
            Valid = False
        End If
    End Sub

    Sub q5()

        iV = iV + 1
        If iV <= aToken.GetUpperBound(0) Then
            Select Case aToken(iV)
                Case 1
                    Stack.Push(1)
                    q1()
                Case 2
                    q2()
                Case 9
                    Stack.Push(9)
                    q0()
                Case Else
                    Valid = False
            End Select
        Else
            Valid = False
        End If
    End Sub

    Sub q6()
        iV = iV + 1

        If iV <= aToken.GetUpperBound(0) Then
            Select Case aToken(iV)
                Case 10
                    If Stack.Peek = 9 Then
                        Stack.Pop()
                        q6()
                    Else
                        Valid = False
                    End If
                Case 7
                    If Stack.Peek = 6 Then
                        Stack.Pop()
                        q4()
                    Else
                        Valid = False
                    End If
            End Select
        ElseIf Stack.Peek = 99 Then
            Stack.Pop()
            Valid = True
        Else
            Valid = False
        End If
    End Sub

    Sub q7()
        iV = iV + 1

        If iV <= aToken.GetUpperBound(0) Then
            Select Case aToken(iV)
                Case 10
                    If Stack.Peek = 9 Then
                        Stack.Pop()
                        q6()
                    Else
                        Valid = False
                    End If
                Case Else
                    Valid = False
            End Select
        Else
            Valid = False
        End If
    End Sub

    Sub q8()
        iV = iV + 1
        If iV <= aToken.GetUpperBound(0) Then
            Valid = False
        ElseIf Stack.Peek = 99 Then
            Stack.Pop()
            Valid = True
        Else
            Valid = False
        End If
    End Sub
End Class