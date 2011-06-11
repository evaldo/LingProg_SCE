Imports System.Data
Imports System.Data.Odbc
Imports System.Data.SqlClient

Namespace DalSce

    Public Class Dal

        Private strConn As String = _
                     "Dsn=OracleXE;" & _
                     "Uid=system;" & _
                     "Pwd=1234"

        Private Function openConexao() As Odbc.OdbcConnection
            Dim cn As Odbc.OdbcConnection
            cn = New Odbc.OdbcConnection(strConn)
            cn.Open()
            Return cn
        End Function

        Private Sub closeConexao(ByVal cn As OdbcConnection)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Sub

        Public Sub ExecuteComando(ByVal consulta As String)
            Dim cn As New OdbcConnection()
            Try
                cn = openConexao()
                Dim cmdCommand As New OdbcCommand
                With cmdCommand
                    .CommandText = consulta.ToString
                    .CommandType = CommandType.Text
                    .Connection = cn
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MsgBox("Mensagem de erro emitida pela operação executada: " & ex.Message & "")
            Finally
                closeConexao(cn)
            End Try
        End Sub

        Public Function GetDataSet(ByVal consulta As String) As DataSet
            Dim cn As New OdbcConnection()
            Try
                cn = openConexao()
                Dim cmdCommand As New OdbcCommand

                With cmdCommand
                    .CommandText = consulta.ToString
                    .CommandType = CommandType.Text
                    .Connection = cn
                    .ExecuteNonQuery()
                End With

                Dim da As New OdbcDataAdapter
                Dim ds As New DataSet
                With da
                    .SelectCommand = cmdCommand
                    .Fill(ds)
                End With
                Return ds
            Catch ex As Exception
                Throw
            Finally
                closeConexao(cn)
            End Try
        End Function

        Public Function GetDataReader(ByVal consulta As String) As OdbcDataReader

            Dim cn As New OdbcConnection()
            Try
                cn = openConexao()
                Dim cmdCommand As New OdbcCommand
                With cmdCommand
                    .CommandText = consulta.ToString
                    .CommandType = CommandType.Text
                    .Connection = cn
                End With
                Return cmdCommand.ExecuteReader()
            Catch ex As Exception
                Throw
            Finally
                closeConexao(cn)
            End Try
        End Function

    End Class

End Namespace