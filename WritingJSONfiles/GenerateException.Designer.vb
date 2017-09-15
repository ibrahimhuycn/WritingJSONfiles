<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerateException
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
        Me.btnGenerateEx = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGenerateEx
        '
        Me.btnGenerateEx.Location = New System.Drawing.Point(21, 33)
        Me.btnGenerateEx.Name = "btnGenerateEx"
        Me.btnGenerateEx.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerateEx.TabIndex = 0
        Me.btnGenerateEx.Text = "GenerateEx"
        Me.btnGenerateEx.UseVisualStyleBackColor = True
        '
        'GenerateException
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 125)
        Me.Controls.Add(Me.btnGenerateEx)
        Me.Name = "GenerateException"
        Me.Text = "GenerateException"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGenerateEx As Button
End Class
