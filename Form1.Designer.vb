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
        Me.btnMultiples = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMultiples
        '
        Me.btnMultiples.Location = New System.Drawing.Point(0, 0)
        Me.btnMultiples.Name = "btnMultiples"
        Me.btnMultiples.Size = New System.Drawing.Size(281, 23)
        Me.btnMultiples.TabIndex = 0
        Me.btnMultiples.Text = "Find Multiples of 3 and 5"
        Me.btnMultiples.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 26)
        Me.Controls.Add(Me.btnMultiples)
        Me.Name = "Form1"
        Me.Text = "Euler1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMultiples As System.Windows.Forms.Button

End Class
