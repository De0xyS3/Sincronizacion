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
        ProgressBar2 = New ProgressBar()
        btnMigrateContent2 = New Button()
        btnSaveSettings2 = New Button()
        cmbDocumentLibraries2 = New ComboBox()
        txtSelectedFolder2 = New TextBox()
        btnLoadFile2 = New Button()
        FolderBrowserDialog2 = New FolderBrowserDialog()
        lblstatus1 = New Label()
        lblstatus2 = New Label()
        Button1 = New Button()
        GroupBox1 = New GroupBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnLoadFile1
        ' 
        btnLoadFile1.Location = New Point(28, 75)
        btnLoadFile1.Name = "btnLoadFile1"
        btnLoadFile1.Size = New Size(75, 23)
        btnLoadFile1.TabIndex = 0
        btnLoadFile1.Text = "Carpeta"
        btnLoadFile1.UseVisualStyleBackColor = True
        ' 
        ' txtSelectedFolder
        ' 
        txtSelectedFolder.Location = New Point(109, 75)
        txtSelectedFolder.Name = "txtSelectedFolder"
        txtSelectedFolder.Size = New Size(229, 23)
        txtSelectedFolder.TabIndex = 1
        ' 
        ' cmbDocumentLibraries
        ' 
        cmbDocumentLibraries.FormattingEnabled = True
        cmbDocumentLibraries.Location = New Point(352, 75)
        cmbDocumentLibraries.Name = "cmbDocumentLibraries"
        cmbDocumentLibraries.Size = New Size(87, 23)
        cmbDocumentLibraries.TabIndex = 2
        ' 
        ' btnSaveSettings
        ' 
        btnSaveSettings.Location = New Point(457, 75)
        btnSaveSettings.Name = "btnSaveSettings"
        btnSaveSettings.Size = New Size(100, 23)
        btnSaveSettings.TabIndex = 3
        btnSaveSettings.Text = "Save"
        btnSaveSettings.UseVisualStyleBackColor = True
        ' 
        ' btnMigrateContent
        ' 
        btnMigrateContent.Location = New Point(352, 104)
        btnMigrateContent.Name = "btnMigrateContent"
        btnMigrateContent.Size = New Size(87, 23)
        btnMigrateContent.TabIndex = 4
        btnMigrateContent.Text = "Respaldar"
        btnMigrateContent.UseVisualStyleBackColor = True
        ' 
        ' ProgressBar
        ' 
        ProgressBar.Location = New Point(28, 104)
        ProgressBar.Name = "ProgressBar"
        ProgressBar.Size = New Size(318, 23)
        ProgressBar.TabIndex = 5
        ' 
        ' ProgressBar2
        ' 
        ProgressBar2.Location = New Point(28, 183)
        ProgressBar2.Name = "ProgressBar2"
        ProgressBar2.Size = New Size(318, 23)
        ProgressBar2.TabIndex = 11
        ' 
        ' btnMigrateContent2
        ' 
        btnMigrateContent2.Location = New Point(352, 183)
        btnMigrateContent2.Name = "btnMigrateContent2"
        btnMigrateContent2.Size = New Size(87, 23)
        btnMigrateContent2.TabIndex = 10
        btnMigrateContent2.Text = "Respaldar"
        btnMigrateContent2.UseVisualStyleBackColor = True
        ' 
        ' btnSaveSettings2
        ' 
        btnSaveSettings2.Location = New Point(457, 154)
        btnSaveSettings2.Name = "btnSaveSettings2"
        btnSaveSettings2.Size = New Size(100, 23)
        btnSaveSettings2.TabIndex = 9
        btnSaveSettings2.Text = "Save"
        btnSaveSettings2.UseVisualStyleBackColor = True
        ' 
        ' cmbDocumentLibraries2
        ' 
        cmbDocumentLibraries2.FormattingEnabled = True
        cmbDocumentLibraries2.Location = New Point(352, 154)
        cmbDocumentLibraries2.Name = "cmbDocumentLibraries2"
        cmbDocumentLibraries2.Size = New Size(87, 23)
        cmbDocumentLibraries2.TabIndex = 8
        ' 
        ' txtSelectedFolder2
        ' 
        txtSelectedFolder2.Location = New Point(109, 154)
        txtSelectedFolder2.Name = "txtSelectedFolder2"
        txtSelectedFolder2.Size = New Size(229, 23)
        txtSelectedFolder2.TabIndex = 7
        ' 
        ' btnLoadFile2
        ' 
        btnLoadFile2.Location = New Point(28, 154)
        btnLoadFile2.Name = "btnLoadFile2"
        btnLoadFile2.Size = New Size(75, 23)
        btnLoadFile2.TabIndex = 6
        btnLoadFile2.Text = "Carpeta"
        btnLoadFile2.UseVisualStyleBackColor = True
        ' 
        ' lblstatus1
        ' 
        lblstatus1.AutoSize = True
        lblstatus1.Location = New Point(457, 108)
        lblstatus1.Name = "lblstatus1"
        lblstatus1.Size = New Size(0, 15)
        lblstatus1.TabIndex = 12
        ' 
        ' lblstatus2
        ' 
        lblstatus2.AutoSize = True
        lblstatus2.Location = New Point(457, 191)
        lblstatus2.Name = "lblstatus2"
        lblstatus2.Size = New Size(0, 15)
        lblstatus2.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(34, 22)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 14
        Button1.Text = "Email"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Location = New Point(28, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(529, 54)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tools"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 247)
        Controls.Add(GroupBox1)
        Controls.Add(lblstatus2)
        Controls.Add(lblstatus1)
        Controls.Add(ProgressBar2)
        Controls.Add(btnMigrateContent2)
        Controls.Add(btnSaveSettings2)
        Controls.Add(cmbDocumentLibraries2)
        Controls.Add(txtSelectedFolder2)
        Controls.Add(btnLoadFile2)
        Controls.Add(ProgressBar)
        Controls.Add(btnMigrateContent)
        Controls.Add(btnSaveSettings)
        Controls.Add(cmbDocumentLibraries)
        Controls.Add(txtSelectedFolder)
        Controls.Add(btnLoadFile1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "Form2"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sync Sharepoint"
        GroupBox1.ResumeLayout(False)
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
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents btnMigrateContent2 As Button
    Friend WithEvents btnSaveSettings2 As Button
    Friend WithEvents cmbDocumentLibraries2 As ComboBox
    Friend WithEvents txtSelectedFolder2 As TextBox
    Friend WithEvents btnLoadFile2 As Button
    Friend WithEvents FolderBrowserDialog2 As FolderBrowserDialog
    Friend WithEvents lblstatus1 As Label
    Friend WithEvents lblstatus2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
