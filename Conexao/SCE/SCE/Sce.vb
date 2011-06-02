Imports SCE.BllSce

Public Class frmSCE

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        carregaGrid()
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        End
    End Sub

    Private Sub grdCliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdCliente.Click

        Dim intLinha As Integer

        intLinha = grdCliente.CurrentRow.Index

        Me.txtCodigo.Text = grdCliente.Item(0, intLinha).Value
        Me.txtNome.Text = grdCliente.Item(1, intLinha).Value
        Me.mskDtNasc.Text = grdCliente.Item(2, intLinha).Value
        Me.txtValor.Text = grdCliente.Item(3, intLinha).Value

    End Sub

    Private Sub carregaGrid()
        Dim ds As New DataSet

        ds = Bll.pesquisaClientes()

        grdCliente.RowCount = ds.Tables(0).Rows.Count

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            grdCliente.Item(0, i).Value = ds.Tables(0).Rows.Item(i).Item("Codigo").ToString
            grdCliente.Item(1, i).Value = ds.Tables(0).Rows.Item(i).Item("Nome").ToString
            grdCliente.Item(2, i).Value = ds.Tables(0).Rows.Item(i).Item("DtNasc").ToString
            grdCliente.Item(3, i).Value = ds.Tables(0).Rows.Item(i).Item("Valor").ToString
        Next i
    End Sub

    Private Sub limpaDadosForm()

        Me.txtCodigo.Clear()
        Me.txtNome.Clear()
        Me.mskDtNasc.Clear()
        Me.txtValor.Clear()

    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click

        Bll.alteraClientes(txtCodigo.Text, txtNome.Text, mskDtNasc.Text, txtValor.Text)
        carregaGrid()
        limpaDadosForm()

    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        limpaDadosForm()
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Bll.incluiClientes(txtCodigo.Text, txtNome.Text, mskDtNasc.Text, txtValor.Text)
        carregaGrid()
        limpaDadosForm()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Bll.excluiClientes(txtCodigo.Text)
        carregaGrid()
        limpaDadosForm()
    End Sub

    Private Sub frmSCE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaGrid()
    End Sub
End Class
