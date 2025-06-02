<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        TxtUsername = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TxtPassword = New TextBox()
        PictureBox2 = New PictureBox()
        BTNLogin = New Button()
        Label4 = New Label()
        Label5 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        LabelJumlahMahasiswa = New Label()
        LabelJumlahProdi = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.LogoMulawarman
        PictureBox1.Location = New Point(316, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(276, 273)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI Black", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(393, 288)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 61)
        Label1.TabIndex = 1
        Label1.Text = "LOGIN"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TxtUsername
        ' 
        TxtUsername.Location = New Point(384, 362)
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(195, 27)
        TxtUsername.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(271, 368)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 3
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(271, 414)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 4
        Label3.Text = "Password"
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Location = New Point(384, 411)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.Size = New Size(195, 27)
        TxtPassword.TabIndex = 5
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.SembunyiPassword
        PictureBox2.Location = New Point(548, 414)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(31, 24)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' BTNLogin
        ' 
        BTNLogin.Location = New Point(415, 457)
        BTNLogin.Name = "BTNLogin"
        BTNLogin.Size = New Size(94, 29)
        BTNLogin.TabIndex = 7
        BTNLogin.Text = "Login"
        BTNLogin.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Segoe UI Black", 16.2F, FontStyle.Bold)
        Label4.Location = New Point(3, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(457, 111)
        Label4.TabIndex = 8
        Label4.Text = "Jumlah Mahasiswa Lulus"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Dock = DockStyle.Fill
        Label5.Font = New Font("Segoe UI Black", 16.2F, FontStyle.Bold)
        Label5.Location = New Point(466, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(458, 111)
        Label5.TabIndex = 9
        Label5.Text = "Jumlah Prodi"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(LabelJumlahMahasiswa, 0, 1)
        TableLayoutPanel1.Controls.Add(LabelJumlahProdi, 1, 1)
        TableLayoutPanel1.Controls.Add(Label4, 0, 0)
        TableLayoutPanel1.Controls.Add(Label5, 1, 0)
        TableLayoutPanel1.Location = New Point(1, 486)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 61.53846F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 38.46154F))
        TableLayoutPanel1.Size = New Size(927, 181)
        TableLayoutPanel1.TabIndex = 11
        ' 
        ' LabelJumlahMahasiswa
        ' 
        LabelJumlahMahasiswa.AutoSize = True
        LabelJumlahMahasiswa.Dock = DockStyle.Fill
        LabelJumlahMahasiswa.Font = New Font("Segoe UI Semibold", 22F, FontStyle.Bold)
        LabelJumlahMahasiswa.Location = New Point(3, 111)
        LabelJumlahMahasiswa.Name = "LabelJumlahMahasiswa"
        LabelJumlahMahasiswa.Size = New Size(457, 70)
        LabelJumlahMahasiswa.TabIndex = 12
        LabelJumlahMahasiswa.Text = "[Data]"
        LabelJumlahMahasiswa.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelJumlahProdi
        ' 
        LabelJumlahProdi.AutoSize = True
        LabelJumlahProdi.Dock = DockStyle.Fill
        LabelJumlahProdi.Font = New Font("Segoe UI Semibold", 22F, FontStyle.Bold)
        LabelJumlahProdi.Location = New Point(466, 111)
        LabelJumlahProdi.Name = "LabelJumlahProdi"
        LabelJumlahProdi.Size = New Size(458, 70)
        LabelJumlahProdi.TabIndex = 13
        LabelJumlahProdi.Text = "[Data]"
        LabelJumlahProdi.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(928, 673)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(BTNLogin)
        Controls.Add(PictureBox2)
        Controls.Add(TxtPassword)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TxtUsername)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BTNLogin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelJumlahMahasiswa As Label
    Friend WithEvents LabelJumlahProdi As Label
End Class
