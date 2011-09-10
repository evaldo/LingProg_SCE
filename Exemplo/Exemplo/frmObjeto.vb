Imports Exemplo.Cadastro
Imports Exemplo.TransacaoPedido
Public Class frmObjeto

    Dim objCliente As Cliente
    Dim objPedido As Pedido

    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click

        '*************************************************************
        'Instacia um Cliente
        '*************************************************************
        objCliente = New Cliente(1)
        objCliente.setNome("Evaldo de Oliveira")
        objCliente.setEndereco("Rua Jovino Ribeiro, XX APTO YYYY, Bairro: XPTO, Juiz de Fora - MG")
        '*************************************************************
        'Instacia um Pedido para o Cliente
        '*************************************************************
        objPedido = New Pedido(objCliente.getCodigo())
        objPedido.setIdPedido(12345)
        objPedido.setDtPedido("10/09/2011")
        objPedido.setValorPedido(4500.85)
        objCliente.setValorUltimoPedido(objPedido.getValorPedido)
        '*************************************************************
        'Adiciona o cliente no ComboBox
        '*************************************************************
        cmbNome.Items.Add(objCliente.getNome())
        
    End Sub

    Private Sub btnGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGet.Click

        MsgBox("Pedido Cadastrado para o cliente :" & Chr(13) & _
               "____________________________________________________________________" & Chr(13) & _
               "Código      : " + objCliente.getCodigo().ToString + "" & Chr(13) & _
               "Nome        : " + objCliente.getNome() + "" & Chr(13) & _
               "Endereço    : " + objCliente.getEndereco() + "" & Chr(13) & _
               "____________________________________________________________________" & Chr(13) & _
               "Pedido Nº   : " + objPedido.getIdPedido().ToString + "" & Chr(13) & _
               "Data        : " + objPedido.getDtPedido().ToString + "" & Chr(13) & _
               "Valor       : " + objPedido.getValorPedido().ToString, MsgBoxStyle.Information)
        
    End Sub
End Class
