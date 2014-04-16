Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class FrmCatalogue

   
    Dim cnn As SqlConnection

    Private Sub FrmCatalogue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection
        Dim cmd As SqlCommand

        'cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=SI6_CVV;User ID=SIO1;Password=SIO1MDP")
        cnn = New SqlConnection("Data Source=ADRIEN-PC;Initial Catalog=SOKA_Gestion;User ID=SIO1;Password=SIO1_MDP")
        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "SELECT NomModele, PrixBase FROM MODELE"
        Dim jeuEnr As SqlDataReader
        jeuEnr = cmd.ExecuteReader
        Dim i As Integer
        i = 0
        While jeuEnr.Read

            lstvModele.Items.Add(jeuEnr.GetValue(0))
            ImageList1.Images.Add(jeuEnr.GetValue(0), Image.FromFile("C:\Users\adrien\Documents\GitHub\PPE\soka\soka\Resources\" & jeuEnr.GetValue(0) & ".jpg"))
            lstvModele.Items(i).ImageKey = jeuEnr.GetValue(0)
            i = i + 1
        End While


    
    End Sub

    


    Private Sub btnAjout_Click(sender As Object, e As EventArgs) Handles btnAjout.Click
        Me.Close()
        frmAjoutProduit.Show()

    End Sub

    Private Sub lstvModele_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstvModele.SelectedIndexChanged


        'Dim test As String

        'MsgBox(lstvModele.SelectedItems.Count)


        'Dim cmd As SqlCommand
        'cmd = New SqlCommand
        'cmd.Connection = cnn
        'cmd.CommandText = "SELECT descriptif FROM MODELE WHERE NomModele='" & CType(lstvModele.SelectedItems.Item, String) & "'"


    End Sub

    
End Class