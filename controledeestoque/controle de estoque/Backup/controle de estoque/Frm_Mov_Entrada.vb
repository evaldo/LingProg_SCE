Public Class Frm_Mov_Entrada

    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click
        'conforme o RadioButton escolido, o foco é posto no text especifico
        If (RadioButton1 = True) Then
            txtCodigo_P.Focus()
        Else
            txtDTmov.Focus()
        End If

        'aqui o código do consultar
    End Sub
End Class