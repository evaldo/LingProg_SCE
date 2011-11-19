Imports SCE.BllSce
Public Class frmSaida

    Dim ds As New DataSet
    Private Sub frmSaida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grdGeral.Visible = True
        grdProduto.Visible = False
        grdFornecedor.Visible = False
        grdFuncionario.Visible = False
        carregaGrid()
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Bll.incluiSaida(txtCodigoProduto.Text, txtCodigoFornecedor.Text, txtMatricula.Text, txtDataMovimentacao.Text, txtQuantidadeMovimentada.Text)
        grdGeral.Visible = True
        grdProduto.Visible = False
        grdFornecedor.Visible = False
        grdFuncionario.Visible = False
        carregaGrid()
        limpaDadosForm()
    End Sub

    Private Sub carregaGrid()

        ds = Bll.pesquisaSaida()

        grdGeral.RowCount = ds.Tables(0).Rows.Count

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            grdGeral.Item(3, i).Value = ds.Tables(0).Rows.Item(i).Item("DT_MOV").ToString
            grdGeral.Item(0, i).Value = ds.Tables(0).Rows.Item(i).Item("CD_PRODUTO").ToString
            grdGeral.Item(1, i).Value = ds.Tables(0).Rows.Item(i).Item("CD_FORNECEDOR").ToString
            grdGeral.Item(2, i).Value = ds.Tables(0).Rows.Item(i).Item("NU_MATRICULA").ToString
            grdGeral.Item(4, i).Value = ds.Tables(0).Rows.Item(i).Item("QT_MOV").ToString
        Next i

        'While i <= ds.Tables(0).Rows.Count - 1

        'grdCliente.Item(0, i).Value = ds.Tables(0).Rows.Item(i).Item("Codigo").ToString
        'grdCliente.Item(1, i).Value = ds.Tables(0).Rows.Item(i).Item("Nome").ToString
        'grdCliente.Item(2, i).Value = ds.Tables(0).Rows.Item(i).Item("DtNasc").ToString
        'grdCliente.Item(3, i).Value = ds.Tables(0).Rows.Item(i).Item("Valor").ToString

        'i = i + 1

        'End While

    End Sub
    Private Sub carregaGrid1()
        Dim ds As New DataSet

        ds = Bll.pesquisaFornecedores()


        grdFornecedor.RowCount = ds.Tables(0).Rows.Count

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            grdFornecedor.Item(0, i).Value = ds.Tables(0).Rows.Item(i).Item("CD_FORNECEDOR").ToString
            grdFornecedor.Item(1, i).Value = ds.Tables(0).Rows.Item(i).Item("NM_FORNECEDOR").ToString
        Next i

    End Sub
    Private Sub carregaGrid2()
        Dim ds As New DataSet

        ds = Bll.pesquisaFuncionarios()

        grdFuncionario.RowCount = ds.Tables(0).Rows.Count

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            grdFuncionario.Item(0, i).Value = ds.Tables(0).Rows.Item(i).Item("NU_MATRICULA").ToString
            grdFuncionario.Item(1, i).Value = ds.Tables(0).Rows.Item(i).Item("NM_FUNCIONARIO").ToString
        Next i

    End Sub
    Private Sub carregaGrid3()
        Dim ds As New DataSet

        ds = Bll.pesquisaProdutos()

        grdProduto.RowCount = ds.Tables(0).Rows.Count

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            grdProduto.Item(0, i).Value = ds.Tables(0).Rows.Item(i).Item("CD_PRODUTO").ToString
            grdProduto.Item(1, i).Value = ds.Tables(0).Rows.Item(i).Item("NM_Produto").ToString
        Next i

    End Sub
    Private Sub limpaDadosForm()

        Me.txtCodigoProduto.Clear()
        Me.txtCodigoFornecedor.Clear()
        Me.txtMatricula.Clear()
        Me.txtDataMovimentacao.Clear()
        Me.txtQuantidadeMovimentada.Clear()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Bll.excluiSaida(txtCodigoProduto.Text)
        carregaGrid()
        limpaDadosForm()
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Bll.alteraSaida(txtCodigoProduto.Text, txtCodigoFornecedor.Text, txtMatricula.Text, txtDataMovimentacao.Text, txtQuantidadeMovimentada.Text)
        carregaGrid()
        limpaDadosForm()
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        ds = Bll.pesquisaSaidaId(txtCodigoProduto.Text)

        grdGeral.RowCount = ds.Tables(0).Rows.Count

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            grdGeral.Item(3, i).Value = ds.Tables(0).Rows.Item(i).Item("DT_MOV").ToString
            grdGeral.Item(0, i).Value = ds.Tables(0).Rows.Item(i).Item("CD_PRODUTO").ToString
            grdGeral.Item(1, i).Value = ds.Tables(0).Rows.Item(i).Item("CD_FORNECEDOR").ToString
            grdGeral.Item(2, i).Value = ds.Tables(0).Rows.Item(i).Item("NU_MATRICULA").ToString
            grdGeral.Item(4, i).Value = ds.Tables(0).Rows.Item(i).Item("QT_MOV").ToString
        Next i

        limpaDadosForm()
    End Sub

   

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Close()
    End Sub

    Private Sub pbxPesquisaProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxPesquisaProduto.Click
        grdGeral.Visible = False
        grdProduto.Visible = True
        grdFornecedor.Visible = False
        grdFuncionario.Visible = False
        carregaGrid3()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        grdGeral.Visible = False
        grdProduto.Visible = False
        grdFornecedor.Visible = True
        grdFuncionario.Visible = False
        carregaGrid1()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        grdGeral.Visible = False
        grdProduto.Visible = False
        grdFornecedor.Visible = False
        grdFuncionario.Visible = True
        carregaGrid2()
    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        limpaDadosForm()
        grdGeral.Visible = True
        grdProduto.Visible = False
        grdFornecedor.Visible = False
        grdFuncionario.Visible = False
        carregaGrid()
    End Sub
End Class