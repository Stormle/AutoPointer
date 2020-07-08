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
        Me.moveto = New System.ComponentModel.BackgroundWorker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bendx = New System.Windows.Forms.TextBox()
        Me.bstartx = New System.Windows.Forms.TextBox()
        Me.endx = New System.Windows.Forms.TextBox()
        Me.startx = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bstarty = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bendy = New System.Windows.Forms.TextBox()
        Me.starty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.endy = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.movements1 = New System.Windows.Forms.TextBox()
        Me.movements2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.perc1 = New System.Windows.Forms.TextBox()
        Me.qwe1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.qwe6 = New System.Windows.Forms.Label()
        Me.intensitys2 = New System.Windows.Forms.TextBox()
        Me.qwe5 = New System.Windows.Forms.Label()
        Me.qwe4 = New System.Windows.Forms.Label()
        Me.intensitys1 = New System.Windows.Forms.TextBox()
        Me.qwe3 = New System.Windows.Forms.Label()
        Me.perc2 = New System.Windows.Forms.TextBox()
        Me.qwe2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.exctor = New System.ComponentModel.BackgroundWorker()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'moveto
        '
        Me.moveto.WorkerSupportsCancellation = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(19, 396)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bendx
        '
        Me.bendx.Location = New System.Drawing.Point(204, 68)
        Me.bendx.Name = "bendx"
        Me.bendx.Size = New System.Drawing.Size(41, 20)
        Me.bendx.TabIndex = 1
        '
        'bstartx
        '
        Me.bstartx.Location = New System.Drawing.Point(204, 42)
        Me.bstartx.Name = "bstartx"
        Me.bstartx.Size = New System.Drawing.Size(41, 20)
        Me.bstartx.TabIndex = 2
        '
        'endx
        '
        Me.endx.Location = New System.Drawing.Point(53, 68)
        Me.endx.Name = "endx"
        Me.endx.Size = New System.Drawing.Size(39, 20)
        Me.endx.TabIndex = 3
        '
        'startx
        '
        Me.startx.Location = New System.Drawing.Point(53, 42)
        Me.startx.Name = "startx"
        Me.startx.Size = New System.Drawing.Size(39, 20)
        Me.startx.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Start:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Region (X, Y)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(169, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Blocked region (X, Y)"
        '
        'bstarty
        '
        Me.bstarty.Location = New System.Drawing.Point(260, 42)
        Me.bstarty.Name = "bstarty"
        Me.bstarty.Size = New System.Drawing.Size(41, 20)
        Me.bstarty.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(244, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = ","
        '
        'bendy
        '
        Me.bendy.Location = New System.Drawing.Point(260, 68)
        Me.bendy.Name = "bendy"
        Me.bendy.Size = New System.Drawing.Size(41, 20)
        Me.bendy.TabIndex = 13
        '
        'starty
        '
        Me.starty.Location = New System.Drawing.Point(101, 42)
        Me.starty.Name = "starty"
        Me.starty.Size = New System.Drawing.Size(39, 20)
        Me.starty.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(90, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = ","
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(90, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(10, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = ","
        '
        'endy
        '
        Me.endy.Location = New System.Drawing.Point(101, 68)
        Me.endy.Name = "endy"
        Me.endy.Size = New System.Drawing.Size(39, 20)
        Me.endy.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "End:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "End:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(169, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Start:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(168, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Time between mouse movements:"
        '
        'movements1
        '
        Me.movements1.Location = New System.Drawing.Point(16, 43)
        Me.movements1.Name = "movements1"
        Me.movements1.Size = New System.Drawing.Size(34, 20)
        Me.movements1.TabIndex = 22
        '
        'movements2
        '
        Me.movements2.Location = New System.Drawing.Point(72, 43)
        Me.movements2.Name = "movements2"
        Me.movements2.Size = New System.Drawing.Size(34, 20)
        Me.movements2.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(56, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(10, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(112, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Seconds"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 9)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(149, 17)
        Me.CheckBox1.TabIndex = 26
        Me.CheckBox1.Text = "Enable intensity variation?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'perc1
        '
        Me.perc1.Location = New System.Drawing.Point(6, 65)
        Me.perc1.Name = "perc1"
        Me.perc1.Size = New System.Drawing.Size(30, 20)
        Me.perc1.TabIndex = 27
        Me.perc1.Visible = False
        '
        'qwe1
        '
        Me.qwe1.AutoSize = True
        Me.qwe1.Location = New System.Drawing.Point(3, 37)
        Me.qwe1.Name = "qwe1"
        Me.qwe1.Size = New System.Drawing.Size(273, 13)
        Me.qwe1.TabIndex = 28
        Me.qwe1.Text = "Cool! How often will intensity change and by how much?"
        Me.qwe1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.qwe6)
        Me.Panel1.Controls.Add(Me.intensitys2)
        Me.Panel1.Controls.Add(Me.qwe5)
        Me.Panel1.Controls.Add(Me.qwe4)
        Me.Panel1.Controls.Add(Me.intensitys1)
        Me.Panel1.Controls.Add(Me.qwe3)
        Me.Panel1.Controls.Add(Me.perc2)
        Me.Panel1.Controls.Add(Me.qwe2)
        Me.Panel1.Controls.Add(Me.qwe1)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.perc1)
        Me.Panel1.Location = New System.Drawing.Point(15, 235)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(302, 142)
        Me.Panel1.TabIndex = 29
        '
        'qwe6
        '
        Me.qwe6.AutoSize = True
        Me.qwe6.Location = New System.Drawing.Point(146, 104)
        Me.qwe6.Name = "qwe6"
        Me.qwe6.Size = New System.Drawing.Size(47, 13)
        Me.qwe6.TabIndex = 36
        Me.qwe6.Text = "seconds"
        Me.qwe6.Visible = False
        '
        'intensitys2
        '
        Me.intensitys2.Location = New System.Drawing.Point(110, 101)
        Me.intensitys2.Name = "intensitys2"
        Me.intensitys2.Size = New System.Drawing.Size(30, 20)
        Me.intensitys2.TabIndex = 35
        Me.intensitys2.Visible = False
        '
        'qwe5
        '
        Me.qwe5.AutoSize = True
        Me.qwe5.Location = New System.Drawing.Point(85, 104)
        Me.qwe5.Name = "qwe5"
        Me.qwe5.Size = New System.Drawing.Size(19, 13)
        Me.qwe5.TabIndex = 34
        Me.qwe5.Text = " to"
        Me.qwe5.Visible = False
        '
        'qwe4
        '
        Me.qwe4.AutoSize = True
        Me.qwe4.Location = New System.Drawing.Point(9, 104)
        Me.qwe4.Name = "qwe4"
        Me.qwe4.Size = New System.Drawing.Size(34, 13)
        Me.qwe4.TabIndex = 33
        Me.qwe4.Text = "Every"
        Me.qwe4.Visible = False
        '
        'intensitys1
        '
        Me.intensitys1.Location = New System.Drawing.Point(49, 101)
        Me.intensitys1.Name = "intensitys1"
        Me.intensitys1.Size = New System.Drawing.Size(30, 20)
        Me.intensitys1.TabIndex = 32
        Me.intensitys1.Visible = False
        '
        'qwe3
        '
        Me.qwe3.AutoSize = True
        Me.qwe3.Location = New System.Drawing.Point(111, 68)
        Me.qwe3.Name = "qwe3"
        Me.qwe3.Size = New System.Drawing.Size(15, 13)
        Me.qwe3.TabIndex = 31
        Me.qwe3.Text = "%"
        Me.qwe3.Visible = False
        '
        'perc2
        '
        Me.perc2.Location = New System.Drawing.Point(75, 65)
        Me.perc2.Name = "perc2"
        Me.perc2.Size = New System.Drawing.Size(30, 20)
        Me.perc2.TabIndex = 30
        Me.perc2.Visible = False
        '
        'qwe2
        '
        Me.qwe2.AutoSize = True
        Me.qwe2.Location = New System.Drawing.Point(42, 68)
        Me.qwe2.Name = "qwe2"
        Me.qwe2.Size = New System.Drawing.Size(27, 13)
        Me.qwe2.TabIndex = 29
        Me.qwe2.Text = "% to"
        Me.qwe2.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.bendx)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.bstartx)
        Me.Panel2.Controls.Add(Me.endx)
        Me.Panel2.Controls.Add(Me.startx)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.bstarty)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.bendy)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.starty)
        Me.Panel2.Controls.Add(Me.endy)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(15, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(349, 111)
        Me.Panel2.TabIndex = 37
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(169, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(167, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Leave all zeros if you don't need it"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(244, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(10, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = ","
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.movements1)
        Me.Panel3.Controls.Add(Me.movements2)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Location = New System.Drawing.Point(15, 129)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(199, 100)
        Me.Panel3.TabIndex = 0
        '
        'exctor
        '
        Me.exctor.WorkerSupportsCancellation = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Location = New System.Drawing.Point(220, 129)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(197, 100)
        Me.Panel4.TabIndex = 38
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(112, 49)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(15, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "%"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(72, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(34, 20)
        Me.TextBox1.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(189, 13)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Chance to do a second stroke at once"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 447)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "AutoPointer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents moveto As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button1 As Button
    Friend WithEvents bendx As TextBox
    Friend WithEvents bstartx As TextBox
    Friend WithEvents endx As TextBox
    Friend WithEvents startx As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents bstarty As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents bendy As TextBox
    Friend WithEvents starty As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents endy As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents movements1 As TextBox
    Friend WithEvents movements2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents perc1 As TextBox
    Friend WithEvents qwe1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents qwe6 As Label
    Friend WithEvents intensitys2 As TextBox
    Friend WithEvents qwe5 As Label
    Friend WithEvents qwe4 As Label
    Friend WithEvents intensitys1 As TextBox
    Friend WithEvents qwe3 As Label
    Friend WithEvents perc2 As TextBox
    Friend WithEvents qwe2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents exctor As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label15 As Label
End Class
