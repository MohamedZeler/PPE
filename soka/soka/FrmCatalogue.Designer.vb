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
        CType(Me.picbo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.Line1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(667, 362)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
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
        Me.txtDescript.Location = New System.Drawing.Point(446, 175)
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
        Me.Label1.Location = New System.Drawing.Point(443, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Description :"
        '
        'picbo1
        '
        Me.picbo1.Location = New System.Drawing.Point(446, 12)
        Me.picbo1.Name = "picbo1"
        Me.picbo1.Size = New System.Drawing.Size(209, 121)
        Me.picbo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbo1.TabIndex = 12
        Me.picbo1.TabStop = False
        '
        'lstvModele
        '
        Me.lstvModele.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColModele, Me.ColPrix})
        Me.lstvModele.LargeImageList = Me.ImageList1
        Me.lstvModele.Location = New System.Drawing.Point(27, 36)
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
        'FrmCatalogue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.soka.My.Resources.Resources.Fond_
        Me.ClientSize = New System.Drawing.Size(667, 362)
        Me.Controls.Add(Me.lstvModele)
        Me.Controls.Add(Me.picbo1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescript)
        Me.Controls.Add(Me.btnModif)
        Me.Controls.Add(Me.btnSuppr)
        Me.Controls.Add(Me.btnAjout)
        Me.Controls.Add(Me.ShapeContainer1)
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
End Class
