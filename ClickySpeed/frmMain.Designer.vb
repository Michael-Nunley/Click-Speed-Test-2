<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.cmdClick = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.tmrCounter = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.smiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSetInterval = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSeparatorMain = New System.Windows.Forms.ToolStripSeparator()
        Me.lblHighestClicksPerSecond = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSeparatorTop = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdResetHighestScore = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSeparatorBottom = New System.Windows.Forms.ToolStripSeparator()
        Me.tsSeparatorMainBottom = New System.Windows.Forms.ToolStripSeparator()
        Me.menuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdClick
        '
        Me.cmdClick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClick.Location = New System.Drawing.Point(11, 145)
        Me.cmdClick.Name = "cmdClick"
        Me.cmdClick.Size = New System.Drawing.Size(289, 148)
        Me.cmdClick.TabIndex = 0
        Me.cmdClick.Text = "Click!"
        Me.cmdClick.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.Location = New System.Drawing.Point(11, 299)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(289, 37)
        Me.cmdReset.TabIndex = 0
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'tmrCounter
        '
        Me.tmrCounter.Interval = 1
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(12, 24)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(289, 108)
        Me.lblTimer.TabIndex = 0
        Me.lblTimer.Text = "00.00"
        '
        'menuStrip
        '
        Me.menuStrip.BackColor = System.Drawing.SystemColors.Control
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smiFile})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.menuStrip.Size = New System.Drawing.Size(310, 24)
        Me.menuStrip.TabIndex = 0
        '
        'smiFile
        '
        Me.smiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdExit, Me.cmdSetInterval, Me.tsSeparatorMain, Me.lblHighestClicksPerSecond, Me.tsSeparatorMainBottom})
        Me.smiFile.Name = "smiFile"
        Me.smiFile.Size = New System.Drawing.Size(37, 20)
        Me.smiFile.Text = "File"
        '
        'cmdExit
        '
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(192, 22)
        Me.cmdExit.Text = "Exit"
        '
        'cmdSetInterval
        '
        Me.cmdSetInterval.Name = "cmdSetInterval"
        Me.cmdSetInterval.Size = New System.Drawing.Size(192, 22)
        Me.cmdSetInterval.Text = "Set Interval [10]"
        '
        'tsSeparatorMain
        '
        Me.tsSeparatorMain.Name = "tsSeparatorMain"
        Me.tsSeparatorMain.Size = New System.Drawing.Size(189, 6)
        '
        'lblHighestClicksPerSecond
        '
        Me.lblHighestClicksPerSecond.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSeparatorTop, Me.cmdResetHighestScore, Me.tsSeparatorBottom})
        Me.lblHighestClicksPerSecond.Name = "lblHighestClicksPerSecond"
        Me.lblHighestClicksPerSecond.Size = New System.Drawing.Size(192, 22)
        Me.lblHighestClicksPerSecond.Text = "Highest Clicks/second"
        '
        'tsSeparatorTop
        '
        Me.tsSeparatorTop.Name = "tsSeparatorTop"
        Me.tsSeparatorTop.Size = New System.Drawing.Size(268, 6)
        '
        'cmdResetHighestScore
        '
        Me.cmdResetHighestScore.Name = "cmdResetHighestScore"
        Me.cmdResetHighestScore.Size = New System.Drawing.Size(271, 22)
        Me.cmdResetHighestScore.Text = "Reset highest clicks per second count"
        '
        'tsSeparatorBottom
        '
        Me.tsSeparatorBottom.Name = "tsSeparatorBottom"
        Me.tsSeparatorBottom.Size = New System.Drawing.Size(268, 6)
        '
        'tsSeparatorMainBottom
        '
        Me.tsSeparatorMainBottom.Name = "tsSeparatorMainBottom"
        Me.tsSeparatorMainBottom.Size = New System.Drawing.Size(189, 6)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 340)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.cmdClick)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.menuStrip)
        Me.MainMenuStrip = Me.menuStrip
        Me.Name = "frmMain"
        Me.Text = "How fast can you click?"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdClick As System.Windows.Forms.Button
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents tmrCounter As System.Windows.Forms.Timer
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents menuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents smiFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdSetInterval As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblHighestClicksPerSecond As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSeparatorMain As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdResetHighestScore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSeparatorTop As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsSeparatorBottom As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsSeparatorMainBottom As System.Windows.Forms.ToolStripSeparator

End Class
