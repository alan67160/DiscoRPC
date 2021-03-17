Imports System.IO
Imports DiscordRPC
Imports DiscordRPC.Message
Imports Newtonsoft.Json
Imports Flurl
Imports Flurl.Http
Public Class Form1
    Dim WithEvents client As DiscordRpcClient = Nothing

    Public config As New Config

    Public CurrentVer As VerConfig = New VerConfig(0, 2, 0)

    Public UpdateVer As VerConfig = Nothing

    Public ignore_ver As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lang.Load()
        If File.Exists("config.json") Then
            config = JsonConvert.DeserializeObject(Of Config)(File.ReadAllText("config.json"))
        Else
            config = New Config
        End If
        LoadLang(config.lang)
        If config IsNot Nothing Then
            If config.rpc.ClientID.HasValue Then
                CFG_ClientID_TextBox.Text = config.rpc.ClientID.Value
            End If

            CFG_Details_TextBox.Text = config.rpc.Details
            CFG_State_TextBox.Text = config.rpc.State

            CFG_LargeImageKey_Textbox.Text = config.rpc.LargeImageKey
            CFG_LargeImageText_TextBox.Text = config.rpc.LargeImageText

            CFG_SmallImageKey_TextBox.Text = config.rpc.SmallImageKey
            CFG_SmallImageText_TextBox.Text = config.rpc.SmallImageText

            If config.rpc.Button_A IsNot Nothing Then
                CFG_ButtonAText_TextBox.Text = config.rpc.Button_A.Label
                CFG_ButtonAURL_TextBox.Text = config.rpc.Button_A.Url
            End If

            If config.rpc.Button_B IsNot Nothing Then
                CFG_ButtonBText_TextBox.Text = config.rpc.Button_B.Label
                CFG_ButtonBURL_TextBox.Text = config.rpc.Button_B.Url
            End If
        End If

        Me.Text = $"DiscoRPC {CurrentVer.ver_}.{CurrentVer.beta_}.{CurrentVer.alpha_}"
    End Sub

    Public Sub LoadLang(Optional lang_ As String = "en_us")

        CFG_ClientID_Label.Text = Lang.Translate(lang_, "cfg.clientid.label")

        CFG_Details_Label.Text = Lang.Translate(lang_, "cfg.details.label")
        CFG_State_Label.Text = Lang.Translate(lang_, "cfg.state.label")

        CFG_LargeImageKey_Label.Text = Lang.Translate(lang_, "cfg.largeimagekey.label")
        CFG_LargeImageText_Label.Text = Lang.Translate(lang_, "cfg.largeimagetext.label")

        CFG_SmallImageKey_Label.Text = Lang.Translate(lang_, "cfg.smallimagekey.label")
        CFG_SmallImageText_Label.Text = Lang.Translate(lang_, "cfg.smallimagetext.label")

        CFG_ButtonAText_Label.Text = Lang.Translate(lang_, "cfg.buttonatext.label")
        CFG_ButtonAURL_Label.Text = Lang.Translate(lang_, "cfg.buttonaurl.label")

        CFG_ButtonBText_Label.Text = Lang.Translate(lang_, "cfg.buttonbtext.label")
        CFG_ButtonBURL_Label.Text = Lang.Translate(lang_, "cfg.buttonburl.label")

        CFG_Refresh_Button.Text = Lang.Translate(lang_, "cfg.refreshbutton.label")
        CFG_Save_Button.Text = Lang.Translate(lang_, "cfg.savebutton.label")
    End Sub

    Private Sub CFG_Refresh_Button_Click(sender As Object, e As EventArgs) Handles CFG_Refresh_Button.Click
        ApplyRPCClient()
    End Sub

    Sub ApplyRPCClient()
        Try
            If client IsNot Nothing Then
                If Not client.ApplicationID = config.rpc.ClientID.ToString Then
                    client.Dispose()
                    client = config.rpc.CreateRichClient
                    If client IsNot Nothing Then
                        client.Initialize()
                    End If
                End If
            Else
                client = config.rpc.CreateRichClient
                If client IsNot Nothing Then
                    client.Initialize()
                End If

            End If
        Catch ex As Exception
            client = Nothing
            MsgBox(ex.ToString)
        End Try

        If client IsNot Nothing Then
            client.SetPresence(config.rpc.CreateRichPresence)
        End If
    End Sub

    Private Sub CFG_Save_Button_Click(sender As Object, e As EventArgs) Handles CFG_Save_Button.Click
        Try
            config.rpc.ClientID = CType(CFG_ClientID_TextBox.Text, ULong)
        Catch ex As Exception
            MsgBox(Lang.Translate(config.lang, "error.clientid", CFG_ClientID_TextBox.Text))
        End Try

        config.rpc.Details = CFG_Details_TextBox.Text
        config.rpc.State = CFG_State_TextBox.Text

        config.rpc.LargeImageKey = CFG_LargeImageKey_Textbox.Text
        config.rpc.LargeImageText = CFG_LargeImageText_TextBox.Text

        config.rpc.SmallImageKey = CFG_SmallImageKey_TextBox.Text
        config.rpc.SmallImageText = CFG_SmallImageText_TextBox.Text

        If Not String.IsNullOrWhiteSpace(CFG_ButtonAText_TextBox.Text) And Not String.IsNullOrWhiteSpace(CFG_ButtonAURL_TextBox.Text) Then
            config.rpc.Button_A = New RPC_Config_Button(CFG_ButtonAText_TextBox.Text, CFG_ButtonAURL_TextBox.Text)
        End If
        If Not String.IsNullOrWhiteSpace(CFG_ButtonBText_TextBox.Text) And Not String.IsNullOrWhiteSpace(CFG_ButtonBURL_TextBox.Text) Then
            config.rpc.Button_B = New RPC_Config_Button(CFG_ButtonBText_TextBox.Text, CFG_ButtonBURL_TextBox.Text)
        End If
        File.WriteAllText("config.json", JsonConvert.SerializeObject(config, Formatting.Indented))
    End Sub

    Async Function GetUpdateFileAsync() As Task(Of VerConfig)
        Try
            Dim r = Await "https://github.com/ZaptoInc/DiscoRPC/blob/main/about.json".GetJsonAsync(Of VerConfig)
            Return r
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Async Sub Timer1_Tick(sender As Object, e As EventArgs) Handles UpdateTimer.Tick
        UpdateTimer.Stop()
        UpdateTimer.Interval = 12 * 60 * 60 * 1000
        Try
            If ignore_ver = False Then
                UpdateVer = Await GetUpdateFileAsync()
                If UpdateVer IsNot Nothing Then
                    If UpdateVer.ver_ > CurrentVer.ver_ Then
                        UpdateForm.Hide()
                        UpdateForm.Show()
                        UpdateForm.LoadLang(config.lang)
                    Else
                        If config.use_beta Then
                            If UpdateVer.beta_ > CurrentVer.beta_ Then
                                UpdateForm.Hide()
                                UpdateForm.Show()
                                UpdateForm.LoadLang(config.lang)
                            Else
                                If config.use_alpha Then
                                    If UpdateVer.alpha_ > CurrentVer.alpha_ Then
                                        UpdateForm.Hide()
                                        UpdateForm.Show()
                                        UpdateForm.LoadLang(config.lang)
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
        UpdateTimer.Start()
    End Sub
End Class
