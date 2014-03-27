Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class Form2

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        Dim adapter As SqlDataAdapter
        Dim table As New DataTable

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=SOKA_GestionCo;User ID=SIO1;Password=SIO1MDP")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select nomParcours, typeEmbarcation, prix FROM TARIF T, EMBARCATION E, PARCOURS P WHERE E.idEmbarcation = T.idEmbarcation AND T.idParcours = P.idParcours ORDER BY 1,2"


        adapter = New SqlDataAdapter()
        adapter.SelectCommand = cmd

        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        adapter.Fill(table)

        cnn.Close()

        dgvTarifs.AutoGenerateColumns = True
        dgvTarifs.DataSource = table
        dgvTarifs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
    End Sub
End Class