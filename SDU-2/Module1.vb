Module Module1
    Private Sub Output(ByVal parameter As String, ByVal value As Double, ByVal unit As String)
        Form1.rtf.AppendText(parameter & " = " & value.ToString("0.0#") & " " & unit & vbCrLf)
    End Sub
    Private Sub Output(ByVal parameter As String, ByVal value As Double, ByVal format As String, ByVal unit As String)
        Form1.rtf.AppendText(parameter & " = " & value.ToString(format) & " " & unit & vbCrLf)
    End Sub
    Private Sub Output(ByVal parameter As String, ByVal value1 As Double, ByVal unit1 As String, ByVal value2 As Double, ByVal unit2 As String)
        Form1.rtf.AppendText(parameter & " = " & value1.ToString("0.0#") & " " & unit1 & " = " & value2.ToString("0.0#") & " " & unit2 & vbCrLf)
    End Sub
    Private Sub Output(ByVal parameter As String, ByVal value1 As Double, ByVal format1 As String, ByVal unit1 As String, ByVal value2 As Double, ByVal format2 As String, ByVal unit2 As String)
        Form1.rtf.AppendText(parameter & " = " & value1.ToString(format1) & " " & unit1 & " = " & value2.ToString(format2) & " " & unit2 & vbCrLf)
    End Sub
    Private Sub Info(ByVal text As String)
        Form1.rtf.AppendText(text & vbCrLf)
    End Sub
    Private Sub br()
        Form1.rtf.AppendText(vbCrLf)
    End Sub
    Private Sub blue()
        Form1.rtf.SelectionColor = Color.Blue
    End Sub
    Private Sub red()
        Form1.rtf.SelectionBackColor = Color.Red
        'Form1.rtf.SelectionColor = Color.DarkRed
    End Sub
    Private Sub green()
        Form1.rtf.SelectionBackColor = Color.Yellow
        'Form1.rtf.SelectionColor = Color.DarkGreen

    End Sub
    Private Sub black()
        Form1.rtf.SelectionColor = Color.Black
    End Sub
End Module
