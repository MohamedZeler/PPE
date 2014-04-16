Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class frm_ListeProspect

    Private Sub frm_ListeProspect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        Dim adapter As SqlDataAdapter
        Dim table As New DataTable

        cnn = New SqlConnection("Data Source=ADRIEN-PC;Initial Catalog=SOKA_Gestion;User ID=SIO1;Password=SIO1_MDP")
        'cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=SI6_CVV;User ID=SIO1;Password=SIO1MDP")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select Titre, NomContact, PrenomContact, MailContact, TelInterneContact, TelPortable, RaisonSociale FROM CONTACT, ENTREPRISE WHERE CONTACT.IdEntreprise = ENTREPRISE.IdEntreprise"


        adapter = New SqlDataAdapter()
        adapter.SelectCommand = cmd

        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        adapter.Fill(table)

        cnn.Close()

        dgv_listeprospect.AutoGenerateColumns = True
        dgv_listeprospect.DataSource = table
        dgv_listeprospect.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders


    End Sub
End Class