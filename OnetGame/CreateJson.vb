Imports System.Text.Json.Serialization

Public Class CreateJson
    <JsonPropertyName("nama")>
    Public Property Nama As String

    <JsonPropertyName("skor")>
    Public Property Skor As Integer

    <JsonPropertyName("tingkatKesulitan")>
    Public Property TingkatKesulitan As String

    <JsonPropertyName("modePermainan")>
    Public Property ModePermainan As String
End Class
