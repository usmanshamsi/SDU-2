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
        Me.design_button = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.momentMu = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
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
        Me.Label20 = New System.Windows.Forms.Label()
        Me.shearVu = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.phi_shear = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.torsionTu = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.limitTu_checkbox = New System.Windows.Forms.CheckBox()
        Me.dShearTorsion = New System.Windows.Forms.RadioButton()
        Me.dShear = New System.Windows.Forms.RadioButton()
        Me.dFlexure = New System.Windows.Forms.RadioButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.print_input_checkbox = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Width of Beam (b)"
        '
        'beam_width
        '
        Me.beam_width.Location = New System.Drawing.Point(274, 12)
        Me.beam_width.Name = "beam_width"
        Me.beam_width.Size = New System.Drawing.Size(85, 22)
        Me.beam_width.TabIndex = 0
        Me.beam_width.Text = "12"
        Me.beam_width.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(365, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "inch"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(196, 17)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Tensile Strength of Rebar (fy)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(365, 253)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 17)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "psi"
        '
        'steel_fy
        '
        Me.steel_fy.Location = New System.Drawing.Point(274, 250)
        Me.steel_fy.Name = "steel_fy"
        Me.steel_fy.Size = New System.Drawing.Size(85, 22)
        Me.steel_fy.TabIndex = 6
        Me.steel_fy.Text = "60000"
        Me.steel_fy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(252, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Compressive Strength of Concrete (f'c)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(365, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "psi"
        '
        'conc_fc
        '
        Me.conc_fc.Location = New System.Drawing.Point(274, 222)
        Me.conc_fc.Name = "conc_fc"
        Me.conc_fc.Size = New System.Drawing.Size(85, 22)
        Me.conc_fc.TabIndex = 5
        Me.conc_fc.Text = "3000"
        Me.conc_fc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Clear Cover (cc)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(365, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "inch"
        '
        'clear_cover
        '
        Me.clear_cover.Location = New System.Drawing.Point(274, 68)
        Me.clear_cover.Name = "clear_cover"
        Me.clear_cover.Size = New System.Drawing.Size(85, 22)
        Me.clear_cover.TabIndex = 2
        Me.clear_cover.Text = "1.5"
        Me.clear_cover.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Overall Depth of Beam (h)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(365, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "inch"
        '
        'beam_depth
        '
        Me.beam_depth.Location = New System.Drawing.Point(274, 40)
        Me.beam_depth.Name = "beam_depth"
        Me.beam_depth.Size = New System.Drawing.Size(85, 22)
        Me.beam_depth.TabIndex = 1
        Me.beam_depth.Text = "24"
        Me.beam_depth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rtf
        '
        Me.rtf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtf.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtf.Location = New System.Drawing.Point(10, 10)
        Me.rtf.Name = "rtf"
        Me.rtf.Size = New System.Drawing.Size(844, 702)
        Me.rtf.TabIndex = 0
        Me.rtf.TabStop = False
        Me.rtf.Text = ""
        '
        'design_button
        '
        Me.design_button.Location = New System.Drawing.Point(14, 521)
        Me.design_button.Name = "design_button"
        Me.design_button.Size = New System.Drawing.Size(143, 36)
        Me.design_button.TabIndex = 13
        Me.design_button.Text = "Design"
        Me.design_button.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(365, 281)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 17)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Kip-ft"
        '
        'momentMu
        '
        Me.momentMu.Location = New System.Drawing.Point(274, 278)
        Me.momentMu.Name = "momentMu"
        Me.momentMu.Size = New System.Drawing.Size(85, 22)
        Me.momentMu.TabIndex = 7
        Me.momentMu.Text = "50"
        Me.momentMu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 281)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(195, 17)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Design Bending Moment (Mu)"
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
        Me.Panel1.Location = New System.Drawing.Point(120, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 31)
        Me.Panel1.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 100)
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
        Me.Panel2.Location = New System.Drawing.Point(120, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(239, 84)
        Me.Panel2.TabIndex = 4
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
        Me.Label17.Location = New System.Drawing.Point(13, 137)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 17)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Main Bar"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(13, 309)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(165, 17)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Design Shear Force (Vu)"
        '
        'shearVu
        '
        Me.shearVu.Location = New System.Drawing.Point(274, 306)
        Me.shearVu.Name = "shearVu"
        Me.shearVu.Size = New System.Drawing.Size(85, 22)
        Me.shearVu.TabIndex = 8
        Me.shearVu.Text = "50"
        Me.shearVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(365, 309)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(28, 17)
        Me.Label21.TabIndex = 25
        Me.Label21.Text = "Kip"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(13, 337)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(235, 17)
        Me.Label22.TabIndex = 29
        Me.Label22.Text = "Strength Reduction Factor for shear"
        '
        'phi_shear
        '
        Me.phi_shear.Location = New System.Drawing.Point(274, 334)
        Me.phi_shear.Name = "phi_shear"
        Me.phi_shear.Size = New System.Drawing.Size(85, 22)
        Me.phi_shear.TabIndex = 9
        Me.phi_shear.Text = "0.75"
        Me.phi_shear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 365)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(135, 17)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Design Torsion (Tu)"
        '
        'torsionTu
        '
        Me.torsionTu.Location = New System.Drawing.Point(274, 362)
        Me.torsionTu.Name = "torsionTu"
        Me.torsionTu.Size = New System.Drawing.Size(85, 22)
        Me.torsionTu.TabIndex = 10
        Me.torsionTu.Text = "100"
        Me.torsionTu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(365, 365)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(59, 17)
        Me.Label23.TabIndex = 32
        Me.Label23.Text = "Kip-Inch"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.limitTu_checkbox)
        Me.Panel3.Controls.Add(Me.dShearTorsion)
        Me.Panel3.Controls.Add(Me.dShear)
        Me.Panel3.Controls.Add(Me.dFlexure)
        Me.Panel3.Location = New System.Drawing.Point(-2, 390)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(408, 125)
        Me.Panel3.TabIndex = 11
        '
        'limitTu_checkbox
        '
        Me.limitTu_checkbox.AutoSize = True
        Me.limitTu_checkbox.Location = New System.Drawing.Point(40, 98)
        Me.limitTu_checkbox.Name = "limitTu_checkbox"
        Me.limitTu_checkbox.Size = New System.Drawing.Size(338, 21)
        Me.limitTu_checkbox.TabIndex = 3
        Me.limitTu_checkbox.Text = "Limit Design Tu to Compatibility Torsion (phi*Tcr)"
        Me.limitTu_checkbox.UseVisualStyleBackColor = True
        '
        'dShearTorsion
        '
        Me.dShearTorsion.AutoSize = True
        Me.dShearTorsion.Location = New System.Drawing.Point(16, 70)
        Me.dShearTorsion.Name = "dShearTorsion"
        Me.dShearTorsion.Size = New System.Drawing.Size(216, 21)
        Me.dShearTorsion.TabIndex = 2
        Me.dShearTorsion.Text = "Design for Shear and Torsion"
        Me.dShearTorsion.UseVisualStyleBackColor = True
        '
        'dShear
        '
        Me.dShear.AutoSize = True
        Me.dShear.Location = New System.Drawing.Point(16, 43)
        Me.dShear.Name = "dShear"
        Me.dShear.Size = New System.Drawing.Size(136, 21)
        Me.dShear.TabIndex = 1
        Me.dShear.Text = "Design for Shear"
        Me.dShear.UseVisualStyleBackColor = True
        '
        'dFlexure
        '
        Me.dFlexure.AutoSize = True
        Me.dFlexure.Checked = True
        Me.dFlexure.Location = New System.Drawing.Point(16, 16)
        Me.dFlexure.Name = "dFlexure"
        Me.dFlexure.Size = New System.Drawing.Size(144, 21)
        Me.dFlexure.TabIndex = 0
        Me.dFlexure.TabStop = True
        Me.dFlexure.Text = "Design for Flexure"
        Me.dFlexure.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.AutoSize = True
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.rtf)
        Me.Panel4.Location = New System.Drawing.Point(430, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel4.Size = New System.Drawing.Size(866, 724)
        Me.Panel4.TabIndex = 37
        '
        'print_input_checkbox
        '
        Me.print_input_checkbox.AutoSize = True
        Me.print_input_checkbox.Location = New System.Drawing.Point(305, 530)
        Me.print_input_checkbox.Name = "print_input_checkbox"
        Me.print_input_checkbox.Size = New System.Drawing.Size(101, 21)
        Me.print_input_checkbox.TabIndex = 12
        Me.print_input_checkbox.Text = "Print Inputs"
        Me.print_input_checkbox.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(11, 689)
        Me.Label11.Name = "Label11"
        Me.Label11.Padding = New System.Windows.Forms.Padding(5)
        Me.Label11.Size = New System.Drawing.Size(408, 47)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Source Code is available at" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "https://github.com/usmanshamsi/SDU-2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AcceptButton = Me.design_button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1308, 748)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.print_input_checkbox)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.torsionTu)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.phi_shear)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.shearVu)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.design_button)
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
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
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
    Friend WithEvents design_button As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents momentMu As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
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
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents shearVu As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents phi_shear As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents torsionTu As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dShearTorsion As System.Windows.Forms.RadioButton
    Friend WithEvents dShear As System.Windows.Forms.RadioButton
    Friend WithEvents dFlexure As System.Windows.Forms.RadioButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents limitTu_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents print_input_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label

End Class
