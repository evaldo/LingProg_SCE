<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntrada
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
        Me.grdGeral = New System.Windows.Forms.DataGridView
        Me.colProduto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMatricula = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDtMovimento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colQuantMov = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnLimpar = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.grdFuncionario = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Funcionario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grdFornecedor = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grdProduto = New System.Windows.Forms.DataGridView
        Me.colCod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Produto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pbxPesquisaProduto = New System.Windows.Forms.PictureBox
        Me.pbxPesquisaFuncionario = New System.Windows.Forms.PictureBox
        Me.pbxPesquisaFornecedor = New System.Windows.Forms.PictureBox
        CType(Me.grdGeral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdFuncionario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdFornecedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPesquisaProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPesquisaFuncionario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPesquisaFornecedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtQuantidadeMovimentada
        '
        Me.txtQuantidadeMovimentada.Location = New System.Drawing.Point(444, 117)
        Me.txtQuantidadeMovimentada.Name = "txtQuantidadeMovimentada"
        Me.txtQuantidadeMovimentada.Size = New System.Drawing.Size(91, 20)
        Me.txtQuantidadeMovimentada.TabIndex = 5
        '
        'txtDataMovimentacao
        '
        Me.txtDataMovimentacao.Location = New System.Drawing.Point(155, 117)
        Me.txtDataMovimentacao.Name = "txtDataMovimentacao"
        Me.txtDataMovimentacao.Size = New System.Drawing.Size(94, 20)
        Me.txtDataMovimentacao.TabIndex = 4
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(559, 48)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(73, 20)
        Me.txtMatricula.TabIndex = 3
        '
        'txtCodigoFornecedor
        '
        Me.txtCodigoFornecedor.Location = New System.Drawing.Point(351, 48)
        Me.txtCodigoFornecedor.Name = "txtCodigoFornecedor"
        Me.txtCodigoFornecedor.Size = New System.Drawing.Size(59, 20)
        Me.txtCodigoFornecedor.TabIndex = 2
        '
        'txtCodigoProduto
        '
        Me.txtCodigoProduto.Location = New System.Drawing.Point(112, 48)
        Me.txtCodigoProduto.Name = "txtCodigoProduto"
        Me.txtCodigoProduto.Size = New System.Drawing.Size(53, 20)
        Me.txtCodigoProduto.TabIndex = 1
        '
        'lblQuantidadeMovimentada
        '
        Me.lblQuantidadeMovimentada.AutoSize = True
        Me.lblQuantidadeMovimentada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblQuantidadeMovimentada.Location = New System.Drawing.Point(329, 120)
        Me.lblQuantidadeMovimentada.Name = "lblQuantidadeMovimentada"
        Me.lblQuantidadeMovimentada.Size = New System.Drawing.Size(109, 13)
        Me.lblQuantidadeMovimentada.TabIndex = 51
        Me.lblQuantidadeMovimentada.Text = "Quant. Movimentada:"
        '
        'lblDataMovimentacao
        '
        Me.lblDataMovimentacao.AutoSize = True
        Me.lblDataMovimentacao.Location = New System.Drawing.Point(28, 120)
        Me.lblDataMovimentacao.Name = "lblDataMovimentacao"
        Me.lblDataMovimentacao.Size = New System.Drawing.Size(121, 13)
        Me.lblDataMovimentacao.TabIndex = 50
        Me.lblDataMovimentacao.Text = "Data da Movimentação:"
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Location = New System.Drawing.Point(495, 55)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(53, 13)
        Me.lblMatricula.TabIndex = 49
        Me.lblMatricula.Text = "Matricula:"
        '
        'lblCodigoFornecedor
        '
        Me.lblCodigoFornecedor.AutoSize = True
        Me.lblCodigoFornecedor.Location = New System.Drawing.Point(254, 55)
        Me.lblCodigoFornecedor.Name = "lblCodigoFornecedor"
        Me.lblCodigoFornecedor.Size = New System.Drawing.Size(89, 13)
        Me.lblCodigoFornecedor.TabIndex = 48
        Me.lblCodigoFornecedor.Text = "Cód. Fornecedor:"
        '
        'lblCodigoProduto
        '
        Me.lblCodigoProduto.AutoSize = True
        Me.lblCodigoProduto.Location = New System.Drawing.Point(28, 55)
        Me.lblCodigoProduto.Name = "lblCodigoProduto"
        Me.lblCodigoProduto.Size = New System.Drawing.Size(72, 13)
        Me.lblCodigoProduto.TabIndex = 47
        Me.lblCodigoProduto.Text = "Cód. Produto:"
        '
        'grdGeral
        '
        Me.grdGeral.AllowUserToAddRows = False
        Me.grdGeral.AllowUserToDeleteRows = False
        Me.grdGeral.AllowUserToResizeColumns = False
        Me.grdGeral.AllowUserToResizeRows = False
        Me.grdGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdGeral.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colProduto, Me.colFornecedor, Me.colMatricula, Me.colDtMovimento, Me.colQuantMov})
        Me.grdGeral.Location = New System.Drawing.Point(14, 213)
        Me.grdGeral.Name = "grdGeral"
        Me.grdGeral.Size = New System.Drawing.Size(671, 253)
        Me.grdGeral.TabIndex = 12
        '
        'colProduto
        '
        Me.colProduto.HeaderText = "Produto"
        Me.colProduto.Name = "colProduto"
        '
        'colFornecedor
        '
        Me.colFornecedor.HeaderText = "Fornecedor"
        Me.colFornecedor.Name = "colFornecedor"
        Me.colFornecedor.Width = 300
        '
        'colMatricula
        '
        Me.colMatricula.HeaderText = "Matricula"
        Me.colMatricula.Name = "colMatricula"
        '
        'colDtMovimento
        '
        Me.colDtMovimento.HeaderText = "Data do Movimento"
        Me.colDtMovimento.Name = "colDtMovimento"
        Me.colDtMovimento.Width = 200
        '
        'colQuantMov
        '
        Me.colQuantMov.HeaderText = "Quantidade do Movimento"
        Me.colQuantMov.Name = "colQuantMov"
        Me.colQuantMov.Width = 150
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(483, 184)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(105, 23)
        Me.btnLimpar.TabIndex = 10
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(594, 184)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(88, 23)
        Me.btnSair.TabIndex = 11
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(257, 184)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(98, 23)
        Me.btnAlterar.TabIndex = 8
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(137, 184)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(97, 23)
        Me.btnExcluir.TabIndex = 7
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(19, 184)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(101, 23)
        Me.btnSalvar.TabIndex = 6
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(372, 184)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(105, 23)
        Me.btnConsultar.TabIndex = 9
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'grdFuncionario
        '
        Me.grdFuncionario.AllowUserToAddRows = False
        Me.grdFuncionario.AllowUserToDeleteRows = False
        Me.grdFuncionario.AllowUserToResizeColumns = False
        Me.grdFuncionario.AllowUserToResizeRows = False
        Me.grdFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdFuncionario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.Funcionario})
        Me.grdFuncionario.Location = New System.Drawing.Point(14, 213)
        Me.grdFuncionario.Name = "grdFuncionario"
        Me.grdFuncionario.Size = New System.Drawing.Size(673, 253)
        Me.grdFuncionario.TabIndex = 57
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 65
        '
        'Funcionario
        '
        Me.Funcionario.HeaderText = "Funcionario"
        Me.Funcionario.Name = "Funcionario"
        '
        'grdFornecedor
        '
        Me.grdFornecedor.AllowUserToAddRows = False
        Me.grdFornecedor.AllowUserToDeleteRows = False
        Me.grdFornecedor.AllowUserToResizeColumns = False
        Me.grdFornecedor.AllowUserToResizeRows = False
        Me.grdFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdFornecedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Fornecedor})
        Me.grdFornecedor.Location = New System.Drawing.Point(14, 213)
        Me.grdFornecedor.Name = "grdFornecedor"
        Me.grdFornecedor.Size = New System.Drawing.Size(673, 254)
        Me.grdFornecedor.TabIndex = 58
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 65
        '
        'Fornecedor
        '
        Me.Fornecedor.HeaderText = "Fornecedor"
        Me.Fornecedor.Name = "Fornecedor"
        '
        'grdProduto
        '
        Me.grdProduto.AllowUserToAddRows = False
        Me.grdProduto.AllowUserToDeleteRows = False
        Me.grdProduto.AllowUserToResizeColumns = False
        Me.grdProduto.AllowUserToResizeRows = False
        Me.grdProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdProduto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCod, Me.Produto})
        Me.grdProduto.Location = New System.Drawing.Point(14, 213)
        Me.grdProduto.Name = "grdProduto"
        Me.grdProduto.Size = New System.Drawing.Size(673, 254)
        Me.grdProduto.TabIndex = 59
        '
        'colCod
        '
        Me.colCod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCod.HeaderText = "Codigo"
        Me.colCod.Name = "colCod"
        Me.colCod.Width = 65
        '
        'Produto
        '
        Me.Produto.HeaderText = "Produto"
        Me.Produto.Name = "Produto"
        '
        'pbxPesquisaProduto
        '
        Me.pbxPesquisaProduto.Image = Global.SCE.My.Resources.Resources.onebit_02
        Me.pbxPesquisaProduto.Location = New System.Drawing.Point(171, 48)
        Me.pbxPesquisaProduto.Name = "pbxPesquisaProduto"
        Me.pbxPesquisaProduto.Size = New System.Drawing.Size(23, 20)
        Me.pbxPesquisaProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPesquisaProduto.TabIndex = 62
        Me.pbxPesquisaProduto.TabStop = False
        '
        'pbxPesquisaFuncionario
        '
        Me.pbxPesquisaFuncionario.Image = Global.SCE.My.Resources.Resources.onebit_02
        Me.pbxPesquisaFuncionario.Location = New System.Drawing.Point(638, 48)
        Me.pbxPesquisaFuncionario.Name = "pbxPesquisaFuncionario"
        Me.pbxPesquisaFuncionario.Size = New System.Drawing.Size(23, 20)
        Me.pbxPesquisaFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPesquisaFuncionario.TabIndex = 63
        Me.pbxPesquisaFuncionario.TabStop = False
        '
        'pbxPesquisaFornecedor
        '
        Me.pbxPesquisaFornecedor.Image = Global.SCE.My.Resources.Resources.onebit_02
        Me.pbxPesquisaFornecedor.Location = New System.Drawing.Point(416, 48)
        Me.pbxPesquisaFornecedor.Name = "pbxPesquisaFornecedor"
        Me.pbxPesquisaFornecedor.Size = New System.Drawing.Size(22, 20)
        Me.pbxPesquisaFornecedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPesquisaFornecedor.TabIndex = 64
        Me.pbxPesquisaFornecedor.TabStop = False
        '
        'frmEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 502)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbxPesquisaFornecedor)
        Me.Controls.Add(Me.pbxPesquisaFuncionario)
        Me.Controls.Add(Me.pbxPesquisaProduto)
        Me.Controls.Add(Me.grdProduto)
        Me.Controls.Add(Me.grdFornecedor)
        Me.Controls.Add(Me.grdFuncionario)
        Me.Controls.Add(Me.grdGeral)
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
        Me.Name = "frmEntrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimentação de Entrada"
        CType(Me.grdGeral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdFuncionario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdFornecedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPesquisaProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPesquisaFuncionario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPesquisaFornecedor, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents grdGeral As System.Windows.Forms.DataGridView
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents colProduto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFornecedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMatricula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDtMovimento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQuantMov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdFuncionario As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Funcionario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdFornecedor As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fornecedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdProduto As System.Windows.Forms.DataGridView
    Friend WithEvents colCod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Produto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pbxPesquisaProduto As System.Windows.Forms.PictureBox
    Friend WithEvents pbxPesquisaFuncionario As System.Windows.Forms.PictureBox
    Friend WithEvents pbxPesquisaFornecedor As System.Windows.Forms.PictureBox
End Class
