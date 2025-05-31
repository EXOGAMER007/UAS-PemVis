Imports MySql.Data.MySqlClient

Public Class InputData
    'Sub CekDataReader()
    '    If RD IsNot Nothing AndAlso Not RD.IsClosed Then
    '        RD.Close()
    '    End If
    'End Sub
    Sub TampilGrid()
        CekDataReader()
        koneksi()
        DA = New MySqlDataAdapter("select * from TBMahasiswa", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "DataMahasiswa")
        DataGridView1.DataSource = DS.Tables("DataMahasiswa")
        DataGridView1.Refresh()
    End Sub
    Private Sub InputData_Load(sender As Object, e As EventArgs) Handles Me.Load
        koneksi()
        TampilGrid()
        CekDataReader()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            If row.Index < DataGridView1.RowCount - 1 And row.Index >= 0 Then
                TxtNIM.Text = row.Cells(0).Value
                TxtNama.Text = row.Cells(1).Value
                KelaminBox.Text = row.Cells(2).Value
                StudiBox.Text = row.Cells(3).Value
                PredikatBox.Text = row.Cells(4).Value
                TxtIPK.Text = row.Cells(5).Value
                PictureBox1.ImageLocation = row.Cells(6).Value
            End If
        End If
    End Sub

    Function PeriksaKosong()
        If TxtNIM.Text = "" Then
            MessageBox.Show("NIM harus diisi", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TxtNama.Text = "" Then
            MessageBox.Show("Nama harus diisi", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf KelaminBox.Text = "" Then
            MessageBox.Show("Jenis kelamin harus diisi", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf StudiBox.Text = "" Then
            MessageBox.Show("Program studi harus diisi", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf PredikatBox.Text = "" Then
            MessageBox.Show("Predikat harus diisi", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TxtIPK.Text = "" Then
            MessageBox.Show("IPK harus diisi", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf PictureBox1.Image Is Nothing Then
            MessageBox.Show("Gambar harus diisi", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Return True
        End If
        Return False
    End Function

    Sub kosong()
        TxtNIM.Clear()
        TxtNama.Clear()
        TxtIPK.Clear()
        PictureBox1.ImageLocation = Nothing
    End Sub

    Private Sub SimpanBTN_Click(sender As Object, e As EventArgs) Handles SimpanBTN.Click
        'If PeriksaKosong() = False Then
        '    MsgBox("Data Belum Lengkap")
        '    TxtNIM.Focus()
        '    Return
        'End If
        If PeriksaKosong() = False Then
            MsgBox("Data Belum Lengkap")
            TxtNIM.Focus()
        Else
            CMD = New MySqlCommand("Select * from TBMahasiswa where NIM = '" &
            TxtNIM.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                CMD = New MySqlCommand("INSERT INTO TBMahasiswa (NIM, Nama, Kelamin, Studi, Predikat, IPK, gambar) VALUES (@NIM, @Nama, @Kelamin, @Studi, @Predikat, @IPK, @Foto)", CONN)
                CMD.Parameters.AddWithValue("@NIM", TxtNIM.Text)
                CMD.Parameters.AddWithValue("@Nama", TxtNama.Text)
                CMD.Parameters.AddWithValue("@Kelamin", KelaminBox.Text)
                CMD.Parameters.AddWithValue("@Studi", StudiBox.Text)
                CMD.Parameters.AddWithValue("@Predikat", PredikatBox.Text)
                CMD.Parameters.AddWithValue("@IPK", TxtIPK.Text)
                CMD.Parameters.AddWithValue("@Foto", PictureBox1.ImageLocation)
                CMD.ExecuteNonQuery()
                kosong()
                TampilGrid()
                MsgBox("Simpan Data Sukses!")
            Else
                RD.Close()
                MsgBox("Data Tersebut Sudah Ada")
            End If
        End If
    End Sub

    'Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    '    SimpanGambar.Filter = "PNG Image|*.png|JPG Image|*.jpg"
    '    If SimpanGambar.ShowDialog() = DialogResult.OK Then
    '        PictureBox1.ImageLocation = SimpanGambar.FileName
    '    End If
    'End Sub

    Function PeriksaDataBaseKosong()
        CekDataReader()
        CMD = New MySqlCommand("Select * from TBMahasiswa where NIM = @NIM", CONN)
        CMD.Parameters.AddWithValue("@NIM", TxtNIM.Text)
        RD = CMD.ExecuteReader

        If RD.HasRows Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub HapusBTN_Click(sender As Object, e As EventArgs) Handles HapusBTN.Click
        koneksi()
        If TxtNIM.Text = Nothing Then
            MsgBox("NIM belum di isi")
            TxtNIM.Focus()
        Else
            If PeriksaDataBaseKosong() Then

                CMD = New MySqlCommand("delete From TBMahasiswa Where NIM = (@NIM)", CONN)
                CMD.Parameters.AddWithValue("@NIM", TxtNIM.Text)

                CekDataReader()

                CMD.ExecuteNonQuery()
                TampilGrid()
                MsgBox("Data berhasil dihapus")
                kosong()
            Else
                MsgBox("Data tidak ditemukan")
            End If
        End If
    End Sub

    Private Sub UbahBTN_Click(sender As Object, e As EventArgs) Handles UbahBTN.Click
        If TxtNIM.Text = Nothing Then
            MsgBox("NIM belum diisi")
            TxtNIM.Focus()
        Else
            Dim ubah As String = "update TBMahasiswa set Nama = (@Nama), 
Kelamin = (@Kelamin), Studi = (@Studi), Predikat = (@Predikat), IPK = (@IPK), gambar = (@Gambar) where NIM = (@NIM)"
            CMD = New MySqlCommand(ubah, CONN)
            CMD.Parameters.AddWithValue("@NIM", TxtNIM.Text)
            CMD.Parameters.AddWithValue("@Nama", TxtNama.Text)
            CMD.Parameters.AddWithValue("@Kelamin", KelaminBox.Text)
            CMD.Parameters.AddWithValue("@Studi", StudiBox.Text)
            CMD.Parameters.AddWithValue("@Predikat", PredikatBox.Text)
            CMD.Parameters.AddWithValue("@IPK", TxtIPK.Text)
            CMD.Parameters.AddWithValue("@Gambar", PictureBox1.ImageLocation)
            CMD.ExecuteNonQuery()
            TampilGrid()
            MsgBox("Data berhasil diubah")
            kosong()
        End If
    End Sub

    Private Sub MasukanBTN_Click(sender As Object, e As EventArgs) Handles MasukanBTN.Click
        SimpanGambar.Filter = "PNG Image|*.png|JPG Image|*.jpg"
        If SimpanGambar.ShowDialog() = DialogResult.OK Then
            PictureBox1.ImageLocation = SimpanGambar.FileName
        End If
    End Sub

    Private Function TentukanPredikat(ByVal IPK As Double) As String
        Dim predikatResult As String = ""

        If IPK >= 3.85 Then
            PredikatBox.Text = "Summa Cum Laude"
        ElseIf IPK >= 3.7 Then
            PredikatBox.Text = "Magna Cum Laude"
        ElseIf IPK >= 3.5 Then
            PredikatBox.Text = "Cum Laude"
        ElseIf IPK >= 3.0 Then
            PredikatBox.Text = "Sangat Memuaskan"
        ElseIf IPK >= 2.75 Then
            PredikatBox.Text = "Memuaskan"
        Else
            PredikatBox.Text = "Cukup" ' Atau "Tidak Memenuhi Syarat" sesuai kebutuhan
        End If

        Return predikatResult
    End Function

    Private Sub TxtIPK_TextChanged(sender As Object, e As EventArgs) Handles TxtIPK.TextChanged
        Dim ipkValue As Double
        Double.TryParse(TxtIPK.Text, ipkValue)
        If ipkValue >= 3.85 Then
            PredikatBox.Text = "Summa Cum Laude"
        ElseIf ipkValue >= 3.7 Then
            PredikatBox.Text = "Magna Cum Laude"
        ElseIf ipkValue >= 3.5 Then
            PredikatBox.Text = "Cum Laude"
        ElseIf ipkValue >= 3.0 Then
            PredikatBox.Text = "Sangat Memuaskan"
        ElseIf ipkValue >= 2.75 Then
            PredikatBox.Text = "Memuaskan"
        Else
            PredikatBox.Text = "Cukup"
        End If
    End Sub

    Private Sub TxtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNIM.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[0-9]” OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub TxtIPK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIPK.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9.]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub TxtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[a-z, A-Z]” _
        OrElse keyascii = Keys.Back _
        OrElse keyascii = Keys.Space _
        OrElse keyascii = Keys.Return _
        OrElse keyascii = Keys.Delete) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub InputData_StyleChanged(sender As Object, e As EventArgs) Handles Me.StyleChanged
        TampilGrid()
        CekDataReader()
    End Sub
End Class