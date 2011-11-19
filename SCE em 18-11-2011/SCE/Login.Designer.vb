<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnOk = New System.Windows.Forms.Button
        Me.txtSenha = New System.Windows.Forms.TextBox
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.lblSenha = New System.Windows.Forms.Label
        Me.lblUsuario = New System.Windows.Forms.Label
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncancelar
        '
        Me.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancelar.Location = New System.Drawing.Point(294, 150)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(94, 23)
        Me.btncancelar.TabIndex = 4
        Me.btncancelar.Text = "&Cancelar"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(191, 150)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(94, 23)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "&OK"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(168, 90)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(220, 20)
        Me.txtSenha.TabIndex = 2
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(168, 33)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(220, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'lblSenha
        '
        Me.lblSenha.Location = New System.Drawing.Point(166, 70)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(220, 23)
        Me.lblSenha.TabIndex = 9
        Me.lblSenha.Text = "&Password"
        Me.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUsuario
        '
        Me.lblUsuario.Location = New System.Drawing.Point(166, 13)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(220, 23)
        Me.lblUsuario.TabIndex = 6
        Me.lblUsuario.Text = "&User name"
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(-1, -1)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(160, 183)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 7
        Me.LogoPictureBox.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 182)
        Me.ControlBox = False
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblSenha As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
End Class
