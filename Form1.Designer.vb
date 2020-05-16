<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.txtPagina = New System.Windows.Forms.TextBox()
        Me.cmdDownload = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(12, 450)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(690, 20)
        Me.txtURL.TabIndex = 0
        '
        'txtPagina
        '
        Me.txtPagina.Location = New System.Drawing.Point(12, 12)
        Me.txtPagina.Multiline = True
        Me.txtPagina.Name = "txtPagina"
        Me.txtPagina.Size = New System.Drawing.Size(776, 432)
        Me.txtPagina.TabIndex = 0
        '
        'cmdDownload
        '
        Me.cmdDownload.Location = New System.Drawing.Point(708, 448)
        Me.cmdDownload.Name = "cmdDownload"
        Me.cmdDownload.Size = New System.Drawing.Size(80, 23)
        Me.cmdDownload.TabIndex = 1
        Me.cmdDownload.Text = "Button1"
        Me.cmdDownload.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 482)
        Me.Controls.Add(Me.cmdDownload)
        Me.Controls.Add(Me.txtPagina)
        Me.Controls.Add(Me.txtURL)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtURL As TextBox
    Friend WithEvents txtPagina As TextBox
    Friend WithEvents cmdDownload As Button
End Class
