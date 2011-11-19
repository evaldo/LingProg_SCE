<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFornecedor
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
        Me.txtContato = New System.Windows.Forms.TextBox
        Me.txtBairro = New System.Windows.Forms.TextBox
        Me.txtEndereco = New System.Windows.Forms.TextBox
        Me.txtFornecedor = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.lblContato = New System.Windows.Forms.Label
        Me.lblBairro = New System.Windows.Forms.Label
        Me.lblEndereco = New System.Windows.Forms.Label
        Me.lblFornecedor = New System.Windows.Forms.Label
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalvarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExcluirCadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlterarCadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultarCadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalvarCadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SairToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.btnLimpar = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.grdFornecedores = New System.Windows.Forms.DataGridView
        Me.colCod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEndereco = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colBairro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colContato = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MenuStrip1.SuspendLayout()
        CType(Me.grdFornecedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtContato
        '
        Me.txtContato.Location = New System.Drawing.Point(104, 181)
        Me.txtContato.Name = "txtContato"
        Me.txtContato.Size = New System.Drawing.Size(210, 20)
        Me.txtContato.TabIndex = 29
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(493, 134)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(181, 20)
        Me.txtBairro.TabIndex = 28
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(101, 134)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(343, 20)
        Me.txtEndereco.TabIndex = 27
        '
        'txtFornecedor
        '
        Me.txtFornecedor.Location = New System.Drawing.Point(101, 87)
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Size = New System.Drawing.Size(259, 20)
        Me.txtFornecedor.TabIndex = 26
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(101, 40)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(67, 20)
        Me.txtCodigo.TabIndex = 25
        '
        'lblContato
        '
        Me.lblContato.AutoSize = True
        Me.lblContato.Location = New System.Drawing.Point(33, 188)
        Me.lblContato.Name = "lblContato"
        Me.lblContato.Size = New System.Drawing.Size(47, 13)
        Me.lblContato.TabIndex = 21
        Me.lblContato.Text = "Contato:"
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(450, 141)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(37, 13)
        Me.lblBairro.TabIndex = 20
        Me.lblBairro.Text = "Bairro:"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(33, 141)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(56, 13)
        Me.lblEndereco.TabIndex = 19
        Me.lblEndereco.Text = "Endereço:"
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Location = New System.Drawing.Point(33, 94)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(64, 13)
        Me.lblFornecedor.TabIndex = 18
        Me.lblFornecedor.Text = "Fornecedor:"
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
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalvarToolStripMenuItem, Me.ExcluirCadastroToolStripMenuItem, Me.AlterarCadastroToolStripMenuItem, Me.ConsultarCadastroToolStripMenuItem, Me.SalvarCadastroToolStripMenuItem})
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
        'SalvarCadastroToolStripMenuItem
        '
        Me.SalvarCadastroToolStripMenuItem.Name = "SalvarCadastroToolStripMenuItem"
        Me.SalvarCadastroToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.SalvarCadastroToolStripMenuItem.Text = "&Salvar Cadastro"
        '
        'SairToolStripMenuItem1
        '
        Me.SairToolStripMenuItem1.Name = "SairToolStripMenuItem1"
        Me.SairToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.SairToolStripMenuItem1.Text = "Sair"
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(481, 226)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(105, 23)
        Me.btnLimpar.TabIndex = 39
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(592, 226)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(88, 23)
        Me.btnSair.TabIndex = 38
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(255, 226)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(98, 23)
        Me.btnAlterar.TabIndex = 37
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(135, 226)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(97, 23)
        Me.btnExcluir.TabIndex = 36
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(17, 226)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(101, 23)
        Me.btnSalvar.TabIndex = 35
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(370, 226)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(105, 23)
        Me.btnConsultar.TabIndex = 34
        Me.btnConsultar.Text = "Consultar Clientes"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'grdFornecedores
        '
        Me.grdFornecedores.AllowUserToAddRows = False
        Me.grdFornecedores.AllowUserToDeleteRows = False
        Me.grdFornecedores.AllowUserToResizeColumns = False
        Me.grdFornecedores.AllowUserToResizeRows = False
        Me.grdFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdFornecedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCod, Me.colFornecedor, Me.colEndereco, Me.colBairro, Me.colContato})
        Me.grdFornecedores.Location = New System.Drawing.Point(12, 255)
        Me.grdFornecedores.Name = "grdFornecedores"
        Me.grdFornecedores.Size = New System.Drawing.Size(671, 227)
        Me.grdFornecedores.TabIndex = 40
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
        'frmFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 508)
        Me.Controls.Add(Me.grdFornecedores)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.txtContato)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.txtFornecedor)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblContato)
        Me.Controls.Add(Me.lblBairro)
        Me.Controls.Add(Me.lblEndereco)
        Me.Controls.Add(Me.lblFornecedor)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmFornecedor"
        Me.Text = "Fornecedor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.grdFornecedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtContato As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtFornecedor As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblContato As System.Windows.Forms.Label
    Friend WithEvents lblBairro As System.Windows.Forms.Label
    Friend WithEvents lblEndereco As System.Windows.Forms.Label
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalvarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcluirCadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlterarCadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarCadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalvarCadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents grdFornecedores As System.Windows.Forms.DataGridView
    Friend WithEvents colCod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFornecedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEndereco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBairro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colContato As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
