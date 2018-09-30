<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.char1 = New System.Windows.Forms.PictureBox()
        Me.char2 = New System.Windows.Forms.PictureBox()
        Me.hpbar1 = New System.Windows.Forms.ProgressBar()
        Me.hpbar2 = New System.Windows.Forms.ProgressBar()
        Me.projectile1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTurn = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTimer = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.projectile2 = New System.Windows.Forms.PictureBox()
        Me.pb2 = New System.Windows.Forms.ProgressBar()
        Me.pb1 = New System.Windows.Forms.ProgressBar()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.powerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.mainTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.char1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.char2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.projectile1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.projectile2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'char1
        '
        Me.char1.Image = Global.AnimalShooterUniverse.My.Resources.Resources.cat2
        Me.char1.Location = New System.Drawing.Point(28, 378)
        Me.char1.Name = "char1"
        Me.char1.Size = New System.Drawing.Size(216, 144)
        Me.char1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.char1.TabIndex = 1
        Me.char1.TabStop = False
        '
        'char2
        '
        Me.char2.Image = Global.AnimalShooterUniverse.My.Resources.Resources.cat1
        Me.char2.InitialImage = Nothing
        Me.char2.Location = New System.Drawing.Point(797, 378)
        Me.char2.Name = "char2"
        Me.char2.Size = New System.Drawing.Size(216, 144)
        Me.char2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.char2.TabIndex = 0
        Me.char2.TabStop = False
        '
        'hpbar1
        '
        Me.hpbar1.Location = New System.Drawing.Point(70, 30)
        Me.hpbar1.Name = "hpbar1"
        Me.hpbar1.Size = New System.Drawing.Size(313, 41)
        Me.hpbar1.TabIndex = 2
        Me.hpbar1.Value = 100
        '
        'hpbar2
        '
        Me.hpbar2.Location = New System.Drawing.Point(668, 30)
        Me.hpbar2.Name = "hpbar2"
        Me.hpbar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.hpbar2.RightToLeftLayout = True
        Me.hpbar2.Size = New System.Drawing.Size(313, 41)
        Me.hpbar2.TabIndex = 3
        Me.hpbar2.Value = 100
        '
        'projectile1
        '
        Me.projectile1.Image = CType(resources.GetObject("projectile1.Image"), System.Drawing.Image)
        Me.projectile1.Location = New System.Drawing.Point(156, 408)
        Me.projectile1.Name = "projectile1"
        Me.projectile1.Size = New System.Drawing.Size(56, 22)
        Me.projectile1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.projectile1.TabIndex = 4
        Me.projectile1.TabStop = False
        Me.projectile1.Visible = False
        '
        'Timer1
        '
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblTurn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtTimer)
        Me.Panel1.Controls.Add(Me.hpbar1)
        Me.Panel1.Controls.Add(Me.hpbar2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1062, 118)
        Me.Panel1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(921, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Player 2"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Player 1"
        '
        'lblTurn
        '
        Me.lblTurn.AutoSize = True
        Me.lblTurn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurn.Location = New System.Drawing.Point(435, 74)
        Me.lblTurn.Name = "lblTurn"
        Me.lblTurn.Size = New System.Drawing.Size(183, 29)
        Me.lblTurn.TabIndex = 6
        Me.lblTurn.Text = "Turn : Player 1"
        Me.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(507, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "TIME"
        '
        'txtTimer
        '
        Me.txtTimer.Enabled = False
        Me.txtTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimer.Location = New System.Drawing.Point(487, 18)
        Me.txtTimer.Name = "txtTimer"
        Me.txtTimer.ReadOnly = True
        Me.txtTimer.Size = New System.Drawing.Size(75, 53)
        Me.txtTimer.TabIndex = 4
        Me.txtTimer.Text = "00"
        Me.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.projectile2)
        Me.Panel2.Controls.Add(Me.pb2)
        Me.Panel2.Controls.Add(Me.pb1)
        Me.Panel2.Controls.Add(Me.char1)
        Me.Panel2.Controls.Add(Me.projectile1)
        Me.Panel2.Controls.Add(Me.char2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 118)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1062, 555)
        Me.Panel2.TabIndex = 8
        '
        'projectile2
        '
        Me.projectile2.Image = CType(resources.GetObject("projectile2.Image"), System.Drawing.Image)
        Me.projectile2.Location = New System.Drawing.Point(832, 408)
        Me.projectile2.Name = "projectile2"
        Me.projectile2.Size = New System.Drawing.Size(56, 22)
        Me.projectile2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.projectile2.TabIndex = 9
        Me.projectile2.TabStop = False
        Me.projectile2.Visible = False
        '
        'pb2
        '
        Me.pb2.Location = New System.Drawing.Point(842, 319)
        Me.pb2.Maximum = 43
        Me.pb2.Minimum = 20
        Me.pb2.Name = "pb2"
        Me.pb2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pb2.RightToLeftLayout = True
        Me.pb2.Size = New System.Drawing.Size(139, 23)
        Me.pb2.TabIndex = 8
        Me.pb2.Value = 20
        Me.pb2.Visible = False
        '
        'pb1
        '
        Me.pb1.Location = New System.Drawing.Point(59, 319)
        Me.pb1.Maximum = 43
        Me.pb1.Minimum = 20
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(139, 23)
        Me.pb1.TabIndex = 7
        Me.pb1.Value = 20
        Me.pb1.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Timer2
        '
        '
        'powerTimer
        '
        '
        'mainTimer
        '
        Me.mainTimer.Interval = 1000
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(510, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 207)
        Me.Label4.TabIndex = 10
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 673)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        CType(Me.char1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.char2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.projectile1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.projectile2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents char2 As PictureBox
    Friend WithEvents char1 As PictureBox
    Friend WithEvents hpbar1 As ProgressBar
    Friend WithEvents hpbar2 As ProgressBar
    Friend WithEvents projectile1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTurn As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTimer As TextBox
    Friend WithEvents pb2 As ProgressBar
    Friend WithEvents pb1 As ProgressBar
    Friend WithEvents projectile2 As PictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Timer2 As Timer
    Friend WithEvents powerTimer As Timer
    Friend WithEvents mainTimer As Timer
    Friend WithEvents Label4 As Label
End Class
