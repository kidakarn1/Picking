<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Select_PD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Select_PD))
        Me.Label1 = New System.Windows.Forms.Label
        Me.emp_name = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.Btb_pd_back = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.se_code_user = New System.Windows.Forms.Label
        Me.PD_hidden_dep_id = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.MintCream
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(36, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 39)
        Me.Label1.Text = "DATE:"
        '
        'emp_name
        '
        Me.emp_name.BackColor = System.Drawing.Color.MintCream
        Me.emp_name.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.emp_name.Location = New System.Drawing.Point(36, 97)
        Me.emp_name.Name = "emp_name"
        Me.emp_name.Size = New System.Drawing.Size(391, 37)
        Me.emp_name.Text = "NAME:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(476, 590)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MintCream
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Btb_pd_back)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.se_code_user)
        Me.Panel1.Controls.Add(Me.emp_name)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(17, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(442, 435)
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(345, 379)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 45)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "OK"
        '
        'Btb_pd_back
        '
        Me.Btb_pd_back.BackColor = System.Drawing.Color.Red
        Me.Btb_pd_back.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular)
        Me.Btb_pd_back.ForeColor = System.Drawing.Color.White
        Me.Btb_pd_back.Location = New System.Drawing.Point(15, 379)
        Me.Btb_pd_back.Name = "Btb_pd_back"
        Me.Btb_pd_back.Size = New System.Drawing.Size(82, 43)
        Me.Btb_pd_back.TabIndex = 6
        Me.Btb_pd_back.Text = "Back"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(69, 335)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(304, 39)
        Me.Label3.Text = "กรุณา เลือก PD ที่ต้องการ"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(69, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(309, 35)
        Me.Label2.Text = "Please Select PD :"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Regular)
        Me.ComboBox1.Location = New System.Drawing.Point(36, 273)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(369, 42)
        Me.ComboBox1.TabIndex = 3
        '
        'se_code_user
        '
        Me.se_code_user.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.se_code_user.ForeColor = System.Drawing.Color.ForestGreen
        Me.se_code_user.Location = New System.Drawing.Point(36, 155)
        Me.se_code_user.Name = "se_code_user"
        Me.se_code_user.Size = New System.Drawing.Size(391, 32)
        Me.se_code_user.Text = "CODE:"
        '
        'PD_hidden_dep_id
        '
        Me.PD_hidden_dep_id.Location = New System.Drawing.Point(344, 88)
        Me.PD_hidden_dep_id.Name = "PD_hidden_dep_id"
        Me.PD_hidden_dep_id.Size = New System.Drawing.Size(100, 20)
        Me.PD_hidden_dep_id.Text = "Label4"
        '
        'Select_PD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(474, 565)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PD_hidden_dep_id)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Select_PD"
        Me.Text = "Select_PD"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents emp_name As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents se_code_user As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Btb_pd_back As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PD_hidden_dep_id As System.Windows.Forms.Label
    Public WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
