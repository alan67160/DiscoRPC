<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateForm))
        Me.UpdateText = New System.Windows.Forms.Label()
        Me.UpdateDownload = New System.Windows.Forms.Button()
        Me.UpdateIgnore = New System.Windows.Forms.Button()
        Me.UpdateDetails = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UpdateText
        '
        Me.UpdateText.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateText.Location = New System.Drawing.Point(12, 26)
        Me.UpdateText.Name = "UpdateText"
        Me.UpdateText.Size = New System.Drawing.Size(776, 51)
        Me.UpdateText.TabIndex = 0
        Me.UpdateText.Text = "update.newversionavailable"
        Me.UpdateText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UpdateDownload
        '
        Me.UpdateDownload.Location = New System.Drawing.Point(687, 328)
        Me.UpdateDownload.Name = "UpdateDownload"
        Me.UpdateDownload.Size = New System.Drawing.Size(101, 23)
        Me.UpdateDownload.TabIndex = 1
        Me.UpdateDownload.Text = "update.download"
        Me.UpdateDownload.UseVisualStyleBackColor = True
        '
        'UpdateIgnore
        '
        Me.UpdateIgnore.Location = New System.Drawing.Point(548, 328)
        Me.UpdateIgnore.Name = "UpdateIgnore"
        Me.UpdateIgnore.Size = New System.Drawing.Size(133, 23)
        Me.UpdateIgnore.TabIndex = 2
        Me.UpdateIgnore.Text = "update.ignoreuntilrestart"
        Me.UpdateIgnore.UseVisualStyleBackColor = True
        '
        'UpdateDetails
        '
        Me.UpdateDetails.Location = New System.Drawing.Point(14, 77)
        Me.UpdateDetails.Name = "UpdateDetails"
        Me.UpdateDetails.Size = New System.Drawing.Size(774, 248)
        Me.UpdateDetails.TabIndex = 3
        Me.UpdateDetails.Text = "update.details"
        '
        'UpdateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 363)
        Me.Controls.Add(Me.UpdateDetails)
        Me.Controls.Add(Me.UpdateIgnore)
        Me.Controls.Add(Me.UpdateDownload)
        Me.Controls.Add(Me.UpdateText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(816, 402)
        Me.MinimumSize = New System.Drawing.Size(816, 402)
        Me.Name = "UpdateForm"
        Me.Text = "update.title"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UpdateText As Label
    Friend WithEvents UpdateDownload As Button
    Friend WithEvents UpdateIgnore As Button
    Friend WithEvents UpdateDetails As Label
End Class
