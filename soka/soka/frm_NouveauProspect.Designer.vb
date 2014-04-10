<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_NouveauProspect
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbtn_madame = New System.Windows.Forms.RadioButton()
        Me.rbtn_monsieur = New System.Windows.Forms.RadioButton()
        Me.txt_nomprospect = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_prenomprospect = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_mailprospect = New System.Windows.Forms.TextBox()
        Me.txt_teldomicile = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_telportable = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbox_entreprises = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_addprospect = New System.Windows.Forms.Button()
        Me.btn_addentreprise = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label1.Location = New System.Drawing.Point(23, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nouveau Prospect"
        '
        'rbtn_madame
        '
        Me.rbtn_madame.AutoSize = True
        Me.rbtn_madame.Location = New System.Drawing.Point(64, 71)
        Me.rbtn_madame.Name = "rbtn_madame"
        Me.rbtn_madame.Size = New System.Drawing.Size(66, 17)
        Me.rbtn_madame.TabIndex = 1
        Me.rbtn_madame.TabStop = True
        Me.rbtn_madame.Text = "Madame"
        Me.rbtn_madame.UseVisualStyleBackColor = True
        '
        'rbtn_monsieur
        '
        Me.rbtn_monsieur.AutoSize = True
        Me.rbtn_monsieur.Location = New System.Drawing.Point(136, 71)
        Me.rbtn_monsieur.Name = "rbtn_monsieur"
        Me.rbtn_monsieur.Size = New System.Drawing.Size(68, 17)
        Me.rbtn_monsieur.TabIndex = 2
        Me.rbtn_monsieur.TabStop = True
        Me.rbtn_monsieur.Text = "Monsieur"
        Me.rbtn_monsieur.UseVisualStyleBackColor = True
        '
        'txt_nomprospect
        '
        Me.txt_nomprospect.Location = New System.Drawing.Point(64, 94)
        Me.txt_nomprospect.Name = "txt_nomprospect"
        Me.txt_nomprospect.Size = New System.Drawing.Size(100, 20)
        Me.txt_nomprospect.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nom : "
        '
        'txt_prenomprospect
        '
        Me.txt_prenomprospect.Location = New System.Drawing.Point(64, 120)
        Me.txt_prenomprospect.Name = "txt_prenomprospect"
        Me.txt_prenomprospect.Size = New System.Drawing.Size(100, 20)
        Me.txt_prenomprospect.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Prénom :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Mail : "
        '
        'txt_mailprospect
        '
        Me.txt_mailprospect.Location = New System.Drawing.Point(64, 171)
        Me.txt_mailprospect.Name = "txt_mailprospect"
        Me.txt_mailprospect.Size = New System.Drawing.Size(136, 20)
        Me.txt_mailprospect.TabIndex = 8
        '
        'txt_teldomicile
        '
        Me.txt_teldomicile.Location = New System.Drawing.Point(84, 23)
        Me.txt_teldomicile.Name = "txt_teldomicile"
        Me.txt_teldomicile.Size = New System.Drawing.Size(100, 20)
        Me.txt_teldomicile.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Domicile :"
        '
        'txt_telportable
        '
        Me.txt_telportable.Location = New System.Drawing.Point(84, 47)
        Me.txt_telportable.Name = "txt_telportable"
        Me.txt_telportable.Size = New System.Drawing.Size(100, 20)
        Me.txt_telportable.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Portable :"
        '
        'cmbox_entreprises
        '
        Me.cmbox_entreprises.FormattingEnabled = True
        Me.cmbox_entreprises.Location = New System.Drawing.Point(82, 314)
        Me.cmbox_entreprises.Name = "cmbox_entreprises"
        Me.cmbox_entreprises.Size = New System.Drawing.Size(121, 21)
        Me.cmbox_entreprises.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 317)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Entreprise :"
        '
        'btn_addprospect
        '
        Me.btn_addprospect.Location = New System.Drawing.Point(103, 341)
        Me.btn_addprospect.Name = "btn_addprospect"
        Me.btn_addprospect.Size = New System.Drawing.Size(75, 23)
        Me.btn_addprospect.TabIndex = 17
        Me.btn_addprospect.Text = "Ajouter"
        Me.btn_addprospect.UseVisualStyleBackColor = True
        '
        'btn_addentreprise
        '
        Me.btn_addentreprise.Location = New System.Drawing.Point(209, 307)
        Me.btn_addentreprise.Name = "btn_addentreprise"
        Me.btn_addentreprise.Size = New System.Drawing.Size(37, 32)
        Me.btn_addentreprise.TabIndex = 18
        Me.btn_addentreprise.Text = "+"
        Me.btn_addentreprise.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_telportable)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_teldomicile)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 206)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 78)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Téléphone"
        '
        'frm_NouveauProspect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.soka.My.Resources.Resources.Fond_
        Me.ClientSize = New System.Drawing.Size(284, 383)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_addentreprise)
        Me.Controls.Add(Me.btn_addprospect)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbox_entreprises)
        Me.Controls.Add(Me.txt_mailprospect)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_prenomprospect)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nomprospect)
        Me.Controls.Add(Me.rbtn_monsieur)
        Me.Controls.Add(Me.rbtn_madame)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_NouveauProspect"
        Me.Text = "frm_NouveauProspect"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbtn_madame As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_monsieur As System.Windows.Forms.RadioButton
    Friend WithEvents txt_nomprospect As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_prenomprospect As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_mailprospect As System.Windows.Forms.TextBox
    Friend WithEvents txt_teldomicile As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_telportable As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbox_entreprises As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_addprospect As System.Windows.Forms.Button
    Friend WithEvents btn_addentreprise As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
