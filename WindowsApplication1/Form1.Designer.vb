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
        Me.buttonGetBuffer = New System.Windows.Forms.Button
        Me.buttonClear = New System.Windows.Forms.Button
        Me.radioButtonPassive = New System.Windows.Forms.RadioButton
        Me.radioButtonActive = New System.Windows.Forms.RadioButton
        Me.label4 = New System.Windows.Forms.Label
        Me.textBoxT2 = New System.Windows.Forms.TextBox
        Me.label3 = New System.Windows.Forms.Label
        Me.textBoxT1 = New System.Windows.Forms.TextBox
        Me.buttonSetMode = New System.Windows.Forms.Button
        Me.listBoxTags = New System.Windows.Forms.ListBox
        Me.listBoxReaders = New System.Windows.Forms.ListBox
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.textBoxGain = New System.Windows.Forms.TextBox
        Me.statusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.buttonSetGain = New System.Windows.Forms.Button
        Me.statusBar1 = New System.Windows.Forms.StatusBar
        Me.statusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.statusBarPanel3 = New System.Windows.Forms.StatusBarPanel
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnListen = New System.Windows.Forms.Button
        CType(Me.statusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.statusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.statusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonGetBuffer
        '
        Me.buttonGetBuffer.Location = New System.Drawing.Point(185, 33)
        Me.buttonGetBuffer.Name = "buttonGetBuffer"
        Me.buttonGetBuffer.Size = New System.Drawing.Size(75, 22)
        Me.buttonGetBuffer.TabIndex = 62
        Me.buttonGetBuffer.Text = "Get Buffer"
        Me.buttonGetBuffer.UseVisualStyleBackColor = True
        '
        'buttonClear
        '
        Me.buttonClear.Location = New System.Drawing.Point(75, 60)
        Me.buttonClear.Name = "buttonClear"
        Me.buttonClear.Size = New System.Drawing.Size(63, 21)
        Me.buttonClear.TabIndex = 61
        Me.buttonClear.Text = "Clear"
        '
        'radioButtonPassive
        '
        Me.radioButtonPassive.AutoSize = True
        Me.radioButtonPassive.Location = New System.Drawing.Point(266, 36)
        Me.radioButtonPassive.Name = "radioButtonPassive"
        Me.radioButtonPassive.Size = New System.Drawing.Size(62, 17)
        Me.radioButtonPassive.TabIndex = 60
        Me.radioButtonPassive.Text = "Passive"
        Me.radioButtonPassive.UseVisualStyleBackColor = True
        '
        'radioButtonActive
        '
        Me.radioButtonActive.AutoSize = True
        Me.radioButtonActive.Checked = True
        Me.radioButtonActive.Location = New System.Drawing.Point(266, 13)
        Me.radioButtonActive.Name = "radioButtonActive"
        Me.radioButtonActive.Size = New System.Drawing.Size(55, 17)
        Me.radioButtonActive.TabIndex = 59
        Me.radioButtonActive.TabStop = True
        Me.radioButtonActive.Text = "Active"
        Me.radioButtonActive.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(344, 38)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(23, 13)
        Me.label4.TabIndex = 58
        Me.label4.Text = "T2:"
        '
        'textBoxT2
        '
        Me.textBoxT2.Location = New System.Drawing.Point(373, 35)
        Me.textBoxT2.Name = "textBoxT2"
        Me.textBoxT2.Size = New System.Drawing.Size(30, 20)
        Me.textBoxT2.TabIndex = 57
        Me.textBoxT2.Text = "10"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(344, 15)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(23, 13)
        Me.label3.TabIndex = 56
        Me.label3.Text = "T1:"
        '
        'textBoxT1
        '
        Me.textBoxT1.Location = New System.Drawing.Point(373, 11)
        Me.textBoxT1.Name = "textBoxT1"
        Me.textBoxT1.Size = New System.Drawing.Size(30, 20)
        Me.textBoxT1.TabIndex = 55
        Me.textBoxT1.Text = "1"
        '
        'buttonSetMode
        '
        Me.buttonSetMode.Location = New System.Drawing.Point(185, 10)
        Me.buttonSetMode.Name = "buttonSetMode"
        Me.buttonSetMode.Size = New System.Drawing.Size(75, 22)
        Me.buttonSetMode.TabIndex = 54
        Me.buttonSetMode.Text = "Set Mode"
        Me.buttonSetMode.UseVisualStyleBackColor = True
        '
        'listBoxTags
        '
        Me.listBoxTags.FormattingEnabled = True
        Me.listBoxTags.Location = New System.Drawing.Point(35, 87)
        Me.listBoxTags.Name = "listBoxTags"
        Me.listBoxTags.Size = New System.Drawing.Size(600, 160)
        Me.listBoxTags.TabIndex = 53
        '
        'listBoxReaders
        '
        Me.listBoxReaders.FormattingEnabled = True
        Me.listBoxReaders.Location = New System.Drawing.Point(35, 270)
        Me.listBoxReaders.Name = "listBoxReaders"
        Me.listBoxReaders.Size = New System.Drawing.Size(600, 95)
        Me.listBoxReaders.TabIndex = 52
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(35, 64)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(34, 13)
        Me.label2.TabIndex = 51
        Me.label2.Text = "Tags:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(32, 254)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(50, 13)
        Me.label1.TabIndex = 50
        Me.label1.Text = "Readers:"
        '
        'textBoxGain
        '
        Me.textBoxGain.Location = New System.Drawing.Point(529, 12)
        Me.textBoxGain.Name = "textBoxGain"
        Me.textBoxGain.Size = New System.Drawing.Size(48, 20)
        Me.textBoxGain.TabIndex = 49
        Me.textBoxGain.Text = "31"
        '
        'statusBarPanel1
        '
        Me.statusBarPanel1.Name = "statusBarPanel1"
        Me.statusBarPanel1.Width = 150
        '
        'buttonSetGain
        '
        Me.buttonSetGain.Location = New System.Drawing.Point(448, 11)
        Me.buttonSetGain.Name = "buttonSetGain"
        Me.buttonSetGain.Size = New System.Drawing.Size(75, 23)
        Me.buttonSetGain.TabIndex = 48
        Me.buttonSetGain.Text = "Set Gain"
        Me.buttonSetGain.UseVisualStyleBackColor = True
        '
        'statusBar1
        '
        Me.statusBar1.Location = New System.Drawing.Point(0, 370)
        Me.statusBar1.Name = "statusBar1"
        Me.statusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.statusBarPanel1, Me.statusBarPanel2, Me.statusBarPanel3})
        Me.statusBar1.ShowPanels = True
        Me.statusBar1.Size = New System.Drawing.Size(669, 20)
        Me.statusBar1.TabIndex = 46
        '
        'statusBarPanel2
        '
        Me.statusBarPanel2.Name = "statusBarPanel2"
        Me.statusBarPanel2.Width = 350
        '
        'statusBarPanel3
        '
        Me.statusBarPanel3.Name = "statusBarPanel3"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(103, 11)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(63, 21)
        Me.btnExit.TabIndex = 47
        Me.btnExit.Text = "Exit"
        '
        'btnListen
        '
        Me.btnListen.Location = New System.Drawing.Point(35, 11)
        Me.btnListen.Name = "btnListen"
        Me.btnListen.Size = New System.Drawing.Size(62, 21)
        Me.btnListen.TabIndex = 45
        Me.btnListen.Text = "Listen"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 390)
        Me.Controls.Add(Me.buttonGetBuffer)
        Me.Controls.Add(Me.buttonClear)
        Me.Controls.Add(Me.radioButtonPassive)
        Me.Controls.Add(Me.radioButtonActive)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.textBoxT2)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.textBoxT1)
        Me.Controls.Add(Me.buttonSetMode)
        Me.Controls.Add(Me.listBoxTags)
        Me.Controls.Add(Me.listBoxReaders)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.textBoxGain)
        Me.Controls.Add(Me.buttonSetGain)
        Me.Controls.Add(Me.statusBar1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnListen)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.statusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.statusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.statusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents buttonGetBuffer As System.Windows.Forms.Button
    Private WithEvents buttonClear As System.Windows.Forms.Button
    Private WithEvents radioButtonPassive As System.Windows.Forms.RadioButton
    Private WithEvents radioButtonActive As System.Windows.Forms.RadioButton
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents textBoxT2 As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents textBoxT1 As System.Windows.Forms.TextBox
    Private WithEvents buttonSetMode As System.Windows.Forms.Button
    Private WithEvents listBoxTags As System.Windows.Forms.ListBox
    Private WithEvents listBoxReaders As System.Windows.Forms.ListBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents textBoxGain As System.Windows.Forms.TextBox
    Private WithEvents statusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Private WithEvents buttonSetGain As System.Windows.Forms.Button
    Private WithEvents statusBar1 As System.Windows.Forms.StatusBar
    Private WithEvents statusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Private WithEvents statusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Private WithEvents btnExit As System.Windows.Forms.Button
    Private WithEvents btnListen As System.Windows.Forms.Button

End Class
