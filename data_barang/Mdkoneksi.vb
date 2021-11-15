Imports System.Data.OleDb
Module Mdkoneksi

    Public cmd As OleDbCommand
    Public da As OleDbDataAdapter
    Public dr As OleDbDataReader
    Public dt As DataTable
    Public ketemu As Boolean 'di pakai buat edit 

    Public koneksi As New OleDbConnection(" provider=microsoft.ace.oledb.12.0; data source=dbbarang.accdb ")

    Sub konek()

        Try
            koneksi.Open()
            ' MsgBox("koneksi berhasil dilakukan")
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("koneksi gagal")
        End Try

    End Sub

    Sub diskonek()
        koneksi.Close()
    End Sub

End Module
