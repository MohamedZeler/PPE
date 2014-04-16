<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_NewAction
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
        Me.txt_dateaction = New System.Windows.Forms.TextBox()
        Me.txt_commentaire = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_contact = New System.Windows.Forms.ComboBox()
        Me.cbo_typeaction = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chk_relance = New System.Windows.Forms.CheckBox()
        Me.txt_daterelance = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_ajouteraction = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date de l'action :"
        '
        'txt_dateaction
        '
        Me.txt_dateaction.Location = New System.Drawing.Point(129, 47)
        Me.txt_dateaction.Name = "txt_dateaction"
        Me.txt_dateaction.Size = New System.Drawing.Size(100, 20)
        Me.txt_dateaction.TabIndex = 1
        '
        'txt_commentaire
        '
        Me.txt_commentaire.Location = New System.Drawing.Point(129, 73)
        Me.txt_commentaire.Name = "txt_commentaire"
        Me.txt_commentaire.Size = New System.Drawing.Size(206, 113)
        Me.txt_commentaire.TabIndex = 2
        Me.txt_commentaire.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Commentaire :"
        '
        'cbo_contact
        '
        Me.cbo_contact.FormattingEnabled = True
        Me.cbo_contact.Location = New System.Drawing.Point(129, 230)
        Me.cbo_contact.Name = "cbo_contact"
        Me.cbo_contact.Size = New System.Drawing.Size(121, 21)
        Me.cbo_contact.TabIndex = 4
        '
        'cbo_typeaction
        '
        Me.cbo_typeaction.FormattingEnabled = True
        Me.cbo_typeaction.Location = New System.Drawing.Point(129, 257)
        Me.cbo_typeaction.Name = "cbo_typeaction"
        Me.cbo_typeaction.Size = New System.Drawing.Size(121, 21)
        Me.cbo_typeaction.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Prospect :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Type d'action :"
        '
        'chk_relance
        '
        Me.chk_relance.AutoSize = True
        Me.chk_relance.Location = New System.Drawing.Point(39, 304)
        Me.chk_relance.Name = "chk_relance"
        Me.chk_relance.Size = New System.Drawing.Size(77, 17)
        Me.chk_relance.TabIndex = 8
        Me.chk_relance.Text = " A relancer"
        Me.chk_relance.UseVisualStyleBackColor = True
        '
        'txt_daterelance
        '
        Me.txt_daterelance.Location = New System.Drawing.Point(205, 304)
        Me.txt_daterelance.Name = "txt_daterelance"
        Me.txt_daterelance.Size = New System.Drawing.Size(100, 20)
        Me.txt_daterelance.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(126, 307)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Date relance :"
        '
        'btn_ajouteraction
        '
        Me.btn_ajouteraction.Location = New System.Drawing.Point(154, 339)
        Me.btn_ajouteraction.Name = "btn_ajouteraction"
        Me.btn_ajouteraction.Size = New System.Drawing.Size(75, 23)
        Me.btn_ajouteraction.TabIndex = 11
        Me.btn_ajouteraction.Text = "Ajouter"
        Me.btn_ajouteraction.UseVisualStyleBackColor = True
        '
        'frm_NewAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 374)
        Me.Controls.Add(Me.btn_ajouteraction)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_daterelance)
        Me.Controls.Add(Me.chk_relance)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbo_typeaction)
        Me.Controls.Add(Me.cbo_contact)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_commentaire)
        Me.Controls.Add(Me.txt_dateaction)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_NewAction"
        Me.Text = "frm_NewAction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_dateaction As System.Windows.Forms.TextBox
    Friend WithEvents txt_commentaire As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_contact As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_typeaction As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chk_relance As System.Windows.Forms.CheckBox
    Friend WithEvents txt_daterelance As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_ajouteraction As System.Windows.Forms.Button
End Class
