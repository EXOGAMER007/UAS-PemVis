Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub PictureBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseClick
        If TxtPassword.UseSystemPasswordChar Then
            TxtPassword.UseSystemPasswordChar = False
            PictureBox2.Image = My.Resources.LihatPassword
        Else
            TxtPassword.UseSystemPasswordChar = True
            PictureBox2.Image = My.Resources.SembunyiPassword
        End If
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BTNLogin.Click
        If TxtUsername.Text = "" Or TxtPassword.Text = "" Then
            MessageBox.Show("Username dan Password harus diisi", "WARNING",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TxtUsername.Text = "admin" And TxtPassword.Text = "admin" Then
            Module1.login = True
            ShowFormInPanel(InputData)
        Else
            MessageBox.Show("Username atau Password salah", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        TxtUsername.Focus()
        koneksi()
        JumlahMahasiswa()
        JumlahProdi()
        TxtPassword.UseSystemPasswordChar = True
        PictureBox2.Image = My.Resources.SembunyiPassword
    End Sub

    Sub JumlahMahasiswa()
        CekDataReader()
        CMD = New MySqlCommand("SELECT COUNT(*) FROM TBMahasiswa", CONN)
        RD = CMD.ExecuteReader()
        If RD.Read() Then
            Dim jumlah As Integer = RD.GetInt32(0)
            LabelJumlahMahasiswa.Text = jumlah.ToString()
        Else
            LabelJumlahMahasiswa.Text = "0"
        End If
    End Sub

    Sub JumlahProdi()
        CekDataReader()
        CMD = New MySqlCommand("SELECT COUNT(DISTINCT Studi) FROM TBMahasiswa", CONN)
        RD = CMD.ExecuteReader()
        If RD.Read() Then
            Dim jumlah As Integer = RD.GetInt32(0)
            LabelJumlahProdi.Text = jumlah.ToString()
        Else
            LabelJumlahProdi.Text = "0"
        End If
    End Sub
End Class