Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class FrmCatalogue

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmCatalogue_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub img1_Click(sender As Object, e As EventArgs) Handles img1.Click

        Dim cnn As SqlConnection
        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=SOKA_GestionCo;User ID=SIO1;Password=SIO1MDP")

        cnn.Open()

        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader


        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT  FROM  "

        JeuEnr = cmd.ExecuteReader()

        While JeuEnr.Read()

        End While

        JeuEnr.Close()
    End Sub

    Private Sub btnAjout_Click(sender As Object, e As EventArgs) Handles btnAjout.Click

        frmAjoutProduit.Show()
    End Sub
End Class