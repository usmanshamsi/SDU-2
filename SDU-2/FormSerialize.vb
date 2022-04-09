Imports System
Imports System.IO
Imports System.Windows.Forms
Imports System.Reflection
Imports System.Xml
Imports System.Diagnostics

Namespace FormSerialisation
    Module FormSerialisor
        Sub Serialise(ByVal c As Control, ByVal XmlFileName As String)
            Dim xmlSerialisedForm As XmlTextWriter = New XmlTextWriter(XmlFileName, System.Text.Encoding.[Default])
            xmlSerialisedForm.Formatting = Formatting.Indented
            xmlSerialisedForm.WriteStartDocument()
            xmlSerialisedForm.WriteStartElement("ChildForm")
            AddChildControls(xmlSerialisedForm, c)
            xmlSerialisedForm.WriteEndElement()
            xmlSerialisedForm.WriteEndDocument()
            xmlSerialisedForm.Flush()
            xmlSerialisedForm.Close()
        End Sub

        Private Sub AddChildControls(ByVal xmlSerialisedForm As XmlTextWriter, ByVal c As Control)
            For Each childCtrl As Control In c.Controls

                If Not (TypeOf childCtrl Is Label) Then
                    xmlSerialisedForm.WriteStartElement("Control")
                    xmlSerialisedForm.WriteAttributeString("Type", childCtrl.[GetType]().ToString())
                    xmlSerialisedForm.WriteAttributeString("Name", childCtrl.Name)

                    If TypeOf childCtrl Is TextBox Then
                        xmlSerialisedForm.WriteElementString("Text", (CType(childCtrl, TextBox)).Text)
                    ElseIf TypeOf childCtrl Is ComboBox Then
                        xmlSerialisedForm.WriteElementString("Text", (CType(childCtrl, ComboBox)).Text)
                        xmlSerialisedForm.WriteElementString("SelectedIndex", (CType(childCtrl, ComboBox)).SelectedIndex.ToString())
                    ElseIf TypeOf childCtrl Is ListBox Then
                        Dim lst As ListBox = CType(childCtrl, ListBox)

                        If lst.SelectedIndex = -1 Then
                            xmlSerialisedForm.WriteElementString("SelectedIndex", "-1")
                        Else

                            For i As Integer = 0 To lst.SelectedIndices.Count - 1
                                xmlSerialisedForm.WriteElementString("SelectedIndex", (lst.SelectedIndices(i).ToString()))
                            Next
                        End If
                    ElseIf TypeOf childCtrl Is CheckBox Then
                        xmlSerialisedForm.WriteElementString("Checked", (CType(childCtrl, CheckBox)).Checked.ToString())
                    ElseIf TypeOf childCtrl Is RadioButton Then
                        xmlSerialisedForm.WriteElementString("Checked", (CType(childCtrl, RadioButton)).Checked.ToString())
                    End If

                    Dim visible As Boolean = CBool(GetType(Control).GetMethod("GetState", BindingFlags.Instance Or BindingFlags.NonPublic).Invoke(childCtrl, New Object() {2}))
                    xmlSerialisedForm.WriteElementString("Visible", visible.ToString())

                    If childCtrl.HasChildren Then

                        If TypeOf childCtrl Is SplitContainer Then
                            AddChildControls(xmlSerialisedForm, (CType(childCtrl, SplitContainer)).Panel1)
                            AddChildControls(xmlSerialisedForm, (CType(childCtrl, SplitContainer)).Panel2)
                        Else
                            AddChildControls(xmlSerialisedForm, childCtrl)
                        End If
                    End If

                    xmlSerialisedForm.WriteEndElement()
                End If
            Next
        End Sub

        Sub Deserialise(ByVal c As Control, ByVal XmlFileName As String)
            If File.Exists(XmlFileName) Then
                Dim xmlSerialisedForm As XmlDocument = New XmlDocument()
                xmlSerialisedForm.Load(XmlFileName)
                Dim topLevel As XmlNode = xmlSerialisedForm.ChildNodes(1)

                For Each n As XmlNode In topLevel.ChildNodes
                    SetControlProperties(CType(c, Control), n)
                Next
            End If
        End Sub

        Private Sub SetControlProperties(ByVal currentCtrl As Control, ByVal n As XmlNode)
            Dim controlName As String = n.Attributes("Name").Value
            Dim controlType As String = n.Attributes("Type").Value
            Dim ctrl As Control() = currentCtrl.Controls.Find(controlName, True)

            If ctrl.Length = 0 Then
            Else
                Dim ctrlToSet As Control = GetImmediateChildControl(ctrl, currentCtrl)

                If ctrlToSet IsNot Nothing Then

                    If ctrlToSet.[GetType]().ToString() = controlType Then

                        Select Case controlType
                            Case "System.Windows.Forms.TextBox"
                                CType(ctrlToSet, System.Windows.Forms.TextBox).Text = n("Text").InnerText
                            Case "System.Windows.Forms.ComboBox"
                                CType(ctrlToSet, System.Windows.Forms.ComboBox).Text = n("Text").InnerText
                                CType(ctrlToSet, System.Windows.Forms.ComboBox).SelectedIndex = Convert.ToInt32(n("SelectedIndex").InnerText)
                            Case "System.Windows.Forms.ListBox"
                                Dim lst As ListBox = CType(ctrlToSet, ListBox)
                                Dim xnlSelectedIndex As XmlNodeList = n.SelectNodes("SelectedIndex")

                                For i As Integer = 0 To xnlSelectedIndex.Count - 1
                                    lst.SelectedIndex = Convert.ToInt32(xnlSelectedIndex(i).InnerText)
                                Next

                            Case "System.Windows.Forms.CheckBox"
                                CType(ctrlToSet, System.Windows.Forms.CheckBox).Checked = Convert.ToBoolean(n("Checked").InnerText)
                            Case "System.Windows.Forms.RadioButton"
                                CType(ctrlToSet, System.Windows.Forms.RadioButton).Checked = Convert.ToBoolean(n("Checked").InnerText)
                        End Select

                        ctrlToSet.Visible = Convert.ToBoolean(n("Visible").InnerText)

                        If n.HasChildNodes AndAlso ctrlToSet.HasChildren Then
                            Dim xnlControls As XmlNodeList = n.SelectNodes("Control")

                            For Each n2 As XmlNode In xnlControls
                                SetControlProperties(ctrlToSet, n2)
                            Next
                        End If
                    Else
                    End If
                Else
                End If
            End If
        End Sub

        Private Function GetImmediateChildControl(ByVal ctrl As Control(), ByVal currentCtrl As Control) As Control
            Dim c As Control = Nothing

            For i As Integer = 0 To ctrl.Length - 1

                If (ctrl(i).Parent.Name = currentCtrl.Name) OrElse (TypeOf currentCtrl Is SplitContainer AndAlso ctrl(i).Parent.Parent.Name = currentCtrl.Name) Then
                    c = ctrl(i)
                    Exit For
                End If
            Next

            Return c
        End Function
    End Module
End Namespace
