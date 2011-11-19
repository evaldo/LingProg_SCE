<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMDI
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
        Me.components = New System.ComponentModel.Container
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.IniciarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FornecedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FuncionárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProdutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MovimentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EntradaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaídaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RelatórioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FornecedorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.FuncionárioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ProdutoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.EntradaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SaídaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.PorPeríodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IniciarToolStripMenuItem, Me.MovimentoToolStripMenuItem, Me.RelatórioToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'IniciarToolStripMenuItem
        '
        Me.IniciarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FornecedorToolStripMenuItem, Me.FuncionárioToolStripMenuItem, Me.ProdutoToolStripMenuItem})
        Me.IniciarToolStripMenuItem.Name = "IniciarToolStripMenuItem"
        Me.IniciarToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.IniciarToolStripMenuItem.Text = "&Cadastro"
        '
        'FornecedorToolStripMenuItem
        '
        Me.FornecedorToolStripMenuItem.Name = "FornecedorToolStripMenuItem"
        Me.FornecedorToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.FornecedorToolStripMenuItem.Text = "Fornecedor"
        '
        'FuncionárioToolStripMenuItem
        '
        Me.FuncionárioToolStripMenuItem.Name = "FuncionárioToolStripMenuItem"
        Me.FuncionárioToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.FuncionárioToolStripMenuItem.Text = "Funcionário"
        '
        'ProdutoToolStripMenuItem
        '
        Me.ProdutoToolStripMenuItem.Name = "ProdutoToolStripMenuItem"
        Me.ProdutoToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ProdutoToolStripMenuItem.Text = "Produto"
        '
        'MovimentoToolStripMenuItem
        '
        Me.MovimentoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntradaToolStripMenuItem, Me.SaídaToolStripMenuItem})
        Me.MovimentoToolStripMenuItem.Name = "MovimentoToolStripMenuItem"
        Me.MovimentoToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.MovimentoToolStripMenuItem.Text = "&Movimento"
        '
        'EntradaToolStripMenuItem
        '
        Me.EntradaToolStripMenuItem.Name = "EntradaToolStripMenuItem"
        Me.EntradaToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.EntradaToolStripMenuItem.Text = "Entrada"
        '
        'SaídaToolStripMenuItem
        '
        Me.SaídaToolStripMenuItem.Name = "SaídaToolStripMenuItem"
        Me.SaídaToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.SaídaToolStripMenuItem.Text = "Saída"
        '
        'RelatórioToolStripMenuItem
        '
        Me.RelatórioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FornecedorToolStripMenuItem1, Me.FuncionárioToolStripMenuItem1, Me.ProdutoToolStripMenuItem1, Me.EntradaToolStripMenuItem1, Me.SaídaToolStripMenuItem1, Me.PorPeríodoToolStripMenuItem})
        Me.RelatórioToolStripMenuItem.Name = "RelatórioToolStripMenuItem"
        Me.RelatórioToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.RelatórioToolStripMenuItem.Text = "&Relatório"
        '
        'FornecedorToolStripMenuItem1
        '
        Me.FornecedorToolStripMenuItem1.Name = "FornecedorToolStripMenuItem1"
        Me.FornecedorToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.FornecedorToolStripMenuItem1.Text = "Fornecedor"
        '
        'FuncionárioToolStripMenuItem1
        '
        Me.FuncionárioToolStripMenuItem1.Name = "FuncionárioToolStripMenuItem1"
        Me.FuncionárioToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.FuncionárioToolStripMenuItem1.Text = "Funcionário"
        '
        'ProdutoToolStripMenuItem1
        '
        Me.ProdutoToolStripMenuItem1.Name = "ProdutoToolStripMenuItem1"
        Me.ProdutoToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ProdutoToolStripMenuItem1.Text = "Produto"
        '
        'EntradaToolStripMenuItem1
        '
        Me.EntradaToolStripMenuItem1.Name = "EntradaToolStripMenuItem1"
        Me.EntradaToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.EntradaToolStripMenuItem1.Text = "Entrada"
        '
        'SaídaToolStripMenuItem1
        '
        Me.SaídaToolStripMenuItem1.Name = "SaídaToolStripMenuItem1"
        Me.SaídaToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.SaídaToolStripMenuItem1.Text = "Saída"
        '
        'PorPeríodoToolStripMenuItem
        '
        Me.PorPeríodoToolStripMenuItem.Name = "PorPeríodoToolStripMenuItem"
        Me.PorPeríodoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PorPeríodoToolStripMenuItem.Text = "Período"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.SairToolStripMenuItem.Text = "&Sair"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(38, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'frmMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmMDI"
        Me.Text = "Sistema de Controle de Estoque"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents IniciarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovimentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelatórioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FornecedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuncionárioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntradaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaídaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FornecedorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuncionárioToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdutoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntradaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaídaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorPeríodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
