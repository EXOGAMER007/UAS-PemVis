Imports MySql.Data.MySqlClient

Module Module1
    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public CMD2 As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public STR As String
    Public kodeNote As String
    Public LihatPassword As Boolean = False
    Public login As Boolean = False
    Public masuk As Boolean = True
    Sub koneksi()
        Try
            Dim STR As String =
            "server=localhost;userid=root;password=;database=TugasAkhir"
            CONN = New MySqlConnection(STR)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub CekDataReader()
        If RD IsNot Nothing AndAlso Not RD.IsClosed Then
            RD.Close()
        End If
    End Sub
    Sub ShowFormInPanel(ByVal form As Form)
        If login = False And masuk = False Then
            MessageBox.Show("Silakan login terlebih dahulu.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Form1.Panel2.Controls.Clear()
            form.TopLevel = False
            form.FormBorderStyle = FormBorderStyle.None
            form.Dock = DockStyle.Fill
            Form1.Panel2.Controls.Add(form)
            form.Show()
        End If
    End Sub
End Module

Public Class Form1


    Private Sub InsertBTN_Click(sender As Object, e As EventArgs) Handles InsertBTN.Click
        ShowFormInPanel(InputData)
    End Sub

    Private Sub KelulusanBTN_Click(sender As Object, e As EventArgs) Handles KelulusanBTN.Click
        ShowFormInPanel(InfoKelulusan)
    End Sub

    Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click
        End
    End Sub

    Private Sub GrafikBTN_Click(sender As Object, e As EventArgs) Handles GrafikBTN.Click
        ShowFormInPanel(Grafik)
    End Sub

    Private Sub IjasaBTN_Click(sender As Object, e As EventArgs) Handles IjasaBTN.Click
        ShowFormInPanel(Ijasa)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ShowFormInPanel(InputData)
        ShowFormInPanel(Login)
        masuk = False
    End Sub
End Class
