<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txt_no = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_tampil = New System.Windows.Forms.Button()
        Me.btn_clr = New System.Windows.Forms.Button()
        Me.check_kecil = New System.Windows.Forms.CheckBox()
        Me.check_besar = New System.Windows.Forms.CheckBox()
        Me.TextBox_cari = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_no
        '
        Me.txt_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_no.Location = New System.Drawing.Point(57, 11)
        Me.txt_no.Name = "txt_no"
        Me.txt_no.Size = New System.Drawing.Size(60, 20)
        Me.txt_no.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nomer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama"
        '
        'txt_nama
        '
        Me.txt_nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nama.Location = New System.Drawing.Point(57, 37)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(133, 20)
        Me.txt_nama.TabIndex = 2
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(57, 199)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(219, 158)
        Me.ListBox1.TabIndex = 4
        '
        'btn_simpan
        '
        Me.btn_simpan.BackgroundImage = CType(resources.GetObject("btn_simpan.BackgroundImage"), System.Drawing.Image)
        Me.btn_simpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_simpan.Location = New System.Drawing.Point(57, 63)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(45, 39)
        Me.btn_simpan.TabIndex = 5
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_tampil
        '
        Me.btn_tampil.BackgroundImage = CType(resources.GetObject("btn_tampil.BackgroundImage"), System.Drawing.Image)
        Me.btn_tampil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_tampil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tampil.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_tampil.Location = New System.Drawing.Point(231, 154)
        Me.btn_tampil.Name = "btn_tampil"
        Me.btn_tampil.Size = New System.Drawing.Size(45, 39)
        Me.btn_tampil.TabIndex = 6
        Me.btn_tampil.UseVisualStyleBackColor = True
        '
        'btn_clr
        '
        Me.btn_clr.BackColor = System.Drawing.Color.Transparent
        Me.btn_clr.BackgroundImage = CType(resources.GetObject("btn_clr.BackgroundImage"), System.Drawing.Image)
        Me.btn_clr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_clr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clr.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_clr.Location = New System.Drawing.Point(155, 363)
        Me.btn_clr.Name = "btn_clr"
        Me.btn_clr.Size = New System.Drawing.Size(61, 39)
        Me.btn_clr.TabIndex = 7
        Me.btn_clr.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_clr.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_clr.UseVisualStyleBackColor = False
        '
        'check_kecil
        '
        Me.check_kecil.AutoSize = True
        Me.check_kecil.Location = New System.Drawing.Point(298, 199)
        Me.check_kecil.Name = "check_kecil"
        Me.check_kecil.Size = New System.Drawing.Size(85, 17)
        Me.check_kecil.TabIndex = 8
        Me.check_kecil.Text = "Kecil - Besar"
        Me.check_kecil.UseVisualStyleBackColor = True
        '
        'check_besar
        '
        Me.check_besar.AutoSize = True
        Me.check_besar.Location = New System.Drawing.Point(298, 222)
        Me.check_besar.Name = "check_besar"
        Me.check_besar.Size = New System.Drawing.Size(85, 17)
        Me.check_besar.TabIndex = 9
        Me.check_besar.Text = "Besar - Kecil"
        Me.check_besar.UseVisualStyleBackColor = True
        '
        'TextBox_cari
        '
        Me.TextBox_cari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_cari.Location = New System.Drawing.Point(76, 165)
        Me.TextBox_cari.Name = "TextBox_cari"
        Me.TextBox_cari.Size = New System.Drawing.Size(73, 20)
        Me.TextBox_cari.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(155, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 24)
        Me.Button1.TabIndex = 11
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Cari by Nama"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 409)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox_cari)
        Me.Controls.Add(Me.check_besar)
        Me.Controls.Add(Me.check_kecil)
        Me.Controls.Add(Me.btn_clr)
        Me.Controls.Add(Me.btn_tampil)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nama)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_no)
        Me.Name = "Form1"
        Me.Text = "Tugas Array"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_no As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_tampil As Button
    Friend WithEvents btn_clr As Button
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents check_kecil As CheckBox
    Friend WithEvents check_besar As CheckBox
    Friend WithEvents TextBox_cari As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
End Class
