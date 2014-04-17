Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class frm_NewAction

    Private Sub frm_NewAction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim j As Integer
        Dim a As Integer

        refreshcboaction()
        refreshcbocontact()

        j = 1
        While j <= 31

            cbo_dateactionjour.Items.Add(j)
            cbo_daterelancejour.Items.Add(j)
            j = j + 1

        End While

        cbo_dateactionmois.Items.Add("Janvier")
        cbo_dateactionmois.Items.Add("Février")
        cbo_dateactionmois.Items.Add("Mars")
        cbo_dateactionmois.Items.Add("Avril")
        cbo_dateactionmois.Items.Add("Mai")
        cbo_dateactionmois.Items.Add("Juin")
        cbo_dateactionmois.Items.Add("Juillet")
        cbo_dateactionmois.Items.Add("Août")
        cbo_dateactionmois.Items.Add("Septembre")
        cbo_dateactionmois.Items.Add("Octobre")
        cbo_dateactionmois.Items.Add("Novembre")
        cbo_dateactionmois.Items.Add("Décembre")
        cbo_daterelancemois.Items.Add("Janvier")
        cbo_daterelancemois.Items.Add("Février")
        cbo_daterelancemois.Items.Add("Mars")
        cbo_daterelancemois.Items.Add("Avril")
        cbo_daterelancemois.Items.Add("Mai")
        cbo_daterelancemois.Items.Add("Juin")
        cbo_daterelancemois.Items.Add("Juillet")
        cbo_daterelancemois.Items.Add("Août")
        cbo_daterelancemois.Items.Add("Septembre")
        cbo_daterelancemois.Items.Add("Octobre")
        cbo_daterelancemois.Items.Add("Novembre")
        cbo_daterelancemois.Items.Add("Décembre")

        a = 2000
        While a <= 2020
            cbo_dateactionannee.Items.Add(a)
            cbo_daterelanceannee.Items.Add(a)
            a = a + 1
        End While

    End Sub
    Dim cnn As SqlConnection

    Private Sub btn_ajouteraction_Click(sender As Object, e As EventArgs) Handles btn_ajouteraction.Click
        cnn = New SqlConnection("Data Source=ADRIEN-PC;Initial Catalog=SOKA_Gestion;User ID=SIO1;Password=SIO1_MDP")
        cnn.Open()

        Dim cmd As SqlCommand
        Dim query As SqlCommand
        Dim aRelancer As Integer
        Dim jeuEnr As SqlDataReader
        Dim dateaction As String
        Dim daterelance As String

        dateaction = cbo_dateactionjour.SelectedItem & "/" & cbo_dateactionmois.SelectedIndex + 1 & "/" & cbo_dateactionannee.SelectedItem

        query = New SqlCommand
        query.Connection = cnn
        query.CommandText = "SELECT IdContact, IdTypeAction FROM CONTACT, TYPE_ACTION WHERE LibTypeAction='" & cbo_typeaction.SelectedItem & "' AND NomContact='" & cbo_contact.SelectedItem & "'"
        jeuEnr = query.ExecuteReader

        If chk_relance.Checked Then
            aRelancer = 1
            daterelance = cbo_daterelancejour.SelectedItem & "/" & cbo_daterelancemois.SelectedIndex + 1 & "/" & cbo_daterelanceannee.SelectedItem
        Else
            aRelancer = 0
            daterelance = ""
        End If

        jeuEnr.Read()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "INSERT INTO ACTION VALUES('" & dateaction & "','" & txt_commentaire.Text & "'," & aRelancer & ",'" & daterelance & "'," & jeuEnr.GetValue(0) & "," & jeuEnr.GetValue(1) & ")"
        jeuEnr.Close()
        cmd.ExecuteNonQuery()
        cnn.Close()

        Me.Close()

    End Sub
End Class