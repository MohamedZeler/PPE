﻿Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class frm_AjouterEntreprise


    Private Sub frm_AjouterEntreprise_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=SOKA_GestionCo;User ID=SIO1;Password=SIO1MDP")

        cnn.Open()

        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT Libpays FROM PAYS"

        JeuEnr = cmd.ExecuteReader()

        While JeuEnr.Read()
            cbo_paysentreprise.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()

    End Sub

    Private Sub btn_addentreprise_Click(sender As Object, e As EventArgs) Handles btn_addentreprise.Click

        Dim cnn As SqlConnection

        cnn = New SqlConnection("DataSource=172.30.0.115;InitialCatalog=SOKA_GestionCo;UserID=SIO1;Password=SIO1MDP")

        cnn.Open()

        Dim cmd As SqlCommand
        Dim query As SqlCommand
        Dim JeuEnr As SqlDataReader
        Dim textsql As String

        query = New SqlCommand()


        query.Connection = cnn
        query.CommandText = "SELECT CodePays FROM PAYS WHERE Libpays = '" & cbo_paysentreprise.Text & "'"

        JeuEnr = query.ExecuteReader()
        MsgBox(JeuEnr.GetValue(1))


        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "INSERT INTO ENTREPRISE(IdEntreprise, RaisonSociale, AdresseRue, CodePostal, Ville, TelStandard, Mail, CodePays) VALUES("", '" & txt_designation.Text & "', '" & txt_adresse.Text & "', '" & txt_cpentreprise.Text & "', '" & txt_villeentreprise.Text & "', '" & txt_mailentreprise.Text & "', 'FRA' )"


    End Sub
End Class