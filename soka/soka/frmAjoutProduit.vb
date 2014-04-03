Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class frmAjoutProduit
    Dim cnn As SqlConnection
    Private Sub frmAjoutProduit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As SqlCommand
        Dim jeuEnr As SqlDataReader

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=SOKA_GestionCo;User ID=SIO1;Password=SIO1MDP")
        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT NomModele FROM MODELE"
        jeuEnr = cmd.ExecuteReader()
        While jeuEnr.Read
            ListBox1.Items.Add(jeuEnr.GetValue(0))
        End While

        jeuEnr.Close()


        cnn.Close()
    End Sub


End Class