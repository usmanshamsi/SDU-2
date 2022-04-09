Imports SDU_1.FormSerialisation

Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click, Label14.Click

    End Sub

    Private Sub calculate_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate_button.Click
        Dim b, h, cc, d, fc, fy, _as As Double
        Try
            b = Convert.ToDouble(beam_width.Text)
            h = Convert.ToDouble(beam_depth.Text)
            cc = Convert.ToDouble(cover.Text)
            d = h - cc
            fc = Convert.ToDouble(conc_fc.Text)
            fy = Convert.ToDouble(steel_fy.Text)
            _as = Convert.ToDouble(area_steel.Text)
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly, "Error in inputs")
        End Try


        'print inputs
        rtf.Clear()

        rtf.AppendText("I N P U T S" & vbCrLf)
        rtf.AppendText("-----------" & vbCrLf)
        _blue() : Output("Width of beam, b", b, "inch")
        _blue() : Output("Depth of beam, h", h, "inch")
        _blue() : Output("Cover to rebar centre", cc, "inch")
        _blue() : Output("Specified Strength of Concrete, f'c", fc, "psi")
        _blue() : Output("Yield Strength of reinforcement, fy", fy, "psi")
        _blue() : Output("Area of reinforcement, As", _as, "sq.inch")
        br()

        'print calculations and results

        rtf.AppendText("O U T P U T S" & vbCrLf)
        rtf.AppendText("-------------" & vbCrLf)

        Output("Effective depth of beam, d", d, "inch")
        br()

        Dim beta1 As Double = CalculateBeta1(fc)
        Output("Beta-1", beta1, "0.0###", "")
        br()

        Dim rho As Double = _as / (b * d)

        Output("Provided reinforcement percentage, rho", rho * 100.0, "%", _as, "sq. inch")



        Dim rho_min As Double = Math.Max(3 * Math.Sqrt(fc) / fy, 200.0 / fy)

        Output("Minimum reinforcement, rho-minimum", rho_min * 100.0, "%", rho_min * b * d, "sq.inch")

        Dim rho_bal As Double = 0.85 * beta1 * (fc / fy) * (87000 / (87000 + fy))
        Output("Balanced reinforcement, rho-balance", rho_bal * 100.0, "%", rho_bal * b * d, "sq.inch")

        Const modulus_of_Steel As Double = 29000000.0

        Dim rho_max As Double = ((0.003 + fy / modulus_of_Steel) / 0.008) * rho_bal
        Output("Maximum reinforcement, rho-max", rho_max * 100.0, "%", rho_max * b * d, "sq.inch")
        br()

        '    CHECK RHO AGAINST RHO MAX AND RHO MIN
        If (rho > rho_max) Then
            If (rho <= rho_bal) Then
                _red() : Info("rho is greater than rho_max, consider reducing.")
                br()
            Else
                _red() : Info("rho is greater than rho_balance, reduce reinforcement percentage.")
                Exit Sub
            End If
        End If


        If (rho < rho_min) Then
            _red() : Info("rho is less than rho_min, consider increasing.")
            br()
        End If

        '    calculate compression block

        Dim a As Double = (_as * fy) / (0.85 * fc * b)
        Output("Depth of Whitney block, a", a, "inch")

        Dim c As Double = a / beta1
        Output("Depth of neutral axis, c", c, "inch")
        br()

        '    calculate strain, phi and moment capacity
        Dim epsilon_t As Double = ((d - c) / c) * 0.003
        Output("Net Tensile Strain, epsilon_t", epsilon_t, "0.0#####", "")

        Dim phi As Double = Phi_flexure(epsilon_t)
        Output("Strength reduction factor, phi_flexure", phi, "0.0###", "")
        br()

        Dim moment_capacity As Double = _as * fy * (d - a / 2)
        _green() : Output("Nominal Moment Capacity, Mn", moment_capacity / 12000.0, "kip-ft")
        _green() : Output("Design Moment Capacity, Mu = phi * Mn", phi * moment_capacity / 12000.0, "kip-ft")


    End Sub

    Private Sub Output(ByVal parameter As String, ByVal value As Double, ByVal unit As String)
        rtf.AppendText(parameter & " = " & value.ToString("0.0#") & " " & unit & vbCrLf)
    End Sub
    Private Sub Output(ByVal parameter As String, ByVal value As Double, ByVal format As String, ByVal unit As String)
        rtf.AppendText(parameter & " = " & value.ToString(format) & " " & unit & vbCrLf)
    End Sub
    Private Sub Output(ByVal parameter As String, ByVal value1 As Double, ByVal unit1 As String, ByVal value2 As Double, ByVal unit2 As String)
        rtf.AppendText(parameter & " = " & value1.ToString("0.0#") & " " & unit1 & " = " & value2.ToString("0.0#") & " " & unit2 & vbCrLf)
    End Sub
    Private Sub Output(ByVal parameter As String, ByVal value1 As Double, ByVal format1 As String, ByVal unit1 As String, ByVal value2 As Double, ByVal format2 As String, ByVal unit2 As String)
        rtf.AppendText(parameter & " = " & value1.ToString(format1) & " " & unit1 & " = " & value2.ToString(format2) & " " & unit2 & vbCrLf)
    End Sub
    Private Sub Info(ByVal text As String)
        rtf.AppendText(text & vbCrLf)
    End Sub
    Private Sub br()
        rtf.AppendText(vbCrLf)
    End Sub
    Private Sub _blue()
        rtf.SelectionColor = Color.Blue
    End Sub
    Private Sub _red()
        rtf.SelectionBackColor = Color.Red
        'rtf.SelectionColor = Color.DarkRed
    End Sub
    Private Sub _green()
        rtf.SelectionBackColor = Color.Yellow
        'rtf.SelectionColor = Color.DarkGreen

    End Sub
    Private Sub _black()
        rtf.SelectionColor = Color.Black
    End Sub

    Function CalculateBeta1(ByVal fc As Double) As Double

        ' fc in psi

        If (fc <= 4000) Then

            Return 0.85

        ElseIf (fc >= 8000) Then

            Return 0.65

        Else

            Return 0.85 - (fc - 4000) / 1000 * 0.05

        End If
    End Function

    Function Phi_flexure(ByVal epsilon_t As Double) As Double

        ' epsilon_t is the strain in tension fibre

        If (epsilon_t >= 0.005) Then

            Return 0.9

        Else
            Return 0.65 + (epsilon_t - 0.002) * (250.0 / 3.0)

        End If
    End Function





    Private Sub beam_width_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beam_width.Enter, beam_width.Click, _
        beam_depth.Enter, beam_depth.Click, cover.Enter, cover.Click, conc_fc.Enter, conc_fc.Click, steel_fy.Enter, steel_fy.Click, _
        area_steel.Enter, area_steel.Click, TextBox1.Enter, TextBox1.Click

        sender.SelectAll()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormSerialisor.Deserialise(Me, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\sdu1-data.xml")
    End Sub


    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        FormSerialisor.Serialise(Me, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\sdu1-data.xml")
    End Sub
End Class
