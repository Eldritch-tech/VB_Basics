<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.txtSampleText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLoadImage = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.chkBold = New System.Windows.Forms.CheckBox()
        Me.chkItalic = New System.Windows.Forms.CheckBox()
        Me.chkBoldItalic = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.rbBlue = New System.Windows.Forms.CheckBox()
        Me.rbRed = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.rbGaramond = New System.Windows.Forms.CheckBox()
        Me.rbMagneto = New System.Windows.Forms.CheckBox()
        Me.rbTahoma = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbGreen = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(40, 23)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(126, 68)
        Me.ListBox1.TabIndex = 0
        '
        'txtSampleText
        '
        Me.txtSampleText.Location = New System.Drawing.Point(54, 61)
        Me.txtSampleText.Name = "txtSampleText"
        Me.txtSampleText.Size = New System.Drawing.Size(100, 22)
        Me.txtSampleText.TabIndex = 1
        Me.txtSampleText.Text = "Sample Text"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Display Text"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(53, 133)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 177)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btnLoadImage
        '
        Me.btnLoadImage.Location = New System.Drawing.Point(64, 337)
        Me.btnLoadImage.Name = "btnLoadImage"
        Me.btnLoadImage.Size = New System.Drawing.Size(112, 23)
        Me.btnLoadImage.TabIndex = 9
        Me.btnLoadImage.Text = "Load Picture"
        Me.btnLoadImage.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(575, 336)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(293, 133)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(187, 176)
        Me.ListView1.TabIndex = 20
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'chkBold
        '
        Me.chkBold.AutoSize = True
        Me.chkBold.Location = New System.Drawing.Point(322, 159)
        Me.chkBold.Name = "chkBold"
        Me.chkBold.Size = New System.Drawing.Size(57, 20)
        Me.chkBold.TabIndex = 21
        Me.chkBold.Text = "Bold"
        Me.chkBold.UseVisualStyleBackColor = True
        '
        'chkItalic
        '
        Me.chkItalic.AutoSize = True
        Me.chkItalic.Location = New System.Drawing.Point(322, 205)
        Me.chkItalic.Name = "chkItalic"
        Me.chkItalic.Size = New System.Drawing.Size(63, 20)
        Me.chkItalic.TabIndex = 22
        Me.chkItalic.Text = "Italics"
        Me.chkItalic.UseVisualStyleBackColor = True
        '
        'chkBoldItalic
        '
        Me.chkBoldItalic.AutoSize = True
        Me.chkBoldItalic.Location = New System.Drawing.Point(322, 251)
        Me.chkBoldItalic.Name = "chkBoldItalic"
        Me.chkBoldItalic.Size = New System.Drawing.Size(94, 20)
        Me.chkBoldItalic.TabIndex = 23
        Me.chkBoldItalic.Text = "Bold Italics"
        Me.chkBoldItalic.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(319, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Font Style"
        '
        'ListView2
        '
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(533, 135)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(178, 173)
        Me.ListView2.TabIndex = 25
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'rbBlue
        '
        Me.rbBlue.AutoSize = True
        Me.rbBlue.Location = New System.Drawing.Point(564, 205)
        Me.rbBlue.Name = "rbBlue"
        Me.rbBlue.Size = New System.Drawing.Size(56, 20)
        Me.rbBlue.TabIndex = 27
        Me.rbBlue.Text = "Blue"
        Me.rbBlue.UseVisualStyleBackColor = True
        '
        'rbRed
        '
        Me.rbRed.AutoSize = True
        Me.rbRed.Location = New System.Drawing.Point(564, 253)
        Me.rbRed.Name = "rbRed"
        Me.rbRed.Size = New System.Drawing.Size(55, 20)
        Me.rbRed.TabIndex = 28
        Me.rbRed.Text = "Red"
        Me.rbRed.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(568, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Font Color"
        '
        'ListView3
        '
        Me.ListView3.HideSelection = False
        Me.ListView3.Location = New System.Drawing.Point(299, 36)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(411, 69)
        Me.ListView3.TabIndex = 30
        Me.ListView3.UseCompatibleStateImageBehavior = False
        '
        'rbGaramond
        '
        Me.rbGaramond.AutoSize = True
        Me.rbGaramond.Location = New System.Drawing.Point(333, 62)
        Me.rbGaramond.Name = "rbGaramond"
        Me.rbGaramond.Size = New System.Drawing.Size(93, 20)
        Me.rbGaramond.TabIndex = 31
        Me.rbGaramond.Text = "Garamond"
        Me.rbGaramond.UseVisualStyleBackColor = True
        '
        'rbMagneto
        '
        Me.rbMagneto.AutoSize = True
        Me.rbMagneto.Location = New System.Drawing.Point(466, 61)
        Me.rbMagneto.Name = "rbMagneto"
        Me.rbMagneto.Size = New System.Drawing.Size(82, 20)
        Me.rbMagneto.TabIndex = 32
        Me.rbMagneto.Text = "Magneto"
        Me.rbMagneto.UseVisualStyleBackColor = True
        '
        'rbTahoma
        '
        Me.rbTahoma.AutoSize = True
        Me.rbTahoma.Location = New System.Drawing.Point(603, 61)
        Me.rbTahoma.Name = "rbTahoma"
        Me.rbTahoma.Size = New System.Drawing.Size(80, 20)
        Me.rbTahoma.TabIndex = 33
        Me.rbTahoma.Text = "Tahoma"
        Me.rbTahoma.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(331, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Font"
        '
        'rbGreen
        '
        Me.rbGreen.AutoSize = True
        Me.rbGreen.Location = New System.Drawing.Point(564, 159)
        Me.rbGreen.Name = "rbGreen"
        Me.rbGreen.Size = New System.Drawing.Size(66, 20)
        Me.rbGreen.TabIndex = 35
        Me.rbGreen.Text = "Green"
        Me.rbGreen.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rbGreen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rbTahoma)
        Me.Controls.Add(Me.rbMagneto)
        Me.Controls.Add(Me.rbGaramond)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rbRed)
        Me.Controls.Add(Me.rbBlue)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkBoldItalic)
        Me.Controls.Add(Me.chkItalic)
        Me.Controls.Add(Me.chkBold)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLoadImage)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSampleText)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents txtSampleText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLoadImage As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents chkBold As CheckBox
    Friend WithEvents chkItalic As CheckBox
    Friend WithEvents chkBoldItalic As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ListView2 As ListView
    Friend WithEvents rbBlue As CheckBox
    Friend WithEvents rbRed As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ListView3 As ListView
    Friend WithEvents rbGaramond As CheckBox
    Friend WithEvents rbMagneto As CheckBox
    Friend WithEvents rbTahoma As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rbGreen As CheckBox
End Class
