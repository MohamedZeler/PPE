Public Class frm_AccueilClient

    Private Sub btn_newprospect_Click(sender As Object, e As EventArgs) Handles btn_newprospect.Click

        frm_NouveauProspect.Show()

    End Sub

    Private Sub frm_AccueilClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_consulterliste_Click(sender As Object, e As EventArgs) Handles btn_consulterliste.Click

        frm_ListeProspect.Show()

    End Sub

    Private Sub btn_newaction_Click(sender As Object, e As EventArgs) Handles btn_newaction.Click

        frm_NewAction.Show()

    End Sub

    Private Sub btn_journalactivite_Click(sender As Object, e As EventArgs) Handles btn_journalactivite.Click

        frm_activite.Show()

    End Sub
End Class