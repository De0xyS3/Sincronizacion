<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnConnect = New Button()
        btnSave = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtSharePointUsername = New TextBox()
        txtSharePointPassword = New TextBox()
        txtSharePointSite = New TextBox()
        SuspendLayout()
        ' 
        ' btnConnect
        ' 
        btnConnect.Location = New Point(11, 96)
        btnConnect.Name = "btnConnect"
        btnConnect.Size = New Size(75, 23)
        btnConnect.TabIndex = 0
        btnConnect.Text = "Conectar"
        btnConnect.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(122, 96)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 1
        btnSave.Text = "Guardar"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 2
        Label1.Text = "Usuario"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(11, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 3
        Label2.Text = "Contraseña"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(30, 15)
        Label3.TabIndex = 4
        Label3.Text = "Sitio"
        ' 
        ' txtSharePointUsername
        ' 
        txtSharePointUsername.Location = New Point(97, 9)
        txtSharePointUsername.Name = "txtSharePointUsername"
        txtSharePointUsername.Size = New Size(100, 23)
        txtSharePointUsername.TabIndex = 5
        ' 
        ' txtSharePointPassword
        ' 
        txtSharePointPassword.Location = New Point(97, 36)
        txtSharePointPassword.Name = "txtSharePointPassword"
        txtSharePointPassword.Size = New Size(100, 23)
        txtSharePointPassword.TabIndex = 7
        ' 
        ' txtSharePointSite
        ' 
        txtSharePointSite.Location = New Point(97, 66)
        txtSharePointSite.Name = "txtSharePointSite"
        txtSharePointSite.Size = New Size(100, 23)
        txtSharePointSite.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(211, 122)
        Controls.Add(txtSharePointPassword)
        Controls.Add(txtSharePointSite)
        Controls.Add(txtSharePointUsername)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSave)
        Controls.Add(btnConnect)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnConnect As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSharePointUsername As TextBox
    Friend WithEvents txtSharePointPassword As TextBox
    Friend WithEvents txtSharePointSite As TextBox
End Class
