Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class Grafik
    Private Sub Grafik_Load(sender As Object, e As EventArgs) Handles Me.Load
        koneksi()
        LoadGrafik()
    End Sub

    Private Sub StudiBox_TextChanged(sender As Object, e As EventArgs) Handles StudiBox.TextChanged
        LoadGrafik()
    End Sub



    Private Sub LoadGrafik()
        Dim selectedStudi As String = StudiBox.Text.Trim()
        With Chart1
            Chart1.Series.Clear()
            Chart1.Titles.Clear()
            Chart1.Titles.Add("IPK Mahasiswa di Program Studi: " & StudiBox.Text.Trim())
            Chart1.ChartAreas(0).AxisY.Title = "IPK"
            Dim sqlQuery As String = "SELECT Nama, IPK FROM TBMahasiswa WHERE Studi LIKE @Studi ORDER BY Nama"

            DA = New MySqlDataAdapter(sqlQuery, CONN)
            DA.SelectCommand.Parameters.AddWithValue("@Studi", selectedStudi)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "MahasiswaIPK")
            If DS.Tables("MahasiswaIPK").Rows.Count > 0 Then
                For Each row As DataRow In DS.Tables("MahasiswaIPK").Rows
                    Dim studentName As String = row("Nama").ToString()
                    Dim studentIPK As Double = Convert.ToDouble(row("IPK"))

                    .Series.Add(studentName)
                    .Series(studentName).ChartType = SeriesChartType.Column
                    .Series(studentName).Points.AddXY("Mahasiswa", studentIPK)
                    '.Series.Add(studentName)
                Next
            End If
        End With
    End Sub

    Private Sub Grafik_StyleChanged(sender As Object, e As EventArgs) Handles Me.StyleChanged
        LoadGrafik()
        CekDataReader()
    End Sub
End Class