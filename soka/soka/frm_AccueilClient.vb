Public Class frm_AccueilClient

    Private Sub btn_newprospect_Click(sender As Object, e As EventArgs) Handles btn_newprospect.Click

        frm_NouveauProspect.Show()

    End Sub

    Private Sub frm_AccueilClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ViewAllProspect = 0

    End Sub

    Private Sub btn_consulterliste_Click(sender As Object, e As EventArgs) Handles btn_consulterliste.Click

        ViewAllProspect = 1
        frm_ListeProspect.Show()

    End Sub

    Private Sub btn_newaction_Click(sender As Object, e As EventArgs) Handles btn_newaction.Click

        frm_NewAction.Show()

    End Sub

    Private Sub btn_journalactivite_Click(sender As Object, e As EventArgs) Handles btn_journalactivite.Click

        OnlyRelances = 0
        frm_activite.Show()

    End Sub

    Private Sub btn_searchprospect_Click(sender As Object, e As EventArgs) Handles btn_searchprospect.Click
        SearchNomContact = txt_nomprospect.Text
        SearchPrenomContact = txt_prenomprospect.Text
        ViewAllProspect = 2
        frm_ListeProspect.Show()


    End Sub

    Private Sub btn_relance_Click(sender As Object, e As EventArgs) Handles btn_relance.Click

        OnlyRelances = 1
        frm_activite.Show()

    End Sub
End Class