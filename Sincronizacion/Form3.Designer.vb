<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtSMTPServer = New TextBox()
        txtSMTPUser = New TextBox()
        txtSMTPPort = New TextBox()
        txtSMTPPassword = New TextBox()
        txtFromEmail = New TextBox()
        txtToEmail = New TextBox()
        conectar = New Button()
        Guardar = New Button()
        chkUseSSL = New CheckBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 15)
        Label1.TabIndex = 0
        Label1.Text = "SMTP Server"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 15)
        Label2.TabIndex = 1
        Label2.Text = "SMTP Port"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(14, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 15)
        Label3.TabIndex = 2
        Label3.Text = "SMTP User"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(14, 129)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 15)
        Label4.TabIndex = 3
        Label4.Text = "SMTP Password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(14, 158)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 15)
        Label5.TabIndex = 4
        Label5.Text = "From Email Address"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(15, 187)
        Label6.Name = "Label6"
        Label6.Size = New Size(96, 15)
        Label6.TabIndex = 5
        Label6.Text = "To Email Address"
        ' 
        ' txtSMTPServer
        ' 
        txtSMTPServer.Location = New Point(132, 11)
        txtSMTPServer.Name = "txtSMTPServer"
        txtSMTPServer.Size = New Size(181, 23)
        txtSMTPServer.TabIndex = 6
        ' 
        ' txtSMTPUser
        ' 
        txtSMTPUser.Location = New Point(132, 92)
        txtSMTPUser.Name = "txtSMTPUser"
        txtSMTPUser.Size = New Size(181, 23)
        txtSMTPUser.TabIndex = 7
        ' 
        ' txtSMTPPort
        ' 
        txtSMTPPort.Location = New Point(132, 38)
        txtSMTPPort.Name = "txtSMTPPort"
        txtSMTPPort.Size = New Size(181, 23)
        txtSMTPPort.TabIndex = 8
        ' 
        ' txtSMTPPassword
        ' 
        txtSMTPPassword.Location = New Point(132, 121)
        txtSMTPPassword.Name = "txtSMTPPassword"
        txtSMTPPassword.Size = New Size(181, 23)
        txtSMTPPassword.TabIndex = 9
        ' 
        ' txtFromEmail
        ' 
        txtFromEmail.Location = New Point(132, 150)
        txtFromEmail.Name = "txtFromEmail"
        txtFromEmail.Size = New Size(181, 23)
        txtFromEmail.TabIndex = 10
        ' 
        ' txtToEmail
        ' 
        txtToEmail.Location = New Point(132, 179)
        txtToEmail.Name = "txtToEmail"
        txtToEmail.Size = New Size(181, 23)
        txtToEmail.TabIndex = 11
        ' 
        ' conectar
        ' 
        conectar.Location = New Point(73, 212)
        conectar.Name = "conectar"
        conectar.Size = New Size(134, 23)
        conectar.TabIndex = 12
        conectar.Text = "Test Connection"
        conectar.UseVisualStyleBackColor = True
        ' 
        ' Guardar
        ' 
        Guardar.Location = New Point(238, 212)
        Guardar.Name = "Guardar"
        Guardar.Size = New Size(75, 23)
        Guardar.TabIndex = 13
        Guardar.Text = "Save"
        Guardar.UseVisualStyleBackColor = True
        ' 
        ' chkUseSSL
        ' 
        chkUseSSL.AutoSize = True
        chkUseSSL.Location = New Point(132, 67)
        chkUseSSL.Name = "chkUseSSL"
        chkUseSSL.Size = New Size(66, 19)
        chkUseSSL.TabIndex = 14
        chkUseSSL.Text = "Use SSL"
        chkUseSSL.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(331, 243)
        Controls.Add(chkUseSSL)
        Controls.Add(Guardar)
        Controls.Add(conectar)
        Controls.Add(txtToEmail)
        Controls.Add(txtFromEmail)
        Controls.Add(txtSMTPPassword)
        Controls.Add(txtSMTPPort)
        Controls.Add(txtSMTPUser)
        Controls.Add(txtSMTPServer)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Email"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSMTPServer As TextBox
    Friend WithEvents txtSMTPUser As TextBox
    Friend WithEvents txtSMTPPort As TextBox
    Friend WithEvents txtSMTPPassword As TextBox
    Friend WithEvents txtFromEmail As TextBox
    Friend WithEvents txtToEmail As TextBox
    Friend WithEvents conectar As Button
    Friend WithEvents Guardar As Button
    Friend WithEvents chkUseSSL As CheckBox
End Class
