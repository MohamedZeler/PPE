Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class frm_NewAction

    Private Sub frm_NewAction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refreshcboaction()
        refreshcbocontact()



    End Sub
    Dim cnn As SqlConnection

    Private Sub btn_ajouteraction_Click(sender As Object, e As EventArgs) Handles btn_ajouteraction.Click
        cnn = New SqlConnection("Data Source=ADRIEN-PC;Initial Catalog=SOKA_Gestion;User ID=SIO1;Password=SIO1_MDP")
        cnn.Open()

        Dim cmd As SqlCommand
        Dim query As SqlCommand
        Dim aRelancer As Integer
        Dim jeuEnr As SqlDataReader

        query = New SqlCommand
        query.Connection = cnn
        query.CommandText = "SELECT IdContact, IdTypeAction FROM CONTACT, TYPE_ACTION WHERE LibTypeAction='" & cbo_typeaction.SelectedItem & "' AND NomContact='" & cbo_contact.SelectedItem & "'"
        jeuEnr = query.ExecuteReader

        If chk_relance.Checked Then
            aRelancer = 1
        Else
            aRelancer = 0
            txt_daterelance.Text = ""
        End If

        jeuEnr.Read()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "INSERT INTO ACTION VALUES('" & txt_dateaction.Text & "','" & txt_commentaire.Text & "'," & aRelancer & ",'" & txt_daterelance.Text & "'," & jeuEnr.GetValue(0) & "," & jeuEnr.GetValue(1) & ")"
        jeuEnr.Close()
        cmd.ExecuteNonQuery()
        cnn.Close()

    End Sub
End Class