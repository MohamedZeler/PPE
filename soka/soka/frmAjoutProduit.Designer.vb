<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAjoutProduit
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNomModele = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrixBase = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMatiere = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtCouture = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtInitiales = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboCollection = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboPublic = New System.Windows.Forms.ComboBox()
        Me.TxtSemelleInterieure = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtSemelle = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtTalon = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtConfort = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtPlus = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtFermeture = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtPhoto = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnParcourir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNomModele
        '
        Me.txtNomModele.Location = New System.Drawing.Point(121, 6)
        Me.txtNomModele.Name = "txtNomModele"
        Me.txtNomModele.Size = New System.Drawing.Size(128, 20)
        Me.txtNomModele.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Location = New System.Drawing.Point(42, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom Modele :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Location = New System.Drawing.Point(58, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prix Base :"
        '
        'txtPrixBase
        '
        Me.txtPrixBase.Location = New System.Drawing.Point(121, 79)
        Me.txtPrixBase.Name = "txtPrixBase"
        Me.txtPrixBase.Size = New System.Drawing.Size(39, 20)
        Me.txtPrixBase.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label3.Location = New System.Drawing.Point(166, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "€"
        '
        'txtMatiere
        '
        Me.txtMatiere.Location = New System.Drawing.Point(121, 115)
        Me.txtMatiere.Name = "txtMatiere"
        Me.txtMatiere.Size = New System.Drawing.Size(128, 20)
        Me.txtMatiere.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label4.Location = New System.Drawing.Point(67, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Matiere :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label5.Location = New System.Drawing.Point(49, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Description :"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(121, 43)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(128, 20)
        Me.txtDescription.TabIndex = 2
        '
        'txtCouture
        '
        Me.txtCouture.Location = New System.Drawing.Point(121, 153)
        Me.txtCouture.Name = "txtCouture"
        Me.txtCouture.Size = New System.Drawing.Size(128, 20)
        Me.txtCouture.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label6.Location = New System.Drawing.Point(67, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Couture :"
        '
        'txtInitiales
        '
        Me.txtInitiales.Location = New System.Drawing.Point(121, 192)
        Me.txtInitiales.Name = "txtInitiales"
        Me.txtInitiales.Size = New System.Drawing.Size(128, 20)
        Me.txtInitiales.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label7.Location = New System.Drawing.Point(67, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Initiales:"
        '
        'cboCollection
        '
        Me.cboCollection.FormattingEnabled = True
        Me.cboCollection.Location = New System.Drawing.Point(123, 231)
        Me.cboCollection.Name = "cboCollection"
        Me.cboCollection.Size = New System.Drawing.Size(125, 21)
        Me.cboCollection.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label8.Location = New System.Drawing.Point(55, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Colection:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label9.Location = New System.Drawing.Point(66, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Public:"
        '
        'cboPublic
        '
        Me.cboPublic.FormattingEnabled = True
        Me.cboPublic.Location = New System.Drawing.Point(121, 271)
        Me.cboPublic.Name = "cboPublic"
        Me.cboPublic.Size = New System.Drawing.Size(125, 21)
        Me.cboPublic.TabIndex = 8
        '
        'TxtSemelleInterieure
        '
        Me.TxtSemelleInterieure.Location = New System.Drawing.Point(120, 309)
        Me.TxtSemelleInterieure.Name = "TxtSemelleInterieure"
        Me.TxtSemelleInterieure.Size = New System.Drawing.Size(128, 20)
        Me.TxtSemelleInterieure.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label10.Location = New System.Drawing.Point(8, 312)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Semelle Interieure :"
        '
        'TxtSemelle
        '
        Me.TxtSemelle.Location = New System.Drawing.Point(120, 346)
        Me.TxtSemelle.Name = "TxtSemelle"
        Me.TxtSemelle.Size = New System.Drawing.Size(128, 20)
        Me.TxtSemelle.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label11.Location = New System.Drawing.Point(55, 349)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Semelle :"
        '
        'TxtTalon
        '
        Me.TxtTalon.Location = New System.Drawing.Point(120, 383)
        Me.TxtTalon.Name = "TxtTalon"
        Me.TxtTalon.Size = New System.Drawing.Size(128, 20)
        Me.TxtTalon.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label12.Location = New System.Drawing.Point(65, 390)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Talon :"
        '
        'TxtConfort
        '
        Me.TxtConfort.Location = New System.Drawing.Point(120, 418)
        Me.TxtConfort.Name = "TxtConfort"
        Me.TxtConfort.Size = New System.Drawing.Size(128, 20)
        Me.TxtConfort.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label13.Location = New System.Drawing.Point(58, 421)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Confort :"
        '
        'TxtPlus
        '
        Me.TxtPlus.Location = New System.Drawing.Point(120, 454)
        Me.TxtPlus.Name = "TxtPlus"
        Me.TxtPlus.Size = New System.Drawing.Size(128, 20)
        Me.TxtPlus.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label14.Location = New System.Drawing.Point(69, 457)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Plus  :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(330, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 33)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Ajouter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtFermeture
        '
        Me.txtFermeture.Location = New System.Drawing.Point(120, 484)
        Me.txtFermeture.Name = "txtFermeture"
        Me.txtFermeture.Size = New System.Drawing.Size(128, 20)
        Me.txtFermeture.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label15.Location = New System.Drawing.Point(42, 487)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Fermeture  :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtPhoto
        '
        Me.txtPhoto.Location = New System.Drawing.Point(118, 521)
        Me.txtPhoto.Name = "txtPhoto"
        Me.txtPhoto.Size = New System.Drawing.Size(128, 20)
        Me.txtPhoto.TabIndex = 15
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label16.Location = New System.Drawing.Point(40, 524)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Photo  :"
        '
        'btnParcourir
        '
        Me.btnParcourir.Location = New System.Drawing.Point(252, 519)
        Me.btnParcourir.Name = "btnParcourir"
        Me.btnParcourir.Size = New System.Drawing.Size(75, 23)
        Me.btnParcourir.TabIndex = 17
        Me.btnParcourir.Text = "Parcourir"
        Me.btnParcourir.UseVisualStyleBackColor = True
        '
        'frmAjoutProduit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.soka.My.Resources.Resources.Fond_
        Me.ClientSize = New System.Drawing.Size(519, 569)
        Me.Controls.Add(Me.btnParcourir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cboPublic)
        Me.Controls.Add(Me.cboCollection)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrixBase)
        Me.Controls.Add(Me.txtInitiales)
        Me.Controls.Add(Me.txtCouture)
        Me.Controls.Add(Me.txtMatiere)
        Me.Controls.Add(Me.txtPhoto)
        Me.Controls.Add(Me.txtFermeture)
        Me.Controls.Add(Me.TxtPlus)
        Me.Controls.Add(Me.TxtConfort)
        Me.Controls.Add(Me.TxtTalon)
        Me.Controls.Add(Me.TxtSemelle)
        Me.Controls.Add(Me.TxtSemelleInterieure)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtNomModele)
        Me.Name = "frmAjoutProduit"
        Me.Text = "frmAjoutProduit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNomModele As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPrixBase As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMatiere As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtCouture As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtInitiales As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboCollection As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboPublic As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSemelleInterieure As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtSemelle As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtTalon As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtConfort As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtPlus As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtFermeture As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtPhoto As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnParcourir As System.Windows.Forms.Button
End Class
