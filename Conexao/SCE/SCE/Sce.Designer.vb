<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSCE
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
        Me.grdCliente = New System.Windows.Forms.DataGridView
        Me.colCod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DtNascimento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ValorPedido = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.lblNome = New System.Windows.Forms.Label
        Me.txtNome = New System.Windows.Forms.TextBox
        Me.lblDtNasc = New System.Windows.Forms.Label
        Me.mskDtNasc = New System.Windows.Forms.MaskedTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtValor = New System.Windows.Forms.TextBox
        Me.btnSair = New System.Windows.Forms.Button
        Me.btnLimpar = New System.Windows.Forms.Button
        CType(Me.grdCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdCliente
        '
        Me.grdCliente.AllowUserToAddRows = False
        Me.grdCliente.AllowUserToDeleteRows = False
        Me.grdCliente.AllowUserToResizeColumns = False
        Me.grdCliente.AllowUserToResizeRows = False
        Me.grdCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCod, Me.colName, Me.DtNascimento, Me.ValorPedido})
        Me.grdCliente.Location = New System.Drawing.Point(1, 89)
        Me.grdCliente.Name = "grdCliente"
        Me.grdCliente.Size = New System.Drawing.Size(671, 150)
        Me.grdCliente.TabIndex = 0
        '
        'colCod
        '
        Me.colCod.HeaderText = "Codigo"
        Me.colCod.Name = "colCod"
        '
        'colName
        '
        Me.colName.HeaderText = "Nome"
        Me.colName.Name = "colName"
        Me.colName.Width = 300
        '
        'DtNascimento
        '
        Me.DtNascimento.HeaderText = "Dt Nascimento"
        Me.DtNascimento.Name = "DtNascimento"
        '
        'ValorPedido
        '
        Me.ValorPedido.HeaderText = "Valor do Pedido"
        Me.ValorPedido.Name = "ValorPedido"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(362, 256)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(105, 23)
        Me.btnConsultar.TabIndex = 1
        Me.btnConsultar.Text = "Consultar Clientes"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(9, 256)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(101, 23)
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(127, 256)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(97, 23)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(247, 256)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(98, 23)
        Me.btnAlterar.TabIndex = 4
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(13, 13)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 5
        Me.lblCodigo.Text = "Codigo"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(60, 10)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 6
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(179, 13)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(35, 13)
        Me.lblNome.TabIndex = 7
        Me.lblNome.Text = "Nome"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(230, 10)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(226, 20)
        Me.txtNome.TabIndex = 8
        '
        'lblDtNasc
        '
        Me.lblDtNasc.AutoSize = True
        Me.lblDtNasc.Location = New System.Drawing.Point(16, 49)
        Me.lblDtNasc.Name = "lblDtNasc"
        Me.lblDtNasc.Size = New System.Drawing.Size(104, 13)
        Me.lblDtNasc.TabIndex = 9
        Me.lblDtNasc.Text = "Data de Nascimento"
        '
        'mskDtNasc
        '
        Me.mskDtNasc.Location = New System.Drawing.Point(127, 49)
        Me.mskDtNasc.Mask = "00/00/0000"
        Me.mskDtNasc.Name = "mskDtNasc"
        Me.mskDtNasc.Size = New System.Drawing.Size(87, 20)
        Me.mskDtNasc.TabIndex = 10
        Me.mskDtNasc.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(263, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Valor do Pedido"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(352, 48)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 12
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(584, 256)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(88, 23)
        Me.btnSair.TabIndex = 13
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(473, 256)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(105, 23)
        Me.btnLimpar.TabIndex = 14
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'frmSCE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 291)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mskDtNasc)
        Me.Controls.Add(Me.lblDtNasc)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.grdCliente)
        Me.Name = "frmSCE"
        Me.Text = "Consulta Cliente"
        CType(Me.grdCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdCliente As System.Windows.Forms.DataGridView
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents lblDtNasc As System.Windows.Forms.Label
    Friend WithEvents mskDtNasc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents colCod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DtNascimento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorPedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button

End Class
