Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        TextBox3.Enabled = False
        ComboBox1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False

        ComboBox1.Items.Add("Reguler")
        ComboBox1.Items.Add("Premium")
        ComboBox1.Items.Add("Master")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        TextBox3.Enabled = True
        ComboBox1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or RadioButton1.Text = "" Or RadioButton2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Maaf Data Harus Dilengkapi!")
        Else
            DataGridView1.Rows.Add(1)
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = TextBox1.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = TextBox2.Text
            If RadioButton1.Checked = True Then
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = RadioButton1.Text
            ElseIf RadioButton2.Checked = True Then
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = RadioButton2.Text
            End If
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(3).Value = TextBox3.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(4).Value = ComboBox1.Text
            DataGridView1.Update()
            MsgBox("DATA TERSIMPAN")
            TextBox1.Text = ""
            TextBox2.Text = ""
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            TextBox3.Text = ""
            ComboBox1.Text = ""
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim pesan As String
        pesan = MsgBox("Apakah anda Yakin Menghapus ?", vbYesNo, "PERHATIAN!")
        If pesan = vbYes Then
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
            MsgBox("DATA TERHAPUS", vbInformation, "PENTING BANGET!")
        End If
    End Sub
End Class
