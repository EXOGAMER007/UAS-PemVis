Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class Ijasa
    Private Sub Ijasa_Load(sender As Object, e As EventArgs) Handles Me.Load
        koneksi()
        TampilGrid()
        CekDataReader()
    End Sub

    Sub TampilGrid()
        CekDataReader()
        DA = New MySqlDataAdapter("select * from TBMahasiswa", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "DataMahasiswa")
        DataGridView1.DataSource = DS.Tables("DataMahasiswa")
        DataGridView1.Refresh()
    End Sub

    'Sub CekDataReader()
    '    If RD IsNot Nothing AndAlso Not RD.IsClosed Then
    '        RD.Close()
    '    End If
    'End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            If row.Index < DataGridView1.RowCount - 1 And row.Index >= 0 Then
                LabelNIM.Text = row.Cells(0).Value
                LabelNama.Text = row.Cells(1).Value
                LabelKelamin.Text = row.Cells(2).Value
                LabelStudi.Text = row.Cells(3).Value
                LabelPredikat.Text = row.Cells(4).Value
                LabelIPK.Text = row.Cells(5).Value
                PictureBox1.ImageLocation = row.Cells(6).Value
            End If
        End If
    End Sub

    Private Sub Ijasa_StyleChanged(sender As Object, e As EventArgs) Handles Me.StyleChanged
        TampilGrid()
        CekDataReader()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Font 
        Dim fontJudul As New Font("Arial", 16, FontStyle.Bold)
        Dim fontSubJudul As New Font("Arial", 12, FontStyle.Bold)
        Dim fontNormal As New Font("Arial", 11)
        Dim fontSmall As New Font("Arial", 10)

        ' margins
        Dim leftMargin As Integer = 50
        Dim centerMargin As Integer = CInt(e.PageBounds.Width / 2 - 200)
        Dim rightMargin As Integer = e.PageBounds.Width - 250
        Dim yPos As Integer = 100

        ' Informasi tambahan
        Dim NoIjasa As String = "IJZ/" & DateTime.Now.ToString("yyyy") & "/" & LabelNIM.Text
        Dim tanggal As String = DateTime.Now.ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("id-ID"))

        ' header di tengah
        Dim headerSize As SizeF = e.Graphics.MeasureString("SURAT IJAZAH", fontJudul)
        e.Graphics.DrawString("SURAT IJAZAH", fontJudul, Brushes.Black, (e.PageBounds.Width - headerSize.Width) / 2, yPos)
        yPos += 40

        Dim noSuratSize As SizeF = e.Graphics.MeasureString("Nomor: " & NoIjasa, fontSubJudul)
        e.Graphics.DrawString("Nomor: " & NoIjasa, fontSubJudul, Brushes.Black, (e.PageBounds.Width - noSuratSize.Width) / 2, yPos)
        yPos += 80

        ' Perkenalan
        e.Graphics.DrawString("Dengan ini menerangkan bahwa:", fontNormal, Brushes.Black, leftMargin, yPos)
        yPos += 40

        ' Data Mahasiswa
        Dim labelWidth As Integer = 120
        Dim valueX As Integer = leftMargin + labelWidth

        e.Graphics.DrawString("Nama", fontNormal, Brushes.Black, leftMargin, yPos)
        e.Graphics.DrawString(": " & LabelNama.Text, fontNormal, Brushes.Black, valueX, yPos)
        yPos += 25

        e.Graphics.DrawString("NIM", fontNormal, Brushes.Black, leftMargin, yPos)
        e.Graphics.DrawString(": " & LabelNIM.Text, fontNormal, Brushes.Black, valueX, yPos)
        yPos += 25

        e.Graphics.DrawString("Program Studi", fontNormal, Brushes.Black, leftMargin, yPos)
        e.Graphics.DrawString(": " & LabelStudi.Text, fontNormal, Brushes.Black, valueX, yPos)
        yPos += 25

        e.Graphics.DrawString("Jenis Kelamin", fontNormal, Brushes.Black, leftMargin, yPos)
        e.Graphics.DrawString(": " & LabelKelamin.Text, fontNormal, Brushes.Black, valueX, yPos)
        yPos += 60

        ' Penghargaan
        e.Graphics.DrawString("Telah menyelesaikan pendidikan dengan:", fontNormal, Brushes.Black, leftMargin, yPos)
        yPos += 40

        e.Graphics.DrawString("Predikat", fontNormal, Brushes.Black, leftMargin, yPos)
        e.Graphics.DrawString(": " & LabelPredikat.Text, fontNormal, Brushes.Black, valueX, yPos)
        yPos += 25

        e.Graphics.DrawString("IPK", fontNormal, Brushes.Black, leftMargin, yPos)
        e.Graphics.DrawString(": " & LabelIPK.Text, fontNormal, Brushes.Black, valueX, yPos)
        yPos += 80

        ' Kesimpulan
        Dim conclusionText As String = "Dengan demikian berhak menyandang gelar sesuai dengan program studi yang telah ditempuh."
        Dim conclusionRect As New RectangleF(leftMargin, yPos, e.PageBounds.Width - 2 * leftMargin, 0)
        conclusionRect.Height = e.Graphics.MeasureString(conclusionText, fontNormal, conclusionRect.Size).Height
        e.Graphics.DrawString(conclusionText, fontNormal, Brushes.Black, conclusionRect)
        yPos += CInt(conclusionRect.Height) + 60

        ' Location and date
        e.Graphics.DrawString("Ditetapkan di:", fontNormal, Brushes.Black, leftMargin, yPos)
        e.Graphics.DrawString("Samarinda", fontNormal, Brushes.Black, valueX, yPos)
        yPos += 25

        e.Graphics.DrawString("Pada tanggal:", fontNormal, Brushes.Black, leftMargin, yPos)
        e.Graphics.DrawString(tanggal, fontNormal, Brushes.Black, valueX, yPos)
        yPos += 80

        ' Tanda tangan
        Dim signatureX As Integer = e.PageBounds.Width - 250
        e.Graphics.DrawString("Rektor/Ketua,", fontNormal, Brushes.Black, signatureX, yPos)
        yPos += 40

        ' sedikit jarak ditanda tangan
        e.Graphics.DrawString("(__________________________)", fontNormal, Brushes.Black, signatureX - 70, yPos)

        ' Footer
        yPos += 60
        e.Graphics.DrawString("Dokumen ini sah tanpa tanda tangan basah dan stempel", fontSmall, Brushes.Gray, centerMargin, yPos)
    End Sub

    Private Sub CetanBTN_Click(sender As Object, e As EventArgs) Handles CetanBTN.Click
        'PrintDocument1.Print()
        TampilkanPreviewCetak()
    End Sub

    Private Sub TampilkanPreviewCetak()
        ' Set dokumen untuk preview
        PrintPreviewDialog1.Document = PrintDocument1

        ' Atur ukuran window preview (opsional)
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.StartPosition = FormStartPosition.CenterScreen

        ' Tampilkan dialog preview
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub StudiBox_TextChanged(sender As Object, e As EventArgs) Handles StudiBox.TextChanged
        If StudiBox.Text = "Semua" Then
            TampilGrid()
        Else
            Try
                DA = New MySqlDataAdapter("select * from TBMahasiswa where Studi like @Studi", CONN)
                DA.SelectCommand.Parameters.AddWithValue("@Studi", "%" & StudiBox.Text & "%")
                DS = New DataSet
                DS.Clear()
                DA.Fill(DS, "DataMahasiswa")
                DataGridView1.DataSource = DS.Tables("DataMahasiswa")
                DataGridView1.ReadOnly = True
            Catch ex As Exception
                MessageBox.Show("Data masih kosong")
            End Try
        End If
    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        If TxtCari.Text <> Nothing Then
            Try
                DA = New MySqlDataAdapter("select * from TBMahasiswa where NIM like @NIM", CONN)
                DA.SelectCommand.Parameters.AddWithValue("@NIM", "%" & CInt(TxtCari.Text) & "%")
                DS = New DataSet
                DS.Clear()
                DA.Fill(DS, "DataMahasiswa")
                DataGridView1.DataSource = DS.Tables("DataMahasiswa")
                DataGridView1.ReadOnly = True
            Catch ex As Exception
                'MessageBox.Show("Data masih kosong")
            End Try
        Else
            TampilGrid()
        End If
    End Sub
    'Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
    '    If TxtCari.Text <> Nothing Then
    '        Try
    '            DA = New MySqlDataAdapter("SELECT * FROM TBMahasiswa WHERE CAST(NIM AS CHAR) LIKE @NIM", CONN)
    '            DA.SelectCommand.Parameters.AddWithValue("@NIM", "%" & TxtCari.Text & "%")
    '            DS = New DataSet
    '            DS.Clear()
    '            DA.Fill(DS, "DataMahasiswa")
    '            DataGridView1.DataSource = DS.Tables("DataMahasiswa")
    '            DataGridView1.ReadOnly = True
    '        Catch ex As Exception
    '            MessageBox.Show("Data masih kosong")
    '        End Try
    '    Else
    '        TampilGrid()
    '    End If
    'End Sub
End Class