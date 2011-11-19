Imports SCE.DalSce
Namespace BllSce
    Public Class BllFornecedor
        Private Shared dal As Dal

        Public Shared Function getFornecedores(ByVal consulta As String) As DataSet
            dal = New Dal
            Return dal.GetDataSet(consulta)
        End Function
        Public Shared Function pesquisaFornecedores() As DataSet 'ByVal Valor As String) As DataSet
            Dim sql As String



            sql = "SELECT * FROM TB_FORNECEDOR;"
            ' sql = sql + ", NM_FORNECEDOR "
            ' sql = sql + ", DS_ENDERECO "
            ' sql = sql + ", DS_BAIRRO "
            ' sql = sql + ", DS_CONTATO from TB_FORNECEDOR"
            dal = New Dal
            Return dal.GetDataSet(sql)
        End Function



        Public Shared Function pesquisaFornecedoresId(ByVal CodigoFornecedor As String, ByVal NomeFornecedor As String, ByVal EnderecoFornecedor As String, ByVal BairroFornecedor As String, ByVal ContatoFornecedor As String) As DataSet  'ByVal Valor As String) As DataSet
            Dim sql As String
            If Not (CodigoFornecedor = "") Then

                sql = "SELECT * FROM TB_FORNECEDOR WHERE CD_FORNECEDOR LIKE " & CodigoFornecedor & ";"
                ' sql = sql + ", NM_FORNECEDOR "
                ' sql = sql + ", DS_ENDERECO "
                ' sql = sql + ", DS_BAIRRO "
                ' sql = sql + ", DS_CONTATO from TB_FORNECEDOR"
                dal = New Dal
                Return dal.GetDataSet(sql)
            End If
            If Not (NomeFornecedor = "") Then
                sql = "SELECT * FROM TB_FORNECEDOR WHERE NM_FORNECEDOR LIKE '" & NomeFornecedor & "';"
                ' sql = sql + ", NM_FORNECEDOR "
                ' sql = sql + ", DS_ENDERECO "
                ' sql = sql + ", DS_BAIRRO "
                ' sql = sql + ", DS_CONTATO from TB_FORNECEDOR"
                dal = New Dal
                Return dal.GetDataSet(sql)
            End If
            If Not (EnderecoFornecedor = "") Then
                sql = "SELECT * FROM TB_FORNECEDOR WHERE DS_ENDERECO LIKE '" & EnderecoFornecedor & "';"
                ' sql = sql + ", NM_FORNECEDOR "
                ' sql = sql + ", DS_ENDERECO "
                ' sql = sql + ", DS_BAIRRO "
                ' sql = sql + ", DS_CONTATO from TB_FORNECEDOR"
                dal = New Dal
                Return dal.GetDataSet(sql)
            End If
            If Not (BairroFornecedor = "") Then
                sql = "SELECT * FROM TB_FORNECEDOR WHERE DS_BAIRRO LIKE '" & BairroFornecedor & "';"
                ' sql = sql + ", NM_FORNECEDOR "
                ' sql = sql + ", DS_ENDERECO "
                ' sql = sql + ", DS_BAIRRO "
                ' sql = sql + ", DS_CONTATO from TB_FORNECEDOR"
                dal = New Dal
                Return dal.GetDataSet(sql)
            End If
            If Not (ContatoFornecedor = "") Then
                sql = "SELECT * FROM TB_FORNECEDOR WHERE DS_CONTATO LIKE '" & ContatoFornecedor & "';"
                ' sql = sql + ", NM_FORNECEDOR "
                ' sql = sql + ", DS_ENDERECO "
                ' sql = sql + ", DS_BAIRRO "
                ' sql = sql + ", DS_CONTATO from TB_FORNECEDOR"
                dal = New Dal
                Return dal.GetDataSet(sql)
            End If
            dal = New Dal
            sql = ""
            Return dal.GetDataSet(sql)
        End Function

        Public Shared Sub alteraFornecedores(ByVal CodigoFornecedor As String, ByVal NomeFornecedor As String, ByVal EnderecoFornecedor As String, ByVal BairroFornecedor As String, ByVal ContatoFornecedor As String)
            Dim sql As String

            sql = "UPDATE TB_FORNECEDOR SET "
            sql = sql + " NM_FORNECEDOR =  '" & NomeFornecedor & "'"
            sql = sql + ", DS_ENDERECO = '" & EnderecoFornecedor & "'"
            sql = sql + ", DS_BAIRRO = '" & BairroFornecedor & "'"
            sql = sql + ", DS_CONTATO ='" & ContatoFornecedor & "'"
            sql = sql + " WHERE CD_FORNECEDOR =" & CodigoFornecedor & ";"

            dal = New Dal
            dal.ExecuteComando(sql)

        End Sub

        Public Shared Sub incluiFornecedores(ByVal CodigoFornecedor As String, ByVal NomeFornecedor As String, ByVal EnderecoFornecedor As String, ByVal BairroFornecedor As String, ByVal ContatoFornecedor As String)
            Dim sql As String

            sql = "INSERT INTO TB_FORNECEDOR (CD_FORNECEDOR, NM_FORNECEDOR, DS_ENDERECO, DS_BAIRRO, DS_CONTATO) "
            sql = sql + " VALUES ("
            sql = sql + " " & CodigoFornecedor & ","
            sql = sql + " '" & NomeFornecedor & "',"
            sql = sql + " '" & EnderecoFornecedor & "',"
            sql = sql + " '" & BairroFornecedor & "',"
            sql = sql + " '" & ContatoFornecedor & "')"

            'sql = sql + " TO_DATE('" & DtNasc & "'), "
            'sql = sql + " TO_NUMBER('" & Valor & "', 'FM99990.00'));"

            dal = New Dal
            dal.ExecuteComando(sql)

        End Sub

        Public Shared Sub excluiFornecedores(ByVal CodigoFornecedor As String)
            Dim sql As String

            sql = "DELETE TB_FORNECEDOR "
            sql = sql + " WHERE CD_FORNECEDOR = " & CodigoFornecedor & ";"

            dal = New Dal
            dal.ExecuteComando(sql)

        End Sub

           End Class
End Namespace
