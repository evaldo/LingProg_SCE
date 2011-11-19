Imports SCE.BllSce

Public Class frmImpressaoProduto

    Dim ds As New DataSet

    Private Sub ImpressaoProdutos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub carregaGrid()

        ds = Bll.pesquisaProdutos()

        grdProdutos.RowCount = ds.Tables(0).Rows.Count

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            grdProdutos.Item(0, i).Value = ds.Tables(0).Rows.Item(i).Item("CD_PRODUTO").ToString
            grdProdutos.Item(1, i).Value = ds.Tables(0).Rows.Item(i).Item("NM_PRODUTO").ToString
            grdProdutos.Item(2, i).Value = ds.Tables(0).Rows.Item(i).Item("VL_CUSTO").ToString
            grdProdutos.Item(3, i).Value = ds.Tables(0).Rows.Item(i).Item("VL_VENDA").ToString
            grdProdutos.Item(4, i).Value = ds.Tables(0).Rows.Item(i).Item("QT_MINIMA").ToString
            grdProdutos.Item(5, i).Value = ds.Tables(0).Rows.Item(i).Item("QT_MAXIMA").ToString
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