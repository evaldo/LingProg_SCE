<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fmr_Mov_saida
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
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.lblFornecedor = New System.Windows.Forms.Label
        Me.lblNfiscal = New System.Windows.Forms.Label
        Me.lbl_DTmov = New System.Windows.Forms.Label
        Me.lblQTMov = New System.Windows.Forms.Label
        Me.txtCodigo_P = New System.Windows.Forms.TextBox
        Me.txtCodigo_F = New System.Windows.Forms.TextBox
        Me.txtnf = New System.Windows.Forms.TextBox
        Me.txtDTmov = New System.Windows.Forms.TextBox
        Me.txtQTmov = New System.Windows.Forms.TextBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.lblConsulta = New System.Windows.Forms.Label
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.btnConsulta = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(12, 9)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(97, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Codigo do produto:"
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Location = New System.Drawing.Point(171, 9)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(115, 13)
        Me.lblFornecedor.TabIndex = 2
        Me.lblFornecedor.Text = "Código do Fornecedor:"
        '
        'lblNfiscal
        '
        Me.lblNfiscal.AutoSize = True
        Me.lblNfiscal.Location = New System.Drawing.Point(12, 47)
        Me.lblNfiscal.Name = "lblNfiscal"
        Me.lblNfiscal.Size = New System.Drawing.Size(114, 13)
        Me.lblNfiscal.TabIndex = 3
        Me.lblNfiscal.Text = "Nota fiscal do produto:"
        '
        'lbl_DTmov
        '
        Me.lbl_DTmov.AutoSize = True
        Me.lbl_DTmov.Location = New System.Drawing.Point(12, 86)
        Me.lbl_DTmov.Name = "lbl_DTmov"
        Me.lbl_DTmov.Size = New System.Drawing.Size(128, 13)
        Me.lbl_DTmov.TabIndex = 4
        Me.lbl_DTmov.Text = "Data atual do movimento:"
        '
        'lblQTMov
        '
        Me.lblQTMov.AutoSize = True
        Me.lblQTMov.Location = New System.Drawing.Point(292, 86)
        Me.lblQTMov.Name = "lblQTMov"
        Me.lblQTMov.Size = New System.Drawing.Size(102, 13)
        Me.lblQTMov.TabIndex = 5
        Me.lblQTMov.Text = "Quantidade movido:"
        '
        'txtCodigo_P
        '
        Me.txtCodigo_P.Location = New System.Drawing.Point(115, 9)
        Me.txtCodigo_P.Name = "txtCodigo_P"
        Me.txtCodigo_P.Size = New System.Drawing.Size(41, 20)
        Me.txtCodigo_P.TabIndex = 6
        '
        'txtCodigo_F
        '
        Me.txtCodigo_F.Location = New System.Drawing.Point(292, 6)
        Me.txtCodigo_F.Name = "txtCodigo_F"
        Me.txtCodigo_F.Size = New System.Drawing.Size(41, 20)
        Me.txtCodigo_F.TabIndex = 7
        '
        'txtnf
        '
        Me.txtnf.Location = New System.Drawing.Point(132, 40)
        Me.txtnf.Name = "txtnf"
        Me.txtnf.Size = New System.Drawing.Size(100, 20)
        Me.txtnf.TabIndex = 8
        '
        'txtDTmov
        '
        Me.txtDTmov.Location = New System.Drawing.Point(146, 83)
        Me.txtDTmov.Name = "txtDTmov"
        Me.txtDTmov.Size = New System.Drawing.Size(140, 20)
        Me.txtDTmov.TabIndex = 9
        '
        'txtQTmov
        '
        Me.txtQTmov.Location = New System.Drawing.Point(400, 83)
        Me.txtQTmov.Name = "txtQTmov"
        Me.txtQTmov.Size = New System.Drawing.Size(140, 20)
        Me.txtQTmov.TabIndex = 10
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(19, 189)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(135, 17)
        Me.RadioButton1.TabIndex = 11
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Pelo código do produto"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'lblConsulta
        '
        Me.lblConsulta.AutoSize = True
        Me.lblConsulta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsulta.Location = New System.Drawing.Point(11, 158)
        Me.lblConsulta.Name = "lblConsulta"
        Me.lblConsulta.Size = New System.Drawing.Size(365, 19)
        Me.lblConsulta.TabIndex = 12
        Me.lblConsulta.Text = "Consultar movimentação de saída de produtos"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(19, 212)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(178, 17)
        Me.RadioButton2.TabIndex = 13
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Pela a data de saída do produto"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'btnConsulta
        '
        Me.btnConsulta.Location = New System.Drawing.Point(197, 229)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(75, 23)
        Me.btnConsulta.TabIndex = 14
        Me.btnConsulta.Text = "Consultar"
        Me.btnConsulta.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(359, 229)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 15
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(278, 229)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 16
        Me.btnImprimir.Text = "Imprimir relatório"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'Fmr_Mov_saida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 256)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.lblConsulta)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.txtQTmov)
        Me.Controls.Add(Me.txtDTmov)
        Me.Controls.Add(Me.txtnf)
        Me.Controls.Add(Me.txtCodigo_F)
        Me.Controls.Add(Me.txtCodigo_P)
        Me.Controls.Add(Me.lblQTMov)
        Me.Controls.Add(Me.lbl_DTmov)
        Me.Controls.Add(Me.lblNfiscal)
        Me.Controls.Add(Me.lblFornecedor)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "Fmr_Mov_saida"
        Me.Text = "Saída de mercadorias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Friend WithEvents lblNfiscal As System.Windows.Forms.Label
    Friend WithEvents lbl_DTmov As System.Windows.Forms.Label
    Friend WithEvents lblQTMov As System.Windows.Forms.Label
    Friend WithEvents txtCodigo_P As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo_F As System.Windows.Forms.TextBox
    Friend WithEvents txtnf As System.Windows.Forms.TextBox
    Friend WithEvents txtDTmov As System.Windows.Forms.TextBox
    Friend WithEvents txtQTmov As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblConsulta As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents btnConsulta As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
End Class
