<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ijasa
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
        DataGridView1 = New DataGridView()
        Panel1 = New Panel()
        CetanBTN = New Button()
        PictureBox1 = New PictureBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        LabelIPK = New Label()
        LabelPredikat = New Label()
        LabelStudi = New Label()
        LabelKelamin = New Label()
        LabelNama = New Label()
        LabelNIM = New Label()
        Label1 = New Label()
        Label6 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(0, 327)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(948, 389)
        DataGridView1.TabIndex = 18
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.AppWorkspace
        Panel1.Controls.Add(CetanBTN)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Location = New Point(0, -3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(948, 328)
        Panel1.TabIndex = 17
        ' 
        ' CetanBTN
        ' 
        CetanBTN.Location = New Point(631, 255)
        CetanBTN.Name = "CetanBTN"
        CetanBTN.Size = New Size(183, 55)
        CetanBTN.TabIndex = 8
        CetanBTN.Text = "Cetak"
        CetanBTN.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.person_dummy
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(603, 15)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(229, 221)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(LabelIPK, 1, 5)
        TableLayoutPanel1.Controls.Add(LabelPredikat, 1, 4)
        TableLayoutPanel1.Controls.Add(LabelStudi, 1, 3)
        TableLayoutPanel1.Controls.Add(LabelKelamin, 1, 2)
        TableLayoutPanel1.Controls.Add(LabelNama, 1, 1)
        TableLayoutPanel1.Controls.Add(LabelNIM, 1, 0)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(Label6, 0, 5)
        TableLayoutPanel1.Controls.Add(Label2, 0, 1)
        TableLayoutPanel1.Controls.Add(Label5, 0, 4)
        TableLayoutPanel1.Controls.Add(Label3, 0, 2)
        TableLayoutPanel1.Controls.Add(Label4, 0, 3)
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 6
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(505, 325)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' LabelIPK
        ' 
        LabelIPK.AutoSize = True
        LabelIPK.Dock = DockStyle.Fill
        LabelIPK.Font = New Font("Segoe UI", 12F)
        LabelIPK.Location = New Point(255, 270)
        LabelIPK.Name = "LabelIPK"
        LabelIPK.Size = New Size(247, 55)
        LabelIPK.TabIndex = 11
        LabelIPK.Text = "IPK"
        LabelIPK.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelPredikat
        ' 
        LabelPredikat.AutoSize = True
        LabelPredikat.Dock = DockStyle.Fill
        LabelPredikat.Font = New Font("Segoe UI", 12F)
        LabelPredikat.Location = New Point(255, 216)
        LabelPredikat.Name = "LabelPredikat"
        LabelPredikat.Size = New Size(247, 54)
        LabelPredikat.TabIndex = 10
        LabelPredikat.Text = "Predikat"
        LabelPredikat.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelStudi
        ' 
        LabelStudi.AutoSize = True
        LabelStudi.Dock = DockStyle.Fill
        LabelStudi.Font = New Font("Segoe UI", 12F)
        LabelStudi.Location = New Point(255, 162)
        LabelStudi.Name = "LabelStudi"
        LabelStudi.Size = New Size(247, 54)
        LabelStudi.TabIndex = 9
        LabelStudi.Text = "Program Studi"
        LabelStudi.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelKelamin
        ' 
        LabelKelamin.AutoSize = True
        LabelKelamin.Dock = DockStyle.Fill
        LabelKelamin.Font = New Font("Segoe UI", 12F)
        LabelKelamin.Location = New Point(255, 108)
        LabelKelamin.Name = "LabelKelamin"
        LabelKelamin.Size = New Size(247, 54)
        LabelKelamin.TabIndex = 8
        LabelKelamin.Text = "Jenis Kelamin"
        LabelKelamin.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelNama
        ' 
        LabelNama.AutoSize = True
        LabelNama.Dock = DockStyle.Fill
        LabelNama.Font = New Font("Segoe UI", 12F)
        LabelNama.Location = New Point(255, 54)
        LabelNama.Name = "LabelNama"
        LabelNama.Size = New Size(247, 54)
        LabelNama.TabIndex = 7
        LabelNama.Text = "Nama Lengkap"
        LabelNama.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelNIM
        ' 
        LabelNIM.AutoSize = True
        LabelNIM.Dock = DockStyle.Fill
        LabelNIM.Font = New Font("Segoe UI", 12F)
        LabelNIM.Location = New Point(255, 0)
        LabelNIM.Name = "LabelNIM"
        LabelNIM.Size = New Size(247, 54)
        LabelNIM.TabIndex = 6
        LabelNIM.Text = "NIM"
        LabelNIM.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(246, 54)
        Label1.TabIndex = 0
        Label1.Text = "NIM"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Dock = DockStyle.Fill
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(3, 270)
        Label6.Name = "Label6"
        Label6.Size = New Size(246, 55)
        Label6.TabIndex = 5
        Label6.Text = "IPK"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(3, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(246, 54)
        Label2.TabIndex = 1
        Label2.Text = "Nama Lengkap"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Dock = DockStyle.Fill
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(3, 216)
        Label5.Name = "Label5"
        Label5.Size = New Size(246, 54)
        Label5.TabIndex = 4
        Label5.Text = "Predikat"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(3, 108)
        Label3.Name = "Label3"
        Label3.Size = New Size(246, 54)
        Label3.TabIndex = 2
        Label3.Text = "Jenis Kelamin"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(3, 162)
        Label4.Name = "Label4"
        Label4.Size = New Size(246, 54)
        Label4.TabIndex = 3
        Label4.Text = "Program Studi"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Ijasa
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(946, 720)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Ijasa"
        Text = "Ijasa"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CetanBTN As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelIPK As Label
    Friend WithEvents LabelPredikat As Label
    Friend WithEvents LabelStudi As Label
    Friend WithEvents LabelKelamin As Label
    Friend WithEvents LabelNama As Label
    Friend WithEvents LabelNIM As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
