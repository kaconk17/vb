Option Explicit On

Public Class Form1
    Dim no(5) As Integer
    Dim nama(5) As String
    Dim i As Integer = 0
    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If IsNumeric(txt_no.Text) = False Then
            MsgBox("Hanya boleh angka !", MsgBoxStyle.Critical)
            txt_no.Focus()
        Else
            no(i) = txt_no.Text
            nama(i) = txt_nama.Text
            txt_no.Text = ""
            txt_nama.Text = ""
            ListBox1.Items.Add(no(i) & " " & nama(i))
            If i < 5 Then


                i = i + 1
            Else
                i = 6
                MsgBox("Data Penuh", MsgBoxStyle.Critical)
            End If

            txt_no.Focus()

        End If


    End Sub

    Private Sub btn_tampil_Click(sender As Object, e As EventArgs) Handles btn_tampil.Click
        Array.Sort(no, nama)

        If check_kecil.CheckState = CheckState.Checked Then
            Dim p As Integer = 6 - i
            ListBox1.Items.Clear()
            For a As Integer = i To 1 Step -1

                ListBox1.Items.Add(no(p) & " " & nama(p))
                p = p + 1
            Next
        Else
            Dim p As Integer = 5
            ListBox1.Items.Clear()
            For a As Integer = i To 1 Step -1

                ListBox1.Items.Add(no(p) & " " & nama(p))
                p = p - 1
            Next
        End If
    End Sub

    Private Sub btn_clr_Click(sender As Object, e As EventArgs) Handles btn_clr.Click
        ListBox1.Items.Clear()
        txt_no.Text = ""
        txt_nama.Text = ""
        i = 0
        Array.Clear(no, 0, no.Length)
        Array.Clear(nama, 0, nama.Length)
    End Sub

    Private Sub txt_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_no.KeyPress

        If e.KeyChar = Chr(13) Then
            txt_nama.Focus()
        End If
    End Sub

    Private Sub txt_nama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nama.KeyPress
        If e.KeyChar = Chr(13) Then
            btn_simpan.Focus()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        check_kecil.CheckState = CheckState.Checked
        check_besar.CheckState = CheckState.Unchecked
    End Sub







    Private Sub check_kecil_CheckStateChanged(sender As Object, e As EventArgs) Handles check_kecil.CheckStateChanged
        If check_kecil.CheckState = CheckState.Checked Then
            check_besar.CheckState = CheckState.Unchecked

        End If
    End Sub

    Private Sub check_besar_CheckStateChanged(sender As Object, e As EventArgs) Handles check_besar.CheckStateChanged
        If check_besar.CheckState = CheckState.Checked Then
            check_kecil.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myindex As Integer = Array.BinarySearch(nama, TextBox_cari.Text)
        If myindex < 0 Then
            MsgBox("Data tidak ditemukan", MsgBoxStyle.Critical)
        Else
            ListBox1.Items.Clear()
            ListBox1.Items.Add(no(myindex) & " " & nama(myindex))
        End If

    End Sub
End Class
