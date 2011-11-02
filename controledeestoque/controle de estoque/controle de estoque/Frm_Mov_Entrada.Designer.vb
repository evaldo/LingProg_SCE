<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Mov_Entrada
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCodigo_P = New System.Windows.Forms.TextBox
        Me.txtCodigo_F = New System.Windows.Forms.TextBox
        Me.lblNf = New System.Windows.Forms.Label
        Me.txtnf = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDTmov = New System.Windows.Forms.TextBox
        Me.lblQTmov = New System.Windows.Forms.Label
        Me.txtQTmov = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.btnConsulta = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código do produto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Código do fornecedor:"
        '
        'txtCodigo_P
        '
        Me.txtCodigo_P.Location = New System.Drawing.Point(115, 6)
        Me.txtCodigo_P.Name = "txtCodigo_P"
        Me.txtCodigo_P.Size = New System.Drawing.Size(48, 20)
        Me.txtCodigo_P.TabIndex = 2
        '
        'txtCodigo_F
        '
        Me.txtCodigo_F.Location = New System.Drawing.Point(287, 6)
        Me.txtCodigo_F.Name = "txtCodigo_F"
        Me.txtCodigo_F.Size = New System.Drawing.Size(48, 20)
        Me.txtCodigo_F.TabIndex = 3
        '
        'lblNf
        '
        Me.lblNf.AutoSize = True
        Me.lblNf.Location = New System.Drawing.Point(12, 50)
        Me.lblNf.Name = "lblNf"
        Me.lblNf.Size = New System.Drawing.Size(114, 13)
        Me.lblNf.TabIndex = 4
        Me.lblNf.Text = "Nota fiscal do produto:"
        '
        'txtnf
        '
        Me.txtnf.Location = New System.Drawing.Point(132, 47)
        Me.txtnf.Name = "txtnf"
        Me.txtnf.Size = New System.Drawing.Size(110, 20)
        Me.txtnf.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Data atual do movimento:"
        '
        'txtDTmov
        '
        Me.txtDTmov.Location = New System.Drawing.Point(142, 81)
        Me.txtDTmov.Name = "txtDTmov"
        Me.txtDTmov.Size = New System.Drawing.Size(100, 20)
        Me.txtDTmov.TabIndex = 7
        '
        'lblQTmov
        '
        Me.lblQTmov.AutoSize = True
        Me.lblQTmov.Location = New System.Drawing.Point(257, 84)
        Me.lblQTmov.Name = "lblQTmov"
        Me.lblQTmov.Size = New System.Drawing.Size(102, 13)
        Me.lblQTmov.TabIndex = 8
        Me.lblQTmov.Text = "Quantidade movido:"
        '
        'txtQTmov
        '
        Me.txtQTmov.Location = New System.Drawing.Point(365, 81)
        Me.txtQTmov.Name = "txtQTmov"
        Me.txtQTmov.Size = New System.Drawing.Size(100, 20)
        Me.txtQTmov.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(382, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Consultar movimentação de entrada de produtos"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(15, 157)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(189, 17)
        Me.RadioButton1.TabIndex = 11
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Pelo código do produto do produto"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(12, 189)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(187, 17)
        Me.RadioButton2.TabIndex = 12
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Pela a data de entrada do produto"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'btnConsulta
        '
        Me.btnConsulta.Location = New System.Drawing.Point(190, 212)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(75, 23)
        Me.btnConsulta.TabIndex = 13
        Me.btnConsulta.Text = "Consultar"
        Me.btnConsulta.UseVisualStyleBackColor = True
        '
        'Frm_Mov_Entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 237)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtQTmov)
        Me.Controls.Add(Me.lblQTmov)
        Me.Controls.Add(Me.txtDTmov)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnf)
        Me.Controls.Add(Me.lblNf)
        Me.Controls.Add(Me.txtCodigo_F)
        Me.Controls.Add(Me.txtCodigo_P)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_Mov_Entrada"
        Me.Text = "Entada de mercadorias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo_P As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo_F As System.Windows.Forms.TextBox
    Friend WithEvents lblNf As System.Windows.Forms.Label
    Friend WithEvents txtnf As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDTmov As System.Windows.Forms.TextBox
    Friend WithEvents lblQTmov As System.Windows.Forms.Label
    Friend WithEvents txtQTmov As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents btnConsulta As System.Windows.Forms.Button
End Class
