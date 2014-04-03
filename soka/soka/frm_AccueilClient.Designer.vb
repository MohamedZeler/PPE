<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AccueilClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AccueilClient))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btn_consulterliste = New System.Windows.Forms.Button()
        Me.btn_newprospect = New System.Windows.Forms.Button()
        Me.txt_nomprospect = New System.Windows.Forms.TextBox()
        Me.txt_prenomprospect = New System.Windows.Forms.TextBox()
        Me.lbl_nomprospect = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_searchprospect = New System.Windows.Forms.Button()
        Me.btn_journalactivite = New System.Windows.Forms.Button()
        Me.btn_newaction = New System.Windows.Forms.Button()
        Me.btn_relance = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label1.Location = New System.Drawing.Point(121, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gestion Commerciale"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(505, 319)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 257
        Me.LineShape1.X2 = 257
        Me.LineShape1.Y1 = 65
        Me.LineShape1.Y2 = 303
        '
        'btn_consulterliste
        '
        Me.btn_consulterliste.Location = New System.Drawing.Point(67, 96)
        Me.btn_consulterliste.Name = "btn_consulterliste"
        Me.btn_consulterliste.Size = New System.Drawing.Size(160, 41)
        Me.btn_consulterliste.TabIndex = 2
        Me.btn_consulterliste.Text = "Liste des prospects"
        Me.btn_consulterliste.UseVisualStyleBackColor = True
        '
        'btn_newprospect
        '
        Me.btn_newprospect.Location = New System.Drawing.Point(67, 232)
        Me.btn_newprospect.Name = "btn_newprospect"
        Me.btn_newprospect.Size = New System.Drawing.Size(160, 41)
        Me.btn_newprospect.TabIndex = 3
        Me.btn_newprospect.Text = "Nouveau prospect"
        Me.btn_newprospect.UseVisualStyleBackColor = True
        '
        'txt_nomprospect
        '
        Me.txt_nomprospect.Location = New System.Drawing.Point(127, 143)
        Me.txt_nomprospect.Name = "txt_nomprospect"
        Me.txt_nomprospect.Size = New System.Drawing.Size(100, 20)
        Me.txt_nomprospect.TabIndex = 4
        '
        'txt_prenomprospect
        '
        Me.txt_prenomprospect.Location = New System.Drawing.Point(127, 169)
        Me.txt_prenomprospect.Name = "txt_prenomprospect"
        Me.txt_prenomprospect.Size = New System.Drawing.Size(100, 20)
        Me.txt_prenomprospect.TabIndex = 5
        '
        'lbl_nomprospect
        '
        Me.lbl_nomprospect.AutoSize = True
        Me.lbl_nomprospect.Location = New System.Drawing.Point(64, 146)
        Me.lbl_nomprospect.Name = "lbl_nomprospect"
        Me.lbl_nomprospect.Size = New System.Drawing.Size(38, 13)
        Me.lbl_nomprospect.TabIndex = 6
        Me.lbl_nomprospect.Text = "Nom : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Prénom : "
        '
        'btn_searchprospect
        '
        Me.btn_searchprospect.Location = New System.Drawing.Point(152, 195)
        Me.btn_searchprospect.Name = "btn_searchprospect"
        Me.btn_searchprospect.Size = New System.Drawing.Size(75, 23)
        Me.btn_searchprospect.TabIndex = 8
        Me.btn_searchprospect.Text = "Rechercher"
        Me.btn_searchprospect.UseVisualStyleBackColor = True
        '
        'btn_journalactivite
        '
        Me.btn_journalactivite.Location = New System.Drawing.Point(288, 96)
        Me.btn_journalactivite.Name = "btn_journalactivite"
        Me.btn_journalactivite.Size = New System.Drawing.Size(160, 41)
        Me.btn_journalactivite.TabIndex = 9
        Me.btn_journalactivite.Text = "Journal d'activité"
        Me.btn_journalactivite.UseVisualStyleBackColor = True
        '
        'btn_newaction
        '
        Me.btn_newaction.Location = New System.Drawing.Point(288, 158)
        Me.btn_newaction.Name = "btn_newaction"
        Me.btn_newaction.Size = New System.Drawing.Size(160, 41)
        Me.btn_newaction.TabIndex = 10
        Me.btn_newaction.Text = "Nouvelle action"
        Me.btn_newaction.UseVisualStyleBackColor = True
        '
        'btn_relance
        '
        Me.btn_relance.Location = New System.Drawing.Point(288, 216)
        Me.btn_relance.Name = "btn_relance"
        Me.btn_relance.Size = New System.Drawing.Size(160, 41)
        Me.btn_relance.TabIndex = 11
        Me.btn_relance.Text = "Relances"
        Me.btn_relance.UseVisualStyleBackColor = True
        '
        'frm_AccueilClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< HEAD
        Me.BackgroundImage = Global.soka.My.Resources.Resources.Fond_
=======
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
>>>>>>> 4ad8fcd014bc873c66b05c43f38b605288e5ab12
        Me.ClientSize = New System.Drawing.Size(505, 319)
        Me.Controls.Add(Me.btn_relance)
        Me.Controls.Add(Me.btn_newaction)
        Me.Controls.Add(Me.btn_journalactivite)
        Me.Controls.Add(Me.btn_searchprospect)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_nomprospect)
        Me.Controls.Add(Me.txt_prenomprospect)
        Me.Controls.Add(Me.txt_nomprospect)
        Me.Controls.Add(Me.btn_newprospect)
        Me.Controls.Add(Me.btn_consulterliste)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frm_AccueilClient"
        Me.Text = "frm_AccueilClient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btn_consulterliste As System.Windows.Forms.Button
    Friend WithEvents btn_newprospect As System.Windows.Forms.Button
    Friend WithEvents txt_nomprospect As System.Windows.Forms.TextBox
    Friend WithEvents txt_prenomprospect As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nomprospect As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_searchprospect As System.Windows.Forms.Button
    Friend WithEvents btn_journalactivite As System.Windows.Forms.Button
    Friend WithEvents btn_newaction As System.Windows.Forms.Button
    Friend WithEvents btn_relance As System.Windows.Forms.Button
End Class
