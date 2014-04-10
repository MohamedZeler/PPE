<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuSOKA
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
        Me.btnMails = New System.Windows.Forms.Button()
        Me.btnCatalogue = New System.Windows.Forms.Button()
        Me.btnGestionCli = New System.Windows.Forms.Button()
        Me.btnParametre = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Location = New System.Drawing.Point(78, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SOKA"
        '
        'btnMails
        '
        Me.btnMails.Location = New System.Drawing.Point(197, 12)
        Me.btnMails.Name = "btnMails"
        Me.btnMails.Size = New System.Drawing.Size(75, 23)
        Me.btnMails.TabIndex = 2
        Me.btnMails.Text = "Mails"
        Me.btnMails.UseVisualStyleBackColor = True
        '
        'btnCatalogue
        '
        Me.btnCatalogue.Location = New System.Drawing.Point(99, 102)
        Me.btnCatalogue.Name = "btnCatalogue"
        Me.btnCatalogue.Size = New System.Drawing.Size(75, 23)
        Me.btnCatalogue.TabIndex = 3
        Me.btnCatalogue.Text = "Catalogue"
        Me.btnCatalogue.UseVisualStyleBackColor = True
        '
        'btnGestionCli
        '
        Me.btnGestionCli.Location = New System.Drawing.Point(68, 131)
        Me.btnGestionCli.Name = "btnGestionCli"
        Me.btnGestionCli.Size = New System.Drawing.Size(132, 23)
        Me.btnGestionCli.TabIndex = 4
        Me.btnGestionCli.Text = "Gestion de la clientèle"
        Me.btnGestionCli.UseVisualStyleBackColor = True
        '
        'btnParametre
        '
        Me.btnParametre.Location = New System.Drawing.Point(12, 12)
        Me.btnParametre.Name = "btnParametre"
        Me.btnParametre.Size = New System.Drawing.Size(75, 23)
        Me.btnParametre.TabIndex = 1
        Me.btnParametre.Text = "Paramètres"
        Me.btnParametre.UseVisualStyleBackColor = True
        '
        'FrmMenuSOKA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.soka.My.Resources.Resources.Fond_
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnGestionCli)
        Me.Controls.Add(Me.btnCatalogue)
        Me.Controls.Add(Me.btnMails)
        Me.Controls.Add(Me.btnParametre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMenuSOKA"
        Me.Text = "FrmMenuSOKA"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMails As System.Windows.Forms.Button
    Friend WithEvents btnCatalogue As System.Windows.Forms.Button
    Friend WithEvents btnGestionCli As System.Windows.Forms.Button
    Friend WithEvents btnParametre As System.Windows.Forms.Button
End Class
