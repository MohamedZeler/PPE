Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class frm_NouveauProspect


    Private Sub btn_addentreprise_Click(sender As Object, e As EventArgs) Handles btn_addentreprise.Click

        frm_AjouterEntreprise.Show()

    End Sub

    Private Sub frm_NouveauProspect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshcboentreprise()

    End Sub

    Private Sub btn_addprospect_Click(sender As Object, e As EventArgs) Handles btn_addprospect.Click

        Dim cnn As SqlConnection

        'cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=SOKA_GestionCo;User ID=SIO1;Password=SIO1MDP")
        cnn = New SqlConnection("Data Source=ADRIEN-PC;Initial Catalog=SOKA_Gestion;User ID=SIO1;Password=SIO1_MDP")
        cnn.Open()

        Dim cmd As SqlCommand
        Dim query As SqlCommand
        Dim JeuEnr As SqlDataReader
        Dim Statut As String

        query = New SqlCommand()
        query.Connection = cnn
        query.CommandText = "SELECT IdEntreprise FROM ENTREPRISE WHERE RaisonSociale = '" & cbo_entreprises.Text & "'"
        JeuEnr = query.ExecuteReader()

        If (rbtn_madame.Checked) Then
            Statut = "Mme"
        Else
            Statut = "M"
        End If

        JeuEnr.Read()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "INSERT INTO CONTACT(Titre, NomContact, PrenomContact, MailContact, TelInterneContact, TelPortable, IdEntreprise) VALUES('" & Statut & "', '" & txt_nomprospect.Text & "', '" & txt_prenomprospect.Text & "', '" & txt_mailprospect.Text & "', '" & txt_teldomicile.Text & "', '" & txt_telportable.Text & "', '" & JeuEnr.GetValue(0) & "' )"
        JeuEnr.Close()
        cmd.ExecuteNonQuery()

        cnn.Close()

        refreshcboentreprise()

        Me.Close()

    End Sub
End Class