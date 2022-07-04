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

    Private Sub ButtonSaveasJSON_Click(sender As Object, e As EventArgs) Handles ButtonSaveasJSON.Click
        Dim customers As List(Of information) = New List(Of information)()
        Dim customer As information = New information With {
            .Name = TextBoxFullname.Text,
            .Email = TextBoxEmail.Text,
            .PhoneNumber = TextBoxPhoneNumber.Text,
            .Gender = ComboBoxGender.Text,
            .Birthday = DateTimePickerBirthday.Value.ToString(),
            .Address = RichTextBoxAddress.Text,
            .Objective = RichTextBoxObjective.Text,
            .College = TextBoxGrad.Text,
            .University = TextBoxUniv.Text,
            .Schoolyear = TextBoxSchoolYear.Text,
            .Skill1 = TextBoxSkill1.Text,
            .Skill2 = TextBoxSkill2.Text,
            .Skill3 = TextBoxSkill3.Text,
            .Skill4 = TextBoxSkill4.Text}




        customers.Add(customer)
        Dim json As String = JsonConvert.SerializeObject(customers, Formatting.Indented)
        File.WriteAllText("JSONFILE/" & TextBoxFullname.Text & ".json", json)
        MessageBox.Show(TextBoxFullname.Text & ".json SuccessFully!!!!!")
    End Sub
End Class

Public Class information
    Public Property Name As String
    Public Property PhoneNumber As String
    Public Property Email As String
    Public Property Address As String
    Public Property Gender As String
    Public Property Birthday As String
    Public Property Objective As String
    Public Property College As String
    Public Property University As String
    Public Property Schoolyear As String
    Public Property Skill1 As String
    Public Property Skill2 As String
    Public Property Skill3 As String
    Public Property Skill4 As String


End Class

