﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class part_detail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(part_detail))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.scan_qty = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.ListBox = New System.Windows.Forms.ListBox
        Me.remain_qty = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.location = New System.Windows.Forms.Label
        Me.lot_no = New System.Windows.Forms.Label
        Me.text_tmp = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.show_qty = New System.Windows.Forms.Label
        Me.show_img = New System.Windows.Forms.PictureBox
        Me.Part_name = New System.Windows.Forms.Label
        Me.Part_No = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.lb_code_line = New System.Windows.Forms.Label
        Me.lb_code_pd = New System.Windows.Forms.Label
        Me.lb_code_user = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(470, 590)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MintCream
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.location)
        Me.Panel1.Controls.Add(Me.lot_no)
        Me.Panel1.Controls.Add(Me.text_tmp)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.show_qty)
        Me.Panel1.Controls.Add(Me.show_img)
        Me.Panel1.Controls.Add(Me.Part_name)
        Me.Panel1.Controls.Add(Me.Part_No)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.lb_code_line)
        Me.Panel1.Controls.Add(Me.lb_code_pd)
        Me.Panel1.Controls.Add(Me.lb_code_user)
        Me.Panel1.Location = New System.Drawing.Point(5, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(462, 525)
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(13, 481)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 37)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Back"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.scan_qty)
        Me.Panel3.Location = New System.Drawing.Point(22, 420)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(425, 44)
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(2, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 28)
        Me.Label4.Text = "Scan QR Code :"
        '
        'scan_qty
        '
        Me.scan_qty.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.scan_qty.Location = New System.Drawing.Point(183, 6)
        Me.scan_qty.Name = "scan_qty"
        Me.scan_qty.Size = New System.Drawing.Size(234, 32)
        Me.scan_qty.TabIndex = 30
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ListBox)
        Me.Panel2.Controls.Add(Me.remain_qty)
        Me.Panel2.Location = New System.Drawing.Point(35, 429)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(281, 34)
        '
        'ListBox
        '
        Me.ListBox.Location = New System.Drawing.Point(213, 8)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(51, 18)
        Me.ListBox.TabIndex = 46
        '
        'remain_qty
        '
        Me.remain_qty.Location = New System.Drawing.Point(3, 3)
        Me.remain_qty.Name = "remain_qty"
        Me.remain_qty.Size = New System.Drawing.Size(40, 23)
        Me.remain_qty.TabIndex = 47
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Green
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(248, 480)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 37)
        Me.Button3.TabIndex = 43
        Me.Button3.Text = "OK3"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(298, 478)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 34)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "OK2"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Green
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(369, 480)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 35)
        Me.Button4.TabIndex = 45
        Me.Button4.Text = "OK4"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(400, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 37)
        Me.Label2.Text = "ชิ้น"
        '
        'location
        '
        Me.location.BackColor = System.Drawing.Color.White
        Me.location.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.location.Location = New System.Drawing.Point(38, 386)
        Me.location.Name = "location"
        Me.location.Size = New System.Drawing.Size(318, 30)
        Me.location.Text = "Location :"
        '
        'lot_no
        '
        Me.lot_no.BackColor = System.Drawing.Color.White
        Me.lot_no.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lot_no.Location = New System.Drawing.Point(248, 330)
        Me.lot_no.Name = "lot_no"
        Me.lot_no.Size = New System.Drawing.Size(202, 22)
        Me.lot_no.Text = "Lot No."
        '
        'text_tmp
        '
        Me.text_tmp.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
        Me.text_tmp.Location = New System.Drawing.Point(328, 278)
        Me.text_tmp.Name = "text_tmp"
        Me.text_tmp.Size = New System.Drawing.Size(66, 29)
        Me.text_tmp.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(244, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 33)
        Me.Label3.Text = "จำนวน:"
        '
        'show_qty
        '
        Me.show_qty.BackColor = System.Drawing.Color.White
        Me.show_qty.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.show_qty.ForeColor = System.Drawing.Color.Red
        Me.show_qty.Location = New System.Drawing.Point(258, 225)
        Me.show_qty.Name = "show_qty"
        Me.show_qty.Size = New System.Drawing.Size(171, 32)
        Me.show_qty.Text = "Label3"
        '
        'show_img
        '
        Me.show_img.Image = CType(resources.GetObject("show_img.Image"), System.Drawing.Image)
        Me.show_img.Location = New System.Drawing.Point(35, 221)
        Me.show_img.Name = "show_img"
        Me.show_img.Size = New System.Drawing.Size(203, 144)
        '
        'Part_name
        '
        Me.Part_name.BackColor = System.Drawing.Color.White
        Me.Part_name.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Part_name.ForeColor = System.Drawing.Color.Green
        Me.Part_name.Location = New System.Drawing.Point(35, 160)
        Me.Part_name.Name = "Part_name"
        Me.Part_name.Size = New System.Drawing.Size(394, 58)
        Me.Part_name.Text = "Part Name:"
        '
        'Part_No
        '
        Me.Part_No.BackColor = System.Drawing.Color.White
        Me.Part_No.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Part_No.ForeColor = System.Drawing.Color.Blue
        Me.Part_No.Location = New System.Drawing.Point(35, 111)
        Me.Part_No.Name = "Part_No"
        Me.Part_No.Size = New System.Drawing.Size(394, 29)
        Me.Part_No.Text = "Part No:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(155, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 30)
        Me.Label1.Text = "PART DETAIL"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 69)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(456, 406)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'lb_code_line
        '
        Me.lb_code_line.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_code_line.BackColor = System.Drawing.Color.MintCream
        Me.lb_code_line.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lb_code_line.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lb_code_line.Location = New System.Drawing.Point(298, 15)
        Me.lb_code_line.Name = "lb_code_line"
        Me.lb_code_line.Size = New System.Drawing.Size(159, 35)
        Me.lb_code_line.Text = "Label2"
        '
        'lb_code_pd
        '
        Me.lb_code_pd.BackColor = System.Drawing.Color.MintCream
        Me.lb_code_pd.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lb_code_pd.ForeColor = System.Drawing.Color.Blue
        Me.lb_code_pd.Location = New System.Drawing.Point(155, 15)
        Me.lb_code_pd.Name = "lb_code_pd"
        Me.lb_code_pd.Size = New System.Drawing.Size(137, 25)
        Me.lb_code_pd.Text = "Label3"
        '
        'lb_code_user
        '
        Me.lb_code_user.BackColor = System.Drawing.Color.MintCream
        Me.lb_code_user.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lb_code_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lb_code_user.Location = New System.Drawing.Point(13, 15)
        Me.lb_code_user.Name = "lb_code_user"
        Me.lb_code_user.Size = New System.Drawing.Size(147, 25)
        Me.lb_code_user.Text = "Label1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'part_detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(473, 583)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "part_detail"
        Me.Text = "part_detail"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lb_code_line As System.Windows.Forms.Label
    Friend WithEvents lb_code_pd As System.Windows.Forms.Label
    Friend WithEvents lb_code_user As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Part_name As System.Windows.Forms.Label
    Friend WithEvents Part_No As System.Windows.Forms.Label
    Friend WithEvents text_tmp As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents show_qty As System.Windows.Forms.Label
    Friend WithEvents show_img As System.Windows.Forms.PictureBox
    Friend WithEvents location As System.Windows.Forms.Label
    Friend WithEvents lot_no As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents scan_qty As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ListBox As System.Windows.Forms.ListBox
    Friend WithEvents remain_qty As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
