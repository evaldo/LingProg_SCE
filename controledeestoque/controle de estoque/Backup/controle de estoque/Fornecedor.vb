'//Projeto academico
'// Autor: Luiz Carlos de Oiveira Junior

Imports estoque

Namespace sistema
    Public Class Fornecedor : Inherits Movimentacao
        Private CD_Fornecedor As Integer
        Private NM_Fornecedor As Integer
        Private DS_Endereco As String
        Private DS_Bairro As String
        Private DS_Contado As String

        Public Sub New(ByVal prmCD_Fornecedor As Integer) 'Criação do método construtor
            Me.CD_Fornecedor(prmCD_Fornecedor')
        End Sub

        '***************************************************
        'Criação dos demais métodos
        '***************************************************
        Public Sub setCodigo(ByVal prmCodigo As Integer)
            CD_Fornecedor = prmCodigo
        End Sub

        Public Function getCodigo() As Integer
            Return CD_Fornecedor
        End Function

        Public Sub setNomef(ByVal prmNome As String)
            NM_Fornecedor = prmNome
        End Sub

        Public Sub setEndereco(ByVal prmEndereco As String)
            DS_Endereco = prmEndereco
        End Sub

        Public Function getEndereco() As String
            Return DS_Endereco
        End Function

        Public Sub setBairro(ByVal prmBairro As String)
            DS_Bairro = prmBairro
        End Sub

        Public Sub setContado(ByVal prmContado As String)
            DS_Endereco = prmContado
        End Sub

        Public Function getContado() As String
            Return DS_Contado
        End Function

    End Class
End Namespace
