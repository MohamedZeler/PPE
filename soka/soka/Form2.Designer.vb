<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ListeProspect
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
        Me.lst_listeprospect = New System.Windows.Forms.ListView()
        Me.btn_deleteprospect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lst_listeprospect
        '
        Me.lst_listeprospect.Location = New System.Drawing.Point(58, 60)
        Me.lst_listeprospect.Name = "lst_listeprospect"
        Me.lst_listeprospect.Size = New System.Drawing.Size(833, 320)
        Me.lst_listeprospect.TabIndex = 0
        Me.lst_listeprospect.UseCompatibleStateImageBehavior = False
        Me.lst_listeprospect.View = System.Windows.Forms.View.Details
        '
        'btn_deleteprospect
        '
        Me.btn_deleteprospect.Location = New System.Drawing.Point(525, 408)
        Me.btn_deleteprospect.Name = "btn_deleteprospect"
        Me.btn_deleteprospect.Size = New System.Drawing.Size(93, 29)
        Me.btn_deleteprospect.TabIndex = 1
        Me.btn_deleteprospect.Text = "Supprimer"
        Me.btn_deleteprospect.UseVisualStyleBackColor = True
        '
        'frm_ListeProspect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.soka.My.Resources.Resources.Fond_
        Me.ClientSize = New System.Drawing.Size(998, 464)
        Me.Controls.Add(Me.btn_deleteprospect)
        Me.Controls.Add(Me.lst_listeprospect)
        Me.Name = "frm_ListeProspect"
        Me.Text = "ListeProspect"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lst_listeprospect As System.Windows.Forms.ListView
    Friend WithEvents btn_deleteprospect As System.Windows.Forms.Button
End Class
