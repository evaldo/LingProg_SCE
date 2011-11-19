Imports SCE.BllSce
Imports System.Windows.Forms


Public Class frmImpressaoFornecedor


    Private Sub carregaGrid()
        Dim ds As New DataSet

        ds = BllFornecedor.pesquisaFornecedores()
        grdFornecedores.RowCount = ds.Tables(0).Rows.Count

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            grdFornecedores.Item(0, i).Value = ds.Tables(0).Rows.Item(i).Item("CD_FORNECEDOR").ToString()
            grdFornecedores.Item(1, i).Value = ds.Tables(0).Rows.Item(i).Item("NM_FORNECEDOR").ToString()
            grdFornecedores.Item(2, i).Value = ds.Tables(0).Rows.Item(i).Item("DS_ENDERECO").ToString()
            grdFornecedores.Item(3, i).Value = ds.Tables(0).Rows.Item(i).Item("DS_BAIRRO").ToString()
            grdFornecedores.Item(4, i).Value = ds.Tables(0).Rows.Item(i).Item("DS_CONTATO").ToString()

        Next i

    End Sub
    Private Sub frmSCE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaGrid()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        Close()
    End Sub


    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

    End Sub
End Class