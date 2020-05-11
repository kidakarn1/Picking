Imports System.Runtime.InteropServices
Imports System.Data
'Imports System.Data.SqlServerCe
Imports System.Data.SqlClient
Imports System.Configuration
Module Module1
    Public check_query As Integer = 0
    Public user_id = "No data"
    Public CODE_PD As String = "No data"
    Public data_combo As String = "No data"
    Public combo_pd As String = "No data"
    Public wi As String = "No data"
    Public line As String = "no data"
    Public tag_remain_qty As String = "no data"
    Public locations As String = "no data"
    Public past_numer As String = "no data"
    Public past_name As String = "no data"
    Public check_QTY As Integer = 0
    Public bool_check_scan As String = "no data"
    Public scan_qr_part_detail As String = "no data"
    Public ck As Integer = 0
    Public check_count As Integer = 0
    Public check_count2 As Integer = 0
    Public QTY_OF_SCAN As Integer = 0
    Public QTY As Integer = 0
    Public total_database As Integer = 0
    Public total_qty As Integer = 0

    Dim myConn As SqlConnection
    Dim reader As SqlDataReader

End Module
