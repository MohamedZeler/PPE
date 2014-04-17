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


        If ajoutModifCatalogue = 2 Then

            cmd.CommandText = "SELECT NomModele, Descriptif, PrixBase, Matiere, Couture, Initiales, SemellesInterieures, Semelle, Fermeture, TalonF, Confort, Plus, IntitulePublic, IntituleCollection FROM MODELE M, PUBLIC2 P, COLLECTION C WHERE M.IdCollection = C.IdCollection AND P.CodePublic = M.CodePublic AND NomModele = '" & IntituleModelePublic & "'"
            jeuEnr = cmd.ExecuteReader
            jeuEnr.Read()
            txtNomModele.Text = jeuEnr.GetValue(0)
            txtDescription.Text = jeuEnr.GetValue(1)
            txtPrixBase.Text = jeuEnr.GetValue(2)
            txtMatiere.Text = jeuEnr.GetValue(3)
            txtCouture.Text = jeuEnr.GetValue(4)
            txtInitiales.Text = jeuEnr.GetValue(5)
            TxtSemelleInterieure.Text = jeuEnr.GetValue(6)
            TxtSemelle.Text = jeuEnr.GetValue(7)
            txtFermeture.Text = jeuEnr.GetValue(8)
            TxtTalon.Text = jeuEnr.GetValue(9)
            TxtConfort.Text = jeuEnr.GetValue(10)
            TxtPlus.Text = jeuEnr.GetValue(11)
            cboPublic.SelectedItem = jeuEnr.GetValue(12)
            cboCollection.SelectedItem = jeuEnr.GetValue(13)
            Button1.Text = "Modifier"
        End If
        cnn.Close()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=SOKA_GestionCo;User ID=SIO1;Password=SIO1MDP")
        cnn = New SqlConnection("Data Source=ADRIEN-PC;Initial Catalog=SOKA_Gestion;User ID=SIO1;Password=SIO1_MDP")
        cnn.Open()
        If ajoutModifCatalogue = 1 Then


            Dim cmdInsert As SqlCommand
            Dim cmdPublic As SqlCommand
            Dim jeuEnr As SqlDataReader

            cmdPublic = New SqlCommand
            cmdPublic.Connection = cnn


            cmdPublic.CommandText = "SELECT CodePublic, IdCollection FROM COLLECTION, PUBLIC2 WHERE IntitulePublic='" & cboPublic.SelectedItem & "' AND IntituleCollection='" & cboCollection.SelectedItem & "'"
            jeuEnr = cmdPublic.ExecuteReader
            jeuEnr.Read()


            cmdInsert = New SqlCommand()
            cmdInsert.Connection = cnn
            cmdInsert.CommandText = "INSERT INTO MODELE VALUES('" & txtNomModele.Text & "','" & txtDescription.Text & "','" & txtPrixBase.Text & "','" & txtMatiere.Text & "','" & txtCouture.Text & "','" & txtInitiales.Text & "','" & TxtSemelleInterieure.Text & "','" & TxtSemelle.Text & "','" & txtFermeture.Text & "','" & TxtTalon.Text & "','" & TxtConfort.Text & "','" & TxtPlus.Text & "'," & jeuEnr.GetValue(1) & ",'" & jeuEnr.GetValue(0) & "','photo.jpeg')"
            jeuEnr.Close()


            cmdInsert.ExecuteNonQuery()



            FileCopy(chemin, "C:\Users\adrien\Documents\GitHub\PPE\soka\soka\Resources\" & txtNomModele.Text & ".jpg")
            Me.Close()
            FrmCatalogue.Show()

        ElseIf ajoutModifCatalogue = 2 Then
            Dim cmdModif As SqlCommand
            Dim cmdPublic2 As SqlCommand
            Dim jeuEnr As SqlDataReader

            cmdPublic2 = New SqlCommand
            cmdModif = New SqlCommand
            cmdPublic2.Connection = cnn
            cmdModif.Connection = cnn

            cmdPublic2.CommandText = "SELECT CodeModele, COLLECTION.IdCollection, PUBLIC2.CodePublic FROM MODELE, COLLECTION, PUBLIC2 WHERE NomModele = '" & IntituleModelePublic & "' AND IntituleCollection = '" & cboCollection.SelectedItem & "' AND IntitulePublic = '" & cboPublic.SelectedItem & "'"
            jeuEnr = cmdPublic2.ExecuteReader
            jeuEnr.Read()

            cmdModif.CommandText = "UPDATE MODELE SET NomModele='" & txtNomModele.Text & "', Descriptif='" & txtDescription.Text & "', PrixBase='" & txtPrixBase.Text & "', Matiere='" & txtMatiere.Text & "', Couture='" & txtCouture.Text & "', Initiales='" & txtInitiales.Text & "', SemellesInterieures='" & TxtSemelleInterieure.Text & "', Semelle='" & TxtSemelle.Text & "', Fermeture='" & txtFermeture.Text & "', TalonF='" & TxtTalon.Text & "', Confort='" & TxtConfort.Text & "', Plus='" & TxtPlus.Text & "',IdCollection=" & jeuEnr.GetValue(1) & ", CodePublic=" & jeuEnr.GetValue(2) & " WHERE CodeModele=" & jeuEnr.GetValue(0)
            jeuEnr.Close()
            cmdModif.ExecuteNonQuery()
            FileCopy(chemin, "C:\Users\adrien\Documents\GitHub\PPE\soka\soka\Resources\" & txtNomModele.Text & ".jpg")
            Me.Close()
            FrmCatalogue.Show()
        End If
        cnn.Close()
    End Sub

    Dim chemin As String
    Private Sub btnParcourir_Click(sender As Object, e As EventArgs) Handles btnParcourir.Click
        OpenFileDialog1.ShowDialog()

        chemin = OpenFileDialog1.FileName

        txtPhoto.Text = chemin

    End Sub
End Class