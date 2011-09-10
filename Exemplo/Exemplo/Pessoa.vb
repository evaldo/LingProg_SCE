Imports Exemplo

Namespace Cadastro
    Public Class Pessoa

        Private Endereco As String

        Public Sub setEndereco(ByVal prmEndereco As String)

            Endereco = prmEndereco

        End Sub

        Public Function getEndereco() As String

            Return Endereco

        End Function

    End Class
End Namespace
