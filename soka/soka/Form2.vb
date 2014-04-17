Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class frm_ListeProspect

    Private Sub frm_ListeProspect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader

        lst_listeprospect.FullRowSelect = True

        lst_listeprospect.Columns.Add("Titre", 50, HorizontalAlignment.Center)
        lst_listeprospect.Columns.Add("Nom", 100, HorizontalAlignment.Center)
        lst_listeprospect.Columns.Add("Prénom", 100, HorizontalAlignment.Center)
        lst_listeprospect.Columns.Add("Mail", 200, HorizontalAlignment.Center)
        lst_listeprospect.Columns.Add("Téléphone", 100, HorizontalAlignment.Center)
        lst_listeprospect.Columns.Add("Portable", 100, HorizontalAlignment.Center)
        lst_listeprospect.Columns.Add("Entreprise", 200, HorizontalAlignment.Center)



        cnn = New SqlConnection("Data Source=ADRIEN-PC;Initial Catalog=SOKA_Gestion;User ID=SIO1;Password=SIO1_MDP")
        'cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=SI6_CVV;User ID=SIO1;Password=SIO1MDP")

        cnn.Open()

        If ViewAllProspect = 1 Then


            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "Select Titre, NomContact, PrenomContact, MailContact, TelInterneContact, TelPortable, RaisonSociale, CONTACT.IdContact FROM CONTACT, ENTREPRISE WHERE CONTACT.IdEntreprise = ENTREPRISE.IdEntreprise"
            JeuEnr = cmd.ExecuteReader()

            Dim i As Integer
            i = 0

            While JeuEnr.Read()


                lst_listeprospect.Items.Add(JeuEnr(0))
                lst_listeprospect.Items(lst_listeprospect.Items.Count - 1).SubItems.Add(JeuEnr(1))
                lst_listeprospect.Items(lst_listeprospect.Items.Count - 1).SubItems.Add(JeuEnr(2))
                lst_listeprospect.Items(lst_listeprospect.Items.Count - 1).SubItems.Add(JeuEnr(3))
                lst_listeprospect.Items(lst_listeprospect.Items.Count - 1).SubItems.Add(JeuEnr(4))
                lst_listeprospect.Items(lst_listeprospect.Items.Count - 1).SubItems.Add(JeuEnr(5))
                lst_listeprospect.Items(lst_listeprospect.Items.Count - 1).SubItems.Add(JeuEnr(6))
                lst_listeprospect.Items(i).Name = JeuEnr.GetValue(7)

                i = i + 1

            End While
        ElseIf ViewAllProspect = 2 Then


            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "Select Titre, NomContact, PrenomContact, MailContact, TelInterneContact, TelPortable, RaisonSociale, CONTACT.IdContact FROM CONTACT, ENTREPRISE WHERE CONTACT.IdEntreprise = ENTREPRISE.IdEntreprise AND NomContact LIKE '%" & SearchNomContact & "%' AND PrenomContact LIKE '%" & SearchPrenomContact & "%'"
            JeuEnr = cmd.ExecuteReader()

            Dim i As Integer
            i = 0

            While JeuEnr.Read()


                lst_listeprospect.Items.Add(JeuEnr(0))
                lst_listeprospect.Items(lst_listeprospect.Items.Count - 1).SubItems.Add(JeuEnr(1))
                lst_listeprospect.Items(lst_listeprospect.Items.Count - 1).SubItems.Add(JeuEnr(2))
                lst_listeprospect.Items(lst_listeprospect.Items.Count - 1).SubItems.Add(JeuEnr(3))
                lst_listeprospect.Items(lst_listeprospect.Items.Count - 1).SubItems.Add(JeuEnr(4))
                lst_listeprospect.Items(lst_listeprospect.Items.Count - 1).SubItems.Add(JeuEnr(5))
                lst_listeprospect.Items(lst_listeprospect.Items.Count - 1).SubItems.Add(JeuEnr(6))
                lst_listeprospect.Items(i).Name = JeuEnr.GetValue(7)

                i = i + 1

            End While




        End If

        cnn.Close()


    End Sub

    Private Sub btn_deleteprospect_Click(sender As Object, e As EventArgs) Handles btn_deleteprospect.Click

        If lst_listeprospect.SelectedItems.Count = 1 Then

            If MsgBox("Êtes vous certain de supprimer ce prospect ?", vbYesNo, "Demande de confirmation") = vbYes Then

                Dim cnn As SqlConnection
                Dim cmd As SqlCommand
                Dim ligneProspect As ListViewItem
                Dim CodeProspect As String

                cnn = New SqlConnection("Data Source=ADRIEN-PC;Initial Catalog=SOKA_Gestion;User ID=SIO1;Password=SIO1_MDP")
                cnn.Open()

                ligneProspect = lst_listeprospect.SelectedItems.Item(0)
                CodeProspect = ligneProspect.Name

                cmd = New SqlCommand()
                cmd.Connection = cnn

                cmd.CommandText = "DELETE FROM ACTION WHERE IdContact = " & CodeProspect
                cmd.ExecuteNonQuery()

                cmd.CommandText = "DELETE FROM CONTACT WHERE IdContact = " & CodeProspect
                cmd.ExecuteNonQuery()

            End If
        End If

    End Sub
End Class