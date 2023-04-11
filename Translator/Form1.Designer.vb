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
        Me.radMother = New System.Windows.Forms.RadioButton()
        Me.radFather = New System.Windows.Forms.RadioButton()
        Me.radSister = New System.Windows.Forms.RadioButton()
        Me.radBrother = New System.Windows.Forms.RadioButton()
        Me.cbl = New System.Windows.Forms.ComboBox()
        Me.btntranslate = New System.Windows.Forms.Button()
        Me.btnext = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'radMother
        '
        Me.radMother.AutoSize = True
        Me.radMother.Location = New System.Drawing.Point(12, 28)
        Me.radMother.Name = "radMother"
        Me.radMother.Size = New System.Drawing.Size(69, 20)
        Me.radMother.TabIndex = 0
        Me.radMother.TabStop = True
        Me.radMother.Text = "&Mother"
        Me.radMother.UseVisualStyleBackColor = True
        '
        'radFather
        '
        Me.radFather.AutoSize = True
        Me.radFather.Location = New System.Drawing.Point(12, 54)
        Me.radFather.Name = "radFather"
        Me.radFather.Size = New System.Drawing.Size(66, 20)
        Me.radFather.TabIndex = 1
        Me.radFather.TabStop = True
        Me.radFather.Text = "&Father"
        Me.radFather.UseVisualStyleBackColor = True
        '
        'radSister
        '
        Me.radSister.AutoSize = True
        Me.radSister.Location = New System.Drawing.Point(12, 80)
        Me.radSister.Name = "radSister"
        Me.radSister.Size = New System.Drawing.Size(62, 20)
        Me.radSister.TabIndex = 2
        Me.radSister.TabStop = True
        Me.radSister.Text = "&Sister"
        Me.radSister.UseVisualStyleBackColor = True
        '
        'radBrother
        '
        Me.radBrother.AutoSize = True
        Me.radBrother.Location = New System.Drawing.Point(12, 106)
        Me.radBrother.Name = "radBrother"
        Me.radBrother.Size = New System.Drawing.Size(71, 20)
        Me.radBrother.TabIndex = 3
        Me.radBrother.TabStop = True
        Me.radBrother.Text = "&Brother"
        Me.radBrother.UseVisualStyleBackColor = True
        '
        'cbl
        '
        Me.cbl.FormattingEnabled = True
        Me.cbl.Items.AddRange(New Object() {"French", "Spanish", "Italian"})
        Me.cbl.Location = New System.Drawing.Point(149, 64)
        Me.cbl.Name = "cbl"
        Me.cbl.Size = New System.Drawing.Size(121, 24)
        Me.cbl.TabIndex = 4
        '
        'btntranslate
        '
        Me.btntranslate.Location = New System.Drawing.Point(330, 64)
        Me.btntranslate.Name = "btntranslate"
        Me.btntranslate.Size = New System.Drawing.Size(75, 23)
        Me.btntranslate.TabIndex = 6
        Me.btntranslate.Text = "&Translate"
        Me.btntranslate.UseVisualStyleBackColor = True
        '
        'btnext
        '
        Me.btnext.Location = New System.Drawing.Point(330, 104)
        Me.btnext.Name = "btnext"
        Me.btnext.Size = New System.Drawing.Size(75, 23)
        Me.btnext.TabIndex = 7
        Me.btnext.Text = "E&xit"
        Me.btnext.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(205, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 163)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnext)
        Me.Controls.Add(Me.btntranslate)
        Me.Controls.Add(Me.cbl)
        Me.Controls.Add(Me.radBrother)
        Me.Controls.Add(Me.radSister)
        Me.Controls.Add(Me.radFather)
        Me.Controls.Add(Me.radMother)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radMother As RadioButton
    Friend WithEvents radFather As RadioButton
    Friend WithEvents radSister As RadioButton
    Friend WithEvents radBrother As RadioButton
    Friend WithEvents cbl As ComboBox
    Friend WithEvents btntranslate As Button
    Friend WithEvents btnext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
