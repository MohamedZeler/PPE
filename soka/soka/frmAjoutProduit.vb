Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class frmAjoutProduit
    Dim cnn As SqlConnection
    Private Sub frmAjoutProduit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn = New SqlConnection("Data Source=ADRIEN-PC;Initial Catalog=SOKA_Gestion;User ID=SIO1;Password=SIO1_MDP")
        'cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=SOKA_GestionCo;User ID=SIO1;Password=SIO1MDP")
        cnn.Open()
        Dim cmd As SqlCommand

        Dim jeuEnr As SqlDataReader

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT IdCollection, IntituleCollection FROM COLLECTION"
        jeuEnr = cmd.ExecuteReader()
        While jeuEnr.Read
            cboCollection.Items.Add(jeuEnr.GetValue(1))
        End While
        jeuEnr.Close()
        cmd.CommandText = "SELECT CodePublic, IntitulePublic FROM PUBLIC2"
        Dim jeuEnr2 As SqlDataReader
        jeuEnr2 = cmd.ExecuteReader()
        While jeuEnr2.Read
            cboPublic.Items.Add(jeuEnr2.GetValue(1))
        End While
        jeuEnr.Close()
        jeuEnr2.Close()
        cnn.Close()


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=SOKA_GestionCo;User ID=SIO1;Password=SIO1MDP")
        cnn = New SqlConnection("Data Source=ADRIEN-PC;Initial Catalog=SOKA_Gestion;User ID=SIO1;Password=SIO1_MDP")
        cnn.Open()
        Dim cmdInsert As SqlCommand
        'Dim cmdCollection As SqlCommand
        Dim cmdPublic As SqlCommand
        Dim jeuEnr As SqlDataReader
        ' Dim jeuEnr2 As SqlDataReader
        cmdPublic = New SqlCommand
        cmdPublic.Connection = cnn
        cmdPublic.CommandText = "SELECT CodePublic, IdCollection FROM COLLECTION, PUBLIC2 WHERE IntitulePublic='" & cboPublic.SelectedItem & "' AND IntituleCollection='" & cboCollection.SelectedItem & "'"
        jeuEnr = cmdPublic.ExecuteReader
        jeuEnr.Read()
        'cmdCollection = New SqlCommand
        'cmdCollection.Connection = cnn
        'cmdCollection.CommandText = "SELECT IdCollection FROM COLLECTION WHERE IntituleCollection='" & cboCollection.SelectedItem & "'"
        'jeuEnr = cmdCollection.ExecuteReader
        'jeuEnr.Read()


        'FrmCatalogue.ImageList1.Images.Add(txtNomModele.Text, )
        cmdInsert = New SqlCommand()
        cmdInsert.Connection = cnn
        cmdInsert.CommandText = "INSERT INTO MODELE VALUES('" & txtNomModele.Text & "','" & txtDescription.Text & "','" & txtPrixBase.Text & "','" & txtMatiere.Text & "','" & txtCouture.Text & "','" & txtInitiales.Text & "','" & TxtSemelleInterieure.Text & "','" & TxtSemelle.Text & "','" & txtFermeture.Text & "','" & TxtTalon.Text & "','" & TxtConfort.Text & "','" & TxtPlus.Text & "'," & jeuEnr.GetValue(1) & ",'" & jeuEnr.GetValue(0) & "','photo.jpeg')"
        jeuEnr.Close()


        cmdInsert.ExecuteNonQuery()

        cnn.Close()
        FileCopy(chemin, "C:\Users\adrien\Documents\GitHub\PPE\soka\soka\Resources\" & txtNomModele.Text & ".jpg")
        Me.Close()
        FrmCatalogue.Show()


    End Sub

    Dim chemin As String
    Private Sub btnParcourir_Click(sender As Object, e As EventArgs) Handles btnParcourir.Click
        OpenFileDialog1.ShowDialog()

        chemin = OpenFileDialog1.FileName

        txtPhoto.Text = chemin

    End Sub
End Class