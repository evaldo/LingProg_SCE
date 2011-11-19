Imports SCE.DalSce
Namespace BllSce
    Public Class BllFuncionario
        Private Shared dal As Dal

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
            sql = sql + ", DS_ENDERECO =  '" & EnderecoFuncionario & "'"
            sql = sql + ", DS_BAIRRO = '" & BairroFornecedor & "'"
            sql = sql + ", NU_TELEFONE_RES = '" & TelefoneResidencialFuncionario & "'"
            sql = sql + ", NU_TELEFONE_CEL = '" & TelefoneCelularFuncionario & "'"
            sql = sql + ", DS_CARGO = '" & CargoFuncionario & "'"
            sql = sql + ", VL_SALARIO = TO_NUMBER(" & ValorSalario & ", 'FM99990.00')"
            sql = sql + " WHERE NU_MATRICULA =" & MatriculaFuncionario & ";"

            dal = New Dal
            dal.ExecuteComando(sql)

        End Sub

        Public Shared Sub incluiFuncionarios(ByVal MatriculaFuncionario As String, ByVal NomeFuncionario As String, ByVal EnderecoFuncionario As String, ByVal BairroFuncionario As String, ByVal TelefoneResidencialFuncionario As String, ByVal TelefoneCelularFuncionario As String, ByVal CargoFuncionario As String, ByVal ValorSalario As String)
            Dim sql As String

            sql = "INSERT INTO TB_FUNCIONARIO (NU_MATRICULA, NM_FUNCIONARIO, DS_ENDERECO, DS_BAIRRO, NU_TELEFONE_RES, NU_TELEFONE_CEL, DS_CARGO, VL_SALARIO) "
            sql = sql + " VALUES ("
            sql = sql + " " & MatriculaFuncionario & ","
            sql = sql + " '" & NomeFuncionario & "',"
            sql = sql + " '" & EnderecoFuncionario & "',"
            sql = sql + " '" & BairroFuncionario & "',"
            sql = sql + " '" & TelefoneResidencialFuncionario & "',"
            sql = sql + " '" & TelefoneCelularFuncionario & "',"
            sql = sql + " '" & CargoFuncionario & "',"
            sql = sql + " TO_NUMBER(" & ValorSalario & ", 'FM99990.00'));"

            'sql = sql + " TO_DATE('" & DtNasc & "'), "
            'sql = sql + " TO_NUMBER('" & Valor & "', 'FM99990.00'));"



            dal = New Dal
            dal.ExecuteComando(sql)

        End Sub

        Public Shared Sub excluiFuncionarios(ByVal MatriculaFuncionario As String)

            Dim sql As String

            sql = "DELETE FROM TB_FUNCIONARIO WHERE NU_MATRICULA = " & MatriculaFuncionario & ";"

            dal = New Dal
            dal.ExecuteComando(sql)

        End Sub
        Public Shared Function pesquisaFuncionariosId(ByVal MatriculaFuncionario As String, ByVal NomeFuncionario As String, ByVal EnderecoFuncionario As String, ByVal BairroFuncionario As String, ByVal TelefoneResidencialFuncionario As String, ByVal TelefoneCelularFuncionario As String, ByVal CargoFuncionario As String, ByVal ValorSalario As String) As DataSet
            Dim sql As String

            If Not (MatriculaFuncionario = "") Then

                sql = "SELECT * FROM TB_FUNCIONARIO WHERE NU_MATRICULA LIKE " & MatriculaFuncionario & ";"

                dal = New Dal
                Return dal.GetDataSet(sql)
            End If
            If Not (NomeFuncionario = "") Then
                sql = "SELECT * FROM TB_FUNCIONARIO WHERE NM_FUNCIONARIO LIKE '" & NomeFuncionario & "';"

                dal = New Dal
                Return dal.GetDataSet(sql)
            End If
            If Not (EnderecoFuncionario = "") Then
                sql = "SELECT * FROM TB_FUNCIONARIO WHERE DS_ENDERECO LIKE '" & EnderecoFuncionario & "';"

                dal = New Dal
                Return dal.GetDataSet(sql)
            End If
            If Not (BairroFuncionario = "") Then
                sql = "SELECT * FROM TB_FUNCIONARIO WHERE DS_BAIRRO LIKE '" & BairroFuncionario & "';"

                dal = New Dal
                Return dal.GetDataSet(sql)
            End If

            If Not (TelefoneResidencialFuncionario = "") Then
                sql = "SELECT * FROM TB_FUNCIONARIO WHERE NU_TELEFONE_RES LIKE '" & TelefoneResidencialFuncionario & "';"

                dal = New Dal
                Return dal.GetDataSet(sql)
            End If
            If Not (TelefoneCelularFuncionario = "") Then
                sql = "SELECT * FROM TB_FUNCIONARIO WHERE NU_TELEFONE_CEL LIKE '" & TelefoneCelularFuncionario & "';"

                dal = New Dal
                Return dal.GetDataSet(sql)
            End If
            If Not (CargoFuncionario = "") Then
                sql = "SELECT * FROM TB_FUNCIONARIO WHERE DS_CARGO LIKE '" & CargoFuncionario & "';"

                dal = New Dal
                Return dal.GetDataSet(sql)
            End If
            If Not (ValorSalario = "") Then
                sql = "SELECT * FROM TB_FUNCIONARIO WHERE VL_SALARIO LIKE TO_NUMBER(" & ValorSalario & ");"
                MsgBox(sql)
                dal = New Dal
                Return dal.GetDataSet(sql)
            End If
            dal = New Dal
            sql = ""
            Return dal.GetDataSet(sql)
        End Function

       

    End Class
End Namespace
