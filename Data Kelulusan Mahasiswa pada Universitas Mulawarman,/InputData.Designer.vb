<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputData
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
        Label4 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        StudiBox = New ComboBox()
        KelaminBox = New ComboBox()
        PredikatBox = New ComboBox()
        TxtNama = New TextBox()
        TxtNIM = New TextBox()
        TxtIPK = New TextBox()
        Panel1 = New Panel()
        TableLayoutPanel3 = New TableLayoutPanel()
        MasukanBTN = New Button()
        HapusBTN = New Button()
        UbahBTN = New Button()
        SimpanBTN = New Button()
        PictureBox1 = New PictureBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        DataGridView1 = New DataGridView()
        SimpanGambar = New OpenFileDialog()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(3, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(210, 57)
        Label4.TabIndex = 0
        Label4.Text = "NIM"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(3, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(210, 57)
        Label1.TabIndex = 1
        Label1.Text = "Nama Lengkap"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(3, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(210, 57)
        Label2.TabIndex = 2
        Label2.Text = "Jenis Kelamin"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(3, 171)
        Label3.Name = "Label3"
        Label3.Size = New Size(210, 57)
        Label3.TabIndex = 3
        Label3.Text = "Program Studi"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Dock = DockStyle.Fill
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(3, 228)
        Label5.Name = "Label5"
        Label5.Size = New Size(210, 57)
        Label5.TabIndex = 4
        Label5.Text = "Predikat"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Dock = DockStyle.Fill
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(3, 285)
        Label6.Name = "Label6"
        Label6.Size = New Size(210, 61)
        Label6.TabIndex = 5
        Label6.Text = "IPK"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 38.46154F))
        TableLayoutPanel1.Controls.Add(Label1, 0, 1)
        TableLayoutPanel1.Controls.Add(Label6, 0, 5)
        TableLayoutPanel1.Controls.Add(Label3, 0, 3)
        TableLayoutPanel1.Controls.Add(Label5, 0, 4)
        TableLayoutPanel1.Controls.Add(Label4, 0, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 2)
        TableLayoutPanel1.Location = New Point(9, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 6
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.66667F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel1.Size = New Size(216, 346)
        TableLayoutPanel1.TabIndex = 6
        ' 
        ' StudiBox
        ' 
        StudiBox.Dock = DockStyle.Fill
        StudiBox.FormattingEnabled = True
        StudiBox.Items.AddRange(New Object() {"Informatika", "Sistem Informasi", "Teknik Sipil"})
        StudiBox.Location = New Point(3, 193)
        StudiBox.Name = "StudiBox"
        StudiBox.Size = New Size(276, 28)
        StudiBox.TabIndex = 11
        ' 
        ' KelaminBox
        ' 
        KelaminBox.Dock = DockStyle.Fill
        KelaminBox.FormattingEnabled = True
        KelaminBox.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        KelaminBox.Location = New Point(3, 136)
        KelaminBox.Name = "KelaminBox"
        KelaminBox.Size = New Size(276, 28)
        KelaminBox.TabIndex = 10
        ' 
        ' PredikatBox
        ' 
        PredikatBox.Dock = DockStyle.Fill
        PredikatBox.Enabled = False
        PredikatBox.FormattingEnabled = True
        PredikatBox.Items.AddRange(New Object() {"Memuaskan", "Sangat Memuaskan", "Cum Laude", "Magna Cum Laude", "Summa Cum Laude"})
        PredikatBox.Location = New Point(3, 250)
        PredikatBox.Name = "PredikatBox"
        PredikatBox.Size = New Size(276, 28)
        PredikatBox.TabIndex = 12
        ' 
        ' TxtNama
        ' 
        TxtNama.Dock = DockStyle.Fill
        TxtNama.Location = New Point(3, 79)
        TxtNama.MaxLength = 50
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(276, 27)
        TxtNama.TabIndex = 8
        ' 
        ' TxtNIM
        ' 
        TxtNIM.Dock = DockStyle.Fill
        TxtNIM.Location = New Point(3, 22)
        TxtNIM.Name = "TxtNIM"
        TxtNIM.Size = New Size(276, 27)
        TxtNIM.TabIndex = 6
        ' 
        ' TxtIPK
        ' 
        TxtIPK.Dock = DockStyle.Fill
        TxtIPK.Location = New Point(3, 307)
        TxtIPK.MaxLength = 4
        TxtIPK.Name = "TxtIPK"
        TxtIPK.Size = New Size(276, 27)
        TxtIPK.TabIndex = 9
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.AppWorkspace
        Panel1.Controls.Add(TableLayoutPanel3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(TableLayoutPanel2)
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Location = New Point(3, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(943, 426)
        Panel1.TabIndex = 7
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 4
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.Controls.Add(MasukanBTN, 3, 0)
        TableLayoutPanel3.Controls.Add(HapusBTN, 2, 0)
        TableLayoutPanel3.Controls.Add(UbahBTN, 1, 0)
        TableLayoutPanel3.Controls.Add(SimpanBTN, 0, 0)
        TableLayoutPanel3.Location = New Point(12, 369)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(919, 54)
        TableLayoutPanel3.TabIndex = 14
        ' 
        ' MasukanBTN
        ' 
        MasukanBTN.Dock = DockStyle.Fill
        MasukanBTN.Location = New Point(690, 3)
        MasukanBTN.Name = "MasukanBTN"
        MasukanBTN.Size = New Size(226, 48)
        MasukanBTN.TabIndex = 3
        MasukanBTN.Text = "Masukan Gambar"
        MasukanBTN.UseVisualStyleBackColor = True
        ' 
        ' HapusBTN
        ' 
        HapusBTN.Dock = DockStyle.Fill
        HapusBTN.Location = New Point(461, 3)
        HapusBTN.Name = "HapusBTN"
        HapusBTN.Size = New Size(223, 48)
        HapusBTN.TabIndex = 2
        HapusBTN.Text = "Hapus"
        HapusBTN.UseVisualStyleBackColor = True
        ' 
        ' UbahBTN
        ' 
        UbahBTN.Dock = DockStyle.Fill
        UbahBTN.Location = New Point(232, 3)
        UbahBTN.Name = "UbahBTN"
        UbahBTN.Size = New Size(223, 48)
        UbahBTN.TabIndex = 1
        UbahBTN.Text = "Ubah"
        UbahBTN.UseVisualStyleBackColor = True
        ' 
        ' SimpanBTN
        ' 
        SimpanBTN.Dock = DockStyle.Fill
        SimpanBTN.Location = New Point(3, 3)
        SimpanBTN.Name = "SimpanBTN"
        SimpanBTN.Size = New Size(223, 48)
        SimpanBTN.TabIndex = 0
        SimpanBTN.Text = "Simpan"
        SimpanBTN.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.person_dummy
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.ErrorImage = Nothing
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(639, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(278, 279)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(TxtNama, 0, 4)
        TableLayoutPanel2.Controls.Add(PredikatBox, 0, 13)
        TableLayoutPanel2.Controls.Add(KelaminBox, 0, 7)
        TableLayoutPanel2.Controls.Add(StudiBox, 0, 10)
        TableLayoutPanel2.Controls.Add(TxtIPK, 0, 16)
        TableLayoutPanel2.Controls.Add(TxtNIM, 0, 1)
        TableLayoutPanel2.Location = New Point(231, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 18
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 5.55555534F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 5.55555534F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 5.55555534F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 5.55555534F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 5.55555534F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 5.55555534F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 5.55555534F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 5.55555534F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 5.55555534F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 5.55555534F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 5.55555534F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 5.55555534F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 5.55555534F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 5.55555534F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 5.55555534F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 5.55555534F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 5.55555534F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 5.55555534F))
        TableLayoutPanel2.Size = New Size(282, 346)
        TableLayoutPanel2.TabIndex = 13
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(3, 433)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(943, 287)
        DataGridView1.TabIndex = 15
        ' 
        ' SimpanGambar
        ' 
        SimpanGambar.FileName = "OpenFileDialog1"
        ' 
        ' InputData
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(946, 720)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "InputData"
        Text = "Form2"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        Panel1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents StudiBox As ComboBox
    Friend WithEvents PredikatBox As ComboBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtIPK As TextBox
    Friend WithEvents TxtNIM As TextBox
    Friend WithEvents KelaminBox As ComboBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents MasukanBTN As Button
    Friend WithEvents HapusBTN As Button
    Friend WithEvents UbahBTN As Button
    Friend WithEvents SimpanBTN As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SimpanGambar As OpenFileDialog
End Class
