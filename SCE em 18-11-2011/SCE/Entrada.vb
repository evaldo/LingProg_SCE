Imports SCE.BllSce
Public Class frmEntrada
    Dim ds As New DataSet

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click

        ds = Bll.pesquisaEntradaId(txtCodigoProduto.Text, txtCodigoFornecedor.Text, txtMatricula.Text, txtDataMovimentacao.Text, txtQuantidadeMovimentada.Text)

        grdGeral.RowCount = ds.Tables(0).Rows.Count

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            grdGeral.Item(3, i).Value = ds.Tables(0).Rows.Item(i).Item("DT_MOV").ToString
            grdGeral.Item(0, i).Value = ds.Tables(0).Rows.Item(i).Item("CD_PRODUTO1").ToString
            grdGeral.Item(1, i).Value = ds.Tables(0).Rows.Item(i).Item("CD_FORNECEDOR1").ToString
            grdGeral.Item(2, i).Value = ds.Tables(0).Rows.Item(i).Item("NU_MATRICULA").ToString
            grdGeral.Item(4, i).Value = ds.Tables(0).Rows.Item(i).Item("QT_MOV").ToString
        Next i
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Close()
    End Sub

    Private Sub grdCliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdGeral.Click

    End Sub

    Private Sub carregaGrid()

        ds = Bll.pesquisaEntrada()

        grdGeral.RowCount = ds.Tables(0).Rows.Count

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

            grdGeral.Item(0, i).Value = ds.Tables(0).Rows.Item(i).Item("CD_PRODUTO1").ToString
            grdGeral.Item(1, i).Value = ds.Tables(0).Rows.Item(i).Item("CD_FORNECEDOR1").ToString
            grdGeral.Item(2, i).Value = ds.Tables(0).Rows.Item(i).Item("NU_MATRICULA").ToString
            grdGeral.Item(3, i).Value = ds.Tables(0).Rows.Item(i).Item("DT_MOV").ToString
            grdGeral.Item(4, i).Value = ds.Tables(0).Rows.Item(i).Item("QT_MOV").ToString
        Next i


    End Sub

    Private Sub limpaDadosForm()

        Me.txtCodigoProduto.Clear()
        Me.txtCodigoFornecedor.Clear()
        Me.txtMatricula.Clear()
        Me.txtDataMovimentacao.Clear()
        Me.txtQuantidadeMovimentada.Clear()
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
    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click

        Bll.alteraEntrada(txtCodigoProduto.Text, txtCodigoFornecedor.Text, txtMatricula.Text, txtDataMovimentacao.Text, txtQuantidadeMovimentada.Text)
        carregaGrid()
        limpaDadosForm()

    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        grdGeral.Visible = True
        grdProduto.Visible = False
        grdFornecedor.Visible = False
        grdFuncionario.Visible = False
        carregaGrid()
        carregaGrid()
        limpaDadosForm()
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        ds = Bll.verificaQuantProduto(txtCodigoProduto.Text)
        If ds.Tables(0).Rows.Item(0).Item("QT_MAXIMA") >= txtQuantidadeMovimentada.Text Then
            Bll.incluiEntrada(txtCodigoProduto.Text, txtCodigoFornecedor.Text, txtMatricula.Text, txtDataMovimentacao.Text, txtQuantidadeMovimentada.Text)
            carregaGrid()
            limpaDadosForm()
        Else
            MsgBox("A quantidade deve ser inferior ou igual a quantidade maxima do produto")


        End If

        'Bll.incluiEntrada(txtCodigoProduto.Text, txtCodigoFornecedor.Text, txtMatricula.Text, txtDataMovimentacao.Text, txtQuantidadeMovimentada.Text)
        grdGeral.Visible = True
        grdProduto.Visible = False
        grdFornecedor.Visible = False
        grdFuncionario.Visible = False
        carregaGrid()

        limpaDadosForm()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Bll.excluiEntrada(txtCodigoProduto.Text)
        carregaGrid()
        limpaDadosForm()
    End Sub

    Private Sub frmSCE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        recuperarProdutos()
        recuperarFornecedores()
        recuperarMatricula()

        grdGeral.Visible = True
        grdProduto.Visible = False
        grdFornecedor.Visible = False
        grdFuncionario.Visible = False
        carregaGrid()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grdGeral.Visible = False
        grdProduto.Visible = True
        grdFornecedor.Visible = False
        grdFuncionario.Visible = False
        carregaGrid3()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grdGeral.Visible = False
        grdProduto.Visible = False
        grdFornecedor.Visible = True
        grdFuncionario.Visible = False
        carregaGrid1()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxPesquisaProduto.Click
        grdGeral.Visible = False
        grdProduto.Visible = True
        grdFornecedor.Visible = False
        grdFuncionario.Visible = False
        carregaGrid3()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxPesquisaFuncionario.Click
        grdGeral.Visible = False
        grdProduto.Visible = False
        grdFornecedor.Visible = False
        grdFuncionario.Visible = True
        carregaGrid2()
    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxPesquisaFornecedor.Click
        grdGeral.Visible = False
        grdProduto.Visible = False
        grdFornecedor.Visible = True
        grdFuncionario.Visible = False
        carregaGrid1()
    End Sub
    Public Sub recuperarProdutos()
        ds = Bll.pesquisaProdutos()
        Dim produtos As New ArrayList()

        With produtos
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                .Add(ds.Tables(0).Rows.Item(i).Item("CD_PRODUTO").ToString)
            Next i
        End With

        'txtCodigoProduto = Bll.pesquisaProdutos()

    End Sub

    Public Sub recuperarFornecedores()
        ds = Bll.pesquisaFornecedores

        Dim fornecedores As New ArrayList()

        With fornecedores
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                .Add(ds.Tables(0).Rows.Item(i).Item("CD_FORNECEDOR").ToString)
            Next i
        End With

        'txtCodigoFornecedor.DataSource = fornecedores

    End Sub

    Public Sub recuperarMatricula()
        ds = Bll.pesquisaFuncionarios()

        Dim matricula As New ArrayList()

        With matricula
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                .Add(ds.Tables(0).Rows.Item(i).Item("NU_MATRICULA").ToString)
            Next i
        End With

        ' txtMatricula.DataSource = matricula
    End Sub

End Class