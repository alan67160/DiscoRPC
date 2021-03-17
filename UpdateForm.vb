Public Class UpdateForm
    Private Sub UpdateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLang(Form1.config.lang)
    End Sub

    Public Sub LoadLang(Optional lang_ As String = "en_us")

        Me.Text = Lang.Translate(lang_, "update.title")

        If Form1.UpdateVer IsNot Nothing Then
            UpdateText.Text = Lang.Translate(lang_, "update.newversionavailable", Form1.UpdateVer.ver_, Form1.UpdateVer.beta_, Form1.UpdateVer.alpha_)
            If Not String.IsNullOrWhiteSpace(Form1.UpdateVer.details) Then
                UpdateDetails.Text = Form1.UpdateVer.details
            Else
                UpdateDetails.Text = Lang.Translate(lang_, "update.details.none")
            End If

        Else
            UpdateText.Text = Lang.Translate(lang_, "update.newversionavailable.none")
            UpdateDetails.Text = Lang.Translate(lang_, "update.details.none")
        End If



        UpdateDownload.Text = Lang.Translate(lang_, "update.download")
        UpdateIgnore.Text = Lang.Translate(lang_, "update.ignoreuntilrestart")
    End Sub

    Private Sub UpdateIgnore_Click(sender As Object, e As EventArgs) Handles UpdateIgnore.Click
        Form1.ignore_ver = True
        Me.Hide()
    End Sub

    Private Sub UpdateDownload_Click(sender As Object, e As EventArgs) Handles UpdateDownload.Click
        If Form1.UpdateVer IsNot Nothing Then
            If Not String.IsNullOrWhiteSpace(Form1.UpdateVer.url) Then
                Process.Start(Form1.UpdateVer.url)
            Else
                Process.Start("https://github.com/ZaptoInc/DiscoRPC")
            End If
        Else
            Process.Start("https://github.com/ZaptoInc/DiscoRPC")
        End If

    End Sub
End Class