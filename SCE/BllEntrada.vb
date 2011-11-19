Imports SCE.DalSce
Namespace BllSce
    Public Class BllEntrada
        Private Shared dal As Dal

        '********************************************-----TB_MOV_ENTRADA-----***********************************

        Public Shared Function getEntrada(ByVal consulta As String) As DataSet
            dal = New Dal
            Return dal.GetDataSet(consulta)
        End Function

        Public Shared Function pesquisaEntrada() As DataSet 'ByVal Valor As String) As DataSet
            Dim sql As String

            sql = "SELECT CD_PRODUTO1 "
            sql = sql + ", CD_FORNECEDOR1 "
            sql = sql + ", NU_MATRICULA "
            sql = sql + ", TO_CHAR(DT_MOV, 'DD/MM/YYYY') DT_MOV"
            sql = sql + ", TO_CHAR(QT_MOV, 'FM99990.00') QT_MOV From TB_MOV_ENTRADA;"
            dal = New Dal
            Return dal.GetDataSet(sql)
        End Function

        Public Shared Sub alteraEntrada(ByVal CodigoProduto As String, ByVal CodigoFornecedor As String, ByVal Matricula As String, ByVal DataMovimentacao As String, ByVal QuantidadeMovimentada As String)
            Dim sql As String

            sql = "UPDATE TB_MOV_ENTRADA SET "
            sql = sql + " CD_FORNECEDOR1 =  '" & CodigoFornecedor & "'"
            sql = sql + " NU_MATRICULA =  '" & Matricula & "'"
            sql = sql + ", DT_MOV = TO_DATE('" & DataMovimentacao & "', 'DD/MM/YYYY') "
            sql = sql + ", QT_MOV = TO_NUMBER(" & QuantidadeMovimentada & ")"
            sql = sql + " WHERE CD_PRODUTO1 = " & CodigoProduto & ";"

            dal = New Dal

            dal.ExecuteComando(sql)

        End Sub

        Public Shared Sub incluiEntrada(ByVal CodigoProduto As String, ByVal CodigoFornecedor As String, ByVal Matricula As String, ByVal DataMovimentacao As String, ByVal QuantidadeMovimentada As String)
            Dim sql As String

            sql = "INSERT INTO TB_MOV_ENTRADA (CD_PRODUTO1, CD_FORNECEDOR1, NU_MATRICULA, DT_MOV, QT_MOV) "
            sql = sql + " VALUES ("
            sql = sql + " " & CodigoProduto & ","
            sql = sql + " '" & CodigoFornecedor & "',"
            sql = sql + " '" & Matricula & "',"
            sql = sql + " TO_DATE('" & DataMovimentacao & "'), "
            sql = sql + " TO_NUMBER('" & QuantidadeMovimentada & "', 'FM99990.00'));"

            dal = New Dal

            dal.ExecuteComando(sql)

        End Sub

        Public Shared Sub excluiEntrada(ByVal CodigoProduto As String)
            Dim sql As String

            sql = "DELETE TB_MOV_ENTRADA "
            sql = sql + " WHERE CD_PRODUTO1 = " & CodigoProduto & ";"

            dal = New Dal

            dal.ExecuteComando(sql)

        End Sub

        Public Shared Function pesquisaEntradaId(ByVal CodigoFornecedor As String, ByVal CodigoProduto As String, ByVal MatriculaFuncionario As String, ByVal DataMovimentacao As String, ByVal QuantidadeMovimentada As String) As DataSet  'ByVal Valor As String) As DataSet
            Dim sql As String
            If Not (CodigoFornecedor = "") Then
                sql = "SELECT * FROM TB_FORNECEDOR WHERE CD_FORNECEDOR like " & CodigoFornecedor & ";"
                ' sql = sql + ", NM_FORNECEDOR "
                ' sql = sql + ", DS_ENDERECO "
                ' sql = sql + ", DS_BAIRRO "
                ' sql = sql + ", DS_CONTATO from TB_FORNECEDOR"
                dal = New Dal
                Return dal.GetDataSet(sql)
            End If

            sql = "SELECT * FROM TB_FORNECEDOR WHERE CD_FORNECEDOR like " & CodigoFornecedor & ";"
            ' sql = sql + ", NM_FORNECEDOR "
            ' sql = sql + ", DS_ENDERECO "
            ' sql = sql + ", DS_BAIRRO "
            ' sql = sql + ", DS_CONTATO from TB_FORNECEDOR"
            dal = New Dal
            Return dal.GetDataSet(sql)
        End Function
    End Class
End Namespace
