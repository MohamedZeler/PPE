Public Class FrmMenuSOKA


    Private Sub btnGestionCli_Click(sender As Object, e As EventArgs) Handles btnGestionCli.Click

        frm_AccueilClient.Show()

    End Sub

    Private Sub btnCatalogue_Click(sender As Object, e As EventArgs) Handles btnCatalogue.Click
        FrmCatalogue.Show()
    End Sub
End Class