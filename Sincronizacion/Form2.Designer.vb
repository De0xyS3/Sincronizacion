<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        btnLoadFile1 = New Button()
        txtSelectedFolder = New TextBox()
        cmbDocumentLibraries = New ComboBox()
        btnSaveSettings = New Button()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        btnMigrateContent = New Button()
        ProgressBar = New ProgressBar()
        SuspendLayout()
        ' 
        ' btnLoadFile1
        ' 
        btnLoadFile1.Location = New Point(29, 23)
        btnLoadFile1.Name = "btnLoadFile1"
        btnLoadFile1.Size = New Size(75, 23)
        btnLoadFile1.TabIndex = 0
        btnLoadFile1.Text = "Carpeta"
        btnLoadFile1.UseVisualStyleBackColor = True
        ' 
        ' txtSelectedFolder
        ' 
        txtSelectedFolder.Location = New Point(110, 23)
        txtSelectedFolder.Name = "txtSelectedFolder"
        txtSelectedFolder.Size = New Size(229, 23)
        txtSelectedFolder.TabIndex = 1
        ' 
        ' cmbDocumentLibraries
        ' 
        cmbDocumentLibraries.FormattingEnabled = True
        cmbDocumentLibraries.Location = New Point(353, 23)
        cmbDocumentLibraries.Name = "cmbDocumentLibraries"
        cmbDocumentLibraries.Size = New Size(87, 23)
        cmbDocumentLibraries.TabIndex = 2
        ' 
        ' btnSaveSettings
        ' 
        btnSaveSettings.Location = New Point(458, 23)
        btnSaveSettings.Name = "btnSaveSettings"
        btnSaveSettings.Size = New Size(100, 23)
        btnSaveSettings.TabIndex = 3
        btnSaveSettings.Text = "Save"
        btnSaveSettings.UseVisualStyleBackColor = True
        ' 
        ' btnMigrateContent
        ' 
        btnMigrateContent.Location = New Point(353, 52)
        btnMigrateContent.Name = "btnMigrateContent"
        btnMigrateContent.Size = New Size(87, 23)
        btnMigrateContent.TabIndex = 4
        btnMigrateContent.Text = "Respaldar"
        btnMigrateContent.UseVisualStyleBackColor = True
        ' 
        ' ProgressBar
        ' 
        ProgressBar.Location = New Point(29, 52)
        ProgressBar.Name = "ProgressBar"
        ProgressBar.Size = New Size(318, 23)
        ProgressBar.TabIndex = 5
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 190)
        Controls.Add(ProgressBar)
        Controls.Add(btnMigrateContent)
        Controls.Add(btnSaveSettings)
        Controls.Add(cmbDocumentLibraries)
        Controls.Add(txtSelectedFolder)
        Controls.Add(btnLoadFile1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLoadFile1 As Button
    Friend WithEvents txtSelectedFolder As TextBox
    Friend WithEvents cmbDocumentLibraries As ComboBox
    Friend WithEvents btnSaveSettings As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents btnMigrateContent As Button
    Friend WithEvents ProgressBar As ProgressBar
End Class
