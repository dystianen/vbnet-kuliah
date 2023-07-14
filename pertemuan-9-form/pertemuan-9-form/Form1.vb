Public Class Form1
    Structure mhs
        Dim nim As String
        Dim name As String
        Dim nilai As Integer
        Dim mutu As String
        Dim keterangan As String
    End Structure

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Sub rata2()
        On Error Resume Next
        Dim x As Integer
        For baris As Integer = 0 To DataGridView1.RowCount - 1
            x = x + DataGridView1.Rows(baris).Cells(2).Value
        Next
        TextBox4.Text = x
        TextBox4.Text = TextBox4.Text / (DataGridView1.RowCount - 1)
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim newmhs As mhs
        newmhs.nim = TextBox1.Text
        newmhs.name = TextBox2.Text
        newmhs.nilai = TextBox3.Text

        If newmhs.nilai > 90 Then
            newmhs.mutu = "A"
        ElseIf newmhs.nilai > 75 Then
            newmhs.mutu = "B"
        ElseIf newmhs.nilai > 60 Then
            newmhs.mutu = "C"
        ElseIf newmhs.nilai > 50 Then

            newmhs.mutu = "D"
        Else
            newmhs.mutu = "E"
        End If
        If newmhs.mutu = "A" Or newmhs.mutu = "B" Or newmhs.mutu = "C" Then
            newmhs.keterangan = "Lulus"
        Else
            newmhs.keterangan = "Gagal"
        End If
        DataGridView1.Rows.Add(newmhs.nim, newmhs.name, newmhs.nilai, newmhs.mutu, newmhs.keterangan)
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox1.Focus()
        Call rata2()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class
