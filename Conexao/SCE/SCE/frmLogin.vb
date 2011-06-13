﻿Imports SCE.DalSce
Imports System.Xml
Public Class frmLogin

    Dim dal As New Dal()
    Dim frmSCE As New frmSCE()

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        dal.setUser(UsernameTextBox.Text)
        dal.setPassword(PasswordTextBox.Text)

        dal.configLogin(UsernameTextBox.Text, PasswordTextBox.Text)

        frmSCE.Show()

        Me.Close()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
