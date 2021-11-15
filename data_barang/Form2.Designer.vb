<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.harga = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.stok = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bhapus = New System.Windows.Forms.Button()
        Me.bkosong = New System.Windows.Forms.Button()
        Me.bsimpan = New System.Windows.Forms.Button()
        Me.dg1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.TextBox()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.tanggal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'harga
        '
        Me.harga.Location = New System.Drawing.Point(178, 160)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(306, 20)
        Me.harga.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(83, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "harga_pokok      :"
        '
        'stok
        '
        Me.stok.Location = New System.Drawing.Point(178, 135)
        Me.stok.Name = "stok"
        Me.stok.Size = New System.Drawing.Size(306, 20)
        Me.stok.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(83, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "stok_produk       :"
        '
        'bhapus
        '
        Me.bhapus.BackColor = System.Drawing.Color.SpringGreen
        Me.bhapus.Location = New System.Drawing.Point(442, 341)
        Me.bhapus.Name = "bhapus"
        Me.bhapus.Size = New System.Drawing.Size(93, 25)
        Me.bhapus.TabIndex = 25
        Me.bhapus.Text = "hapus"
        Me.bhapus.UseVisualStyleBackColor = False
        '
        'bkosong
        '
        Me.bkosong.BackColor = System.Drawing.Color.Honeydew
        Me.bkosong.Location = New System.Drawing.Point(335, 341)
        Me.bkosong.Name = "bkosong"
        Me.bkosong.Size = New System.Drawing.Size(93, 25)
        Me.bkosong.TabIndex = 24
        Me.bkosong.Text = "kosongkan"
        Me.bkosong.UseVisualStyleBackColor = False
        '
        'bsimpan
        '
        Me.bsimpan.BackColor = System.Drawing.Color.LightSkyBlue
        Me.bsimpan.Location = New System.Drawing.Point(38, 341)
        Me.bsimpan.Name = "bsimpan"
        Me.bsimpan.Size = New System.Drawing.Size(93, 25)
        Me.bsimpan.TabIndex = 23
        Me.bsimpan.Text = "simpan"
        Me.bsimpan.UseVisualStyleBackColor = False
        '
        'dg1
        '
        Me.dg1.BackgroundColor = System.Drawing.Color.LightPink
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(12, 188)
        Me.dg1.Name = "dg1"
        Me.dg1.Size = New System.Drawing.Size(547, 147)
        Me.dg1.TabIndex = 22
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(178, 56)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(306, 20)
        Me.id.TabIndex = 21
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(178, 82)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(306, 20)
        Me.nama.TabIndex = 20
        '
        'tanggal
        '
        Me.tanggal.Location = New System.Drawing.Point(178, 108)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(306, 20)
        Me.tanggal.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(81, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "tanggal_masuk   :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(82, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "nama_barang     :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(82, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "id_barang           :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightCyan
        Me.Label1.Location = New System.Drawing.Point(222, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "INPUT_DATA_BARANG"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(571, 24)
        Me.MenuStrip1.TabIndex = 30
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EXITToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(571, 378)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.stok)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bhapus)
        Me.Controls.Add(Me.bkosong)
        Me.Controls.Add(Me.bsimpan)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents harga As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents stok As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents bhapus As Button
    Friend WithEvents bkosong As Button
    Friend WithEvents bsimpan As Button
    Friend WithEvents dg1 As DataGridView
    Friend WithEvents id As TextBox
    Friend WithEvents nama As TextBox
    Friend WithEvents tanggal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
End Class
