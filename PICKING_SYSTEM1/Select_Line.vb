Imports System.Data.SqlClient
Imports PICKING_SYSTEM.Page_projects
Public Class Select_Line
    Dim myConn As SqlConnection
    Dim x As ListViewItem
    Dim sel_itemSpa As String = "                        "
    Dim sel_where As String = ""
    Public Part_Selected As String = ""
    Public Part_Name As String = ""
    Public lo As String = ""
    Public QTY As String = ""
    Public Lot_No As String = ""
    Public PD3 As Select_PD
    Dim wi As String = ""
    Public part As part_detail
    Private Sub selLine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            myConn = New SqlConnection("Data Source=192.168.161.101;Initial Catalog=tbkkfa01_dev;Integrated Security=False;User Id=pcs_admin;Password=P@ss!fa")
            ' myConn = New SqlConnection("Data Source=192.168.10.12\SQLEXPRESS2017,1433;Initial Catalog=tbkkfa01_dev;Integrated Security=False;User Id=sa;Password=p@sswd;")
            'myConn = New SqlConnection("Server=192.168.161.101\PCSDBSV; Database=test_db;User ID=pcs_admin;Password=P@ss!fa")
            'myConn = New SqlConnection("Data Source=192.168.1.116;Initial Catalog=tbkkfa01_dev;Integrated Security=False;User Id=pcs_admin;Password=P@ss!fa")
            myConn.Open()
        Catch ex As Exception
            MsgBox("Connect Database Fail" & vbNewLine & ex.Message, 16, "Status line")
        Finally
            'PictureBox2.Visible = True
            combobox_line()
            ComboBox1.SelectedIndex = 0
            Dim page As Page_projects = New Page_projects()

            Line_PD.Text = Module1.CODE_PD
            Line_Emp_cd.Text = main.show_code_id_user()
            'PictureBox2.Visible = False
            'Me.emp_cd.Focus()
        End Try



    End Sub
    Dim reader As SqlDataReader
    Dim dat As String = String.Empty
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Line_list_view.Items.Clear()
        sel_where = ComboBox1.SelectedItem.ToString()
        Module1.line = sel_where
        Try

            Dim strCommand As String = "SELECT item_cd, wi, qty  FROM sup_work_plan_supply_dev WHERE line_cd  = '" & sel_where & "' AND (ps_unit_numerator <> '' AND location_part <> '') AND pick_flg != 1 AND WORK_ODR_DLV_DATE BETWEEN CAST(GETDATE() AS DATE) AND DATEADD(DAY, 4, CAST(GETDATE() AS DATE)) ORDER BY wi ASC"
            'Dim strCommand As String = "SELECT item_cd, wi, qty  FROM sup_work_plan_supply_dev WHERE line_cd  = '" & sel_where & "'and item_cd = '898248-1601' and pick_flg != 1 ORDER BY wi ASC"
            Dim command As SqlCommand = New SqlCommand(strCommand, myConn)
            reader = command.ExecuteReader()
            Dim num As Integer
            num = 0
            'Dim LI As New ListViewItem 'new obj ''
            Do While reader.Read = True
                x = New ListViewItem(reader("item_cd").ToString)
                x.SubItems.Add(reader("wi").ToString)
                x.SubItems.Add(reader("qty").ToString)
                Line_list_view.Items.Add(x)
                num = num + 1
            Loop
            reader.Close()
            'scan_pick.line_cd.Text = sel_where '
            'part_detail.line_cd.Text = sel_where '
        Catch ex As Exception
            MsgBox("Connect Database Fail" & vbNewLine & ex.Message, 16, "Status in")
        Finally
            'MsgBox("OK")
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Line_list_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Line_list_view_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Line_list_view.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Line_list_view.Items.Clear()
        Dim page As Page_projects = New Page_projects()
        page.PD.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        Try
            query_detail_location()

            If Module1.check_query = 1 Then
                Dim p_scan As scan_location = New scan_location()
                p_scan.PD4 = Me
                p_scan.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox("Please select Part")
        Finally
        End Try
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Line_PD_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Line_PD.ParentChanged

    End Sub

    Private Sub Line_Emp_cd_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Line_Emp_cd.ParentChanged

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Public Function given_code_line() As String
        Dim data = "LINE: " + sel_where
        Return data
    End Function

    Public Function get_pd() As String
        Return PD3.give_value_code_pd
    End Function

    Public Function query_detail_location() As String
        Try
            Dim code_line = sel_where
            Dim code_part = Line_list_view.FocusedItem.SubItems(0).Text
            Dim code_wi = Line_list_view.FocusedItem.SubItems(1).Text
            Module1.wi = code_wi
            Dim strCommand As String = "SELECT item_cd, item_name , qty , location_part , wi FROM sup_work_plan_supply_dev WHERE line_cd  = '" & code_line & "' AND item_cd = '" & code_part & "'AND wi  = '" & code_wi & "' AND (ps_unit_numerator <> '' AND location_part <> '') AND pick_flg != 1 AND WORK_ODR_DLV_DATE BETWEEN CAST(GETDATE() AS DATE) AND DATEADD(DAY, 4, CAST(GETDATE() AS DATE)) ORDER BY wi ASC"
            'Dim strCommand As String = "SELECT item_cd, item_name , qty , location_part , wi FROM sup_work_plan_supply_dev WHERE line_cd  = '" & code_line & "' AND item_cd = '" & code_part & "'AND wi  = '" & code_wi & "' ORDER BY wi ASC"
            'MsgBox(strCommand)
            Dim command As SqlCommand = New SqlCommand(strCommand, myConn)
            reader = command.ExecuteReader()
            Do While reader.Read()
                Part_Selected = reader.Item(0)
                Part_Name = reader.Item(1)
                lo = reader.Item(3)
                QTY = reader.Item(2)
                wi = reader.Item(4)
                Lot_No = "    -    "
                Module1.check_QTY = QTY
                Module1.past_name = Part_Name
                Module1.locations = lo
                ' scan_location.Text_wi_cd.Text = reader.Item(4)

                'part_detail.item_cd.Text = reader.Item(0)
                'part_detail.item_name.Text = reader.Item(1)
                ' part_detail.req_qty.Text = reader.Item(2)
                ' part_detail.location_de.Text = reader.Item(3)
                'part_detail.lot_no.Text = "    -    "
            Loop

            'scan_location.loc_scan_txt.Focus()

            reader.Close()
            Module1.check_query = 1
        Catch
            Module1.check_query = 0
            MsgBox("Please select Part")
        End Try

        Return 0
    End Function
    Public Function get_Part_Selected() As String
        Dim data = "Part_Selected : " + Part_Selected
        Return data
    End Function

    Public Function get_Part_Name() As String
        Dim data = "Part_Name : " + Part_Name
        Return data
    End Function

    Public Function get_Location() As String
        Dim data = "Location : " + lo
        Return data
    End Function

    Public Function get_QTY() As String
        Dim data = "QTY : " + QTY
        Return data
    End Function

    Public Function get_Lot_No() As String
        Dim data = "Lot No : " + Lot_No
        Return data
    End Function
    Public Function get_wi() As String
        Dim data = wi
        Return data
    End Function

    Private Sub Lb2_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lb2.ParentChanged

    End Sub
    Public Sub combobox_line()
        Dim subSelpd = Module1.data_combo
        Dim strCommand As String = "SELECT DISTINCT line_cd from sup_work_plan_supply_dev where pd like '%" & subSelpd & "%' order by line_cd asc"
        Dim command As SqlCommand = New SqlCommand(strCommand, myConn)
        reader = command.ExecuteReader()
        Dim num As Integer
        num = 0
        Do While reader.Read()
            ComboBox1.Items.Add(reader.Item(0))
            num = num + 1
        Loop
        reader.Close()
    End Sub
End Class