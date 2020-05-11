Imports System.Runtime.InteropServices
Imports System.Data
'Imports System.Data.SqlServerCe
Imports System.Data.SqlClient
Imports System.Configuration
Public Class main
    Public scan_terminal_id = "PICK001"
    Dim myConn As SqlConnection
    Dim path As String
    Public Str As String
    Public count_emp_id As Integer
    Dim imagefile As String
    Public pd_of_user As String
    Public passToanofrm As String
    Public empToanofrm As String
    Public code_id_user As String
    Public pd_user As String
    Public valSel As Array
    Public strData(,) As String
    Public miscData() As Object = {}
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'myConn = New SqlConnection("Data Source=192.168.10.12\SQLEXPRESS2017,1433;Initial Catalog=tbkkfa01_dev;Integrated Security=False;User Id=sa;Password=p@sswd;")
            myConn = New SqlConnection("Data Source=192.168.161.101;Initial Catalog=tbkkfa01_dev;Integrated Security=False;User Id=pcs_admin;Password=P@ss!fa")
            'Server= localhost; Database= employeedetails; Integrated Security=True;
            'Data Source=192.168.10.16\SQLEXPRESS,1433;Initial Catalog=tbkkfa01_dev;Integrated Security=SSPI;
            myConn.Open()
        Catch ex As Exception

            MsgBox("Connect Database Fail" & vbNewLine & ex.Message, 16, "Status in ")
        Finally
            Me.emp_cd.Focus()
        End Try
    End Sub

    Private Sub Label1_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
    End Sub

    Private Sub Label1_ParentChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.ParentChanged
        Label2.Text = "DATE" + ": " + DateTime.Now.ToString("dd-MM-yyyy")

    End Sub

    Private Sub Panel1_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel1.GotFocus
        Panel1.Parent = PictureBox1
        Panel1.BackColor = Color.Transparent
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Dim reader As SqlDataReader
    Dim dat As String = String.Empty

    Private Sub emp_cd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emp_cd.TextChanged
        Str = emp_cd.Text
        If Str.Length() = 5 Then
            query_user()
        End If
    End Sub

    Public Function show_code_id_user() As String
        Return code_id_user
    End Function

    Public Sub query_user()
        Try
            'ProgressBar1.Show()
            'Dim strCommand As String = "SELECT * FROM sys_users"
            Dim strCommand As String = "SELECT * FROM sys_users WHERE emp_id = " & "'" & Str & "'"
            'MsgBox(strCommand)
            Dim command As SqlCommand = New SqlCommand(strCommand, myConn)
            reader = command.ExecuteReader()
            Do While reader.Read()
                dat = reader.Item(2) & " " & reader.Item(3)
                passToanofrm = dat
                'System.Console.WriteLine("===>" + reader.Item(1))'
                code_id_user = "CODE : " + reader.Item(1)
                empToanofrm = "Name:  " + reader("firstname").ToString & " " & reader("lastname").ToString
                count_emp_id = 1
                pd_user = reader("dep_id").ToString()
            Loop
            reader.Close()
        Catch ex As Exception
            MsgBox("Connect Database Fail" & vbNewLine & ex.Message, 16, "Status")
        Finally
            'Select_PD.emp_name.Text = empToanofrm'
            'Select_PD.se_code_user.Text = code_id_user '
            'Select_Line.Line_Emp_cd.Text = code_id_user ' 'แสดงในหน้า Select_line'
            'Select_PD.PD_hidden_dep_id.Text = pd_user - 1 'ส่ง PD user ไปหน้า select_pd'
            ' Select_PD.ComboBox1.SelectedIndex = 0'
            'Select_PD.emp_cd.Text = empToanofrm '
            'Select_PD.emp_cd.Text = empToanofrm '
            emp_cd.Text = ""
            'System.Console.WriteLine(count_emp_id)'
            If count_emp_id = 0 Then
                MessageBox.Show("SORRY CODE_ID FAIL")
                'ProgressBar1.Hide()
                'MsgBox("NO CODE_ID")'
            Else
                Dim PD As Select_PD = New Select_PD()
                PD.Show()
                Me.Hide()
            End If
        End Try
    End Sub
    

    Public Function show_empToanofrm() As String
        Return empToanofrm
    End Function

    Private Sub Label1_ParentChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.ParentChanged

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub WebBrowser2_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)
        'WebBrowser2_DocumentCompleted = "https://gfycat.com/stickers/search/b%C3%ACnh+d%C6%B0%C6%A1ng"
    End Sub

    Private Sub ProgressBar1_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class