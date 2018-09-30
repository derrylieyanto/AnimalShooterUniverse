<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CharSelectForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CharSelectForm))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnChar1Next = New System.Windows.Forms.Button()
        Me.btnChar1Prev = New System.Windows.Forms.Button()
        Me.PbKiri = New System.Windows.Forms.PictureBox()
        Me.PbKanan = New System.Windows.Forms.PictureBox()
        Me.btnChar2Prev = New System.Windows.Forms.Button()
        Me.btnChar2Next = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PbKiri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbKanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(339, 198)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 19)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnChar1Next
        '
        Me.btnChar1Next.Location = New System.Drawing.Point(173, 276)
        Me.btnChar1Next.Name = "btnChar1Next"
        Me.btnChar1Next.Size = New System.Drawing.Size(75, 23)
        Me.btnChar1Next.TabIndex = 1
        Me.btnChar1Next.Text = "Next"
        Me.btnChar1Next.UseVisualStyleBackColor = True
        '
        'btnChar1Prev
        '
        Me.btnChar1Prev.Location = New System.Drawing.Point(50, 276)
        Me.btnChar1Prev.Name = "btnChar1Prev"
        Me.btnChar1Prev.Size = New System.Drawing.Size(75, 23)
        Me.btnChar1Prev.TabIndex = 2
        Me.btnChar1Prev.Text = "Previous"
        Me.btnChar1Prev.UseVisualStyleBackColor = True
        '
        'PbKiri
        '
        Me.PbKiri.Image = Global.AnimalShooterUniverse.My.Resources.Resources.kucing2
        Me.PbKiri.Location = New System.Drawing.Point(50, 120)
        Me.PbKiri.Name = "PbKiri"
        Me.PbKiri.Size = New System.Drawing.Size(198, 150)
        Me.PbKiri.TabIndex = 3
        Me.PbKiri.TabStop = False
        '
        'PbKanan
        '
        Me.PbKanan.Image = CType(resources.GetObject("PbKanan.Image"), System.Drawing.Image)
        Me.PbKanan.Location = New System.Drawing.Point(496, 120)
        Me.PbKanan.Name = "PbKanan"
        Me.PbKanan.Size = New System.Drawing.Size(212, 150)
        Me.PbKanan.TabIndex = 4
        Me.PbKanan.TabStop = False
        '
        'btnChar2Prev
        '
        Me.btnChar2Prev.Location = New System.Drawing.Point(496, 275)
        Me.btnChar2Prev.Name = "btnChar2Prev"
        Me.btnChar2Prev.Size = New System.Drawing.Size(75, 23)
        Me.btnChar2Prev.TabIndex = 5
        Me.btnChar2Prev.Text = "Previous"
        Me.btnChar2Prev.UseVisualStyleBackColor = True
        '
        'btnChar2Next
        '
        Me.btnChar2Next.Location = New System.Drawing.Point(632, 274)
        Me.btnChar2Next.Name = "btnChar2Next"
        Me.btnChar2Next.Size = New System.Drawing.Size(75, 23)
        Me.btnChar2Next.TabIndex = 6
        Me.btnChar2Next.Text = "Next"
        Me.btnChar2Next.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 304)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 7
        '
        'CharSelectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 547)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnChar2Next)
        Me.Controls.Add(Me.btnChar2Prev)
        Me.Controls.Add(Me.PbKanan)
        Me.Controls.Add(Me.PbKiri)
        Me.Controls.Add(Me.btnChar1Prev)
        Me.Controls.Add(Me.btnChar1Next)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CharSelectForm"
        Me.Text = "CharSelectForm"
        CType(Me.PbKiri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbKanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnChar1Next As Button
    Friend WithEvents btnChar1Prev As Button
    Friend WithEvents PbKiri As PictureBox
    Friend WithEvents PbKanan As PictureBox
    Friend WithEvents btnChar2Prev As Button
    Friend WithEvents btnChar2Next As Button
    Friend WithEvents Label1 As Label
End Class
