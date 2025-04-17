Imports System.Windows.Forms
Imports System.IO


Public Class Form1
    Dim fileName As String
    Private Sub btnSelectFile_Click(sender As Object, e As EventArgs) Handles btnSelectFile.Click

        Dim dialog As New OpenFileDialog()
        With lvFile
            .View = View.Details
            .GridLines = True
            .Columns.Clear()
            .Items.Clear()
            .Columns.Insert(0, "ID")
            .Columns.Insert(1, "Colour")
            .Columns.Insert(2, "Date")

            .Columns(0).Width = 0
            .Columns(1).Width = 100
            .Columns(2).Width = 250
            .FullRowSelect = True ' this property allows selection of the row
            .MultiSelect = False
        End With


        dialog.Title = "Browse Files"
        '   dialog.Filter = "Text Files(*.*)|*.TXT"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then

            'Using MyReader As New Microsoft.VisualBasic.
            'FileIO.TextFieldParser(
            '            "C:\TestFolder\test.txt")
            Using MyReader As New Microsoft.VisualBasic.
                      FileIO.TextFieldParser(dialog.FileName)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(",")
                Dim currentRow As String()

                ' First row is columns

                currentRow = MyReader.ReadFields()
                Dim currentField As String
                For Each currentField In currentRow
                    MsgBox(currentField)
                Next

                While Not MyReader.EndOfData
                    Try
                        'Read Next Line into list box
                        currentRow = MyReader.ReadFields()
                        '  Dim MyArray() As String = Split(currentRow.ToString, ",")
                        lvFile.Items.Add(New ListViewItem(New String() {currentRow(1), currentRow(0), currentRow(2)}))

                    Catch ex As Microsoft.VisualBasic.
                                FileIO.MalformedLineException
                        MsgBox("Line " & ex.Message &
                        "is not valid and will be skipped.")
                    End Try
                End While
            End Using
        End If

    End Sub


End Class