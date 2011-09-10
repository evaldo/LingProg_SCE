'***************************************************
'Classe Cadastro da Aplicação Exemplo
'Autor: Evaldo de Oliveira
'Data de Criação: 10/09/2011
'***************************************************

Imports Exemplo
'***************************************************
'Criação do Namespace Cadastro
'***************************************************
Namespace Cadastro
    Public Class Cliente : Inherits Pessoa 'Herança da classe Pessoa
        '***************************************************
        'Criação dos atributos da classe Cliente
        '***************************************************
        Private IdCodigo As Integer
        Private Nome As String
        Private ValorUltimoPedido As Double
        '***************************************************
        'Criação do método construtor
        '***************************************************
        Public Sub New(ByVal prmIdCodigo As Integer)

            Me.setCodigo(prmIdCodigo)

        End Sub
        '***************************************************
        'Criação dos demais métodos
        '***************************************************
        Public Sub setCodigo(ByVal prmCodigo As Integer)

            IdCodigo = prmCodigo

        End Sub

        Public Function getCodigo() As Integer

            Return IdCodigo

        End Function

        Public Sub setNome(ByVal prmNome As String)

            Nome = prmNome

        End Sub

        Public Function getNome() As String

            Return Nome

        End Function

        Public Sub setValorUltimoPedido(ByVal prmValorUltimoPedido As Double)

            ValorUltimoPedido = prmValorUltimoPedido

        End Sub

        Public Function getValorUltimoPedido() As Double

            Return ValorUltimoPedido

        End Function

    End Class

End Namespace
