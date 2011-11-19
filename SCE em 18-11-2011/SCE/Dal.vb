Imports System.Data
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Xml

Namespace DalSce

    Public Class Dal

        Private User As String
        Private Password As String

        Private strConn As String = _
                     "Dsn=OracleXe;" & _
                     "Uid=" & getUser() & ";" & _
                     "Pwd=" & getPassword() & ""

        Public Sub setUser(ByVal prmUser As String)
            If lerConfigLoginUser() = "" Then
                User = prmUser
            Else
                Me.User = lerConfigLoginUser()
            End If
        End Sub

        Public Function getUser() As String
            Return lerConfigLoginUser()
        End Function

        Public Sub setPassword(ByVal prmPassword As String)
            If lerConfigLoginPassword() = "" Then
                Password = prmPassword
            Else
                Me.Password = lerConfigLoginPassword()
            End If
        End Sub

        Public Function getPassword() As String
            Return lerConfigLoginPassword()
        End Function

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
            Catch EX As Exception
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

        Public Sub configLogin(ByVal prmUser As String, ByVal prmPassword As String)

            Try
                Dim refXML As Object = Nothing

                'Define documento arquivo XML
                Dim xmldocumento As XmlDocument = New XmlDocument
                xmldocumento.LoadXml("<login></login>")

                'Define o raiz
                Dim root As XmlNode = xmldocumento.DocumentElement

                'Define o elementUser
                Dim elementUser As XmlElement = xmldocumento.CreateElement("user")
                elementUser.InnerText = prmUser
                root.AppendChild(elementUser)

                'Define o elementPassword
                Dim elementPass As XmlElement = xmldocumento.CreateElement("password")
                elementPass.InnerText = prmPassword
                root.AppendChild(elementPass)

                'salva o arquivo XML
                xmldocumento.Save("configLogin.xml")

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

        End Sub

        Public Function lerConfigLoginUser() As String

            Try

                Dim xmldocumento As New XmlDocument()
                xmldocumento.Load("configLogin.xml")

                Return xmldocumento.SelectSingleNode("login").ChildNodes(0).InnerText

            Catch ex As Exception
                Return ""
            End Try

        End Function

        Public Function lerConfigLoginPassword() As String

            Try

                Dim xmldocumento As New XmlDocument()
                xmldocumento.Load("configLogin.xml")

                Return xmldocumento.SelectSingleNode("login").ChildNodes(1).InnerText

            Catch ex As Exception
                Return ""
            End Try

        End Function

    End Class

End Namespace