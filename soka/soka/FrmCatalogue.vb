Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class FrmCatalogue

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmCatalogue_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub img1_Click(sender As Object, e As EventArgs) Handles img.Click

        Dim cnn As SqlConnection
        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=SOKA_GestionCo;User ID=SIO1;Password=SIO1MDP")

        cnn.Open()

        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader


        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT image FROM Produit "

        JeuEnr = cmd.ExecuteReader()

        While JeuEnr.Read()

        End While

        JeuEnr.Close()
    End Sub

<<<<<<< HEAD
    Private Sub img2_Click(sender As Object, e As EventArgs) Handles img2.Click

=======
    Private Sub btnAjout_Click(sender As Object, e As EventArgs) Handles btnAjout.Click

        frmAjoutProduit.Show()
>>>>>>> f037bd709b40bc650a32986e3739c0a62f209c61
    End Sub
End Class