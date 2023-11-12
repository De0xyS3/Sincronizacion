Imports Newtonsoft.Json
Imports System.IO
Imports System.Diagnostics
Imports MimeKit
Imports MailKit.Net.Smtp

Public Class Form2
    Inherits Form

    Private Const ConfigFilePath As String = "SharePointConfig.json" ' Asegúrate de tener la ruta correcta al archivo JSON
    Private Const PowerShellScriptPath As String = "Get-SharePointLibraries.ps1" ' Asegúrate de tener la ruta correcta al script de PowerShell
    Private Const SettingsFilePath As String = "Settings.json" ' El archivo donde se guardarán las configuraciones
    Private Const SettingsFilePath2 As String = "Settings2.json" ' El archivo donde se guardarán las configuraciones
    Private Const SettingsFilePath3 As String = "Settings3.json" ' El archivo donde se guardarán las configuraciones
    Private Const SettingsFilePath4 As String = "Settings4.json" ' El archivo donde se guardarán las configuraciones
    Private Const EmailConfigFilePath As String = "email.json"
    Private Function ReadEmailSettings(EmailConfigFilePath As String) As Configurations.Settings
        ' Leer el archivo JSON y deserializar a la clase Settings
        Dim jsonContent As String = File.ReadAllText(EmailConfigFilePath)
        Return JsonConvert.DeserializeObject(Of Configurations.Settings)(jsonContent)
    End Function

    Private Sub SendEmail(settings As Configurations.Settings, subject As String, body As String)
        Try
            Dim message As New MimeMessage()
            message.From.Add(New MailboxAddress("Backup System", settings.FromEmail))
            message.To.Add(New MailboxAddress("Admin", settings.ToEmail))
            message.Subject = subject
            message.Body = New TextPart("plain") With {.Text = body}

            Using client As New MailKit.Net.Smtp.SmtpClient()
                client.Connect(settings.SMTPServer, settings.SMTPPort, settings.UseSSL)
                client.Authenticate(settings.SMTPUser, settings.SMTPPassword)
                client.Send(message)
                client.Disconnect(True)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al enviar el correo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private credentials As SharePointConfig1

    ' El ComboBox ya está diseñado y tiene el nombre cmbDocumentLibraries, así que no necesitas declararlo aquí.

    ' Constructor de Form2.
    Public Sub New()
        ' Este llamado es requerido por el diseñador.
        InitializeComponent()

        ' Cargar las credenciales de SharePoint desde el archivo JSON.
        LoadCredentials()

        ' Comenzar el proceso de llenar el ComboBox de forma asincrónica para evitar congelar la UI.
        Task.Run(Sub() LoadDocumentLibraries())
        Task.Run(Sub() LoadDocumentLibraries2())
        Task.Run(Sub() LoadDocumentLibraries3())
        Task.Run(Sub() LoadDocumentLibraries4())


    End Sub

    Private Sub ToggleControls(enable As Boolean)
        ' Cambia la propiedad Enabled de los controles
        Me.btnMigrateContent.Enabled = enable
        Me.txtSelectedFolder.Enabled = enable
        ' Repite para cada control que quieras habilitar/deshabilitar
        ' ...
    End Sub
    Private Sub ToggleControls2(enable As Boolean)
        ' Cambia la propiedad Enabled de los controles
        Me.btnMigrateContent2.Enabled = enable
        Me.txtSelectedFolder2.Enabled = enable
        ' Repite para cada control que quieras habilitar/deshabilitar
        ' ...
    End Sub
    Private Sub ToggleControls3(enable As Boolean)
        ' Cambia la propiedad Enabled de los controles
        Me.btnMigrateContent3.Enabled = enable
        Me.txtSelectedFolder3.Enabled = enable
        ' Repite para cada control que quieras habilitar/deshabilitar
        ' ...
    End Sub
    Private Sub ToggleControls4(enable As Boolean)
        ' Cambia la propiedad Enabled de los controles
        Me.btnMigrateContent4.Enabled = enable
        Me.txtSelectedFolder4.Enabled = enable
        ' Repite para cada control que quieras habilitar/deshabilitar
        ' ...
    End Sub

    Private Sub LoadCredentials()
        ' Carga las credenciales de SharePoint desde el archivo JSON.
        If File.Exists(ConfigFilePath) Then
            Dim jsonContent = File.ReadAllText(ConfigFilePath)
            credentials = JsonConvert.DeserializeObject(Of SharePointConfig1)(jsonContent)
        Else
            MessageBox.Show("No se encontró el archivo de configuración.")
            Me.Close()
        End If
    End Sub

    Private Sub LoadDocumentLibraries()
        ' Construye la información de inicio del proceso para ejecutar el script de PowerShell.
        Dim startInfo As New ProcessStartInfo With {
            .FileName = "pwsh.exe",
            .Arguments = $"-File ""{PowerShellScriptPath}"" -SiteUrl ""{credentials.SiteUrl}"" -Username ""{credentials.Username}"" -Password ""{credentials.Password}""",
            .UseShellExecute = False,
            .RedirectStandardOutput = True,
            .CreateNoWindow = True
        }

        ' Ejecuta el script de PowerShell y captura la salida.
        Using process As New Process With {.StartInfo = startInfo}
            process.Start()
            Dim result As String = process.StandardOutput.ReadToEnd()
            process.WaitForExit()

            ' Verifica el código de salida para determinar si el script se ejecutó correctamente.
            If process.ExitCode = 0 Then
                ' Deserializa la salida JSON a una lista de cadenas.
                Dim documentLibraries As List(Of String) = JsonConvert.DeserializeObject(Of List(Of String))(result)
                ' Invoca la actualización del ComboBox en el hilo de la interfaz de usuario.
                If cmbDocumentLibraries.InvokeRequired Then
                    cmbDocumentLibraries.Invoke(Sub()
                                                    UpdateComboBox(documentLibraries)
                                                End Sub)
                Else
                    UpdateComboBox(documentLibraries)
                End If
            Else
                MessageBox.Show("Hubo un error al ejecutar el script de PowerShell.")
            End If
        End Using
    End Sub


    Private Sub LoadDocumentLibraries2()
        ' Construye la información de inicio del proceso para ejecutar el script de PowerShell.
        Dim startInfo As New ProcessStartInfo With {
            .FileName = "pwsh.exe",
            .Arguments = $"-File ""{PowerShellScriptPath}"" -SiteUrl ""{credentials.SiteUrl}"" -Username ""{credentials.Username}"" -Password ""{credentials.Password}""",
            .UseShellExecute = False,
            .RedirectStandardOutput = True,
            .CreateNoWindow = True
        }

        ' Ejecuta el script de PowerShell y captura la salida.
        Using process As New Process With {.StartInfo = startInfo}
            process.Start()
            Dim result As String = process.StandardOutput.ReadToEnd()
            process.WaitForExit()

            ' Verifica el código de salida para determinar si el script se ejecutó correctamente.
            If process.ExitCode = 0 Then
                ' Deserializa la salida JSON a una lista de cadenas.
                Dim documentLibraries As List(Of String) = JsonConvert.DeserializeObject(Of List(Of String))(result)
                ' Invoca la actualización del ComboBox en el hilo de la interfaz de usuario.
                If cmbDocumentLibraries2.InvokeRequired Then
                    cmbDocumentLibraries2.Invoke(Sub()
                                                     UpdateComboBox2(documentLibraries)
                                                 End Sub)
                Else
                    UpdateComboBox2(documentLibraries)
                End If
            Else
                MessageBox.Show("Hubo un error al ejecutar el script de PowerShell.")
            End If
        End Using
    End Sub
    Private Sub LoadDocumentLibraries3()
        ' Construye la información de inicio del proceso para ejecutar el script de PowerShell.
        Dim startInfo As New ProcessStartInfo With {
            .FileName = "pwsh.exe",
            .Arguments = $"-File ""{PowerShellScriptPath}"" -SiteUrl ""{credentials.SiteUrl}"" -Username ""{credentials.Username}"" -Password ""{credentials.Password}""",
            .UseShellExecute = False,
            .RedirectStandardOutput = True,
            .CreateNoWindow = True
        }

        ' Ejecuta el script de PowerShell y captura la salida.
        Using process As New Process With {.StartInfo = startInfo}
            process.Start()
            Dim result As String = process.StandardOutput.ReadToEnd()
            process.WaitForExit()

            ' Verifica el código de salida para determinar si el script se ejecutó correctamente.
            If process.ExitCode = 0 Then
                ' Deserializa la salida JSON a una lista de cadenas.
                Dim documentLibraries As List(Of String) = JsonConvert.DeserializeObject(Of List(Of String))(result)
                ' Invoca la actualización del ComboBox en el hilo de la interfaz de usuario.
                If cmbDocumentLibraries3.InvokeRequired Then
                    cmbDocumentLibraries3.Invoke(Sub()
                                                     UpdateComboBox3(documentLibraries)
                                                 End Sub)
                Else
                    UpdateComboBox3(documentLibraries)
                End If
            Else
                MessageBox.Show("Hubo un error al ejecutar el script de PowerShell.")
            End If
        End Using
    End Sub
    Private Sub LoadDocumentLibraries4()
        ' Construye la información de inicio del proceso para ejecutar el script de PowerShell.
        Dim startInfo As New ProcessStartInfo With {
            .FileName = "pwsh.exe",
            .Arguments = $"-File ""{PowerShellScriptPath}"" -SiteUrl ""{credentials.SiteUrl}"" -Username ""{credentials.Username}"" -Password ""{credentials.Password}""",
            .UseShellExecute = False,
            .RedirectStandardOutput = True,
            .CreateNoWindow = True
        }

        ' Ejecuta el script de PowerShell y captura la salida.
        Using process As New Process With {.StartInfo = startInfo}
            process.Start()
            Dim result As String = process.StandardOutput.ReadToEnd()
            process.WaitForExit()

            ' Verifica el código de salida para determinar si el script se ejecutó correctamente.
            If process.ExitCode = 0 Then
                ' Deserializa la salida JSON a una lista de cadenas.
                Dim documentLibraries As List(Of String) = JsonConvert.DeserializeObject(Of List(Of String))(result)
                ' Invoca la actualización del ComboBox en el hilo de la interfaz de usuario.
                If cmbDocumentLibraries4.InvokeRequired Then
                    cmbDocumentLibraries4.Invoke(Sub()
                                                     UpdateComboBox4(documentLibraries)
                                                 End Sub)
                Else
                    UpdateComboBox4(documentLibraries)
                End If
            Else
                MessageBox.Show("Hubo un error al ejecutar el script de PowerShell.")
            End If
        End Using
    End Sub

    ' Actualiza el ComboBox con los items de la lista proporcionada.
    Private Sub UpdateComboBox(documentLibraries As List(Of String))
        cmbDocumentLibraries.Items.Clear()
        For Each library As String In documentLibraries
            cmbDocumentLibraries.Items.Add(library)
        Next
    End Sub
    Private Sub UpdateComboBox2(documentLibraries As List(Of String))
        cmbDocumentLibraries2.Items.Clear()
        For Each library As String In documentLibraries
            cmbDocumentLibraries2.Items.Add(library)
        Next
    End Sub
    Private Sub UpdateComboBox3(documentLibraries As List(Of String))
        cmbDocumentLibraries3.Items.Clear()
        For Each library As String In documentLibraries
            cmbDocumentLibraries3.Items.Add(library)
        Next
    End Sub
    Private Sub UpdateComboBox4(documentLibraries As List(Of String))
        cmbDocumentLibraries4.Items.Clear()
        For Each library As String In documentLibraries
            cmbDocumentLibraries4.Items.Add(library)
        Next
    End Sub

    ' Clase para coincidir con la estructura de tu archivo de configuración JSON.
    Private Class SharePointConfig1
        Public Property SiteUrl As String
        Public Property Username As String
        Public Property Password As String
    End Class

    ' Método para el evento Click del botón que abre el FolderBrowserDialog.
    Private Sub btnLoadFile1_Click(sender As Object, e As EventArgs) Handles btnLoadFile1.Click
        ' Mostrar el FolderBrowserDialog.
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            ' Establecer la ruta de la carpeta seleccionada en el TextBox.
            txtSelectedFolder.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        ' Crea una instancia de la configuración para guardar.
        Dim config As New Configuration With {
            .SiteUrl = credentials.SiteUrl,
            .Username = credentials.Username,
            .Password = credentials.Password,
            .LocalFolderPath = txtSelectedFolder.Text,
            .SelectedLibrary = If(cmbDocumentLibraries.SelectedItem IsNot Nothing, cmbDocumentLibraries.SelectedItem.ToString(), String.Empty)
        }

        ' Guarda la configuración en un archivo JSON.
        SaveConfiguration(SettingsFilePath, config)
    End Sub

    ' Método para guardar la configuración en un archivo JSON.
    Private Sub SaveConfiguration(filePath As String, config As Configuration)
        Dim jsonContent As String = JsonConvert.SerializeObject(config, Formatting.Indented)
        File.WriteAllText(filePath, jsonContent)
        MessageBox.Show("La configuración se guardó correctamente.")
    End Sub

    ' Clase para la configuración que se guardará.
    Private Class Configuration
        Public Property SiteUrl As String
        Public Property Username As String
        Public Property Password As String
        Public Property LocalFolderPath As String
        Public Property SelectedLibrary As String
    End Class

    Private Sub btnMigrateContent_Click(sender As Object, e As EventArgs) Handles btnMigrateContent.Click
        Dim settings As Configuration = LoadConfiguration(SettingsFilePath)

        ' Aquí deberías comprobar que settings tiene toda la información necesaria.

        ' Inicia el proceso de migración en un hilo separado.
        Task.Run(Sub() RunMigrationScript(settings))
    End Sub
    Private Function LoadConfiguration(filePath As String) As Configuration
        Dim jsonContent As String = File.ReadAllText(filePath)
        Return JsonConvert.DeserializeObject(Of Configuration)(jsonContent)
    End Function


    Private Sub RunMigrationScript(settings As Configuration)
        ' Deshabilita los controles al inicio del proceso
        '   Me.Invoke(Sub() ToggleControls(False)) 

        Me.Invoke(Sub()
                      ToggleControls(False)
                      lblstatus1.Text = "Ejecutando..."
                      lblstatus1.BackColor = Color.Green
                  End Sub)
        ' Establece los valores iniciales para la barra de progreso
        ProgressBar.Minimum = 0
        ProgressBar.Maximum = 100
        ProgressBar.Value = 0

        ' Configura el proceso para ejecutar el script de PowerShell
        Dim startInfo As New ProcessStartInfo With {
            .FileName = "pwsh.exe",
            .Arguments = $"-File ""copiardata.ps1"" -LocalFolderPath ""{settings.LocalFolderPath}"" -SelectedLibrary ""{settings.SelectedLibrary}"" -SiteUrl ""{settings.SiteUrl}"" -Username ""{settings.Username}"" -Password ""{settings.Password}""",
            .UseShellExecute = False,
            .RedirectStandardOutput = True,
            .RedirectStandardError = True,
            .CreateNoWindow = True
        }

        ' Ejecuta el script en un nuevo hilo para evitar congelar la interfaz de usuario
        Task.Run(Sub()
                     Using process As New Process With {.StartInfo = startInfo}
                         process.Start()

                         ' Lee la salida del proceso para actualizar la barra de progreso
                         While Not process.StandardOutput.EndOfStream
                             Dim line As String = process.StandardOutput.ReadLine()

                             ' Asume que la salida de progreso es del tipo "Progress: 50.00"
                             If line.StartsWith("Progress: ") Then
                                 ' Extrae el número de progreso como un decimal y conviértelo a entero
                                 Dim progressPercentageStr As String = line.Replace("Progress: ", "").Trim()
                                 Dim progressPercentage As Decimal
                                 If Decimal.TryParse(progressPercentageStr, progressPercentage) Then
                                     ' Actualiza la barra de progreso en el hilo de la interfaz de usuario
                                     Me.Invoke(Sub()
                                                   ProgressBar.Value = CInt(Math.Truncate(progressPercentage))
                                               End Sub)
                                 End If
                             End If
                         End While

                         ' Espera a que el proceso termine
                         process.WaitForExit()

                         ' Restablece la barra de progreso a 0 después de la operación
                         Me.Invoke(Sub() ProgressBar.Value = 0)
                         '        ToggleControls(True)
                         Me.Invoke(Sub()
                                       ToggleControls(True)
                                       lblstatus1.Text = "En espera de ejecución"
                                       lblstatus1.BackColor = Color.Red
                                   End Sub)
                         ' Maneja el resultado de la ejecución del script
                         If process.ExitCode <> 0 Then
                             ' Lee el error si lo hay
                             Dim errorOutput As String = process.StandardError.ReadToEnd()
                             ' Muestra el error en la interfaz de usuario o lo registra
                             Me.Invoke(Sub() MessageBox.Show($"Error durante la migración: {errorOutput}"))
                         Else
                             ' Muestra un mensaje de éxito
                             Me.Invoke(Sub() MessageBox.Show("La migración de contenido se completó correctamente."))
                             ' Enviar correo electrónico
                             Dim emailSettings As Configurations.Settings = ReadEmailSettings(EmailConfigFilePath)
                             SendEmail(emailSettings, "Respaldo Completado", "El proceso de respaldo ha terminado exitosamente.")


                         End If
                     End Using
                 End Sub)
    End Sub

    Private Sub RunMigrationScript2(settings As Configuration)
        ' Deshabilita los controles al inicio del proceso
        '  Me.Invoke(Sub() ToggleControls2(False))
        Me.Invoke(Sub()
                      ToggleControls2(False)
                      lblstatus2.Text = "Ejecutando..."
                      lblstatus2.BackColor = Color.Green
                  End Sub)
        ' Establece los valores iniciales para la barra de progreso
        ProgressBar2.Minimum = 0
        ProgressBar2.Maximum = 100
        ProgressBar2.Value = 0

        ' Configura el proceso para ejecutar el script de PowerShell
        Dim startInfo As New ProcessStartInfo With {
            .FileName = "pwsh.exe",
            .Arguments = $"-File ""copiardata2.ps1"" -LocalFolderPath ""{settings.LocalFolderPath}"" -SelectedLibrary ""{settings.SelectedLibrary}"" -SiteUrl ""{settings.SiteUrl}"" -Username ""{settings.Username}"" -Password ""{settings.Password}""",
            .UseShellExecute = False,
            .RedirectStandardOutput = True,
            .RedirectStandardError = True,
            .CreateNoWindow = True
        }

        ' Ejecuta el script en un nuevo hilo para evitar congelar la interfaz de usuario
        Task.Run(Sub()
                     Using process As New Process With {.StartInfo = startInfo}
                         process.Start()

                         ' Lee la salida del proceso para actualizar la barra de progreso
                         While Not process.StandardOutput.EndOfStream
                             Dim line As String = process.StandardOutput.ReadLine()

                             ' Asume que la salida de progreso es del tipo "Progress: 50.00"
                             If line.StartsWith("Progress: ") Then
                                 ' Extrae el número de progreso como un decimal y conviértelo a entero
                                 Dim progressPercentageStr As String = line.Replace("Progress: ", "").Trim()
                                 Dim progressPercentage As Decimal
                                 If Decimal.TryParse(progressPercentageStr, progressPercentage) Then
                                     ' Actualiza la barra de progreso en el hilo de la interfaz de usuario
                                     Me.Invoke(Sub()
                                                   ProgressBar2.Value = CInt(Math.Truncate(progressPercentage))
                                               End Sub)
                                 End If
                             End If
                         End While

                         ' Espera a que el proceso termine
                         process.WaitForExit()

                         ' Restablece la barra de progreso a 0 después de la operación
                         Me.Invoke(Sub() ProgressBar2.Value = 0)
                         '     ToggleControls2(True)
                         Me.Invoke(Sub()
                                       ToggleControls2(True)
                                       lblstatus2.Text = "En espera de ejecución"
                                       lblstatus2.BackColor = Color.Red
                                   End Sub)
                         ' Maneja el resultado de la ejecución del script
                         If process.ExitCode <> 0 Then
                             ' Lee el error si lo hay
                             Dim errorOutput As String = process.StandardError.ReadToEnd()
                             ' Muestra el error en la interfaz de usuario o lo registra
                             Me.Invoke(Sub() MessageBox.Show($"Error durante la migración: {errorOutput}"))
                         Else
                             ' Muestra un mensaje de éxito
                             Me.Invoke(Sub() MessageBox.Show("La migración de contenido se completó correctamente."))
                         End If
                     End Using
                 End Sub)
    End Sub

    Private Sub btnLoadFile2_Click(sender As Object, e As EventArgs) Handles btnLoadFile2.Click
        ' Mostrar el FolderBrowserDialog.
        If FolderBrowserDialog2.ShowDialog() = DialogResult.OK Then
            ' Establecer la ruta de la carpeta seleccionada en el TextBox.
            txtSelectedFolder2.Text = FolderBrowserDialog2.SelectedPath
        End If
    End Sub

    Private Sub btnMigrateContent2_Click(sender As Object, e As EventArgs) Handles btnMigrateContent2.Click
        Dim settings As Configuration = LoadConfiguration(SettingsFilePath2)

        ' Aquí deberías comprobar que settings tiene toda la información necesaria.

        ' Inicia el proceso de migración en un hilo separado.
        Task.Run(Sub() RunMigrationScript2(settings))
    End Sub

    Private Sub btnSaveSettings2_Click(sender As Object, e As EventArgs) Handles btnSaveSettings2.Click
        ' Crea una instancia de la configuración para guardar.
        Dim config As New Configuration With {
            .SiteUrl = credentials.SiteUrl,
            .Username = credentials.Username,
            .Password = credentials.Password,
            .LocalFolderPath = txtSelectedFolder2.Text,
            .SelectedLibrary = If(cmbDocumentLibraries2.SelectedItem IsNot Nothing, cmbDocumentLibraries2.SelectedItem.ToString(), String.Empty)
        }

        ' Guarda la configuración en un archivo JSON.
        SaveConfiguration(SettingsFilePath2, config)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form3 As New Form3()
        form3.Show()
    End Sub


    Private Sub RunMigrationScript3(settings As Configuration)
        ' Deshabilita los controles al inicio del proceso
        '  Me.Invoke(Sub() ToggleControls2(False))
        Me.Invoke(Sub()
                      ToggleControls3(False)
                      lblstatus3.Text = "Ejecutando..."
                      lblstatus3.BackColor = Color.Green
                  End Sub)
        ' Establece los valores iniciales para la barra de progreso
        ProgressBar3.Minimum = 0
        ProgressBar3.Maximum = 100
        ProgressBar3.Value = 0

        ' Configura el proceso para ejecutar el script de PowerShell
        Dim startInfo As New ProcessStartInfo With {
            .FileName = "pwsh.exe",
            .Arguments = $"-File ""copiardata3.ps1"" -LocalFolderPath ""{settings.LocalFolderPath}"" -SelectedLibrary ""{settings.SelectedLibrary}"" -SiteUrl ""{settings.SiteUrl}"" -Username ""{settings.Username}"" -Password ""{settings.Password}""",
            .UseShellExecute = False,
            .RedirectStandardOutput = True,
            .RedirectStandardError = True,
            .CreateNoWindow = True
        }

        ' Ejecuta el script en un nuevo hilo para evitar congelar la interfaz de usuario
        Task.Run(Sub()
                     Using process As New Process With {.StartInfo = startInfo}
                         process.Start()

                         ' Lee la salida del proceso para actualizar la barra de progreso
                         While Not process.StandardOutput.EndOfStream
                             Dim line As String = process.StandardOutput.ReadLine()

                             ' Asume que la salida de progreso es del tipo "Progress: 50.00"
                             If line.StartsWith("Progress: ") Then
                                 ' Extrae el número de progreso como un decimal y conviértelo a entero
                                 Dim progressPercentageStr As String = line.Replace("Progress: ", "").Trim()
                                 Dim progressPercentage As Decimal
                                 If Decimal.TryParse(progressPercentageStr, progressPercentage) Then
                                     ' Actualiza la barra de progreso en el hilo de la interfaz de usuario
                                     Me.Invoke(Sub()
                                                   ProgressBar3.Value = CInt(Math.Truncate(progressPercentage))
                                               End Sub)
                                 End If
                             End If
                         End While

                         ' Espera a que el proceso termine
                         process.WaitForExit()

                         ' Restablece la barra de progreso a 0 después de la operación
                         Me.Invoke(Sub() ProgressBar3.Value = 0)
                         '     ToggleControls2(True)
                         Me.Invoke(Sub()
                                       ToggleControls3(True)
                                       lblstatus3.Text = "En espera de ejecución"
                                       lblstatus3.BackColor = Color.Red
                                   End Sub)
                         ' Maneja el resultado de la ejecución del script
                         If process.ExitCode <> 0 Then
                             ' Lee el error si lo hay
                             Dim errorOutput As String = process.StandardError.ReadToEnd()
                             ' Muestra el error en la interfaz de usuario o lo registra
                             Me.Invoke(Sub() MessageBox.Show($"Error durante la migración: {errorOutput}"))
                         Else
                             ' Muestra un mensaje de éxito
                             Me.Invoke(Sub() MessageBox.Show("La migración de contenido se completó correctamente."))
                         End If
                     End Using
                 End Sub)
    End Sub

    Private Sub btnLoadFile3_Click(sender As Object, e As EventArgs) Handles btnLoadFile3.Click
        ' Mostrar el FolderBrowserDialog.
        If FolderBrowserDialog3.ShowDialog() = DialogResult.OK Then
            ' Establecer la ruta de la carpeta seleccionada en el TextBox.
            txtSelectedFolder3.Text = FolderBrowserDialog3.SelectedPath
        End If
    End Sub

    Private Sub btnMigrateContent3_Click(sender As Object, e As EventArgs) Handles btnMigrateContent3.Click
        Dim settings As Configuration = LoadConfiguration(SettingsFilePath3)

        ' Aquí deberías comprobar que settings tiene toda la información necesaria.

        ' Inicia el proceso de migración en un hilo separado.
        Task.Run(Sub() RunMigrationScript3(settings))
    End Sub

    Private Sub btnSaveSettings3_Click(sender As Object, e As EventArgs) Handles btnSaveSettings3.Click
        ' Crea una instancia de la configuración para guardar.
        Dim config As New Configuration With {
            .SiteUrl = credentials.SiteUrl,
            .Username = credentials.Username,
            .Password = credentials.Password,
            .LocalFolderPath = txtSelectedFolder3.Text,
            .SelectedLibrary = If(cmbDocumentLibraries3.SelectedItem IsNot Nothing, cmbDocumentLibraries3.SelectedItem.ToString(), String.Empty)
        }

        ' Guarda la configuración en un archivo JSON.
        SaveConfiguration(SettingsFilePath3, config)
    End Sub


    Private Sub RunMigrationScript4(settings As Configuration)
        ' Deshabilita los controles al inicio del proceso
        '  Me.Invoke(Sub() ToggleControls2(False))
        Me.Invoke(Sub()
                      ToggleControls4(False)
                      lblstatus4.Text = "Ejecutando..."
                      lblstatus4.BackColor = Color.Green
                  End Sub)
        ' Establece los valores iniciales para la barra de progreso
        ProgressBar4.Minimum = 0
        ProgressBar4.Maximum = 100
        ProgressBar4.Value = 0

        ' Configura el proceso para ejecutar el script de PowerShell
        Dim startInfo As New ProcessStartInfo With {
            .FileName = "pwsh.exe",
            .Arguments = $"-File ""copiardata4.ps1"" -LocalFolderPath ""{settings.LocalFolderPath}"" -SelectedLibrary ""{settings.SelectedLibrary}"" -SiteUrl ""{settings.SiteUrl}"" -Username ""{settings.Username}"" -Password ""{settings.Password}""",
            .UseShellExecute = False,
            .RedirectStandardOutput = True,
            .RedirectStandardError = True,
            .CreateNoWindow = True
        }

        ' Ejecuta el script en un nuevo hilo para evitar congelar la interfaz de usuario
        Task.Run(Sub()
                     Using process As New Process With {.StartInfo = startInfo}
                         process.Start()

                         ' Lee la salida del proceso para actualizar la barra de progreso
                         While Not process.StandardOutput.EndOfStream
                             Dim line As String = process.StandardOutput.ReadLine()

                             ' Asume que la salida de progreso es del tipo "Progress: 50.00"
                             If line.StartsWith("Progress: ") Then
                                 ' Extrae el número de progreso como un decimal y conviértelo a entero
                                 Dim progressPercentageStr As String = line.Replace("Progress: ", "").Trim()
                                 Dim progressPercentage As Decimal
                                 If Decimal.TryParse(progressPercentageStr, progressPercentage) Then
                                     ' Actualiza la barra de progreso en el hilo de la interfaz de usuario
                                     Me.Invoke(Sub()
                                                   ProgressBar4.Value = CInt(Math.Truncate(progressPercentage))
                                               End Sub)
                                 End If
                             End If
                         End While

                         ' Espera a que el proceso termine
                         process.WaitForExit()

                         ' Restablece la barra de progreso a 0 después de la operación
                         Me.Invoke(Sub() ProgressBar4.Value = 0)
                         '     ToggleControls2(True)
                         Me.Invoke(Sub()
                                       ToggleControls4(True)
                                       lblstatus4.Text = "En espera de ejecución"
                                       lblstatus4.BackColor = Color.Red
                                   End Sub)
                         ' Maneja el resultado de la ejecución del script
                         If process.ExitCode <> 0 Then
                             ' Lee el error si lo hay
                             Dim errorOutput As String = process.StandardError.ReadToEnd()
                             ' Muestra el error en la interfaz de usuario o lo registra
                             Me.Invoke(Sub() MessageBox.Show($"Error durante la migración: {errorOutput}"))
                         Else
                             ' Muestra un mensaje de éxito
                             Me.Invoke(Sub() MessageBox.Show("La migración de contenido se completó correctamente."))
                         End If
                     End Using
                 End Sub)
    End Sub

    Private Sub btnLoadFile4_Click(sender As Object, e As EventArgs) Handles btnLoadFile4.Click
        ' Mostrar el FolderBrowserDialog.
        If FolderBrowserDialog4.ShowDialog() = DialogResult.OK Then
            ' Establecer la ruta de la carpeta seleccionada en el TextBox.
            txtSelectedFolder4.Text = FolderBrowserDialog4.SelectedPath
        End If
    End Sub

    Private Sub btnMigrateContent4_Click(sender As Object, e As EventArgs) Handles btnMigrateContent4.Click
        Dim settings As Configuration = LoadConfiguration(SettingsFilePath4)

        ' Aquí deberías comprobar que settings tiene toda la información necesaria.

        ' Inicia el proceso de migración en un hilo separado.
        Task.Run(Sub() RunMigrationScript4(settings))
    End Sub

    Private Sub btnSaveSettings4_Click(sender As Object, e As EventArgs) Handles btnSaveSettings4.Click
        ' Crea una instancia de la configuración para guardar.
        Dim config As New Configuration With {
            .SiteUrl = credentials.SiteUrl,
            .Username = credentials.Username,
            .Password = credentials.Password,
            .LocalFolderPath = txtSelectedFolder4.Text,
            .SelectedLibrary = If(cmbDocumentLibraries4.SelectedItem IsNot Nothing, cmbDocumentLibraries4.SelectedItem.ToString(), String.Empty)
        }

        ' Guarda la configuración en un archivo JSON.
        SaveConfiguration(SettingsFilePath4, config)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ProgramarEjecucion()
        Else
            Timer1.Stop()
        End If
    End Sub

    Private Sub ProgramarEjecucion()
        Dim targetTime As DateTime = DateTimePicker1.Value
        If targetTime < DateTime.Now Then
            MessageBox.Show("La hora seleccionada ya ha pasado. Se programará para el mismo horario mañana.")
            targetTime = targetTime.AddDays(1)
        End If

        DateTimePicker1.Value = targetTime
        Timer1.Interval = 60000 ' 60 segundos * 1000
        Timer1.Start()

        MessageBox.Show("Ejecución programada para las " & targetTime.ToShortTimeString())
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Comprueba si es la hora para ejecutar el script
        Dim currentTime As DateTime = DateTime.Now
        Dim scheduledTime As DateTime = DateTimePicker1.Value

        If currentTime.Hour = scheduledTime.Hour AndAlso currentTime.Minute = scheduledTime.Minute Then
            ' Detén el Timer y ejecuta el script
            Timer1.Stop()
            RunMigrationScript(ObtenerSettings()) ' Asegúrate de tener una función que obtenga los ajustes necesarios
        End If
    End Sub

    Private Function ObtenerSettings() As Configuration
        ' Supongamos que tienes un método para leer un archivo de configuración JSON
        Dim settingsFilePath As String = "Settings.json"
        Dim jsonContent As String = File.ReadAllText(settingsFilePath)
        Return JsonConvert.DeserializeObject(Of Configuration)(jsonContent)
    End Function

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            ProgramarEjecucion2()
        Else
            Timer2.Stop()
        End If
    End Sub


    Private Sub ProgramarEjecucion2()
        Dim targetTime As DateTime = DateTimePicker2.Value
        If targetTime < DateTime.Now Then
            MessageBox.Show("La hora seleccionada ya ha pasado. Se programará para el mismo horario mañana.")
            targetTime = targetTime.AddDays(1)
        End If

        DateTimePicker2.Value = targetTime
        Timer2.Interval = 60000 ' 60 segundos * 1000
        Timer2.Start()

        MessageBox.Show("Ejecución programada para las " & targetTime.ToShortTimeString())
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' Comprueba si es la hora para ejecutar el script
        Dim currentTime As DateTime = DateTime.Now
        Dim scheduledTime As DateTime = DateTimePicker2.Value

        If currentTime.Hour = scheduledTime.Hour AndAlso currentTime.Minute = scheduledTime.Minute Then
            ' Detén el Timer y ejecuta el script
            Timer2.Stop()
            RunMigrationScript2(ObtenerSettings2()) ' Asegúrate de tener una función que obtenga los ajustes necesarios
        End If
    End Sub


    Private Function ObtenerSettings2() As Configuration
        ' Supongamos que tienes un método para leer un archivo de configuración JSON
        Dim settingsFilePath2 As String = "Settings2.json"
        Dim jsonContent As String = File.ReadAllText(SettingsFilePath2)
        Return JsonConvert.DeserializeObject(Of Configuration)(jsonContent)
    End Function

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            ProgramarEjecucion3()
        Else
            Timer3.Stop()
        End If
    End Sub

    Private Sub ProgramarEjecucion3()
        Dim targetTime As DateTime = DateTimePicker3.Value
        If targetTime < DateTime.Now Then
            MessageBox.Show("La hora seleccionada ya ha pasado. Se programará para el mismo horario mañana.")
            targetTime = targetTime.AddDays(1)
        End If

        DateTimePicker3.Value = targetTime
        Timer3.Interval = 60000 ' 60 segundos * 1000
        Timer3.Start()

        MessageBox.Show("Ejecución programada para las " & targetTime.ToShortTimeString())
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        ' Comprueba si es la hora para ejecutar el script
        Dim currentTime As DateTime = DateTime.Now
        Dim scheduledTime As DateTime = DateTimePicker3.Value

        If currentTime.Hour = scheduledTime.Hour AndAlso currentTime.Minute = scheduledTime.Minute Then
            ' Detén el Timer y ejecuta el script
            Timer3.Stop()
            RunMigrationScript3(ObtenerSettings3()) ' Asegúrate de tener una función que obtenga los ajustes necesarios
        End If
    End Sub

    Private Function ObtenerSettings3() As Configuration
        ' Supongamos que tienes un método para leer un archivo de configuración JSON
        Dim settingsFilePath3 As String = "Settings3.json"
        Dim jsonContent As String = File.ReadAllText(settingsFilePath3)
        Return JsonConvert.DeserializeObject(Of Configuration)(jsonContent)
    End Function

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            ProgramarEjecucion4()
        Else
            Timer4.Stop()
        End If
    End Sub

    Private Sub ProgramarEjecucion4()
        Dim targetTime As DateTime = DateTimePicker4.Value
        If targetTime < DateTime.Now Then
            MessageBox.Show("La hora seleccionada ya ha pasado. Se programará para el mismo horario mañana.")
            targetTime = targetTime.AddDays(1)
        End If

        DateTimePicker4.Value = targetTime
        Timer3.Interval = 60000 ' 60 segundos * 1000
        Timer3.Start()

        MessageBox.Show("Ejecución programada para las " & targetTime.ToShortTimeString())
    End Sub


    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        ' Comprueba si es la hora para ejecutar el script
        Dim currentTime As DateTime = DateTime.Now
        Dim scheduledTime As DateTime = DateTimePicker3.Value

        If currentTime.Hour = scheduledTime.Hour AndAlso currentTime.Minute = scheduledTime.Minute Then
            ' Detén el Timer y ejecuta el script
            Timer3.Stop()
            RunMigrationScript4(ObtenerSettings4()) ' Asegúrate de tener una función que obtenga los ajustes necesarios
        End If
    End Sub


    Private Function ObtenerSettings4() As Configuration
        ' Supongamos que tienes un método para leer un archivo de configuración JSON
        Dim settingsFilePath4 As String = "Settings4.json"
        Dim jsonContent As String = File.ReadAllText(settingsFilePath4)
        Return JsonConvert.DeserializeObject(Of Configuration)(jsonContent)
    End Function


End Class
