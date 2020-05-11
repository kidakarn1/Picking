Imports System.Data.SqlClient
Imports PICKING_SYSTEM.connect
Public Class scan_location
    Dim myConn As SqlConnection
    Public PD4 As Select_Line
    Dim path As String
    Dim imagefile As String
    Dim a As Boolean
    Public getwi As String = "wi_null"
    Private Sub scan_location_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            getwi = PD4.get_wi()
            ' myConn = New SqlConnection("Data Source=192.168.10.12\SQLEXPRESS2017,1433;Initial Catalog=tbkkfa01_dev;Integrated Security=False;User Id=sa;Password=p@sswd;")
            myConn = New SqlConnection("Data Source=192.168.161.101;Initial Catalog=tbkkfa01_dev;Integrated Security=False;User Id=pcs_admin;Password=P@ss!fa")

            ' myConn = New SqlConnection("Data Source=192.168.1.116;Initial Catalog=tbkkfa01_dev;Integrated Security=False;User Id=pcs_admin;Password=P@ss!fa")
            myConn.Open()
        Catch ex As Exception
            MsgBox("Connect Database Fail" & vbNewLine & ex.Message, 16, "Status scan")
        Finally
            Button1.Hide()
            path = Me.GetType().Assembly.GetModules()(0).FullyQualifiedName
            Dim en As Int32 = path.LastIndexOf("\")
            path = path.Substring(0, en)
            Me.text_box_location.Focus()
            lb_code_user.Text = main.show_code_id_user()
            lb_code_pd.Text = Module1.CODE_PD
            lb_code_line.Text = PD4.given_code_line()
            Part_Selected.Text = PD4.get_Part_Selected()
            Part_Name.Text = PD4.get_Part_Name()
            Location.Text = PD4.get_Location()
            QTY.Text = PD4.get_QTY()
            Lot_No.Text = PD4.get_Lot_No
            'MsgBox("LOAD SCAN LOCATION")
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        Dim Line As Select_Line = New Select_Line()

        PD4.Show()
        Me.Close()
    End Sub

    Private Sub lb_code_user_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_code_user.ParentChanged

    End Sub


    Private Sub Label1_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_code_line.ParentChanged

    End Sub

    Private Sub lb_code_pd_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_code_pd.ParentChanged

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Part_Selected_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Part_Selected.ParentChanged

    End Sub

    Private Sub QTY_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QTY.ParentChanged

    End Sub

    Private Sub text_box_location_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_box_location.TextChanged
        System.Windows.Forms.Application.DoEvents()
        Try

            Dim sub_box = text_box_location.Text
            Dim loc_val As String = Location.Text.Substring(11)
            Dim ps = Part_Selected.Text.Substring(16)
            Module1.past_numer = ps
            Dim length_of_text_box As Integer
            length_of_text_box = (ps.Length() + loc_val.Length()) + 6
            'MsgBox(length_of_text_box)
            'MsgBox(sub_box.Length())
            Dim sub_box_length As Integer
            sub_box_length = sub_box.Length() + 6
            'MsgBox(sub_box_length)
            a = (length_of_text_box = sub_box_length)
            'If length_of_text_box = sub_box_length Then
            Dim val_box = sub_box.Split(" ")
            Dim part = val_box(0)
            Dim loca = val_box(6)
            If part = ps Then
                If loca = loc_val Then
                    Button1.Show()
                Else
                    ' MsgBox("location Faill")
                    text_box_location.Text = ""
                    Button1.Hide()
                End If
            Else
                '  MsgBox("Part Faill")
                text_box_location.Text = ""
                Button1.Hide()
            End If
            'End If
        Catch ex As Exception
            ' MsgBox("scan faill")
        End Try


    End Sub


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim SearchWithinThis As String = text_box_location.Text
        check()

    End Sub

    Private Sub Location_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Location.ParentChanged

    End Sub
    Public Sub check()
        ' MsgBox("In check")
        Dim part_de As part_detail = New part_detail()
        part_de.PD5 = Me
        part_de.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel1.GotFocus

    End Sub

    Private Sub Label1_ParentChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.ParentChanged

    End Sub

    Private Sub Part_Name_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Part_Name.ParentChanged

    End Sub

    Private Sub Lot_No_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lot_No.ParentChanged

    End Sub
End Class