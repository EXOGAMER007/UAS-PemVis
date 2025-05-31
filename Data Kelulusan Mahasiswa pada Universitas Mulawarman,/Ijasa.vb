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
                LabelPredikat.Text = row.Cells(5).Value
                PictureBox1.ImageLocation = row.Cells(6).Value
            End If
        End If
    End Sub

    Private Sub Ijasa_StyleChanged(sender As Object, e As EventArgs) Handles Me.StyleChanged
        TampilGrid()
        CekDataReader()
    End Sub
End Class