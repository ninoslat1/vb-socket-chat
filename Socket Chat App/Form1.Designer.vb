<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Button3 = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        BackgroundWorker2 = New ComponentModel.BackgroundWorker()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(682, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 50)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(738, 12)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(50, 50)
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Constantia", 20.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(37, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 33)
        Label1.TabIndex = 3
        Label1.Text = "Server"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Constantia", 14F, FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(37, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(27, 23)
        Label2.TabIndex = 4
        Label2.Text = "IP"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Constantia", 14F, FontStyle.Italic, GraphicsUnit.Point)
        Label3.Location = New Point(37, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 23)
        Label3.TabIndex = 5
        Label3.Text = "Port"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Constantia", 14F, FontStyle.Italic, GraphicsUnit.Point)
        Label4.Location = New Point(356, 178)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 23)
        Label4.TabIndex = 8
        Label4.Text = "Port"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Constantia", 14F, FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(356, 138)
        Label5.Name = "Label5"
        Label5.Size = New Size(27, 23)
        Label5.TabIndex = 7
        Label5.Text = "IP"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Constantia", 20F, FontStyle.Italic, GraphicsUnit.Point)
        Label6.Location = New Point(356, 88)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 33)
        Label6.TabIndex = 6
        Label6.Text = "Client"
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(116, 138)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(192, 16)
        TextBox1.TabIndex = 9
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Location = New Point(116, 181)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(192, 16)
        TextBox2.TabIndex = 10
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Location = New Point(429, 181)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(192, 16)
        TextBox3.TabIndex = 12
        ' 
        ' TextBox4
        ' 
        TextBox4.BorderStyle = BorderStyle.None
        TextBox4.Location = New Point(429, 138)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(192, 16)
        TextBox4.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(173, 233)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 13
        Button1.Text = "Start"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(482, 233)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 14
        Button2.Text = "Connect"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox5
        ' 
        TextBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TextBox5.BorderStyle = BorderStyle.None
        TextBox5.Location = New Point(37, 284)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(735, 555)
        TextBox5.TabIndex = 15
        ' 
        ' TextBox6
        ' 
        TextBox6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TextBox6.BorderStyle = BorderStyle.None
        TextBox6.Location = New Point(37, 876)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(584, 68)
        TextBox6.TabIndex = 16
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.Location = New Point(639, 876)
        Button3.Name = "Button3"
        Button3.Size = New Size(133, 68)
        Button3.TabIndex = 17
        Button3.Text = "Send Message"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' BackgroundWorker1
        ' 
        ' 
        ' BackgroundWorker2
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 972)
        Controls.Add(Button3)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker

End Class
