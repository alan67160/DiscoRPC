Imports System.Text.RegularExpressions
Imports Newtonsoft.Json.Linq

Namespace Lang
    Module LangModule
        Public CurrentLang As Dictionary(Of String, JObject) = Nothing
        Public ReadOnly ArgumentsRegex As New Regex("\[\[[\s*[^>](.*?)]]]", RegexOptions.Compiled)
        Sub Load()
            CurrentLang = New Dictionary(Of String, JObject)
            For Each file In IO.Directory.GetFiles("langs")
                Try
                    Dim lang_json As JObject = JObject.Parse(IO.File.ReadAllText(file))
                    If lang_json.ContainsKey("langcode") Then
                        CurrentLang.Add(lang_json("langcode").ToString, lang_json)
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.ToString)
                End Try
            Next
        End Sub

        Public Function Translate(lang As String, code As String, ParamArray arguments As String()) As String
            Try
                Try
                    If CurrentLang Is Nothing Then Throw New Exception
                    If CurrentLang.ContainsKey(lang) Then
                        Dim lang_object = CurrentLang(lang)
                        If lang_object.ContainsKey(code) Then
                            Return SetArguments(lang_object(code), arguments)
                        Else
                            Throw New Exception
                        End If
                    Else
                        Throw New Exception
                    End If
                Catch
                    If CurrentLang Is Nothing Then Throw New Exception
                    If CurrentLang.ContainsKey("en") Then
                        Dim lang_object = CurrentLang("en")
                        If lang_object.ContainsKey(code) Then
                            Return SetArguments(lang_object(code), arguments)
                        Else
                            Throw New Exception
                        End If
                    Else
                        Throw New Exception
                    End If
                End Try
            Catch
                Return SetArguments($"{lang}.{code}", arguments)
            End Try
        End Function

        Private Function SetArguments(original As String, ParamArray arguments As String()) As String
            Dim result As String = original
            Try
                If arguments.Count > 0 Then
                    For i = 0 To arguments.Count - 1
                        result = result.Replace($"{{{{{i}}}}}", arguments(i))
                    Next
                End If
            Catch ex As Exception
                Console.WriteLine(ex.ToString)
            End Try

            Return result
        End Function
    End Module
End Namespace
