Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Module Fonction

    Public Sub refreshcboentreprise()

        frm_NouveauProspect.cbo_entreprises.Items.Clear()

        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=SOKA_GestionCo;User ID=SIO1;Password=SIO1MDP")

        cnn.Open()

        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT RaisonSociale FROM ENTREPRISE"

        JeuEnr = cmd.ExecuteReader()

        While JeuEnr.Read()
            frm_NouveauProspect.cbo_entreprises.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()

    End Sub

End Module
