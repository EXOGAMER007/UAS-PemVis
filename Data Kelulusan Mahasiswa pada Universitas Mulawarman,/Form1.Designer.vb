<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        ExitBTN = New Button()
        IjasaBTN = New Button()
        KelulusanBTN = New Button()
        GrafikBTN = New Button()
        InsertBTN = New Button()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.AppWorkspace
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Location = New Point(1, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(383, 726)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F)
        Label1.Location = New Point(26, 140)
        Label1.Name = "Label1"
        Label1.Size = New Size(331, 74)
        Label1.TabIndex = 1
        Label1.Text = "Data Kelulusan Mahasiswa" & vbCrLf & "Mulawarman"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.LogoMulawarman
        PictureBox1.Location = New Point(111, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(152, 137)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(ExitBTN, 0, 6)
        TableLayoutPanel1.Controls.Add(IjasaBTN, 0, 3)
        TableLayoutPanel1.Controls.Add(KelulusanBTN, 0, 2)
        TableLayoutPanel1.Controls.Add(GrafikBTN, 0, 1)
        TableLayoutPanel1.Controls.Add(InsertBTN, 0, 0)
        TableLayoutPanel1.Location = New Point(3, 214)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 7
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.Size = New Size(377, 509)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' ExitBTN
        ' 
        ExitBTN.Dock = DockStyle.Fill
        ExitBTN.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        ExitBTN.Location = New Point(3, 435)
        ExitBTN.Name = "ExitBTN"
        ExitBTN.Size = New Size(371, 71)
        ExitBTN.TabIndex = 1
        ExitBTN.Text = "Exit"
        ExitBTN.UseVisualStyleBackColor = True
        ' 
        ' IjasaBTN
        ' 
        IjasaBTN.Dock = DockStyle.Fill
        IjasaBTN.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        IjasaBTN.Location = New Point(3, 219)
        IjasaBTN.Name = "IjasaBTN"
        IjasaBTN.Size = New Size(371, 66)
        IjasaBTN.TabIndex = 3
        IjasaBTN.Text = "Ijasa dan Laporan"
        IjasaBTN.UseVisualStyleBackColor = True
        ' 
        ' KelulusanBTN
        ' 
        KelulusanBTN.Dock = DockStyle.Fill
        KelulusanBTN.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        KelulusanBTN.Location = New Point(3, 147)
        KelulusanBTN.Name = "KelulusanBTN"
        KelulusanBTN.Size = New Size(371, 66)
        KelulusanBTN.TabIndex = 2
        KelulusanBTN.Text = "Informasi Kelulusan"
        KelulusanBTN.UseVisualStyleBackColor = True
        ' 
        ' GrafikBTN
        ' 
        GrafikBTN.Dock = DockStyle.Fill
        GrafikBTN.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        GrafikBTN.Location = New Point(3, 75)
        GrafikBTN.Name = "GrafikBTN"
        GrafikBTN.Size = New Size(371, 66)
        GrafikBTN.TabIndex = 1
        GrafikBTN.Text = "Grafik Kelulusan"
        GrafikBTN.UseVisualStyleBackColor = True
        ' 
        ' InsertBTN
        ' 
        InsertBTN.Dock = DockStyle.Fill
        InsertBTN.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        InsertBTN.Location = New Point(3, 3)
        InsertBTN.Name = "InsertBTN"
        InsertBTN.Size = New Size(371, 66)
        InsertBTN.TabIndex = 0
        InsertBTN.Text = "Input Data"
        InsertBTN.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(390, 1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(946, 720)
        Panel2.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1348, 721)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ExitBTN As Button
    Friend WithEvents IjasaBTN As Button
    Friend WithEvents KelulusanBTN As Button
    Friend WithEvents GrafikBTN As Button
    Friend WithEvents InsertBTN As Button
    Friend WithEvents Panel2 As Panel

End Class
