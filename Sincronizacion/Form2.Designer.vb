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
        components = New ComponentModel.Container()
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
        Label1 = New Label()
        ProgressBar3 = New ProgressBar()
        btnMigrateContent3 = New Button()
        btnSaveSettings3 = New Button()
        cmbDocumentLibraries3 = New ComboBox()
        txtSelectedFolder3 = New TextBox()
        btnLoadFile3 = New Button()
        Label2 = New Label()
        ProgressBar4 = New ProgressBar()
        btnMigrateContent4 = New Button()
        btnSaveSettings4 = New Button()
        cmbDocumentLibraries4 = New ComboBox()
        txtSelectedFolder4 = New TextBox()
        btnLoadFile4 = New Button()
        FolderBrowserDialog3 = New FolderBrowserDialog()
        FolderBrowserDialog4 = New FolderBrowserDialog()
        lblstatus3 = New Label()
        lblstatus4 = New Label()
        DateTimePicker1 = New DateTimePicker()
        CheckBox1 = New CheckBox()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        Timer3 = New Timer(components)
        Timer4 = New Timer(components)
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker3 = New DateTimePicker()
        DateTimePicker4 = New DateTimePicker()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(457, 279)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 22
        ' 
        ' ProgressBar3
        ' 
        ProgressBar3.Location = New Point(28, 262)
        ProgressBar3.Name = "ProgressBar3"
        ProgressBar3.Size = New Size(318, 23)
        ProgressBar3.TabIndex = 21
        ' 
        ' btnMigrateContent3
        ' 
        btnMigrateContent3.Location = New Point(352, 262)
        btnMigrateContent3.Name = "btnMigrateContent3"
        btnMigrateContent3.Size = New Size(87, 23)
        btnMigrateContent3.TabIndex = 20
        btnMigrateContent3.Text = "Respaldar"
        btnMigrateContent3.UseVisualStyleBackColor = True
        ' 
        ' btnSaveSettings3
        ' 
        btnSaveSettings3.Location = New Point(457, 233)
        btnSaveSettings3.Name = "btnSaveSettings3"
        btnSaveSettings3.Size = New Size(100, 23)
        btnSaveSettings3.TabIndex = 19
        btnSaveSettings3.Text = "Save"
        btnSaveSettings3.UseVisualStyleBackColor = True
        ' 
        ' cmbDocumentLibraries3
        ' 
        cmbDocumentLibraries3.FormattingEnabled = True
        cmbDocumentLibraries3.Location = New Point(352, 233)
        cmbDocumentLibraries3.Name = "cmbDocumentLibraries3"
        cmbDocumentLibraries3.Size = New Size(87, 23)
        cmbDocumentLibraries3.TabIndex = 18
        ' 
        ' txtSelectedFolder3
        ' 
        txtSelectedFolder3.Location = New Point(109, 233)
        txtSelectedFolder3.Name = "txtSelectedFolder3"
        txtSelectedFolder3.Size = New Size(229, 23)
        txtSelectedFolder3.TabIndex = 17
        ' 
        ' btnLoadFile3
        ' 
        btnLoadFile3.Location = New Point(28, 233)
        btnLoadFile3.Name = "btnLoadFile3"
        btnLoadFile3.Size = New Size(75, 23)
        btnLoadFile3.TabIndex = 16
        btnLoadFile3.Text = "Carpeta"
        btnLoadFile3.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(457, 351)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 29
        ' 
        ' ProgressBar4
        ' 
        ProgressBar4.Location = New Point(28, 343)
        ProgressBar4.Name = "ProgressBar4"
        ProgressBar4.Size = New Size(318, 23)
        ProgressBar4.TabIndex = 28
        ' 
        ' btnMigrateContent4
        ' 
        btnMigrateContent4.Location = New Point(352, 343)
        btnMigrateContent4.Name = "btnMigrateContent4"
        btnMigrateContent4.Size = New Size(87, 23)
        btnMigrateContent4.TabIndex = 27
        btnMigrateContent4.Text = "Respaldar"
        btnMigrateContent4.UseVisualStyleBackColor = True
        ' 
        ' btnSaveSettings4
        ' 
        btnSaveSettings4.Location = New Point(457, 314)
        btnSaveSettings4.Name = "btnSaveSettings4"
        btnSaveSettings4.Size = New Size(100, 23)
        btnSaveSettings4.TabIndex = 26
        btnSaveSettings4.Text = "Save"
        btnSaveSettings4.UseVisualStyleBackColor = True
        ' 
        ' cmbDocumentLibraries4
        ' 
        cmbDocumentLibraries4.FormattingEnabled = True
        cmbDocumentLibraries4.Location = New Point(352, 314)
        cmbDocumentLibraries4.Name = "cmbDocumentLibraries4"
        cmbDocumentLibraries4.Size = New Size(87, 23)
        cmbDocumentLibraries4.TabIndex = 25
        ' 
        ' txtSelectedFolder4
        ' 
        txtSelectedFolder4.Location = New Point(109, 314)
        txtSelectedFolder4.Name = "txtSelectedFolder4"
        txtSelectedFolder4.Size = New Size(229, 23)
        txtSelectedFolder4.TabIndex = 24
        ' 
        ' btnLoadFile4
        ' 
        btnLoadFile4.Location = New Point(28, 314)
        btnLoadFile4.Name = "btnLoadFile4"
        btnLoadFile4.Size = New Size(75, 23)
        btnLoadFile4.TabIndex = 23
        btnLoadFile4.Text = "Carpeta"
        btnLoadFile4.UseVisualStyleBackColor = True
        ' 
        ' lblstatus3
        ' 
        lblstatus3.AutoSize = True
        lblstatus3.Location = New Point(457, 270)
        lblstatus3.Name = "lblstatus3"
        lblstatus3.Size = New Size(0, 15)
        lblstatus3.TabIndex = 30
        ' 
        ' lblstatus4
        ' 
        lblstatus4.AutoSize = True
        lblstatus4.Location = New Point(457, 351)
        lblstatus4.Name = "lblstatus4"
        lblstatus4.Size = New Size(0, 15)
        lblstatus4.TabIndex = 31
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Time
        DateTimePicker1.Location = New Point(563, 75)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(80, 23)
        DateTimePicker1.TabIndex = 32
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(649, 78)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(82, 19)
        CheckBox1.TabIndex = 33
        CheckBox1.Text = "Programar"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' Timer2
        ' 
        ' 
        ' Timer3
        ' 
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Format = DateTimePickerFormat.Time
        DateTimePicker2.Location = New Point(563, 152)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(80, 23)
        DateTimePicker2.TabIndex = 34
        ' 
        ' DateTimePicker3
        ' 
        DateTimePicker3.Format = DateTimePickerFormat.Time
        DateTimePicker3.Location = New Point(563, 233)
        DateTimePicker3.Name = "DateTimePicker3"
        DateTimePicker3.Size = New Size(80, 23)
        DateTimePicker3.TabIndex = 35
        ' 
        ' DateTimePicker4
        ' 
        DateTimePicker4.Format = DateTimePickerFormat.Time
        DateTimePicker4.Location = New Point(563, 314)
        DateTimePicker4.Name = "DateTimePicker4"
        DateTimePicker4.Size = New Size(80, 23)
        DateTimePicker4.TabIndex = 36
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(649, 152)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(82, 19)
        CheckBox2.TabIndex = 37
        CheckBox2.Text = "Programar"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(649, 235)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(82, 19)
        CheckBox3.TabIndex = 38
        CheckBox3.Text = "Programar"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(649, 317)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(82, 19)
        CheckBox4.TabIndex = 39
        CheckBox4.Text = "Programar"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(744, 395)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(DateTimePicker4)
        Controls.Add(DateTimePicker3)
        Controls.Add(DateTimePicker2)
        Controls.Add(CheckBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(lblstatus4)
        Controls.Add(lblstatus3)
        Controls.Add(Label2)
        Controls.Add(ProgressBar4)
        Controls.Add(btnMigrateContent4)
        Controls.Add(btnSaveSettings4)
        Controls.Add(cmbDocumentLibraries4)
        Controls.Add(txtSelectedFolder4)
        Controls.Add(btnLoadFile4)
        Controls.Add(Label1)
        Controls.Add(ProgressBar3)
        Controls.Add(btnMigrateContent3)
        Controls.Add(btnSaveSettings3)
        Controls.Add(cmbDocumentLibraries3)
        Controls.Add(txtSelectedFolder3)
        Controls.Add(btnLoadFile3)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar3 As ProgressBar
    Friend WithEvents btnMigrateContent3 As Button
    Friend WithEvents btnSaveSettings3 As Button
    Friend WithEvents cmbDocumentLibraries3 As ComboBox
    Friend WithEvents txtSelectedFolder3 As TextBox
    Friend WithEvents btnLoadFile3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar4 As ProgressBar
    Friend WithEvents btnMigrateContent4 As Button
    Friend WithEvents btnSaveSettings4 As Button
    Friend WithEvents cmbDocumentLibraries4 As ComboBox
    Friend WithEvents txtSelectedFolder4 As TextBox
    Friend WithEvents btnLoadFile4 As Button
    Friend WithEvents FolderBrowserDialog3 As FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog4 As FolderBrowserDialog
    Friend WithEvents lblstatus3 As Label
    Friend WithEvents lblstatus4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
End Class
