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
        Me.ResultTextBox = New System.Windows.Forms.TextBox()
        Me.ExpressionTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_convert = New System.Windows.Forms.Button()
        Me.Button_close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ResultTextBox
        '
        Me.ResultTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.ResultTextBox.Location = New System.Drawing.Point(12, 153)
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.PlaceholderText = "Output..."
        Me.ResultTextBox.ReadOnly = True
        Me.ResultTextBox.Size = New System.Drawing.Size(776, 31)
        Me.ResultTextBox.TabIndex = 17
        '
        'ExpressionTextBox
        '
        Me.ExpressionTextBox.Location = New System.Drawing.Point(12, 97)
        Me.ExpressionTextBox.Name = "ExpressionTextBox"
        Me.ExpressionTextBox.PlaceholderText = "Put your infix here..."
        Me.ExpressionTextBox.Size = New System.Drawing.Size(776, 31)
        Me.ExpressionTextBox.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calisto MT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(195, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(399, 41)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Infix to Postfix converter"
        '
        'Button_convert
        '
        Me.Button_convert.BackColor = System.Drawing.Color.PaleGreen
        Me.Button_convert.Location = New System.Drawing.Point(210, 233)
        Me.Button_convert.Name = "Button_convert"
        Me.Button_convert.Size = New System.Drawing.Size(177, 65)
        Me.Button_convert.TabIndex = 26
        Me.Button_convert.Text = "Convert"
        Me.Button_convert.UseVisualStyleBackColor = False
        '
        'Button_close
        '
        Me.Button_close.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button_close.Location = New System.Drawing.Point(393, 233)
        Me.Button_close.Name = "Button_close"
        Me.Button_close.Size = New System.Drawing.Size(177, 65)
        Me.Button_close.TabIndex = 27
        Me.Button_close.Text = "Close"
        Me.Button_close.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button_close)
        Me.Controls.Add(Me.Button_convert)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ResultTextBox)
        Me.Controls.Add(Me.ExpressionTextBox)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ResultTextBox As TextBox
    Friend WithEvents ExpressionTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_convert As Button
    Friend WithEvents Button_close As Button
End Class
