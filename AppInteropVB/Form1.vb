Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop.Word

Public Class Form1
    Private Sub btndocx_Click(sender As Object, e As EventArgs) Handles btndocx.Click
        Dim dialogo As SaveFileDialog = New SaveFileDialog()

        If dialogo.ShowDialog() = DialogResult.OK Then
            Dim obj As Object = System.Reflection.Missing.Value
            Dim word As Microsoft.Office.Interop.Word.Application = New Microsoft.Office.Interop.Word.Application()
            Dim doc As Microsoft.Office.Interop.Word.Document = word.Documents.Add(obj)
            doc.Activate()
            word.Selection.TypeText(txt.Text)
            doc.SaveAs2(dialogo.FileName)
            word.Visible = True
        End If
    End Sub

    Private Sub btnxls_Click(sender As Object, e As EventArgs) Handles btnxls.Click
        Dim dialogoexe As SaveFileDialog = New SaveFileDialog()

        If dialogoexe.ShowDialog() = DialogResult.OK Then
            Dim obj As Object = System.Reflection.Missing.Value
            Dim excel As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application()
            Dim file As Microsoft.Office.Interop.Excel.Workbook = excel.Workbooks.Add(obj)
            Dim hoja As Microsoft.Office.Interop.Excel.Worksheet = file.Worksheets.Add()
            file.Activate()
            hoja.Cells(1, 1).Value = txt.Text
            file.SaveAs(dialogoexe.FileName)
            excel.Visible = True
        End If
    End Sub
End Class
