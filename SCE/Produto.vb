﻿Imports SCE.BllSce

Public Class frmProduto

    Dim ds As New DataSet

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click

        ds = BllProduto.pesquisaProdutoId(txtCodigo.Text, txtProduto.Text, txtValorCusto.Text, txtValorVenda.Text, txtQuantidadeMinima.Text, txtQuantidadeMaxima.Text)

        grdProdutos.RowCount = ds.Tables(0).Rows.Count

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            grdProdutos.Item(0, i).Value = ds.Tables(0).Rows.Item(i).Item("CD_PRODUTO").ToString
            grdProdutos.Item(1, i).Value = ds.Tables(0).Rows.Item(i).Item("NM_PRODUTO").ToString
            grdProdutos.Item(2, i).Value = ds.Tables(0).Rows.Item(i).Item("VL_CUSTO").ToString
            grdProdutos.Item(3, i).Value = ds.Tables(0).Rows.Item(i).Item("VL_VENDA").ToString
            grdProdutos.Item(4, i).Value = ds.Tables(0).Rows.Item(i).Item("QT_MINIMA").ToString
            grdProdutos.Item(5, i).Value = ds.Tables(0).Rows.Item(i).Item("QT_MAXIMA").ToString
        Next i

        limpaDadosForm()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Close()
    End Sub

    Private Sub carregaGrid()

        ds = BllProduto.pesquisaProdutos()

        grdProdutos.RowCount = ds.Tables(0).Rows.Count

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            grdProdutos.Item(0, i).Value = ds.Tables(0).Rows.Item(i).Item("CD_PRODUTO").ToString
            grdProdutos.Item(1, i).Value = ds.Tables(0).Rows.Item(i).Item("NM_PRODUTO").ToString
            grdProdutos.Item(2, i).Value = ds.Tables(0).Rows.Item(i).Item("VL_CUSTO").ToString
            grdProdutos.Item(3, i).Value = ds.Tables(0).Rows.Item(i).Item("VL_VENDA").ToString
            grdProdutos.Item(4, i).Value = ds.Tables(0).Rows.Item(i).Item("QT_MINIMA").ToString
            grdProdutos.Item(5, i).Value = ds.Tables(0).Rows.Item(i).Item("QT_MAXIMA").ToString
        Next i

        'While i <= ds.Tables(0).Rows.Count - 1

        'grdCliente.Item(0, i).Value = ds.Tables(0).Rows.Item(i).Item("Codigo").ToString
        'grdCliente.Item(1, i).Value = ds.Tables(0).Rows.Item(i).Item("Nome").ToString
        'grdCliente.Item(2, i).Value = ds.Tables(0).Rows.Item(i).Item("DtNasc").ToString
        'grdCliente.Item(3, i).Value = ds.Tables(0).Rows.Item(i).Item("Valor").ToString

        'i = i + 1

        'End While

    End Sub

    Private Sub limpaDadosForm()

        Me.txtCodigo.Clear()
        Me.txtProduto.Clear()
        Me.txtValorCusto.Clear()
        Me.txtValorVenda.Clear()
        Me.txtQuantidadeMinima.Clear()
        Me.txtQuantidadeMaxima.Clear()

    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click

        BllProduto.alteraProduto(txtCodigo.Text, txtProduto.Text, txtValorCusto.Text, txtValorVenda.Text, txtQuantidadeMinima.Text, txtQuantidadeMaxima.Text)
        carregaGrid()
        limpaDadosForm()

    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        limpaDadosForm()
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        BllProduto.incluiProduto(txtCodigo.Text, txtProduto.Text, txtValorCusto.Text, txtValorVenda.Text, txtQuantidadeMinima.Text, txtQuantidadeMaxima.Text)
        carregaGrid()
        limpaDadosForm()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        BllProduto.excluiProduto(txtCodigo.Text)
        carregaGrid()
        limpaDadosForm()
    End Sub

    Private Sub frmSCE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaGrid()
    End Sub



    Private Sub SairToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub SalvarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class