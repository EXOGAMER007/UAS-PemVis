<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grafik
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Chart1 = New DataVisualization.Charting.Chart()
        StudiBox = New ComboBox()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Chart1
        ' 
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New Point(0, -6)
        Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Chart1.Series.Add(Series1)
        Chart1.Size = New Size(720, 720)
        Chart1.TabIndex = 0
        Chart1.Text = "Chart1"
        ' 
        ' StudiBox
        ' 
        StudiBox.FormattingEnabled = True
        StudiBox.Items.AddRange(New Object() {"Informatika", "Sistem Informasi", "Teknik Sipil"})
        StudiBox.Location = New Point(19, 79)
        StudiBox.Name = "StudiBox"
        StudiBox.Size = New Size(177, 28)
        StudiBox.TabIndex = 1
        StudiBox.Text = "Informatika"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(33, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 28)
        Label1.TabIndex = 2
        Label1.Text = "Program Studi"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Chart1)
        Panel1.Location = New Point(230, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(720, 720)
        Panel1.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.AppWorkspace
        Panel2.Controls.Add(StudiBox)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(1, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(227, 718)
        Panel2.TabIndex = 4
        ' 
        ' Grafik
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(946, 720)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Grafik"
        Text = "Grafik"
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents StudiBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
