Imports System.Net.Sockets
Imports System.IO
Imports System.Net

Public Class Form1
    Private Client As TcpClient
    Public Reader As StreamReader
    Public Writer As StreamWriter
    Public receivedMessage As String
    Public sendMessage As String
    Private isDragging As Boolean = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim LocalIP As IPAddress() = Dns.GetHostAddresses(Dns.GetHostName)

        For Each address As IPAddress In LocalIP
            If address.AddressFamily = AddressFamily.InterNetwork Then
                TextBox1.Text = address.ToString()
                TextBox4.Text = address.ToString()
            End If
        Next
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim res As Boolean

        res = MessageBox.Show("Are you sure want to exit the apps?", "Exit App", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If res = True Then
            Application.Exit()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim listener As New TcpListener(IPAddress.Any, Integer.Parse(TextBox2.Text))
        listener.Start()
        Client = listener.AcceptTcpClient()
        Reader = New StreamReader(Client.GetStream())
        Writer = New StreamWriter(Client.GetStream())
        Writer.AutoFlush = True
        BackgroundWorker1.RunWorkerAsync()
        BackgroundWorker2.WorkerSupportsCancellation = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Client = New TcpClient()
        Dim Endpoint As New IPEndPoint(IPAddress.Parse(TextBox4.Text), Integer.Parse(TextBox3.Text))
        Try
            Client.Connect(Endpoint)
            If (Client.Connected) Then
                TextBox5.AppendText("Connected to Server " + Environment.NewLine)
                Writer = New StreamWriter(Client.GetStream())
                Reader = New StreamReader(Client.GetStream())
                Writer.AutoFlush = True
                BackgroundWorker1.RunWorkerAsync()
                BackgroundWorker2.WorkerSupportsCancellation = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        While (Client.Connected)
            Try
                receivedMessage = Reader.ReadLine()
                Me.TextBox5.Invoke(New MethodInvoker(Function()
                                                         TextBox5.AppendText("You: " + receivedMessage + Environment.NewLine)
                                                     End Function))
                receivedMessage = ""
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString())
            End Try
        End While
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        If (Client.Connected) Then
            Writer.WriteLine(sendMessage)
            Me.TextBox5.Invoke(New MethodInvoker(Function()
                                                     TextBox5.AppendText("Me: " + sendMessage + Environment.NewLine)
                                                 End Function))
            sendMessage = ""
        Else
            MessageBox.Show("Message failed to sent")
        End If

        BackgroundWorker2.CancelAsync()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (TextBox6.Text <> "") Then
            sendMessage = TextBox6.Text
            BackgroundWorker2.RunWorkerAsync()
        End If

        TextBox6.Text = ""
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            Me.Capture = True
            Me.Cursor = Cursors.SizeAll
        End If
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If isDragging Then
            Me.Location = New Point(Me.Left + e.X, +Me.Top + e.Y)
        End If
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            isDragging = False
            Me.Capture = False
            Me.Cursor = Cursors.Default
        End If
    End Sub
End Class
