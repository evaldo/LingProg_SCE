Imports SCE.BllSce

Public Class frmFornecedor

    Dim ds As New DataSet

    Private Sub carregaGrid()

        ds = Bll.pesquisaFornecedores()

        grdFornecedores.RowCount = ds.Tables(0).Rows.Count

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            grdFornecedores.Item(0, i).Value = ds.Tables(0).Rows.Item(i).Item("CD_FORNECEDOR").ToString
            grdFornecedores.Item(1, i).Value = ds.Tables(0).Rows.Item(i).Item("NM_FORNECEDOR").ToString
            grdFornecedores.Item(2, i).Value = ds.Tables(0).Rows.Item(i).Item("DS_ENDERECO").ToString
            grdFornecedores.Item(3, i).Value = ds.Tables(0).Rows.Item(i).Item("DS_BAIRRO").ToString
            grdFornecedores.Item(4, i).Value = ds.Tables(0).Rows.Item(i).Item("DS_CONTATO").ToString
        Next i

        'While i <= ds.Tables(0).Rows.Count - 1

        'grdCliente.Item(0, i).Value = ds.Tables(0).Rows.Item(i).Item("Codigo").ToString
        'grdCliente.Item(1, i).Value = ds.Tables(0).Rows.Item(i).Item("Nome").ToString
        'grdCliente.Item(2, i).Value = ds.Tables(0).Rows.Item(i).Item("DtNasc").ToString
        'grdCliente.Item(3, i).Value = ds.Tables(0).Rows.Item(i).Item("Valor").ToString

        'i = i + 1

        'End While

    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        If txtBairro.Text = "" Or txtCodigo.Text = "" Or txtContato.Text = "" Or txtEndereco.Text = "" Or txtFornecedor.Text = "" Then
            ds = Bll.pesquisaFornecedoresId(txtCodigo.Text, txtFornecedor.Text, txtEndereco.Text, txtBairro.Text, txtContato.Text)

            grdFornecedores.RowCount = ds.Tables(0).Rows.Count

            If grdFornecedores.RowCount = 0 Then
                MsgBox("Não foi possivel localizar!")
            End If

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                grdFornecedores.Item(0, i).Value = ds.Tables(0).Rows.Item(i).Item("CD_FORNECEDOR").ToString()
                grdFornecedores.Item(1, i).Value = ds.Tables(0).Rows.Item(i).Item("NM_FORNECEDOR").ToString()
                grdFornecedores.Item(2, i).Value = ds.Tables(0).Rows.Item(i).Item("DS_ENDERECO").ToString()
                grdFornecedores.Item(3, i).Value = ds.Tables(0).Rows.Item(i).Item("DS_BAIRRO").ToString()
                grdFornecedores.Item(4, i).Value = ds.Tables(0).Rows.Item(i).Item("DS_CONTATO").ToString()

            Next i

            limpaDadosForm()

        Else
            MsgBox("Por favor antes de consultar informe algum dado em qualquer campo")
        End If
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Close()
    End Sub
    Private Sub limpaDadosForm()

        Me.txtCodigo.Clear()
        Me.txtFornecedor.Clear()
        Me.txtEndereco.Clear()
        Me.txtBairro.Clear()
        Me.txtContato.Clear()
    End Sub

    Public Function validar() As Boolean
        If Me.txtCodigo.Text = "" Then
            Return False

        ElseIf Me.txtContato.Text = "" Then

            Return False

        ElseIf Me.txtEndereco.Text = "" Then

            Return False

        ElseIf Me.txtBairro.Text = "" Then

            Return False


        ElseIf Me.txtFornecedor.Text = "" Then

            Return False

        Else
            Return True

        End If

    End Function


    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        If validar() = True Then

            Bll.alteraFornecedores(txtCodigo.Text, txtFornecedor.Text, txtEndereco.Text, txtBairro.Text, txtContato.Text)
            carregaGrid()
            limpaDadosForm()
        Else
            MsgBox("Preencha todos os campos do formulario")
        End If

    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        limpaDadosForm()
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        If validar() = True And Not (txtCodigo.Text = ds.Tables(0).Rows.Item(0).Item("CD_FORNECEDOR").ToString) Then
            Bll.incluiFornecedores(txtCodigo.Text, txtFornecedor.Text, txtEndereco.Text, txtBairro.Text, txtContato.Text)
            carregaGrid()
            limpaDadosForm()
        Else
            MsgBox("Preencha campos do formulario corretamente")
        End If
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If Not (Me.txtCodigo.Text = "") Then
            Bll.excluiFornecedores(txtCodigo.Text)
            carregaGrid()
            limpaDadosForm()
        Else
            MsgBox("Preencha o campo Codigo")
        End If
    End Sub

    Private Sub frmSCE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaGrid()
    End Sub


    Private Sub TelaDeFornecedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Show()

    End Sub

    Private Sub TelaDeProdutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmProduto.Show()
    End Sub

    Private Sub TelaDeFuncionarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmFuncionario.Show()
    End Sub

    Private Sub TelaDeEntradaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmEntrada.Show()
    End Sub

    Private Sub TelaDeSaidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSaida.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmImpressaoFornecedor.Show()

    End Sub

    Private Sub ProdutosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmImpressaoProduto.Show()
    End Sub
End Class
