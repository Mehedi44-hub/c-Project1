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
        Me.LabelHelloWorld = New System.Windows.Forms.Label()
        Me.ButtonHelloWorld = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelHelloWorld
        '
        Me.LabelHelloWorld.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelHelloWorld.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHelloWorld.Location = New System.Drawing.Point(304, 136)
        Me.LabelHelloWorld.Name = "LabelHelloWorld"
        Me.LabelHelloWorld.Size = New System.Drawing.Size(174, 56)
        Me.LabelHelloWorld.TabIndex = 0
        '
        'ButtonHelloWorld
        '
        Me.ButtonHelloWorld.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHelloWorld.Location = New System.Drawing.Point(304, 242)
        Me.ButtonHelloWorld.Name = "ButtonHelloWorld"
        Me.ButtonHelloWorld.Size = New System.Drawing.Size(174, 41)
        Me.ButtonHelloWorld.TabIndex = 1
        Me.ButtonHelloWorld.Text = "Display"
        Me.ButtonHelloWorld.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonHelloWorld)
        Me.Controls.Add(Me.LabelHelloWorld)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelHelloWorld As Label
    Friend WithEvents ButtonHelloWorld As Button
End Class
