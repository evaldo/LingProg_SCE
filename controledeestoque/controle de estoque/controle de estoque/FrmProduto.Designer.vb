<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProduto
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
        Me.lblNome = New System.Windows.Forms.Label
        Me.lblCusto = New System.Windows.Forms.Label
        Me.lblVenda = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.txtNome = New System.Windows.Forms.TextBox
        Me.txtCusto = New System.Windows.Forms.TextBox
        Me.txtVenda = New System.Windows.Forms.TextBox
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.lblMaxima = New System.Windows.Forms.Label
        Me.txtMaxima = New System.Windows.Forms.TextBox
        Me.lblMinimo = New System.Windows.Forms.Label
        Me.txtMinimo = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(12, 9)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código:"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(9, 47)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(92, 13)
        Me.lblNome.TabIndex = 1
        Me.lblNome.Text = "Nome do produto:"
        '
        'lblCusto
        '
        Me.lblCusto.AutoSize = True
        Me.lblCusto.Location = New System.Drawing.Point(9, 84)
        Me.lblCusto.Name = "lblCusto"
        Me.lblCusto.Size = New System.Drawing.Size(78, 13)
        Me.lblCusto.TabIndex = 2
        Me.lblCusto.Text = "Valor do custo:"
        '
        'lblVenda
        '
        Me.lblVenda.AutoSize = True
        Me.lblVenda.Location = New System.Drawing.Point(224, 84)
        Me.lblVenda.Name = "lblVenda"
        Me.lblVenda.Size = New System.Drawing.Size(82, 13)
        Me.lblVenda.TabIndex = 3
        Me.lblVenda.Text = "Valor de venda:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(61, 9)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(44, 20)
        Me.txtCodigo.TabIndex = 4
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(107, 44)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(112, 20)
        Me.txtNome.TabIndex = 5
        '
        'txtCusto
        '
        Me.txtCusto.Location = New System.Drawing.Point(91, 81)
        Me.txtCusto.Name = "txtCusto"
        Me.txtCusto.Size = New System.Drawing.Size(114, 20)
        Me.txtCusto.TabIndex = 6
        '
        'txtVenda
        '
        Me.txtVenda.Location = New System.Drawing.Point(312, 81)
        Me.txtVenda.Name = "txtVenda"
        Me.txtVenda.Size = New System.Drawing.Size(114, 20)
        Me.txtVenda.TabIndex = 7
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(12, 199)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 8
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(91, 199)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 9
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(172, 199)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(75, 23)
        Me.btnAlterar.TabIndex = 10
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(253, 199)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 11
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(334, 199)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 12
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'lblMaxima
        '
        Me.lblMaxima.AutoSize = True
        Me.lblMaxima.Location = New System.Drawing.Point(12, 115)
        Me.lblMaxima.Name = "lblMaxima"
        Me.lblMaxima.Size = New System.Drawing.Size(159, 13)
        Me.lblMaxima.TabIndex = 13
        Me.lblMaxima.Text = "Quantidade máxima no estoque:"
        '
        'txtMaxima
        '
        Me.txtMaxima.Location = New System.Drawing.Point(177, 115)
        Me.txtMaxima.Name = "txtMaxima"
        Me.txtMaxima.Size = New System.Drawing.Size(104, 20)
        Me.txtMaxima.TabIndex = 14
        '
        'lblMinimo
        '
        Me.lblMinimo.AutoSize = True
        Me.lblMinimo.Location = New System.Drawing.Point(9, 158)
        Me.lblMinimo.Name = "lblMinimo"
        Me.lblMinimo.Size = New System.Drawing.Size(156, 13)
        Me.lblMinimo.TabIndex = 15
        Me.lblMinimo.Text = "Quantidade minimo no estoque:"
        '
        'txtMinimo
        '
        Me.txtMinimo.Location = New System.Drawing.Point(171, 155)
        Me.txtMinimo.Name = "txtMinimo"
        Me.txtMinimo.Size = New System.Drawing.Size(106, 20)
        Me.txtMinimo.TabIndex = 16
        '
        'FrmProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 231)
        Me.Controls.Add(Me.txtMinimo)
        Me.Controls.Add(Me.lblMinimo)
        Me.Controls.Add(Me.txtMaxima)
        Me.Controls.Add(Me.lblMaxima)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.txtVenda)
        Me.Controls.Add(Me.txtCusto)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblVenda)
        Me.Controls.Add(Me.lblCusto)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "FrmProduto"
        Me.Text = "FrmProduto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents lblCusto As System.Windows.Forms.Label
    Friend WithEvents lblVenda As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtCusto As System.Windows.Forms.TextBox
    Friend WithEvents txtVenda As System.Windows.Forms.TextBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents lblMaxima As System.Windows.Forms.Label
    Friend WithEvents txtMaxima As System.Windows.Forms.TextBox
    Friend WithEvents lblMinimo As System.Windows.Forms.Label
    Friend WithEvents txtMinimo As System.Windows.Forms.TextBox
End Class
