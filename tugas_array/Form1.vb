Public Class Form1
    Dim no(5) As Integer
    Dim nama(5) As String
    Dim i As Integer = 0
    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click

        no(i) = txt_no.Text
        nama(i) = txt_nama.Text
        txt_no.Text = ""
        txt_nama.Text = ""
        If i < 5 Then


            i = i + 1
        Else
            MsgBox("Data Penuh", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub btn_tampil_Click(sender As Object, e As EventArgs) Handles btn_tampil.Click
        Array.Sort(no, nama)

        Dim p As Integer = 5
        For a As Integer = i To 1 Step -1

            ListBox1.Items.Add(no(p) & " " & nama(p))
            p = p - 1
        Next
    End Sub

    Private Sub btn_clr_Click(sender As Object, e As EventArgs) Handles btn_clr.Click
        ListBox1.Items.Clear()
        i = 0
        Array.Clear(no, 0, no.Length)
        Array.Clear(nama, 0, nama.Length)
    End Sub
End Class
