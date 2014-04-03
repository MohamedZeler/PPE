Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
    Public Class FrmListeContacts

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        Dim adapter As SqlDataAdapter
        Dim table As New DataTable

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=SOKA_GestionCo;User ID=SIO1;Password=SIO1MDP")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select * FROM CONTACT;"


        adapter = New SqlDataAdapter()
        adapter.SelectCommand = cmd

        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        adapter.Fill(table)

        cnn.Close()

        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = table
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders


        DataGridView1.ColumnCount = 1
        DataGridView1.ColumnHeadersVisible = True


        DataGridView1.Columns(0).Name = "Id contact"
        DataGridView1.Columns(0).Name = "Titre"
        DataGridView1.Columns(0).Name = "Nom"
        DataGridView1.Columns(0).Name = "Prénom"
        DataGridView1.Columns(0).Name = "Mél"
        DataGridView1.Columns(0).Name = "Tel fixe"
        DataGridView1.Columns(0).Name = "Tel mobile"
        DataGridView1.Columns(0).Name = "Id entreprise"


        Dim row1() As String = {"1", "test", "test", "test", "test", "test", "test", "1"}
        Dim rows() As Object = {row1}

        Dim rowArray As String()
        For Each rowArray In rows
            DataGridView1.Rows.Add(rowArray)
        Next rowArray

    End Sub
    End Class