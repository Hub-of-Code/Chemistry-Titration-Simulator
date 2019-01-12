Public Class Form1
    Dim kp As Boolean = False
    Dim x As Integer = 86
    Dim y As Integer = 624
    Dim z As Integer = 201
    Dim xx As Integer = 140
    Dim yy As Integer = 430
    Dim zz As Integer = 146
    Dim x1 As Integer
    Dim y1 As Integer
    Dim z1 As Integer
    Dim x2 As Integer = 140
    Dim y2 As Integer = 67
    Dim z2 As Integer = 146
    Dim x3 As Integer = 86
    Dim y3 As Integer = 624
    Dim z3 As Integer = 201
    Dim dp As Integer
    Dim tb As Integer
    Dim rnd As Integer
    Dim rd As String
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim p As System.Drawing.Pen = New System.Drawing.Pen(Brushes.Black, 3)
        Dim gr As System.Drawing.Graphics = Me.CreateGraphics
        gr.DrawLine(p, 86, 624, 202, 624)
        gr.DrawLine(p, 86, 624, 128, 534)
        gr.DrawLine(p, 202, 624, 158, 534)
        gr.DrawLine(p, 128, 536, 128, 500)
        gr.DrawLine(p, 158, 536, 158, 500)
        gr.DrawLine(p, 128, 500, 158, 500)
        gr.DrawLine(p, 139, 45, 147, 45)
        gr.DrawLine(p, 139, 430, 147, 430)
        gr.DrawLine(p, 139, 45, 139, 430)
        gr.DrawLine(p, 147, 45, 147, 430)
        gr.DrawLine(p, 139, 428, 143, 460)
        gr.DrawLine(p, 147, 428, 143, 460)
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If TextBox4.Text = "20" Then
            If Label5.Text = "Methyl Red" Then
                y = y - 2
                x = x + 1
                z = z - 1
                Dim Q As System.Drawing.Pen = New System.Drawing.Pen(Brushes.Yellow, 4)
                Dim gr As System.Drawing.Graphics = Me.CreateGraphics
                gr.DrawLine(Q, x, y, z, y)
            End If
            If Label5.Text = "Methyl Orange" Then
                y = y - 2
                x = x + 1
                z = z - 1
                Dim Q As System.Drawing.Pen = New System.Drawing.Pen(Brushes.Yellow, 4)
                Dim gr As System.Drawing.Graphics = Me.CreateGraphics
                gr.DrawLine(Q, x, y, z, y)
            End If
            If Label5.Text = "Phenolpthalein" Then
                y = y - 2
                x = x + 1
                z = z - 1
                Dim Q As System.Drawing.Pen = New System.Drawing.Pen(Brushes.Pink, 4)
                Dim gr As System.Drawing.Graphics = Me.CreateGraphics
                gr.DrawLine(Q, x, y, z, y)
            End If
            If y = 610 Then
                y1 = y
                x1 = x
                z1 = z
                Timer2.Enabled = False
            End If
        End If
        If TextBox4.Text = "25" Then
            If Label5.Text = "Methyl Red" Then
                y = y - 2
                x = x + 1
                z = z - 1
                Dim Q As System.Drawing.Pen = New System.Drawing.Pen(Brushes.Yellow, 4)
                Dim gr As System.Drawing.Graphics = Me.CreateGraphics
                gr.DrawLine(Q, x, y, z, y)
            End If
            If Label5.Text = "Methyl Orange" Then
                y = y - 2
                x = x + 1
                z = z - 1
                Dim Q As System.Drawing.Pen = New System.Drawing.Pen(Brushes.Yellow, 4)
                Dim gr As System.Drawing.Graphics = Me.CreateGraphics
                gr.DrawLine(Q, x, y, z, y)
            End If
            If Label5.Text = "Phenolpthalein" Then
                y = y - 2
                x = x + 1
                z = z - 1
                Dim Q As System.Drawing.Pen = New System.Drawing.Pen(Brushes.Pink, 4)
                Dim gr As System.Drawing.Graphics = Me.CreateGraphics
                gr.DrawLine(Q, x, y, z, y)
            End If
            If y = 606 Then
                y1 = y
                x1 = x
                z1 = z
                Timer2.Enabled = False
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox3.Visible = True
        If TextBox1.Text = "" Then
            kp = True
            MsgBox("You must provide necessary values", MsgBoxStyle.Exclamation, "Error")
        Else
            kp = False
        End If
        If kp = False Then
            If y < 624 Then
                MsgBox("Already filled. You must start a new Titration before you can refill", MsgBoxStyle.Critical, "Error")
            Else
                If ComboBox1.Text = "Hydrochloric Acid" Then
                    If ComboBox2.Text = "Sodium Trioxocarbonate(iv)" Then
                        If TextBox1.Text <> "" Then
                            If TextBox5.Text = "" Then
                                If TextBox4.Text <> "" Then
                                    If TextBox2.Text <> "" Then
                                        If TextBox3.Text <> "" Then
                                            Label5.Text = "Methyl Orange"
                                            ListBox1.Items.Add("______________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & ComboBox1.Text & " ")
                                            ListBox1.Items.Add(" Base = " & ComboBox2.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("mass of base = " & TextBox2.Text & ", Vol of base =" & TextBox3.Text & "")
                                            ListBox1.Items.Add("         mass conc of base = (mass of base * 1000)/vol of base")
                                            ListBox1.Items.Add("         mass conc of b = ((" & TextBox2.Text & ") * 1000 )/(" & TextBox3.Text & ") ")
                                            Dim X1 As Double = Val(TextBox2.Text) * 1000
                                            Dim x2 As Double = Val(TextBox3.Text)
                                            ListBox1.Items.Add("         mass conc of b = " & X1 & " / " & x2)
                                            ListBox1.Items.Add("         mass conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)))
                                            ListBox1.Items.Add("Therefore mass conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) & "g per dm cube")
                                            Dim x As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text))
                                            ListBox1.Items.Add("                                                                                    ")
                                            ListBox1.Items.Add("        molar mass of base = 106")
                                            ListBox1.Items.Add("       molar conc. of b = (mass conc)/(molar mass)")
                                            Dim x3 As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text))
                                            Dim x4 As Double = 106
                                            ListBox1.Items.Add("       molar conc. of b = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("Therefore molar conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 106 & "mol per dm cube")
                                            Dim y As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 106
                                            ListBox1.Items.Add("                                   ")
                                            ListBox1.Items.Add("      CA = (11.6 * " & TextBox1.Text & ") / 1000 ")
                                            Dim x5 As Double = 11.6 * Val(TextBox1.Text)
                                            Dim x6 As Double = 1000
                                            ListBox1.Items.Add("      CA = " & x5 & " / " & x6)
                                            ListBox1.Items.Add("Therefore CA = " & (Val(TextBox1.Text) * 11.6) / 1000 & "mol per dm cube")
                                            ListBox1.Items.Add("                                                                           ")
                                            ListBox1.Items.Add("         (Ca * Va)/(Cb * Vb)= Na/Nb")
                                            ListBox1.Items.Add("         Va = (Cb * Vb * Na)/(Ca * Nb)")
                                            ListBox1.Items.Add("         Va = (" & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 106 & ") * (" & TextBox4.Text & ") * 2 )/((" & (Val(TextBox1.Text) * 11.6) / 1000 & ") * 1) ")
                                            Dim X7 As Double = ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 106) * (Val(TextBox4.Text) * 2)
                                            Dim x8 As Double = ((Val(TextBox1.Text) * 11.6) / 1000) * 1
                                            ListBox1.Items.Add("         Ca = " & X7 & " / " & x8)
                                            ListBox1.Items.Add("         Ca = " & ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 106) * (Val(TextBox4.Text) * 2) / ((Val(TextBox1.Text) * 11.6) / 1000) * 1)
                                            ListBox1.Items.Add("Therefore Conc of A (Ca) = " & ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 106) * (Val(TextBox4.Text) * 2) / ((Val(TextBox1.Text) * 11.6) / 1000) * 1)
                                            Dim z As Double = ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 106) * (Val(TextBox4.Text) * 2) / (((Val(TextBox1.Text) * 11.6) / 1000) * 1)
                                            Label4.Text = CStr(Math.Round(Val(z), 4))
                                            Label4.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If ComboBox1.Text = "Hydrochloric Acid" Then
                    If ComboBox2.Text = "Sodium Trioxocarbonate(iv)" Then
                        If TextBox1.Text <> "" Then
                            If TextBox5.Text <> "" Then
                                If TextBox4.Text <> "" Then
                                    If TextBox2.Text = "" Then
                                        If TextBox3.Text = "" Then
                                            Label5.Text = "Methyl Orange"
                                            ListBox1.Items.Add("______________________________________________________________________________________________")
                                            ListBox1.Items.Add("Therefore mass conc of b = " & (Val(TextBox5.Text)) & "g per dm cube")
                                            Dim x As Double = (Val(TextBox5.Text))
                                            ListBox1.Items.Add("                                                                                    ")
                                            ListBox1.Items.Add("        molar mass of base = 106")
                                            ListBox1.Items.Add("       molar conc. of b = (mass conc)/(molar mass)")
                                            Dim x3 As Double = (Val(TextBox5.Text))
                                            Dim x4 As Double = 106
                                            ListBox1.Items.Add("       molar conc. of b = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("Therefore molar conc of b = " & (Val(TextBox5.Text)) / 106 & "mol per dm cube")
                                            Dim y As Double = (Val(TextBox5.Text)) / 106
                                            ListBox1.Items.Add("                                   ")
                                            ListBox1.Items.Add("      CA = (11.6 * " & TextBox1.Text & ") / 1000 ")
                                            Dim x5 As Double = 11.6 * Val(TextBox1.Text)
                                            Dim x6 As Double = 1000
                                            ListBox1.Items.Add("      CA = " & x5 & " / " & x6)
                                            ListBox1.Items.Add("Therefore CA = " & (Val(TextBox1.Text) * 11.6) / 1000 & "mol per dm cube")
                                            ListBox1.Items.Add("                                                                           ")
                                            ListBox1.Items.Add("         (Ca * Va)/(Cb * Vb)= Na/Nb")
                                            ListBox1.Items.Add("         Va = (Cb * Vb * Na)/(Ca * Nb)")
                                            ListBox1.Items.Add("         Va = (" & (Val(TextBox5.Text)) / 106 & ") * (" & TextBox4.Text & ") * 2 )/((" & (Val(TextBox1.Text) * 11.6) / 1000 & ") * 1) ")
                                            Dim X7 As Double = ((Val(TextBox5.Text)) / 106) * (Val(TextBox4.Text) * 2)
                                            Dim x8 As Double = ((Val(TextBox1.Text) * 11.6) / 1000) * 1
                                            ListBox1.Items.Add("         Ca = " & X7 & " / " & x8)
                                            ListBox1.Items.Add("         Ca = " & ((Val(TextBox5.Text)) / 106) * (Val(TextBox4.Text) * 2) / ((Val(TextBox1.Text) * 11.6) / 1000) * 1)
                                            ListBox1.Items.Add("Therefore Conc of A (Ca) = " & ((Val(TextBox5.Text)) / 106) * (Val(TextBox4.Text) * 2) / ((Val(TextBox1.Text) * 11.6) / 1000) * 1)
                                            Dim z As Double = ((Val(TextBox5.Text)) / 106) * (Val(TextBox4.Text) * 2) / (((Val(TextBox1.Text) * 11.6) / 1000) * 1)
                                            Label4.Text = CStr(Math.Round(Val(z), 4))
                                            Label4.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If ComboBox1.Text = "Hydrochloric Acid" Then
                    If ComboBox2.Text = "Sodium Hydroxide" Then
                        If TextBox1.Text <> "" Then
                            If TextBox5.Text = "" Then
                                If TextBox4.Text <> "" Then
                                    If TextBox2.Text <> "" Then
                                        If TextBox3.Text <> "" Then
                                            Label5.Text = "Methyl Orange"
                                            ListBox1.Items.Add("______________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & ComboBox1.Text & " ")
                                            ListBox1.Items.Add(" Base = " & ComboBox2.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("mass of base = " & TextBox2.Text & ", Vol of base =" & TextBox3.Text & "")
                                            ListBox1.Items.Add("         mass conc of base = (mass of base * 1000)/vol of base")
                                            ListBox1.Items.Add("         mass conc of b = ((" & TextBox2.Text & ") * 1000 )/(" & TextBox3.Text & ") ")
                                            Dim X1 As Double = Val(TextBox2.Text) * 1000
                                            Dim x2 As Double = Val(TextBox3.Text)
                                            ListBox1.Items.Add("         mass conc of b = " & X1 & " / " & x2)
                                            ListBox1.Items.Add("         mass conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)))
                                            ListBox1.Items.Add("Therefore mass conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) & "g per dm cube")
                                            Dim x As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text))
                                            ListBox1.Items.Add("                                                                                    ")
                                            ListBox1.Items.Add("        molar mass of base = 40")
                                            ListBox1.Items.Add("       molar conc. of b = (mass conc)/(molar mass)")
                                            Dim x3 As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text))
                                            Dim x4 As Double = 40
                                            ListBox1.Items.Add("       molar conc. of b = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("Therefore molar conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 40 & "mol per dm cube")
                                            Dim y As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 40
                                            ListBox1.Items.Add("                                   ")
                                            ListBox1.Items.Add("      CA = (11.6 * " & TextBox1.Text & ") / 1000 ")
                                            Dim x5 As Double = 11.6 * Val(TextBox1.Text)
                                            Dim x6 As Double = 1000
                                            ListBox1.Items.Add("      CA = " & x5 & " / " & x6)
                                            ListBox1.Items.Add("Therefore CA = " & (Val(TextBox1.Text) * 11.6) / 1000 & "mol per dm cube")
                                            ListBox1.Items.Add("                                                                           ")
                                            ListBox1.Items.Add("         (Ca * Va)/(Cb * Vb)= Na/Nb")
                                            ListBox1.Items.Add("         Va = (Cb * Vb * Na)/(Ca * Nb)")
                                            ListBox1.Items.Add("         Va = (" & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 40 & ") * (" & TextBox4.Text & ") * 1 )/((" & (Val(TextBox1.Text) * 11.6) / 1000 & ") * 1) ")
                                            Dim X7 As Double = ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 40) * (Val(TextBox4.Text) * 1)
                                            Dim x8 As Double = ((Val(TextBox1.Text) * 11.6) / 1000) * 1
                                            ListBox1.Items.Add("         Ca = " & X7 & " / " & x8)
                                            ListBox1.Items.Add("         Ca = " & ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 40) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 11.6) / 1000) * 1)
                                            ListBox1.Items.Add("Therefore Conc of A (Ca) = " & ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 40) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 11.6) / 1000) * 1)
                                            Dim z As Double = ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 40) * (Val(TextBox4.Text) * 1) / (((Val(TextBox1.Text) * 11.6) / 1000) * 1)
                                            Label4.Text = CStr(Math.Round(Val(z), 4))
                                            Label4.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If ComboBox1.Text = "Hydrochloric Acid" Then
                    If ComboBox2.Text = "Sodium Hydroxide" Then
                        If TextBox1.Text <> "" Then
                            If TextBox5.Text <> "" Then
                                If TextBox4.Text <> "" Then
                                    If TextBox2.Text = "" Then
                                        If TextBox3.Text = "" Then
                                            Label5.Text = "Methyl Orange"
                                            ListBox1.Items.Add("______________________________________________________________________________________________")
                                            ListBox1.Items.Add("Therefore mass conc of b = " & (Val(TextBox5.Text)) & "g per dm cube")
                                            Dim x As Double = (Val(TextBox5.Text))
                                            ListBox1.Items.Add("                                                                                    ")
                                            ListBox1.Items.Add("        molar mass of base = 40")
                                            ListBox1.Items.Add("       molar conc. of b = (mass conc)/(molar mass)")
                                            Dim x3 As Double = (Val(TextBox5.Text))
                                            Dim x4 As Double = 40
                                            ListBox1.Items.Add("       molar conc. of b = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("Therefore molar conc of b = " & (Val(TextBox5.Text)) / 40 & "mol per dm cube")
                                            Dim y As Double = (Val(TextBox5.Text)) / 40
                                            ListBox1.Items.Add("                                   ")
                                            ListBox1.Items.Add("      CA = (11.6 * " & TextBox1.Text & ") / 1000 ")
                                            Dim x5 As Double = 11.6 * Val(TextBox1.Text)
                                            Dim x6 As Double = 1000
                                            ListBox1.Items.Add("      CA = " & x5 & " / " & x6)
                                            ListBox1.Items.Add("Therefore CA = " & (Val(TextBox1.Text) * 11.6) / 1000 & "mol per dm cube")
                                            ListBox1.Items.Add("                                                                           ")
                                            ListBox1.Items.Add("         (Ca * Va)/(Cb * Vb)= Na/Nb")
                                            ListBox1.Items.Add("         Va = (Cb * Vb * Na)/(Ca * Nb)")
                                            ListBox1.Items.Add("         Va = (" & (Val(TextBox5.Text)) / 40 & ") * (" & TextBox4.Text & ") * 1 )/((" & (Val(TextBox1.Text) * 11.6) / 1000 & ") * 1) ")
                                            Dim X7 As Double = ((Val(TextBox5.Text)) / 40) * (Val(TextBox4.Text) * 1)
                                            Dim x8 As Double = ((Val(TextBox1.Text) * 11.6) / 1000) * 1
                                            ListBox1.Items.Add("         Ca = " & X7 & " / " & x8)
                                            ListBox1.Items.Add("         Ca = " & ((Val(TextBox5.Text)) / 40) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 11.6) / 1000) * 1)
                                            ListBox1.Items.Add("Therefore Conc of A (Ca) = " & ((Val(TextBox5.Text)) / 40) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 11.6) / 1000) * 1)
                                            Dim z As Double = ((Val(TextBox5.Text)) / 40) * (Val(TextBox4.Text) * 1) / (((Val(TextBox1.Text) * 11.6) / 1000) * 1)
                                            Label4.Text = CStr(Math.Round(Val(z), 4))
                                            Label4.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If ComboBox1.Text = "Hydrochloric Acid" Then
                    If ComboBox2.Text = "Potassium Hydroxide" Then
                        If TextBox1.Text <> "" Then
                            If TextBox5.Text = "" Then
                                If TextBox4.Text <> "" Then
                                    If TextBox2.Text <> "" Then
                                        If TextBox3.Text <> "" Then
                                            Label5.Text = "Methyl Orange"
                                            ListBox1.Items.Add("______________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & ComboBox1.Text & " ")
                                            ListBox1.Items.Add(" Base = " & ComboBox2.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("mass of base = " & TextBox2.Text & ", Vol of base =" & TextBox3.Text & "")
                                            ListBox1.Items.Add("         mass conc of base = (mass of base * 1000)/vol of base")
                                            ListBox1.Items.Add("         mass conc of b = ((" & TextBox2.Text & ") * 1000 )/(" & TextBox3.Text & ") ")
                                            Dim X1 As Double = Val(TextBox2.Text) * 1000
                                            Dim x2 As Double = Val(TextBox3.Text)
                                            ListBox1.Items.Add("         mass conc of b = " & X1 & " / " & x2)
                                            ListBox1.Items.Add("         mass conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)))
                                            ListBox1.Items.Add("Therefore mass conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) & "g per dm cube")
                                            Dim x As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text))
                                            ListBox1.Items.Add("                                                                                    ")
                                            ListBox1.Items.Add("        molar mass of base = 56")
                                            ListBox1.Items.Add("       molar conc. of b = (mass conc)/(molar mass)")
                                            Dim x3 As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text))
                                            Dim x4 As Double = 56
                                            ListBox1.Items.Add("       molar conc. of b = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("Therefore molar conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 56 & "mol per dm cube")
                                            Dim y As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 56
                                            ListBox1.Items.Add("                                   ")
                                            ListBox1.Items.Add("      CA = (11.6 * " & TextBox1.Text & ") / 1000 ")
                                            Dim x5 As Double = 11.6 * Val(TextBox1.Text)
                                            Dim x6 As Double = 1000
                                            ListBox1.Items.Add("      CA = " & x5 & " / " & x6)
                                            ListBox1.Items.Add("Therefore CA = " & (Val(TextBox1.Text) * 11.6) / 1000 & "mol per dm cube")
                                            ListBox1.Items.Add("                                                                           ")
                                            ListBox1.Items.Add("         (Ca * Va)/(Cb * Vb)= Na/Nb")
                                            ListBox1.Items.Add("         Va = (Cb * Vb * Na)/(Ca * Nb)")
                                            ListBox1.Items.Add("         Va = (" & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 56 & ") * (" & TextBox4.Text & ") * 1 )/((" & (Val(TextBox1.Text) * 11.6) / 1000 & ") * 1) ")
                                            Dim X7 As Double = ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 56) * (Val(TextBox4.Text) * 1)
                                            Dim x8 As Double = ((Val(TextBox1.Text) * 11.6) / 1000) * 1
                                            ListBox1.Items.Add("         Ca = " & X7 & " / " & x8)
                                            ListBox1.Items.Add("         Ca = " & ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 56) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 11.6) / 1000) * 1)
                                            ListBox1.Items.Add("Therefore Conc of A (Ca) = " & ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 56) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 11.6) / 1000) * 1)
                                            Dim z As Double = ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 56) * (Val(TextBox4.Text) * 1) / (((Val(TextBox1.Text) * 11.6) / 1000) * 1)
                                            Label4.Text = CStr(Math.Round(Val(z), 4))
                                            Label4.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If ComboBox1.Text = "Hydrochloric Acid" Then
                    If ComboBox2.Text = "Potassium Hydroxide" Then
                        If TextBox1.Text <> "" Then
                            If TextBox5.Text <> "" Then
                                If TextBox4.Text <> "" Then
                                    If TextBox2.Text = "" Then
                                        If TextBox3.Text = "" Then
                                            Label5.Text = "Methyl Orange"
                                            ListBox1.Items.Add("______________________________________________________________________________________________")
                                            ListBox1.Items.Add("Therefore mass conc of b = " & (Val(TextBox5.Text)) & "g per dm cube")
                                            Dim x As Double = (Val(TextBox5.Text))
                                            ListBox1.Items.Add("                                                                                    ")
                                            ListBox1.Items.Add("        molar mass of base = 56")
                                            ListBox1.Items.Add("       molar conc. of b = (mass conc)/(molar mass)")
                                            Dim x3 As Double = (Val(TextBox5.Text))
                                            Dim x4 As Double = 56
                                            ListBox1.Items.Add("       molar conc. of b = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("Therefore molar conc of b = " & (Val(TextBox5.Text)) / 56 & "mol per dm cube")
                                            Dim y As Double = (Val(TextBox5.Text)) / 56
                                            ListBox1.Items.Add("                                   ")
                                            ListBox1.Items.Add("      CA = (11.6 * " & TextBox1.Text & ") / 1000 ")
                                            Dim x5 As Double = 11.6 * Val(TextBox1.Text)
                                            Dim x6 As Double = 1000
                                            ListBox1.Items.Add("      CA = " & x5 & " / " & x6)
                                            ListBox1.Items.Add("Therefore CA = " & (Val(TextBox1.Text) * 11.6) / 1000 & "mol per dm cube")
                                            ListBox1.Items.Add("                                                                           ")
                                            ListBox1.Items.Add("         (Ca * Va)/(Cb * Vb)= Na/Nb")
                                            ListBox1.Items.Add("         Va = (Cb * Vb * Na)/(Ca * Nb)")
                                            ListBox1.Items.Add("         Va = (" & (Val(TextBox5.Text)) / 56 & ") * (" & TextBox4.Text & ") * 1 )/((" & (Val(TextBox1.Text) * 11.6) / 1000 & ") * 1) ")
                                            Dim X7 As Double = ((Val(TextBox5.Text)) / 56) * (Val(TextBox4.Text) * 1)
                                            Dim x8 As Double = ((Val(TextBox1.Text) * 11.6) / 1000) * 1
                                            ListBox1.Items.Add("         Ca = " & X7 & " / " & x8)
                                            ListBox1.Items.Add("         Ca = " & ((Val(TextBox5.Text)) / 56) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 11.6) / 1000) * 1)
                                            ListBox1.Items.Add("Therefore Conc of A (Ca) = " & ((Val(TextBox5.Text)) / 56) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 11.6) / 1000) * 1)
                                            Dim z As Double = ((Val(TextBox5.Text)) / 56) * (Val(TextBox4.Text) * 1) / (((Val(TextBox1.Text) * 11.6) / 1000) * 1)
                                            Label4.Text = CStr(Math.Round(Val(z), 4))
                                            Label4.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                'For H2SO4'
                If ComboBox1.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                    If ComboBox2.Text = "Potassium Hydroxide" Then
                        If TextBox1.Text <> "" Then
                            If TextBox5.Text = "" Then
                                If TextBox4.Text <> "" Then
                                    If TextBox2.Text <> "" Then
                                        If TextBox3.Text <> "" Then
                                            Label5.Text = "Methyl Orange"
                                            ListBox1.Items.Add("______________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & ComboBox1.Text & " ")
                                            ListBox1.Items.Add(" Base = " & ComboBox2.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("mass of base = " & TextBox2.Text & ", Vol of base =" & TextBox3.Text & "")
                                            ListBox1.Items.Add("         mass conc of base = (mass of base * 1000)/vol of base")
                                            ListBox1.Items.Add("         mass conc of b = ((" & TextBox2.Text & ") * 1000 )/(" & TextBox3.Text & ") ")
                                            Dim X1 As Double = Val(TextBox2.Text) * 1000
                                            Dim x2 As Double = Val(TextBox3.Text)
                                            ListBox1.Items.Add("         mass conc of b = " & X1 & " / " & x2)
                                            ListBox1.Items.Add("         mass conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)))
                                            ListBox1.Items.Add("Therefore mass conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) & "g per dm cube")
                                            Dim x As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text))
                                            ListBox1.Items.Add("                                                                                    ")
                                            ListBox1.Items.Add("        molar mass of base = 56")
                                            ListBox1.Items.Add("       molar conc. of b = (mass conc)/(molar mass)")
                                            Dim x3 As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text))
                                            Dim x4 As Double = 56
                                            ListBox1.Items.Add("       molar conc. of b = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("Therefore molar conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 56 & "mol per dm cube")
                                            Dim y As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 56
                                            ListBox1.Items.Add("                                   ")
                                            ListBox1.Items.Add("      CA = (18.0 * " & TextBox1.Text & ") / 1000 ")
                                            Dim x5 As Double = 18.0 * Val(TextBox1.Text)
                                            Dim x6 As Double = 1000
                                            ListBox1.Items.Add("      CA = " & x5 & " / " & x6)
                                            ListBox1.Items.Add("Therefore CA = " & (Val(TextBox1.Text) * 18.0) / 1000 & "mol per dm cube")
                                            ListBox1.Items.Add("                                                                           ")
                                            ListBox1.Items.Add("         (Ca * Va)/(Cb * Vb)= Na/Nb")
                                            ListBox1.Items.Add("         Va = (Cb * Vb * Na)/(Ca * Nb)")
                                            ListBox1.Items.Add("         Va = (" & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 56 & ") * (" & TextBox4.Text & ") * 1 )/((" & (Val(TextBox1.Text) * 18.0) / 1000 & ") * 2) ")
                                            Dim X7 As Double = ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 56) * (Val(TextBox4.Text) * 1)
                                            Dim x8 As Double = ((Val(TextBox1.Text) * 18.0) / 1000) * 2
                                            ListBox1.Items.Add("         Ca = " & X7 & " / " & x8)
                                            ListBox1.Items.Add("         Ca = " & ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 56) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 18.0) / 1000) * 2)
                                            ListBox1.Items.Add("Therefore Conc of A (Ca) = " & ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 56) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 18.0) / 1000) * 2)
                                            Dim z As Double = ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 56) * (Val(TextBox4.Text) * 1) / (((Val(TextBox1.Text) * 18.0) / 1000) * 2)
                                            Label4.Text = CStr(Math.Round(Val(z), 4))
                                            Label4.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If ComboBox1.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                    If ComboBox2.Text = "Potassium Hydroxide" Then
                        If TextBox1.Text <> "" Then
                            If TextBox5.Text <> "" Then
                                If TextBox4.Text <> "" Then
                                    If TextBox2.Text = "" Then
                                        If TextBox3.Text = "" Then
                                            Label5.Text = "Methyl Orange"
                                            ListBox1.Items.Add("______________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & ComboBox1.Text & " ")
                                            ListBox1.Items.Add(" Base = " & ComboBox2.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            Dim x As Double = (Val(TextBox5.Text))
                                            ListBox1.Items.Add("                                                                                    ")
                                            ListBox1.Items.Add("        molar mass of base = 56")
                                            ListBox1.Items.Add("       molar conc. of b = (mass conc)/(molar mass)")
                                            Dim x3 As Double = (Val(TextBox5.Text))
                                            Dim x4 As Double = 56
                                            ListBox1.Items.Add("       molar conc. of b = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("Therefore molar conc of b = " & (Val(TextBox5.Text)) / 56 & "mol per dm cube")
                                            Dim y As Double = (Val(TextBox5.Text)) / 56
                                            ListBox1.Items.Add("                                   ")
                                            ListBox1.Items.Add("      CA = (18.0 * " & TextBox1.Text & ") / 1000 ")
                                            Dim x5 As Double = 18.0 * Val(TextBox1.Text)
                                            Dim x6 As Double = 1000
                                            ListBox1.Items.Add("      CA = " & x5 & " / " & x6)
                                            ListBox1.Items.Add("Therefore CA = " & (Val(TextBox1.Text) * 18.0) / 1000 & "mol per dm cube")
                                            ListBox1.Items.Add("                                                                           ")
                                            ListBox1.Items.Add("         (Ca * Va)/(Cb * Vb)= Na/Nb")
                                            ListBox1.Items.Add("         Va = (Cb * Vb * Na)/(Ca * Nb)")
                                            ListBox1.Items.Add("         Va = (" & (Val(TextBox5.Text)) / 56 & ") * (" & TextBox4.Text & ") * 1 )/((" & (Val(TextBox1.Text) * 18.0) / 1000 & ") * 2) ")
                                            Dim X7 As Double = ((Val(TextBox5.Text)) / 56) * (Val(TextBox4.Text) * 1)
                                            Dim x8 As Double = ((Val(TextBox1.Text) * 18.0) / 1000) * 2
                                            ListBox1.Items.Add("         Ca = " & X7 & " / " & x8)
                                            ListBox1.Items.Add("         Ca = " & ((Val(TextBox5.Text)) / 56) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 18) / 1000) * 2)
                                            ListBox1.Items.Add("Therefore Conc of A (Ca) = " & ((Val(TextBox5.Text)) / 56) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 18) / 1000) * 2)
                                            Dim z As Double = ((Val(TextBox5.Text)) / 56) * (Val(TextBox4.Text) * 1) / (((Val(TextBox1.Text) * 18) / 1000) * 2)
                                            Label4.Text = CStr(Math.Round(Val(z), 4))
                                            Label4.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If ComboBox1.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                    If ComboBox2.Text = "Sodium Hydroxide" Then
                        If TextBox1.Text <> "" Then
                            If TextBox5.Text = "" Then
                                If TextBox4.Text <> "" Then
                                    If TextBox2.Text <> "" Then
                                        If TextBox3.Text <> "" Then
                                            Label5.Text = "Methyl Orange"
                                            ListBox1.Items.Add("______________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & ComboBox1.Text & " ")
                                            ListBox1.Items.Add(" Base = " & ComboBox2.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("mass of base = " & TextBox2.Text & ", Vol of base =" & TextBox3.Text & "")
                                            ListBox1.Items.Add("         mass conc of base = (mass of base * 1000)/vol of base")
                                            ListBox1.Items.Add("         mass conc of b = ((" & TextBox2.Text & ") * 1000 )/(" & TextBox3.Text & ") ")
                                            Dim X1 As Double = Val(TextBox2.Text) * 1000
                                            Dim x2 As Double = Val(TextBox3.Text)
                                            ListBox1.Items.Add("         mass conc of b = " & X1 & " / " & x2)
                                            ListBox1.Items.Add("         mass conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)))
                                            ListBox1.Items.Add("Therefore mass conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) & "g per dm cube")
                                            Dim x As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text))
                                            ListBox1.Items.Add("                                                                                    ")
                                            ListBox1.Items.Add("        molar mass of base = 40")
                                            ListBox1.Items.Add("       molar conc. of b = (mass conc)/(molar mass)")
                                            Dim x3 As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text))
                                            Dim x4 As Double = 40
                                            ListBox1.Items.Add("       molar conc. of b = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("Therefore molar conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 40 & "mol per dm cube")
                                            Dim y As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 40
                                            ListBox1.Items.Add("                                   ")
                                            ListBox1.Items.Add("      CA = (18.0 * " & TextBox1.Text & ") / 1000 ")
                                            Dim x5 As Double = 18.0 * Val(TextBox1.Text)
                                            Dim x6 As Double = 1000
                                            ListBox1.Items.Add("      CA = " & x5 & " / " & x6)
                                            ListBox1.Items.Add("Therefore CA = " & (Val(TextBox1.Text) * 18.0) / 1000 & "mol per dm cube")
                                            ListBox1.Items.Add("                                                                           ")
                                            ListBox1.Items.Add("         (Ca * Va)/(Cb * Vb)= Na/Nb")
                                            ListBox1.Items.Add("         Va = (Cb * Vb * Na)/(Ca * Nb)")
                                            ListBox1.Items.Add("         Va = (" & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 40 & ") * (" & TextBox4.Text & ") * 1 )/((" & (Val(TextBox1.Text) * 18.0) / 1000 & ") * 2) ")
                                            Dim X7 As Double = ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 40) * (Val(TextBox4.Text) * 1)
                                            Dim x8 As Double = ((Val(TextBox1.Text) * 18.0) / 1000) * 2
                                            ListBox1.Items.Add("         Ca = " & X7 & " / " & x8)
                                            ListBox1.Items.Add("         Ca = " & ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 40) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 18.0) / 1000) * 2)
                                            ListBox1.Items.Add("Therefore Conc of A (Ca) = " & ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 40) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 18.0) / 1000) * 2)
                                            Dim z As Double = ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 40) * (Val(TextBox4.Text) * 1) / (((Val(TextBox1.Text) * 18.0) / 1000) * 2)
                                            Label4.Text = CStr(Math.Round(Val(z), 4))
                                            Label4.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If ComboBox1.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                    If ComboBox2.Text = "Sodium Hydroxide" Then
                        If TextBox1.Text <> "" Then
                            If TextBox5.Text <> "" Then
                                If TextBox4.Text <> "" Then
                                    If TextBox2.Text = "" Then
                                        If TextBox3.Text = "" Then
                                            Label5.Text = "Methyl Orange"
                                            ListBox1.Items.Add("______________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & ComboBox1.Text & " ")
                                            ListBox1.Items.Add(" Base = " & ComboBox2.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            Dim x As Double = (Val(TextBox5.Text))
                                            ListBox1.Items.Add("                                                                                    ")
                                            ListBox1.Items.Add("        molar mass of base = 40")
                                            ListBox1.Items.Add("       molar conc. of b = (mass conc)/(molar mass)")
                                            Dim x3 As Double = (Val(TextBox5.Text))
                                            Dim x4 As Double = 40
                                            ListBox1.Items.Add("       molar conc. of b = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("Therefore molar conc of b = " & (Val(TextBox5.Text)) / 40 & "mol per dm cube")
                                            Dim y As Double = (Val(TextBox5.Text)) / 40
                                            ListBox1.Items.Add("                                   ")
                                            ListBox1.Items.Add("      CA = (18.0 * " & TextBox1.Text & ") / 1000 ")
                                            Dim x5 As Double = 18.0 * Val(TextBox1.Text)
                                            Dim x6 As Double = 1000
                                            ListBox1.Items.Add("      CA = " & x5 & " / " & x6)
                                            ListBox1.Items.Add("Therefore CA = " & (Val(TextBox1.Text) * 18.0) / 1000 & "mol per dm cube")
                                            ListBox1.Items.Add("                                                                           ")
                                            ListBox1.Items.Add("         (Ca * Va)/(Cb * Vb)= Na/Nb")
                                            ListBox1.Items.Add("         Va = (Cb * Vb * Na)/(Ca * Nb)")
                                            ListBox1.Items.Add("         Va = (" & (Val(TextBox5.Text)) / 40 & ") * (" & TextBox4.Text & ") * 1 )/((" & (Val(TextBox1.Text) * 18.0) / 1000 & ") * 2) ")
                                            Dim X7 As Double = ((Val(TextBox5.Text)) / 40) * (Val(TextBox4.Text) * 1)
                                            Dim x8 As Double = ((Val(TextBox1.Text) * 18.0) / 1000) * 2
                                            ListBox1.Items.Add("         Ca = " & X7 & " / " & x8)
                                            ListBox1.Items.Add("         Ca = " & ((Val(TextBox5.Text)) / 40) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 18) / 1000) * 2)
                                            ListBox1.Items.Add("Therefore Conc of A (Ca) = " & ((Val(TextBox5.Text)) / 40) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 18) / 1000) * 2)
                                            Dim z As Double = ((Val(TextBox5.Text)) / 40) * (Val(TextBox4.Text) * 1) / (((Val(TextBox1.Text) * 18) / 1000) * 2)
                                            Label4.Text = CStr(Math.Round(Val(z), 4))
                                            Label4.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If ComboBox1.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                    If ComboBox2.Text = "Sodium Trioxocarbonate(iv)" Then
                        If TextBox1.Text <> "" Then
                            If TextBox5.Text = "" Then
                                If TextBox4.Text <> "" Then
                                    If TextBox2.Text <> "" Then
                                        If TextBox3.Text <> "" Then
                                            Label5.Text = "Methyl Orange"
                                            ListBox1.Items.Add("______________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & ComboBox1.Text & " ")
                                            ListBox1.Items.Add(" Base = " & ComboBox2.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("mass of base = " & TextBox2.Text & ", Vol of base =" & TextBox3.Text & "")
                                            ListBox1.Items.Add("         mass conc of base = (mass of base * 1000)/vol of base")
                                            ListBox1.Items.Add("         mass conc of b = ((" & TextBox2.Text & ") * 1000 )/(" & TextBox3.Text & ") ")
                                            Dim X1 As Double = Val(TextBox2.Text) * 1000
                                            Dim x2 As Double = Val(TextBox3.Text)
                                            ListBox1.Items.Add("         mass conc of b = " & X1 & " / " & x2)
                                            ListBox1.Items.Add("         mass conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)))
                                            ListBox1.Items.Add("Therefore mass conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) & "g per dm cube")
                                            Dim x As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text))
                                            ListBox1.Items.Add("                                                                                    ")
                                            ListBox1.Items.Add("        molar mass of base = 106")
                                            ListBox1.Items.Add("       molar conc. of b = (mass conc)/(molar mass)")
                                            Dim x3 As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text))
                                            Dim x4 As Double = 106
                                            ListBox1.Items.Add("       molar conc. of b = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("Therefore molar conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 106 & "mol per dm cube")
                                            Dim y As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 106
                                            ListBox1.Items.Add("                                   ")
                                            ListBox1.Items.Add("      CA = (18.0 * " & TextBox1.Text & ") / 1000 ")
                                            Dim x5 As Double = 18.0 * Val(TextBox1.Text)
                                            Dim x6 As Double = 1000
                                            ListBox1.Items.Add("      CA = " & x5 & " / " & x6)
                                            ListBox1.Items.Add("Therefore CA = " & (Val(TextBox1.Text) * 18.0) / 1000 & "mol per dm cube")
                                            ListBox1.Items.Add("                                                                           ")
                                            ListBox1.Items.Add("         (Ca * Va)/(Cb * Vb)= Na/Nb")
                                            ListBox1.Items.Add("         Va = (Cb * Vb * Na)/(Ca * Nb)")
                                            ListBox1.Items.Add("         Va = (" & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 106 & ") * (" & TextBox4.Text & ") * 1 )/((" & (Val(TextBox1.Text) * 18.0) / 1000 & ") * 1) ")
                                            Dim X7 As Double = ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 106) * (Val(TextBox4.Text) * 1)
                                            Dim x8 As Double = ((Val(TextBox1.Text) * 18.0) / 1000) * 1
                                            ListBox1.Items.Add("         Ca = " & X7 & " / " & x8)
                                            ListBox1.Items.Add("         Ca = " & ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 106) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 18.0) / 1000) * 1)
                                            ListBox1.Items.Add("Therefore Conc of A (Ca) = " & ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 106) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 18.0) / 1000) * 1)
                                            Dim z As Double = ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 106) * (Val(TextBox4.Text) * 1) / (((Val(TextBox1.Text) * 18.0) / 1000) * 1)
                                            Label4.Text = CStr(Math.Round(Val(z), 4))
                                            Label4.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If ComboBox1.Text = "Hydrogen Tetraoxosulphate(vi) Acid" Then
                    If ComboBox2.Text = "Sodium Trioxocarbonate(iv)" Then
                        If TextBox1.Text <> "" Then
                            If TextBox5.Text <> "" Then
                                If TextBox4.Text <> "" Then
                                    If TextBox2.Text = "" Then
                                        If TextBox3.Text = "" Then
                                            Label5.Text = "Methyl Orange"
                                            ListBox1.Items.Add("______________________________________________________________________________________________")
                                            ListBox1.Items.Add("Therefore mass conc of b = " & (Val(TextBox5.Text)) & "g per dm cube")
                                            Dim x As Double = (Val(TextBox5.Text))
                                            ListBox1.Items.Add("                                                                                    ")
                                            ListBox1.Items.Add("        molar mass of base = 106")
                                            ListBox1.Items.Add("       molar conc. of b = (mass conc)/(molar mass)")
                                            Dim x3 As Double = (Val(TextBox5.Text))
                                            Dim x4 As Double = 106
                                            ListBox1.Items.Add("       molar conc. of b = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("Therefore molar conc of b = " & (Val(TextBox5.Text)) / 106 & "mol per dm cube")
                                            Dim y As Double = (Val(TextBox5.Text)) / 106
                                            ListBox1.Items.Add("                                   ")
                                            ListBox1.Items.Add("      CA = (18.0 * " & TextBox1.Text & ") / 1000 ")
                                            Dim x5 As Double = 18.0 * Val(TextBox1.Text)
                                            Dim x6 As Double = 1000
                                            ListBox1.Items.Add("      CA = " & x5 & " / " & x6)
                                            ListBox1.Items.Add("Therefore CA = " & (Val(TextBox1.Text) * 18.0) / 1000 & "mol per dm cube")
                                            ListBox1.Items.Add("                                                                           ")
                                            ListBox1.Items.Add("         (Ca * Va)/(Cb * Vb)= Na/Nb")
                                            ListBox1.Items.Add("         Va = (Cb * Vb * Na)/(Ca * Nb)")
                                            ListBox1.Items.Add("         Va = (" & (Val(TextBox5.Text)) / 106 & ") * (" & TextBox4.Text & ") * 1 )/((" & (Val(TextBox1.Text) * 18.0) / 1000 & ") * 1) ")
                                            Dim X7 As Double = ((Val(TextBox5.Text)) / 106) * (Val(TextBox4.Text) * 1)
                                            Dim x8 As Double = ((Val(TextBox1.Text) * 18.0) / 1000) * 1
                                            ListBox1.Items.Add("         Ca = " & X7 & " / " & x8)
                                            ListBox1.Items.Add("         Ca = " & ((Val(TextBox5.Text)) / 106) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 18.0) / 1000) * 1)
                                            ListBox1.Items.Add("Therefore Conc of A (Ca) = " & ((Val(TextBox5.Text)) / 106) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 18.0) / 1000) * 1)
                                            Dim z As Double = ((Val(TextBox5.Text)) / 106) * (Val(TextBox4.Text) * 1) / (((Val(TextBox1.Text) * 18.0) / 1000) * 1)
                                            Label4.Text = CStr(Math.Round(Val(z), 4))
                                            Label4.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                'For Trioxonitrate(v) Acid'
                If ComboBox1.Text = "Trioxonitrate(v) Acid" Then
                    If ComboBox2.Text = "Sodium Hydroxide" Then
                        If TextBox1.Text <> "" Then
                            If TextBox5.Text = "" Then
                                If TextBox4.Text <> "" Then
                                    If TextBox2.Text <> "" Then
                                        If TextBox3.Text <> "" Then
                                            Label5.Text = "Methyl Orange"
                                            ListBox1.Items.Add("______________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & ComboBox1.Text & " ")
                                            ListBox1.Items.Add(" Base = " & ComboBox2.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("mass of base = " & TextBox2.Text & ", Vol of base =" & TextBox3.Text & "")
                                            ListBox1.Items.Add("         mass conc of base = (mass of base * 1000)/vol of base")
                                            ListBox1.Items.Add("         mass conc of b = ((" & TextBox2.Text & ") * 1000 )/(" & TextBox3.Text & ") ")
                                            Dim X1 As Double = Val(TextBox2.Text) * 1000
                                            Dim x2 As Double = Val(TextBox3.Text)
                                            ListBox1.Items.Add("         mass conc of b = " & X1 & " / " & x2)
                                            ListBox1.Items.Add("         mass conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)))
                                            ListBox1.Items.Add("Therefore mass conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) & "g per dm cube")
                                            Dim x As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text))
                                            ListBox1.Items.Add("                                                                                    ")
                                            ListBox1.Items.Add("        molar mass of base = 40")
                                            ListBox1.Items.Add("       molar conc. of b = (mass conc)/(molar mass)")
                                            Dim x3 As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text))
                                            Dim x4 As Double = 40
                                            ListBox1.Items.Add("       molar conc. of b = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("Therefore molar conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 40 & "mol per dm cube")
                                            Dim y As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 40
                                            ListBox1.Items.Add("                                   ")
                                            ListBox1.Items.Add("      CA = (15.8 * " & TextBox1.Text & ") / 1000 ")
                                            Dim x5 As Double = 15.8 * Val(TextBox1.Text)
                                            Dim x6 As Double = 1000
                                            ListBox1.Items.Add("      CA = " & x5 & " / " & x6)
                                            ListBox1.Items.Add("Therefore CA = " & (Val(TextBox1.Text) * 15.8) / 1000 & "mol per dm cube")
                                            ListBox1.Items.Add("                                                                           ")
                                            ListBox1.Items.Add("         (Ca * Va)/(Cb * Vb)= Na/Nb")
                                            ListBox1.Items.Add("         Va = (Cb * Vb * Na)/(Ca * Nb)")
                                            ListBox1.Items.Add("         Va = (" & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 40 & ") * (" & TextBox4.Text & ") * 1 )/((" & (Val(TextBox1.Text) * 15.8) / 1000 & ") * 1) ")
                                            Dim X7 As Double = ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 40) * (Val(TextBox4.Text) * 1)
                                            Dim x8 As Double = ((Val(TextBox1.Text) * 15.8) / 1000) * 1
                                            ListBox1.Items.Add("         Ca = " & X7 & " / " & x8)
                                            ListBox1.Items.Add("         Ca = " & ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 40) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 15.8) / 1000) * 1)
                                            ListBox1.Items.Add("Therefore Conc of A (Ca) = " & ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 40) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 15.8) / 1000) * 1)
                                            Dim z As Double = ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 40) * (Val(TextBox4.Text) * 1) / (((Val(TextBox1.Text) * 15.8) / 1000) * 1)
                                            Label4.Text = CStr(Math.Round(Val(z), 4))
                                            Label4.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If ComboBox1.Text = "Trioxonitrate(v) Acid" Then
                    If ComboBox2.Text = "Sodium Hydroxide" Then
                        If TextBox1.Text <> "" Then
                            If TextBox5.Text <> "" Then
                                If TextBox4.Text <> "" Then
                                    If TextBox2.Text = "" Then
                                        If TextBox3.Text = "" Then
                                            Label5.Text = "Methyl Orange"
                                            ListBox1.Items.Add("______________________________________________________________________________________________")
                                            ListBox1.Items.Add("Therefore mass conc of b = " & (Val(TextBox5.Text)) & "g per dm cube")
                                            Dim x As Double = (Val(TextBox5.Text))
                                            ListBox1.Items.Add("                                                                                    ")
                                            ListBox1.Items.Add("        molar mass of base = 40")
                                            ListBox1.Items.Add("       molar conc. of b = (mass conc)/(molar mass)")
                                            Dim x3 As Double = (Val(TextBox5.Text))
                                            Dim x4 As Double = 40
                                            ListBox1.Items.Add("       molar conc. of b = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("Therefore molar conc of b = " & (Val(TextBox5.Text)) / 40 & "mol per dm cube")
                                            Dim y As Double = (Val(TextBox5.Text)) / 40
                                            ListBox1.Items.Add("                                   ")
                                            ListBox1.Items.Add("      CA = (15.8 * " & TextBox1.Text & ") / 1000 ")
                                            Dim x5 As Double = 15.8 * Val(TextBox1.Text)
                                            Dim x6 As Double = 1000
                                            ListBox1.Items.Add("      CA = " & x5 & " / " & x6)
                                            ListBox1.Items.Add("Therefore CA = " & (Val(TextBox1.Text) * 15.8) / 1000 & "mol per dm cube")
                                            ListBox1.Items.Add("                                                                           ")
                                            ListBox1.Items.Add("         (Ca * Va)/(Cb * Vb)= Na/Nb")
                                            ListBox1.Items.Add("         Va = (Cb * Vb * Na)/(Ca * Nb)")
                                            ListBox1.Items.Add("         Va = (" & (Val(TextBox5.Text)) / 40 & ") * (" & TextBox4.Text & ") * 1 )/((" & (Val(TextBox1.Text) * 15.8) / 1000 & ") * 1) ")
                                            Dim X7 As Double = ((Val(TextBox5.Text)) / 40) * (Val(TextBox4.Text) * 1)
                                            Dim x8 As Double = ((Val(TextBox1.Text) * 15.8) / 1000) * 1
                                            ListBox1.Items.Add("         Ca = " & X7 & " / " & x8)
                                            ListBox1.Items.Add("         Ca = " & ((Val(TextBox5.Text)) / 40) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 15.8) / 1000) * 1)
                                            ListBox1.Items.Add("Therefore Conc of A (Ca) = " & ((Val(TextBox5.Text)) / 40) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 15.8) / 1000) * 1)
                                            Dim z As Double = ((Val(TextBox5.Text)) / 40) * (Val(TextBox4.Text) * 1) / (((Val(TextBox1.Text) * 15.8) / 1000) * 1)
                                            Label4.Text = CStr(Math.Round(Val(z), 4))
                                            Label4.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If ComboBox1.Text = "Trioxonitrate(v) Acid" Then
                    If ComboBox2.Text = "Potassium Hydroxide" Then
                        If TextBox1.Text <> "" Then
                            If TextBox5.Text = "" Then
                                If TextBox4.Text <> "" Then
                                    If TextBox2.Text <> "" Then
                                        If TextBox3.Text <> "" Then
                                            Label5.Text = "Methyl Orange"
                                            ListBox1.Items.Add("______________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & ComboBox1.Text & " ")
                                            ListBox1.Items.Add(" Base = " & ComboBox2.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("mass of base = " & TextBox2.Text & ", Vol of base =" & TextBox3.Text & "")
                                            ListBox1.Items.Add("         mass conc of base = (mass of base * 1000)/vol of base")
                                            ListBox1.Items.Add("         mass conc of b = ((" & TextBox2.Text & ") * 1000 )/(" & TextBox3.Text & ") ")
                                            Dim X1 As Double = Val(TextBox2.Text) * 1000
                                            Dim x2 As Double = Val(TextBox3.Text)
                                            ListBox1.Items.Add("         mass conc of b = " & X1 & " / " & x2)
                                            ListBox1.Items.Add("         mass conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)))
                                            ListBox1.Items.Add("Therefore mass conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) & "g per dm cube")
                                            Dim x As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text))
                                            ListBox1.Items.Add("                                                                                    ")
                                            ListBox1.Items.Add("        molar mass of base = 56")
                                            ListBox1.Items.Add("       molar conc. of b = (mass conc)/(molar mass)")
                                            Dim x3 As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text))
                                            Dim x4 As Double = 56
                                            ListBox1.Items.Add("       molar conc. of b = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("Therefore molar conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 56 & "mol per dm cube")
                                            Dim y As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 56
                                            ListBox1.Items.Add("                                   ")
                                            ListBox1.Items.Add("      CA = (15.8 * " & TextBox1.Text & ") / 1000 ")
                                            Dim x5 As Double = 15.8 * Val(TextBox1.Text)
                                            Dim x6 As Double = 1000
                                            ListBox1.Items.Add("      CA = " & x5 & " / " & x6)
                                            ListBox1.Items.Add("Therefore CA = " & (Val(TextBox1.Text) * 15.8) / 1000 & "mol per dm cube")
                                            ListBox1.Items.Add("                                                                           ")
                                            ListBox1.Items.Add("         (Ca * Va)/(Cb * Vb)= Na/Nb")
                                            ListBox1.Items.Add("         Va = (Cb * Vb * Na)/(Ca * Nb)")
                                            ListBox1.Items.Add("         Va = (" & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 56 & ") * (" & TextBox4.Text & ") * 1 )/((" & (Val(TextBox1.Text) * 15.8) / 1000 & ") * 1) ")
                                            Dim X7 As Double = ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 56) * (Val(TextBox4.Text) * 1)
                                            Dim x8 As Double = ((Val(TextBox1.Text) * 15.8) / 1000) * 1
                                            ListBox1.Items.Add("         Ca = " & X7 & " / " & x8)
                                            ListBox1.Items.Add("         Ca = " & ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 56) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 15.8) / 1000) * 1)
                                            ListBox1.Items.Add("Therefore Conc of A (Ca) = " & ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 56) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 15.8) / 1000) * 1)
                                            Dim z As Double = ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 56) * (Val(TextBox4.Text) * 1) / (((Val(TextBox1.Text) * 15.8) / 1000) * 1)
                                            Label4.Text = CStr(Math.Round(Val(z), 4))
                                            Label4.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If ComboBox1.Text = "Trioxonitrate(v) Acid" Then
                    If ComboBox2.Text = "Potassium Hydroxide" Then
                        If TextBox1.Text <> "" Then
                            If TextBox5.Text <> "" Then
                                If TextBox4.Text <> "" Then
                                    If TextBox2.Text = "" Then
                                        If TextBox3.Text = "" Then
                                            Label5.Text = "Methyl Orange"
                                            ListBox1.Items.Add("______________________________________________________________________________________________")
                                            ListBox1.Items.Add("Therefore mass conc of b = " & (Val(TextBox5.Text)) & "g per dm cube")
                                            Dim x As Double = (Val(TextBox5.Text))
                                            ListBox1.Items.Add("                                                                                    ")
                                            ListBox1.Items.Add("        molar mass of base = 56")
                                            ListBox1.Items.Add("       molar conc. of b = (mass conc)/(molar mass)")
                                            Dim x3 As Double = (Val(TextBox5.Text))
                                            Dim x4 As Double = 56
                                            ListBox1.Items.Add("       molar conc. of b = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("Therefore molar conc of b = " & (Val(TextBox5.Text)) / 56 & "mol per dm cube")
                                            Dim y As Double = (Val(TextBox5.Text)) / 56
                                            ListBox1.Items.Add("                                   ")
                                            ListBox1.Items.Add("      CA = (15.8 * " & TextBox1.Text & ") / 1000 ")
                                            Dim x5 As Double = 15.8 * Val(TextBox1.Text)
                                            Dim x6 As Double = 1000
                                            ListBox1.Items.Add("      CA = " & x5 & " / " & x6)
                                            ListBox1.Items.Add("Therefore CA = " & (Val(TextBox1.Text) * 15.8) / 1000 & "mol per dm cube")
                                            ListBox1.Items.Add("                                                                           ")
                                            ListBox1.Items.Add("         (Ca * Va)/(Cb * Vb)= Na/Nb")
                                            ListBox1.Items.Add("         Va = (Cb * Vb * Na)/(Ca * Nb)")
                                            ListBox1.Items.Add("         Va = (" & (Val(TextBox5.Text)) / 56 & ") * (" & TextBox4.Text & ") * 1 )/((" & (Val(TextBox1.Text) * 15.8) / 1000 & ") * 1) ")
                                            Dim X7 As Double = ((Val(TextBox5.Text)) / 56) * (Val(TextBox4.Text) * 1)
                                            Dim x8 As Double = ((Val(TextBox1.Text) * 15.8) / 1000) * 1
                                            ListBox1.Items.Add("         Ca = " & X7 & " / " & x8)
                                            ListBox1.Items.Add("         Ca = " & ((Val(TextBox5.Text)) / 56) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 15.8) / 1000) * 1)
                                            ListBox1.Items.Add("Therefore Conc of A (Ca) = " & ((Val(TextBox5.Text)) / 56) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 15.8) / 1000) * 1)
                                            Dim z As Double = ((Val(TextBox5.Text)) / 56) * (Val(TextBox4.Text) * 1) / (((Val(TextBox1.Text) * 15.8) / 1000) * 1)
                                            Label4.Text = CStr(Math.Round(Val(z), 4))
                                            Label4.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If ComboBox1.Text = "Trioxonitrate(v) Acid" Then
                    If ComboBox2.Text = "Aqueous Ammonia" Then
                        If TextBox1.Text <> "" Then
                            If TextBox5.Text = "" Then
                                If TextBox4.Text <> "" Then
                                    If TextBox2.Text <> "" Then
                                        If TextBox3.Text <> "" Then
                                            Label5.Text = "Methyl Orange"
                                            ListBox1.Items.Add("______________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & ComboBox1.Text & " ")
                                            ListBox1.Items.Add(" Base = " & ComboBox2.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("mass of base = " & TextBox2.Text & ", Vol of base =" & TextBox3.Text & "")
                                            ListBox1.Items.Add("         mass conc of base = (mass of base * 1000)/vol of base")
                                            ListBox1.Items.Add("         mass conc of b = ((" & TextBox2.Text & ") * 1000 )/(" & TextBox3.Text & ") ")
                                            Dim X1 As Double = Val(TextBox2.Text) * 1000
                                            Dim x2 As Double = Val(TextBox3.Text)
                                            ListBox1.Items.Add("         mass conc of b = " & X1 & " / " & x2)
                                            ListBox1.Items.Add("         mass conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)))
                                            ListBox1.Items.Add("Therefore mass conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) & "g per dm cube")
                                            Dim x As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text))
                                            ListBox1.Items.Add("                                                                                    ")
                                            ListBox1.Items.Add("        molar mass of base = 35")
                                            ListBox1.Items.Add("       molar conc. of b = (mass conc)/(molar mass)")
                                            Dim x3 As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text))
                                            Dim x4 As Double = 35
                                            ListBox1.Items.Add("       molar conc. of b = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("Therefore molar conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 35 & "mol per dm cube")
                                            Dim y As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 35
                                            ListBox1.Items.Add("                                   ")
                                            ListBox1.Items.Add("      CA = (15.8 * " & TextBox1.Text & ") / 1000 ")
                                            Dim x5 As Double = 15.8 * Val(TextBox1.Text)
                                            Dim x6 As Double = 1000
                                            ListBox1.Items.Add("      CA = " & x5 & " / " & x6)
                                            ListBox1.Items.Add("Therefore CA = " & (Val(TextBox1.Text) * 15.8) / 1000 & "mol per dm cube")
                                            ListBox1.Items.Add("                                                                           ")
                                            ListBox1.Items.Add("         (Ca * Va)/(Cb * Vb)= Na/Nb")
                                            ListBox1.Items.Add("         Va = (Cb * Vb * Na)/(Ca * Nb)")
                                            ListBox1.Items.Add("         Va = (" & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 35 & ") * (" & TextBox4.Text & ") * 1 )/((" & (Val(TextBox1.Text) * 15.8) / 1000 & ") * 1) ")
                                            Dim X7 As Double = ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 35) * (Val(TextBox4.Text) * 1)
                                            Dim x8 As Double = ((Val(TextBox1.Text) * 15.8) / 1000) * 1
                                            ListBox1.Items.Add("         Ca = " & X7 & " / " & x8)
                                            ListBox1.Items.Add("         Ca = " & ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 35) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 15.8) / 1000) * 1)
                                            ListBox1.Items.Add("Therefore Conc of A (Ca) = " & ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 35) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 15.8) / 1000) * 1)
                                            Dim z As Double = ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 35) * (Val(TextBox4.Text) * 1) / (((Val(TextBox1.Text) * 15.8) / 1000) * 1)
                                            Label4.Text = CStr(Math.Round(Val(z), 4))
                                            Label4.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If ComboBox1.Text = "Trioxonitrate(v) Acid" Then
                    If ComboBox2.Text = "Aqueous Ammonia" Then
                        If TextBox1.Text <> "" Then
                            If TextBox5.Text <> "" Then
                                If TextBox4.Text <> "" Then
                                    If TextBox2.Text = "" Then
                                        If TextBox3.Text = "" Then
                                            Label5.Text = "Methyl Orange"
                                            ListBox1.Items.Add("______________________________________________________________________________________________")
                                            ListBox1.Items.Add("Therefore mass conc of b = " & (Val(TextBox5.Text)) & "g per dm cube")
                                            Dim x As Double = (Val(TextBox5.Text))
                                            ListBox1.Items.Add("                                                                                    ")
                                            ListBox1.Items.Add("        molar mass of base = 35")
                                            ListBox1.Items.Add("       molar conc. of b = (mass conc)/(molar mass)")
                                            Dim x3 As Double = (Val(TextBox5.Text))
                                            Dim x4 As Double = 35
                                            ListBox1.Items.Add("       molar conc. of b = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("Therefore molar conc of b = " & (Val(TextBox5.Text)) / 35 & "mol per dm cube")
                                            Dim y As Double = (Val(TextBox5.Text)) / 35
                                            ListBox1.Items.Add("                                   ")
                                            ListBox1.Items.Add("      CA = (15.8 * " & TextBox1.Text & ") / 1000 ")
                                            Dim x5 As Double = 15.8 * Val(TextBox1.Text)
                                            Dim x6 As Double = 1000
                                            ListBox1.Items.Add("      CA = " & x5 & " / " & x6)
                                            ListBox1.Items.Add("Therefore CA = " & (Val(TextBox1.Text) * 15.8) / 1000 & "mol per dm cube")
                                            ListBox1.Items.Add("                                                                           ")
                                            ListBox1.Items.Add("         (Ca * Va)/(Cb * Vb)= Na/Nb")
                                            ListBox1.Items.Add("         Va = (Cb * Vb * Na)/(Ca * Nb)")
                                            ListBox1.Items.Add("         Va = (" & (Val(TextBox5.Text)) / 35 & ") * (" & TextBox4.Text & ") * 1 )/((" & (Val(TextBox1.Text) * 15.8) / 1000 & ") * 1) ")
                                            Dim X7 As Double = ((Val(TextBox5.Text)) / 35) * (Val(TextBox4.Text) * 1)
                                            Dim x8 As Double = ((Val(TextBox1.Text) * 15.8) / 1000) * 1
                                            ListBox1.Items.Add("         Ca = " & X7 & " / " & x8)
                                            ListBox1.Items.Add("         Ca = " & ((Val(TextBox5.Text)) / 35) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 15.8) / 1000) * 1)
                                            ListBox1.Items.Add("Therefore Conc of A (Ca) = " & ((Val(TextBox5.Text)) / 35) * (Val(TextBox4.Text) * 1) / ((Val(TextBox1.Text) * 15.8) / 1000) * 1)
                                            Dim z As Double = ((Val(TextBox5.Text)) / 35) * (Val(TextBox4.Text) * 1) / (((Val(TextBox1.Text) * 15.8) / 1000) * 1)
                                            Label4.Text = CStr(Math.Round(Val(z), 4))
                                            Label4.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If ComboBox1.Text = "Trioxonitrate(v) Acid" Then
                    If ComboBox2.Text = "Sodium Trioxocarbonate(iv)" Then
                        If TextBox1.Text <> "" Then
                            If TextBox5.Text = "" Then
                                If TextBox4.Text <> "" Then
                                    If TextBox2.Text <> "" Then
                                        If TextBox3.Text <> "" Then
                                            Label5.Text = "Methyl Orange"
                                            ListBox1.Items.Add("______________________________________________________________________________________________")
                                            ListBox1.Items.Add(" Acid = " & ComboBox1.Text & " ")
                                            ListBox1.Items.Add(" Base = " & ComboBox2.Text & " ")
                                            ListBox1.Items.Add("                                                                                            ")
                                            ListBox1.Items.Add("mass of base = " & TextBox2.Text & ", Vol of base =" & TextBox3.Text & "")
                                            ListBox1.Items.Add("         mass conc of base = (mass of base * 1000)/vol of base")
                                            ListBox1.Items.Add("         mass conc of b = ((" & TextBox2.Text & ") * 1000 )/(" & TextBox3.Text & ") ")
                                            Dim X1 As Double = Val(TextBox2.Text) * 1000
                                            Dim x2 As Double = Val(TextBox3.Text)
                                            ListBox1.Items.Add("         mass conc of b = " & X1 & " / " & x2)
                                            ListBox1.Items.Add("         mass conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)))
                                            ListBox1.Items.Add("Therefore mass conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) & "g per dm cube")
                                            Dim x As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text))
                                            ListBox1.Items.Add("                                                                                    ")
                                            ListBox1.Items.Add("        molar mass of base = 106")
                                            ListBox1.Items.Add("       molar conc. of b = (mass conc)/(molar mass)")
                                            Dim x3 As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text))
                                            Dim x4 As Double = 106
                                            ListBox1.Items.Add("       molar conc. of b = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("Therefore molar conc of b = " & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 106 & "mol per dm cube")
                                            Dim y As Double = (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 106
                                            ListBox1.Items.Add("                                   ")
                                            ListBox1.Items.Add("      CA = (15.8 * " & TextBox1.Text & ") / 1000 ")
                                            Dim x5 As Double = 15.8 * Val(TextBox1.Text)
                                            Dim x6 As Double = 1000
                                            ListBox1.Items.Add("      CA = " & x5 & " / " & x6)
                                            ListBox1.Items.Add("Therefore CA = " & (Val(TextBox1.Text) * 15.8) / 1000 & "mol per dm cube")
                                            ListBox1.Items.Add("                                                                           ")
                                            ListBox1.Items.Add("         (Ca * Va)/(Cb * Vb)= Na/Nb")
                                            ListBox1.Items.Add("         Va = (Cb * Vb * Na)/(Ca * Nb)")
                                            ListBox1.Items.Add("         Va = (" & (Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 106 & ") * (" & TextBox4.Text & ") * 2 )/((" & (Val(TextBox1.Text) * 15.8) / 1000 & ") * 1) ")
                                            Dim X7 As Double = ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 106) * (Val(TextBox4.Text) * 2)
                                            Dim x8 As Double = ((Val(TextBox1.Text) * 15.8) / 1000) * 1
                                            ListBox1.Items.Add("         Ca = " & X7 & " / " & x8)
                                            ListBox1.Items.Add("         Ca = " & ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 106) * (Val(TextBox4.Text) * 2) / ((Val(TextBox1.Text) * 15.8) / 1000) * 1)
                                            ListBox1.Items.Add("Therefore Conc of A (Ca) = " & ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 106) * (Val(TextBox4.Text) * 2) / ((Val(TextBox1.Text) * 15.8) / 1000) * 1)
                                            Dim z As Double = ((Val(TextBox2.Text) * 1000) / (Val(TextBox3.Text)) / 106) * (Val(TextBox4.Text) * 2) / (((Val(TextBox1.Text) * 15.8) / 1000) * 1)
                                            Label4.Text = CStr(Math.Round(Val(z), 4))
                                            Label4.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If ComboBox1.Text = "Trioxonitrate(v) Acid" Then
                    If ComboBox2.Text = "Sodium Trioxocarbonate(iv)" Then
                        If TextBox1.Text <> "" Then
                            If TextBox5.Text <> "" Then
                                If TextBox4.Text <> "" Then
                                    If TextBox2.Text = "" Then
                                        If TextBox3.Text = "" Then
                                            Label5.Text = "Methyl Orange"
                                            ListBox1.Items.Add("______________________________________________________________________________________________")
                                            ListBox1.Items.Add("Therefore mass conc of b = " & (Val(TextBox5.Text)) & "g per dm cube")
                                            Dim x As Double = (Val(TextBox5.Text))
                                            ListBox1.Items.Add("                                                                                    ")
                                            ListBox1.Items.Add("        molar mass of base = 106")
                                            ListBox1.Items.Add("       molar conc. of b = (mass conc)/(molar mass)")
                                            Dim x3 As Double = (Val(TextBox5.Text))
                                            Dim x4 As Double = 106
                                            ListBox1.Items.Add("       molar conc. of b = " & x3 & " / " & x4)
                                            ListBox1.Items.Add("Therefore molar conc of b = " & (Val(TextBox5.Text)) / 106 & "mol per dm cube")
                                            Dim y As Double = (Val(TextBox5.Text)) / 106
                                            ListBox1.Items.Add("                                   ")
                                            ListBox1.Items.Add("      CA = (15.8 * " & TextBox1.Text & ") / 1000 ")
                                            Dim x5 As Double = 15.8 * Val(TextBox1.Text)
                                            Dim x6 As Double = 1000
                                            ListBox1.Items.Add("      CA = " & x5 & " / " & x6)
                                            ListBox1.Items.Add("Therefore CA = " & (Val(TextBox1.Text) * 15.8) / 1000 & "mol per dm cube")
                                            ListBox1.Items.Add("                                                                           ")
                                            ListBox1.Items.Add("         (Ca * Va)/(Cb * Vb)= Na/Nb")
                                            ListBox1.Items.Add("         Va = (Cb * Vb * Na)/(Ca * Nb)")
                                            ListBox1.Items.Add("         Va = (" & (Val(TextBox5.Text)) / 106 & ") * (" & TextBox4.Text & ") * 2 )/((" & (Val(TextBox1.Text) * 15.8) / 1000 & ") * 1) ")
                                            Dim X7 As Double = ((Val(TextBox5.Text)) / 106) * (Val(TextBox4.Text) * 2)
                                            Dim x8 As Double = ((Val(TextBox1.Text) * 15.8) / 1000) * 1
                                            ListBox1.Items.Add("         Ca = " & X7 & " / " & x8)
                                            ListBox1.Items.Add("         Ca = " & ((Val(TextBox5.Text)) / 106) * (Val(TextBox4.Text) * 2) / ((Val(TextBox1.Text) * 15.8) / 1000) * 1)
                                            ListBox1.Items.Add("Therefore Conc of A (Ca) = " & ((Val(TextBox5.Text)) / 106) * (Val(TextBox4.Text) * 2) / ((Val(TextBox1.Text) * 15.8) / 1000) * 1)
                                            Dim z As Double = ((Val(TextBox5.Text)) / 106) * (Val(TextBox4.Text) * 2) / (((Val(TextBox1.Text) * 15.8) / 1000) * 1)
                                            Label4.Text = CStr(Math.Round(Val(z), 4))
                                            Label4.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            'Imikan's Calculation for volume goes in here
            Label4.Text = Val(Label4.Text) + Val(rd)
            If Val(Label4.Text) > 50 Then
                MsgBox("The Values input will lead to an Overflow. Please review them", MsgBoxStyle.Exclamation, "Error")
            Else
                Timer2.Enabled = True
                Timer4.Enabled = True
                Timer3.Enabled = True
            End If
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Button2.Visible = True
        Timer3.Enabled = False
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        yy = yy - 3
        Dim p As System.Drawing.Pen = New System.Drawing.Pen(Brushes.PaleTurquoise, 3)
        Dim gr As System.Drawing.Graphics = Me.CreateGraphics
        gr.DrawLine(p, xx, yy, zz, yy)
        If yy <= 70 Then
            Timer4.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        Label4.Text = "0.00"
        PictureBox12.Location = New Point(142, 460)
        Button2.Visible = False
        Dim gr As System.Drawing.Graphics = Me.CreateGraphics
        gr.Clear(Color.Beige)
        x = 86
        y = 624
        z = 201
        xx = 140
        yy = 430
        zz = 146
        x1 = 0
        y1 = 0
        z1 = 0
        x2 = 140
        y2 = 67
        z2 = 146
        dp = 0
        y3 = 624
        x3 = 86
        z3 = 201
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If y2 > 67 Then
            MsgBox("Titration is already started. Begin a new one first", MsgBoxStyle.Critical, "Error")
        Else
            Timer6.Enabled = True
            Timer7.Enabled = True
            Timer5.Enabled = True
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If Label5.Text = "Methyl Orange" Or Label5.Text = "Methyl Red" Then
            y1 = y1 - 2
            x1 = x1 + 1
            z1 = z1 - 1
            Dim Q As System.Drawing.Pen = New System.Drawing.Pen(Brushes.Yellow, 4)
            Dim gr As System.Drawing.Graphics = Me.CreateGraphics
            gr.DrawLine(Q, x1, y1, z1, y1)
        Else
            y1 = y1 - 2
            x1 = x1 + 1
            z1 = z1 - 1
            Dim Q As System.Drawing.Pen = New System.Drawing.Pen(Brushes.Pink, 4)
            Dim gr As System.Drawing.Graphics = Me.CreateGraphics
            gr.DrawLine(Q, x1, y1, z1, y1)
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        y2 = y2 + 3
        dp = dp + 1
        Dim p As System.Drawing.Pen = New System.Drawing.Pen(Brushes.Beige, 3)
        Dim gr As System.Drawing.Graphics = Me.CreateGraphics
        gr.DrawLine(p, x2, y2, z2, y2)
        Dim h As Integer = (Val(Label4.Text) * 120) / 50
        If dp >= h Then
            tb = tb + 1
            If tb = 1 Then
                A1.Text = CStr(Math.Round(Val(Label4.Text), 1))
                If A1.Text.Contains(".") Then
                    Dim k As String() = A1.Text.Split(".")
                    Dim j As String = k(1)
                    If j.Count = 1 Then
                        A1.Text = A1.Text & "0"
                    End If
                    If j.Count = 2 Then
                        A1.Text = A1.Text
                    End If
                Else
                    A1.Text = A1.Text & ".00"
                End If
                A2.Text = A1.Text
            End If
            If tb = 2 Then
                B1.Text = CStr(Math.Round(Val(Label4.Text), 1))
                If B1.Text.Contains(".") Then
                    Dim k As String() = B1.Text.Split(".")
                    Dim j As String = k(1)
                    If j.Count = 1 Then
                        B1.Text = B1.Text & "0"
                    End If
                    If j.Count = 2 Then
                        B1.Text = B1.Text
                    End If
                Else
                    B1.Text = B1.Text & ".00"
                End If
                B2.Text = B1.Text
            End If
            If tb = 3 Then
                C1.Text = CStr(Math.Round(Val(Label4.Text), 1))
                If C1.Text.Contains(".") Then
                    Dim k As String() = C1.Text.Split(".")
                    Dim j As String = k(1)
                    If j.Count = 1 Then
                        C1.Text = C1.Text & "0"
                    End If
                    If j.Count = 2 Then
                        C1.Text = C1.Text
                    End If
                Else
                    C1.Text = C1.Text & ".00"
                End If
                C2.Text = C1.Text
                Label26.Text = "(" & A1.Text & " + " & B1.Text & " + " & C1.Text & ") / 3"
                Label27.Text = (Val(A1.Text) + Val(B1.Text) + Val(C1.Text)) / 3
                Label27.Text = CStr(Math.Round(Val(Label27.Text), 2))
                If Label27.Text.Contains(".") Then
                    Dim k As String() = Label27.Text.Split(".")
                    Dim j As String = k(1)
                    If j.Count = 1 Then
                        Label27.Text = Label27.Text & "0"
                    End If
                    If j.Count = 2 Then
                        Label27.Text = Label27.Text
                    End If
                Else
                    Label27.Text = Label27.Text & ".00"
                End If
            End If
            Timer8.Enabled = True
            Timer6.Enabled = False
            Timer5.Enabled = False
        End If
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        PictureBox12.Visible = True
        PictureBox12.Top += 15
        If PictureBox12.Location.Y >= y1 - 25 Then
            PictureBox12.Location = New Point(142, 460)
        End If
    End Sub

    Private Sub rand_Tick(sender As Object, e As EventArgs) Handles rand.Tick
        rnd = rnd + 1
        If rnd = 1 Then
            rd = "-0.2"
        End If
        If rnd = 2 Then
            rd = "-0.1"
        End If
        If rnd = 3 Then
            rd = "0"
        End If
        If rnd = 4 Then
            rd = "0.1"
        End If
        If rnd = 5 Then
            rd = "0.2"
            rnd = 0
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        A1.Text = ""
        B1.Text = ""
        C1.Text = ""
        A2.Text = ""
        B2.Text = ""
        C2.Text = ""
        Label26.Text = ""
        Label27.Text = ""
        tb = 0
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If tb = 0 Then
            MsgBox("There is nothing to Calculate from the table. Make sure you perform a titration", MsgBoxStyle.Critical, "Error")
        Else
            If tb = 1 Then
                Label26.Text = "(" & A1.Text & ") / 1"
                Label27.Text = A1.Text
                Label27.Text = CStr(Math.Round(Val(Label27.Text), 2))
                If Label27.Text.Contains(".") Then
                    Dim k As String() = Label27.Text.Split(".")
                    Dim j As String = k(1)
                    If j.Count = 1 Then
                        Label27.Text = Label27.Text & "0"
                    End If
                    If j.Count = 2 Then
                        Label27.Text = Label27.Text
                    End If
                Else
                    Label27.Text = Label27.Text & ".00"
                End If
            End If
            If tb = 2 Then
                Label26.Text = "(" & A1.Text & " + " & B1.Text & ") / 2"
                Label27.Text = (Val(A1.Text) + Val(B1.Text)) / 2
                Label27.Text = CStr(Math.Round(Val(Label27.Text), 2))
                If Label27.Text.Contains(".") Then
                    Dim k As String() = Label27.Text.Split(".")
                    Dim j As String = k(1)
                    If j.Count = 1 Then
                        Label27.Text = Label27.Text & "0"
                    End If
                    If j.Count = 2 Then
                        Label27.Text = Label27.Text
                    End If
                Else
                    Label27.Text = Label27.Text & ".00"
                End If
            End If
            If tb = 3 Then
                Label26.Text = "(" & A1.Text & " + " & B1.Text & " + " & C1.Text & ") / 3"
                Label27.Text = (Val(A1.Text) + Val(B1.Text) + Val(C1.Text)) / 3
                Label27.Text = CStr(Math.Round(Val(Label27.Text), 2))
                If Label27.Text.Contains(".") Then
                    Dim k As String() = Label27.Text.Split(".")
                    Dim j As String = k(1)
                    If j.Count = 1 Then
                        Label27.Text = Label27.Text & "0"
                    End If
                    If j.Count = 2 Then
                        Label27.Text = Label27.Text
                    End If
                Else
                    Label27.Text = Label27.Text & ".00"
                End If
            End If
        End If
    End Sub
    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        If Label5.Text = "Methyl Orange" Or Label5.Text = "Methyl Red" Then
            y3 = y3 - 2
            x3 = x3 + 1
            z3 = z3 - 1
            Dim Q As System.Drawing.Pen = New System.Drawing.Pen(Brushes.Orange, 4)
            Dim gr As System.Drawing.Graphics = Me.CreateGraphics
            gr.DrawLine(Q, x3, y3, z3, y3)
        Else
            y3 = y3 - 2
            x3 = x3 + 1
            z3 = z3 - 1
            Dim Q As System.Drawing.Pen = New System.Drawing.Pen(Brushes.PaleTurquoise, 4)
            Dim gr As System.Drawing.Graphics = Me.CreateGraphics
            gr.DrawLine(Q, x3, y3, z3, y3)
        End If
        If y3 = y1 Then
            PictureBox12.Visible = False
            Timer7.Enabled = False
            Timer8.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label4.Text = ""
        Dim CTL As Control
        For Each CTL In Controls
            If TypeOf CTL Is TextBox Then
                CTL.Text = ""
            End If
        Next
        A1.Text = ""
        B1.Text = ""
        C1.Text = ""
        A2.Text = ""
        B2.Text = ""
        C2.Text = ""
        Label26.Text = ""
        Label27.Text = ""
        tb = 0
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("This software is a product of BTC CORP Corporation (Edinyanga Ottoho Ottoho (CEO),Victory Zibril (Program Manager) and Imikan Isinenyin Umoinyang (Software Informant)) with directions from Mr. Ime Umana (A chemist)")
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        If My.Computer.Clock.LocalTime.Hour >= 0 Then
            If My.Computer.Clock.LocalTime.Hour < 12 Then
                Dim sapi
                sapi = CreateObject("SAPI.spvoice")
                sapi.speak("Good Morning User, and welcome to the BTC's chemistry titration simulator")
                sapi.speak("Please, make sure to input your values before starting the titration")
            End If
        End If
        If My.Computer.Clock.LocalTime.Hour >= 12 Then
            If My.Computer.Clock.LocalTime.Hour < 16 Then
                Dim sapi
                sapi = CreateObject("SAPI.spvoice")
                sapi.speak("Good afternoon User, and welcome to the BTC's chemistry titration simulator")
                sapi.speak("Please, make sure to input your values before starting the titration")
            End If
        End If
        If My.Computer.Clock.LocalTime.Hour >= 16 Then
            If My.Computer.Clock.LocalTime.Hour < 24 Then
                Dim sapi
                sapi = CreateObject("SAPI.spvoice")
                sapi.speak("Good evening User, and welcome to the BTC's chemistry titration simulator")
                sapi.speak("Please make sure to input your values before starting the titration")
            End If
        End If
        Timer9.Enabled = False
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form3.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer9.Enabled = True
    End Sub
    Private Sub Button7_MouseEnter(sender As Object, e As EventArgs) Handles Button7.MouseEnter
        Button7.Image = bk2.Image
    End Sub

    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs) Handles Button7.MouseLeave
        Button7.Image = bk1.Image
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        If Label27.Text = "" Then
            MsgBox("You cannot proceed without calculating the Average volume of acid used", MsgBoxStyle.Critical, "Error")
        Else
            Form2.Show()
        End If
    End Sub

    Private Sub TitrationTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TitrationTableToolStripMenuItem.Click
        Dim sapi
        sapi = CreateObject("SAPI.spvoice")
        sapi.speak("The titration table automatically fills in the Volume of the Acid used in the reaction. To conclude at the acquired volumes, Click on the 'Calculate' button under the Table so it finds the Average. The software automatically calculates the Average at every third successive titration")
        MsgBox("The titration table automatically fills in the Volume of the Acid used in the reaction. To conclude at the acquired volumes, Click on the 'Calculate' button under the Table so it finds the Average. The software automatically calculates the Average at every third successive titration", MsgBoxStyle.Information, "Information")
    End Sub

    Private Sub InputtingValuesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputtingValuesToolStripMenuItem.Click
        Dim sapi
        sapi = CreateObject("SAPI.spvoice")
        sapi.speak("You are provided with Textboxes to input the Volume of Acid, Volume of Base, Mass of Base and the Mass Concentration of Base. You provide either the  Volume of Acid, Volume of Base and Mass of Base or only the Volume of the Acid and Mass Concentration of Base")
        MsgBox("You are provided with Textboxes to input the Volume of Acid, Volume of Base, Mass of Base and the Mass Conc. of Base. You provide either the  Volume of Acid, Volume of Base and Mass of Base or only the Volume of the Acid and Mass Conc. of Base", MsgBoxStyle.Information, "Information")
    End Sub

    Private Sub BasicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BasicToolStripMenuItem.Click
        Dim sapi
        sapi = CreateObject("SAPI.spvoice")
        sapi.speak("Please endeavour to fill in the appropriate values into the provided boxes and obey all instructions given in the previous Help items. Don't start a new titration or fill containers while a titration is going on")
        MsgBox("Please endeavour to fill in the appropriate values into the provided boxes and obey all instructions given in the previous Help items. Don't start a new titration or fill containers while a titration is going on", MsgBoxStyle.Information, "Information")
    End Sub

    Private Sub ColourSchemeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColourSchemeToolStripMenuItem.Click
        Dim sapi
        sapi = CreateObject("SAPI.spvoice")
        sapi.speak("The Sky blue colours in the containers represent transparent fluids")
        MsgBox("The Sky blue colours in the containers represent transparent fluids", MsgBoxStyle.Information, "Help and Support")
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

    End Sub
End Class
