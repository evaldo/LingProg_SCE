Imports System.Windows.Forms

Public Class frmMDI

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub FornecedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornecedorToolStripMenuItem.Click
        frmFornecedor.MdiParent = Me
        frmFornecedor.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        End
    End Sub

    Private Sub FuncionárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionárioToolStripMenuItem.Click
        frmFuncionario.MdiParent = Me
        frmFuncionario.Show()
    End Sub

    Private Sub ProdutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdutoToolStripMenuItem.Click
        frmProduto.MdiParent = Me
        frmProduto.Show()

    End Sub

    Private Sub EntradaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradaToolStripMenuItem.Click
        frmEntrada.MdiParent = Me
        frmEntrada.Show()

    End Sub

    Private Sub SaídaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaídaToolStripMenuItem.Click
        frmSaida.MdiParent = Me
        frmSaida.Show()
    End Sub

    Private Sub FornecedorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornecedorToolStripMenuItem1.Click
        frmImpressaoFornecedor.MdiParent = Me
        frmImpressaoFornecedor.Show()

    End Sub

    Private Sub ProdutoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdutoToolStripMenuItem1.Click
        frmImpressaoProduto.MdiParent = Me
        frmImpressaoProduto.Show()
    End Sub
End Class
