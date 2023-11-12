Imports Newtonsoft.Json
Public Class Form1

    Private Const ConfigFilePath As String = "SharePointConfig.json"
    Public Function LoadSettingsFromFile(filePath As String) As SharePointConfig1
        If IO.File.Exists(filePath) Then
            Dim jsonContent = IO.File.ReadAllText(filePath)
            Return JsonConvert.DeserializeObject(Of SharePointConfig1)(jsonContent)
        Else
            Return New SharePointConfig1()
        End If
    End Function
    Public Sub SaveSettingsToFile(filePath As String, config As SharePointConfig1)
        Dim jsonContent = JsonConvert.SerializeObject(config, Newtonsoft.Json.Formatting.Indented)
        IO.File.WriteAllText(filePath, jsonContent)
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        ' Declarar la lista de directorios fuera del bloque If
        Dim directories As List(Of String) = Nothing

        ' Configurar la información para iniciar el proceso de PowerShell 7
        Dim startInfo As New ProcessStartInfo With {
            .FileName = "pwsh.exe",
            .Arguments = "-File Get-SharePointLibraries.ps1 " &
                         "-SiteUrl """ & txtSharePointSite.Text & """ " &
                         "-Username """ & txtSharePointUsername.Text & """ " &
                         "-Password """ & txtSharePointPassword.Text & """",
            .RedirectStandardOutput = True,
            .UseShellExecute = False,
            .CreateNoWindow = True
        }

        ' Iniciar el proceso y leer la salida
        Using process As New Process With {.StartInfo = startInfo}
            process.Start()
            Dim output As String = process.StandardOutput.ReadToEnd()
            process.WaitForExit()

            ' Convertir la salida JSON en una lista de directorios
            If output.StartsWith("{") Or output.StartsWith("[") Then
                ' Asignar un valor a la variable "directories"
                directories = JsonConvert.DeserializeObject(Of List(Of String))(output)

                MessageBox.Show("Cuenta conectada con éxito.")

            Else
                MessageBox.Show("Salida no es un JSON válido: " & output)
            End If

        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim config As New SharePointConfig1() With {
            .SiteUrl = txtSharePointSite.Text,
            .Username = txtSharePointUsername.Text,
            .Password = txtSharePointPassword.Text
        }
        SaveSettingsToFile(ConfigFilePath, config)
        MessageBox.Show("Configuración guardada con éxito!")
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()


    End Sub


    Public Class SharePointConfig1
        Public Property SiteUrl As String
        Public Property Username As String
        Public Property Password As String
    End Class
End Class
