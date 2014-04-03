Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class FrmCatalogue

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmCatalogue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

<<<<<<< HEAD
    Private Sub img2_Click(sender As Object, e As EventArgs) Handles img2.Click
        picbo1.Image = Image.FromFile(" C:\Users\raoul\Documents\PPE\Images\ttipi.jpg")
=======
    Private Sub img1_Click(sender As Object, e As EventArgs) Handles img.Click

        Dim cnn As SqlConnection
        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=SOKA_GestionCo;User ID=SIO1;Password=SIO1MDP")

        cnn.Open()

        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader


        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = ""

        cmd.CommandText = "SELECT image FROM Produit "


        JeuEnr = cmd.ExecuteReader()

        While JeuEnr.Read()
>>>>>>> f3bdac2e7e88edaca0faadee7928433570f6ce19


    End Sub

<<<<<<< HEAD

=======

    Private Sub img2_Click(sender As Object, e As EventArgs) Handles img2.Click

    End Sub
>>>>>>> f3bdac2e7e88edaca0faadee7928433570f6ce19
    Private Sub btnAjout_Click(sender As Object, e As EventArgs) Handles btnAjout.Click

        frmAjoutProduit.Show()

<<<<<<< HEAD
    End Sub

    Private Sub img1_Click(sender As Object, e As EventArgs) Handles img1.Click
        picbo1.Image = Image.FromFile(" C:\Users\raoul\Documents\PPE\Images\s-de-soka.jpg")
=======
>>>>>>> f3bdac2e7e88edaca0faadee7928433570f6ce19
    End Sub
End Class