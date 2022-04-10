Imports SDU_1.FormSerialisation

Public Class Form1

    Private Sub design_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles design_button.Click
        Select Case True
            Case dFlexure.Checked
                design_for_flexure()

            Case dShear.Checked
                design_for_shear()

            Case dShearTorsion.Checked
                design_for_shear_and_torsion(limitTu_checkbox.Checked)

        End Select






    End Sub

    Private Sub OutputLine(ByVal parameter As String, ByVal value As Double, ByVal unit As String)
        rtf.AppendText(parameter & " = " & value.ToString("0.0#") & " " & unit & vbCrLf)
    End Sub
    Private Sub OutputLine(ByVal parameter As String, ByVal value As Double, ByVal format As String, ByVal unit As String)
        rtf.AppendText(parameter & " = " & value.ToString(format) & " " & unit & vbCrLf)
    End Sub
    Private Sub OutputLine(ByVal parameter As String, ByVal value1 As Double, ByVal unit1 As String, ByVal value2 As Double, ByVal unit2 As String)
        rtf.AppendText(parameter & " = " & value1.ToString("0.0#") & " " & unit1 & " = " & value2.ToString("0.0#") & " " & unit2 & vbCrLf)
    End Sub
    Private Sub OutputLine(ByVal parameter As String, ByVal value1 As Double, ByVal format1 As String, ByVal unit1 As String, ByVal value2 As Double, ByVal format2 As String, ByVal unit2 As String)
        rtf.AppendText(parameter & " = " & value1.ToString(format1) & " " & unit1 & " = " & value2.ToString(format2) & " " & unit2 & vbCrLf)
    End Sub

    Private Sub Output(ByVal parameter As String, ByVal value As Double, ByVal unit As String)
        rtf.AppendText(parameter & " = " & value.ToString("0.0#") & " " & unit)
    End Sub
    Private Sub Output(ByVal parameter As String, ByVal value As Double, ByVal format As String, ByVal unit As String)
        rtf.AppendText(parameter & " = " & value.ToString(format) & " " & unit)
    End Sub
    Private Sub Output(ByVal parameter As String, ByVal value1 As Double, ByVal unit1 As String, ByVal value2 As Double, ByVal unit2 As String)
        rtf.AppendText(parameter & " = " & value1.ToString("0.0#") & " " & unit1 & " = " & value2.ToString("0.0#") & " " & unit2)
    End Sub
    Private Sub Output(ByVal parameter As String, ByVal value1 As Double, ByVal format1 As String, ByVal unit1 As String, ByVal value2 As Double, ByVal format2 As String, ByVal unit2 As String)
        rtf.AppendText(parameter & " = " & value1.ToString(format1) & " " & unit1 & " = " & value2.ToString(format2) & " " & unit2)
    End Sub

    Private Sub InfoLine(ByVal text As String)
        rtf.AppendText(text & vbCrLf)
    End Sub
    Private Sub Info(ByVal text As String)
        rtf.AppendText(text)
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
    Function CalculateTcr(ByVal b As Double, ByVal h As Double, ByVal fc As Double) As Double
        Dim acp As Double = b * h
        Dim pcp As Double = 2.0 * (b + h)
        Dim rootfc As Double = Math.Sqrt(fc)
        Return 4.0 * rootfc * acp * acp / pcp
    End Function
    Function Phi_flexure(ByVal epsilon_t As Double) As Double

        ' epsilon_t is the strain in tension fibre

        If (epsilon_t >= 0.005) Then

            Return 0.9

        Else
            Return 0.65 + (epsilon_t - 0.002) * (250.0 / 3.0)

        End If
    End Function

    Sub design_for_flexure()
        Dim b, h, cc, d, fc, fy, mu As Double
        Dim stdia, bardia As Double
        Try
            b = Convert.ToDouble(beam_width.Text)
            h = Convert.ToDouble(beam_depth.Text)
            cc = Convert.ToDouble(clear_cover.Text)

            fc = Convert.ToDouble(conc_fc.Text)
            fy = Convert.ToDouble(steel_fy.Text)
            mu = Convert.ToDouble(momentMu.Text)
            mu = mu * 12000.0      ' convert from kip-ft to lb-in

            Select Case True
                Case st14.Checked
                    stdia = 1.0 / 4
                Case st38.Checked
                    stdia = 3.0 / 8
                Case st12.Checked
                    stdia = 1.0 / 2
            End Select

            Select Case True
                Case bar3.Checked
                    bardia = 3 / 8.0
                Case bar4.Checked
                    bardia = 4 / 8.0
                Case bar5.Checked
                    bardia = 5 / 8.0
                Case bar6.Checked
                    bardia = 6 / 8.0
                Case bar7.Checked
                    bardia = 7 / 8.0
                Case bar8.Checked
                    bardia = 8 / 8.0
                Case bar9.Checked
                    bardia = 9 / 8.0
                Case bar10.Checked
                    bardia = 10 / 8.0
            End Select

            d = h - cc - stdia - bardia / 2.0


        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly, "Error in inputs")
        End Try


        rtf.Clear()

        If print_input_checkbox.Checked Then
            'print inputs
            rtf.AppendText("I N P U T S" & vbCrLf)
            rtf.AppendText("-----------" & vbCrLf)
            _blue() : OutputLine("Width of beam, b", b, "inch")
            _blue() : OutputLine("Depth of beam, h", h, "inch")
            _blue() : OutputLine("Clear Cover", cc, "inch")
            _blue() : OutputLine("Stirrup Bar Diameter", stdia, "0.0##", "inch")
            _blue() : OutputLine("Main Bar Diameter", bardia, "0.0##", "inch")
            _blue() : OutputLine("Specified Strength of Concrete, f'c", fc, "psi")
            _blue() : OutputLine("Yield Strength of reinforcement, fy", fy, "psi")
            _blue() : OutputLine("Design Bending Moment, Mu", mu / 12000.0, "kip-ft")
            br()
        End If


        'print calculations and results

        rtf.AppendText("D E S I G N   F O R  F L E X U R E" & vbCrLf)
        rtf.AppendText("----------------------------------" & vbCrLf)

        OutputLine("Effective depth of beam, d", d, "inch")
        br()

        Dim beta1 As Double = CalculateBeta1(fc)
        OutputLine("Beta-1", beta1, "0.0###", "")
        br()

        Const phi As Double = 0.9
        OutputLine("Strength reduction factor, phi_flexure", phi, "")
        rtf.AppendText("(Reinforcement percentage rho will be limited to rho_max)" & vbCrLf)
        br()

        Dim ru As Double = mu / (b * Math.Pow(d, 2))
        Dim f1 As Double = (2 * ru) / (0.85 * fc * phi)
        Dim f2 As Double = 1 - Math.Sqrt(1 - f1)
        Dim rho_calc As Double = (0.85 * fc * f2) / fy
        OutputLine("Calculated reinforcement, As-calc", rho_calc * b * d, "sq.inch")
        OutputLine("rho-calc", rho_calc * 100, "%")
        br()

        Dim rho_min As Double = Math.Max(3 * Math.Sqrt(fc) / fy, 200.0 / fy)
        OutputLine("Minimum reinforcement, As-min", rho_min * b * d, "sq. inch")
        OutputLine("rho-min", rho_min * 100, "%")
        br()

        Dim rho_bal As Double = 0.85 * beta1 * (fc / fy) * (87000 / (87000 + fy))
        OutputLine("Balanced reinforcement, As-bal", rho_bal * b * d, "sq. inch")
        OutputLine("rho-balance", rho_bal * 100, "%")
        br()

        Const modulus_of_Steel As Double = 29000000.0
        Dim rho_max As Double = ((0.003 + fy / modulus_of_Steel) / 0.008) * rho_bal
        OutputLine("Maximum reinforcement, As-max", rho_max * b * d, "sq.inch")
        OutputLine("rho-max", rho_max * 100, "%")
        br()

        If rho_calc > rho_max Then
            _red() : InfoLine("Calculated reinforcement is more than maximum allowed (rho-calc > rho-max). Revise section.")
        Else
            Dim rho As Double = Math.Max(rho_calc, Math.Min(rho_min, 4 * rho_calc / 3))
            _green() : OutputLine("Reinforcement to be provided, As", rho * b * d, "sq.inch")
            _green() : OutputLine("rho", rho * 100, "%")
        End If
    End Sub

    Sub design_for_shear()
        Dim b, h, cc, d, fc, fy, vu, phi As Double
        Dim stdia, bardia As Double
        Try
            b = Convert.ToDouble(beam_width.Text)
            h = Convert.ToDouble(beam_depth.Text)
            cc = Convert.ToDouble(clear_cover.Text)

            fc = Convert.ToDouble(conc_fc.Text)
            fy = Convert.ToDouble(steel_fy.Text)

            vu = Convert.ToDouble(shearVu.Text) * 1000.0 ' converted from kip to lbs
            phi = Convert.ToDouble(phi_shear.Text)

            Select Case True
                Case st14.Checked
                    stdia = 1.0 / 4
                Case st38.Checked
                    stdia = 3.0 / 8
                Case st12.Checked
                    stdia = 1.0 / 2
            End Select

            Select Case True
                Case bar3.Checked
                    bardia = 3 / 8.0
                Case bar4.Checked
                    bardia = 4 / 8.0
                Case bar5.Checked
                    bardia = 5 / 8.0
                Case bar6.Checked
                    bardia = 6 / 8.0
                Case bar7.Checked
                    bardia = 7 / 8.0
                Case bar8.Checked
                    bardia = 8 / 8.0
                Case bar9.Checked
                    bardia = 9 / 8.0
                Case bar10.Checked
                    bardia = 10 / 8.0
            End Select

            d = h - cc - stdia - bardia / 2.0


        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly, "Error in inputs")
        End Try


        rtf.Clear()

        If print_input_checkbox.Checked Then
            'print inputs
            rtf.AppendText("I N P U T S" & vbCrLf)
            rtf.AppendText("-----------" & vbCrLf)
            _blue() : OutputLine("Width of beam, b", b, "inch")
            _blue() : OutputLine("Depth of beam, h", h, "inch")
            _blue() : OutputLine("Clear Cover", cc, "inch")
            _blue() : OutputLine("Stirrup Bar Diameter", stdia, "0.0##", "inch")
            _blue() : OutputLine("Main Bar Diameter", bardia, "0.0##", "inch")
            _blue() : OutputLine("Specified Strength of Concrete, f'c", fc, "psi")
            _blue() : OutputLine("Yield Strength of reinforcement, fy", fy, "psi")
            _blue() : OutputLine("Design Shear Force, Vu", vu / 1000.0, "kip")
            _blue() : OutputLine("Strength Reduction Factor, phi-shear", phi, "")
            br()
        End If


        'print calculations and results

        rtf.AppendText("D E S I G N   F O R   S H E A R" & vbCrLf)
        rtf.AppendText("--------------------------------" & vbCrLf)

        OutputLine("Effective depth of beam, d", d, "inch")
        br()

        Dim av_over_s_1, av_over_s_2, av_over_s_min, av_over_s As Double
        Dim rootfc As Double = Math.Sqrt(fc)
        av_over_s_1 = 50 * b / fy
        av_over_s_2 = 0.75 * rootfc * b / fy
        av_over_s_min = Math.Max(av_over_s_1, av_over_s_2)
        Dim vc As Double = 2 * rootfc * b * d

        OutputLine("Shear capacity of provided section, Vc", vc / 1000, "kip")
        OutputLine("phi*Vc", phi * vc / 1000, "kip")
        br()

        If vu < phi * vc / 2 Then
            _green() : InfoLine("Vu < (phi * Vc) / 2, No shear reinforcement is required.")
        ElseIf vu <= phi * vc Then
            av_over_s = av_over_s_min
            _green() : OutputLine("Minimum Shear Reinforcement required, Av/S", av_over_s, "0.0#####", "sq.inch/inch")
            Dim spacing As Double = stdia / av_over_s
            _green() : OutputLine("Required stirrup spacing", spacing, "inch")
            br()
        Else
            Dim vs As Double = (vu - phi * vc) / phi
            OutputLine("Vs = (Vu - phi*Vc)/phi", vs / 1000, "kip")
            br()

            If vs > 4 * vc Then
                _red() : InfoLine("Vs > 4 * Vc, Section need to be revised")
            Else
                av_over_s = vs / (fy * d)
                av_over_s = Math.Max(av_over_s, av_over_s_min)
                _green() : OutputLine("Shear Reinforcement required, Av/S", av_over_s, "0.######", "sq.inch / inch")
                Dim spacing As Double = (2 * 0.785 * stdia ^ 2) / av_over_s
                _green() : OutputLine("Required stirrup spacing", spacing, "inch")
            End If
        End If





    End Sub

    Sub design_for_shear_and_torsion(ByVal design_for_phi_Tcr As Boolean)
        Dim b, h, cc, d, fc, fy, vu, tu, phi As Double
        Dim stdia, bardia As Double
        Try
            b = Convert.ToDouble(beam_width.Text)
            h = Convert.ToDouble(beam_depth.Text)
            cc = Convert.ToDouble(clear_cover.Text)

            fc = Convert.ToDouble(conc_fc.Text)
            fy = Convert.ToDouble(steel_fy.Text)

            vu = Convert.ToDouble(shearVu.Text) * 1000.0 ' converted from kip to lbs
            tu = Convert.ToDouble(torsionTu.Text) * 1000.0 ' converted from kip-inch to lb-inch
            phi = Convert.ToDouble(phi_shear.Text)

            Select Case True
                Case st14.Checked
                    stdia = 1.0 / 4
                Case st38.Checked
                    stdia = 3.0 / 8
                Case st12.Checked
                    stdia = 1.0 / 2
            End Select

            Select Case True
                Case bar3.Checked
                    bardia = 3 / 8.0
                Case bar4.Checked
                    bardia = 4 / 8.0
                Case bar5.Checked
                    bardia = 5 / 8.0
                Case bar6.Checked
                    bardia = 6 / 8.0
                Case bar7.Checked
                    bardia = 7 / 8.0
                Case bar8.Checked
                    bardia = 8 / 8.0
                Case bar9.Checked
                    bardia = 9 / 8.0
                Case bar10.Checked
                    bardia = 10 / 8.0
            End Select

            d = h - cc - stdia - bardia / 2.0


        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly, "Error in inputs")
        End Try


        rtf.Clear()

        If print_input_checkbox.Checked Then
            'print inputs
            rtf.AppendText("I N P U T S" & vbCrLf)
            rtf.AppendText("-----------" & vbCrLf)
            _blue() : OutputLine("Width of beam, b", b, "inch")
            _blue() : OutputLine("Depth of beam, h", h, "inch")
            _blue() : OutputLine("Clear Cover", cc, "inch")
            _blue() : OutputLine("Stirrup Bar Diameter", stdia, "0.0##", "inch")
            _blue() : OutputLine("Main Bar Diameter", bardia, "0.0##", "inch")
            _blue() : OutputLine("Specified Strength of Concrete, f'c", fc, "psi")
            _blue() : OutputLine("Yield Strength of reinforcement, fy", fy, "psi")
            _blue() : OutputLine("Design Shear Force, Vu", vu / 1000.0, "kip")
            _blue() : OutputLine("Design Torsion, Tu", tu / 1000.0, "kip-inch")
            _blue() : OutputLine("Strength Reduction Factor, phi-shear", phi, "")
            br()
        End If

        '----------------------------------------------------------------

        'print calculations and results

        rtf.AppendText("D E S I G N   F O R   S H E A R" & vbCrLf)
        rtf.AppendText("--------------------------------" & vbCrLf)

        OutputLine("Effective depth of beam, d", d, "inch")
        br()

        Dim av_over_s_1, av_over_s_2, av_over_s_min, av_over_s As Double
        Dim rootfc As Double = Math.Sqrt(fc)
        av_over_s_1 = 50 * b / fy
        av_over_s_2 = 0.75 * rootfc * b / fy
        av_over_s_min = Math.Max(av_over_s_1, av_over_s_2)
        Dim vc As Double = 2 * rootfc * b * d

        OutputLine("Shear capacity of provided section, Vc", vc / 1000, "kip")
        OutputLine("phi*Vc", phi * vc / 1000, "kip")
        br()

        If vu < phi * vc / 2 Then
            _green() : InfoLine("Vu < (phi * Vc) / 2, No shear reinforcement is required.")
        ElseIf vu <= phi * vc Then
            av_over_s = av_over_s_min
            _green() : OutputLine("Minimum Shear Reinforcement required, Av/S", av_over_s, "0.0#####", "sq.inch/inch")
            Dim spacing As Double = stdia / av_over_s
            _green() : OutputLine("Required stirrup spacing", spacing, "inch")
            br()
        Else
            Dim vs As Double = (vu - phi * vc) / phi
            OutputLine("Vs = (Vu - phi*Vc)/phi", vs / 1000, "kip")
            br()

            If vs > 4 * vc Then
                _red() : InfoLine("Vs > 4 * Vc, Section need to be revised")
            Else
                av_over_s = vs / (fy * d)
                av_over_s = Math.Max(av_over_s, av_over_s_min)
                _green() : OutputLine("Shear Reinforcement required, Av/S", av_over_s, "0.######", "sq.inch / inch")
            End If
        End If

        '----------------------------------------------------------------
        br()
        rtf.AppendText("D E S I G N   F O R   T O R S I O N" & vbCrLf)
        rtf.AppendText("-----------------------------------" & vbCrLf)


        Dim x0, y0, x1, y1 As Double
        x0 = b
        y0 = h
        x1 = x0 - 2 * (cc + stdia / 2)
        y1 = y0 - 2 * (cc + stdia / 2)
        Dim Acp As Double = x0 * y0
        Dim Pcp As Double = 2 * (x0 + y0)
        Dim A0h As Double = x1 * y1
        Dim A0 As Double = 0.85 * A0h
        Dim Ph As Double = 2 * (x1 + y1)
        InfoLine("Section Parameters:")
        Output("x1", x1, "inch")
        OutputLine(", y1", y1, "inch")
        Output("Acp", Acp, "sq.inch")
        OutputLine(", Pcp", Pcp, "inch")
        Output("A0h", A0h, "sq.inch")
        Output(", A0", A0, "sq.inch")
        OutputLine(", Ph", Ph, "inch")
        br()

        
        Dim tcr As Double = CalculateTcr(b, h, fc)
        Output("Tcr", tcr / 1000.0, "kip-inch")
        OutputLine(" (phi * Tcr", phi * tcr / 1000.0, "kip-inch)")
        br()


        If design_for_phi_Tcr Then
            If phi * tcr < tu Then
                _green() : InfoLine("Phi*Tcr < Tu, ignoring design Tu and checking for phi*Tcr")
                br()
                tu = phi * tcr
            End If
        End If











        If tu < phi * tcr / 4.0 Then
            _green() : InfoLine("Tu < phi * Tcr / 4.0, No need for torsion reinforcement.")
        Else
            Dim lhs As Double
            lhs = Math.Pow(vu / (b * d), 2.0)
            lhs += Math.Pow(tu * Ph / (1.7 * A0h * A0h), 2.0)
            lhs = Math.Sqrt(lhs)
            OutputLine("Left hand side of shear + torsion check", lhs, "psi")

            Dim rhs As Double
            rhs = vc / (b * d) + 8 * rootfc
            rhs = rhs * phi
            OutputLine("Right hand side of shear + torsion check", rhs, "psi")
            br()

            Dim section_is_adequate As Boolean = (lhs <= rhs)

            If section_is_adequate Then
                _green() : InfoLine("Section is adequate for design Vu and Tu")
                br()
                Dim at_over_s As Double = (tu / phi) / (2 * A0 * fy)
                Dim Al_min As Double = Math.Max(5 * rootfc * Acp / fy - at_over_s * Ph, 25 * b / fy)
                Dim Al As Double = Math.Max(at_over_s * Ph, Al_min)
                _green() : OutputLine("At/s", at_over_s, "0.######", "sq.inch / inch")
                _green() : OutputLine("Al", Al, "sq.inch")
                br()
                
                Dim spacing As Double = (0.785 * stdia ^ 2) / (av_over_s / 2.0 + at_over_s)
                _green() : OutputLine("Required stirrup spacing (single binder)", spacing, "inch")
                spacing = (0.785 * stdia ^ 2) / (av_over_s / 4.0 + at_over_s)
                _green() : OutputLine("Required stirrup spacing (double binder)", spacing, "inch")
                spacing = (0.785 * stdia ^ 2) / (av_over_s / 6.0 + at_over_s)
                _green() : OutputLine("Required stirrup spacing (triple binder)", spacing, "inch")

            Else
                _red() : InfoLine("Section is inadequate for shear + torsion. Revise Section")
            End If
        End If

    End Sub

    Private Sub beam_width_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beam_width.Enter, beam_width.Click, _
        beam_depth.Enter, beam_depth.Click, clear_cover.Enter, clear_cover.Click, conc_fc.Enter, conc_fc.Click, steel_fy.Enter, steel_fy.Click, _
          momentMu.Enter, momentMu.Click, shearVu.Enter, shearVu.Click, phi_shear.Enter, phi_shear.Click, torsionTu.Enter, torsionTu.Click

        sender.SelectAll()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormSerialisor.Deserialise(Me, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\sdu2-data.xml")
    End Sub


    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        FormSerialisor.Serialise(Me, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\sdu2-data.xml")
    End Sub

    
End Class
