<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDiceGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDiceGame))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.pbxLogoReverse = New System.Windows.Forms.PictureBox()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.prbLoad = New System.Windows.Forms.ProgressBar()
        Me.lblRule21 = New System.Windows.Forms.Label()
        Me.tmrPlayer = New System.Windows.Forms.Timer(Me.components)
        Me.pbxPlayerDie2 = New System.Windows.Forms.PictureBox()
        Me.pbxPlayerDie1 = New System.Windows.Forms.PictureBox()
        Me.lblDealerScore = New System.Windows.Forms.Label()
        Me.pnlScores = New System.Windows.Forms.Panel()
        Me.lblPlayerScore = New System.Windows.Forms.Label()
        Me.pbxDealerDie1 = New System.Windows.Forms.PictureBox()
        Me.pbxDealerDie2 = New System.Windows.Forms.PictureBox()
        Me.pnlRules = New System.Windows.Forms.Panel()
        Me.lblRules = New System.Windows.Forms.Label()
        Me.lblRulesTitle = New System.Windows.Forms.Label()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnHit = New System.Windows.Forms.Button()
        Me.btnStand = New System.Windows.Forms.Button()
        Me.btnUseBothDice = New System.Windows.Forms.Button()
        Me.btnUseDie2 = New System.Windows.Forms.Button()
        Me.btnUseDie1 = New System.Windows.Forms.Button()
        Me.lblScores = New System.Windows.Forms.Label()
        Me.lstScore = New System.Windows.Forms.ListBox()
        Me.tmrDealer = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameControl = New System.Windows.Forms.Timer(Me.components)
        Me.pnlHeader.SuspendLayout()
        CType(Me.pbxLogoReverse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPlayerDie2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPlayerDie1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlScores.SuspendLayout()
        CType(Me.pbxDealerDie1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDealerDie2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRules.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Transparent
        Me.pnlHeader.Controls.Add(Me.pbxLogoReverse)
        Me.pnlHeader.Controls.Add(Me.pbxLogo)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1264, 112)
        Me.pnlHeader.TabIndex = 1
        '
        'pbxLogoReverse
        '
        Me.pbxLogoReverse.Image = Global.Event_Driven_Dice.My.Resources.Resources.logoreverse
        Me.pbxLogoReverse.Location = New System.Drawing.Point(752, 3)
        Me.pbxLogoReverse.Name = "pbxLogoReverse"
        Me.pbxLogoReverse.Size = New System.Drawing.Size(100, 100)
        Me.pbxLogoReverse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogoReverse.TabIndex = 5
        Me.pbxLogoReverse.TabStop = False
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = Global.Event_Driven_Dice.My.Resources.Resources.logo
        Me.pbxLogo.Location = New System.Drawing.Point(414, 3)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(100, 100)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 4
        Me.pbxLogo.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Rockwell", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(507, 29)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(258, 59)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Dice-Jack"
        '
        'btnReset
        '
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(28, 71)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(181, 39)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(28, 16)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(0)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(181, 39)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'prbLoad
        '
        Me.prbLoad.Location = New System.Drawing.Point(0, 657)
        Me.prbLoad.Name = "prbLoad"
        Me.prbLoad.Size = New System.Drawing.Size(1264, 22)
        Me.prbLoad.TabIndex = 2
        '
        'lblRule21
        '
        Me.lblRule21.AutoSize = True
        Me.lblRule21.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRule21.ForeColor = System.Drawing.Color.White
        Me.lblRule21.Location = New System.Drawing.Point(243, 385)
        Me.lblRule21.Name = "lblRule21"
        Me.lblRule21.Size = New System.Drawing.Size(0, 30)
        Me.lblRule21.TabIndex = 8
        '
        'tmrPlayer
        '
        '
        'pbxPlayerDie2
        '
        Me.pbxPlayerDie2.Location = New System.Drawing.Point(675, 510)
        Me.pbxPlayerDie2.Name = "pbxPlayerDie2"
        Me.pbxPlayerDie2.Size = New System.Drawing.Size(102, 102)
        Me.pbxPlayerDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPlayerDie2.TabIndex = 4
        Me.pbxPlayerDie2.TabStop = False
        '
        'pbxPlayerDie1
        '
        Me.pbxPlayerDie1.Location = New System.Drawing.Point(503, 510)
        Me.pbxPlayerDie1.Name = "pbxPlayerDie1"
        Me.pbxPlayerDie1.Size = New System.Drawing.Size(102, 102)
        Me.pbxPlayerDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPlayerDie1.TabIndex = 3
        Me.pbxPlayerDie1.TabStop = False
        '
        'lblDealerScore
        '
        Me.lblDealerScore.AutoSize = True
        Me.lblDealerScore.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDealerScore.ForeColor = System.Drawing.Color.White
        Me.lblDealerScore.Location = New System.Drawing.Point(5, 7)
        Me.lblDealerScore.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDealerScore.Name = "lblDealerScore"
        Me.lblDealerScore.Size = New System.Drawing.Size(105, 25)
        Me.lblDealerScore.TabIndex = 11
        Me.lblDealerScore.Text = "Dealer: 0"
        '
        'pnlScores
        '
        Me.pnlScores.BackColor = System.Drawing.Color.Transparent
        Me.pnlScores.Controls.Add(Me.lblPlayerScore)
        Me.pnlScores.Controls.Add(Me.lblDealerScore)
        Me.pnlScores.Location = New System.Drawing.Point(571, 342)
        Me.pnlScores.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlScores.Name = "pnlScores"
        Me.pnlScores.Size = New System.Drawing.Size(152, 85)
        Me.pnlScores.TabIndex = 12
        '
        'lblPlayerScore
        '
        Me.lblPlayerScore.AutoSize = True
        Me.lblPlayerScore.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerScore.ForeColor = System.Drawing.Color.White
        Me.lblPlayerScore.Location = New System.Drawing.Point(5, 52)
        Me.lblPlayerScore.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPlayerScore.Name = "lblPlayerScore"
        Me.lblPlayerScore.Size = New System.Drawing.Size(102, 25)
        Me.lblPlayerScore.TabIndex = 12
        Me.lblPlayerScore.Text = "Player: 0"
        '
        'pbxDealerDie1
        '
        Me.pbxDealerDie1.Location = New System.Drawing.Point(496, 164)
        Me.pbxDealerDie1.Name = "pbxDealerDie1"
        Me.pbxDealerDie1.Size = New System.Drawing.Size(102, 102)
        Me.pbxDealerDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxDealerDie1.TabIndex = 13
        Me.pbxDealerDie1.TabStop = False
        '
        'pbxDealerDie2
        '
        Me.pbxDealerDie2.Location = New System.Drawing.Point(675, 164)
        Me.pbxDealerDie2.Name = "pbxDealerDie2"
        Me.pbxDealerDie2.Size = New System.Drawing.Size(102, 102)
        Me.pbxDealerDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxDealerDie2.TabIndex = 14
        Me.pbxDealerDie2.TabStop = False
        '
        'pnlRules
        '
        Me.pnlRules.BackColor = System.Drawing.Color.Transparent
        Me.pnlRules.Controls.Add(Me.lblRulesTitle)
        Me.pnlRules.Controls.Add(Me.lblRules)
        Me.pnlRules.Location = New System.Drawing.Point(82, 186)
        Me.pnlRules.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlRules.Name = "pnlRules"
        Me.pnlRules.Size = New System.Drawing.Size(265, 414)
        Me.pnlRules.TabIndex = 15
        '
        'lblRules
        '
        Me.lblRules.AutoSize = True
        Me.lblRules.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRules.ForeColor = System.Drawing.Color.White
        Me.lblRules.Location = New System.Drawing.Point(22, 45)
        Me.lblRules.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRules.Name = "lblRules"
        Me.lblRules.Size = New System.Drawing.Size(213, 340)
        Me.lblRules.TabIndex = 1
        Me.lblRules.Text = resources.GetString("lblRules.Text")
        '
        'lblRulesTitle
        '
        Me.lblRulesTitle.AutoSize = True
        Me.lblRulesTitle.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRulesTitle.ForeColor = System.Drawing.Color.White
        Me.lblRulesTitle.Location = New System.Drawing.Point(90, 13)
        Me.lblRulesTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRulesTitle.Name = "lblRulesTitle"
        Me.lblRulesTitle.Size = New System.Drawing.Size(77, 25)
        Me.lblRulesTitle.TabIndex = 0
        Me.lblRulesTitle.Text = "Rules:"
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.btnHit)
        Me.pnlButtons.Controls.Add(Me.btnStand)
        Me.pnlButtons.Controls.Add(Me.btnUseBothDice)
        Me.pnlButtons.Controls.Add(Me.btnUseDie2)
        Me.pnlButtons.Controls.Add(Me.btnUseDie1)
        Me.pnlButtons.Controls.Add(Me.lblScores)
        Me.pnlButtons.Controls.Add(Me.lstScore)
        Me.pnlButtons.Controls.Add(Me.btnStart)
        Me.pnlButtons.Controls.Add(Me.btnReset)
        Me.pnlButtons.Location = New System.Drawing.Point(891, 118)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(240, 512)
        Me.pnlButtons.TabIndex = 16
        '
        'btnHit
        '
        Me.btnHit.Enabled = False
        Me.btnHit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHit.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHit.ForeColor = System.Drawing.Color.White
        Me.btnHit.Location = New System.Drawing.Point(132, 464)
        Me.btnHit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnHit.Name = "btnHit"
        Me.btnHit.Size = New System.Drawing.Size(77, 39)
        Me.btnHit.TabIndex = 7
        Me.btnHit.Text = "Hit"
        Me.btnHit.UseVisualStyleBackColor = True
        '
        'btnStand
        '
        Me.btnStand.Enabled = False
        Me.btnStand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStand.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStand.ForeColor = System.Drawing.Color.White
        Me.btnStand.Location = New System.Drawing.Point(28, 464)
        Me.btnStand.Margin = New System.Windows.Forms.Padding(0)
        Me.btnStand.Name = "btnStand"
        Me.btnStand.Size = New System.Drawing.Size(76, 39)
        Me.btnStand.TabIndex = 6
        Me.btnStand.Text = "Stand"
        Me.btnStand.UseVisualStyleBackColor = True
        '
        'btnUseBothDice
        '
        Me.btnUseBothDice.Enabled = False
        Me.btnUseBothDice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUseBothDice.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUseBothDice.ForeColor = System.Drawing.Color.White
        Me.btnUseBothDice.Location = New System.Drawing.Point(28, 407)
        Me.btnUseBothDice.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUseBothDice.Name = "btnUseBothDice"
        Me.btnUseBothDice.Size = New System.Drawing.Size(181, 39)
        Me.btnUseBothDice.TabIndex = 5
        Me.btnUseBothDice.Text = "Add Both Dice"
        Me.btnUseBothDice.UseVisualStyleBackColor = True
        '
        'btnUseDie2
        '
        Me.btnUseDie2.Enabled = False
        Me.btnUseDie2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUseDie2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUseDie2.ForeColor = System.Drawing.Color.White
        Me.btnUseDie2.Location = New System.Drawing.Point(28, 352)
        Me.btnUseDie2.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUseDie2.Name = "btnUseDie2"
        Me.btnUseDie2.Size = New System.Drawing.Size(181, 39)
        Me.btnUseDie2.TabIndex = 4
        Me.btnUseDie2.Text = "Add Second Die"
        Me.btnUseDie2.UseVisualStyleBackColor = True
        '
        'btnUseDie1
        '
        Me.btnUseDie1.Enabled = False
        Me.btnUseDie1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUseDie1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUseDie1.ForeColor = System.Drawing.Color.White
        Me.btnUseDie1.Location = New System.Drawing.Point(28, 295)
        Me.btnUseDie1.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUseDie1.Name = "btnUseDie1"
        Me.btnUseDie1.Size = New System.Drawing.Size(181, 39)
        Me.btnUseDie1.TabIndex = 3
        Me.btnUseDie1.Text = "Add First Die"
        Me.btnUseDie1.UseVisualStyleBackColor = True
        '
        'lblScores
        '
        Me.lblScores.AutoSize = True
        Me.lblScores.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScores.ForeColor = System.Drawing.Color.White
        Me.lblScores.Location = New System.Drawing.Point(79, 118)
        Me.lblScores.Name = "lblScores"
        Me.lblScores.Size = New System.Drawing.Size(79, 25)
        Me.lblScores.TabIndex = 10
        Me.lblScores.Text = "Scores"
        '
        'lstScore
        '
        Me.lstScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lstScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstScore.ColumnWidth = 100
        Me.lstScore.Font = New System.Drawing.Font("Segoe Script", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstScore.ForeColor = System.Drawing.Color.White
        Me.lstScore.FormattingEnabled = True
        Me.lstScore.ItemHeight = 20
        Me.lstScore.Location = New System.Drawing.Point(28, 150)
        Me.lstScore.MultiColumn = True
        Me.lstScore.Name = "lstScore"
        Me.lstScore.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstScore.Size = New System.Drawing.Size(181, 122)
        Me.lstScore.TabIndex = 6
        '
        'tmrDealer
        '
        '
        'tmrGameControl
        '
        Me.tmrGameControl.Enabled = True
        '
        'frmDiceGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1260, 677)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.pnlRules)
        Me.Controls.Add(Me.pbxDealerDie2)
        Me.Controls.Add(Me.pbxDealerDie1)
        Me.Controls.Add(Me.pnlScores)
        Me.Controls.Add(Me.lblRule21)
        Me.Controls.Add(Me.pbxPlayerDie2)
        Me.Controls.Add(Me.pbxPlayerDie1)
        Me.Controls.Add(Me.prbLoad)
        Me.Controls.Add(Me.pnlHeader)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDiceGame"
        Me.Text = "Dice Game"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.pbxLogoReverse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPlayerDie2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPlayerDie1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlScores.ResumeLayout(False)
        Me.pnlScores.PerformLayout()
        CType(Me.pbxDealerDie1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDealerDie2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRules.ResumeLayout(False)
        Me.pnlRules.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlButtons.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents prbLoad As ProgressBar
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents pbxPlayerDie1 As PictureBox
    Friend WithEvents pbxPlayerDie2 As PictureBox
    Friend WithEvents lblRule21 As Label
    Friend WithEvents tmrPlayer As Timer
    Friend WithEvents lblDealerScore As Label
    Friend WithEvents pnlScores As Panel
    Friend WithEvents lblPlayerScore As Label
    Friend WithEvents pbxDealerDie1 As PictureBox
    Friend WithEvents pbxDealerDie2 As PictureBox
    Friend WithEvents pnlRules As Panel
    Friend WithEvents lblRules As Label
    Friend WithEvents lblRulesTitle As Label
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents pbxLogoReverse As PictureBox
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnUseBothDice As Button
    Friend WithEvents btnUseDie2 As Button
    Friend WithEvents btnUseDie1 As Button
    Friend WithEvents btnHit As Button
    Friend WithEvents btnStand As Button
    Friend WithEvents tmrDealer As Timer
    Friend WithEvents tmrGameControl As Timer
    Friend WithEvents lblScores As Label
    Friend WithEvents lstScore As ListBox
End Class
