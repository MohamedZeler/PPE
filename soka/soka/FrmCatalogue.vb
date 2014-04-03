Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class FrmCatalogue

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmCatalogue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub img2_Click(sender As Object, e As EventArgs) Handles img2.Click
        picbo1.Image = Image.FromFile(" C:\Users\raoul\Documents\PPE\Images\ttipi.jpg")


    End Sub


    Private Sub btnAjout_Click(sender As Object, e As EventArgs) Handles btnAjout.Click

        frmAjoutProduit.Show()

    End Sub

    Private Sub img1_Click(sender As Object, e As EventArgs) Handles img1.Click
        picbo1.Image = Image.FromFile(" C:\Users\raoul\Documents\PPE\Images\s-de-soka.jpg")
    End Sub
End Class