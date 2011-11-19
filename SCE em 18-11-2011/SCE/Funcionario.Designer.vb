<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuncionario
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
        Me.lblMatricula = New System.Windows.Forms.Label
        Me.lblFuncionario = New System.Windows.Forms.Label
        Me.lblEndereco = New System.Windows.Forms.Label
        Me.lblBairro = New System.Windows.Forms.Label
        Me.lblTelefoneResidencial = New System.Windows.Forms.Label
        Me.lblTelefoneCelular = New System.Windows.Forms.Label
        Me.lblCargo = New System.Windows.Forms.Label
        Me.lblSalario = New System.Windows.Forms.Label
        Me.txtMatricula = New System.Windows.Forms.TextBox
        Me.txtFuncionario = New System.Windows.Forms.TextBox
        Me.txtEndereco = New System.Windows.Forms.TextBox
        Me.txtBairro = New System.Windows.Forms.TextBox
        Me.txtTelefoneResidencial = New System.Windows.Forms.TextBox
        Me.txtTelefoneCelular = New System.Windows.Forms.TextBox
        Me.txtValorSalario = New System.Windows.Forms.TextBox
        Me.txtCargo = New System.Windows.Forms.TextBox
        Me.grdFuncionarios = New System.Windows.Forms.DataGridView
        Me.colCod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEndereco = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colBairro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colContato = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnLimpar = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnConsultar = New System.Windows.Forms.Button
        CType(Me.grdFuncionarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Location = New System.Drawing.Point(33, 38)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(53, 13)
        Me.lblMatricula.TabIndex = 0
        Me.lblMatricula.Text = "Matricula:"
        '
        'lblFuncionario
        '
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.Location = New System.Drawing.Point(33, 85)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(65, 13)
        Me.lblFuncionario.TabIndex = 1
        Me.lblFuncionario.Text = "Funcionário:"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(33, 132)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(56, 13)
        Me.lblEndereco.TabIndex = 2
        Me.lblEndereco.Text = "Endereço:"
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(450, 132)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(37, 13)
        Me.lblBairro.TabIndex = 3
        Me.lblBairro.Text = "Bairro:"
        '
        'lblTelefoneResidencial
        '
        Me.lblTelefoneResidencial.AutoSize = True
        Me.lblTelefoneResidencial.Location = New System.Drawing.Point(33, 179)
        Me.lblTelefoneResidencial.Name = "lblTelefoneResidencial"
        Me.lblTelefoneResidencial.Size = New System.Drawing.Size(83, 13)
        Me.lblTelefoneResidencial.TabIndex = 4
        Me.lblTelefoneResidencial.Text = "Tel Residêncial:"
        '
        'lblTelefoneCelular
        '
        Me.lblTelefoneCelular.AutoSize = True
        Me.lblTelefoneCelular.Location = New System.Drawing.Point(326, 175)
        Me.lblTelefoneCelular.Name = "lblTelefoneCelular"
        Me.lblTelefoneCelular.Size = New System.Drawing.Size(63, 13)
        Me.lblTelefoneCelular.TabIndex = 5
        Me.lblTelefoneCelular.Text = "Tel. Celular:"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Location = New System.Drawing.Point(33, 230)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(38, 13)
        Me.lblCargo.TabIndex = 6
        Me.lblCargo.Text = "Cargo:"
        '
        'lblSalario
        '
        Me.lblSalario.AutoSize = True
        Me.lblSalario.Location = New System.Drawing.Point(348, 230)
        Me.lblSalario.Name = "lblSalario"
        Me.lblSalario.Size = New System.Drawing.Size(42, 13)
        Me.lblSalario.TabIndex = 7
        Me.lblSalario.Text = "Salário:"
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(101, 31)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(67, 20)
        Me.txtMatricula.TabIndex = 1
        '
        'txtFuncionario
        '
        Me.txtFuncionario.Location = New System.Drawing.Point(101, 78)
        Me.txtFuncionario.Name = "txtFuncionario"
        Me.txtFuncionario.Size = New System.Drawing.Size(259, 20)
        Me.txtFuncionario.TabIndex = 2
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(101, 125)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(343, 20)
        Me.txtEndereco.TabIndex = 3
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(493, 125)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(181, 20)
        Me.txtBairro.TabIndex = 4
        '
        'txtTelefoneResidencial
        '
        Me.txtTelefoneResidencial.Location = New System.Drawing.Point(118, 172)
        Me.txtTelefoneResidencial.Name = "txtTelefoneResidencial"
        Me.txtTelefoneResidencial.Size = New System.Drawing.Size(181, 20)
        Me.txtTelefoneResidencial.TabIndex = 5
        '
        'txtTelefoneCelular
        '
        Me.txtTelefoneCelular.Location = New System.Drawing.Point(395, 168)
        Me.txtTelefoneCelular.Name = "txtTelefoneCelular"
        Me.txtTelefoneCelular.Size = New System.Drawing.Size(181, 20)
        Me.txtTelefoneCelular.TabIndex = 6
        '
        'txtValorSalario
        '
        Me.txtValorSalario.Location = New System.Drawing.Point(396, 223)
        Me.txtValorSalario.Name = "txtValorSalario"
        Me.txtValorSalario.Size = New System.Drawing.Size(181, 20)
        Me.txtValorSalario.TabIndex = 8
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(77, 223)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(250, 20)
        Me.txtCargo.TabIndex = 7
        '
        'grdFuncionarios
        '
        Me.grdFuncionarios.AllowUserToAddRows = False
        Me.grdFuncionarios.AllowUserToDeleteRows = False
        Me.grdFuncionarios.AllowUserToResizeColumns = False
        Me.grdFuncionarios.AllowUserToResizeRows = False
        Me.grdFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdFuncionarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCod, Me.colFornecedor, Me.colEndereco, Me.colBairro, Me.colContato, Me.Column1, Me.Column2, Me.Column3})
        Me.grdFuncionarios.Location = New System.Drawing.Point(14, 297)
        Me.grdFuncionarios.Name = "grdFuncionarios"
        Me.grdFuncionarios.Size = New System.Drawing.Size(671, 150)
        Me.grdFuncionarios.TabIndex = 15
        '
        'colCod
        '
        Me.colCod.HeaderText = "Matrícula"
        Me.colCod.Name = "colCod"
        '
        'colFornecedor
        '
        Me.colFornecedor.HeaderText = "Funcionário"
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
        Me.colContato.HeaderText = "Tel. Residêncial"
        Me.colContato.Name = "colContato"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Tel. Celular"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Cargo"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Salario"
        Me.Column3.Name = "Column3"
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(483, 268)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(105, 23)
        Me.btnLimpar.TabIndex = 13
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(594, 268)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(88, 23)
        Me.btnSair.TabIndex = 14
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(257, 268)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(98, 23)
        Me.btnAlterar.TabIndex = 11
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(137, 268)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(97, 23)
        Me.btnExcluir.TabIndex = 10
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(19, 268)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(101, 23)
        Me.btnSalvar.TabIndex = 9
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(372, 268)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(105, 23)
        Me.btnConsultar.TabIndex = 12
        Me.btnConsultar.Text = "Consultar "
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'frmFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 454)
        Me.ControlBox = False
        Me.Controls.Add(Me.grdFuncionarios)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.txtCargo)
        Me.Controls.Add(Me.txtValorSalario)
        Me.Controls.Add(Me.txtTelefoneCelular)
        Me.Controls.Add(Me.txtTelefoneResidencial)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.txtFuncionario)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.lblSalario)
        Me.Controls.Add(Me.lblCargo)
        Me.Controls.Add(Me.lblTelefoneCelular)
        Me.Controls.Add(Me.lblTelefoneResidencial)
        Me.Controls.Add(Me.lblBairro)
        Me.Controls.Add(Me.lblEndereco)
        Me.Controls.Add(Me.lblFuncionario)
        Me.Controls.Add(Me.lblMatricula)
        Me.Name = "frmFuncionario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Funcionários"
        CType(Me.grdFuncionarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMatricula As System.Windows.Forms.Label
    Friend WithEvents lblFuncionario As System.Windows.Forms.Label
    Friend WithEvents lblEndereco As System.Windows.Forms.Label
    Friend WithEvents lblBairro As System.Windows.Forms.Label
    Friend WithEvents lblTelefoneResidencial As System.Windows.Forms.Label
    Friend WithEvents lblTelefoneCelular As System.Windows.Forms.Label
    Friend WithEvents lblCargo As System.Windows.Forms.Label
    Friend WithEvents lblSalario As System.Windows.Forms.Label
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents txtFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefoneResidencial As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefoneCelular As System.Windows.Forms.TextBox
    Friend WithEvents txtValorSalario As System.Windows.Forms.TextBox
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents grdFuncionarios As System.Windows.Forms.DataGridView
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
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
