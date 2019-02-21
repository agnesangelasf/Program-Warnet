Public Class Pembayaran

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = Format(Now, "dd / MMM /yyyy")
        Label3.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        ComboBox1.Items.Add("Non Member")
        ComboBox1.Items.Add("Reguler")
        ComboBox1.Items.Add("Premium")
        ComboBox1.Items.Add("Master")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Reguler" Then
            TextBox3.Text = Val(TextBox2.Text - TextBox1.Text) * Val(Label9.Text) / Val(Label12.Text)
            Label18.Text = "Selamat Anda Mendapat Diskon"
            Label19.Text = "5%"
        ElseIf ComboBox1.Text = "Premium" Then
            TextBox3.Text = Val(TextBox2.Text - TextBox1.Text) * Val(Label9.Text) / Val(Label15.Text)
            Label18.Text = "Selamat Anda Mendapat Diskon"
            Label19.Text = "10%"
        ElseIf ComboBox1.Text = "Master" Then
            TextBox3.Text = Val(TextBox2.Text - TextBox1.Text) * Val(Label9.Text) / Val(Label17.Text)
            Label18.Text = "Selamat Anda Mendapat Diskon"
            Label19.Text = "20%"
        ElseIf ComboBox1.Text = "Non Member" Then
            TextBox3.Text = Val(TextBox2.Text - TextBox1.Text) * Val(Label9.Text)
            Label18.Text = "Maaf tidak Mendapat Diskon"
            Label19.Text = "Karena Anda Bukan Member"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView1.Rows.Add(1)
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = ComboBox1.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = TextBox1.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = TextBox2.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(3).Value = TextBox3.Text
        DataGridView1.Update()
        MsgBox("DATA TERSIMPAN")
        ComboBox1.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Label19.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim pesan As String
        pesan = MsgBox("Apakah anda Yakin Menghapus ?", vbYesNo, "PERHATIAN!")
        If pesan = vbYes Then
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
            MsgBox("DATA TERHAPUS", vbInformation, "PERHATIAN!")
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ComboBox1.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
End Class