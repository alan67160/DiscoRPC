Imports DiscordRPC

Public Class Config
    Public hide_on_startup As Boolean = False
    Public start_with_windows As Boolean = False
    Public lang As String = "en_us"
    Public use_beta As Boolean = True
    Public use_alpha As Boolean = False
    Public rpc As New RPC_Config
End Class

Public Class RPC_Config
    Public ClientID As ULong? = 821442553265782844
    Public Details As String = "Fully Customizable"
    Public State As String
    Public LargeImageKey As String = "discorpc"
    Public LargeImageText As String = $"DiscoRPC"
    Public SmallImageKey As String
    Public SmallImageText As String

    Public Button_A As RPC_Config_Button = New RPC_Config_Button("Download", "https://github.com/ZaptoInc/DiscoRPC/releases")
    Public Button_B As RPC_Config_Button = Nothing

    Function CreateRichClient() As DiscordRpcClient
        If ClientID.HasValue Then
            Dim client As New DiscordRpcClient(Me.ClientID.Value)
            Return client
        Else
            Return Nothing
        End If

    End Function

    Function CreateRichPresence() As RichPresence
        Dim pre As New RichPresence
        Dim asset = New Assets()
        If Not String.IsNullOrWhiteSpace(Me.SmallImageKey) Then
            asset.SmallImageKey = Me.SmallImageKey
        End If
        If Not String.IsNullOrWhiteSpace(Me.SmallImageText) Then
            asset.SmallImageText = Me.SmallImageText
        End If
        If Not String.IsNullOrWhiteSpace(Me.LargeImageKey) Then
            asset.LargeImageKey = Me.LargeImageKey
        End If
        If Not String.IsNullOrWhiteSpace(Me.LargeImageText) Then
            asset.LargeImageText = Me.LargeImageText
        End If
        pre.Assets = asset

        Dim buttons As New List(Of Button)
        If Button_A IsNot Nothing Then
            Dim button_temp As New Button
            If Uri.IsWellFormedUriString(Button_A.Url, UriKind.Absolute) Then
                button_temp.Url = Button_A.Url
            End If
            button_temp.Label = Button_A.Label
            buttons.Add(button_temp)
        End If
        If Button_B IsNot Nothing Then
            Dim button_temp As New Button
            If Uri.IsWellFormedUriString(Button_B.Url, UriKind.Absolute) Then
                button_temp.Url = Button_B.Url
            End If
            button_temp.Label = Button_B.Label
            buttons.Add(button_temp)
        End If
        pre.Buttons = buttons.ToArray
        pre.Details = Me.Details
        pre.State = Me.State
        Return pre
    End Function
End Class
Public Class RPC_Config_Button
    Public Label As String = Nothing
    Public Url As String = Nothing

    Sub New()

    End Sub

    Sub New(Label As String, Url As String)
        If Not String.IsNullOrWhiteSpace(Label) Then
            Me.Label = Label
        Else
            Me.Label = Nothing
        End If
        If Not String.IsNullOrWhiteSpace(Url) Then
            If Uri.IsWellFormedUriString(Url, UriKind.Absolute) Then
                Me.Url = Url
            End If
        Else
            Me.Url = Nothing
        End If

    End Sub
End Class