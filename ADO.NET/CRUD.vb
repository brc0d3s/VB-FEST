Imports System.Drawing.Printing
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Npgsql
Imports Npgsql.Internal

Public Class CRUD
    Dim con As NpgsqlConnection = New NpgsqlConnection("User Id=postgres.qwjczytalqqhshwbitov;Password=brc0d3s_crudDB;Server=aws-0-us-west-1.pooler.supabase.com;Port=5432;Database=postgres;")

    Private Sub CRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            con.Open()
            Dim query As String = "select * from crudTable"
            Dim cmd As New NpgsqlCommand(query, con)
            Dim ad As New NpgsqlDataAdapter(cmd)
            Dim table As New DataTable
            ad.Fill(table)
            dgv.DataSource = table
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim id As Integer = Integer.TryParse(txtID.Text, id)
        Dim name As String = txtName.Text
        Dim address As String = txtAddress.Text
        Dim city As String = cmbCity.Text
        Dim age As String = txtAge.Text
        Dim sex As String = If(rdbMale.Checked, rdbMale.Text, rbtFemale.Text)

        Dim query As String = "INSERT INTO crudTable VALUES(@id, @name, @address, @city, @age, @sex)"
        Dim cmd As NpgsqlCommand = New NpgsqlCommand(query, con)

        Try
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@name", name)
            cmd.Parameters.AddWithValue("@address", address)
            cmd.Parameters.AddWithValue("@city", city)
            cmd.Parameters.AddWithValue("@age", age)
            cmd.Parameters.AddWithValue("@sex", sex)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()


            MessageBox.Show("Data successfully added")

            LoadData()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim id As Integer = Integer.TryParse(txtID.Text, id)
        Dim name As String = txtName.Text
        Dim address As String = txtAddress.Text
        Dim city As String = cmbCity.Text
        Dim age As String = txtAge.Text
        Dim sex As String = If(rdbMale.Checked, rdbMale.Text, rbtFemale.Text)

        Dim query As String = "UPDATE crudTable SET name = @name, address = @address, city = @city, age = @age, sex = @sex WHERE id = @id"
        Dim cmd As NpgsqlCommand = New NpgsqlCommand(query, con)

        Try
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@name", name)
            cmd.Parameters.AddWithValue("@address", address)
            cmd.Parameters.AddWithValue("@city", city)
            cmd.Parameters.AddWithValue("@age", age)
            cmd.Parameters.AddWithValue("@sex", sex)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Data successfully updated")

            LoadData()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim id As Integer = Integer.TryParse(txtID.Text, id)

        Dim query As String = "DELETE FROM crudTable WHERE id = @id"
        Dim cmd As NpgsqlCommand = New NpgsqlCommand(query, con)

        Try
            cmd.Parameters.AddWithValue("@id", id)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Data successfully deleted")

            LoadData()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim id As Integer = Integer.TryParse(txtID.Text, id)

        Dim query As String = "SELECT * FROM crudTable WHERE id = @id"
        Dim cmd As NpgsqlCommand = New NpgsqlCommand(query, con)

        Try
            cmd.Parameters.AddWithValue("@id", id)

            con.Open()
            Dim reader As NpgsqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                txtName.Text = reader("name").ToString()
                txtAddress.Text = reader("address").ToString()
                cmbCity.Text = reader("city").ToString()
                txtAge.Text = reader("age").ToString()
                Dim sex As String = reader("sex").ToString()
                If sex = "Male" Then
                    rdbMale.Checked = True
                Else
                    rbtFemale.Checked = True
                End If

                LoadData()
            Else
                MessageBox.Show("No data found")
            End If

            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        If Me.dgv IsNot Nothing AndAlso Me.dgv.Rows.Count > 0 Then
            PrintPreviewDialog1.ShowDialog()
        Else
            MessageBox.Show("No data available to preview.")
        End If
    End Sub

    Private Sub btnPrintData_Click(sender As Object, e As EventArgs) Handles btnPrintData.Click
        If Me.dgv IsNot Nothing AndAlso Me.dgv.Rows.Count > 0 Then
            Dim printDialog As New PrintDialog()
            printDialog.Document = PrintDocument1
            If printDialog.ShowDialog() = DialogResult.OK Then
                PrintDocument1.Print()
            End If
        Else
            MessageBox.Show("No data available to print.")
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.dgv.Width, Me.dgv.Height)
        dgv.DrawToBitmap(bm, New System.Drawing.Rectangle(0, 0, Me.dgv.Width, Me.dgv.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub PrintDocument1_EndPrint(sender As Object, e As PrintEventArgs) Handles PrintDocument1.EndPrint
        ' Save as PDF after printing
        SaveAsPDF("output.pdf")
    End Sub

    Private Sub SaveAsPDF(fileName As String)
        Dim pdfDoc As New Document(PageSize.A4.Rotate())
        Try
            Dim pdfWriter As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(fileName, FileMode.Create))
            pdfDoc.Open()

            Dim pdfTable As New PdfPTable(dgv.Columns.Count)
            For Each column As DataGridViewColumn In dgv.Columns
                If column.HeaderText IsNot Nothing Then
                    pdfTable.AddCell(column.HeaderText)
                End If
            Next

            For Each row As DataGridViewRow In dgv.Rows
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Value IsNot Nothing Then
                        pdfTable.AddCell(cell.Value.ToString())
                    End If
                Next
            Next

            pdfDoc.Add(pdfTable)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            pdfDoc.Close()
        End Try
    End Sub

End Class
