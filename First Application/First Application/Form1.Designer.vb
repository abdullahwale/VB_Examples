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
        Me.btOne = New System.Windows.Forms.Button()
        Me.tbOne = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btOne
        '
        Me.btOne.Location = New System.Drawing.Point(326, 231)
        Me.btOne.Name = "btOne"
        Me.btOne.Size = New System.Drawing.Size(338, 127)
        Me.btOne.TabIndex = 0
        Me.btOne.Text = "Button1"
        Me.btOne.UseVisualStyleBackColor = True
        '
        'tbOne
        '
        Me.tbOne.Location = New System.Drawing.Point(280, 110)
        Me.tbOne.Name = "tbOne"
        Me.tbOne.Size = New System.Drawing.Size(372, 20)
        Me.tbOne.TabIndex = 1
        Me.tbOne.Text = "Default Value"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 516)
        Me.Controls.Add(Me.tbOne)
        Me.Controls.Add(Me.btOne)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btOne As System.Windows.Forms.Button
    Friend WithEvents tbOne As System.Windows.Forms.TextBox

End Class
