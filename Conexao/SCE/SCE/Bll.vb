Imports SCE.DalSce

Namespace BllSce
    Public Class Bll

        Private Shared dal As Dal

        Public Shared Function getClientes(ByVal consulta As String) As DataSet
            dal = New Dal
            Return dal.GetDataSet(consulta)
        End Function

        Public Shared Function pesquisaClientes() As DataSet 'ByVal Valor As String) As DataSet
            Dim sql As String

            sql = "SELECT CODIGO "
            sql = sql + ", NOME "
            sql = sql + ", TO_CHAR(DTNASC, 'DD/MM/YYYY') DTNASC"
            sql = sql + ", TO_CHAR(VALOR, 'FM99990.00') VALOR From cliente;"
            dal = New Dal
            Return dal.GetDataSet(sql)
        End Function

        Public Shared Sub alteraClientes(ByVal Codigo As String, ByVal Nome As String, ByVal DtNasc As String, ByVal Valor As String)
            Dim sql As String

            sql = "UPDATE CLIENTE SET "
            sql = sql + " NOME =  '" & Nome & "'"
            sql = sql + ", DTNASC = TO_DATE('" & DtNasc & "', 'DD/MM/YYYY') "
            sql = sql + ", VALOR = TO_NUMBER(" & Valor & ")"
            sql = sql + " WHERE CODIGO = " & Codigo & ";"

            dal = New Dal

            dal.ExecuteComando(sql)

        End Sub

        Public Shared Sub incluiClientes(ByVal Codigo As String, ByVal Nome As String, ByVal DtNasc As String, ByVal Valor As String)
            Dim sql As String

            sql = "INSERT INTO CLIENTE (CODIGO, NOME, DTNASC, VALOR) "
            sql = sql + " VALUES ("
            sql = sql + " " & Codigo & ","
            sql = sql + " '" & Nome & "',"
            sql = sql + " TO_DATE('" & DtNasc & "'), "
            sql = sql + " TO_NUMBER('" & Valor & "', 'FM99990.00'));"

            dal = New Dal

            dal.ExecuteComando(sql)

        End Sub

        Public Shared Sub excluiClientes(ByVal Codigo As String)
            Dim sql As String

            sql = "DELETE CLIENTE "
            sql = sql + " WHERE CODIGO = " & Codigo & ";"

            dal = New Dal

            dal.ExecuteComando(sql)

        End Sub

    End Class
End Namespace
