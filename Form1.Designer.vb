<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CFG_ClientID_Label = New System.Windows.Forms.Label()
        Me.CFG_ClientID_TextBox = New System.Windows.Forms.TextBox()
        Me.CFG_Details_Label = New System.Windows.Forms.Label()
        Me.CFG_Details_TextBox = New System.Windows.Forms.TextBox()
        Me.CFG_State_TextBox = New System.Windows.Forms.TextBox()
        Me.CFG_State_Label = New System.Windows.Forms.Label()
        Me.CFG_LargeImageKey_Label = New System.Windows.Forms.Label()
        Me.CFG_LargeImageKey_Textbox = New System.Windows.Forms.TextBox()
        Me.CFG_LargeImageText_TextBox = New System.Windows.Forms.TextBox()
        Me.CFG_LargeImageText_Label = New System.Windows.Forms.Label()
        Me.CFG_SmallImageText_Label = New System.Windows.Forms.Label()
        Me.CFG_SmallImageText_TextBox = New System.Windows.Forms.TextBox()
        Me.CFG_SmallImageKey_TextBox = New System.Windows.Forms.TextBox()
        Me.CFG_SmallImageKey_Label = New System.Windows.Forms.Label()
        Me.CFG_ButtonBURL_TextBox = New System.Windows.Forms.TextBox()
        Me.CFG_ButtonBText_TextBox = New System.Windows.Forms.TextBox()
        Me.CFG_ButtonAURL_Label = New System.Windows.Forms.Label()
        Me.CFG_ButtonAURL_TextBox = New System.Windows.Forms.TextBox()
        Me.CFG_ButtonAText_TextBox = New System.Windows.Forms.TextBox()
        Me.CFG_ButtonAText_Label = New System.Windows.Forms.Label()
        Me.CFG_ButtonBURL_Label = New System.Windows.Forms.Label()
        Me.CFG_ButtonBText_Label = New System.Windows.Forms.Label()
        Me.CFG_Refresh_Button = New System.Windows.Forms.Button()
        Me.CFG_Save_Button = New System.Windows.Forms.Button()
        Me.UpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LangComboBox = New System.Windows.Forms.ComboBox()
        Me.LangLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CFG_ClientID_Label
        '
        Me.CFG_ClientID_Label.AutoSize = True
        Me.CFG_ClientID_Label.Location = New System.Drawing.Point(12, 9)
        Me.CFG_ClientID_Label.Name = "CFG_ClientID_Label"
        Me.CFG_ClientID_Label.Size = New System.Drawing.Size(50, 13)
        Me.CFG_ClientID_Label.TabIndex = 0
        Me.CFG_ClientID_Label.Text = "Client ID:"
        '
        'CFG_ClientID_TextBox
        '
        Me.CFG_ClientID_TextBox.Location = New System.Drawing.Point(15, 25)
        Me.CFG_ClientID_TextBox.MaxLength = 18
        Me.CFG_ClientID_TextBox.Name = "CFG_ClientID_TextBox"
        Me.CFG_ClientID_TextBox.Size = New System.Drawing.Size(129, 20)
        Me.CFG_ClientID_TextBox.TabIndex = 1
        '
        'CFG_Details_Label
        '
        Me.CFG_Details_Label.AutoSize = True
        Me.CFG_Details_Label.Location = New System.Drawing.Point(174, 9)
        Me.CFG_Details_Label.Name = "CFG_Details_Label"
        Me.CFG_Details_Label.Size = New System.Drawing.Size(42, 13)
        Me.CFG_Details_Label.TabIndex = 2
        Me.CFG_Details_Label.Text = "Details:"
        '
        'CFG_Details_TextBox
        '
        Me.CFG_Details_TextBox.Location = New System.Drawing.Point(177, 25)
        Me.CFG_Details_TextBox.MaxLength = 128
        Me.CFG_Details_TextBox.Name = "CFG_Details_TextBox"
        Me.CFG_Details_TextBox.Size = New System.Drawing.Size(611, 20)
        Me.CFG_Details_TextBox.TabIndex = 3
        '
        'CFG_State_TextBox
        '
        Me.CFG_State_TextBox.Location = New System.Drawing.Point(177, 77)
        Me.CFG_State_TextBox.MaxLength = 128
        Me.CFG_State_TextBox.Name = "CFG_State_TextBox"
        Me.CFG_State_TextBox.Size = New System.Drawing.Size(611, 20)
        Me.CFG_State_TextBox.TabIndex = 5
        '
        'CFG_State_Label
        '
        Me.CFG_State_Label.AutoSize = True
        Me.CFG_State_Label.Location = New System.Drawing.Point(174, 61)
        Me.CFG_State_Label.Name = "CFG_State_Label"
        Me.CFG_State_Label.Size = New System.Drawing.Size(35, 13)
        Me.CFG_State_Label.TabIndex = 6
        Me.CFG_State_Label.Text = "State:"
        '
        'CFG_LargeImageKey_Label
        '
        Me.CFG_LargeImageKey_Label.AutoSize = True
        Me.CFG_LargeImageKey_Label.Location = New System.Drawing.Point(12, 113)
        Me.CFG_LargeImageKey_Label.Name = "CFG_LargeImageKey_Label"
        Me.CFG_LargeImageKey_Label.Size = New System.Drawing.Size(90, 13)
        Me.CFG_LargeImageKey_Label.TabIndex = 7
        Me.CFG_LargeImageKey_Label.Text = "Large Image Key:"
        '
        'CFG_LargeImageKey_Textbox
        '
        Me.CFG_LargeImageKey_Textbox.Location = New System.Drawing.Point(15, 129)
        Me.CFG_LargeImageKey_Textbox.MaxLength = 128
        Me.CFG_LargeImageKey_Textbox.Name = "CFG_LargeImageKey_Textbox"
        Me.CFG_LargeImageKey_Textbox.Size = New System.Drawing.Size(129, 20)
        Me.CFG_LargeImageKey_Textbox.TabIndex = 8
        '
        'CFG_LargeImageText_TextBox
        '
        Me.CFG_LargeImageText_TextBox.Location = New System.Drawing.Point(177, 129)
        Me.CFG_LargeImageText_TextBox.MaxLength = 128
        Me.CFG_LargeImageText_TextBox.Name = "CFG_LargeImageText_TextBox"
        Me.CFG_LargeImageText_TextBox.Size = New System.Drawing.Size(611, 20)
        Me.CFG_LargeImageText_TextBox.TabIndex = 9
        '
        'CFG_LargeImageText_Label
        '
        Me.CFG_LargeImageText_Label.AutoSize = True
        Me.CFG_LargeImageText_Label.Location = New System.Drawing.Point(174, 113)
        Me.CFG_LargeImageText_Label.Name = "CFG_LargeImageText_Label"
        Me.CFG_LargeImageText_Label.Size = New System.Drawing.Size(93, 13)
        Me.CFG_LargeImageText_Label.TabIndex = 10
        Me.CFG_LargeImageText_Label.Text = "Large Image Text:"
        '
        'CFG_SmallImageText_Label
        '
        Me.CFG_SmallImageText_Label.AutoSize = True
        Me.CFG_SmallImageText_Label.Location = New System.Drawing.Point(174, 165)
        Me.CFG_SmallImageText_Label.Name = "CFG_SmallImageText_Label"
        Me.CFG_SmallImageText_Label.Size = New System.Drawing.Size(91, 13)
        Me.CFG_SmallImageText_Label.TabIndex = 14
        Me.CFG_SmallImageText_Label.Text = "Small Image Text:"
        '
        'CFG_SmallImageText_TextBox
        '
        Me.CFG_SmallImageText_TextBox.Location = New System.Drawing.Point(177, 181)
        Me.CFG_SmallImageText_TextBox.MaxLength = 128
        Me.CFG_SmallImageText_TextBox.Name = "CFG_SmallImageText_TextBox"
        Me.CFG_SmallImageText_TextBox.Size = New System.Drawing.Size(611, 20)
        Me.CFG_SmallImageText_TextBox.TabIndex = 13
        '
        'CFG_SmallImageKey_TextBox
        '
        Me.CFG_SmallImageKey_TextBox.Location = New System.Drawing.Point(15, 181)
        Me.CFG_SmallImageKey_TextBox.MaxLength = 128
        Me.CFG_SmallImageKey_TextBox.Name = "CFG_SmallImageKey_TextBox"
        Me.CFG_SmallImageKey_TextBox.Size = New System.Drawing.Size(129, 20)
        Me.CFG_SmallImageKey_TextBox.TabIndex = 12
        '
        'CFG_SmallImageKey_Label
        '
        Me.CFG_SmallImageKey_Label.AutoSize = True
        Me.CFG_SmallImageKey_Label.Location = New System.Drawing.Point(12, 165)
        Me.CFG_SmallImageKey_Label.Name = "CFG_SmallImageKey_Label"
        Me.CFG_SmallImageKey_Label.Size = New System.Drawing.Size(88, 13)
        Me.CFG_SmallImageKey_Label.TabIndex = 11
        Me.CFG_SmallImageKey_Label.Text = "Small Image Key:"
        '
        'CFG_ButtonBURL_TextBox
        '
        Me.CFG_ButtonBURL_TextBox.Location = New System.Drawing.Point(177, 285)
        Me.CFG_ButtonBURL_TextBox.MaxLength = 128
        Me.CFG_ButtonBURL_TextBox.Name = "CFG_ButtonBURL_TextBox"
        Me.CFG_ButtonBURL_TextBox.Size = New System.Drawing.Size(611, 20)
        Me.CFG_ButtonBURL_TextBox.TabIndex = 21
        '
        'CFG_ButtonBText_TextBox
        '
        Me.CFG_ButtonBText_TextBox.Location = New System.Drawing.Point(15, 285)
        Me.CFG_ButtonBText_TextBox.MaxLength = 32
        Me.CFG_ButtonBText_TextBox.Name = "CFG_ButtonBText_TextBox"
        Me.CFG_ButtonBText_TextBox.Size = New System.Drawing.Size(129, 20)
        Me.CFG_ButtonBText_TextBox.TabIndex = 20
        '
        'CFG_ButtonAURL_Label
        '
        Me.CFG_ButtonAURL_Label.AutoSize = True
        Me.CFG_ButtonAURL_Label.Location = New System.Drawing.Point(174, 217)
        Me.CFG_ButtonAURL_Label.Name = "CFG_ButtonAURL_Label"
        Me.CFG_ButtonAURL_Label.Size = New System.Drawing.Size(76, 13)
        Me.CFG_ButtonAURL_Label.TabIndex = 18
        Me.CFG_ButtonAURL_Label.Text = "Button A URL:"
        '
        'CFG_ButtonAURL_TextBox
        '
        Me.CFG_ButtonAURL_TextBox.Location = New System.Drawing.Point(177, 233)
        Me.CFG_ButtonAURL_TextBox.MaxLength = 128
        Me.CFG_ButtonAURL_TextBox.Name = "CFG_ButtonAURL_TextBox"
        Me.CFG_ButtonAURL_TextBox.Size = New System.Drawing.Size(611, 20)
        Me.CFG_ButtonAURL_TextBox.TabIndex = 17
        '
        'CFG_ButtonAText_TextBox
        '
        Me.CFG_ButtonAText_TextBox.Location = New System.Drawing.Point(15, 233)
        Me.CFG_ButtonAText_TextBox.MaxLength = 32
        Me.CFG_ButtonAText_TextBox.Name = "CFG_ButtonAText_TextBox"
        Me.CFG_ButtonAText_TextBox.Size = New System.Drawing.Size(129, 20)
        Me.CFG_ButtonAText_TextBox.TabIndex = 16
        '
        'CFG_ButtonAText_Label
        '
        Me.CFG_ButtonAText_Label.AutoSize = True
        Me.CFG_ButtonAText_Label.Location = New System.Drawing.Point(12, 217)
        Me.CFG_ButtonAText_Label.Name = "CFG_ButtonAText_Label"
        Me.CFG_ButtonAText_Label.Size = New System.Drawing.Size(75, 13)
        Me.CFG_ButtonAText_Label.TabIndex = 15
        Me.CFG_ButtonAText_Label.Text = "Button A Text:"
        '
        'CFG_ButtonBURL_Label
        '
        Me.CFG_ButtonBURL_Label.AutoSize = True
        Me.CFG_ButtonBURL_Label.Location = New System.Drawing.Point(174, 269)
        Me.CFG_ButtonBURL_Label.Name = "CFG_ButtonBURL_Label"
        Me.CFG_ButtonBURL_Label.Size = New System.Drawing.Size(76, 13)
        Me.CFG_ButtonBURL_Label.TabIndex = 23
        Me.CFG_ButtonBURL_Label.Text = "Button B URL:"
        '
        'CFG_ButtonBText_Label
        '
        Me.CFG_ButtonBText_Label.AutoSize = True
        Me.CFG_ButtonBText_Label.Location = New System.Drawing.Point(12, 269)
        Me.CFG_ButtonBText_Label.Name = "CFG_ButtonBText_Label"
        Me.CFG_ButtonBText_Label.Size = New System.Drawing.Size(75, 13)
        Me.CFG_ButtonBText_Label.TabIndex = 22
        Me.CFG_ButtonBText_Label.Text = "Button B Text:"
        '
        'CFG_Refresh_Button
        '
        Me.CFG_Refresh_Button.Location = New System.Drawing.Point(713, 324)
        Me.CFG_Refresh_Button.Name = "CFG_Refresh_Button"
        Me.CFG_Refresh_Button.Size = New System.Drawing.Size(75, 23)
        Me.CFG_Refresh_Button.TabIndex = 24
        Me.CFG_Refresh_Button.Text = "Refresh"
        Me.CFG_Refresh_Button.UseVisualStyleBackColor = True
        '
        'CFG_Save_Button
        '
        Me.CFG_Save_Button.Location = New System.Drawing.Point(632, 324)
        Me.CFG_Save_Button.Name = "CFG_Save_Button"
        Me.CFG_Save_Button.Size = New System.Drawing.Size(75, 23)
        Me.CFG_Save_Button.TabIndex = 25
        Me.CFG_Save_Button.Text = "Save"
        Me.CFG_Save_Button.UseVisualStyleBackColor = True
        '
        'UpdateTimer
        '
        Me.UpdateTimer.Enabled = True
        Me.UpdateTimer.Interval = 10000
        '
        'LangComboBox
        '
        Me.LangComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LangComboBox.FormattingEnabled = True
        Me.LangComboBox.Location = New System.Drawing.Point(15, 324)
        Me.LangComboBox.Name = "LangComboBox"
        Me.LangComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LangComboBox.Size = New System.Drawing.Size(121, 21)
        Me.LangComboBox.TabIndex = 26
        '
        'LangLabel
        '
        Me.LangLabel.AutoSize = True
        Me.LangLabel.Location = New System.Drawing.Point(12, 308)
        Me.LangLabel.Name = "LangLabel"
        Me.LangLabel.Size = New System.Drawing.Size(34, 13)
        Me.LangLabel.TabIndex = 27
        Me.LangLabel.Text = "Lang:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 359)
        Me.Controls.Add(Me.LangLabel)
        Me.Controls.Add(Me.LangComboBox)
        Me.Controls.Add(Me.CFG_Save_Button)
        Me.Controls.Add(Me.CFG_Refresh_Button)
        Me.Controls.Add(Me.CFG_ButtonBURL_Label)
        Me.Controls.Add(Me.CFG_ButtonBText_Label)
        Me.Controls.Add(Me.CFG_ButtonBURL_TextBox)
        Me.Controls.Add(Me.CFG_ButtonBText_TextBox)
        Me.Controls.Add(Me.CFG_ButtonAURL_Label)
        Me.Controls.Add(Me.CFG_ButtonAURL_TextBox)
        Me.Controls.Add(Me.CFG_ButtonAText_TextBox)
        Me.Controls.Add(Me.CFG_ButtonAText_Label)
        Me.Controls.Add(Me.CFG_SmallImageText_Label)
        Me.Controls.Add(Me.CFG_SmallImageText_TextBox)
        Me.Controls.Add(Me.CFG_SmallImageKey_TextBox)
        Me.Controls.Add(Me.CFG_SmallImageKey_Label)
        Me.Controls.Add(Me.CFG_LargeImageText_Label)
        Me.Controls.Add(Me.CFG_LargeImageText_TextBox)
        Me.Controls.Add(Me.CFG_LargeImageKey_Textbox)
        Me.Controls.Add(Me.CFG_LargeImageKey_Label)
        Me.Controls.Add(Me.CFG_State_Label)
        Me.Controls.Add(Me.CFG_State_TextBox)
        Me.Controls.Add(Me.CFG_Details_TextBox)
        Me.Controls.Add(Me.CFG_Details_Label)
        Me.Controls.Add(Me.CFG_ClientID_TextBox)
        Me.Controls.Add(Me.CFG_ClientID_Label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(816, 398)
        Me.MinimumSize = New System.Drawing.Size(816, 398)
        Me.Name = "Form1"
        Me.Text = "DiscoRPC X.X.X"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CFG_ClientID_Label As Label
    Friend WithEvents CFG_ClientID_TextBox As TextBox
    Friend WithEvents CFG_Details_Label As Label
    Friend WithEvents CFG_Details_TextBox As TextBox
    Friend WithEvents CFG_State_TextBox As TextBox
    Friend WithEvents CFG_State_Label As Label
    Friend WithEvents CFG_LargeImageKey_Label As Label
    Friend WithEvents CFG_LargeImageKey_Textbox As TextBox
    Friend WithEvents CFG_LargeImageText_TextBox As TextBox
    Friend WithEvents CFG_LargeImageText_Label As Label
    Friend WithEvents CFG_SmallImageText_Label As Label
    Friend WithEvents CFG_SmallImageText_TextBox As TextBox
    Friend WithEvents CFG_SmallImageKey_TextBox As TextBox
    Friend WithEvents CFG_SmallImageKey_Label As Label
    Friend WithEvents CFG_ButtonBURL_TextBox As TextBox
    Friend WithEvents CFG_ButtonBText_TextBox As TextBox
    Friend WithEvents CFG_ButtonAURL_Label As Label
    Friend WithEvents CFG_ButtonAURL_TextBox As TextBox
    Friend WithEvents CFG_ButtonAText_TextBox As TextBox
    Friend WithEvents CFG_ButtonAText_Label As Label
    Friend WithEvents CFG_ButtonBURL_Label As Label
    Friend WithEvents CFG_ButtonBText_Label As Label
    Friend WithEvents CFG_Refresh_Button As Button
    Friend WithEvents CFG_Save_Button As Button
    Friend WithEvents UpdateTimer As Timer
    Friend WithEvents LangComboBox As ComboBox
    Friend WithEvents LangLabel As Label
End Class
