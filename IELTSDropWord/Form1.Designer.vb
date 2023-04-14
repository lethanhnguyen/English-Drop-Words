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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDrop = New System.Windows.Forms.Button()
        Me.cbDropCapitalWords = New System.Windows.Forms.CheckBox()
        Me.cbDrop2Words = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numDropRatio = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOriginalText = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnPreprocessing = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDroppedText = New System.Windows.Forms.RichTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.numDropRatio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnDrop)
        Me.Panel1.Controls.Add(Me.cbDropCapitalWords)
        Me.Panel1.Controls.Add(Me.cbDrop2Words)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.numDropRatio)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(962, 103)
        Me.Panel1.TabIndex = 0
        '
        'btnDrop
        '
        Me.btnDrop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrop.Location = New System.Drawing.Point(870, 14)
        Me.btnDrop.Name = "btnDrop"
        Me.btnDrop.Size = New System.Drawing.Size(75, 73)
        Me.btnDrop.TabIndex = 5
        Me.btnDrop.Text = "Drop"
        Me.btnDrop.UseVisualStyleBackColor = True
        '
        'cbDropCapitalWords
        '
        Me.cbDropCapitalWords.AutoSize = True
        Me.cbDropCapitalWords.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDropCapitalWords.Location = New System.Drawing.Point(16, 70)
        Me.cbDropCapitalWords.Name = "cbDropCapitalWords"
        Me.cbDropCapitalWords.Size = New System.Drawing.Size(166, 20)
        Me.cbDropCapitalWords.TabIndex = 4
        Me.cbDropCapitalWords.Text = "Drop Capitalized words"
        Me.cbDropCapitalWords.UseVisualStyleBackColor = True
        '
        'cbDrop2Words
        '
        Me.cbDrop2Words.AutoSize = True
        Me.cbDrop2Words.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDrop2Words.Location = New System.Drawing.Point(16, 47)
        Me.cbDrop2Words.Name = "cbDrop2Words"
        Me.cbDrop2Words.Size = New System.Drawing.Size(235, 20)
        Me.cbDrop2Words.TabIndex = 3
        Me.cbDrop2Words.Text = "Drop more than 2 continuous words"
        Me.cbDrop2Words.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(177, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "%"
        '
        'numDropRatio
        '
        Me.numDropRatio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numDropRatio.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numDropRatio.Location = New System.Drawing.Point(114, 14)
        Me.numDropRatio.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numDropRatio.Name = "numDropRatio"
        Me.numDropRatio.Size = New System.Drawing.Size(57, 22)
        Me.numDropRatio.TabIndex = 1
        Me.numDropRatio.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Drop ratio"
        '
        'txtOriginalText
        '
        Me.txtOriginalText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOriginalText.Location = New System.Drawing.Point(10, 155)
        Me.txtOriginalText.Name = "txtOriginalText"
        Me.txtOriginalText.Size = New System.Drawing.Size(469, 398)
        Me.txtOriginalText.TabIndex = 1
        Me.txtOriginalText.Text = ""
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnPreprocessing)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(10, 127)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(469, 30)
        Me.Panel2.TabIndex = 2
        '
        'btnPreprocessing
        '
        Me.btnPreprocessing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreprocessing.Location = New System.Drawing.Point(371, 3)
        Me.btnPreprocessing.Name = "btnPreprocessing"
        Me.btnPreprocessing.Size = New System.Drawing.Size(93, 23)
        Me.btnPreprocessing.TabIndex = 1
        Me.btnPreprocessing.Text = "Preprocessing"
        Me.btnPreprocessing.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(187, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Original Text"
        '
        'txtDroppedText
        '
        Me.txtDroppedText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDroppedText.Location = New System.Drawing.Point(501, 155)
        Me.txtDroppedText.Name = "txtDroppedText"
        Me.txtDroppedText.Size = New System.Drawing.Size(469, 398)
        Me.txtDroppedText.TabIndex = 3
        Me.txtDroppedText.Text = ""
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(501, 127)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(469, 30)
        Me.Panel3.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(371, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Copy"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(187, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Dropped Text"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(982, 565)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txtDroppedText)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtOriginalText)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IELTS Drop Words"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.numDropRatio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents numDropRatio As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents cbDrop2Words As CheckBox
    Friend WithEvents cbDropCapitalWords As CheckBox
    Friend WithEvents btnDrop As Button
    Friend WithEvents txtOriginalText As RichTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDroppedText As RichTextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnPreprocessing As Button
    Friend WithEvents Button1 As Button
End Class
