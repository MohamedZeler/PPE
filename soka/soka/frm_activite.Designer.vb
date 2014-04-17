<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_activite
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
        Me.lst_actions = New System.Windows.Forms.ListView()
        Me.lbl_actiontitre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lst_actions
        '
        Me.lst_actions.Location = New System.Drawing.Point(67, 77)
        Me.lst_actions.Name = "lst_actions"
        Me.lst_actions.Size = New System.Drawing.Size(758, 260)
        Me.lst_actions.TabIndex = 0
        Me.lst_actions.UseCompatibleStateImageBehavior = False
        Me.lst_actions.View = System.Windows.Forms.View.Details
        '
        'lbl_actiontitre
        '
        Me.lbl_actiontitre.AutoSize = True
        Me.lbl_actiontitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_actiontitre.Location = New System.Drawing.Point(346, 26)
        Me.lbl_actiontitre.Name = "lbl_actiontitre"
        Me.lbl_actiontitre.Size = New System.Drawing.Size(95, 31)
        Me.lbl_actiontitre.TabIndex = 1
        Me.lbl_actiontitre.Text = "Label1"
        '
        'frm_activite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.soka.My.Resources.Resources.Fond_
        Me.ClientSize = New System.Drawing.Size(872, 368)
        Me.Controls.Add(Me.lbl_actiontitre)
        Me.Controls.Add(Me.lst_actions)
        Me.Name = "frm_activite"
        Me.Text = "frm_activite"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lst_actions As System.Windows.Forms.ListView
    Friend WithEvents lbl_actiontitre As System.Windows.Forms.Label
End Class
