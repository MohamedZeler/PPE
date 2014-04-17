Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class FrmCatalogue

   
    Dim cnn As SqlConnection

    Private Sub FrmCatalogue_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        ajoutModifCatalogue = 0

        btn_agrandir.Text = "+"
        Me.Width = 680

        'cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=SI6_CVV;User ID=SIO1;Password=SIO1MDP")
        cnn = New SqlConnection("Data Source=ADRIEN-PC;Initial Catalog=SOKA_Gestion;User ID=SIO1;Password=SIO1_MDP")
        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "SELECT NomModele, PrixBase FROM MODELE"
        Dim jeuEnr As SqlDataReader
        jeuEnr = cmd.ExecuteReader
        Dim i As Integer
        i = 0
        While jeuEnr.Read

            lstvModele.Items.Add(jeuEnr.GetValue(0))
            ImageList1.Images.Add(jeuEnr.GetValue(0), Image.FromFile("C:\Users\adrien\Documents\GitHub\PPE\soka\soka\Resources\" & jeuEnr.GetValue(0) & ".jpg"))
            lstvModele.Items(i).ImageKey = jeuEnr.GetValue(0)
            lstvModele.Items(i).Name = jeuEnr.GetValue(0)
            i = i + 1
        End While



        lblPrix.Text = "--"
        lblMatiere.Text = "--"
        lblCouture.Text = "--"
        lblInitiales.Text = "--"
        lblSemellesInterieures.Text = "--"
        lblSemelles.Text = "--"
        lblFermeture.Text = "--"
        lblTalon.Text = "--"
        lblConfort.Text = "--"
        lblPlus.Text = "--"
        lblPublic.Text = "--"
        lblPointure.Text = "--"
        lblCollection.Text = "--"



    End Sub

    


    Private Sub btnAjout_Click(sender As Object, e As EventArgs) Handles btnAjout.Click
        ajoutModifCatalogue = 1
        Me.Close()
        frmAjoutProduit.Show()

    End Sub

   



    Private Sub lstvModele_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstvModele.SelectedIndexChanged
        Dim test As ListViewItem
        Dim NomModele As String



        If lstvModele.SelectedItems.Count = 1 Then
            test = lstvModele.SelectedItems.Item(0)
            picbo1.ImageLocation = "C:\Users\adrien\Documents\GitHub\PPE\soka\soka\Resources\" & test.Name & ".jpg"

            NomModele = test.Name

            Dim cnn As SqlConnection
            Dim cmd As SqlCommand

            'cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=SI6_CVV;User ID=SIO1;Password=SIO1MDP")
            cnn = New SqlConnection("Data Source=ADRIEN-PC;Initial Catalog=SOKA_Gestion;User ID=SIO1;Password=SIO1_MDP")
            cnn.Open()

            cmd = New SqlCommand()
            cmd.Connection = cnn

            cmd.CommandText = "SELECT Descriptif, PrixBase, Matiere, Couture, Initiales, SemellesInterieures, Semelle, Fermeture, TalonF, Confort, Plus, IntitulePublic, PointureMini, PointureMaxi, IntituleCollection, Annee FROM MODELE M, PUBLIC2 P, COLLECTION C WHERE M.IdCollection = C.IdCollection AND P.CodePublic = M.CodePublic AND NomModele = '" & NomModele & "'"

            Dim JeuEnr As SqlDataReader
            JeuEnr = cmd.ExecuteReader
            JeuEnr.Read()

            txtDescript.Text = JeuEnr.GetValue(0)
            lblPrix.Text = JeuEnr.GetValue(1)
            lblMatiere.Text = JeuEnr.GetValue(2)
            lblCouture.Text = JeuEnr.GetValue(3)
            lblInitiales.Text = JeuEnr.GetValue(4)
            lblSemellesInterieures.Text = JeuEnr.GetValue(5)
            lblSemelles.Text = JeuEnr.GetValue(6)
            lblFermeture.Text = JeuEnr.GetValue(7)
            lblTalon.Text = JeuEnr.GetValue(8)
            lblConfort.Text = JeuEnr.GetValue(9)
            lblPlus.Text = JeuEnr.GetValue(10)
            lblPublic.Text = JeuEnr.GetValue(11)
            lblPointure.Text = JeuEnr.GetValue(12) & " - " & JeuEnr.GetValue(13)
            lblCollection.Text = JeuEnr.GetValue(14) & " " & JeuEnr.GetValue(15)




        End If

    End Sub

    

    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click

        Dim test As ListViewItem

        If lstvModele.SelectedItems.Count = 1 Then


            test = lstvModele.SelectedItems.Item(0)
            IntituleModelePublic = test.Name
            ajoutModifCatalogue = 2
            Me.Close()
            frmAjoutProduit.Show()

        End If
    End Sub

    Private Sub btnSuppr_Click(sender As Object, e As EventArgs) Handles btnSuppr.Click
        If lstvModele.SelectedItems.Count = 1 Then
            If MsgBox("Êtes vous certain de supprimer ce modele ?", vbYesNo, "Demande de confirmation") = vbYes Then
                Dim cnn As SqlConnection
                cnn = New SqlConnection
                cnn = New SqlConnection("Data Source=ADRIEN-PC;Initial Catalog=SOKA_Gestion;User ID=SIO1;Password=SIO1_MDP")
                cnn.Open()
                Dim cmd As SqlCommand
                cmd = New SqlCommand
                cmd.Connection = cnn
                cmd.CommandText = "DELETE FROM MODELE WHERE NomModele='" & lstvModele.SelectedItems.Item(0).Name & "'"
                cmd.ExecuteNonQuery()
                cnn.Close()

                Me.Close()


            End If
        End If
    End Sub

    Private Sub btn_agrandir_Click(sender As Object, e As EventArgs) Handles btn_agrandir.Click

        If Me.Width < 1200 Then


            Me.Width = 1200
            btn_agrandir.Text = "-"
        ElseIf Me.Width >= 1200 Then
            Me.Width = 680
            btn_agrandir.Text = "+"
        End If

    End Sub
End Class