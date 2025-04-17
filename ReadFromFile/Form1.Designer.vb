<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSelectFile = New System.Windows.Forms.Button()
        Me.lvFile = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'btnSelectFile
        '
        Me.btnSelectFile.Location = New System.Drawing.Point(46, 29)
        Me.btnSelectFile.Name = "btnSelectFile"
        Me.btnSelectFile.Size = New System.Drawing.Size(196, 35)
        Me.btnSelectFile.TabIndex = 0
        Me.btnSelectFile.Text = "Select File"
        Me.btnSelectFile.UseVisualStyleBackColor = True
        '
        'lvFile
        '
        Me.lvFile.HideSelection = False
        Me.lvFile.Location = New System.Drawing.Point(45, 89)
        Me.lvFile.Name = "lvFile"
        Me.lvFile.Size = New System.Drawing.Size(446, 276)
        Me.lvFile.TabIndex = 1
        Me.lvFile.UseCompatibleStateImageBehavior = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lvFile)
        Me.Controls.Add(Me.btnSelectFile)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSelectFile As Windows.Forms.Button
    Friend WithEvents lvFile As Windows.Forms.ListView
End Class
