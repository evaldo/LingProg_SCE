<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduto
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
        Me.txtQuantidadeMaxima = New System.Windows.Forms.TextBox
        Me.txtQuantidadeMinima = New System.Windows.Forms.TextBox
        Me.txtValorVenda = New System.Windows.Forms.TextBox
        Me.txtValorCusto = New System.Windows.Forms.TextBox
        Me.txtProduto = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.lblQuantidadeMaxima = New System.Windows.Forms.Label
        Me.lblQuantidadeMinima = New System.Windows.Forms.Label
        Me.lblValorVenda = New System.Windows.Forms.Label
        Me.lblValorCusto = New System.Windows.Forms.Label
        Me.lblProduto = New System.Windows.Forms.Label
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalvarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExcluirCadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlterarCadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultarCadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SairToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.grdProdutos = New System.Windows.Forms.DataGridView
        Me.btnLimpar = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.colCod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEndereco = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colBairro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colContato = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MenuStrip1.SuspendLayout()
        CType(Me.grdProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtQuantidadeMaxima
        '
        Me.txtQuantidadeMaxima.Location = New System.Drawing.Point(419, 177)
        Me.txtQuantidadeMaxima.Name = "txtQuantidadeMaxima"
        Me.txtQuantidadeMaxima.Size = New System.Drawing.Size(120, 20)
        Me.txtQuantidadeMaxima.TabIndex = 30
        '
        'txtQuantidadeMinima
        '
        Me.txtQuantidadeMinima.Location = New System.Drawing.Point(118, 181)
        Me.txtQuantidadeMinima.Name = "txtQuantidadeMinima"
        Me.txtQuantidadeMinima.Size = New System.Drawing.Size(119, 20)
        Me.txtQuantidadeMinima.TabIndex = 29
        '
        'txtValorVenda
        '
        Me.txtValorVenda.Location = New System.Drawing.Point(415, 134)
        Me.txtValorVenda.Name = "txtValorVenda"
        Me.txtValorVenda.Size = New System.Drawing.Size(125, 20)
        Me.txtValorVenda.TabIndex = 28
        '
        'txtValorCusto
        '
        Me.txtValorCusto.Location = New System.Drawing.Point(120, 134)
        Me.txtValorCusto.Name = "txtValorCusto"
        Me.txtValorCusto.Size = New System.Drawing.Size(119, 20)
        Me.txtValorCusto.TabIndex = 27
        '
        'txtProduto
        '
        Me.txtProduto.Location = New System.Drawing.Point(101, 87)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(259, 20)
        Me.txtProduto.TabIndex = 26
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(101, 40)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(67, 20)
        Me.txtCodigo.TabIndex = 25
        '
        'lblQuantidadeMaxima
        '
        Me.lblQuantidadeMaxima.AutoSize = True
        Me.lblQuantidadeMaxima.Location = New System.Drawing.Point(326, 184)
        Me.lblQuantidadeMaxima.Name = "lblQuantidadeMaxima"
        Me.lblQuantidadeMaxima.Size = New System.Drawing.Size(81, 13)
        Me.lblQuantidadeMaxima.TabIndex = 22
        Me.lblQuantidadeMaxima.Text = "Quant. Máxima:"
        '
        'lblQuantidadeMinima
        '
        Me.lblQuantidadeMinima.AutoSize = True
        Me.lblQuantidadeMinima.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblQuantidadeMinima.Location = New System.Drawing.Point(33, 188)
        Me.lblQuantidadeMinima.Name = "lblQuantidadeMinima"
        Me.lblQuantidadeMinima.Size = New System.Drawing.Size(80, 13)
        Me.lblQuantidadeMinima.TabIndex = 21
        Me.lblQuantidadeMinima.Text = "Quant. Mínima:"
        '
        'lblValorVenda
        '
        Me.lblValorVenda.AutoSize = True
        Me.lblValorVenda.Location = New System.Drawing.Point(323, 141)
        Me.lblValorVenda.Name = "lblValorVenda"
        Me.lblValorVenda.Size = New System.Drawing.Size(83, 13)
        Me.lblValorVenda.TabIndex = 20
        Me.lblValorVenda.Text = "Valor de Venda:"
        '
        'lblValorCusto
        '
        Me.lblValorCusto.AutoSize = True
        Me.lblValorCusto.Location = New System.Drawing.Point(33, 141)
        Me.lblValorCusto.Name = "lblValorCusto"
        Me.lblValorCusto.Size = New System.Drawing.Size(79, 13)
        Me.lblValorCusto.TabIndex = 19
        Me.lblValorCusto.Text = "Valor de Custo:"
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(33, 94)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(47, 13)
        Me.lblProduto.TabIndex = 18
        Me.lblProduto.Text = "Produto:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(33, 47)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigo.TabIndex = 17
        Me.lblCodigo.Text = "Código:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.SairToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(697, 24)
        Me.MenuStrip1.TabIndex = 33
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalvarToolStripMenuItem, Me.ExcluirCadastroToolStripMenuItem, Me.AlterarCadastroToolStripMenuItem, Me.ConsultarCadastroToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ArquivoToolStripMenuItem.Text = "Arquivo"
        '
        'SalvarToolStripMenuItem
        '
        Me.SalvarToolStripMenuItem.Name = "SalvarToolStripMenuItem"
        Me.SalvarToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.SalvarToolStripMenuItem.Text = "&Novo Cadastro"
        '
        'ExcluirCadastroToolStripMenuItem
        '
        Me.ExcluirCadastroToolStripMenuItem.Name = "ExcluirCadastroToolStripMenuItem"
        Me.ExcluirCadastroToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ExcluirCadastroToolStripMenuItem.Text = "&Excluir Cadastro"
        '
        'AlterarCadastroToolStripMenuItem
        '
        Me.AlterarCadastroToolStripMenuItem.Name = "AlterarCadastroToolStripMenuItem"
        Me.AlterarCadastroToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AlterarCadastroToolStripMenuItem.Text = "&Alterar Cadastro"
        '
        'ConsultarCadastroToolStripMenuItem
        '
        Me.ConsultarCadastroToolStripMenuItem.Name = "ConsultarCadastroToolStripMenuItem"
        Me.ConsultarCadastroToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ConsultarCadastroToolStripMenuItem.Text = "&Consultar Cadastro"
        '
        'SairToolStripMenuItem1
        '
        Me.SairToolStripMenuItem1.Name = "SairToolStripMenuItem1"
        Me.SairToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.SairToolStripMenuItem1.Text = "Sair"
        '
        'grdProdutos
        '
        Me.grdProdutos.AllowUserToAddRows = False
        Me.grdProdutos.AllowUserToDeleteRows = False
        Me.grdProdutos.AllowUserToResizeColumns = False
        Me.grdProdutos.AllowUserToResizeRows = False
        Me.grdProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCod, Me.colFornecedor, Me.colEndereco, Me.colBairro, Me.colContato, Me.Column1})
        Me.grdProdutos.Location = New System.Drawing.Point(12, 255)
        Me.grdProdutos.Name = "grdProdutos"
        Me.grdProdutos.Size = New System.Drawing.Size(671, 179)
        Me.grdProdutos.TabIndex = 54
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(481, 226)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(105, 23)
        Me.btnLimpar.TabIndex = 53
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(592, 226)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(88, 23)
        Me.btnSair.TabIndex = 52
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(255, 226)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(98, 23)
        Me.btnAlterar.TabIndex = 51
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(135, 226)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(97, 23)
        Me.btnExcluir.TabIndex = 50
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(17, 226)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(101, 23)
        Me.btnSalvar.TabIndex = 49
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(370, 226)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(105, 23)
        Me.btnConsultar.TabIndex = 48
        Me.btnConsultar.Text = "Consultar Clientes"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'colCod
        '
        Me.colCod.HeaderText = "Codigo"
        Me.colCod.Name = "colCod"
        '
        'colFornecedor
        '
        Me.colFornecedor.HeaderText = "Produto"
        Me.colFornecedor.Name = "colFornecedor"
        Me.colFornecedor.Width = 300
        '
        'colEndereco
        '
        Me.colEndereco.HeaderText = "Vl.Custo"
        Me.colEndereco.Name = "colEndereco"
        Me.colEndereco.Width = 200
        '
        'colBairro
        '
        Me.colBairro.HeaderText = "Vl.Venda"
        Me.colBairro.Name = "colBairro"
        Me.colBairro.Width = 150
        '
        'colContato
        '
        Me.colContato.HeaderText = "Qt.Minima"
        Me.colContato.Name = "colContato"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Qt.Maxima"
        Me.Column1.Name = "Column1"
        '
        'frmProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 446)
        Me.Controls.Add(Me.grdProdutos)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.txtQuantidadeMaxima)
        Me.Controls.Add(Me.txtQuantidadeMinima)
        Me.Controls.Add(Me.txtValorVenda)
        Me.Controls.Add(Me.txtValorCusto)
        Me.Controls.Add(Me.txtProduto)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblQuantidadeMaxima)
        Me.Controls.Add(Me.lblQuantidadeMinima)
        Me.Controls.Add(Me.lblValorVenda)
        Me.Controls.Add(Me.lblValorCusto)
        Me.Controls.Add(Me.lblProduto)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmProduto"
        Me.Text = "Produto"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.grdProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtQuantidadeMaxima As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantidadeMinima As System.Windows.Forms.TextBox
    Friend WithEvents txtValorVenda As System.Windows.Forms.TextBox
    Friend WithEvents txtValorCusto As System.Windows.Forms.TextBox
    Friend WithEvents txtProduto As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblQuantidadeMaxima As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeMinima As System.Windows.Forms.Label
    Friend WithEvents lblValorVenda As System.Windows.Forms.Label
    Friend WithEvents lblValorCusto As System.Windows.Forms.Label
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalvarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcluirCadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlterarCadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarCadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grdProdutos As System.Windows.Forms.DataGridView
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents colCod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFornecedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEndereco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBairro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colContato As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
