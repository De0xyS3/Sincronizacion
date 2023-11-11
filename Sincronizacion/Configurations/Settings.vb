Imports System.IO
Imports Newtonsoft.Json

Namespace Configurations

    Public Class Settings

        Public Shared Property SMTPServer As String
        Public Shared Property SMTPPort As Integer
        Public Shared Property UseSSL As Boolean
        Public Shared Property SMTPUser As String
        Public Shared Property SMTPPassword As String
        Public Shared Property FromEmail As String
        Public Shared Property ToEmail As String


        ' Método para cargar configuraciones desde un archivo
        Public Shared Function LoadSettingsFromFile(filePath As String) As Settings
            If File.Exists(filePath) Then
                Dim jsonString As String = File.ReadAllText(filePath)
                Return JsonConvert.DeserializeObject(Of Settings)(jsonString)
            Else
                Return New Settings() ' Retornar configuraciones por defecto si el archivo no existe
            End If
        End Function

        ' Método para guardar configuraciones en un archivo
        Public Sub SaveSettingsToFile(filePath As String)
            Dim jsonString As String = JsonConvert.SerializeObject(Me)
            File.WriteAllText(filePath, jsonString)
        End Sub

    End Class

End Namespace
