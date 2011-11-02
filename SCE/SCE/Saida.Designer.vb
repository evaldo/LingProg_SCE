<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaida
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
        Me.txtQuantidadeMovimentada = New System.Windows.Forms.TextBox
        Me.txtDataMovimentacao = New System.Windows.Forms.TextBox
        Me.txtMatricula = New System.Windows.Forms.TextBox
        Me.txtCodigoFornecedor = New System.Windows.Forms.TextBox
        Me.txtCodigoProduto = New System.Windows.Forms.TextBox
        Me.lblQuantidadeMovimentada = New System.Windows.Forms.Label
        Me.lblDataMovimentacao = New System.Windows.Forms.Label
        Me.lblMatricula = New System.Windows.Forms.Label
        Me.lblCodigoFornecedor = New System.Windows.Forms.Label
        Me.lblCodigoProduto = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalvarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExcluirCadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlterarCadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultarCadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SairToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.grdCliente = New System.Windows.Forms.DataGridView
        Me.colCod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEndereco = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colBairro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colContato = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnLimpar = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        CType(Me.grdCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtQuantidadeMovimentada
        '
        Me.txtQuantidadeMovimentada.Location = New System.Drawing.Point(148, 135)
        Me.txtQuantidadeMovimentada.Name = "txtQuantidadeMovimentada"
        Me.txtQuantidadeMovimentada.Size = New System.Drawing.Size(91, 20)
        Me.txtQuantidadeMovimentada.TabIndex = 44
        '
        'txtDataMovimentacao
        '
        Me.txtDataMovimentacao.Location = New System.Drawing.Point(423, 88)
        Me.txtDataMovimentacao.Name = "txtDataMovimentacao"
        Me.txtDataMovimentacao.Size = New System.Drawing.Size(125, 20)
        Me.txtDataMovimentacao.TabIndex = 43
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(97, 88)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(119, 20)
        Me.txtMatricula.TabIndex = 42
        '
        'txtCodigoFornecedor
        '
        Me.txtCodigoFornecedor.Location = New System.Drawing.Point(423, 47)
        Me.txtCodigoFornecedor.Name = "txtCodigoFornecedor"
        Me.txtCodigoFornecedor.Size = New System.Drawing.Size(109, 20)
        Me.txtCodigoFornecedor.TabIndex = 41
        '
        'txtCodigoProduto
        '
        Me.txtCodigoProduto.Location = New System.Drawing.Point(117, 47)
        Me.txtCodigoProduto.Name = "txtCodigoProduto"
        Me.txtCodigoProduto.Size = New System.Drawing.Size(109, 20)
        Me.txtCodigoProduto.TabIndex = 40
        '
        'lblQuantidadeMovimentada
        '
        Me.lblQuantidadeMovimentada.AutoSize = True
        Me.lblQuantidadeMovimentada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblQuantidadeMovimentada.Location = New System.Drawing.Point(33, 138)
        Me.lblQuantidadeMovimentada.Name = "lblQuantidadeMovimentada"
        Me.lblQuantidadeMovimentada.Size = New System.Drawing.Size(109, 13)
        Me.lblQuantidadeMovimentada.TabIndex = 38
        Me.lblQuantidadeMovimentada.Text = "Quant. Movimentada:"
        '
        'lblDataMovimentacao
        '
        Me.lblDataMovimentacao.AutoSize = True
        Me.lblDataMovimentacao.Location = New System.Drawing.Point(296, 95)
        Me.lblDataMovimentacao.Name = "lblDataMovimentacao"
        Me.lblDataMovimentacao.Size = New System.Drawing.Size(121, 13)
        Me.lblDataMovimentacao.TabIndex = 37
        Me.lblDataMovimentacao.Text = "Data da Movimentação:"
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Location = New System.Drawing.Point(33, 95)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(53, 13)
        Me.lblMatricula.TabIndex = 36
        Me.lblMatricula.Text = "Matricula:"
        '
        'lblCodigoFornecedor
        '
        Me.lblCodigoFornecedor.AutoSize = True
        Me.lblCodigoFornecedor.Location = New System.Drawing.Point(326, 54)
        Me.lblCodigoFornecedor.Name = "lblCodigoFornecedor"
        Me.lblCodigoFornecedor.Size = New System.Drawing.Size(89, 13)
        Me.lblCodigoFornecedor.TabIndex = 35
        Me.lblCodigoFornecedor.Text = "Cód. Fornecedor:"
        '
        'lblCodigoProduto
        '
        Me.lblCodigoProduto.AutoSize = True
        Me.lblCodigoProduto.Location = New System.Drawing.Point(33, 54)
        Me.lblCodigoProduto.Name = "lblCodigoProduto"
        Me.lblCodigoProduto.Size = New System.Drawing.Size(72, 13)
        Me.lblCodigoProduto.TabIndex = 34
        Me.lblCodigoProduto.Text = "Cód. Produto:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.SairToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(697, 24)
        Me.MenuStrip1.TabIndex = 46
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalvarToolStripMenuItem, Me.ExcluirCadastroToolStripMenuItem, Me.AlterarCadastroToolStripMenuItem, Me.ConsultarCadastroToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "Arquivo"
        '
        'SalvarToolStripMenuItem
        '
        Me.SalvarToolStripMenuItem.Name = "SalvarToolStripMenuItem"
        Me.SalvarToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.SalvarToolStripMenuItem.Text = "&Novo Cadastro"
        '
        'ExcluirCadastroToolStripMenuItem
        '
        Me.ExcluirCadastroToolStripMenuItem.Name = "ExcluirCadastroToolStripMenuItem"
        Me.ExcluirCadastroToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ExcluirCadastroToolStripMenuItem.Text = "&Excluir Cadastro"
        '
        'AlterarCadastroToolStripMenuItem
        '
        Me.AlterarCadastroToolStripMenuItem.Name = "AlterarCadastroToolStripMenuItem"
        Me.AlterarCadastroToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.AlterarCadastroToolStripMenuItem.Text = "&Alterar Cadastro"
        '
        'ConsultarCadastroToolStripMenuItem
        '
        Me.ConsultarCadastroToolStripMenuItem.Name = "ConsultarCadastroToolStripMenuItem"
        Me.ConsultarCadastroToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ConsultarCadastroToolStripMenuItem.Text = "&Consultar Cadastro"
        '
        'SairToolStripMenuItem1
        '
        Me.SairToolStripMenuItem1.Name = "SairToolStripMenuItem1"
        Me.SairToolStripMenuItem1.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem1.Text = "Sair"
        '
        'grdCliente
        '
        Me.grdCliente.AllowUserToAddRows = False
        Me.grdCliente.AllowUserToDeleteRows = False
        Me.grdCliente.AllowUserToResizeColumns = False
        Me.grdCliente.AllowUserToResizeRows = False
        Me.grdCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCod, Me.colFornecedor, Me.colEndereco, Me.colBairro, Me.colContato})
        Me.grdCliente.Location = New System.Drawing.Point(14, 206)
        Me.grdCliente.Name = "grdCliente"
        Me.grdCliente.Size = New System.Drawing.Size(671, 267)
        Me.grdCliente.TabIndex = 61
        '
        'colCod
        '
        Me.colCod.HeaderText = "Codigo"
        Me.colCod.Name = "colCod"
        '
        'colFornecedor
        '
        Me.colFornecedor.HeaderText = "Fornecedor"
        Me.colFornecedor.Name = "colFornecedor"
        Me.colFornecedor.Width = 300
        '
        'colEndereco
        '
        Me.colEndereco.HeaderText = "Endereco"
        Me.colEndereco.Name = "colEndereco"
        Me.colEndereco.Width = 200
        '
        'colBairro
        '
        Me.colBairro.HeaderText = "Bairro"
        Me.colBairro.Name = "colBairro"
        Me.colBairro.Width = 150
        '
        'colContato
        '
        Me.colContato.HeaderText = "Contato"
        Me.colContato.Name = "colContato"
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(483, 177)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(105, 23)
        Me.btnLimpar.TabIndex = 60
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(594, 177)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(88, 23)
        Me.btnSair.TabIndex = 59
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(257, 177)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(98, 23)
        Me.btnAlterar.TabIndex = 58
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(137, 177)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(97, 23)
        Me.btnExcluir.TabIndex = 57
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(19, 177)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(101, 23)
        Me.btnSalvar.TabIndex = 56
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(372, 177)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(105, 23)
        Me.btnConsultar.TabIndex = 55
        Me.btnConsultar.Text = "Consultar Clientes"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'frmSaida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 511)
        Me.Controls.Add(Me.grdCliente)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.txtQuantidadeMovimentada)
        Me.Controls.Add(Me.txtDataMovimentacao)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.txtCodigoFornecedor)
        Me.Controls.Add(Me.txtCodigoProduto)
        Me.Controls.Add(Me.lblQuantidadeMovimentada)
        Me.Controls.Add(Me.lblDataMovimentacao)
        Me.Controls.Add(Me.lblMatricula)
        Me.Controls.Add(Me.lblCodigoFornecedor)
        Me.Controls.Add(Me.lblCodigoProduto)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmSaida"
        Me.Text = "Movimentação de Saída"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.grdCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtQuantidadeMovimentada As System.Windows.Forms.TextBox
    Friend WithEvents txtDataMovimentacao As System.Windows.Forms.TextBox
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoFornecedor As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoProduto As System.Windows.Forms.TextBox
    Friend WithEvents lblQuantidadeMovimentada As System.Windows.Forms.Label
    Friend WithEvents lblDataMovimentacao As System.Windows.Forms.Label
    Friend WithEvents lblMatricula As System.Windows.Forms.Label
    Friend WithEvents lblCodigoFornecedor As System.Windows.Forms.Label
    Friend WithEvents lblCodigoProduto As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalvarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcluirCadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlterarCadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarCadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grdCliente As System.Windows.Forms.DataGridView
    Friend WithEvents colCod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFornecedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEndereco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBairro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colContato As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
End Class
