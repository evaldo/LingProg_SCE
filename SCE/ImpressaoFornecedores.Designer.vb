<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpressaoFornecedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImpressaoFornecedor))
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.grdFornecedores = New System.Windows.Forms.DataGridView
        Me.colCod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEndereco = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colBairro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colContato = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        CType(Me.grdFornecedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(697, 20)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(64, 23)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Imprirmir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(782, 20)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'grdFornecedores
        '
        Me.grdFornecedores.AllowUserToAddRows = False
        Me.grdFornecedores.AllowUserToDeleteRows = False
        Me.grdFornecedores.AllowUserToResizeColumns = False
        Me.grdFornecedores.AllowUserToResizeRows = False
        Me.grdFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdFornecedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCod, Me.colFornecedor, Me.colEndereco, Me.colBairro, Me.colContato})
        Me.grdFornecedores.Location = New System.Drawing.Point(4, 66)
        Me.grdFornecedores.Name = "grdFornecedores"
        Me.grdFornecedores.Size = New System.Drawing.Size(887, 299)
        Me.grdFornecedores.TabIndex = 41
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 31)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Lista de Fornecedores: "
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frmImpressaoFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 377)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdFornecedores)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Name = "frmImpressaoFornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impressao"
        CType(Me.grdFornecedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents grdFornecedores As System.Windows.Forms.DataGridView
    Friend WithEvents colCod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFornecedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEndereco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBairro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colContato As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
