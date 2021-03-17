Public Class VerConfig
    Public ver_ As Integer = 0
    Public beta_ As Integer = 0
    Public alpha_ As Integer = 0
    Public url As String = "https://github.com/ZaptoInc/DiscoRPC"
    Public details As String = ""
    Sub New()

    End Sub

    Sub New(ver_ As Integer, beta_ As Integer, alpha_ As Integer)
        Me.ver_ = ver_
        Me.beta_ = beta_
        Me.alpha_ = alpha_
    End Sub
End Class
