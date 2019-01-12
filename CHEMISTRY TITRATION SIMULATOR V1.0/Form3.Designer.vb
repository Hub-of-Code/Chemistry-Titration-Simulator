<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.a6 = New System.Windows.Forms.PictureBox()
        Me.a5 = New System.Windows.Forms.PictureBox()
        Me.a4 = New System.Windows.Forms.PictureBox()
        Me.a3 = New System.Windows.Forms.PictureBox()
        Me.a2 = New System.Windows.Forms.PictureBox()
        Me.a1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.a6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.a5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.a4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.a3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.a2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.a1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'a6
        '
        Me.a6.BackColor = System.Drawing.Color.White
        Me.a6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a6.Location = New System.Drawing.Point(356, 212)
        Me.a6.Name = "a6"
        Me.a6.Size = New System.Drawing.Size(25, 25)
        Me.a6.TabIndex = 17
        Me.a6.TabStop = False
        '
        'a5
        '
        Me.a5.BackColor = System.Drawing.Color.White
        Me.a5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a5.Location = New System.Drawing.Point(328, 212)
        Me.a5.Name = "a5"
        Me.a5.Size = New System.Drawing.Size(25, 25)
        Me.a5.TabIndex = 16
        Me.a5.TabStop = False
        '
        'a4
        '
        Me.a4.BackColor = System.Drawing.Color.White
        Me.a4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a4.Location = New System.Drawing.Point(300, 212)
        Me.a4.Name = "a4"
        Me.a4.Size = New System.Drawing.Size(25, 25)
        Me.a4.TabIndex = 15
        Me.a4.TabStop = False
        '
        'a3
        '
        Me.a3.BackColor = System.Drawing.Color.White
        Me.a3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a3.Location = New System.Drawing.Point(273, 212)
        Me.a3.Name = "a3"
        Me.a3.Size = New System.Drawing.Size(25, 25)
        Me.a3.TabIndex = 14
        Me.a3.TabStop = False
        '
        'a2
        '
        Me.a2.BackColor = System.Drawing.Color.White
        Me.a2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a2.Location = New System.Drawing.Point(245, 212)
        Me.a2.Name = "a2"
        Me.a2.Size = New System.Drawing.Size(25, 25)
        Me.a2.TabIndex = 13
        Me.a2.TabStop = False
        '
        'a1
        '
        Me.a1.BackColor = System.Drawing.Color.White
        Me.a1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a1.Location = New System.Drawing.Point(218, 212)
        Me.a1.Name = "a1"
        Me.a1.Size = New System.Drawing.Size(25, 25)
        Me.a1.TabIndex = 12
        Me.a1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 6000
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(594, 280)
        Me.Controls.Add(Me.a6)
        Me.Controls.Add(Me.a5)
        Me.Controls.Add(Me.a4)
        Me.Controls.Add(Me.a3)
        Me.Controls.Add(Me.a2)
        Me.Controls.Add(Me.a1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StartUp"
        CType(Me.a6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.a5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.a4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.a3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.a2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.a1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents a6 As System.Windows.Forms.PictureBox
    Friend WithEvents a5 As System.Windows.Forms.PictureBox
    Friend WithEvents a4 As System.Windows.Forms.PictureBox
    Friend WithEvents a3 As System.Windows.Forms.PictureBox
    Friend WithEvents a2 As System.Windows.Forms.PictureBox
    Friend WithEvents a1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
