Imports SCE.BllSce

Public Class frmFuncionario

    Dim ds As New DataSet

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        ds = BllFuncionario.pesquisaFuncionariosId(txtMatricula.Text, txtFuncionario.Text, txtEndereco.Text, txtBairro.Text, txtTelefoneResidencial.Text, txtTelefoneCelular.Text, txtCargo.Text, txtValorSalario.Text)

        grdFuncionarios.RowCount = ds.Tables(0).Rows.Count

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            grdFuncionarios.Item(0, i).Value = ds.Tables(0).Rows.Item(i).Item("NU_MATRICULA").ToString
            grdFuncionarios.Item(1, i).Value = ds.Tables(0).Rows.Item(i).Item("NM_FUNCIONARIO").ToString
            grdFuncionarios.Item(2, i).Value = ds.Tables(0).Rows.Item(i).Item("DS_ENDERECO").ToString
            grdFuncionarios.Item(3, i).Value = ds.Tables(0).Rows.Item(i).Item("DS_BAIRRO").ToString
            grdFuncionarios.Item(4, i).Value = ds.Tables(0).Rows.Item(i).Item("NU_TELEFONE_RES").ToString
            grdFuncionarios.Item(5, i).Value = ds.Tables(0).Rows.Item(i).Item("NU_TELEFONE_CEL").ToString
            grdFuncionarios.Item(6, i).Value = ds.Tables(0).Rows.Item(i).Item("DS_CARGO").ToString
            grdFuncionarios.Item(7, i).Value = ds.Tables(0).Rows.Item(i).Item("VL_SALARIO").ToString
        Next i

        limpaDadosForm()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Close()
    End Sub

    Private Sub grdCliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdFuncionarios.Click

    End Sub

    Private Sub carregaGrid()


        ds = BllFuncionario.pesquisaFuncionarios()

        grdFuncionarios.RowCount = ds.Tables(0).Rows.Count

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            grdFuncionarios.Item(0, i).Value = ds.Tables(0).Rows.Item(i).Item("NU_MATRICULA").ToString
            grdFuncionarios.Item(1, i).Value = ds.Tables(0).Rows.Item(i).Item("NM_FUNCIONARIO").ToString
            grdFuncionarios.Item(2, i).Value = ds.Tables(0).Rows.Item(i).Item("DS_ENDERECO").ToString
            grdFuncionarios.Item(3, i).Value = ds.Tables(0).Rows.Item(i).Item("DS_BAIRRO").ToString
            grdFuncionarios.Item(4, i).Value = ds.Tables(0).Rows.Item(i).Item("NU_TELEFONE_RES").ToString
            grdFuncionarios.Item(5, i).Value = ds.Tables(0).Rows.Item(i).Item("NU_TELEFONE_CEL").ToString
            grdFuncionarios.Item(6, i).Value = ds.Tables(0).Rows.Item(i).Item("DS_CARGO").ToString
            grdFuncionarios.Item(7, i).Value = ds.Tables(0).Rows.Item(i).Item("VL_SALARIO").ToString
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

        Me.txtMatricula.Clear()
        Me.txtFuncionario.Clear()
        Me.txtEndereco.Clear()
        Me.txtBairro.Clear()
        Me.txtTelefoneResidencial.Clear()
        Me.txtTelefoneCelular.Clear()
        Me.txtCargo.Clear()
        Me.txtValorSalario.Clear()
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click

        BllFuncionario.alteraFuncionarios(txtMatricula.Text, txtFuncionario.Text, txtEndereco.Text, txtBairro.Text, txtTelefoneResidencial.Text, txtTelefoneCelular.Text, txtCargo.Text, txtValorSalario.Text)
        carregaGrid()
        limpaDadosForm()

    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        limpaDadosForm()
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        BllFuncionario.incluiFuncionarios(txtMatricula.Text, txtFuncionario.Text, txtEndereco.Text, txtBairro.Text, txtTelefoneResidencial.Text, txtTelefoneCelular.Text, txtCargo.Text, txtValorSalario.Text)
        carregaGrid()
        limpaDadosForm()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        BllFuncionario.excluiFuncionarios(txtMatricula.Text)
        carregaGrid()
        limpaDadosForm()
    End Sub

    Private Sub frmSCE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaGrid()
    End Sub


End Class
