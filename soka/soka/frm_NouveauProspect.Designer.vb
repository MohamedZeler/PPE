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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
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
        Me.txt_nomprospect.Location = New System.Drawing.Point(64, 103)
        Me.txt_nomprospect.Name = "txt_nomprospect"
        Me.txt_nomprospect.Size = New System.Drawing.Size(100, 20)
        Me.txt_nomprospect.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nom : "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(64, 129)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 132)
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
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(64, 171)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 8
        '
        'frm_NouveauProspect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 329)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nomprospect)
        Me.Controls.Add(Me.rbtn_monsieur)
        Me.Controls.Add(Me.rbtn_madame)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_NouveauProspect"
        Me.Text = "frm_NouveauProspect"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbtn_madame As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_monsieur As System.Windows.Forms.RadioButton
    Friend WithEvents txt_nomprospect As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
