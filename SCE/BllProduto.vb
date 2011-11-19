Imports SCE.DalSce
Namespace BllSce
    Public Class BllProduto
        Private Shared dal As Dal

        '********************************************-----TB_PRODUTO-----***********************************
        Public Shared Function getProdutos(ByVal consulta As String) As DataSet
            dal = New Dal
            Return dal.GetDataSet(consulta)
        End Function
        Public Shared Function pesquisaProdutos() As DataSet 'ByVal Valor As String) As DataSet
            Dim sql As String

            sql = "SELECT CD_PRODUTO "
            sql = sql + ", NM_PRODUTO"
            sql = sql + ", VL_CUSTO "
            sql = sql + ", VL_VENDA "
            sql = sql + ", QT_MINIMA"
            sql = sql + ", QT_MAXIMA from TB_PRODUTO"
            dal = New Dal
            Return dal.GetDataSet(sql)
        End Function

        Public Shared Sub alteraProduto(ByVal CodigoProduto As String, ByVal NomeProduto As String, ByVal ValorCusto As String, ByVal ValorVenda As String, ByVal QuantidadeMinima As String, ByVal QuantidadeMaxima As String)
            Dim sql As String

            sql = "UPDATE TB_PRODUTO SET "
            sql = sql + " NM_PRODUTO =  '" & NomeProduto & "'"
            sql = sql + ", VL_CUSTO = TO_NUMBER(" & ValorCusto & ",'FM99990.00')"
            sql = sql + ", VL_VENDA = TO_NUMBER(" & ValorVenda & ",'FM99990.00')"
            sql = sql + ", QT_MINIMA = TO_NUMBER(" & QuantidadeMinima & ",'FM99990.00')"
            sql = sql + ", QT_MAXIMA = TO_NUMBER(" & QuantidadeMaxima & ",'FM99990.00')"
            sql = sql + " WHERE CD_PRODUTO = " & CodigoProduto & ";"

            dal = New Dal
            dal.ExecuteComando(sql)

        End Sub

        Public Shared Sub incluiProduto(ByVal CodigoProduto As String, ByVal NomeProduto As String, ByVal ValorCusto As String, ByVal ValorVenda As String, ByVal QuantidadeMinima As String, ByVal QuantidadeMaxima As String)
            Dim sql As String

            sql = "INSERT INTO TB_PRODUTO (CD_PRODUTO, NM_PRODUTO, VL_CUSTO, VL_VENDA, QT_MINIMA, QT_MAXIMA) "
            sql = sql + " VALUES ("
            sql = sql + " " & CodigoProduto & ","
            sql = sql + " '" & NomeProduto & "',"
            sql = sql + " '" & ValorCusto & "',"
            sql = sql + " '" & ValorVenda & "',"
            sql = sql + " '" & QuantidadeMinima & "',"
            sql = sql + " '" & CodigoProduto & "');"

            dal = New Dal
            dal.ExecuteComando(sql)

        End Sub

        Public Shared Sub excluiProduto(ByVal CodigoProduto As String)
            Dim sql As String

            sql = "DELETE FROM TB_PRODUTO WHERE CD_PRODUTO = " & CodigoProduto & ";"

            dal = New Dal
            dal.ExecuteComando(sql)

        End Sub

        Public Shared Function pesquisaProdutoId(ByVal CodigoProduto As String, ByVal NomeProduto As String, ByVal ValorCusto As String, ByVal ValorVenda As String, ByVal QuantidadeMinima As String, ByVal QuantidadeMaxima As String) As DataSet  'ByVal Valor As String) As DataSet
            Dim sql As String

            sql = "SELECT * FROM TB_PRODUTO WHERE CD_PRODUTO = " & CodigoProduto & ";"
            If Not (CodigoProduto = "") Then

                sql = "SELECT * FROM TB_PRODUTO WHERE CD_PRODUTO LIKE " & CodigoProduto & ";"

                dal = New Dal
                Return dal.GetDataSet(sql)
            End If
            If Not (NomeProduto = "") Then
                sql = "SELECT * FROM TB_PRODUTO WHERE NM_PRODUTO LIKE '" & NomeProduto & "';"

                dal = New Dal
                Return dal.GetDataSet(sql)
            End If
            If Not (ValorCusto = "") Then
                sql = "SELECT * FROM TB_PRODUTO WHERE VL_CUSTO LIKE '" & ValorCusto & "';"

                dal = New Dal
                Return dal.GetDataSet(sql)
            End If
            If Not (ValorVenda = "") Then
                sql = "SELECT * FROM TB_PRODUTO WHERE VL_VENDA LIKE '" & ValorVenda & "';"

                dal = New Dal
                Return dal.GetDataSet(sql)
            End If

            If Not (QuantidadeMinima = "") Then
                sql = "SELECT * FROM TB_PRODUTO WHERE QT_MINIMA LIKE '" & QuantidadeMinima & "';"

                dal = New Dal
                Return dal.GetDataSet(sql)
            End If
            If Not (QuantidadeMaxima = "") Then
                sql = "SELECT * FROM TB_PRODUTO WHERE QT_MAXIMA LIKE '" & QuantidadeMaxima & "';"

                dal = New Dal
                Return dal.GetDataSet(sql)
            End If
            dal = New Dal
            sql = ""
            Return dal.GetDataSet(sql)
        End Function
        Public Shared Function verificaQuantProduto(ByVal CodigoProduto As String) As DataSet
            Dim sql As String

            sql = "SELECT * FROM TB_PRODUTO WHERE CD_PRODUTO = " & CodigoProduto & ";"
            ' sql = sql + ", NM_FORNECEDOR "
            ' sql = sql + ", DS_ENDERECO "
            ' sql = sql + ", DS_BAIRRO "
            ' sql = sql + ", DS_CONTATO from TB_FORNECEDOR"
            dal = New Dal
            Return dal.GetDataSet(sql)
        End Function

    End Class
End Namespace
