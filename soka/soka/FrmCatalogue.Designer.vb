<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCatalogue
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
        Me.components = New System.ComponentModel.Container()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnAjout = New System.Windows.Forms.Button()
        Me.btnSuppr = New System.Windows.Forms.Button()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.txtDescript = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picbo1 = New System.Windows.Forms.PictureBox()
        Me.lstvModele = New System.Windows.Forms.ListView()
        Me.ColModele = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColPrix = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblInitiales = New System.Windows.Forms.Label()
        Me.lblSemelles = New System.Windows.Forms.Label()
        Me.lblCouture = New System.Windows.Forms.Label()
        Me.lblMatiere = New System.Windows.Forms.Label()
        Me.lblPrix = New System.Windows.Forms.Label()
        Me.lblSemellesInterieures = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblFermeture = New System.Windows.Forms.Label()
        Me.lblTalon = New System.Windows.Forms.Label()
        Me.lblConfort = New System.Windows.Forms.Label()
        Me.lblPublic = New System.Windows.Forms.Label()
        Me.lblPlus = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblCollection = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblPointure = New System.Windows.Forms.Label()
        Me.btn_agrandir = New System.Windows.Forms.Button()
        CType(Me.picbo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1, Me.LineShape1, Me.Line1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1177, 362)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.White
        Me.RectangleShape1.FillColor = System.Drawing.Color.White
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(674, 25)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(461, 297)
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 409
        Me.LineShape1.X2 = 409
        Me.LineShape1.Y1 = -1
        Me.LineShape1.Y2 = 326
        '
        'Line1
        '
        Me.Line1.Name = "Line1"
        Me.Line1.X1 = 409
        Me.Line1.X2 = 665
        Me.Line1.Y1 = 326
        Me.Line1.Y2 = 326
        '
        'btnAjout
        '
        Me.btnAjout.Location = New System.Drawing.Point(36, 326)
        Me.btnAjout.Name = "btnAjout"
        Me.btnAjout.Size = New System.Drawing.Size(75, 23)
        Me.btnAjout.TabIndex = 1
        Me.btnAjout.Text = "Ajouter"
        Me.btnAjout.UseVisualStyleBackColor = True
        '
        'btnSuppr
        '
        Me.btnSuppr.Location = New System.Drawing.Point(446, 295)
        Me.btnSuppr.Name = "btnSuppr"
        Me.btnSuppr.Size = New System.Drawing.Size(75, 23)
        Me.btnSuppr.TabIndex = 2
        Me.btnSuppr.Text = "Supprimer"
        Me.btnSuppr.UseVisualStyleBackColor = True
        '
        'btnModif
        '
        Me.btnModif.Location = New System.Drawing.Point(580, 295)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(75, 23)
        Me.btnModif.TabIndex = 3
        Me.btnModif.Text = "Modifier"
        Me.btnModif.UseVisualStyleBackColor = True
        '
        'txtDescript
        '
        Me.txtDescript.Location = New System.Drawing.Point(446, 193)
        Me.txtDescript.Name = "txtDescript"
        Me.txtDescript.Size = New System.Drawing.Size(209, 96)
        Me.txtDescript.TabIndex = 4
        Me.txtDescript.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Location = New System.Drawing.Point(443, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Description :"
        '
        'picbo1
        '
        Me.picbo1.Location = New System.Drawing.Point(446, 8)
        Me.picbo1.Name = "picbo1"
        Me.picbo1.Size = New System.Drawing.Size(150, 150)
        Me.picbo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbo1.TabIndex = 12
        Me.picbo1.TabStop = False
        '
        'lstvModele
        '
        Me.lstvModele.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColModele, Me.ColPrix})
        Me.lstvModele.LargeImageList = Me.ImageList1
        Me.lstvModele.Location = New System.Drawing.Point(27, 36)
        Me.lstvModele.MultiSelect = False
        Me.lstvModele.Name = "lstvModele"
        Me.lstvModele.Size = New System.Drawing.Size(353, 235)
        Me.lstvModele.TabIndex = 13
        Me.lstvModele.UseCompatibleStateImageBehavior = False
        '
        'ColModele
        '
        Me.ColModele.Text = "Modele"
        '
        'ColPrix
        '
        Me.ColPrix.Text = "Prix"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(60, 60)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(699, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Prix:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(699, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Label2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(699, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Matiere:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(699, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Label2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(699, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Couture:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(699, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Semelles:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(699, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Initiales:"
        '
        'lblInitiales
        '
        Me.lblInitiales.AutoSize = True
        Me.lblInitiales.BackColor = System.Drawing.Color.White
        Me.lblInitiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInitiales.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblInitiales.Location = New System.Drawing.Point(794, 176)
        Me.lblInitiales.Name = "lblInitiales"
        Me.lblInitiales.Size = New System.Drawing.Size(63, 20)
        Me.lblInitiales.TabIndex = 16
        Me.lblInitiales.Text = "Label2"
        '
        'lblSemelles
        '
        Me.lblSemelles.AutoSize = True
        Me.lblSemelles.BackColor = System.Drawing.Color.White
        Me.lblSemelles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemelles.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSemelles.Location = New System.Drawing.Point(794, 251)
        Me.lblSemelles.Name = "lblSemelles"
        Me.lblSemelles.Size = New System.Drawing.Size(63, 20)
        Me.lblSemelles.TabIndex = 17
        Me.lblSemelles.Text = "Label2"
        '
        'lblCouture
        '
        Me.lblCouture.AutoSize = True
        Me.lblCouture.BackColor = System.Drawing.Color.White
        Me.lblCouture.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCouture.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCouture.Location = New System.Drawing.Point(794, 138)
        Me.lblCouture.Name = "lblCouture"
        Me.lblCouture.Size = New System.Drawing.Size(63, 20)
        Me.lblCouture.TabIndex = 18
        Me.lblCouture.Text = "Label2"
        '
        'lblMatiere
        '
        Me.lblMatiere.AutoSize = True
        Me.lblMatiere.BackColor = System.Drawing.Color.White
        Me.lblMatiere.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatiere.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMatiere.Location = New System.Drawing.Point(794, 102)
        Me.lblMatiere.Name = "lblMatiere"
        Me.lblMatiere.Size = New System.Drawing.Size(63, 20)
        Me.lblMatiere.TabIndex = 19
        Me.lblMatiere.Text = "Label2"
        '
        'lblPrix
        '
        Me.lblPrix.AutoSize = True
        Me.lblPrix.BackColor = System.Drawing.Color.White
        Me.lblPrix.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrix.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPrix.Location = New System.Drawing.Point(794, 55)
        Me.lblPrix.Name = "lblPrix"
        Me.lblPrix.Size = New System.Drawing.Size(73, 20)
        Me.lblPrix.TabIndex = 20
        Me.lblPrix.Text = "Label13"
        '
        'lblSemellesInterieures
        '
        Me.lblSemellesInterieures.AutoSize = True
        Me.lblSemellesInterieures.BackColor = System.Drawing.Color.White
        Me.lblSemellesInterieures.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemellesInterieures.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSemellesInterieures.Location = New System.Drawing.Point(794, 216)
        Me.lblSemellesInterieures.Name = "lblSemellesInterieures"
        Me.lblSemellesInterieures.Size = New System.Drawing.Size(63, 20)
        Me.lblSemellesInterieures.TabIndex = 17
        Me.lblSemellesInterieures.Text = "Label2"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(874, 55)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 20)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Fermeture:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(874, 102)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 20)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Talon"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(874, 138)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 20)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "Confort:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(874, 251)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 20)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "Public:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(874, 176)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 20)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "Plus:"
        '
        'lblFermeture
        '
        Me.lblFermeture.AutoSize = True
        Me.lblFermeture.BackColor = System.Drawing.Color.White
        Me.lblFermeture.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFermeture.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFermeture.Location = New System.Drawing.Point(975, 55)
        Me.lblFermeture.Name = "lblFermeture"
        Me.lblFermeture.Size = New System.Drawing.Size(73, 20)
        Me.lblFermeture.TabIndex = 20
        Me.lblFermeture.Text = "Label13"
        '
        'lblTalon
        '
        Me.lblTalon.AutoSize = True
        Me.lblTalon.BackColor = System.Drawing.Color.White
        Me.lblTalon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTalon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTalon.Location = New System.Drawing.Point(975, 102)
        Me.lblTalon.Name = "lblTalon"
        Me.lblTalon.Size = New System.Drawing.Size(63, 20)
        Me.lblTalon.TabIndex = 19
        Me.lblTalon.Text = "Label2"
        '
        'lblConfort
        '
        Me.lblConfort.AutoSize = True
        Me.lblConfort.BackColor = System.Drawing.Color.White
        Me.lblConfort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfort.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblConfort.Location = New System.Drawing.Point(975, 138)
        Me.lblConfort.Name = "lblConfort"
        Me.lblConfort.Size = New System.Drawing.Size(63, 20)
        Me.lblConfort.TabIndex = 18
        Me.lblConfort.Text = "Label2"
        '
        'lblPublic
        '
        Me.lblPublic.AutoSize = True
        Me.lblPublic.BackColor = System.Drawing.Color.White
        Me.lblPublic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublic.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPublic.Location = New System.Drawing.Point(975, 251)
        Me.lblPublic.Name = "lblPublic"
        Me.lblPublic.Size = New System.Drawing.Size(63, 20)
        Me.lblPublic.TabIndex = 17
        Me.lblPublic.Text = "Label2"
        '
        'lblPlus
        '
        Me.lblPlus.AutoSize = True
        Me.lblPlus.BackColor = System.Drawing.Color.White
        Me.lblPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPlus.Location = New System.Drawing.Point(975, 176)
        Me.lblPlus.Name = "lblPlus"
        Me.lblPlus.Size = New System.Drawing.Size(63, 20)
        Me.lblPlus.TabIndex = 16
        Me.lblPlus.Text = "Label2"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(874, 216)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(93, 20)
        Me.Label26.TabIndex = 15
        Me.Label26.Text = "Collection:"
        '
        'lblCollection
        '
        Me.lblCollection.AutoSize = True
        Me.lblCollection.BackColor = System.Drawing.Color.White
        Me.lblCollection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCollection.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCollection.Location = New System.Drawing.Point(975, 216)
        Me.lblCollection.Name = "lblCollection"
        Me.lblCollection.Size = New System.Drawing.Size(63, 20)
        Me.lblCollection.TabIndex = 17
        Me.lblCollection.Text = "Label2"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(686, 206)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(82, 20)
        Me.Label29.TabIndex = 15
        Me.Label29.Text = "Semelles"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.White
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(685, 226)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(101, 20)
        Me.Label30.TabIndex = 15
        Me.Label30.Text = "Interieures:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(874, 283)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Pointure :"
        '
        'lblPointure
        '
        Me.lblPointure.AutoSize = True
        Me.lblPointure.BackColor = System.Drawing.Color.White
        Me.lblPointure.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointure.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPointure.Location = New System.Drawing.Point(975, 283)
        Me.lblPointure.Name = "lblPointure"
        Me.lblPointure.Size = New System.Drawing.Size(63, 20)
        Me.lblPointure.TabIndex = 22
        Me.lblPointure.Text = "Label2"
        '
        'btn_agrandir
        '
        Me.btn_agrandir.Location = New System.Drawing.Point(626, 25)
        Me.btn_agrandir.Name = "btn_agrandir"
        Me.btn_agrandir.Size = New System.Drawing.Size(26, 23)
        Me.btn_agrandir.TabIndex = 23
        Me.btn_agrandir.Text = "Button1"
        Me.btn_agrandir.UseVisualStyleBackColor = True
        '
        'FrmCatalogue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.soka.My.Resources.Resources.Fond_
        Me.ClientSize = New System.Drawing.Size(1177, 362)
        Me.Controls.Add(Me.btn_agrandir)
        Me.Controls.Add(Me.lblPointure)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.lblCollection)
        Me.Controls.Add(Me.lblFermeture)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblPlus)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblPublic)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblConfort)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblTalon)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lblSemellesInterieures)
        Me.Controls.Add(Me.lblInitiales)
        Me.Controls.Add(Me.lblSemelles)
        Me.Controls.Add(Me.lblCouture)
        Me.Controls.Add(Me.lblMatiere)
        Me.Controls.Add(Me.lblPrix)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstvModele)
        Me.Controls.Add(Me.picbo1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescript)
        Me.Controls.Add(Me.btnModif)
        Me.Controls.Add(Me.btnSuppr)
        Me.Controls.Add(Me.btnAjout)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmCatalogue"
        Me.Text = "FrmCatalogue"
        CType(Me.picbo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btnAjout As System.Windows.Forms.Button
    Friend WithEvents btnSuppr As System.Windows.Forms.Button
    Friend WithEvents btnModif As System.Windows.Forms.Button
    Friend WithEvents txtDescript As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picbo1 As System.Windows.Forms.PictureBox
    Friend WithEvents lstvModele As System.Windows.Forms.ListView
    Friend WithEvents ColModele As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColPrix As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblInitiales As System.Windows.Forms.Label
    Friend WithEvents lblSemelles As System.Windows.Forms.Label
    Friend WithEvents lblCouture As System.Windows.Forms.Label
    Friend WithEvents lblMatiere As System.Windows.Forms.Label
    Friend WithEvents lblPrix As System.Windows.Forms.Label
    Friend WithEvents lblSemellesInterieures As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblFermeture As System.Windows.Forms.Label
    Friend WithEvents lblTalon As System.Windows.Forms.Label
    Friend WithEvents lblConfort As System.Windows.Forms.Label
    Friend WithEvents lblPublic As System.Windows.Forms.Label
    Friend WithEvents lblPlus As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lblCollection As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblPointure As System.Windows.Forms.Label
    Friend WithEvents btn_agrandir As System.Windows.Forms.Button
End Class
