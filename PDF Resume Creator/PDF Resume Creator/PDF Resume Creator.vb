Imports System.IO
Imports System.Text
Imports Newtonsoft.Json

Public Class PDFResumeCreator
    'Private Sub Buttontesting_Click(sender As Object, e As EventArgs) Handles Buttontesting.Click
    '    Dim customers As List(Of Customer) = New List(Of Customer)()
    '    Dim customer As Customer = New Customer With {
    '        .Fullname = Convert.ToString("Jerick"),
    '        .Email = Convert.ToString("ContactName"),
    '        .Address = Convert.ToString("Address")}
    '    customers.Add(customer)
    '    Dim json As String = JsonConvert.SerializeObject(customers, Formatting.Indented)
    '    File.WriteAllText("Json.json", json)
    'End Sub

    Private Sub ButtonPoweroff_Click(sender As Object, e As EventArgs) Handles ButtonPoweroff.Click
        Me.Hide()
    End Sub
End Class

Public Class Customer
    Public Property Fullname As String
    Public Property Email As String
    Public Property Address As String

End Class

