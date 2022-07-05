Imports System.IO
Imports System.Text
Imports Newtonsoft.Json
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw
Public Class PDFResumeCreator
    Dim path As String
    Dim filedata As String
    Dim pdflocation As String


    Private Sub ButtonPoweroff_Click(sender As Object, e As EventArgs) Handles ButtonPoweroff.Click
        Me.Hide()
    End Sub

    Private Sub ButtonSaveasJSON_Click(sender As Object, e As EventArgs) Handles ButtonSaveasJSON.Click
        path = "JSONFILE/" & TextBoxFullname.Text & ".json"
        Dim bday As String = DateTimePickerBirthday.Value.Month & DateTimePickerBirthday.Value.Day & DateTimePickerBirthday.Value.Year
        Dim customers As List(Of information) = New List(Of information)()

        Dim customer As information = New information With {
            .Name = TextBoxFullname.Text,
            .Email = TextBoxEmail.Text,
            .PhoneNumber = TextBoxPhoneNumber.Text,
            .Gender = ComboBoxGender.Text,
            .Birthday = bday,
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
        Dim name As Paragraph = New Paragraph(record.Name.ToUpper())
        Dim email As Paragraph = New Paragraph(record.Email)
        Dim contact As Paragraph = New Paragraph(record.PhoneNumber)
        Dim address As Paragraph = New Paragraph(record.Address)
        Dim birthday As Paragraph = New Paragraph(record.Birthday & vbLf & vbLf)
        Dim obj As Chunk = New Chunk(vbLf & vbLf & "OBJECTIVE:" & vbLf)
        Dim objective As Paragraph = New Paragraph(record.Objective & vbLf & vbLf)
        Dim edu As Chunk = New Chunk(vbLf & "EDUCATIONAL BACKGROUND:" & vbLf & vbLf)
        Dim college As Paragraph = New Paragraph("COLLEGE: " & record.College & vbLf & vbLf)
        Dim universi As Paragraph = New Paragraph("COLLEGE: " & record.University & vbLf & vbLf)
        Dim sy As Paragraph = New Paragraph("COLLEGE: " & record.Schoolyear & vbLf & vbLf)
        Dim skill As Chunk = New Chunk(vbLf & "SKILLS:" & vbLf & vbLf)
        Dim _skill1 As Paragraph = New Paragraph("* " & record.Skill1 & vbLf & vbLf)
        Dim _skill2 As Paragraph = New Paragraph("* " & record.Skill2 & vbLf & vbLf)
        Dim _skill3 As Paragraph = New Paragraph("* " & record.Skill3 & vbLf & vbLf)
        Dim _skill4 As Paragraph = New Paragraph("* " & record.Skill4 & vbLf & vbLf)

        Dim line As LineSeparator = New LineSeparator(5.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_RIGHT, 1)

        name.Font.Size = 20
        name.Alignment = Element.ALIGN_CENTER
        name.SetLeading(15, 1)
        obj.Font.Size = 18
        edu.Font.Size = 18

        objective.SetLeading(15, 1)

        college.IndentationLeft = 40

        skill.Font.Size = 18
        _skill1.IndentationLeft = 40
        _skill2.IndentationLeft = 40
        _skill3.IndentationLeft = 40
        _skill4.IndentationLeft = 40


        jsonWriter.Add(name)
        jsonWriter.Add(contact)
        jsonWriter.Add(address)
        jsonWriter.Add(email)
        jsonWriter.Add(birthday)
        jsonWriter.Add(obj)
        jsonWriter.Add(objective)
        jsonWriter.Add(edu)

        jsonWriter.Add(college)
        jsonWriter.Add(skill)
        jsonWriter.Add(_skill1)
        jsonWriter.Add(_skill2)
        jsonWriter.Add(_skill3)
        jsonWriter.Add(_skill4)
        jsonWriter.Add(line)
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

