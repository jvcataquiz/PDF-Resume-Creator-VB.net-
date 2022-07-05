Imports System.IO
Imports System.Text
Imports Newtonsoft.Json
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class PDFResumeCreator
    Dim path As String
    Dim filedata As String
    Dim pdflocation As String


    Private Sub ButtonPoweroff_Click(sender As Object, e As EventArgs) Handles ButtonPoweroff.Click
        Me.Hide()
    End Sub

    Private Sub ButtonSaveasJSON_Click(sender As Object, e As EventArgs) Handles ButtonSaveasJSON.Click
        path = "JSONFILE/" & TextBoxFullname.Text & ".json"

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

        Dim newStr = json.Substring(1, json.Length - 1)

        newStr = newStr.Remove(newStr.LastIndexOf("]"))

        File.WriteAllText(path, newStr)
        MessageBox.Show(TextBoxFullname.Text & ".json SuccessFully!!!!!")
    End Sub

    Private Sub ButtonPrintPDF_Click(sender As Object, e As EventArgs) Handles ButtonPrintPDF.Click
        path = "JSONFILE/" & TextBoxFullname.Text & ".json"
        pdflocation = "PDFFILE/" & TextBoxFullname.Text & ".pdf"

        filedata = File.ReadAllText(path)
        Dim record As information = JsonConvert.DeserializeObject(Of information)(filedata)


        Dim jsonWriter As New Document()
        Dim PDF As PdfWriter = PdfWriter.GetInstance(jsonWriter, New FileStream(pdflocation, FileMode.Create))

        jsonWriter.Open()
        jsonWriter.Add(New Paragraph(record.Name))
        jsonWriter.Close()

    End Sub

    Private Sub PDFResumeCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        path = "JSONFILE/" & TextBoxFullname.Text & ".json"
        filedata = "PDFFILE/" & TextBoxFullname.Text & ".pdf"
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

