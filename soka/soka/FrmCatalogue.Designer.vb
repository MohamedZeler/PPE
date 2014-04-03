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
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnAjout = New System.Windows.Forms.Button()
        Me.btnSuppr = New System.Windows.Forms.Button()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.txtDescript = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.img = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.picbo1 = New System.Windows.Forms.PictureBox()
        Me.img2 = New System.Windows.Forms.Button()
        Me.img1 = New System.Windows.Forms.Button()
        CType(Me.picbo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.Line1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(667, 466)
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
        Me.btnAjout.Location = New System.Drawing.Point(33, 372)
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
        Me.Label1.Location = New System.Drawing.Point(443, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Description :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 80)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "\d(-_-)b/"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'img
        '
        Me.img.Location = New System.Drawing.Point(24, 12)
        Me.img.Name = "img"
        Me.img.Size = New System.Drawing.Size(80, 80)
        Me.img.TabIndex = 8
        Me.img.Text = "(_- | )"
        Me.img.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(261, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 80)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "(/-_-)/"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(261, 132)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 80)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "( | -_)"
        Me.Button5.UseVisualStyleBackColor = True
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
        'img2
        '
        Me.img2.Image = Global.soka.My.Resources.Resources.ttipi
        Me.img2.Location = New System.Drawing.Point(139, 132)
        Me.img2.Name = "img2"
        Me.img2.Size = New System.Drawing.Size(80, 80)
        Me.img2.TabIndex = 11
        Me.img2.UseVisualStyleBackColor = True
        '
        'img1
        '
        Me.img1.Image = Global.soka.My.Resources.Resources.s_de_soka
        Me.img1.Location = New System.Drawing.Point(139, 12)
        Me.img1.Name = "img1"
        Me.img1.Size = New System.Drawing.Size(80, 80)
        Me.img1.TabIndex = 7
        Me.img1.UseVisualStyleBackColor = True
        '
        'FrmCatalogue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 466)
        Me.Controls.Add(Me.picbo1)
        Me.Controls.Add(Me.img2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.img)
        Me.Controls.Add(Me.img1)
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents img1 As System.Windows.Forms.Button
    Friend WithEvents img As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents img2 As System.Windows.Forms.Button
    Friend WithEvents picbo1 As System.Windows.Forms.PictureBox
End Class
