Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a.Text = Form1.ComboBox1.Text
        b.Text = Form1.ComboBox2.Text
        va.Text = Form1.Label27.Text
        vb.Text = Form1.TextBox4.Text
        Label19.Text = Form1.TextBox1.Text
        Label16.Text = Form1.TextBox3.Text
        Label21.Text = Form1.TextBox2.Text
        Label11.Text = Form1.TextBox5.Text
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "entration of B in mol/dm cube" Then
            If a.Text = "Hydrochloric Acid" Then
                If b.Text = "Sodium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label21.Text & ", Volume of Base =" & Label16.Text & "")
                                        ListBox1.Items.Add("       Mass Conc. of Base = (Mass of Base * 1000)/Volume of Base")
                                        ListBox1.Items.Add("       Mass Conc. of B = ((" & Label21.Text & ") * 1000 )/(" & Label16.Text & ") ")
                                        Dim X1 As Double = Val(Label21.Text) * 1000
                                        Dim x2 As Double = Val(Label16.Text)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)))
                                        ListBox1.Items.Add("Therefore, Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) & " g/dm cube")
                                        Dim x As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))
                                        ListBox1.Items.Add("                                                                                    ")
                                        ListBox1.Items.Add("      Molar Mass of Base = 40")
                                        ListBox1.Items.Add("      Molar Conc. of B = (Mass Conc.)/(Molar Mass)")
                                        Dim x3 As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))
                                        Dim x4 As Double = 40
                                        ListBox1.Items.Add("      Molar Conc. of B = " & x3 & " / " & x4)
                                        ListBox1.Items.Add("      Molar Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 40 & " mol/dm cube")
                                        Dim y As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 40
                                        ListBox1.Items.Add(" Therefore, Molar Conc. of B = " & CStr(Math.Round(Val(y), 4)) & " mol/dm cube")
                                        Label23.Text = CStr(Math.Round(Val(y), 4))
                                        Label23.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in mol/dm cube" Then
            If a.Text = "Hydrochloric Acid" Then
                If b.Text = "Sodium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        If Label11.Text <> "" Then
                                            ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                            ListBox1.Items.Add(" Base = " & b.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("Mass of Base = " & Label11.Text & "")
                                            ListBox1.Items.Add("      Molar Conc. of B = (Mass Conc.)/(Molar Mass)")
                                            Dim x3 As Double = Val(Label11.Text)
                                            Dim x4 As Double = 40
                                            ListBox1.Items.Add("      Molar Conc. of B = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("      Molar Conc. of B = " & Val(Label11.Text) / 40 & " mol/dm cube")
                                            Dim y As Double = Val(Label11.Text) / 40
                                            ListBox1.Items.Add(" Therefore, Molar Conc. of B = " & CStr(Math.Round(Val(y), 4)) & " mol/dm cube")
                                            Label23.Text = CStr(Math.Round(Val(y), 4))
                                            Label23.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If ComboBox1.Text = "Concentration of B in mol/dm cube" Then
            If a.Text = "Hydrochloric Acid" Then
                If b.Text = "Potassium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label21.Text & ", Volume of Base =" & Label16.Text & "")
                                        ListBox1.Items.Add("       Mass Conc. of Base = (Mass of Base * 1000)/Volume of Base")
                                        ListBox1.Items.Add("       Mass Conc. of B = ((" & Label21.Text & ") * 1000 )/(" & Label16.Text & ") ")
                                        Dim X1 As Double = Val(Label21.Text) * 1000
                                        Dim x2 As Double = Val(Label16.Text)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)))
                                        ListBox1.Items.Add("Therefore, Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) & " g/dm cube")
                                        Dim x As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))
                                        ListBox1.Items.Add("                                                                                    ")
                                        ListBox1.Items.Add("      Molar Mass of Base = 56")
                                        ListBox1.Items.Add("      Molar Conc. of B = (Mass Conc.)/(Molar Mass)")
                                        Dim x3 As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))
                                        Dim x4 As Double = 56
                                        ListBox1.Items.Add("      Molar Conc. of B = " & x3 & " / " & x4)
                                        ListBox1.Items.Add("      Molar Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 56 & " mol/dm cube")
                                        Dim y As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 56
                                        ListBox1.Items.Add(" Therefore, Molar Conc. of B = " & CStr(Math.Round(Val(y), 4)) & " mol/dm cube")
                                        Label23.Text = CStr(Math.Round(Val(y), 4))
                                        Label23.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in mol/dm cube" Then
            If a.Text = "Hydrochloric Acid" Then
                If b.Text = "Potassium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        If Label11.Text <> "" Then
                                            ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                            ListBox1.Items.Add(" Base = " & b.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("Mass of Base = " & Label11.Text & "")
                                            ListBox1.Items.Add("      Molar Conc. of B = (Mass Conc.)/(Molar Mass)")
                                            Dim x3 As Double = Val(Label11.Text)
                                            Dim x4 As Double = 56
                                            ListBox1.Items.Add("      Molar Conc. of B = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("      Molar Conc. of B = " & Val(Label11.Text) / 56 & " mol/dm cube")
                                            Dim y As Double = Val(Label11.Text) / 56
                                            ListBox1.Items.Add(" Therefore, Molar Conc. of B = " & CStr(Math.Round(Val(y), 4)) & " mol/dm cube")
                                            Label23.Text = CStr(Math.Round(Val(y), 4))
                                            Label23.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in mol/dm cube" Then
            If a.Text = "Hydrochloric Acid" Then
                If b.Text = "Sodium Trioxocarbonate(iv)" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label21.Text & ", Volume of Base =" & Label16.Text & "")
                                        ListBox1.Items.Add("       Mass Conc. of Base = (Mass of Base * 1000)/Volume of Base")
                                        ListBox1.Items.Add("       Mass Conc. of B = ((" & Label21.Text & ") * 1000 )/(" & Label16.Text & ") ")
                                        Dim X1 As Double = Val(Label21.Text) * 1000
                                        Dim x2 As Double = Val(Label16.Text)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)))
                                        ListBox1.Items.Add("Therefore, Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) & " g/dm cube")
                                        Dim x As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))
                                        ListBox1.Items.Add("                                                                                    ")
                                        ListBox1.Items.Add("      Molar Mass of Base = 106")
                                        ListBox1.Items.Add("      Molar Conc. of B = (Mass Conc.)/(Molar Mass)")
                                        Dim x3 As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))
                                        Dim x4 As Double = 106
                                        ListBox1.Items.Add("      Molar Conc. of B = " & x3 & " / " & x4)
                                        ListBox1.Items.Add("      Molar Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 106 & " mol/dm cube")
                                        Dim y As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 106
                                        ListBox1.Items.Add(" Therefore, Molar Conc. of B = " & CStr(Math.Round(Val(y), 4)) & " mol/dm cube")
                                        Label23.Text = CStr(Math.Round(Val(y), 4))
                                        Label23.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in mol/dm cube" Then
            If a.Text = "Hydrochloric Acid" Then
                If b.Text = "Sodium Trioxocarbonate(iv)" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        If Label11.Text <> "" Then
                                            ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                            ListBox1.Items.Add(" Base = " & b.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("Mass of Base = " & Label11.Text & "")
                                            ListBox1.Items.Add("      Molar Conc. of B = (Mass Conc.)/(Molar Mass)")
                                            Dim x3 As Double = Val(Label11.Text)
                                            Dim x4 As Double = 106
                                            ListBox1.Items.Add("      Molar Conc. of B = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("      Molar Conc. of B = " & Val(Label11.Text) / 106 & " mol/dm cube")
                                            Dim y As Double = Val(Label11.Text) / 106
                                            ListBox1.Items.Add(" Therefore, Molar Conc. of B = " & CStr(Math.Round(Val(y), 4)) & " mol/dm cube")
                                            Label23.Text = CStr(Math.Round(Val(y), 4))
                                            Label23.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If ComboBox1.Text = "Concentration of B in mol/dm cube" Then
            If a.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                If b.Text = "Sodium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label21.Text & ", Volume of Base =" & Label16.Text & "")
                                        ListBox1.Items.Add("       Mass Conc. of Base = (Mass of Base * 1000)/Volume of Base")
                                        ListBox1.Items.Add("       Mass Conc. of B = ((" & Label21.Text & ") * 1000 )/(" & Label16.Text & ") ")
                                        Dim X1 As Double = Val(Label21.Text) * 1000
                                        Dim x2 As Double = Val(Label16.Text)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)))
                                        ListBox1.Items.Add("Therefore, Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) & " g/dm cube")
                                        Dim x As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))
                                        ListBox1.Items.Add("                                                                                    ")
                                        ListBox1.Items.Add("      Molar Mass of Base = 40")
                                        ListBox1.Items.Add("      Molar Conc. of B = (Mass Conc.)/(Molar Mass)")
                                        Dim x3 As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))
                                        Dim x4 As Double = 40
                                        ListBox1.Items.Add("      Molar Conc. of B = " & x3 & " / " & x4)
                                        ListBox1.Items.Add("      Molar Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 40 & " mol/dm cube")
                                        Dim y As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 40
                                        ListBox1.Items.Add(" Therefore, Molar Conc. of B = " & CStr(Math.Round(Val(y), 4)) & " mol/dm cube")
                                        Label23.Text = CStr(Math.Round(Val(y), 4))
                                        Label23.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in mol/dm cube" Then
            If a.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                If b.Text = "Sodium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        If Label11.Text <> "" Then
                                            ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                            ListBox1.Items.Add(" Base = " & b.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("Mass of Base = " & Label11.Text & "")
                                            ListBox1.Items.Add("      Molar Conc. of B = (Mass Conc.)/(Molar Mass)")
                                            Dim x3 As Double = Val(Label11.Text)
                                            Dim x4 As Double = 40
                                            ListBox1.Items.Add("      Molar Conc. of B = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("      Molar Conc. of B = " & Val(Label11.Text) / 40 & " mol/dm cube")
                                            Dim y As Double = Val(Label11.Text) / 40
                                            ListBox1.Items.Add(" Therefore, Molar Conc. of B = " & CStr(Math.Round(Val(y), 4)) & " mol/dm cube")
                                            Label23.Text = CStr(Math.Round(Val(y), 4))
                                            Label23.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in mol/dm cube" Then
            If a.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                If b.Text = "Potassium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label21.Text & ", Volume of Base =" & Label16.Text & "")
                                        ListBox1.Items.Add("       Mass Conc. of Base = (Mass of Base * 1000)/Volume of Base")
                                        ListBox1.Items.Add("       Mass Conc. of B = ((" & Label21.Text & ") * 1000 )/(" & Label16.Text & ") ")
                                        Dim X1 As Double = Val(Label21.Text) * 1000
                                        Dim x2 As Double = Val(Label16.Text)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)))
                                        ListBox1.Items.Add("Therefore, Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) & " g/dm cube")
                                        Dim x As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))
                                        ListBox1.Items.Add("                                                                                    ")
                                        ListBox1.Items.Add("      Molar Mass of Base = 56")
                                        ListBox1.Items.Add("      Molar Conc. of B = (Mass Conc.)/(Molar Mass)")
                                        Dim x3 As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))
                                        Dim x4 As Double = 56
                                        ListBox1.Items.Add("      Molar Conc. of B = " & x3 & " / " & x4)
                                        ListBox1.Items.Add("      Molar Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 56 & " mol/dm cube")
                                        Dim y As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 56
                                        ListBox1.Items.Add(" Therefore, Molar Conc. of B = " & CStr(Math.Round(Val(y), 4)) & " mol/dm cube")
                                        Label23.Text = CStr(Math.Round(Val(y), 4))
                                        Label23.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in mol/dm cube" Then
            If a.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                If b.Text = "Potassium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        If Label11.Text <> "" Then
                                            ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                            ListBox1.Items.Add(" Base = " & b.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("Mass of Base = " & Label11.Text & "")
                                            ListBox1.Items.Add("      Molar Conc. of B = (Mass Conc.)/(Molar Mass)")
                                            Dim x3 As Double = Val(Label11.Text)
                                            Dim x4 As Double = 56
                                            ListBox1.Items.Add("      Molar Conc. of B = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("      Molar Conc. of B = " & Val(Label11.Text) / 56 & " mol/dm cube")
                                            Dim y As Double = Val(Label11.Text) / 56
                                            ListBox1.Items.Add(" Therefore, Molar Conc. of B = " & CStr(Math.Round(Val(y), 4)) & " mol/dm cube")
                                            Label23.Text = CStr(Math.Round(Val(y), 4))
                                            Label23.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in mol/dm cube" Then
            If a.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                If b.Text = "Sodium Trioxocarbonate(iv)" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label21.Text & ", Volume of Base =" & Label16.Text & "")
                                        ListBox1.Items.Add("       Mass Conc. of Base = (Mass of Base * 1000)/Volume of Base")
                                        ListBox1.Items.Add("       Mass Conc. of B = ((" & Label21.Text & ") * 1000 )/(" & Label16.Text & ") ")
                                        Dim X1 As Double = Val(Label21.Text) * 1000
                                        Dim x2 As Double = Val(Label16.Text)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)))
                                        ListBox1.Items.Add("Therefore, Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) & " g/dm cube")
                                        Dim x As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))
                                        ListBox1.Items.Add("                                                                                    ")
                                        ListBox1.Items.Add("      Molar Mass of Base = 106")
                                        ListBox1.Items.Add("      Molar Conc. of B = (Mass Conc.)/(Molar Mass)")
                                        Dim x3 As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))
                                        Dim x4 As Double = 106
                                        ListBox1.Items.Add("      Molar Conc. of B = " & x3 & " / " & x4)
                                        ListBox1.Items.Add("      Molar Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 106 & " mol/dm cube")
                                        Dim y As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 106
                                        ListBox1.Items.Add(" Therefore, Molar Conc. of B = " & CStr(Math.Round(Val(y), 4)) & " mol/dm cube")
                                        Label23.Text = CStr(Math.Round(Val(y), 4))
                                        Label23.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in mol/dm cube" Then
            If a.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                If b.Text = "Sodium Trioxocarbonate(iv)" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        If Label11.Text <> "" Then
                                            ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                            ListBox1.Items.Add(" Base = " & b.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("Mass of Base = " & Label11.Text & "")
                                            ListBox1.Items.Add("      Molar Conc. of B = (Mass Conc.)/(Molar Mass)")
                                            Dim x3 As Double = Val(Label11.Text)
                                            Dim x4 As Double = 106
                                            ListBox1.Items.Add("      Molar Conc. of B = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("      Molar Conc. of B = " & Val(Label11.Text) / 106 & " mol/dm cube")
                                            Dim y As Double = Val(Label11.Text) / 106
                                            ListBox1.Items.Add(" Therefore, Molar Conc. of B = " & CStr(Math.Round(Val(y), 4)) & " mol/dm cube")
                                            Label23.Text = CStr(Math.Round(Val(y), 4))
                                            Label23.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If ComboBox1.Text = "Concentration of B in mol/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Sodium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label21.Text & ", Volume of Base =" & Label16.Text & "")
                                        ListBox1.Items.Add("       Mass Conc. of Base = (Mass of Base * 1000)/Volume of Base")
                                        ListBox1.Items.Add("       Mass Conc. of B = ((" & Label21.Text & ") * 1000 )/(" & Label16.Text & ") ")
                                        Dim X1 As Double = Val(Label21.Text) * 1000
                                        Dim x2 As Double = Val(Label16.Text)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)))
                                        ListBox1.Items.Add("Therefore, Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) & " g/dm cube")
                                        Dim x As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))
                                        ListBox1.Items.Add("                                                                                    ")
                                        ListBox1.Items.Add("      Molar Mass of Base = 40")
                                        ListBox1.Items.Add("      Molar Conc. of B = (Mass Conc.)/(Molar Mass)")
                                        Dim x3 As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))
                                        Dim x4 As Double = 40
                                        ListBox1.Items.Add("      Molar Conc. of B = " & x3 & " / " & x4)
                                        ListBox1.Items.Add("      Molar Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 40 & " mol/dm cube")
                                        Dim y As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 40
                                        ListBox1.Items.Add(" Therefore, Molar Conc. of B = " & CStr(Math.Round(Val(y), 4)) & " mol/dm cube")
                                        Label23.Text = CStr(Math.Round(Val(y), 4))
                                        Label23.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in mol/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Sodium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        If Label11.Text <> "" Then
                                            ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                            ListBox1.Items.Add(" Base = " & b.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("Mass of Base = " & Label11.Text & "")
                                            ListBox1.Items.Add("      Molar Conc. of B = (Mass Conc.)/(Molar Mass)")
                                            Dim x3 As Double = Val(Label11.Text)
                                            Dim x4 As Double = 40
                                            ListBox1.Items.Add("      Molar Conc. of B = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("      Molar Conc. of B = " & Val(Label11.Text) / 40 & " mol/dm cube")
                                            Dim y As Double = Val(Label11.Text) / 40
                                            ListBox1.Items.Add(" Therefore, Molar Conc. of B = " & CStr(Math.Round(Val(y), 4)) & " mol/dm cube")
                                            Label23.Text = CStr(Math.Round(Val(y), 4))
                                            Label23.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in mol/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Potassium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label21.Text & ", Volume of Base =" & Label16.Text & "")
                                        ListBox1.Items.Add("       Mass Conc. of Base = (Mass of Base * 1000)/Volume of Base")
                                        ListBox1.Items.Add("       Mass Conc. of B = ((" & Label21.Text & ") * 1000 )/(" & Label16.Text & ") ")
                                        Dim X1 As Double = Val(Label21.Text) * 1000
                                        Dim x2 As Double = Val(Label16.Text)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)))
                                        ListBox1.Items.Add("Therefore, Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) & " g/dm cube")
                                        Dim x As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))
                                        ListBox1.Items.Add("                                                                                    ")
                                        ListBox1.Items.Add("      Molar Mass of Base = 56")
                                        ListBox1.Items.Add("      Molar Conc. of B = (Mass Conc.)/(Molar Mass)")
                                        Dim x3 As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))
                                        Dim x4 As Double = 56
                                        ListBox1.Items.Add("      Molar Conc. of B = " & x3 & " / " & x4)
                                        ListBox1.Items.Add("      Molar Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 56 & " mol/dm cube")
                                        Dim y As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 56
                                        ListBox1.Items.Add(" Therefore, Molar Conc. of B = " & CStr(Math.Round(Val(y), 4)) & " mol/dm cube")
                                        Label23.Text = CStr(Math.Round(Val(y), 4))
                                        Label23.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in mol/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Potassium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        If Label11.Text <> "" Then
                                            ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                            ListBox1.Items.Add(" Base = " & b.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("Mass of Base = " & Label11.Text & "")
                                            ListBox1.Items.Add("      Molar Conc. of B = (Mass Conc.)/(Molar Mass)")
                                            Dim x3 As Double = Val(Label11.Text)
                                            Dim x4 As Double = 56
                                            ListBox1.Items.Add("      Molar Conc. of B = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("      Molar Conc. of B = " & Val(Label11.Text) / 56 & " mol/dm cube")
                                            Dim y As Double = Val(Label11.Text) / 56
                                            ListBox1.Items.Add(" Therefore, Molar Conc. of B = " & CStr(Math.Round(Val(y), 4)) & " mol/dm cube")
                                            Label23.Text = CStr(Math.Round(Val(y), 4))
                                            Label23.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in mol/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Aqueous Ammonia" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label21.Text & ", Volume of Base =" & Label16.Text & "")
                                        ListBox1.Items.Add("       Mass Conc. of Base = (Mass of Base * 1000)/Volume of Base")
                                        ListBox1.Items.Add("       Mass Conc. of B = ((" & Label21.Text & ") * 1000 )/(" & Label16.Text & ") ")
                                        Dim X1 As Double = Val(Label21.Text) * 1000
                                        Dim x2 As Double = Val(Label16.Text)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)))
                                        ListBox1.Items.Add("Therefore, Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) & " g/dm cube")
                                        Dim x As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))
                                        ListBox1.Items.Add("                                                                                    ")
                                        ListBox1.Items.Add("      Molar Mass of Base = 35")
                                        ListBox1.Items.Add("      Molar Conc. of B = (Mass Conc.)/(Molar Mass)")
                                        Dim x3 As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))
                                        Dim x4 As Double = 35
                                        ListBox1.Items.Add("      Molar Conc. of B = " & x3 & " / " & x4)
                                        ListBox1.Items.Add("      Molar Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 35 & " mol/dm cube")
                                        Dim y As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 35
                                        ListBox1.Items.Add(" Therefore, Molar Conc. of B = " & CStr(Math.Round(Val(y), 4)) & " mol/dm cube")
                                        Label23.Text = CStr(Math.Round(Val(y), 4))
                                        Label23.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in mol/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Aqueous Ammonia" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        If Label11.Text <> "" Then
                                            ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                            ListBox1.Items.Add(" Base = " & b.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("Mass of Base = " & Label11.Text & "")
                                            ListBox1.Items.Add("      Molar Conc. of B = (Mass Conc.)/(Molar Mass)")
                                            Dim x3 As Double = Val(Label11.Text)
                                            Dim x4 As Double = 35
                                            ListBox1.Items.Add("      Molar Conc. of B = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("      Molar Conc. of B = " & Val(Label11.Text) / 35 & " mol/dm cube")
                                            Dim y As Double = Val(Label11.Text) / 35
                                            ListBox1.Items.Add(" Therefore, Molar Conc. of B = " & CStr(Math.Round(Val(y), 4)) & " mol/dm cube")
                                            Label23.Text = CStr(Math.Round(Val(y), 4))
                                            Label23.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in mol/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Sodium Trioxocarbonate(iv)" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label21.Text & ", Volume of Base =" & Label16.Text & "")
                                        ListBox1.Items.Add("       Mass Conc. of Base = (Mass of Base * 1000)/Volume of Base")
                                        ListBox1.Items.Add("       Mass Conc. of B = ((" & Label21.Text & ") * 1000 )/(" & Label16.Text & ") ")
                                        Dim X1 As Double = Val(Label21.Text) * 1000
                                        Dim x2 As Double = Val(Label16.Text)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)))
                                        ListBox1.Items.Add("Therefore, Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) & " g/dm cube")
                                        Dim x As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))
                                        ListBox1.Items.Add("                                                                                    ")
                                        ListBox1.Items.Add("      Molar Mass of Base = 106")
                                        ListBox1.Items.Add("      Molar Conc. of B = (Mass Conc.)/(Molar Mass)")
                                        Dim x3 As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))
                                        Dim x4 As Double = 106
                                        ListBox1.Items.Add("      Molar Conc. of B = " & x3 & " / " & x4)
                                        ListBox1.Items.Add("      Molar Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 106 & " mol/dm cube")
                                        Dim y As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 106
                                        ListBox1.Items.Add(" Therefore, Molar Conc. of B = " & CStr(Math.Round(Val(y), 4)) & " mol/dm cube")
                                        Label23.Text = CStr(Math.Round(Val(y), 4))
                                        Label23.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in mol/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Sodium Trioxocarbonate(iv)" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        If Label11.Text <> "" Then
                                            ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                            ListBox1.Items.Add(" Base = " & b.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("Mass of Base = " & Label11.Text & "")
                                            ListBox1.Items.Add("      Molar Conc. of B = (Mass Conc.)/(Molar Mass)")
                                            Dim x3 As Double = Val(Label11.Text)
                                            Dim x4 As Double = 106
                                            ListBox1.Items.Add("      Molar Conc. of B = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("      Molar Conc. of B = " & Val(Label11.Text) / 106 & " mol/dm cube")
                                            Dim y As Double = Val(Label11.Text) / 106
                                            ListBox1.Items.Add(" Therefore, Molar Conc. of B = " & CStr(Math.Round(Val(y), 4)) & " mol/dm cube")
                                            Label23.Text = CStr(Math.Round(Val(y), 4))
                                            Label23.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If


        If ComboBox1.Text = "Concentration of B in g/dm cube" Then
            If a.Text = "Hydrochloric Acid" Then
                If b.Text = "Sodium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label21.Text & ", Volume of Base =" & Label16.Text & "")
                                        ListBox1.Items.Add("       Mass Conc. of Base = (Mass of Base * 1000)/Volume of Base")
                                        ListBox1.Items.Add("       Mass Conc. of B = ((" & Label21.Text & ") * 1000 )/(" & Label16.Text & ") ")
                                        Dim X1 As Double = Val(Label21.Text) * 1000
                                        Dim x2 As Double = Val(Label16.Text)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)))
                                        ListBox1.Items.Add("Therefore, Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) & " g/dm cube")
                                        Dim y As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))
                                        Label11.Text = CStr(Math.Round(Val(y), 4))
                                        Label11.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in g/dm cube" Then
            If a.Text = "Hydrochloric Acid" Then
                If b.Text = "Sodium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label11.Text & "")
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in g/dm cube" Then
            If a.Text = "Hydrochloric Acid" Then
                If b.Text = "Potassium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label21.Text & ", Volume of Base =" & Label16.Text & "")
                                        ListBox1.Items.Add("       Mass Conc. of Base = (Mass of Base * 1000)/Volume of Base")
                                        ListBox1.Items.Add("       Mass Conc. of B = ((" & Label21.Text & ") * 1000 )/(" & Label16.Text & ") ")
                                        Dim X1 As Double = Val(Label21.Text) * 1000
                                        Dim x2 As Double = Val(Label16.Text)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)))
                                        ListBox1.Items.Add("Therefore, Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) & " g/dm cube")
                                        Dim y As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))

                                        Label11.Text = CStr(Math.Round(Val(y), 4))
                                        Label11.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in g/dm cube" Then
            If a.Text = "Hydrochloric Acid" Then
                If b.Text = "Potassium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label11.Text & "")
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in g/dm cube" Then
            If a.Text = "Hydrochloric Acid" Then
                If b.Text = "Sodium Trioxocarbonate(iv)" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label21.Text & ", Volume of Base =" & Label16.Text & "")
                                        ListBox1.Items.Add("       Mass Conc. of Base = (Mass of Base * 1000)/Volume of Base")
                                        ListBox1.Items.Add("       Mass Conc. of B = ((" & Label21.Text & ") * 1000 )/(" & Label16.Text & ") ")
                                        Dim X1 As Double = Val(Label21.Text) * 1000
                                        Dim x2 As Double = Val(Label16.Text)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)))
                                        ListBox1.Items.Add("Therefore, Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) & " g/dm cube")
                                        Dim y As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))

                                        Label11.Text = CStr(Math.Round(Val(y), 4))
                                        Label11.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in g/dm cube" Then
            If a.Text = "Hydrochloric Acid" Then
                If b.Text = "Sodium Trioxocarbonate(iv)" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label11.Text & "")
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in g/dm cube" Then
            If a.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                If b.Text = "Sodium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label21.Text & ", Volume of Base =" & Label16.Text & "")
                                        ListBox1.Items.Add("       Mass Conc. of Base = (Mass of Base * 1000)/Volume of Base")
                                        ListBox1.Items.Add("       Mass Conc. of B = ((" & Label21.Text & ") * 1000 )/(" & Label16.Text & ") ")
                                        Dim X1 As Double = Val(Label21.Text) * 1000
                                        Dim x2 As Double = Val(Label16.Text)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)))
                                        ListBox1.Items.Add("Therefore, Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) & " g/dm cube")
                                        Dim y As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))

                                        Label11.Text = CStr(Math.Round(Val(y), 4))
                                        Label11.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in g/dm cube" Then
            If a.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                If b.Text = "Sodium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label11.Text & "")
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in g/dm cube" Then
            If a.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                If b.Text = "Potassium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label21.Text & ", Volume of Base =" & Label16.Text & "")
                                        ListBox1.Items.Add("       Mass Conc. of Base = (Mass of Base * 1000)/Volume of Base")
                                        ListBox1.Items.Add("       Mass Conc. of B = ((" & Label21.Text & ") * 1000 )/(" & Label16.Text & ") ")
                                        Dim X1 As Double = Val(Label21.Text) * 1000
                                        Dim x2 As Double = Val(Label16.Text)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)))
                                        ListBox1.Items.Add("Therefore, Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) & " g/dm cube")
                                        Dim y As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))

                                        Label11.Text = CStr(Math.Round(Val(y), 4))
                                        Label11.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in g/dm cube" Then
            If a.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                If b.Text = "Potassium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label11.Text & "")
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in g/dm cube" Then
            If a.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                If b.Text = "Sodium Trioxocarbonate(iv)" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label21.Text & ", Volume of Base =" & Label16.Text & "")
                                        ListBox1.Items.Add("       Mass Conc. of Base = (Mass of Base * 1000)/Volume of Base")
                                        ListBox1.Items.Add("       Mass Conc. of B = ((" & Label21.Text & ") * 1000 )/(" & Label16.Text & ") ")
                                        Dim X1 As Double = Val(Label21.Text) * 1000
                                        Dim x2 As Double = Val(Label16.Text)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)))
                                        ListBox1.Items.Add("Therefore, Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) & " g/dm cube")
                                        Dim y As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))

                                        Label11.Text = CStr(Math.Round(Val(y), 4))
                                        Label11.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in g/dm cube" Then
            If a.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                If b.Text = "Sodium Trioxocarbonate(iv)" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label11.Text & "")
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If ComboBox1.Text = "Concentration of B in g/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Sodium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label21.Text & ", Volume of Base =" & Label16.Text & "")
                                        ListBox1.Items.Add("       Mass Conc. of Base = (Mass of Base * 1000)/Volume of Base")
                                        ListBox1.Items.Add("       Mass Conc. of B = ((" & Label21.Text & ") * 1000 )/(" & Label16.Text & ") ")
                                        Dim X1 As Double = Val(Label21.Text) * 1000
                                        Dim x2 As Double = Val(Label16.Text)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)))
                                        ListBox1.Items.Add("Therefore, Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) & " g/dm cube")
                                        Dim y As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))

                                        Label11.Text = CStr(Math.Round(Val(y), 4))
                                        Label11.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in g/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Sodium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label11.Text & "")
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in g/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Potassium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label21.Text & ", Volume of Base =" & Label16.Text & "")
                                        ListBox1.Items.Add("       Mass Conc. of Base = (Mass of Base * 1000)/Volume of Base")
                                        ListBox1.Items.Add("       Mass Conc. of B = ((" & Label21.Text & ") * 1000 )/(" & Label16.Text & ") ")
                                        Dim X1 As Double = Val(Label21.Text) * 1000
                                        Dim x2 As Double = Val(Label16.Text)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)))
                                        ListBox1.Items.Add("Therefore, Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) & " g/dm cube")
                                        Dim y As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))

                                        Label11.Text = CStr(Math.Round(Val(y), 4))
                                        Label11.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in g/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Potassium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label11.Text & "")
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in g/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Aqueous Ammonia" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label21.Text & ", Volume of Base =" & Label16.Text & "")
                                        ListBox1.Items.Add("       Mass Conc. of Base = (Mass of Base * 1000)/Volume of Base")
                                        ListBox1.Items.Add("       Mass Conc. of B = ((" & Label21.Text & ") * 1000 )/(" & Label16.Text & ") ")
                                        Dim X1 As Double = Val(Label21.Text) * 1000
                                        Dim x2 As Double = Val(Label16.Text)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)))
                                        ListBox1.Items.Add("Therefore, Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) & " g/dm cube")
                                        Dim y As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))

                                        Label11.Text = CStr(Math.Round(Val(y), 4))
                                        Label11.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in g/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Aqueous Ammonia" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label11.Text & "")
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in g/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Sodium Trioxocarbonate(iv)" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label21.Text & ", Volume of Base =" & Label16.Text & "")
                                        ListBox1.Items.Add("       Mass Conc. of Base = (Mass of Base * 1000)/Volume of Base")
                                        ListBox1.Items.Add("       Mass Conc. of B = ((" & Label21.Text & ") * 1000 )/(" & Label16.Text & ") ")
                                        Dim X1 As Double = Val(Label21.Text) * 1000
                                        Dim x2 As Double = Val(Label16.Text)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("       Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)))
                                        ListBox1.Items.Add("Therefore, Mass Conc. of B = " & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) & " g/dm cube")
                                        Dim y As Double = (Val(Label21.Text) * 1000) / (Val(Label16.Text))

                                        Label11.Text = CStr(Math.Round(Val(y), 4))
                                        Label11.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of B in g/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Sodium Trioxocarbonate(iv)" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("Mass of Base = " & Label11.Text & "")
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        'for ca'
        If ComboBox1.Text = "Concentration of A in mol/dm cube" Then
            If a.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                If b.Text = "Sodium Trioxocarbonate(iv)" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" H(2)SO(4) + Na(2)CO(3) → NaSO(4) + H(2)O + CO")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("  (Ca * Va)/(Cb * Vb) = Na/Nb")
                                        ListBox1.Items.Add("   Ca = (Cb * Vb * Na)/(Va *Nb)")
                                        ListBox1.Items.Add("   Ca = (" & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 106 & " * " & vb.Text & " * 1 )/( " & va.Text & " * 1)")
                                        Dim X1 As Double = (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 106 * (Val(vb.Text) * 1)))
                                        Dim x2 As Double = (Val(va.Text) * 1)
                                        ListBox1.Items.Add("   Ca = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("   Ca = " & (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 106 * (Val(vb.Text) * 1))) / (Val(va.Text) * 1))
                                        ListBox1.Items.Add("   Therefore, Molar Conc. of A = " & (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 106 * (Val(vb.Text) * 1))) / (Val(va.Text) * 1) & " mol/dm cube")
                                        Dim y As Double = (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 106 * (Val(vb.Text) * 1))) / (Val(va.Text) * 1)

                                        Label6.Text = CStr(Math.Round(Val(y), 4))
                                        Label6.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in mol/dm cube" Then
            If a.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                If b.Text = "Sodium Trioxocarbonate(iv)" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        If Label11.Text <> "" Then
                                            ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                            ListBox1.Items.Add(" Base = " & b.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add(" H(2)SO(4) + Na(2)CO(3) → NaSO(4) + H(2)O + CO")
                                            ListBox1.Items.Add("  (Ca * Va)/(Cb * Vb) = Na/Nb")
                                            ListBox1.Items.Add("   Ca = (Cb * Vb * Na)/(Va *Nb)")
                                            ListBox1.Items.Add("   Ca = (" & (Val(Label11.Text) / 106) & " * " & vb.Text & " * 1 )/( " & va.Text & " * 1)")
                                            Dim X1 As Double = (Val((Val(Label11.Text) / 106) * (Val(vb.Text) * 1)))
                                            Dim x2 As Double = (Val(va.Text) * 1)
                                            ListBox1.Items.Add("   Ca = " & X1 & " / " & x2)
                                            ListBox1.Items.Add("   Ca = " & (Val((Val(Label11.Text) / 106) * (Val(vb.Text) * 1))) / (Val(va.Text) * 1))
                                            ListBox1.Items.Add("   Therefore, Molar Conc. of A = " & (Val((Val(Label11.Text) / 106) * (Val(vb.Text) * 1))) / (Val(va.Text) * 1) & " mol/dm cube")
                                            Dim y As Double = (Val((Val(Label11.Text) / 106) * (Val(vb.Text) * 1))) / (Val(va.Text) * 1)

                                            Label6.Text = CStr(Math.Round(Val(y), 4))
                                            Label6.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in mol/dm cube" Then
            If a.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                If b.Text = "Sodium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add(" H(2)SO(4) + 2NaOH → Na(2)SO(4) + 2H(2)O")
                                        ListBox1.Items.Add("   (Ca * Va)/(Cb * Vb) = Na/Nb")
                                        ListBox1.Items.Add("   Ca = (Cb * Vb * Na)/(Va *Nb)")
                                        ListBox1.Items.Add("   Ca = (" & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 40 & " * " & vb.Text & " * 1 )/( " & va.Text & " * 2)")
                                        Dim X1 As Double = (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 40 * (Val(vb.Text) * 1)))
                                        Dim x2 As Double = (Val(va.Text) * 2)
                                        ListBox1.Items.Add("   Ca = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("   Ca = " & (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 40 * (Val(vb.Text) * 1))) / (Val(va.Text) * 2))
                                        ListBox1.Items.Add("   Therefore, Molar Conc. of A = " & (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 40 * (Val(vb.Text) * 1))) / (Val(va.Text) * 2) & " mol/dm cube")
                                        Dim y As Double = (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 40 * (Val(vb.Text) * 1))) / (Val(va.Text) * 2)

                                        Label6.Text = CStr(Math.Round(Val(y), 4))
                                        Label6.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in mol/dm cube" Then
            If a.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                If b.Text = "Sodium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        If Label11.Text <> "" Then
                                            ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                            ListBox1.Items.Add(" Base = " & b.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add(" H(2)SO(4) + 2NaOH → Na(2)SO(4) + 2H(2)O")
                                            ListBox1.Items.Add("  (Ca * Va)/(Cb * Vb) = Na/Nb")
                                            ListBox1.Items.Add("   Ca = (Cb * Vb * Na)/(Va *Nb)")
                                            ListBox1.Items.Add("   Ca = (" & (Val(Label11.Text) / 40) & " * " & vb.Text & " * 1 )/( " & va.Text & " * 2)")
                                            Dim X1 As Double = (Val((Val(Label11.Text) / 40) * (Val(vb.Text) * 1)))
                                            Dim x2 As Double = (Val(va.Text) * 2)
                                            ListBox1.Items.Add("   Ca = " & X1 & " / " & x2)
                                            ListBox1.Items.Add("   Ca = " & (Val((Val(Label11.Text) / 40) * (Val(vb.Text) * 1))) / (Val(va.Text) * 2))
                                            ListBox1.Items.Add("   Therefore, Molar Conc. of A = " & (Val((Val(Label11.Text) / 40) * (Val(vb.Text) * 1))) / (Val(va.Text) * 2) & " mol/dm cube")
                                            Dim y As Double = (Val((Val(Label11.Text) / 40) * (Val(vb.Text) * 1))) / (Val(va.Text) * 2)

                                            Label6.Text = CStr(Math.Round(Val(y), 4))
                                            Label6.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in mol/dm cube" Then
            If a.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                If b.Text = "potassium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add(" H(2)SO(4) + 2KOH → K(2)SO(4) + 2H(2)O")
                                        ListBox1.Items.Add("  (Ca * Va)/(Cb * Vb) = Na/Nb")
                                        ListBox1.Items.Add("   Ca = (Cb * Vb * Na)/(Va *Nb)")
                                        ListBox1.Items.Add("   Ca = (" & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 56 & " * " & vb.Text & " * 1 )/( " & va.Text & " * 2)")
                                        Dim X1 As Double = (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 56 * (Val(vb.Text) * 1)))
                                        Dim x2 As Double = (Val(va.Text) * 2)
                                        ListBox1.Items.Add("   Ca = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("   Ca = " & (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 56 * (Val(vb.Text) * 1))) / (Val(va.Text) * 2))
                                        ListBox1.Items.Add("   Therefore, Molar Conc. of A = " & (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 56 * (Val(vb.Text) * 1))) / (Val(va.Text) * 2) & " mol/dm cube")
                                        Dim y As Double = (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 56 * (Val(vb.Text) * 1))) / (Val(va.Text) * 2)

                                        Label6.Text = CStr(Math.Round(Val(y), 4))
                                        Label6.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in mol/dm cube" Then
            If a.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                If b.Text = "Potassium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        If Label11.Text <> "" Then
                                            ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                            ListBox1.Items.Add(" Base = " & b.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add(" H(2)SO(4) + 2NaOH → Na(2)SO(4) + 2H(2)O")
                                            ListBox1.Items.Add("  (Ca * Va)/(Cb * Vb) = Na/Nb")
                                            ListBox1.Items.Add("   Ca = (Cb * Vb * Na)/(Va *Nb)")
                                            ListBox1.Items.Add("   Ca = (" & (Val(Label11.Text) / 56) & " * " & vb.Text & " * 1 )/( " & va.Text & " * 2)")
                                            Dim X1 As Double = (Val((Val(Label11.Text) / 56) * (Val(vb.Text) * 1)))
                                            Dim x2 As Double = (Val(va.Text) * 2)
                                            ListBox1.Items.Add("   Ca = " & X1 & " / " & x2)
                                            ListBox1.Items.Add("   Ca = " & (Val((Val(Label11.Text) / 56) * (Val(vb.Text) * 1))) / (Val(va.Text) * 2))
                                            ListBox1.Items.Add("   Therefore, Molar Conc. of A = " & (Val((Val(Label11.Text) / 56) * (Val(vb.Text) * 1))) / (Val(va.Text) * 2) & " mol/dm cube")
                                            Dim y As Double = (Val((Val(Label11.Text) / 56) * (Val(vb.Text) * 1))) / (Val(va.Text) * 2)

                                            Label6.Text = CStr(Math.Round(Val(y), 4))
                                            Label6.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in mol/dm cube" Then
            If a.Text = "Hydrochloric Acid" Then
                If b.Text = "Sodium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add(" HCl + NaOH → NaCl + H(2)O")
                                        ListBox1.Items.Add("  (Ca * Va)/(Cb * Vb) = Na/Nb")
                                        ListBox1.Items.Add("   Ca = (Cb * Vb * Na)/(Va *Nb)")
                                        ListBox1.Items.Add("   Ca = (" & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 40 & " * " & vb.Text & " * 1 )/( " & va.Text & " * 1)")
                                        Dim X1 As Double = (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 40 * (Val(vb.Text) * 1)))
                                        Dim x2 As Double = (Val(va.Text) * 1)
                                        ListBox1.Items.Add("   Ca = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("   Ca = " & (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 40 * (Val(vb.Text) * 1))) / (Val(va.Text) * 1))
                                        ListBox1.Items.Add("   Therefore, Molar Conc. of A = " & (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 40 * (Val(vb.Text) * 1))) / (Val(va.Text) * 1) & " mol/dm cube")
                                        Dim y As Double = (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 40 * (Val(vb.Text) * 1))) / (Val(va.Text) * 1)

                                        Label6.Text = CStr(Math.Round(Val(y), 4))
                                        Label6.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in mol/dm cube" Then
            If a.Text = "Hydrochloric Acid" Then
                If b.Text = "Sodium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        If Label11.Text <> "" Then
                                            ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                            ListBox1.Items.Add(" Base = " & b.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add(" HCl + NaOH → NaCl + H(2)O")
                                            ListBox1.Items.Add("  (Ca * Va)/(Cb * Vb) = Na/Nb")
                                            ListBox1.Items.Add("   Ca = (Cb * Vb * Na)/(Va *Nb)")
                                            ListBox1.Items.Add("   Ca = (" & (Val(Label11.Text) / 40) & " * " & vb.Text & " * 1 )/( " & va.Text & " * 1)")
                                            Dim X1 As Double = (Val((Val(Label11.Text) / 40) * (Val(vb.Text) * 1)))
                                            Dim x2 As Double = (Val(va.Text) * 1)
                                            ListBox1.Items.Add("   Ca = " & X1 & " / " & x2)
                                            ListBox1.Items.Add("   Ca = " & (Val((Val(Label11.Text) / 40) * (Val(vb.Text) * 1))) / (Val(va.Text) * 1))
                                            ListBox1.Items.Add("   Therefore, Molar Conc. of A = " & (Val((Val(Label11.Text) / 40) * (Val(vb.Text) * 1))) / (Val(va.Text) * 1) & " mol/dm cube")
                                            Dim y As Double = (Val((Val(Label11.Text) / 40) * (Val(vb.Text) * 1))) / (Val(va.Text) * 1)

                                            Label6.Text = CStr(Math.Round(Val(y), 4))
                                            Label6.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in mol/dm cube" Then
            If a.Text = "Hydrochloric Acid" Then
                If b.Text = "Potassium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add(" HCl + KOH → KCl + H(2)O")
                                        ListBox1.Items.Add("  (Ca * Va)/(Cb * Vb) = Na/Nb")
                                        ListBox1.Items.Add("   Ca = (Cb * Vb * Na)/(Va *Nb)")
                                        ListBox1.Items.Add("   Ca = (" & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 56 & " * " & vb.Text & " * 1 )/( " & va.Text & " * 1)")
                                        Dim X1 As Double = (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 56 * (Val(vb.Text) * 1)))
                                        Dim x2 As Double = (Val(va.Text) * 1)
                                        ListBox1.Items.Add("   Ca = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("   Ca = " & (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 56 * (Val(vb.Text) * 1))) / (Val(va.Text) * 1))
                                        ListBox1.Items.Add("   Therefore, Molar Conc. of A = " & (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 56 * (Val(vb.Text) * 1))) / (Val(va.Text) * 1) & " mol/dm cube")
                                        Dim y As Double = (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 56 * (Val(vb.Text) * 1))) / (Val(va.Text) * 1)

                                        Label6.Text = CStr(Math.Round(Val(y), 4))
                                        Label6.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in mol/dm cube" Then
            If a.Text = "Hydrochloric Acid" Then
                If b.Text = "Potassium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        If Label11.Text <> "" Then
                                            ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                            ListBox1.Items.Add(" Base = " & b.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("   HCl + KOH → KCl + H(2)O")
                                            ListBox1.Items.Add("  (Ca * Va)/(Cb * Vb) = Na/Nb")
                                            ListBox1.Items.Add("   Ca = (Cb * Vb * Na)/(Va *Nb)")
                                            ListBox1.Items.Add("   Ca = (" & (Val(Label11.Text) / 56) & " * " & vb.Text & " * 1 )/( " & va.Text & " * 1)")
                                            Dim X1 As Double = (Val((Val(Label11.Text) / 56) * (Val(vb.Text) * 1)))
                                            Dim x2 As Double = (Val(va.Text) * 1)
                                            ListBox1.Items.Add("   Ca = " & X1 & " / " & x2)
                                            ListBox1.Items.Add("   Ca = " & (Val((Val(Label11.Text) / 56) * (Val(vb.Text) * 1))) / (Val(va.Text) * 1))
                                            ListBox1.Items.Add("   Therefore, Molar Conc. of A = " & (Val((Val(Label11.Text) / 56) * (Val(vb.Text) * 1))) / (Val(va.Text) * 1) & " mol/dm cube")
                                            Dim y As Double = (Val((Val(Label11.Text) / 56) * (Val(vb.Text) * 1))) / (Val(va.Text) * 1)

                                            Label6.Text = CStr(Math.Round(Val(y), 4))
                                            Label6.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in mol/dm cube" Then
            If a.Text = "Hydrochloric Acid" Then
                If b.Text = "Sodium Trioxocarbonate(iv)" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("   2HCl + Na(2)CO(3) → 2NaCl + H(2)O + CO(2)")
                                        ListBox1.Items.Add("  (Ca * Va)/(Cb * Vb) = Na/Nb")
                                        ListBox1.Items.Add("   Ca = (Cb * Vb * Na)/(Va *Nb)")
                                        ListBox1.Items.Add("   Ca = (" & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 106 & " * " & vb.Text & " * 2 )/( " & va.Text & " * 1)")
                                        Dim X1 As Double = (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 106 * (Val(vb.Text) * 2)))
                                        Dim x2 As Double = (Val(va.Text) * 1)
                                        ListBox1.Items.Add("   Ca = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("   Ca = " & (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 106 * (Val(vb.Text) * 2))) / (Val(va.Text) * 1))
                                        ListBox1.Items.Add("   Therefore, Molar Conc. of A = " & (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 106 * (Val(vb.Text) * 2))) / (Val(va.Text) * 1) & " mol/dm cube")
                                        Dim y As Double = (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 106 * (Val(vb.Text) * 2))) / (Val(va.Text) * 1)

                                        Label6.Text = CStr(Math.Round(Val(y), 4))
                                        Label6.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in mol/dm cube" Then
            If a.Text = "Hydrochloric Acid" Then
                If b.Text = "Sodium Trioxocarbonate(iv)" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        If Label11.Text <> "" Then
                                            ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                            ListBox1.Items.Add(" Base = " & b.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("   2HCl + Na(2)CO(3) → 2NaCl + H(2)O + CO(2)")
                                            ListBox1.Items.Add("  (Ca * Va)/(Cb * Vb) = Na/Nb")
                                            ListBox1.Items.Add("   Ca = (Cb * Vb * Na)/(Va *Nb)")
                                            ListBox1.Items.Add("   Ca = (" & (Val(Label11.Text) / 106) & " * " & vb.Text & " * 1 )/( " & va.Text & " * 1)")
                                            Dim X1 As Double = (Val((Val(Label11.Text) / 106) * (Val(vb.Text) * 2)))
                                            Dim x2 As Double = (Val(va.Text) * 1)
                                            ListBox1.Items.Add("   Ca = " & X1 & " / " & x2)
                                            ListBox1.Items.Add("   Ca = " & (Val((Val(Label11.Text) / 106) * (Val(vb.Text) * 2))) / (Val(va.Text) * 1))
                                            ListBox1.Items.Add("   Therefore, Molar Conc. of A = " & (Val((Val(Label11.Text) / 106) * (Val(vb.Text) * 2))) / (Val(va.Text) * 1) & " mol/dm cube")
                                            Dim y As Double = (Val((Val(Label11.Text) / 106) * (Val(vb.Text) * 2))) / (Val(va.Text) * 1)

                                            Label6.Text = CStr(Math.Round(Val(y), 4))
                                            Label6.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in mol/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Sodium Trioxocarbonate(iv)" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("   2HNO(3) + Na(2)CO(3) → 2NaNO(3) + H(2)O + CO(2)")
                                        ListBox1.Items.Add("  (Ca * Va)/(Cb * Vb) = Na/Nb")
                                        ListBox1.Items.Add("   Ca = (Cb * Vb * Na)/(Va *Nb)")
                                        ListBox1.Items.Add("   Ca = (" & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 106 & " * " & vb.Text & " * 2 )/( " & va.Text & " * 1)")
                                        Dim X1 As Double = (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 106 * (Val(vb.Text) * 2)))
                                        Dim x2 As Double = (Val(va.Text) * 1)
                                        ListBox1.Items.Add("   Ca = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("   Ca = " & (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 106 * (Val(vb.Text) * 2))) / (Val(va.Text) * 1))
                                        ListBox1.Items.Add("   Therefore, Molar Conc. of A = " & (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 106 * (Val(vb.Text) * 2))) / (Val(va.Text) * 1) & " mol/dm cube")
                                        Dim y As Double = (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 106 * (Val(vb.Text) * 2))) / (Val(va.Text) * 1)

                                        Label6.Text = CStr(Math.Round(Val(y), 4))
                                        Label6.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in mol/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Sodium Trioxocarbonate(iv)" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        If Label11.Text <> "" Then
                                            ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                            ListBox1.Items.Add(" Base = " & b.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("   2HNO(3) + Na(2)CO(3) → 2NaNO(3) + H(2)O + CO(2)")
                                            ListBox1.Items.Add("  (Ca * Va)/(Cb * Vb) = Na/Nb")
                                            ListBox1.Items.Add("   Ca = (Cb * Vb * Na)/(Va *Nb)")
                                            ListBox1.Items.Add("   Ca = (" & (Val(Label11.Text) / 106) & " * " & vb.Text & " * 1 )/( " & va.Text & " * 1)")
                                            Dim X1 As Double = (Val((Val(Label11.Text) / 106) * (Val(vb.Text) * 2)))
                                            Dim x2 As Double = (Val(va.Text) * 1)
                                            ListBox1.Items.Add("   Ca = " & X1 & " / " & x2)
                                            ListBox1.Items.Add("   Ca = " & (Val((Val(Label11.Text) / 106) * (Val(vb.Text) * 2))) / (Val(va.Text) * 1))
                                            ListBox1.Items.Add("   Therefore, Molar Conc. of A = " & (Val((Val(Label11.Text) / 106) * (Val(vb.Text) * 2))) / (Val(va.Text) * 1) & " mol/dm cube")
                                            Dim y As Double = (Val((Val(Label11.Text) / 106) * (Val(vb.Text) * 2))) / (Val(va.Text) * 1)

                                            Label6.Text = CStr(Math.Round(Val(y), 4))
                                            Label6.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in mol/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Aqueous Ammonia" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("   HNO(3) + NH(4)OH → NH(4)NO(3) + H(2)O ")
                                        ListBox1.Items.Add("  (Ca * Va)/(Cb * Vb) = Na/Nb")
                                        ListBox1.Items.Add("   Ca = (Cb * Vb * Na)/(Va *Nb)")
                                        ListBox1.Items.Add("   Ca = (" & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 35 & " * " & vb.Text & " * 1 )/( " & va.Text & " * 1)")
                                        Dim X1 As Double = (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 35 * (Val(vb.Text) * 1)))
                                        Dim x2 As Double = (Val(va.Text) * 1)
                                        ListBox1.Items.Add("   Ca = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("   Ca = " & (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 35 * (Val(vb.Text) * 1))) / (Val(va.Text) * 1))
                                        ListBox1.Items.Add("   Therefore, Molar Conc. of A = " & (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 35 * (Val(vb.Text) * 1))) / (Val(va.Text) * 1) & " mol/dm cube")
                                        Dim y As Double = (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 35 * (Val(vb.Text) * 1))) / (Val(va.Text) * 1)

                                        Label6.Text = CStr(Math.Round(Val(y), 4))
                                        Label6.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in mol/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Aqueous Ammonia" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        If Label11.Text <> "" Then
                                            ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                            ListBox1.Items.Add(" Base = " & b.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("   HNO(3) + NH(4)OH → NH(4)NO(3) + H(2)O ")
                                            ListBox1.Items.Add("  (Ca * Va)/(Cb * Vb) = Na/Nb")
                                            ListBox1.Items.Add("   Ca = (Cb * Vb * Na)/(Va *Nb)")
                                            ListBox1.Items.Add("   Ca = (" & (Val(Label11.Text) / 35) & " * " & vb.Text & " * 1 )/( " & va.Text & " * 1)")
                                            Dim X1 As Double = (Val((Val(Label11.Text) / 35) * (Val(vb.Text) * 1)))
                                            Dim x2 As Double = (Val(va.Text) * 1)
                                            ListBox1.Items.Add("   Ca = " & X1 & " / " & x2)
                                            ListBox1.Items.Add("   Ca = " & (Val((Val(Label11.Text) / 35) * (Val(vb.Text) * 1))) / (Val(va.Text) * 1))
                                            ListBox1.Items.Add("   Therefore, Molar Conc. of A = " & (Val((Val(Label11.Text) / 35) * (Val(vb.Text) * 1))) / (Val(va.Text) * 1) & " mol/dm cube")
                                            Dim y As Double = (Val((Val(Label11.Text) / 35) * (Val(vb.Text) * 1))) / (Val(va.Text) * 1)

                                            Label6.Text = CStr(Math.Round(Val(y), 4))
                                            Label6.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in mol/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Sodium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("   HNO(3) + NaOH → NaNO(3) + H(2)O ")
                                        ListBox1.Items.Add("  (Ca * Va)/(Cb * Vb) = Na/Nb")
                                        ListBox1.Items.Add("   Ca = (Cb * Vb * Na)/(Va *Nb)")
                                        ListBox1.Items.Add("   Ca = (" & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 40 & " * " & vb.Text & " * 1 )/( " & va.Text & " * 1)")
                                        Dim X1 As Double = (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 40 * (Val(vb.Text) * 1)))
                                        Dim x2 As Double = (Val(va.Text) * 1)
                                        ListBox1.Items.Add("   Ca = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("   Ca = " & (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 40 * (Val(vb.Text) * 1))) / (Val(va.Text) * 1))
                                        ListBox1.Items.Add("   Therefore, Molar Conc. of A = " & (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 40 * (Val(vb.Text) * 1))) / (Val(va.Text) * 1) & " mol/dm cube")
                                        Dim y As Double = (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 40 * (Val(vb.Text) * 1))) / (Val(va.Text) * 1)

                                        Label6.Text = CStr(Math.Round(Val(y), 4))
                                        Label6.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in mol/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Sodium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        If Label11.Text <> "" Then
                                            ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                            ListBox1.Items.Add(" Base = " & b.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("   HNO(3) + NaOH → NaNO(3) + H(2)O ")
                                            ListBox1.Items.Add("  (Ca * Va)/(Cb * Vb) = Na/Nb")
                                            ListBox1.Items.Add("   Ca = (Cb * Vb * Na)/(Va *Nb)")
                                            ListBox1.Items.Add("   Ca = (" & (Val(Label11.Text) / 40) & " * " & vb.Text & " * 1 )/( " & va.Text & " * 1)")
                                            Dim X1 As Double = (Val((Val(Label11.Text) / 40) * (Val(vb.Text) * 1)))
                                            Dim x2 As Double = (Val(va.Text) * 1)
                                            ListBox1.Items.Add("   Ca = " & X1 & " / " & x2)
                                            ListBox1.Items.Add("   Ca = " & (Val((Val(Label11.Text) / 40) * (Val(vb.Text) * 1))) / (Val(va.Text) * 1))
                                            ListBox1.Items.Add("   Therefore, Molar Conc. of A = " & (Val((Val(Label11.Text) / 40) * (Val(vb.Text) * 1))) / (Val(va.Text) * 1) & " mol/dm cube")
                                            Dim y As Double = (Val((Val(Label11.Text) / 40) * (Val(vb.Text) * 1))) / (Val(va.Text) * 1)

                                            Label6.Text = CStr(Math.Round(Val(y), 4))
                                            Label6.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in mol/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Potassium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text <> "" Then
                                    If Label16.Text <> "" Then
                                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                                        ListBox1.Items.Add("                                                                                            ")
                                        ListBox1.Items.Add("   HNO(3) + KOH → KNO(3) + H(2)O ")
                                        ListBox1.Items.Add("  (Ca * Va)/(Cb * Vb) = Na/Nb")
                                        ListBox1.Items.Add("   Ca = (Cb * Vb * Na)/(Va *Nb)")
                                        ListBox1.Items.Add("   Ca = (" & (Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 56 & " * " & vb.Text & " * 1 )/( " & va.Text & " * 1)")
                                        Dim X1 As Double = (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 56 * (Val(vb.Text) * 1)))
                                        Dim x2 As Double = (Val(va.Text) * 1)
                                        ListBox1.Items.Add("   Ca = " & X1 & " / " & x2)
                                        ListBox1.Items.Add("   Ca = " & (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 56 * (Val(vb.Text) * 1))) / (Val(va.Text) * 1))
                                        ListBox1.Items.Add("   Therefore, Molar Conc. of A = " & (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 56 * (Val(vb.Text) * 1))) / (Val(va.Text) * 1) & " mol/dm cube")
                                        Dim y As Double = (Val((Val(Label21.Text) * 1000) / (Val(Label16.Text)) / 56 * (Val(vb.Text) * 1))) / (Val(va.Text) * 1)

                                        Label6.Text = CStr(Math.Round(Val(y), 4))
                                        Label6.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in mol/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Potassium Hydroxide" Then
                    If vb.Text <> "" Then
                        If va.Text <> "" Then
                            If Label19.Text <> "" Then
                                If Label21.Text = "" Then
                                    If Label16.Text = "" Then
                                        If Label11.Text <> "" Then
                                            ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & a.Text & " ")
                                            ListBox1.Items.Add(" Base = " & b.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("   HNO(3) + KOH → KNO(3) + H(2)O ")
                                            ListBox1.Items.Add("  (Ca * Va)/(Cb * Vb) = Na/Nb")
                                            ListBox1.Items.Add("   Ca = (Cb * Vb * Na)/(Va *Nb)")
                                            ListBox1.Items.Add("   Ca = (" & (Val(Label11.Text) / 56) & " * " & vb.Text & " * 1 )/( " & va.Text & " * 1)")
                                            Dim X1 As Double = (Val((Val(Label11.Text) / 56) * (Val(vb.Text) * 1)))
                                            Dim x2 As Double = (Val(va.Text) * 1)
                                            ListBox1.Items.Add("   Ca = " & X1 & " / " & x2)
                                            ListBox1.Items.Add("   Ca = " & (Val((Val(Label11.Text) / 56) * (Val(vb.Text) * 1))) / (Val(va.Text) * 1))
                                            ListBox1.Items.Add("   Therefore, Molar Conc. of A = " & (Val((Val(Label11.Text) / 56) * (Val(vb.Text) * 1))) / (Val(va.Text) * 1) & " mol/dm cube")
                                            Dim y As Double = (Val((Val(Label11.Text) / 56) * (Val(vb.Text) * 1))) / (Val(va.Text) * 1)

                                            Label6.Text = CStr(Math.Round(Val(y), 4))
                                            Label6.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If ComboBox1.Text = "Concentration of A in g/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Aqueous Ammonia" Then
                    If Label6.Text <> "" Then
                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                        ListBox1.Items.Add("                                                                                            ")
                        ListBox1.Items.Add("Molar Conc. of A = " & Label6.Text & "")
                        ListBox1.Items.Add("      Molar Conc. of A = (Mass Conc.)/(Molar Mass)")
                        ListBox1.Items.Add("       Mass Conc. of A = Molar Conc. * Molar Mass")
                        Dim x3 As Double = Val(Label6.Text)
                        Dim x4 As Double = 63
                        ListBox1.Items.Add("       Mass Conc. of A = " & x3 & " * " & x4)
                        ListBox1.Items.Add("       Mass Conc. of A = " & Val(Label6.Text) * 63 & " g/dm cube")
                        Dim y As Double = Val(Label6.Text) * 63
                        ListBox1.Items.Add(" Therefore, Mass Conc. of A = " & CStr(Math.Round(Val(y), 4)) & " g/dm cube")
                    Else
                        MsgBox("You must calculate the Concentration of A in mol/dm cube first", MsgBoxStyle.Exclamation, "Invalid")
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in g/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Sodium Hydroxide" Then
                    If Label6.Text <> "" Then
                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                        ListBox1.Items.Add("                                                                                            ")
                        ListBox1.Items.Add("Molar Conc. of A = " & Label6.Text & "")
                        ListBox1.Items.Add("      Molar Conc. of A = (Mass Conc.)/(Molar Mass)")
                        ListBox1.Items.Add("       Mass Conc. of A = Molar Conc. * Molar Mass")
                        Dim x3 As Double = Val(Label6.Text)
                        Dim x4 As Double = 63
                        ListBox1.Items.Add("       Mass Conc. of A = " & x3 & " * " & x4)
                        ListBox1.Items.Add("       Mass Conc. of A = " & Val(Label6.Text) * 63 & " g/dm cube")
                        Dim y As Double = Val(Label6.Text) * 63
                        ListBox1.Items.Add(" Therefore, Mass Conc. of A = " & CStr(Math.Round(Val(y), 4)) & " g/dm cube")
                    Else
                        MsgBox("You must calculate the Concentration of A in mol/dm cube first", MsgBoxStyle.Exclamation, "Invalid")
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in g/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Potassium Hydroxide" Then
                    If Label6.Text <> "" Then
                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                        ListBox1.Items.Add("                                                                                            ")
                        ListBox1.Items.Add("Molar Conc. of A = " & Label6.Text & "")
                        ListBox1.Items.Add("      Molar Conc. of A = (Mass Conc.)/(Molar Mass)")
                        ListBox1.Items.Add("       Mass Conc. of A = Molar Conc. * Molar Mass")
                        Dim x3 As Double = Val(Label6.Text)
                        Dim x4 As Double = 63
                        ListBox1.Items.Add("       Mass Conc. of A = " & x3 & " * " & x4)
                        ListBox1.Items.Add("       Mass Conc. of A = " & Val(Label6.Text) * 63 & " g/dm cube")
                        Dim y As Double = Val(Label6.Text) * 63
                        ListBox1.Items.Add(" Therefore, Mass Conc. of A = " & CStr(Math.Round(Val(y), 4)) & " g/dm cube")
                    Else
                        MsgBox("You must calculate the Concentration of A in mol/dm cube first", MsgBoxStyle.Exclamation, "Invalid")
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in g/dm cube" Then
            If a.Text = "Trioxonitrate(v) Acid" Then
                If b.Text = "Sodium Trioxocarbonate(iv)" Then
                    If Label6.Text <> "" Then
                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                        ListBox1.Items.Add("                                                                                            ")
                        ListBox1.Items.Add("Molar Conc. of A = " & Label6.Text & "")
                        ListBox1.Items.Add("      Molar Conc. of A = (Mass Conc.)/(Molar Mass)")
                        ListBox1.Items.Add("       Mass Conc. of A = Molar Conc. * Molar Mass")
                        Dim x3 As Double = Val(Label6.Text)
                        Dim x4 As Double = 63
                        ListBox1.Items.Add("       Mass Conc. of A = " & x3 & " * " & x4)
                        ListBox1.Items.Add("       Mass Conc. of A = " & Val(Label6.Text) * 63 & " g/dm cube")
                        Dim y As Double = Val(Label6.Text) * 63
                        ListBox1.Items.Add(" Therefore, Mass Conc. of A = " & CStr(Math.Round(Val(y), 4)) & " g/dm cube")
                    Else
                        MsgBox("You must calculate the Concentration of A in mol/dm cube first", MsgBoxStyle.Exclamation, "Invalid")
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in g/dm cube" Then
            If a.Text = "Hydrochloric Acid" Then
                If b.Text = "Sodium Hydroxide" Then
                    If Label6.Text <> "" Then
                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                        ListBox1.Items.Add("                                                                                            ")
                        ListBox1.Items.Add("Molar Conc. of A = " & Label6.Text & "")
                        ListBox1.Items.Add("      Molar Conc. of A = (Mass Conc.)/(Molar Mass)")
                        ListBox1.Items.Add("       Mass Conc. of A = Molar Conc. * Molar Mass")
                        Dim x3 As Double = Val(Label6.Text)
                        Dim x4 As Double = 36.5
                        ListBox1.Items.Add("       Mass Conc. of A = " & x3 & " * " & x4)
                        ListBox1.Items.Add("       Mass Conc. of A = " & Val(Label6.Text) * 36.5 & " g/dm cube")
                        Dim y As Double = Val(Label6.Text) * 36.5
                        ListBox1.Items.Add(" Therefore, Mass Conc. of A = " & CStr(Math.Round(Val(y), 4)) & " g/dm cube")
                    Else
                        MsgBox("You must calculate the Concentration of A in mol/dm cube first", MsgBoxStyle.Exclamation, "Invalid")
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in g/dm cube" Then
            If a.Text = "Hydrochloric Acid" Then
                If b.Text = "Sodium Trioxocarbonate(iv)" Then
                    If Label6.Text <> "" Then
                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                        ListBox1.Items.Add("                                                                                            ")
                        ListBox1.Items.Add("Molar Conc. of A = " & Label6.Text & "")
                        ListBox1.Items.Add("      Molar Conc. of A = (Mass Conc.)/(Molar Mass)")
                        ListBox1.Items.Add("       Mass Conc. of A = Molar Conc. * Molar Mass")
                        Dim x3 As Double = Val(Label6.Text)
                        Dim x4 As Double = 36.5
                        ListBox1.Items.Add("       Mass Conc. of A = " & x3 & " * " & x4)
                        ListBox1.Items.Add("       Mass Conc. of A = " & Val(Label6.Text) * 36.5 & " g/dm cube")
                        Dim y As Double = Val(Label6.Text) * 36.5
                        ListBox1.Items.Add(" Therefore, Mass Conc. of A = " & CStr(Math.Round(Val(y), 4)) & " g/dm cube")
                    Else
                        MsgBox("You must calculate the Concentration of A in mol/dm cube first", MsgBoxStyle.Exclamation, "Invalid")
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in g/dm cube" Then
            If a.Text = "Hydrochloric Acid" Then
                If b.Text = "Potassium Hydroxide" Then
                    If Label6.Text <> "" Then
                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                        ListBox1.Items.Add("                                                                                            ")
                        ListBox1.Items.Add("Molar Conc. of A = " & Label6.Text & "")
                        ListBox1.Items.Add("      Molar Conc. of A = (Mass Conc.)/(Molar Mass)")
                        ListBox1.Items.Add("       Mass Conc. of A = Molar Conc. * Molar Mass")
                        Dim x3 As Double = Val(Label6.Text)
                        Dim x4 As Double = 36.5
                        ListBox1.Items.Add("       Mass Conc. of A = " & x3 & " * " & x4)
                        ListBox1.Items.Add("       Mass Conc. of A = " & Val(Label6.Text) * 36.5 & " g/dm cube")
                        Dim y As Double = Val(Label6.Text) * 36.5
                        ListBox1.Items.Add(" Therefore, Mass Conc. of A = " & CStr(Math.Round(Val(y), 4)) & " g/dm cube")
                    Else
                        MsgBox("You must calculate the Concentration of A in mol/dm cube first", MsgBoxStyle.Exclamation, "Invalid")
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in g/dm cube" Then
            If a.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                If b.Text = "Sodium Hydroxide" Then
                    If Label6.Text <> "" Then
                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                        ListBox1.Items.Add("                                                                                            ")
                        ListBox1.Items.Add("Molar Conc. of A = " & Label6.Text & "")
                        ListBox1.Items.Add("      Molar Conc. of A = (Mass Conc.)/(Molar Mass)")
                        ListBox1.Items.Add("       Mass Conc. of A = Molar Conc. * Molar Mass")
                        Dim x3 As Double = Val(Label6.Text)
                        Dim x4 As Double = 98
                        ListBox1.Items.Add("       Mass Conc. of A = " & x3 & " * " & x4)
                        ListBox1.Items.Add("       Mass Conc. of A = " & Val(Label6.Text) * 98 & " g/dm cube")
                        Dim y As Double = Val(Label6.Text) * 98
                        ListBox1.Items.Add(" Therefore, Mass Conc. of A = " & CStr(Math.Round(Val(y), 4)) & " g/dm cube")
                    Else
                        MsgBox("You must calculate the Concentration of A in mol/dm cube first", MsgBoxStyle.Exclamation, "Invalid")
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in g/dm cube" Then
            If a.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                If b.Text = "Potassium Hydroxide" Then
                    If Label6.Text <> "" Then
                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                        ListBox1.Items.Add("                                                                                            ")
                        ListBox1.Items.Add("Molar Conc. of A = " & Label6.Text & "")
                        ListBox1.Items.Add("      Molar Conc. of A = (Mass Conc.)/(Molar Mass)")
                        ListBox1.Items.Add("       Mass Conc. of A = Molar Conc. * Molar Mass")
                        Dim x3 As Double = Val(Label6.Text)
                        Dim x4 As Double = 98
                        ListBox1.Items.Add("       Mass Conc. of A = " & x3 & " * " & x4)
                        ListBox1.Items.Add("       Mass Conc. of A = " & Val(Label6.Text) * 98 & " g/dm cube")
                        Dim y As Double = Val(Label6.Text) * 98
                        ListBox1.Items.Add(" Therefore, Mass Conc. of A = " & CStr(Math.Round(Val(y), 4)) & " g/dm cube")
                    Else
                        MsgBox("You must calculate the Concentration of A in mol/dm cube first", MsgBoxStyle.Exclamation, "Invalid")
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "Concentration of A in g/dm cube" Then
            If a.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                If b.Text = "Sodium Trioxocarbonate(iv)" Then
                    If Label6.Text <> "" Then
                        ListBox1.Items.Add("____________________________________________________________________________________________________________________________________________________________________________________________")
                        ListBox1.Items.Add(" Acid = " & a.Text & " ")
                        ListBox1.Items.Add(" Base = " & b.Text & " ")
                        ListBox1.Items.Add("                                                                                            ")
                        ListBox1.Items.Add("Molar Conc. of A = " & Label6.Text & "")
                        ListBox1.Items.Add("      Molar Conc. of A = (Mass Conc.)/(Molar Mass)")
                        ListBox1.Items.Add("       Mass Conc. of A = Molar Conc. * Molar Mass")
                        Dim x3 As Double = Val(Label6.Text)
                        Dim x4 As Double = 98
                        ListBox1.Items.Add("       Mass Conc. of A = " & x3 & " * " & x4)
                        ListBox1.Items.Add("       Mass Conc. of A = " & Val(Label6.Text) * 98 & " g/dm cube")
                        Dim y As Double = Val(Label6.Text) * 98
                        ListBox1.Items.Add(" Therefore, Mass Conc. of A = " & CStr(Math.Round(Val(y), 4)) & " g/dm cube")
                    Else
                        MsgBox("You must calculate the Concentration of A in mol/dm cube first", MsgBoxStyle.Exclamation, "Invalid")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim sapi
        sapi = CreateObject("SAPI.spvoice")
        sapi.speak("welcome, to the calculation form")
        sapi.speak("this will help you with calculations analysis, thank you")
        Timer1.Enabled = False
    End Sub
    Private Sub Button7_MouseEnter(sender As Object, e As EventArgs) Handles Button7.MouseEnter
        Button7.Image = bk2.Image
    End Sub

    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs) Handles Button7.MouseLeave
        Button7.Image = bk1.Image
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub
End Class