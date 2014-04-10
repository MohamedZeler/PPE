<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AjouterEntreprise
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
        Me.txt_designation = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_adresse = New System.Windows.Forms.TextBox()
        Me.txt_cpentreprise = New System.Windows.Forms.TextBox()
        Me.txt_villeentreprise = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_telentreprise = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_mailentreprise = New System.Windows.Forms.TextBox()
        Me.cbo_paysentreprise = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_addentreprise = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Location = New System.Drawing.Point(46, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nouvelle entreprise"
        '
        'txt_designation
        '
        Me.txt_designation.Location = New System.Drawing.Point(91, 68)
        Me.txt_designation.Name = "txt_designation"
        Me.txt_designation.Size = New System.Drawing.Size(100, 20)
        Me.txt_designation.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Location = New System.Drawing.Point(3, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Désignation : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label3.Location = New System.Drawing.Point(21, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Adresse :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label4.Location = New System.Drawing.Point(2, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Code Postal :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label5.Location = New System.Drawing.Point(40, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Ville :"
        '
        'txt_adresse
        '
        Me.txt_adresse.Location = New System.Drawing.Point(76, 31)
        Me.txt_adresse.Name = "txt_adresse"
        Me.txt_adresse.Size = New System.Drawing.Size(100, 20)
        Me.txt_adresse.TabIndex = 6
        '
        'txt_cpentreprise
        '
        Me.txt_cpentreprise.Location = New System.Drawing.Point(76, 57)
        Me.txt_cpentreprise.Name = "txt_cpentreprise"
        Me.txt_cpentreprise.Size = New System.Drawing.Size(100, 20)
        Me.txt_cpentreprise.TabIndex = 7
        '
        'txt_villeentreprise
        '
        Me.txt_villeentreprise.Location = New System.Drawing.Point(76, 83)
        Me.txt_villeentreprise.Name = "txt_villeentreprise"
        Me.txt_villeentreprise.Size = New System.Drawing.Size(100, 20)
        Me.txt_villeentreprise.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txt_villeentreprise)
        Me.GroupBox1.Controls.Add(Me.txt_cpentreprise)
        Me.GroupBox1.Controls.Add(Me.txt_adresse)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Location = New System.Drawing.Point(15, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(188, 111)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Localisation"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label6.Location = New System.Drawing.Point(23, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Téléphone :"
        '
        'txt_telentreprise
        '
        Me.txt_telentreprise.Location = New System.Drawing.Point(91, 226)
        Me.txt_telentreprise.Name = "txt_telentreprise"
        Me.txt_telentreprise.Size = New System.Drawing.Size(100, 20)
        Me.txt_telentreprise.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label7.Location = New System.Drawing.Point(53, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Mail :"
        '
        'txt_mailentreprise
        '
        Me.txt_mailentreprise.Location = New System.Drawing.Point(91, 252)
        Me.txt_mailentreprise.Name = "txt_mailentreprise"
        Me.txt_mailentreprise.Size = New System.Drawing.Size(100, 20)
        Me.txt_mailentreprise.TabIndex = 13
        '
        'cbo_paysentreprise
        '
        Me.cbo_paysentreprise.FormattingEnabled = True
        Me.cbo_paysentreprise.Location = New System.Drawing.Point(91, 288)
        Me.cbo_paysentreprise.Name = "cbo_paysentreprise"
        Me.cbo_paysentreprise.Size = New System.Drawing.Size(139, 21)
        Me.cbo_paysentreprise.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label8.Location = New System.Drawing.Point(49, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Pays :"
        '
        'btn_addentreprise
        '
        Me.btn_addentreprise.Location = New System.Drawing.Point(128, 325)
        Me.btn_addentreprise.Name = "btn_addentreprise"
        Me.btn_addentreprise.Size = New System.Drawing.Size(75, 23)
        Me.btn_addentreprise.TabIndex = 16
        Me.btn_addentreprise.Text = "Ajouter"
        Me.btn_addentreprise.UseVisualStyleBackColor = True
        '
        'frm_AjouterEntreprise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.soka.My.Resources.Resources.Fond_
        Me.ClientSize = New System.Drawing.Size(325, 360)
        Me.Controls.Add(Me.btn_addentreprise)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbo_paysentreprise)
        Me.Controls.Add(Me.txt_mailentreprise)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_telentreprise)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_designation)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_AjouterEntreprise"
        Me.Text = "frm_AjouterEntreprise"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_designation As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_adresse As System.Windows.Forms.TextBox
    Friend WithEvents txt_cpentreprise As System.Windows.Forms.TextBox
    Friend WithEvents txt_villeentreprise As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_telentreprise As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_mailentreprise As System.Windows.Forms.TextBox
    Friend WithEvents cbo_paysentreprise As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_addentreprise As System.Windows.Forms.Button
End Class
