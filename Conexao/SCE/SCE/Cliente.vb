Public Class Cliente

    Private strCodigo As String
    Private strNome As String

    Public Sub New(ByVal prmCodigo As String, ByVal prmNome As String)
        Me.setCodigo(prmCodigo)
        Me.setNome(prmNome)
    End Sub

    Public Sub setCodigo(ByVal prmCodigo As String)
        strCodigo = prmCodigo
    End Sub

    Public Function getCodigo() As String
        Return strCodigo
    End Function

    Public Sub setNome(ByVal prmNome As String)
        strNome = prmNome
    End Sub

    Public Function getNome() As String
        Return strNome
    End Function

End Class
