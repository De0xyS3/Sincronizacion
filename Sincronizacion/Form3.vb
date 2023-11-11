Imports System.IO
Imports Newtonsoft.Json
Imports MailKit.Net.Smtp

Public Class Form3
    Private Const ConfigFilePath As String = "email.json" ' Modificar según la ubicación deseada

    Private Sub conectar_Click(sender As Object, e As EventArgs) Handles conectar.Click
        Try
            Using client As New SmtpClient()
                client.Connect(txtSMTPServer.Text, CInt(txtSMTPPort.Text), chkUseSSL.Checked)
                client.Authenticate(txtSMTPUser.Text, txtSMTPPassword.Text)
                client.Disconnect(True)
            End Using
            MessageBox.Show("Conexión exitosa.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al conectar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Dim currentSettings As New Configurations.Settings()
        currentSettings.SMTPServer = txtSMTPServer.Text
        currentSettings.SMTPPort = CInt(txtSMTPPort.Text)
        currentSettings.UseSSL = chkUseSSL.Checked
        currentSettings.SMTPUser = txtSMTPUser.Text
        currentSettings.SMTPPassword = txtSMTPPassword.Text
        currentSettings.FromEmail = txtFromEmail.Text
        currentSettings.ToEmail = txtToEmail.Text

        ' Guardar configuraciones en el archivo
        currentSettings.SaveSettingsToFile(ConfigFilePath)

        MessageBox.Show("Configuraciones guardadas exitosamente!")
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim currentSettings As Configurations.Settings = Configurations.Settings.LoadSettingsFromFile(ConfigFilePath)
        txtSMTPServer.Text = currentSettings.SMTPServer
        txtSMTPPort.Text = currentSettings.SMTPPort.ToString()
        chkUseSSL.Checked = currentSettings.UseSSL
        txtSMTPUser.Text = currentSettings.SMTPUser
        txtSMTPPassword.Text = currentSettings.SMTPPassword
        txtFromEmail.Text = currentSettings.FromEmail
        txtToEmail.Text = currentSettings.ToEmail

    End Sub
End Class