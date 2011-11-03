Imports SCE.BllSce

Public Class frmFornecedor

    Private Sub carregaGrid()
        Dim ds As New DataSet

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

        Dim ds As New DataSet

        ds = Bll.pesquisaFornecedoresId(txtCodigo.Text)

        grdFornecedores.RowCount = ds.Tables(0).Rows.Count

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            grdFornecedores.Item(0, i).Value = ds.Tables(0).Rows.Item(i).Item("CD_FORNECEDOR").ToString()
            grdFornecedores.Item(1, i).Value = ds.Tables(0).Rows.Item(i).Item("NM_FORNECEDOR").ToString()
            grdFornecedores.Item(2, i).Value = ds.Tables(0).Rows.Item(i).Item("DS_ENDERECO").ToString()
            grdFornecedores.Item(3, i).Value = ds.Tables(0).Rows.Item(i).Item("DS_BAIRRO").ToString()
            grdFornecedores.Item(4, i).Value = ds.Tables(0).Rows.Item(i).Item("DS_CONTATO").ToString()

        Next i

        limpaDadosForm()
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        End
    End Sub
    Private Sub limpaDadosForm()

        Me.txtCodigo.Clear()
        Me.txtFornecedor.Clear()
        Me.txtEndereco.Clear()
        Me.txtBairro.Clear()
        Me.txtContato.Clear()
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click

        Bll.alteraFornecedores(txtCodigo.Text, txtFornecedor.Text, txtEndereco.Text, txtBairro.Text, txtContato.Text)
        carregaGrid()
        limpaDadosForm()

    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        limpaDadosForm()
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Bll.incluiFornecedores(txtCodigo.Text, txtFornecedor.Text, txtEndereco.Text, txtBairro.Text, txtContato.Text)
        carregaGrid()
        limpaDadosForm()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Bll.excluiFornecedores(txtCodigo.Text)
        carregaGrid()
        limpaDadosForm()
    End Sub

    Private Sub frmSCE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaGrid()
    End Sub
End Class
