Imports SCE.DalSce
Namespace BllSce
    Public Class Bll
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

        

        Public Shared Function pesquisaFornecedoresId(ByVal CodigoFornecedor As String) As DataSet  'ByVal Valor As String) As DataSet
            Dim sql As String

            sql = "SELECT * FROM TB_FORNECEDOR WHERE CD_FORNECEDOR=" & CodigoFornecedor & ";"
            ' sql = sql + ", NM_FORNECEDOR "
            ' sql = sql + ", DS_ENDERECO "
            ' sql = sql + ", DS_BAIRRO "
            ' sql = sql + ", DS_CONTATO from TB_FORNECEDOR"
            dal = New Dal
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
            sql = sql + " CD_FORNECEDOR =  '" & CodigoFornecedor & "'"
            sql = sql + " NU_MATRICULA =  '" & Matricula & "'"
            sql = sql + ", DT_MOV = TO_DATE('" & DataMovimentacao & "', 'DD/MM/YYYY') "
            sql = sql + ", QT_MOV = TO_NUMBER(" & QuantidadeMovimentada & ")"
            sql = sql + " WHERE CD_PRODUTO = " & CodigoProduto & ";"

            dal = New Dal

            dal.ExecuteComando(sql)

        End Sub

        Public Shared Sub incluiSaida(ByVal CodigoProduto As String, ByVal CodigoFornecedor As String, ByVal Matricula As String, ByVal DataMovimentacao As String, ByVal QuantidadeMovimentada As String)
            Dim sql As String

            sql = "INSERT INTO TB_MOV_SAIDA (CD_PRODUTO, CD_FORNECEDOR, NU_MATRICULA, DT_MOV, QT_MOV) "
            sql = sql + " VALUES ("
            sql = sql + " " & CodigoProduto & ","
            sql = sql + " '" & CodigoFornecedor & "',"
            sql = sql + " '" & Matricula & "',"
            sql = sql + " TO_DATE('" & DataMovimentacao & "'), "
            sql = sql + " TO_NUMBER('" & QuantidadeMovimentada & "', 'FM99990.00'));"

            dal = New Dal

            dal.ExecuteComando(sql)

        End Sub

        Public Shared Sub excluiSaida(ByVal CodigoProduto As String)
            Dim sql As String

            sql = "DELETE TB_MOV_SAIDA "
            sql = sql + " WHERE CD_PRODUTO = " & CodigoProduto & ";"

            dal = New Dal

            dal.ExecuteComando(sql)

        End Sub

        '********************************************-----TB_FUNCIONARIO-----***********************************
        Public Shared Function getFuncionarios(ByVal consulta As String) As DataSet
            dal = New Dal
            Return dal.GetDataSet(consulta)
        End Function
        Public Shared Function pesquisaFuncionarios() As DataSet 'ByVal Valor As String) As DataSet
            Dim sql As String

            sql = "SELECT NU_MATRICULA "
            sql = sql + ", NM_FUNCIONARIO "
            sql = sql + ", DS_ENDERECO "
            sql = sql + ", DS_BAIRRO "
            sql = sql + ", NU_TELEFONE_RES"
            sql = sql + ", NU_TELEFONE_CEL"
            sql = sql + ", DS_CARGO"
            sql = sql + ", VL_SALARIO from TB_FUNCIONARIO"
            dal = New Dal
            Return dal.GetDataSet(sql)
        End Function

        Public Shared Sub alteraFuncionarios(ByVal MatriculaFuncionario As String, ByVal NomeFuncionario As String, ByVal EnderecoFuncionario As String, ByVal BairroFornecedor As String, ByVal TelefoneResidencialFuncionario As String, ByVal TelefoneCelularFuncionario As String, ByVal CargoFuncionario As String, ByVal ValorSalario As String)
            Dim sql As String

            sql = "UPDATE TB_FUNCIONARIO SET "
            sql = sql + " NM_FUNCIONARIO =  '" & NomeFuncionario & "'"
            sql = sql + ", DS_ENDERECO = '" & EnderecoFuncionario & "'"
            sql = sql + ", DS_BAIRRO '" & BairroFornecedor & "'"
            sql = sql + ", NU_TELEFONE_RES '" & TelefoneResidencialFuncionario & "'"
            sql = sql + ", NU_TELEFONE_CEL ' " & TelefoneCelularFuncionario & ","
            sql = sql + ", DS_CARGO ' " & CargoFuncionario & ","
            sql = sql + ", VL_SALARIO ' " & ValorSalario & ","
            sql = sql + " WHERE NU_MATRICULA = " & MatriculaFuncionario & ";"

            dal = New Dal
            dal.ExecuteComando(sql)

        End Sub

        Public Shared Sub incluiFuncionarios(ByVal MatriculaFuncionario As String, ByVal NomeFuncionario As String, ByVal EnderecoFuncionario As String, ByVal BairroFornecedor As String, ByVal TelefoneResidencialFuncionario As String, ByVal TelefoneCelularFuncionario As String, ByVal CargoFuncionario As String, ByVal ValorSalario As String)
            Dim sql As String

            sql = "INSERT INTO TB_FUNCIONARIO (NU_MATRICULA, NM_FUNCIONARIO, DS_ENDERECO, DS_BAIRRO, NU_TELEFONE_RES, NU_TELEFONE_CEL, DS_CARGO, VL_SALARIO) "
            sql = sql + " VALUES ("
            sql = sql + " " & MatriculaFuncionario & ","
            sql = sql + " '" & NomeFuncionario & "',"
            sql = sql + " '" & EnderecoFuncionario & "',"
            sql = sql + " '" & BairroFornecedor & "',"
            sql = sql + " '" & TelefoneResidencialFuncionario & "',"
            sql = sql + " '" & TelefoneCelularFuncionario & "',"
            sql = sql + " '" & CargoFuncionario & "',"
            sql = sql + " TO_NUMBER('" & ValorSalario & "', 'FM99990.00'));"

            'sql = sql + " TO_DATE('" & DtNasc & "'), "
            'sql = sql + " TO_NUMBER('" & Valor & "', 'FM99990.00'));"

            dal = New Dal
            dal.ExecuteComando(sql)

        End Sub

        Public Shared Sub excluiFuncionarios(ByVal MatriculaFuncionario As String)
            Dim sql As String

            sql = "DELETE TB_FUNCIONARIO "
            sql = sql + " WHERE NU_MATRICULA = " & MatriculaFuncionario & ";"

            dal = New Dal
            dal.ExecuteComando(sql)

        End Sub

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
            sql = sql + " NM_FUNCIONARIO =  '" & NomeProduto & "'"
            sql = sql + ", DS_ENDERECO = '" & ValorCusto & "'"
            sql = sql + ", DS_BAIRRO '" & ValorVenda & "'"
            sql = sql + ", NU_TELEFONE_RES '" & QuantidadeMinima & "'"
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
            sql = sql + " '" & CodigoProduto & "',);"
            'sql = sql + " '" & CargoFuncionario & "',;"
            'sql = sql + " TO_NUMBER('" & ValorSalario & "', 'FM99990.00'));"

            'sql = sql + " TO_DATE('" & DtNasc & "'), "
            'sql = sql + " TO_NUMBER('" & Valor & "', 'FM99990.00'));"

            dal = New Dal
            dal.ExecuteComando(sql)

        End Sub

        Public Shared Sub excluiProduto(ByVal CodigoProduto As String)
            Dim sql As String

            sql = "DELETE TB_PRODUTO "
            sql = sql + " WHERE CD_CODIGO = " & CodigoProduto & ";"

            dal = New Dal
            dal.ExecuteComando(sql)

        End Sub


    End Class
End Namespace
