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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTurn = New System.Windows.Forms.Label()
        Me.txtTimer = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.wall = New System.Windows.Forms.Label()
        Me.projectile2 = New System.Windows.Forms.PictureBox()
        Me.pb2 = New System.Windows.Forms.ProgressBar()
        Me.pb1 = New System.Windows.Forms.ProgressBar()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.powerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.mainTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnSkill1 = New System.Windows.Forms.Button()
        Me.btnSkill2 = New System.Windows.Forms.Button()
        CType(Me.char1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.char2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.projectile1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.projectile2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'char1
        '
        Me.char1.Image = Global.AnimalShooterUniverse.My.Resources.Resources.cat2
        Me.char1.Location = New System.Drawing.Point(34, 397)
        Me.char1.Margin = New System.Windows.Forms.Padding(2)
        Me.char1.Name = "char1"
        Me.char1.Size = New System.Drawing.Size(216, 144)
        Me.char1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.char1.TabIndex = 1
        Me.char1.TabStop = False
        '
        'char2
        '
        Me.char2.Image = CType(resources.GetObject("char2.Image"), System.Drawing.Image)
        Me.char2.InitialImage = Nothing
        Me.char2.Location = New System.Drawing.Point(803, 397)
        Me.char2.Margin = New System.Windows.Forms.Padding(2)
        Me.char2.Name = "char2"
        Me.char2.Size = New System.Drawing.Size(213, 142)
        Me.char2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.char2.TabIndex = 0
        Me.char2.TabStop = False
        '
        'hpbar1
        '
        Me.hpbar1.Location = New System.Drawing.Point(109, 26)
        Me.hpbar1.Margin = New System.Windows.Forms.Padding(2)
        Me.hpbar1.Name = "hpbar1"
        Me.hpbar1.Size = New System.Drawing.Size(235, 33)
        Me.hpbar1.TabIndex = 2
        Me.hpbar1.Value = 100
        '
        'hpbar2
        '
        Me.hpbar2.Location = New System.Drawing.Point(727, 26)
        Me.hpbar2.Margin = New System.Windows.Forms.Padding(2)
        Me.hpbar2.Name = "hpbar2"
        Me.hpbar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.hpbar2.RightToLeftLayout = True
        Me.hpbar2.Size = New System.Drawing.Size(235, 33)
        Me.hpbar2.TabIndex = 3
        Me.hpbar2.Value = 100
        '
        'projectile1
        '
        Me.projectile1.Image = CType(resources.GetObject("projectile1.Image"), System.Drawing.Image)
        Me.projectile1.Location = New System.Drawing.Point(130, 449)
        Me.projectile1.Margin = New System.Windows.Forms.Padding(2)
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
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblTurn)
        Me.Panel1.Controls.Add(Me.txtTimer)
        Me.Panel1.Controls.Add(Me.hpbar1)
        Me.Panel1.Controls.Add(Me.hpbar2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1064, 96)
        Me.Panel1.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(967, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(94, 88)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AnimalShooterUniverse.My.Resources.Resources.cat2
        Me.PictureBox1.Location = New System.Drawing.Point(10, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(885, 3)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Player 2"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Player 1"
        '
        'lblTurn
        '
        Me.lblTurn.AutoSize = True
        Me.lblTurn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurn.Location = New System.Drawing.Point(438, 61)
        Me.lblTurn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTurn.Name = "lblTurn"
        Me.lblTurn.Size = New System.Drawing.Size(147, 24)
        Me.lblTurn.TabIndex = 6
        Me.lblTurn.Text = "Turn : Player 1"
        Me.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTimer
        '
        Me.txtTimer.Enabled = False
        Me.txtTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimer.Location = New System.Drawing.Point(480, 15)
        Me.txtTimer.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTimer.Name = "txtTimer"
        Me.txtTimer.ReadOnly = True
        Me.txtTimer.Size = New System.Drawing.Size(57, 44)
        Me.txtTimer.TabIndex = 4
        Me.txtTimer.Text = "00"
        Me.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnSkill2)
        Me.Panel2.Controls.Add(Me.btnSkill1)
        Me.Panel2.Controls.Add(Me.wall)
        Me.Panel2.Controls.Add(Me.pb2)
        Me.Panel2.Controls.Add(Me.pb1)
        Me.Panel2.Controls.Add(Me.char2)
        Me.Panel2.Controls.Add(Me.char1)
        Me.Panel2.Controls.Add(Me.projectile2)
        Me.Panel2.Controls.Add(Me.projectile1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 96)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1064, 585)
        Me.Panel2.TabIndex = 8
        '
        'wall
        '
        Me.wall.BackColor = System.Drawing.Color.Black
        Me.wall.Location = New System.Drawing.Point(498, 288)
        Me.wall.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.wall.Name = "wall"
        Me.wall.Size = New System.Drawing.Size(39, 253)
        Me.wall.TabIndex = 10
        '
        'projectile2
        '
        Me.projectile2.Image = CType(resources.GetObject("projectile2.Image"), System.Drawing.Image)
        Me.projectile2.Location = New System.Drawing.Point(863, 449)
        Me.projectile2.Margin = New System.Windows.Forms.Padding(2)
        Me.projectile2.Name = "projectile2"
        Me.projectile2.Size = New System.Drawing.Size(56, 22)
        Me.projectile2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.projectile2.TabIndex = 9
        Me.projectile2.TabStop = False
        Me.projectile2.Visible = False
        '
        'pb2
        '
        Me.pb2.Location = New System.Drawing.Point(842, 350)
        Me.pb2.Margin = New System.Windows.Forms.Padding(2)
        Me.pb2.Maximum = 43
        Me.pb2.Minimum = 20
        Me.pb2.Name = "pb2"
        Me.pb2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pb2.Size = New System.Drawing.Size(104, 19)
        Me.pb2.TabIndex = 8
        Me.pb2.Value = 20
        Me.pb2.Visible = False
        '
        'pb1
        '
        Me.pb1.Location = New System.Drawing.Point(102, 350)
        Me.pb1.Margin = New System.Windows.Forms.Padding(2)
        Me.pb1.Maximum = 43
        Me.pb1.Minimum = 20
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(104, 19)
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
        'btnSkill1
        '
        Me.btnSkill1.Location = New System.Drawing.Point(34, 15)
        Me.btnSkill1.Name = "btnSkill1"
        Me.btnSkill1.Size = New System.Drawing.Size(91, 47)
        Me.btnSkill1.TabIndex = 11
        Me.btnSkill1.Text = "SKILL"
        Me.btnSkill1.UseVisualStyleBackColor = True
        '
        'btnSkill2
        '
        Me.btnSkill2.Location = New System.Drawing.Point(925, 15)
        Me.btnSkill2.Name = "btnSkill2"
        Me.btnSkill2.Size = New System.Drawing.Size(91, 47)
        Me.btnSkill2.TabIndex = 12
        Me.btnSkill2.Text = "SKILL"
        Me.btnSkill2.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        CType(Me.char1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.char2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.projectile1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtTimer As TextBox
    Friend WithEvents pb2 As ProgressBar
    Friend WithEvents pb1 As ProgressBar
    Friend WithEvents projectile2 As PictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Timer2 As Timer
    Friend WithEvents powerTimer As Timer
    Friend WithEvents mainTimer As Timer
    Friend WithEvents wall As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSkill2 As Button
    Friend WithEvents btnSkill1 As Button
End Class
