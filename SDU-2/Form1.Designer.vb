<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.beam_width = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.steel_fy = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.conc_fc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.clear_cover = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.beam_depth = New System.Windows.Forms.TextBox()
        Me.rtf = New System.Windows.Forms.RichTextBox()
        Me.flexure_button = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.momentMu = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.st14 = New System.Windows.Forms.RadioButton()
        Me.st38 = New System.Windows.Forms.RadioButton()
        Me.st12 = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bar10 = New System.Windows.Forms.RadioButton()
        Me.bar9 = New System.Windows.Forms.RadioButton()
        Me.bar8 = New System.Windows.Forms.RadioButton()
        Me.bar7 = New System.Windows.Forms.RadioButton()
        Me.bar6 = New System.Windows.Forms.RadioButton()
        Me.bar5 = New System.Windows.Forms.RadioButton()
        Me.bar4 = New System.Windows.Forms.RadioButton()
        Me.bar3 = New System.Windows.Forms.RadioButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.shear_button = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.shearVu = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.phi_shear = New System.Windows.Forms.TextBox()
        Me.shear_torsion_button = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.torsionTu = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.shear_phiTcr_button = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Width of Beam (b)"
        '
        'beam_width
        '
        Me.beam_width.Location = New System.Drawing.Point(274, 35)
        Me.beam_width.Name = "beam_width"
        Me.beam_width.Size = New System.Drawing.Size(85, 22)
        Me.beam_width.TabIndex = 0
        Me.beam_width.Text = "12"
        Me.beam_width.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(365, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "inch"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 276)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(196, 17)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Tensile Strength of Rebar (fy)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(365, 276)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 17)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "psi"
        '
        'steel_fy
        '
        Me.steel_fy.Location = New System.Drawing.Point(274, 273)
        Me.steel_fy.Name = "steel_fy"
        Me.steel_fy.Size = New System.Drawing.Size(85, 22)
        Me.steel_fy.TabIndex = 4
        Me.steel_fy.Text = "60000"
        Me.steel_fy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(252, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Compressive Strength of Concrete (f'c)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(365, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "psi"
        '
        'conc_fc
        '
        Me.conc_fc.Location = New System.Drawing.Point(274, 245)
        Me.conc_fc.Name = "conc_fc"
        Me.conc_fc.Size = New System.Drawing.Size(85, 22)
        Me.conc_fc.TabIndex = 3
        Me.conc_fc.Text = "3000"
        Me.conc_fc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Clear Cover (cc)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(365, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "inch"
        '
        'clear_cover
        '
        Me.clear_cover.Location = New System.Drawing.Point(274, 91)
        Me.clear_cover.Name = "clear_cover"
        Me.clear_cover.Size = New System.Drawing.Size(85, 22)
        Me.clear_cover.TabIndex = 2
        Me.clear_cover.Text = "1.5"
        Me.clear_cover.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Overall Depth of Beam (h)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(365, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "inch"
        '
        'beam_depth
        '
        Me.beam_depth.Location = New System.Drawing.Point(274, 63)
        Me.beam_depth.Name = "beam_depth"
        Me.beam_depth.Size = New System.Drawing.Size(85, 22)
        Me.beam_depth.TabIndex = 1
        Me.beam_depth.Text = "24"
        Me.beam_depth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rtf
        '
        Me.rtf.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtf.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtf.Location = New System.Drawing.Point(430, 10)
        Me.rtf.Name = "rtf"
        Me.rtf.Size = New System.Drawing.Size(866, 670)
        Me.rtf.TabIndex = 0
        Me.rtf.TabStop = False
        Me.rtf.Text = ""
        '
        'flexure_button
        '
        Me.flexure_button.Location = New System.Drawing.Point(216, 385)
        Me.flexure_button.Name = "flexure_button"
        Me.flexure_button.Size = New System.Drawing.Size(143, 31)
        Me.flexure_button.TabIndex = 6
        Me.flexure_button.Text = "Design for Flexure"
        Me.flexure_button.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(365, 351)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 17)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Kip-ft"
        '
        'momentMu
        '
        Me.momentMu.Location = New System.Drawing.Point(274, 348)
        Me.momentMu.Name = "momentMu"
        Me.momentMu.Size = New System.Drawing.Size(85, 22)
        Me.momentMu.TabIndex = 0
        Me.momentMu.Text = "50"
        Me.momentMu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 351)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(195, 17)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Design Bending Moment (Mu)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(13, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(186, 18)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Beam Size and Material"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(13, 323)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(146, 18)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Design for Flexure"
        '
        'st14
        '
        Me.st14.AutoSize = True
        Me.st14.Location = New System.Drawing.Point(18, 3)
        Me.st14.Name = "st14"
        Me.st14.Size = New System.Drawing.Size(54, 21)
        Me.st14.TabIndex = 0
        Me.st14.Text = "1/4"""
        Me.st14.UseVisualStyleBackColor = True
        '
        'st38
        '
        Me.st38.AutoSize = True
        Me.st38.Location = New System.Drawing.Point(95, 3)
        Me.st38.Name = "st38"
        Me.st38.Size = New System.Drawing.Size(54, 21)
        Me.st38.TabIndex = 1
        Me.st38.Text = "3/8"""
        Me.st38.UseVisualStyleBackColor = True
        '
        'st12
        '
        Me.st12.AutoSize = True
        Me.st12.Checked = True
        Me.st12.Location = New System.Drawing.Point(173, 3)
        Me.st12.Name = "st12"
        Me.st12.Size = New System.Drawing.Size(54, 21)
        Me.st12.TabIndex = 2
        Me.st12.TabStop = True
        Me.st12.Text = "1/2"""
        Me.st12.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.st12)
        Me.Panel1.Controls.Add(Me.st38)
        Me.Panel1.Controls.Add(Me.st14)
        Me.Panel1.Location = New System.Drawing.Point(120, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 31)
        Me.Panel1.TabIndex = 20
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 123)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 17)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "Stirrup Bar"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.bar10)
        Me.Panel2.Controls.Add(Me.bar9)
        Me.Panel2.Controls.Add(Me.bar8)
        Me.Panel2.Controls.Add(Me.bar7)
        Me.Panel2.Controls.Add(Me.bar6)
        Me.Panel2.Controls.Add(Me.bar5)
        Me.Panel2.Controls.Add(Me.bar4)
        Me.Panel2.Controls.Add(Me.bar3)
        Me.Panel2.Location = New System.Drawing.Point(120, 155)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(239, 84)
        Me.Panel2.TabIndex = 22
        '
        'bar10
        '
        Me.bar10.AutoSize = True
        Me.bar10.Location = New System.Drawing.Point(95, 58)
        Me.bar10.Name = "bar10"
        Me.bar10.Size = New System.Drawing.Size(53, 21)
        Me.bar10.TabIndex = 7
        Me.bar10.Text = "#10"
        Me.bar10.UseVisualStyleBackColor = True
        '
        'bar9
        '
        Me.bar9.AutoSize = True
        Me.bar9.Location = New System.Drawing.Point(18, 58)
        Me.bar9.Name = "bar9"
        Me.bar9.Size = New System.Drawing.Size(45, 21)
        Me.bar9.TabIndex = 6
        Me.bar9.Text = "#9"
        Me.bar9.UseVisualStyleBackColor = True
        '
        'bar8
        '
        Me.bar8.AutoSize = True
        Me.bar8.Checked = True
        Me.bar8.Location = New System.Drawing.Point(173, 30)
        Me.bar8.Name = "bar8"
        Me.bar8.Size = New System.Drawing.Size(45, 21)
        Me.bar8.TabIndex = 5
        Me.bar8.TabStop = True
        Me.bar8.Text = "#8"
        Me.bar8.UseVisualStyleBackColor = True
        '
        'bar7
        '
        Me.bar7.AutoSize = True
        Me.bar7.Location = New System.Drawing.Point(95, 31)
        Me.bar7.Name = "bar7"
        Me.bar7.Size = New System.Drawing.Size(45, 21)
        Me.bar7.TabIndex = 4
        Me.bar7.Text = "#7"
        Me.bar7.UseVisualStyleBackColor = True
        '
        'bar6
        '
        Me.bar6.AutoSize = True
        Me.bar6.Location = New System.Drawing.Point(18, 31)
        Me.bar6.Name = "bar6"
        Me.bar6.Size = New System.Drawing.Size(45, 21)
        Me.bar6.TabIndex = 3
        Me.bar6.Text = "#6"
        Me.bar6.UseVisualStyleBackColor = True
        '
        'bar5
        '
        Me.bar5.AutoSize = True
        Me.bar5.Location = New System.Drawing.Point(173, 3)
        Me.bar5.Name = "bar5"
        Me.bar5.Size = New System.Drawing.Size(45, 21)
        Me.bar5.TabIndex = 2
        Me.bar5.Text = "#5"
        Me.bar5.UseVisualStyleBackColor = True
        '
        'bar4
        '
        Me.bar4.AutoSize = True
        Me.bar4.Location = New System.Drawing.Point(95, 4)
        Me.bar4.Name = "bar4"
        Me.bar4.Size = New System.Drawing.Size(45, 21)
        Me.bar4.TabIndex = 1
        Me.bar4.Text = "#4"
        Me.bar4.UseVisualStyleBackColor = True
        '
        'bar3
        '
        Me.bar3.AutoSize = True
        Me.bar3.Location = New System.Drawing.Point(18, 4)
        Me.bar3.Name = "bar3"
        Me.bar3.Size = New System.Drawing.Size(45, 21)
        Me.bar3.TabIndex = 0
        Me.bar3.Text = "#3"
        Me.bar3.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 160)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 17)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Main Bar"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(13, 450)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(230, 18)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Design for Shear and Torsion"
        '
        'shear_button
        '
        Me.shear_button.Location = New System.Drawing.Point(16, 569)
        Me.shear_button.Name = "shear_button"
        Me.shear_button.Size = New System.Drawing.Size(88, 87)
        Me.shear_button.TabIndex = 26
        Me.shear_button.Text = "Design for Shear"
        Me.shear_button.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(13, 478)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(165, 17)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Design Shear Force (Vu)"
        '
        'shearVu
        '
        Me.shearVu.Location = New System.Drawing.Point(274, 475)
        Me.shearVu.Name = "shearVu"
        Me.shearVu.Size = New System.Drawing.Size(85, 22)
        Me.shearVu.TabIndex = 23
        Me.shearVu.Text = "50"
        Me.shearVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(365, 478)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(28, 17)
        Me.Label21.TabIndex = 25
        Me.Label21.Text = "Kip"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(13, 506)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(242, 17)
        Me.Label22.TabIndex = 29
        Me.Label22.Text = "Strength Reduction Factor, phi-shear"
        '
        'phi_shear
        '
        Me.phi_shear.Location = New System.Drawing.Point(274, 503)
        Me.phi_shear.Name = "phi_shear"
        Me.phi_shear.Size = New System.Drawing.Size(85, 22)
        Me.phi_shear.TabIndex = 28
        Me.phi_shear.Text = "0.75"
        Me.phi_shear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'shear_torsion_button
        '
        Me.shear_torsion_button.Location = New System.Drawing.Point(110, 569)
        Me.shear_torsion_button.Name = "shear_torsion_button"
        Me.shear_torsion_button.Size = New System.Drawing.Size(98, 87)
        Me.shear_torsion_button.TabIndex = 33
        Me.shear_torsion_button.Text = "Design for Shear and Torsion"
        Me.shear_torsion_button.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 534)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(135, 17)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Design Torsion (Tu)"
        '
        'torsionTu
        '
        Me.torsionTu.Location = New System.Drawing.Point(274, 531)
        Me.torsionTu.Name = "torsionTu"
        Me.torsionTu.Size = New System.Drawing.Size(85, 22)
        Me.torsionTu.TabIndex = 30
        Me.torsionTu.Text = "100"
        Me.torsionTu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(365, 534)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(59, 17)
        Me.Label23.TabIndex = 32
        Me.Label23.Text = "Kip-Inch"
        '
        'shear_phiTcr_button
        '
        Me.shear_phiTcr_button.Location = New System.Drawing.Point(216, 569)
        Me.shear_phiTcr_button.Name = "shear_phiTcr_button"
        Me.shear_phiTcr_button.Size = New System.Drawing.Size(144, 87)
        Me.shear_phiTcr_button.TabIndex = 35
        Me.shear_phiTcr_button.Text = "Design for Shear and Compatibility Torsion (phi-Tcr)"
        Me.shear_phiTcr_button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.flexure_button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1308, 692)
        Me.Controls.Add(Me.shear_phiTcr_button)
        Me.Controls.Add(Me.shear_torsion_button)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.torsionTu)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.phi_shear)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.shear_button)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.shearVu)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.rtf)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.flexure_button)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.momentMu)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.beam_width)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.steel_fy)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.beam_depth)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.conc_fc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.clear_cover)
        Me.Controls.Add(Me.Label6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "SDU-2 (Rectangular Beam Design)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents beam_width As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents steel_fy As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents conc_fc As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents clear_cover As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents beam_depth As System.Windows.Forms.TextBox
    Friend WithEvents rtf As System.Windows.Forms.RichTextBox
    Friend WithEvents flexure_button As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents momentMu As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents st12 As System.Windows.Forms.RadioButton
    Friend WithEvents st38 As System.Windows.Forms.RadioButton
    Friend WithEvents st14 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents bar8 As System.Windows.Forms.RadioButton
    Friend WithEvents bar7 As System.Windows.Forms.RadioButton
    Friend WithEvents bar6 As System.Windows.Forms.RadioButton
    Friend WithEvents bar5 As System.Windows.Forms.RadioButton
    Friend WithEvents bar4 As System.Windows.Forms.RadioButton
    Friend WithEvents bar3 As System.Windows.Forms.RadioButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents bar10 As System.Windows.Forms.RadioButton
    Friend WithEvents bar9 As System.Windows.Forms.RadioButton
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents shear_button As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents shearVu As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents phi_shear As System.Windows.Forms.TextBox
    Friend WithEvents shear_torsion_button As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents torsionTu As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents shear_phiTcr_button As System.Windows.Forms.Button

End Class
