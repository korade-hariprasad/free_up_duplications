<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.tbPath = New System.Windows.Forms.TextBox()
        Me.Search = New System.Windows.Forms.Button()
        Me.tbxten = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tbPath
        '
        Me.tbPath.Location = New System.Drawing.Point(12, 22)
        Me.tbPath.Name = "tbPath"
        Me.tbPath.Size = New System.Drawing.Size(311, 20)
        Me.tbPath.TabIndex = 0
        Me.tbPath.Text = "drive path here"
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(166, 69)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(109, 23)
        Me.Search.TabIndex = 2
        Me.Search.Text = "Delete   Copies"
        Me.Search.UseVisualStyleBackColor = True
        '
        'tbxten
        '
        Me.tbxten.Location = New System.Drawing.Point(329, 22)
        Me.tbxten.Name = "tbxten"
        Me.tbxten.Size = New System.Drawing.Size(84, 20)
        Me.tbxten.TabIndex = 3
        Me.tbxten.Text = "extension here"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 111)
        Me.Controls.Add(Me.tbxten)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.tbPath)
        Me.Name = "main"
        Me.Text = "Free-up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbPath As TextBox
    Friend WithEvents Search As Button
    Friend WithEvents tbxten As TextBox
End Class
