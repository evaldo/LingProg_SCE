Imports Exemplo
Imports Exemplo.Cadastro

Namespace TransacaoPedido
    Public Class Pedido

        Private IdPedido As Integer
        Private IdCliente As Integer
        Private DtPedido As Date
        Private ValorPedido As Double

        Public Sub New(ByVal prmIdCliente As Integer)

            Dim objCliente As New Cliente(prmIdCliente)

        End Sub

        Public Sub setIdPedido(ByVal prmIdPedido As Integer)

            IdPedido = prmIdPedido

        End Sub

        Public Function getIdPedido() As Integer

            Return IdPedido

        End Function

        Public Sub setDtPedido(ByVal prmDtPedido As Date)

            DtPedido = prmDtPedido

        End Sub

        Public Function getDtPedido() As Date

            Return DtPedido

        End Function

        Public Sub setValorPedido(ByVal prmValorPedido As Double)

            ValorPedido = prmValorPedido

        End Sub

        Public Function getValorPedido() As Double

            Return ValorPedido

        End Function

    End Class

End Namespace
