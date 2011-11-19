Imports SCE.DalSce
Namespace BllSce
    Public Class BllSaida
        Private Shared dal As Dal

        '********************************-----TB_MOV_SAIDA-----***********************************

        Public Shared Function getSaida(ByVal consulta As String) As DataSet
            dal = New Dal
            Return dal.GetDataSet(consulta)
        End Function

        Public Shared Function pesquisaSaida() As DataSet 'ByVal Valor As String) As DataSet
            Dim sql As String

            sql = "SELECT CD_PRODUTO "
            sql = sql + ", CD_FORNECEDOR "
            sql = sql + ", NU_MATRICULA "
            sql = sql + ", TO_CHAR(DT_MOV, 'DD/MM/YYYY') DT_MOV"
            sql = sql + ", TO_CHAR(QT_MOV, 'FM99990.00') QT_MOV From TB_MOV_SAIDA;"
            dal = New Dal
            Return dal.GetDataSet(sql)
        End Function

        Public Shared Sub alteraSaida(ByVal CodigoProduto As String, ByVal CodigoFornecedor As String, ByVal Matricula As String, ByVal DataMovimentacao As String, ByVal QuantidadeMovimentada As String)
            Dim sql As String

            sql = "UPDATE TB_MOV_SAIDA SET "
            sql = sql + " CD_FORNECEDOR = TO_NUMBER(" & CodigoFornecedor & ",'FM99990.00')"
            sql = sql + ", NU_MATRICULA =  TO_NUMBER(" & Matricula & ",'FM99990.00')"
            sql = sql + ", DT_MOV = TO_DATE('" & DataMovimentacao & "', 'DD/MM/YYYY') "
            sql = sql + ", QT_MOV = TO_NUMBER(" & QuantidadeMovimentada & ")"
            sql = sql + " WHERE CD_PRODUTO = TO_NUMBER(" & CodigoProduto & ",'FM99990.00');"

            dal = New Dal

            dal.ExecuteComando(sql)

        End Sub

        Public Shared Sub incluiSaida(ByVal CodigoProduto As String, ByVal CodigoFornecedor As String, ByVal Matricula As String, ByVal DataMovimentacao As String, ByVal QuantidadeMovimentada As String)
            Dim sql As String

            sql = "INSERT INTO TB_MOV_SAIDA (CD_PRODUTO, CD_FORNECEDOR, NU_MATRICULA, DT_MOV, QT_MOV) "
            sql = sql + " VALUES ("
            sql = sql + " " & CodigoProduto & ","
            sql = sql + " " & CodigoFornecedor & ","
            sql = sql + " " & Matricula & ","
            sql = sql + " TO_DATE('" & DataMovimentacao & "'), "
            sql = sql + " TO_NUMBER('" & QuantidadeMovimentada & "', 'FM99990.00'));"

            dal = New Dal

            dal.ExecuteComando(sql)

        End Sub
        Public Shared Function pesquisaSaidaId(ByVal CodigoProduto As String) As DataSet 'ByVal Valor As String) As DataSet
            Dim sql As String

            sql = "SELECT * FROM TB_MOV_SAIDA WHERE CD_PRODUTO LIKE '" & CodigoProduto & "';"

            dal = New Dal
            Return dal.GetDataSet(sql)
        End Function

        Public Shared Sub excluiSaida(ByVal CodigoProduto As String)
            Dim sql As String

            sql = "DELETE TB_MOV_SAIDA "
            sql = sql + " WHERE CD_PRODUTO = " & CodigoProduto & ";"

            dal = New Dal

            dal.ExecuteComando(sql)

        End Sub

    End Class
End Namespace
