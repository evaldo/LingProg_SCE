<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmObjeto
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
        Me.btnSet = New System.Windows.Forms.Button
        Me.btnGet = New System.Windows.Forms.Button
        Me.lblNome = New System.Windows.Forms.Label
        Me.cmbNome = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(48, 45)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(75, 23)
        Me.btnSet.TabIndex = 0
        Me.btnSet.Text = "Set"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'btnGet
        '
        Me.btnGet.Location = New System.Drawing.Point(157, 45)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(75, 23)
        Me.btnGet.TabIndex = 1
        Me.btnGet.Text = "Get"
        Me.btnGet.UseVisualStyleBackColor = True
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(24, 12)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(38, 13)
        Me.lblNome.TabIndex = 2
        Me.lblNome.Text = "Nome:"
        '
        'cmbNome
        '
        Me.cmbNome.FormattingEnabled = True
        Me.cmbNome.Location = New System.Drawing.Point(69, 12)
        Me.cmbNome.Name = "cmbNome"
        Me.cmbNome.Size = New System.Drawing.Size(180, 21)
        Me.cmbNome.TabIndex = 3
        '
        'frmObjeto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 89)
        Me.Controls.Add(Me.cmbNome)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.btnGet)
        Me.Controls.Add(Me.btnSet)
        Me.Name = "frmObjeto"
        Me.Text = "Instaciação de Objetos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents btnGet As System.Windows.Forms.Button
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents cmbNome As System.Windows.Forms.ComboBox

End Class
