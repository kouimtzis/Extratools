Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MaterialLookupDataSet.MATERIAL' table. You can move, or remove it, as needed.
        Me.MATERIALTableAdapter.Fill(Me.MaterialLookupDataSet.MATERIAL)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = "*"
        TextBox2.Text = "*"
        TextBox3.Text = "*"
    End Sub

   
End Class