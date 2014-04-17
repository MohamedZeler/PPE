Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class frm_activite

    Private Sub frm_activite_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader
        Dim relance As String

        lst_actions.FullRowSelect = True

        lst_actions.Columns.Add("Date Action", 80, HorizontalAlignment.Center)
        lst_actions.Columns.Add("Commentaires", 100, HorizontalAlignment.Center)
        lst_actions.Columns.Add("A Relancer", 50, HorizontalAlignment.Center)
        lst_actions.Columns.Add("Date Relance", 80, HorizontalAlignment.Center)
        lst_actions.Columns.Add("NomProspect", 100, HorizontalAlignment.Center)
        lst_actions.Columns.Add("PrenomProspect", 100, HorizontalAlignment.Center)
        lst_actions.Columns.Add("Entreprise", 100, HorizontalAlignment.Center)
        lst_actions.Columns.Add("Nature action", 100, HorizontalAlignment.Center)

        cnn = New SqlConnection("Data Source=ADRIEN-PC;Initial Catalog=SOKA_Gestion;User ID=SIO1;Password=SIO1_MDP")

        cnn.Open()

        If OnlyRelances = 0 Then

            lbl_actiontitre.Text = "Liste des actions"

            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT IdAction, DateAction, Commentaire, ARelancer, DateRelance, NomContact, PrenomContact, RaisonSociale, LibTypeAction FROM ACTION, CONTACT, ENTREPRISE, TYPE_ACTION WHERE ACTION.IdContact = CONTACT.IdContact AND CONTACT.IdEntreprise = ENTREPRISE.IdEntreprise AND TYPE_ACTION.IdTypeAction = ACTION.IdTypeAction"
            JeuEnr = cmd.ExecuteReader()

            Dim i As Integer
            i = 0

            While JeuEnr.Read()
                If JeuEnr.GetValue(3) = 1 Then
                    relance = "Oui"
                Else
                    relance = "Non"
                End If
                lst_actions.Items.Add(JeuEnr.GetValue(1))
                lst_actions.Items(lst_actions.Items.Count - 1).SubItems.Add(JeuEnr.GetValue(2))
                lst_actions.Items(lst_actions.Items.Count - 1).SubItems.Add(relance)
                lst_actions.Items(lst_actions.Items.Count - 1).SubItems.Add(JeuEnr.GetValue(4))
                lst_actions.Items(lst_actions.Items.Count - 1).SubItems.Add(JeuEnr.GetValue(5))
                lst_actions.Items(lst_actions.Items.Count - 1).SubItems.Add(JeuEnr.GetValue(6))
                lst_actions.Items(lst_actions.Items.Count - 1).SubItems.Add(JeuEnr.GetValue(7))
                lst_actions.Items(lst_actions.Items.Count - 1).SubItems.Add(JeuEnr.GetValue(8))
                lst_actions.Items(i).Name = JeuEnr.GetValue(0)

            End While
        ElseIf OnlyRelances = 1 Then

            lbl_actiontitre.Text = "Liste des relances à réaliser"

            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT IdAction, DateAction, Commentaire, ARelancer, DateRelance, NomContact, PrenomContact, RaisonSociale, LibTypeAction FROM ACTION, CONTACT, ENTREPRISE, TYPE_ACTION WHERE ACTION.IdContact = CONTACT.IdContact AND CONTACT.IdEntreprise = ENTREPRISE.IdEntreprise AND TYPE_ACTION.IdTypeAction = ACTION.IdTypeAction AND ARelancer = 1"
            JeuEnr = cmd.ExecuteReader()

            Dim i As Integer
            i = 0

            While JeuEnr.Read()
                If JeuEnr.GetValue(3) = 1 Then
                    relance = "Oui"
                Else
                    relance = "Non"
                End If
                lst_actions.Items.Add(JeuEnr.GetValue(1))
                lst_actions.Items(lst_actions.Items.Count - 1).SubItems.Add(JeuEnr.GetValue(2))
                lst_actions.Items(lst_actions.Items.Count - 1).SubItems.Add(relance)
                lst_actions.Items(lst_actions.Items.Count - 1).SubItems.Add(JeuEnr.GetValue(4))
                lst_actions.Items(lst_actions.Items.Count - 1).SubItems.Add(JeuEnr.GetValue(5))
                lst_actions.Items(lst_actions.Items.Count - 1).SubItems.Add(JeuEnr.GetValue(6))
                lst_actions.Items(lst_actions.Items.Count - 1).SubItems.Add(JeuEnr.GetValue(7))
                lst_actions.Items(lst_actions.Items.Count - 1).SubItems.Add(JeuEnr.GetValue(8))
                lst_actions.Items(i).Name = JeuEnr.GetValue(0)

            End While
        End If

        cnn.Close()


    End Sub
End Class