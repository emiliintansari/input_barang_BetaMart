Imports System.Data.OleDb

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
    End Sub
    'buat nampilin data yang ada di data base 
    Sub tampildata()
        konek()
        da = New OleDbDataAdapter(" SELECT * from tbr ", koneksi)
        dt = New DataTable
        da.Fill(dt)
        dg1.DataSource = dt
        diskonek()
    End Sub
    'buat nyimpen data 
    Private Sub bsimpan_Click(sender As Object, e As EventArgs) Handles bsimpan.Click

        If ketemu = False Then
            'Simpan Data Baru 
            konek()
            cmd = New OleDbCommand("INSERT INTO tbr VALUES('" & id.Text & "','" & nama.Text & "','" & tanggal.Text & "','" & stok.Text & "','" & harga.Text & "')", koneksi)
            cmd.ExecuteNonQuery()
            MsgBox("~Data Berhasil DI Input~")
            diskonek()
        Else
            'edit data 
            konek()
            cmd = New OleDbCommand(" UPDATE tbr set nama = '" & nama.Text & "',tanggal ='" & tanggal.Text & "',stok ='" & stok.Text & "',harga ='" & harga.Text & "' WHERE id = '" & id.Text & "'", koneksi)
            cmd.ExecuteNonQuery()
            MsgBox(" Data Berhasil DI EDIT")
            diskonek()


        End If

        'buat nampilin data 
        bkosong_Click(sender, e)
        tampildata()
    End Sub

    Private Sub bkosong_Click(sender As Object, e As EventArgs) Handles bkosong.Click
        'buat ngosongin form 
        id.Text = ""
        nama.Text = ""
        tanggal.Text = ""
        stok.Text = ""
        harga.Text = ""
        id.Focus()


    End Sub
    'buat kalo di klik enter tuh ntar nyari data 
    Private Sub id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles id.KeyPress
        If e.KeyChar = Chr(13) Then

            konek()
            cmd = New OleDbCommand("SELECT * FROM tbr WHERE id= '" & id.Text &
                "' ", koneksi)
            dr = cmd.ExecuteReader
            If dr.Read Then
                id.Text = dr.Item(0)
                nama.Text = dr.Item(1)
                tanggal.Text = dr.Item(2)
                stok.Text = dr.Item(3)
                harga.Text = dr.Item(4)
                ketemu = True

            Else
                MsgBox("Maaf data ga di temukan")
                ketemu = False

            End If
            diskonek()

        End If

    End Sub

    Private Sub bhapus_Click(sender As Object, e As EventArgs) Handles bhapus.Click
        Dim pilih = MessageBox.Show("yakin menghapus data ?", " perhatian!!!", MessageBoxButtons.YesNo)
        If pilih = vbYes Then
            konek()
            cmd = New OleDbCommand("DELETE FROM tbr WHERE id = '" & id.Text & "'", koneksi)
            cmd.ExecuteNonQuery()
            MsgBox("Data Ini Sudah DI Hapus")
            diskonek()

            tampildata()
            bkosong_Click(sender, e)


        End If
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        End
    End Sub
End Class
