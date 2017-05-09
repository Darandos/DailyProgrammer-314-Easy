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
		Me.Input = New System.Windows.Forms.TextBox()
		Me.SubmitButton = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Input
		'
		Me.Input.Location = New System.Drawing.Point(13, 13)
		Me.Input.Name = "Input"
		Me.Input.Size = New System.Drawing.Size(259, 20)
		Me.Input.TabIndex = 0
		'
		'SubmitButton
		'
		Me.SubmitButton.Location = New System.Drawing.Point(197, 39)
		Me.SubmitButton.Name = "SubmitButton"
		Me.SubmitButton.Size = New System.Drawing.Size(75, 23)
		Me.SubmitButton.TabIndex = 1
		Me.SubmitButton.Text = "Calculate"
		Me.SubmitButton.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 76)
		Me.Controls.Add(Me.SubmitButton)
		Me.Controls.Add(Me.Input)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Input As TextBox
	Friend WithEvents SubmitButton As Button
End Class
