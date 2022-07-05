<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PDFResumeCreator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PDFResumeCreator))
        Me.ButtonPoweroff = New System.Windows.Forms.Button()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.TextBoxFullname = New System.Windows.Forms.TextBox()
        Me.LabelFullname = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonSaveasJSON = New System.Windows.Forms.Button()
        Me.TextBoxSkill4 = New System.Windows.Forms.TextBox()
        Me.TextBoxSkill3 = New System.Windows.Forms.TextBox()
        Me.TextBoxSkill2 = New System.Windows.Forms.TextBox()
        Me.TextBoxSkill1 = New System.Windows.Forms.TextBox()
        Me.LabelSkill4 = New System.Windows.Forms.Label()
        Me.LabelSkill3 = New System.Windows.Forms.Label()
        Me.LabelSkill2 = New System.Windows.Forms.Label()
        Me.LabelSkill1 = New System.Windows.Forms.Label()
        Me.TextBoxSchoolYear = New System.Windows.Forms.TextBox()
        Me.LabelSy = New System.Windows.Forms.Label()
        Me.TextBoxCourse = New System.Windows.Forms.TextBox()
        Me.TextBoxUniv = New System.Windows.Forms.TextBox()
        Me.LabelUniv = New System.Windows.Forms.Label()
        Me.LabelGrad = New System.Windows.Forms.Label()
        Me.RichTextBoxAddress = New System.Windows.Forms.RichTextBox()
        Me.LabelObj = New System.Windows.Forms.Label()
        Me.RichTextBoxObjective = New System.Windows.Forms.RichTextBox()
        Me.LabelAddress = New System.Windows.Forms.Label()
        Me.ComboBoxGender = New System.Windows.Forms.ComboBox()
        Me.LabelGender = New System.Windows.Forms.Label()
        Me.TextBoxPhoneNumber = New System.Windows.Forms.TextBox()
        Me.LabelPhoneNumber = New System.Windows.Forms.Label()
        Me.LabelBday = New System.Windows.Forms.Label()
        Me.DateTimePickerBirthday = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.ButtonPrintPDF = New System.Windows.Forms.Button()
        Me.ButtonNew = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonPoweroff
        '
        Me.ButtonPoweroff.BackgroundImage = CType(resources.GetObject("ButtonPoweroff.BackgroundImage"), System.Drawing.Image)
        Me.ButtonPoweroff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonPoweroff.FlatAppearance.BorderSize = 0
        Me.ButtonPoweroff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPoweroff.Location = New System.Drawing.Point(705, 12)
        Me.ButtonPoweroff.Name = "ButtonPoweroff"
        Me.ButtonPoweroff.Size = New System.Drawing.Size(39, 39)
        Me.ButtonPoweroff.TabIndex = 0
        Me.ButtonPoweroff.UseVisualStyleBackColor = True
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.BackColor = System.Drawing.Color.White
        Me.LabelTitle.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelTitle.Location = New System.Drawing.Point(12, 12)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(262, 29)
        Me.LabelTitle.TabIndex = 1
        Me.LabelTitle.Text = "PDF RESUME CREATOR"
        '
        'TextBoxFullname
        '
        Me.TextBoxFullname.Location = New System.Drawing.Point(32, 37)
        Me.TextBoxFullname.Name = "TextBoxFullname"
        Me.TextBoxFullname.Size = New System.Drawing.Size(343, 23)
        Me.TextBoxFullname.TabIndex = 1
        '
        'LabelFullname
        '
        Me.LabelFullname.AutoSize = True
        Me.LabelFullname.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelFullname.ForeColor = System.Drawing.Color.White
        Me.LabelFullname.Location = New System.Drawing.Point(19, 11)
        Me.LabelFullname.Name = "LabelFullname"
        Me.LabelFullname.Size = New System.Drawing.Size(84, 23)
        Me.LabelFullname.TabIndex = 3
        Me.LabelFullname.Text = "Fullname:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ButtonSaveasJSON)
        Me.Panel1.Controls.Add(Me.TextBoxSkill4)
        Me.Panel1.Controls.Add(Me.TextBoxSkill3)
        Me.Panel1.Controls.Add(Me.TextBoxSkill2)
        Me.Panel1.Controls.Add(Me.TextBoxSkill1)
        Me.Panel1.Controls.Add(Me.LabelSkill4)
        Me.Panel1.Controls.Add(Me.LabelSkill3)
        Me.Panel1.Controls.Add(Me.LabelSkill2)
        Me.Panel1.Controls.Add(Me.LabelSkill1)
        Me.Panel1.Controls.Add(Me.TextBoxSchoolYear)
        Me.Panel1.Controls.Add(Me.LabelSy)
        Me.Panel1.Controls.Add(Me.TextBoxCourse)
        Me.Panel1.Controls.Add(Me.TextBoxUniv)
        Me.Panel1.Controls.Add(Me.LabelUniv)
        Me.Panel1.Controls.Add(Me.LabelGrad)
        Me.Panel1.Controls.Add(Me.RichTextBoxAddress)
        Me.Panel1.Controls.Add(Me.LabelObj)
        Me.Panel1.Controls.Add(Me.RichTextBoxObjective)
        Me.Panel1.Controls.Add(Me.LabelAddress)
        Me.Panel1.Controls.Add(Me.ComboBoxGender)
        Me.Panel1.Controls.Add(Me.LabelGender)
        Me.Panel1.Controls.Add(Me.TextBoxPhoneNumber)
        Me.Panel1.Controls.Add(Me.LabelPhoneNumber)
        Me.Panel1.Controls.Add(Me.LabelBday)
        Me.Panel1.Controls.Add(Me.DateTimePickerBirthday)
        Me.Panel1.Controls.Add(Me.TextBoxEmail)
        Me.Panel1.Controls.Add(Me.LabelEmail)
        Me.Panel1.Controls.Add(Me.TextBoxFullname)
        Me.Panel1.Controls.Add(Me.LabelFullname)
        Me.Panel1.Location = New System.Drawing.Point(21, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(723, 401)
        Me.Panel1.TabIndex = 4
        '
        'ButtonSaveasJSON
        '
        Me.ButtonSaveasJSON.BackColor = System.Drawing.Color.Black
        Me.ButtonSaveasJSON.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonSaveasJSON.ForeColor = System.Drawing.Color.White
        Me.ButtonSaveasJSON.Location = New System.Drawing.Point(584, 359)
        Me.ButtonSaveasJSON.Name = "ButtonSaveasJSON"
        Me.ButtonSaveasJSON.Size = New System.Drawing.Size(107, 33)
        Me.ButtonSaveasJSON.TabIndex = 15
        Me.ButtonSaveasJSON.Text = "Save As JSON"
        Me.ButtonSaveasJSON.UseVisualStyleBackColor = False
        '
        'TextBoxSkill4
        '
        Me.TextBoxSkill4.Location = New System.Drawing.Point(550, 317)
        Me.TextBoxSkill4.Name = "TextBoxSkill4"
        Me.TextBoxSkill4.Size = New System.Drawing.Size(141, 23)
        Me.TextBoxSkill4.TabIndex = 14
        '
        'TextBoxSkill3
        '
        Me.TextBoxSkill3.Location = New System.Drawing.Point(376, 317)
        Me.TextBoxSkill3.Name = "TextBoxSkill3"
        Me.TextBoxSkill3.Size = New System.Drawing.Size(141, 23)
        Me.TextBoxSkill3.TabIndex = 13
        '
        'TextBoxSkill2
        '
        Me.TextBoxSkill2.Location = New System.Drawing.Point(201, 317)
        Me.TextBoxSkill2.Name = "TextBoxSkill2"
        Me.TextBoxSkill2.Size = New System.Drawing.Size(141, 23)
        Me.TextBoxSkill2.TabIndex = 12
        '
        'TextBoxSkill1
        '
        Me.TextBoxSkill1.Location = New System.Drawing.Point(32, 317)
        Me.TextBoxSkill1.Name = "TextBoxSkill1"
        Me.TextBoxSkill1.Size = New System.Drawing.Size(141, 23)
        Me.TextBoxSkill1.TabIndex = 11
        '
        'LabelSkill4
        '
        Me.LabelSkill4.AutoSize = True
        Me.LabelSkill4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelSkill4.ForeColor = System.Drawing.Color.White
        Me.LabelSkill4.Location = New System.Drawing.Point(536, 291)
        Me.LabelSkill4.Name = "LabelSkill4"
        Me.LabelSkill4.Size = New System.Drawing.Size(54, 23)
        Me.LabelSkill4.TabIndex = 32
        Me.LabelSkill4.Text = "Skill4:"
        '
        'LabelSkill3
        '
        Me.LabelSkill3.AutoSize = True
        Me.LabelSkill3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelSkill3.ForeColor = System.Drawing.Color.White
        Me.LabelSkill3.Location = New System.Drawing.Point(362, 291)
        Me.LabelSkill3.Name = "LabelSkill3"
        Me.LabelSkill3.Size = New System.Drawing.Size(53, 23)
        Me.LabelSkill3.TabIndex = 30
        Me.LabelSkill3.Text = "Skill3:"
        '
        'LabelSkill2
        '
        Me.LabelSkill2.AutoSize = True
        Me.LabelSkill2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelSkill2.ForeColor = System.Drawing.Color.White
        Me.LabelSkill2.Location = New System.Drawing.Point(190, 291)
        Me.LabelSkill2.Name = "LabelSkill2"
        Me.LabelSkill2.Size = New System.Drawing.Size(53, 23)
        Me.LabelSkill2.TabIndex = 28
        Me.LabelSkill2.Text = "Skill2:"
        '
        'LabelSkill1
        '
        Me.LabelSkill1.AutoSize = True
        Me.LabelSkill1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelSkill1.ForeColor = System.Drawing.Color.White
        Me.LabelSkill1.Location = New System.Drawing.Point(21, 291)
        Me.LabelSkill1.Name = "LabelSkill1"
        Me.LabelSkill1.Size = New System.Drawing.Size(51, 23)
        Me.LabelSkill1.TabIndex = 26
        Me.LabelSkill1.Text = "Skill1:"
        '
        'TextBoxSchoolYear
        '
        Me.TextBoxSchoolYear.Location = New System.Drawing.Point(574, 263)
        Me.TextBoxSchoolYear.Name = "TextBoxSchoolYear"
        Me.TextBoxSchoolYear.Size = New System.Drawing.Size(118, 23)
        Me.TextBoxSchoolYear.TabIndex = 10
        '
        'LabelSy
        '
        Me.LabelSy.AutoSize = True
        Me.LabelSy.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelSy.ForeColor = System.Drawing.Color.White
        Me.LabelSy.Location = New System.Drawing.Point(563, 237)
        Me.LabelSy.Name = "LabelSy"
        Me.LabelSy.Size = New System.Drawing.Size(52, 23)
        Me.LabelSy.TabIndex = 24
        Me.LabelSy.Text = " Year:"
        '
        'TextBoxCourse
        '
        Me.TextBoxCourse.Location = New System.Drawing.Point(362, 263)
        Me.TextBoxCourse.Name = "TextBoxCourse"
        Me.TextBoxCourse.Size = New System.Drawing.Size(205, 23)
        Me.TextBoxCourse.TabIndex = 9
        '
        'TextBoxUniv
        '
        Me.TextBoxUniv.Location = New System.Drawing.Point(32, 265)
        Me.TextBoxUniv.Name = "TextBoxUniv"
        Me.TextBoxUniv.Size = New System.Drawing.Size(310, 23)
        Me.TextBoxUniv.TabIndex = 8
        '
        'LabelUniv
        '
        Me.LabelUniv.AutoSize = True
        Me.LabelUniv.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelUniv.ForeColor = System.Drawing.Color.White
        Me.LabelUniv.Location = New System.Drawing.Point(21, 239)
        Me.LabelUniv.Name = "LabelUniv"
        Me.LabelUniv.Size = New System.Drawing.Size(90, 23)
        Me.LabelUniv.TabIndex = 21
        Me.LabelUniv.Text = "University:"
        '
        'LabelGrad
        '
        Me.LabelGrad.AutoSize = True
        Me.LabelGrad.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelGrad.ForeColor = System.Drawing.Color.White
        Me.LabelGrad.Location = New System.Drawing.Point(348, 237)
        Me.LabelGrad.Name = "LabelGrad"
        Me.LabelGrad.Size = New System.Drawing.Size(67, 23)
        Me.LabelGrad.TabIndex = 19
        Me.LabelGrad.Text = "Course:"
        '
        'RichTextBoxAddress
        '
        Me.RichTextBoxAddress.Location = New System.Drawing.Point(32, 141)
        Me.RichTextBoxAddress.Name = "RichTextBoxAddress"
        Me.RichTextBoxAddress.Size = New System.Drawing.Size(660, 32)
        Me.RichTextBoxAddress.TabIndex = 6
        Me.RichTextBoxAddress.Text = ""
        '
        'LabelObj
        '
        Me.LabelObj.AutoSize = True
        Me.LabelObj.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelObj.ForeColor = System.Drawing.Color.White
        Me.LabelObj.Location = New System.Drawing.Point(20, 177)
        Me.LabelObj.Name = "LabelObj"
        Me.LabelObj.Size = New System.Drawing.Size(86, 23)
        Me.LabelObj.TabIndex = 16
        Me.LabelObj.Text = "Objective:"
        '
        'RichTextBoxObjective
        '
        Me.RichTextBoxObjective.Location = New System.Drawing.Point(32, 204)
        Me.RichTextBoxObjective.Name = "RichTextBoxObjective"
        Me.RichTextBoxObjective.Size = New System.Drawing.Size(660, 32)
        Me.RichTextBoxObjective.TabIndex = 7
        Me.RichTextBoxObjective.Text = ""
        '
        'LabelAddress
        '
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelAddress.ForeColor = System.Drawing.Color.White
        Me.LabelAddress.Location = New System.Drawing.Point(19, 115)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(74, 23)
        Me.LabelAddress.TabIndex = 14
        Me.LabelAddress.Text = "Address:"
        '
        'ComboBoxGender
        '
        Me.ComboBoxGender.FormattingEnabled = True
        Me.ComboBoxGender.Items.AddRange(New Object() {"", "Male", "Female"})
        Me.ComboBoxGender.Location = New System.Drawing.Point(312, 89)
        Me.ComboBoxGender.Name = "ComboBoxGender"
        Me.ComboBoxGender.Size = New System.Drawing.Size(121, 23)
        Me.ComboBoxGender.TabIndex = 4
        '
        'LabelGender
        '
        Me.LabelGender.AutoSize = True
        Me.LabelGender.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelGender.ForeColor = System.Drawing.Color.White
        Me.LabelGender.Location = New System.Drawing.Point(295, 63)
        Me.LabelGender.Name = "LabelGender"
        Me.LabelGender.Size = New System.Drawing.Size(71, 23)
        Me.LabelGender.TabIndex = 11
        Me.LabelGender.Text = "Gender:"
        '
        'TextBoxPhoneNumber
        '
        Me.TextBoxPhoneNumber.Location = New System.Drawing.Point(32, 89)
        Me.TextBoxPhoneNumber.MaxLength = 11
        Me.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber"
        Me.TextBoxPhoneNumber.Size = New System.Drawing.Size(242, 23)
        Me.TextBoxPhoneNumber.TabIndex = 3
        '
        'LabelPhoneNumber
        '
        Me.LabelPhoneNumber.AutoSize = True
        Me.LabelPhoneNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelPhoneNumber.ForeColor = System.Drawing.Color.White
        Me.LabelPhoneNumber.Location = New System.Drawing.Point(19, 63)
        Me.LabelPhoneNumber.Name = "LabelPhoneNumber"
        Me.LabelPhoneNumber.Size = New System.Drawing.Size(132, 23)
        Me.LabelPhoneNumber.TabIndex = 9
        Me.LabelPhoneNumber.Text = "Phone Number:"
        '
        'LabelBday
        '
        Me.LabelBday.AutoSize = True
        Me.LabelBday.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelBday.ForeColor = System.Drawing.Color.White
        Me.LabelBday.Location = New System.Drawing.Point(439, 63)
        Me.LabelBday.Name = "LabelBday"
        Me.LabelBday.Size = New System.Drawing.Size(78, 23)
        Me.LabelBday.TabIndex = 7
        Me.LabelBday.Text = "Birthday:"
        '
        'DateTimePickerBirthday
        '
        Me.DateTimePickerBirthday.Location = New System.Drawing.Point(484, 89)
        Me.DateTimePickerBirthday.MaxDate = New Date(2022, 7, 25, 23, 59, 59, 0)
        Me.DateTimePickerBirthday.MinDate = New Date(1909, 1, 25, 23, 59, 59, 0)
        Me.DateTimePickerBirthday.Name = "DateTimePickerBirthday"
        Me.DateTimePickerBirthday.Size = New System.Drawing.Size(207, 23)
        Me.DateTimePickerBirthday.TabIndex = 5
        Me.DateTimePickerBirthday.Value = New Date(2022, 7, 5, 1, 20, 18, 0)
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(416, 37)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(275, 23)
        Me.TextBoxEmail.TabIndex = 2
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelEmail.ForeColor = System.Drawing.Color.White
        Me.LabelEmail.Location = New System.Drawing.Point(399, 11)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(55, 23)
        Me.LabelEmail.TabIndex = 5
        Me.LabelEmail.Text = "Email:"
        '
        'ButtonPrintPDF
        '
        Me.ButtonPrintPDF.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ButtonPrintPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPrintPDF.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonPrintPDF.ForeColor = System.Drawing.Color.Red
        Me.ButtonPrintPDF.Location = New System.Drawing.Point(605, 474)
        Me.ButtonPrintPDF.Name = "ButtonPrintPDF"
        Me.ButtonPrintPDF.Size = New System.Drawing.Size(107, 28)
        Me.ButtonPrintPDF.TabIndex = 16
        Me.ButtonPrintPDF.Text = "Print to PDF"
        Me.ButtonPrintPDF.UseVisualStyleBackColor = False
        Me.ButtonPrintPDF.Visible = False
        '
        'ButtonNew
        '
        Me.ButtonNew.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ButtonNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonNew.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonNew.ForeColor = System.Drawing.Color.Black
        Me.ButtonNew.Location = New System.Drawing.Point(481, 474)
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Size = New System.Drawing.Size(107, 28)
        Me.ButtonNew.TabIndex = 17
        Me.ButtonNew.Text = "New Entry"
        Me.ButtonNew.UseVisualStyleBackColor = False
        Me.ButtonNew.Visible = False
        '
        'PDFResumeCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(763, 518)
        Me.Controls.Add(Me.ButtonNew)
        Me.Controls.Add(Me.ButtonPrintPDF)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.ButtonPoweroff)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PDFResumeCreator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PDF Resume Creator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonPoweroff As Button
    Friend WithEvents LabelTitle As Label
    Friend WithEvents TextBoxFullname As TextBox
    Friend WithEvents LabelFullname As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxSkill4 As TextBox
    Friend WithEvents TextBoxSkill3 As TextBox
    Friend WithEvents TextBoxSkill2 As TextBox
    Friend WithEvents TextBoxSkill1 As TextBox
    Friend WithEvents LabelSkill4 As Label
    Friend WithEvents LabelSkill3 As Label
    Friend WithEvents LabelSkill2 As Label
    Friend WithEvents LabelSkill1 As Label
    Friend WithEvents TextBoxSchoolYear As TextBox
    Friend WithEvents LabelSy As Label
    Friend WithEvents TextBoxCourse As TextBox
    Friend WithEvents TextBoxUniv As TextBox
    Friend WithEvents LabelUniv As Label
    Friend WithEvents LabelGrad As Label
    Friend WithEvents RichTextBoxAddress As RichTextBox
    Friend WithEvents LabelObj As Label
    Friend WithEvents RichTextBoxObjective As RichTextBox
    Friend WithEvents LabelAddress As Label
    Friend WithEvents ComboBoxGender As ComboBox
    Friend WithEvents LabelGender As Label
    Friend WithEvents TextBoxPhoneNumber As TextBox
    Friend WithEvents LabelPhoneNumber As Label
    Friend WithEvents LabelBday As Label
    Friend WithEvents DateTimePickerBirthday As DateTimePicker
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents LabelEmail As Label
    Friend WithEvents ButtonSaveasJSON As Button
    Friend WithEvents ButtonPrintPDF As Button
    Friend WithEvents ButtonNew As Button
End Class
