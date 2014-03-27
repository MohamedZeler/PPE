Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class frm_AjouterEntreprise


    Private Sub frm_AjouterEntreprise_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cnn As SqlConnection

        cnn = New SqlConnection("DataSource=172.30.0.115;InitialCatalog=SOKA_GestionCo;UserID=SIO1;Password=SIO1MDP")

        cnn.Open()

        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT * FROM PAYS"

        JeuEnr = cmd.ExecuteReader()
        MsgBox(JeuEnr.GetValue(1))

        While JeuEnr.Read()
            cbo_paysentreprise.Items.Add(JeuEnr.GetValue(1))
        End While

        JeuEnr.Close()

    End Sub
End Class