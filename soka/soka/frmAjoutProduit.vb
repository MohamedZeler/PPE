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
        




        cnn.Close()
    End Sub


    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click, Label8.Click

    End Sub
End Class