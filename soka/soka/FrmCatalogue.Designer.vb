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
        Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnAjout = New System.Windows.Forms.Button()
        Me.btnSuppr = New System.Windows.Forms.Button()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.txtDescript = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Line1
        '
        Me.Line1.Name = "Line1"
        Me.Line1.X1 = 409
        Me.Line1.X2 = 665
        Me.Line1.Y1 = 326
        Me.Line1.Y2 = 326
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 409
        Me.LineShape1.X2 = 409
        Me.LineShape1.Y1 = -1
        Me.LineShape1.Y2 = 326
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
        Me.btnSuppr.Location = New System.Drawing.Point(335, 372)
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.soka.My.Resources.Resources.chaussure_soka
        Me.PictureBox1.Location = New System.Drawing.Point(446, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 127)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(205, 45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(63, 54)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(206, 150)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(61, 54)
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(325, 150)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(58, 54)
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(325, 45)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(58, 54)
        Me.PictureBox5.TabIndex = 10
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(94, 45)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(64, 54)
        Me.PictureBox6.TabIndex = 11
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Location = New System.Drawing.Point(325, 254)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(64, 54)
        Me.PictureBox7.TabIndex = 12
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Location = New System.Drawing.Point(204, 254)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(64, 54)
        Me.PictureBox8.TabIndex = 13
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Location = New System.Drawing.Point(94, 254)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(64, 54)
        Me.PictureBox9.TabIndex = 14
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Location = New System.Drawing.Point(94, 150)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(64, 54)
        Me.PictureBox10.TabIndex = 15
        Me.PictureBox10.TabStop = False
        '
        'FrmCatalogue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 466)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescript)
        Me.Controls.Add(Me.btnModif)
        Me.Controls.Add(Me.btnSuppr)
        Me.Controls.Add(Me.btnAjout)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "FrmCatalogue"
        Me.Text = "FrmCatalogue"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
End Class
