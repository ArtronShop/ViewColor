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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Info = New System.Windows.Forms.Button()
        Me.ColorView = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.AppId = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.APIAuth = New System.Windows.Forms.TextBox()
        Me.Connect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RGBCopy = New System.Windows.Forms.Button()
        Me.HexCopy = New System.Windows.Forms.Button()
        Me.UpdateColorTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RGBBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.HexBox = New System.Windows.Forms.TextBox()
        Me.Status = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Info
        '
        Me.Info.BackColor = System.Drawing.Color.Transparent
        Me.Info.FlatAppearance.BorderSize = 0
        Me.Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Info.Image = CType(resources.GetObject("Info.Image"), System.Drawing.Image)
        Me.Info.Location = New System.Drawing.Point(191, 222)
        Me.Info.Name = "Info"
        Me.Info.Size = New System.Drawing.Size(29, 27)
        Me.Info.TabIndex = 0
        Me.Info.UseVisualStyleBackColor = False
        '
        'ColorView
        '
        Me.ColorView.BackColor = System.Drawing.Color.Black
        Me.ColorView.Location = New System.Drawing.Point(27, 119)
        Me.ColorView.Name = "ColorView"
        Me.ColorView.Size = New System.Drawing.Size(128, 128)
        Me.ColorView.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Connect)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 55)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(214, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "App id:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.AppId)
        Me.Panel4.Location = New System.Drawing.Point(260, 21)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(62, 23)
        Me.Panel4.TabIndex = 4
        '
        'AppId
        '
        Me.AppId.BackColor = System.Drawing.Color.White
        Me.AppId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AppId.Location = New System.Drawing.Point(5, 5)
        Me.AppId.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.AppId.Name = "AppId"
        Me.AppId.Size = New System.Drawing.Size(52, 13)
        Me.AppId.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.APIAuth)
        Me.Panel1.Location = New System.Drawing.Point(95, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(113, 23)
        Me.Panel1.TabIndex = 2
        '
        'APIAuth
        '
        Me.APIAuth.BackColor = System.Drawing.Color.White
        Me.APIAuth.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.APIAuth.Location = New System.Drawing.Point(5, 6)
        Me.APIAuth.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.APIAuth.Name = "APIAuth"
        Me.APIAuth.Size = New System.Drawing.Size(103, 13)
        Me.APIAuth.TabIndex = 3
        '
        'Connect
        '
        Me.Connect.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Connect.FlatAppearance.BorderSize = 0
        Me.Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Connect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Connect.ForeColor = System.Drawing.Color.White
        Me.Connect.Location = New System.Drawing.Point(328, 21)
        Me.Connect.Name = "Connect"
        Me.Connect.Size = New System.Drawing.Size(71, 23)
        Me.Connect.TabIndex = 2
        Me.Connect.Text = "Connect"
        Me.Connect.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "REST API auth:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(157, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "RGB:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(157, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hex:"
        '
        'RGBCopy
        '
        Me.RGBCopy.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RGBCopy.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RGBCopy.FlatAppearance.BorderSize = 0
        Me.RGBCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RGBCopy.Image = CType(resources.GetObject("RGBCopy.Image"), System.Drawing.Image)
        Me.RGBCopy.Location = New System.Drawing.Point(369, 132)
        Me.RGBCopy.Name = "RGBCopy"
        Me.RGBCopy.Size = New System.Drawing.Size(31, 31)
        Me.RGBCopy.TabIndex = 7
        Me.RGBCopy.UseVisualStyleBackColor = False
        '
        'HexCopy
        '
        Me.HexCopy.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HexCopy.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.HexCopy.FlatAppearance.BorderSize = 0
        Me.HexCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HexCopy.Image = CType(resources.GetObject("HexCopy.Image"), System.Drawing.Image)
        Me.HexCopy.Location = New System.Drawing.Point(369, 175)
        Me.HexCopy.Name = "HexCopy"
        Me.HexCopy.Size = New System.Drawing.Size(31, 31)
        Me.HexCopy.TabIndex = 8
        Me.HexCopy.UseVisualStyleBackColor = False
        '
        'UpdateColorTimer
        '
        Me.UpdateColorTimer.Interval = 3000
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Navy
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(162, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.RGBBox)
        Me.Panel3.Location = New System.Drawing.Point(226, 132)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(137, 31)
        Me.Panel3.TabIndex = 5
        '
        'RGBBox
        '
        Me.RGBBox.BackColor = System.Drawing.Color.White
        Me.RGBBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RGBBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RGBBox.Location = New System.Drawing.Point(3, 4)
        Me.RGBBox.Name = "RGBBox"
        Me.RGBBox.ReadOnly = True
        Me.RGBBox.Size = New System.Drawing.Size(131, 24)
        Me.RGBBox.TabIndex = 10
        Me.RGBBox.Text = "0,0,0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.HexBox)
        Me.Panel2.Location = New System.Drawing.Point(226, 176)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(137, 31)
        Me.Panel2.TabIndex = 6
        '
        'HexBox
        '
        Me.HexBox.BackColor = System.Drawing.Color.White
        Me.HexBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HexBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.HexBox.Location = New System.Drawing.Point(3, 3)
        Me.HexBox.Name = "HexBox"
        Me.HexBox.ReadOnly = True
        Me.HexBox.Size = New System.Drawing.Size(131, 24)
        Me.HexBox.TabIndex = 11
        Me.HexBox.Text = "#000000"
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Location = New System.Drawing.Point(223, 229)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(68, 13)
        Me.Status.TabIndex = 10
        Me.Status.Text = "wait connect"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(429, 301)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.HexCopy)
        Me.Controls.Add(Me.RGBCopy)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ColorView)
        Me.Controls.Add(Me.Info)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewColor By IOXhop.com"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Info As Button
    Friend WithEvents ColorView As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Connect As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RGBCopy As Button
    Friend WithEvents HexCopy As Button
    Friend WithEvents UpdateColorTimer As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents APIAuth As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RGBBox As TextBox
    Friend WithEvents HexBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents AppId As TextBox
    Friend WithEvents Status As Label
End Class
