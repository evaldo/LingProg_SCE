Imports estoque

Namespace sistema
    Public Class Funcionario : Inherits Movimentacao
        Private IdFuncionario As Integer
        Private nome As String
        Private endereco As String
        Private telefoneResidencial As String
        Private telefoneCelular As String
        Private cargo As String
        Private salario As String

        Public Sub New(ByVal prmIdCodigo As Integer) 'Criação do método construtor
            Me.IdFuncionario(prmIdCodigo)
        End Sub

        '***************************************************
        'Criação dos demais métodos
        '***************************************************
        Public Sub setCodigo(ByVal prmCodigo As Integer)
            IdFuncionario = prmCodigo
        End Sub

        Public Function getCodigo() As Integer
            Return IdFuncionario()
        End Function

        Public Sub setNome(ByVal prmNome As Integer)
            nome = prmNome
        End Sub

        Public Function getNome() As Integer
            Return nome
        End Function

        Public Sub setEndereco(ByVal prmEndereco As Integer)
            endereco = prmEndereco
        End Sub

        Public Function getEndereco() As Integer
            Return endereco
        End Function

        Public Sub setTelefone(ByVal prmTelefone As Integer)
            telefoneResidencial = prmTelefone
        End Sub

        Public Function getTelefone() As Integer
            Return telefoneResidencial
        End Function

        Public Sub setCelular(ByVal prmCelular As Integer)
            telefoneCelular = prmCelular
        End Sub

        Public Function getCelular() As Integer
            Return telefoneCelular
        End Function

        Public Sub setCargo(ByVal prmCargo As Integer)
            cargo = prmCargo
        End Sub

        Public Function getCargo() As Integer
            Return cargo
        End Function

        Public Sub setSalario(ByVal prmSalario As Integer)
            salario = prmSalario
        End Sub

        Public Function getSalario() As Integer
            Return salario
        End Function

    End Class
End Namespace