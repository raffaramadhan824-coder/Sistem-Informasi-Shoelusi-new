Imports System.Drawing

Namespace Shoelusi

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmKasir
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso (components IsNot Nothing) Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private Sub InitializeComponent()
            Me.tabMain = New System.Windows.Forms.TabControl()
            Me.tpPenjualan = New System.Windows.Forms.TabPage()
            Me.lblTitlePenjualan = New System.Windows.Forms.Label()
            Me.pnlPenjualan = New System.Windows.Forms.Panel()
            Me.lbltxtPenjualanKode = New System.Windows.Forms.Label()
            Me.txtPenjualanKode = New System.Windows.Forms.TextBox()
            Me.lbltxtPenjualanPesanan = New System.Windows.Forms.Label()
            Me.txtPenjualanPesanan = New System.Windows.Forms.TextBox()
            Me.lbltxtPenjualanTanggal = New System.Windows.Forms.Label()
            Me.dtpPenjualanTanggal = New System.Windows.Forms.DateTimePicker()
            Me.lbltxtPenjualanTotal = New System.Windows.Forms.Label()
            Me.txtPenjualanTotal = New System.Windows.Forms.TextBox()
            Me.lbltxtPenjualanMetode = New System.Windows.Forms.Label()
            Me.lbltxtPenjualanJumlah = New System.Windows.Forms.Label()
            Me.txtPenjualanMetode = New System.Windows.Forms.TextBox()
            Me.txtPenjualanJumlah = New System.Windows.Forms.TextBox()
            Me.btnTambahPenjualan = New System.Windows.Forms.Button()
            Me.btnUbahPenjualan = New System.Windows.Forms.Button()
            Me.btnHapusPenjualan = New System.Windows.Forms.Button()
            Me.btnBersihkanPenjualan = New System.Windows.Forms.Button()
            Me.dgvPenjualan = New System.Windows.Forms.DataGridView()
            Me.dgvPenjualanCol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPenjualanCol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPenjualanCol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPenjualanCol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPenjualanCol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.tpPesanan = New System.Windows.Forms.TabPage()
            Me.lblTitlePesanan = New System.Windows.Forms.Label()
            Me.pnlPesanan = New System.Windows.Forms.Panel()
            Me.lbltxtPesananNo = New System.Windows.Forms.Label()
            Me.txtPesananNo = New System.Windows.Forms.TextBox()
            Me.lbltxtPesananPelanggan = New System.Windows.Forms.Label()
            Me.txtPesananPelanggan = New System.Windows.Forms.TextBox()
            Me.lbltxtPesananLayanan = New System.Windows.Forms.Label()
            Me.txtPesananLayanan = New System.Windows.Forms.TextBox()
            Me.lbltxtPesananTanggal = New System.Windows.Forms.Label()
            Me.dtpPesananTanggal = New System.Windows.Forms.DateTimePicker()
            Me.lbltxtPesananStatus = New System.Windows.Forms.Label()
            Me.txtPesananStatus = New System.Windows.Forms.TextBox()
            Me.btnTambahPesanan = New System.Windows.Forms.Button()
            Me.btnUbahPesanan = New System.Windows.Forms.Button()
            Me.btnHapusPesanan = New System.Windows.Forms.Button()
            Me.btnBersihkanPesanan = New System.Windows.Forms.Button()
            Me.dgvPesanan = New System.Windows.Forms.DataGridView()
            Me.dgvPesananCol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPesananCol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPesananCol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPesananCol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPesananCol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.tpCekLayanan = New System.Windows.Forms.TabPage()
            Me.lblTitleCekLayanan = New System.Windows.Forms.Label()
            Me.txtCariCekLayanan = New System.Windows.Forms.TextBox()
            Me.lblCariCekLayanan = New System.Windows.Forms.Label()
            Me.dgvCekLayanan = New System.Windows.Forms.DataGridView()
            Me.dgvCekLayananCol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvCekLayananCol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvCekLayananCol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvCekLayananCol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvCekLayananCol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.tpCekPengerjaan = New System.Windows.Forms.TabPage()
            Me.lblTitleCekPengerjaan = New System.Windows.Forms.Label()
            Me.txtCariCekPengerjaan = New System.Windows.Forms.TextBox()
            Me.lblCariCekPengerjaan = New System.Windows.Forms.Label()
            Me.dgvCekPengerjaan = New System.Windows.Forms.DataGridView()
            Me.dgvCekPengerjaanCol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvCekPengerjaanCol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvCekPengerjaanCol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvCekPengerjaanCol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvCekPengerjaanCol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvCekPengerjaanCol6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblBrand = New System.Windows.Forms.Label()
            Me.lblActor = New System.Windows.Forms.Label()
            Me.btnLogout = New System.Windows.Forms.Button()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.TextBox3 = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.TextBox4 = New System.Windows.Forms.TextBox()
            Me.TextBox5 = New System.Windows.Forms.TextBox()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.Button4 = New System.Windows.Forms.Button()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.TextBox7 = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.TextBox8 = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.TextBox9 = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.ComboBox1 = New System.Windows.Forms.ComboBox()
            Me.ComboBox2 = New System.Windows.Forms.ComboBox()
            Me.tabMain.SuspendLayout()
            Me.tpPenjualan.SuspendLayout()
            Me.pnlPenjualan.SuspendLayout()
            CType(Me.dgvPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpPesanan.SuspendLayout()
            Me.pnlPesanan.SuspendLayout()
            CType(Me.dgvPesanan, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpCekLayanan.SuspendLayout()
            CType(Me.dgvCekLayanan, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpCekPengerjaan.SuspendLayout()
            CType(Me.dgvCekPengerjaan, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'tabMain
            '
            Me.tabMain.Controls.Add(Me.tpPenjualan)
            Me.tabMain.Controls.Add(Me.tpPesanan)
            Me.tabMain.Controls.Add(Me.tpCekLayanan)
            Me.tabMain.Controls.Add(Me.tpCekPengerjaan)
            Me.tabMain.Controls.Add(Me.TabPage1)
            Me.tabMain.Cursor = System.Windows.Forms.Cursors.Default
            Me.tabMain.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tabMain.Location = New System.Drawing.Point(20, 100)
            Me.tabMain.Name = "tabMain"
            Me.tabMain.SelectedIndex = 0
            Me.tabMain.Size = New System.Drawing.Size(1210, 590)
            Me.tabMain.TabIndex = 3
            '
            'tpPenjualan
            '
            Me.tpPenjualan.BackColor = System.Drawing.Color.CadetBlue
            Me.tpPenjualan.Controls.Add(Me.lblTitlePenjualan)
            Me.tpPenjualan.Controls.Add(Me.pnlPenjualan)
            Me.tpPenjualan.Controls.Add(Me.dgvPenjualan)
            Me.tpPenjualan.Location = New System.Drawing.Point(4, 28)
            Me.tpPenjualan.Name = "tpPenjualan"
            Me.tpPenjualan.Size = New System.Drawing.Size(1202, 558)
            Me.tpPenjualan.TabIndex = 0
            Me.tpPenjualan.Text = "Penjualan"
            '
            'lblTitlePenjualan
            '
            Me.lblTitlePenjualan.BackColor = System.Drawing.Color.Transparent
            Me.lblTitlePenjualan.Font = New System.Drawing.Font("Bookman Old Style", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitlePenjualan.ForeColor = System.Drawing.Color.White
            Me.lblTitlePenjualan.Location = New System.Drawing.Point(532, 0)
            Me.lblTitlePenjualan.Name = "lblTitlePenjualan"
            Me.lblTitlePenjualan.Size = New System.Drawing.Size(255, 52)
            Me.lblTitlePenjualan.TabIndex = 0
            Me.lblTitlePenjualan.Text = "PENJUALAN"
            Me.lblTitlePenjualan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlPenjualan
            '
            Me.pnlPenjualan.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.pnlPenjualan.Controls.Add(Me.lbltxtPenjualanKode)
            Me.pnlPenjualan.Controls.Add(Me.txtPenjualanKode)
            Me.pnlPenjualan.Controls.Add(Me.lbltxtPenjualanPesanan)
            Me.pnlPenjualan.Controls.Add(Me.txtPenjualanPesanan)
            Me.pnlPenjualan.Controls.Add(Me.lbltxtPenjualanTanggal)
            Me.pnlPenjualan.Controls.Add(Me.dtpPenjualanTanggal)
            Me.pnlPenjualan.Controls.Add(Me.lbltxtPenjualanTotal)
            Me.pnlPenjualan.Controls.Add(Me.txtPenjualanTotal)
            Me.pnlPenjualan.Controls.Add(Me.lbltxtPenjualanMetode)
            Me.pnlPenjualan.Controls.Add(Me.lbltxtPenjualanJumlah)
            Me.pnlPenjualan.Controls.Add(Me.txtPenjualanMetode)
            Me.pnlPenjualan.Controls.Add(Me.txtPenjualanJumlah)
            Me.pnlPenjualan.Controls.Add(Me.btnTambahPenjualan)
            Me.pnlPenjualan.Controls.Add(Me.btnUbahPenjualan)
            Me.pnlPenjualan.Controls.Add(Me.btnHapusPenjualan)
            Me.pnlPenjualan.Controls.Add(Me.btnBersihkanPenjualan)
            Me.pnlPenjualan.Location = New System.Drawing.Point(20, 55)
            Me.pnlPenjualan.Name = "pnlPenjualan"
            Me.pnlPenjualan.Size = New System.Drawing.Size(1150, 160)
            Me.pnlPenjualan.TabIndex = 1
            '
            'lbltxtPenjualanKode
            '
            Me.lbltxtPenjualanKode.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPenjualanKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPenjualanKode.ForeColor = System.Drawing.Color.White
            Me.lbltxtPenjualanKode.Location = New System.Drawing.Point(15, 16)
            Me.lbltxtPenjualanKode.Name = "lbltxtPenjualanKode"
            Me.lbltxtPenjualanKode.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtPenjualanKode.TabIndex = 0
            Me.lbltxtPenjualanKode.Text = "Kode Penjualan"
            Me.lbltxtPenjualanKode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtPenjualanKode
            '
            Me.txtPenjualanKode.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtPenjualanKode.Location = New System.Drawing.Point(15, 43)
            Me.txtPenjualanKode.Name = "txtPenjualanKode"
            Me.txtPenjualanKode.Size = New System.Drawing.Size(190, 27)
            Me.txtPenjualanKode.TabIndex = 1
            '
            'lbltxtPenjualanPesanan
            '
            Me.lbltxtPenjualanPesanan.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPenjualanPesanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPenjualanPesanan.ForeColor = System.Drawing.Color.White
            Me.lbltxtPenjualanPesanan.Location = New System.Drawing.Point(217, 16)
            Me.lbltxtPenjualanPesanan.Name = "lbltxtPenjualanPesanan"
            Me.lbltxtPenjualanPesanan.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtPenjualanPesanan.TabIndex = 2
            Me.lbltxtPenjualanPesanan.Text = "Kode Pesanan"
            Me.lbltxtPenjualanPesanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtPenjualanPesanan
            '
            Me.txtPenjualanPesanan.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtPenjualanPesanan.Location = New System.Drawing.Point(217, 43)
            Me.txtPenjualanPesanan.Name = "txtPenjualanPesanan"
            Me.txtPenjualanPesanan.Size = New System.Drawing.Size(190, 27)
            Me.txtPenjualanPesanan.TabIndex = 3
            '
            'lbltxtPenjualanTanggal
            '
            Me.lbltxtPenjualanTanggal.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPenjualanTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPenjualanTanggal.ForeColor = System.Drawing.Color.White
            Me.lbltxtPenjualanTanggal.Location = New System.Drawing.Point(419, 16)
            Me.lbltxtPenjualanTanggal.Name = "lbltxtPenjualanTanggal"
            Me.lbltxtPenjualanTanggal.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtPenjualanTanggal.TabIndex = 4
            Me.lbltxtPenjualanTanggal.Text = "Tgl. Pengambilan"
            Me.lbltxtPenjualanTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpPenjualanTanggal
            '
            Me.dtpPenjualanTanggal.CustomFormat = "dd/MM/yyyy"
            Me.dtpPenjualanTanggal.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.dtpPenjualanTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpPenjualanTanggal.Location = New System.Drawing.Point(419, 43)
            Me.dtpPenjualanTanggal.Name = "dtpPenjualanTanggal"
            Me.dtpPenjualanTanggal.Size = New System.Drawing.Size(190, 27)
            Me.dtpPenjualanTanggal.TabIndex = 5
            '
            'lbltxtPenjualanTotal
            '
            Me.lbltxtPenjualanTotal.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPenjualanTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPenjualanTotal.ForeColor = System.Drawing.Color.White
            Me.lbltxtPenjualanTotal.Location = New System.Drawing.Point(621, 16)
            Me.lbltxtPenjualanTotal.Name = "lbltxtPenjualanTotal"
            Me.lbltxtPenjualanTotal.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtPenjualanTotal.TabIndex = 6
            Me.lbltxtPenjualanTotal.Text = "Total (Rp)"
            Me.lbltxtPenjualanTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtPenjualanTotal
            '
            Me.txtPenjualanTotal.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtPenjualanTotal.Location = New System.Drawing.Point(621, 43)
            Me.txtPenjualanTotal.Name = "txtPenjualanTotal"
            Me.txtPenjualanTotal.ReadOnly = True
            Me.txtPenjualanTotal.Size = New System.Drawing.Size(190, 27)
            Me.txtPenjualanTotal.TabIndex = 7
            '
            'lbltxtPenjualanMetode
            '
            Me.lbltxtPenjualanMetode.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPenjualanMetode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPenjualanMetode.ForeColor = System.Drawing.Color.White
            Me.lbltxtPenjualanMetode.Location = New System.Drawing.Point(823, 16)
            Me.lbltxtPenjualanMetode.Name = "lbltxtPenjualanMetode"
            Me.lbltxtPenjualanMetode.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtPenjualanMetode.TabIndex = 8
            Me.lbltxtPenjualanMetode.Text = "Status Pembayaran"
            Me.lbltxtPenjualanMetode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lbltxtPenjualanJumlah
            '
            Me.lbltxtPenjualanJumlah.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPenjualanJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPenjualanJumlah.ForeColor = System.Drawing.Color.White
            Me.lbltxtPenjualanJumlah.Location = New System.Drawing.Point(1018, 16)
            Me.lbltxtPenjualanJumlah.Name = "lbltxtPenjualanJumlah"
            Me.lbltxtPenjualanJumlah.Size = New System.Drawing.Size(119, 23)
            Me.lbltxtPenjualanJumlah.TabIndex = 20
            Me.lbltxtPenjualanJumlah.Text = "Jumlah Sepatu"
            Me.lbltxtPenjualanJumlah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtPenjualanMetode
            '
            Me.txtPenjualanMetode.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtPenjualanMetode.Location = New System.Drawing.Point(823, 43)
            Me.txtPenjualanMetode.Name = "txtPenjualanMetode"
            Me.txtPenjualanMetode.Size = New System.Drawing.Size(190, 27)
            Me.txtPenjualanMetode.TabIndex = 9
            '
            'txtPenjualanJumlah
            '
            Me.txtPenjualanJumlah.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtPenjualanJumlah.Location = New System.Drawing.Point(1018, 43)
            Me.txtPenjualanJumlah.Name = "txtPenjualanJumlah"
            Me.txtPenjualanJumlah.Size = New System.Drawing.Size(119, 27)
            Me.txtPenjualanJumlah.TabIndex = 21
            '
            'btnTambahPenjualan
            '
            Me.btnTambahPenjualan.BackColor = System.Drawing.Color.Teal
            Me.btnTambahPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnTambahPenjualan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnTambahPenjualan.ForeColor = System.Drawing.Color.White
            Me.btnTambahPenjualan.Location = New System.Drawing.Point(21, 105)
            Me.btnTambahPenjualan.Name = "btnTambahPenjualan"
            Me.btnTambahPenjualan.Size = New System.Drawing.Size(100, 34)
            Me.btnTambahPenjualan.TabIndex = 10
            Me.btnTambahPenjualan.Text = "Tambah"
            Me.btnTambahPenjualan.UseVisualStyleBackColor = False
            '
            'btnUbahPenjualan
            '
            Me.btnUbahPenjualan.BackColor = System.Drawing.Color.LightSeaGreen
            Me.btnUbahPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnUbahPenjualan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnUbahPenjualan.ForeColor = System.Drawing.Color.White
            Me.btnUbahPenjualan.Location = New System.Drawing.Point(127, 105)
            Me.btnUbahPenjualan.Name = "btnUbahPenjualan"
            Me.btnUbahPenjualan.Size = New System.Drawing.Size(100, 34)
            Me.btnUbahPenjualan.TabIndex = 11
            Me.btnUbahPenjualan.Text = "Ubah"
            Me.btnUbahPenjualan.UseVisualStyleBackColor = False
            '
            'btnHapusPenjualan
            '
            Me.btnHapusPenjualan.BackColor = System.Drawing.Color.Brown
            Me.btnHapusPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnHapusPenjualan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnHapusPenjualan.ForeColor = System.Drawing.Color.White
            Me.btnHapusPenjualan.Location = New System.Drawing.Point(913, 105)
            Me.btnHapusPenjualan.Name = "btnHapusPenjualan"
            Me.btnHapusPenjualan.Size = New System.Drawing.Size(100, 34)
            Me.btnHapusPenjualan.TabIndex = 12
            Me.btnHapusPenjualan.Text = "Hapus"
            Me.btnHapusPenjualan.UseVisualStyleBackColor = False
            '
            'btnBersihkanPenjualan
            '
            Me.btnBersihkanPenjualan.BackColor = System.Drawing.SystemColors.ControlDarkDark
            Me.btnBersihkanPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBersihkanPenjualan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnBersihkanPenjualan.ForeColor = System.Drawing.Color.White
            Me.btnBersihkanPenjualan.Location = New System.Drawing.Point(1024, 105)
            Me.btnBersihkanPenjualan.Name = "btnBersihkanPenjualan"
            Me.btnBersihkanPenjualan.Size = New System.Drawing.Size(114, 34)
            Me.btnBersihkanPenjualan.TabIndex = 13
            Me.btnBersihkanPenjualan.Text = "Bersihkan"
            Me.btnBersihkanPenjualan.UseVisualStyleBackColor = False
            '
            'dgvPenjualan
            '
            Me.dgvPenjualan.AllowUserToAddRows = False
            Me.dgvPenjualan.AllowUserToDeleteRows = False
            Me.dgvPenjualan.AllowUserToResizeRows = False
            Me.dgvPenjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvPenjualan.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
            Me.dgvPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvPenjualan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvPenjualanCol1, Me.dgvPenjualanCol2, Me.dgvPenjualanCol3, Me.dgvPenjualanCol4, Me.dgvPenjualanCol5})
            Me.dgvPenjualan.Location = New System.Drawing.Point(20, 230)
            Me.dgvPenjualan.MultiSelect = False
            Me.dgvPenjualan.Name = "dgvPenjualan"
            Me.dgvPenjualan.ReadOnly = True
            Me.dgvPenjualan.RowHeadersVisible = False
            Me.dgvPenjualan.RowHeadersWidth = 51
            Me.dgvPenjualan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPenjualan.Size = New System.Drawing.Size(1150, 325)
            Me.dgvPenjualan.TabIndex = 2
            '
            'dgvPenjualanCol1
            '
            Me.dgvPenjualanCol1.HeaderText = "Kode Penjualan"
            Me.dgvPenjualanCol1.MinimumWidth = 6
            Me.dgvPenjualanCol1.Name = "dgvPenjualanCol1"
            Me.dgvPenjualanCol1.ReadOnly = True
            Me.dgvPenjualanCol1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPenjualanCol2
            '
            Me.dgvPenjualanCol2.HeaderText = "Kode Pesanan"
            Me.dgvPenjualanCol2.MinimumWidth = 6
            Me.dgvPenjualanCol2.Name = "dgvPenjualanCol2"
            Me.dgvPenjualanCol2.ReadOnly = True
            Me.dgvPenjualanCol2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPenjualanCol3
            '
            Me.dgvPenjualanCol3.HeaderText = "Tanggal Pengambilan"
            Me.dgvPenjualanCol3.MinimumWidth = 6
            Me.dgvPenjualanCol3.Name = "dgvPenjualanCol3"
            Me.dgvPenjualanCol3.ReadOnly = True
            Me.dgvPenjualanCol3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPenjualanCol4
            '
            Me.dgvPenjualanCol4.HeaderText = "Total (Rp)"
            Me.dgvPenjualanCol4.MinimumWidth = 6
            Me.dgvPenjualanCol4.Name = "dgvPenjualanCol4"
            Me.dgvPenjualanCol4.ReadOnly = True
            Me.dgvPenjualanCol4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPenjualanCol5
            '
            Me.dgvPenjualanCol5.HeaderText = "Status Pembayaran"
            Me.dgvPenjualanCol5.MinimumWidth = 6
            Me.dgvPenjualanCol5.Name = "dgvPenjualanCol5"
            Me.dgvPenjualanCol5.ReadOnly = True
            Me.dgvPenjualanCol5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'tpPesanan
            '
            Me.tpPesanan.BackColor = System.Drawing.Color.CadetBlue
            Me.tpPesanan.Controls.Add(Me.lblTitlePesanan)
            Me.tpPesanan.Controls.Add(Me.pnlPesanan)
            Me.tpPesanan.Controls.Add(Me.dgvPesanan)
            Me.tpPesanan.Location = New System.Drawing.Point(4, 28)
            Me.tpPesanan.Name = "tpPesanan"
            Me.tpPesanan.Size = New System.Drawing.Size(1202, 558)
            Me.tpPesanan.TabIndex = 1
            Me.tpPesanan.Text = "Pesanan"
            '
            'lblTitlePesanan
            '
            Me.lblTitlePesanan.BackColor = System.Drawing.Color.Transparent
            Me.lblTitlePesanan.Font = New System.Drawing.Font("Bookman Old Style", 17.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitlePesanan.ForeColor = System.Drawing.Color.White
            Me.lblTitlePesanan.Location = New System.Drawing.Point(524, 4)
            Me.lblTitlePesanan.Name = "lblTitlePesanan"
            Me.lblTitlePesanan.Size = New System.Drawing.Size(203, 35)
            Me.lblTitlePesanan.TabIndex = 0
            Me.lblTitlePesanan.Text = "PESANAN"
            Me.lblTitlePesanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlPesanan
            '
            Me.pnlPesanan.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.pnlPesanan.Controls.Add(Me.lbltxtPesananNo)
            Me.pnlPesanan.Controls.Add(Me.txtPesananNo)
            Me.pnlPesanan.Controls.Add(Me.lbltxtPesananPelanggan)
            Me.pnlPesanan.Controls.Add(Me.txtPesananPelanggan)
            Me.pnlPesanan.Controls.Add(Me.lbltxtPesananLayanan)
            Me.pnlPesanan.Controls.Add(Me.txtPesananLayanan)
            Me.pnlPesanan.Controls.Add(Me.lbltxtPesananTanggal)
            Me.pnlPesanan.Controls.Add(Me.dtpPesananTanggal)
            Me.pnlPesanan.Controls.Add(Me.lbltxtPesananStatus)
            Me.pnlPesanan.Controls.Add(Me.txtPesananStatus)
            Me.pnlPesanan.Controls.Add(Me.btnTambahPesanan)
            Me.pnlPesanan.Controls.Add(Me.btnUbahPesanan)
            Me.pnlPesanan.Controls.Add(Me.btnHapusPesanan)
            Me.pnlPesanan.Controls.Add(Me.btnBersihkanPesanan)
            Me.pnlPesanan.Location = New System.Drawing.Point(20, 55)
            Me.pnlPesanan.Name = "pnlPesanan"
            Me.pnlPesanan.Size = New System.Drawing.Size(1150, 160)
            Me.pnlPesanan.TabIndex = 1
            '
            'lbltxtPesananNo
            '
            Me.lbltxtPesananNo.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPesananNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPesananNo.ForeColor = System.Drawing.Color.White
            Me.lbltxtPesananNo.Location = New System.Drawing.Point(15, 16)
            Me.lbltxtPesananNo.Name = "lbltxtPesananNo"
            Me.lbltxtPesananNo.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtPesananNo.TabIndex = 0
            Me.lbltxtPesananNo.Text = "No. Pesanan"
            Me.lbltxtPesananNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtPesananNo
            '
            Me.txtPesananNo.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtPesananNo.Location = New System.Drawing.Point(15, 43)
            Me.txtPesananNo.Name = "txtPesananNo"
            Me.txtPesananNo.Size = New System.Drawing.Size(190, 27)
            Me.txtPesananNo.TabIndex = 1
            '
            'lbltxtPesananPelanggan
            '
            Me.lbltxtPesananPelanggan.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPesananPelanggan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPesananPelanggan.ForeColor = System.Drawing.Color.White
            Me.lbltxtPesananPelanggan.Location = New System.Drawing.Point(217, 16)
            Me.lbltxtPesananPelanggan.Name = "lbltxtPesananPelanggan"
            Me.lbltxtPesananPelanggan.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtPesananPelanggan.TabIndex = 2
            Me.lbltxtPesananPelanggan.Text = "Nama Pelanggan"
            Me.lbltxtPesananPelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtPesananPelanggan
            '
            Me.txtPesananPelanggan.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtPesananPelanggan.Location = New System.Drawing.Point(217, 43)
            Me.txtPesananPelanggan.Name = "txtPesananPelanggan"
            Me.txtPesananPelanggan.Size = New System.Drawing.Size(190, 27)
            Me.txtPesananPelanggan.TabIndex = 3
            '
            'lbltxtPesananLayanan
            '
            Me.lbltxtPesananLayanan.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPesananLayanan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPesananLayanan.ForeColor = System.Drawing.Color.White
            Me.lbltxtPesananLayanan.Location = New System.Drawing.Point(419, 16)
            Me.lbltxtPesananLayanan.Name = "lbltxtPesananLayanan"
            Me.lbltxtPesananLayanan.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtPesananLayanan.TabIndex = 4
            Me.lbltxtPesananLayanan.Text = "Kode Layanan"
            Me.lbltxtPesananLayanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtPesananLayanan
            '
            Me.txtPesananLayanan.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtPesananLayanan.Location = New System.Drawing.Point(419, 43)
            Me.txtPesananLayanan.Name = "txtPesananLayanan"
            Me.txtPesananLayanan.Size = New System.Drawing.Size(190, 27)
            Me.txtPesananLayanan.TabIndex = 5
            '
            'lbltxtPesananTanggal
            '
            Me.lbltxtPesananTanggal.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPesananTanggal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPesananTanggal.ForeColor = System.Drawing.Color.White
            Me.lbltxtPesananTanggal.Location = New System.Drawing.Point(621, 16)
            Me.lbltxtPesananTanggal.Name = "lbltxtPesananTanggal"
            Me.lbltxtPesananTanggal.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtPesananTanggal.TabIndex = 6
            Me.lbltxtPesananTanggal.Text = "Tanggal Pesanan"
            Me.lbltxtPesananTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpPesananTanggal
            '
            Me.dtpPesananTanggal.CustomFormat = "dd/MM/yyyy"
            Me.dtpPesananTanggal.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.dtpPesananTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpPesananTanggal.Location = New System.Drawing.Point(621, 43)
            Me.dtpPesananTanggal.Name = "dtpPesananTanggal"
            Me.dtpPesananTanggal.Size = New System.Drawing.Size(190, 27)
            Me.dtpPesananTanggal.TabIndex = 7
            '
            'lbltxtPesananStatus
            '
            Me.lbltxtPesananStatus.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPesananStatus.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPesananStatus.ForeColor = System.Drawing.Color.White
            Me.lbltxtPesananStatus.Location = New System.Drawing.Point(823, 16)
            Me.lbltxtPesananStatus.Name = "lbltxtPesananStatus"
            Me.lbltxtPesananStatus.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtPesananStatus.TabIndex = 8
            Me.lbltxtPesananStatus.Text = "Status"
            Me.lbltxtPesananStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtPesananStatus
            '
            Me.txtPesananStatus.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtPesananStatus.Location = New System.Drawing.Point(823, 43)
            Me.txtPesananStatus.Name = "txtPesananStatus"
            Me.txtPesananStatus.Size = New System.Drawing.Size(190, 27)
            Me.txtPesananStatus.TabIndex = 9
            '
            'btnTambahPesanan
            '
            Me.btnTambahPesanan.BackColor = System.Drawing.Color.Teal
            Me.btnTambahPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnTambahPesanan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnTambahPesanan.ForeColor = System.Drawing.Color.White
            Me.btnTambahPesanan.Location = New System.Drawing.Point(15, 105)
            Me.btnTambahPesanan.Name = "btnTambahPesanan"
            Me.btnTambahPesanan.Size = New System.Drawing.Size(100, 34)
            Me.btnTambahPesanan.TabIndex = 10
            Me.btnTambahPesanan.Text = "Tambah"
            Me.btnTambahPesanan.UseVisualStyleBackColor = False
            '
            'btnUbahPesanan
            '
            Me.btnUbahPesanan.BackColor = System.Drawing.Color.LightSeaGreen
            Me.btnUbahPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnUbahPesanan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnUbahPesanan.ForeColor = System.Drawing.Color.White
            Me.btnUbahPesanan.Location = New System.Drawing.Point(127, 105)
            Me.btnUbahPesanan.Name = "btnUbahPesanan"
            Me.btnUbahPesanan.Size = New System.Drawing.Size(100, 34)
            Me.btnUbahPesanan.TabIndex = 11
            Me.btnUbahPesanan.Text = "Ubah"
            Me.btnUbahPesanan.UseVisualStyleBackColor = False
            '
            'btnHapusPesanan
            '
            Me.btnHapusPesanan.BackColor = System.Drawing.Color.Brown
            Me.btnHapusPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnHapusPesanan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnHapusPesanan.ForeColor = System.Drawing.Color.White
            Me.btnHapusPesanan.Location = New System.Drawing.Point(930, 105)
            Me.btnHapusPesanan.Name = "btnHapusPesanan"
            Me.btnHapusPesanan.Size = New System.Drawing.Size(100, 34)
            Me.btnHapusPesanan.TabIndex = 12
            Me.btnHapusPesanan.Text = "Hapus"
            Me.btnHapusPesanan.UseVisualStyleBackColor = False
            '
            'btnBersihkanPesanan
            '
            Me.btnBersihkanPesanan.BackColor = System.Drawing.SystemColors.ControlDarkDark
            Me.btnBersihkanPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBersihkanPesanan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnBersihkanPesanan.ForeColor = System.Drawing.Color.White
            Me.btnBersihkanPesanan.Location = New System.Drawing.Point(1036, 105)
            Me.btnBersihkanPesanan.Name = "btnBersihkanPesanan"
            Me.btnBersihkanPesanan.Size = New System.Drawing.Size(111, 34)
            Me.btnBersihkanPesanan.TabIndex = 13
            Me.btnBersihkanPesanan.Text = "Bersihkan"
            Me.btnBersihkanPesanan.UseVisualStyleBackColor = False
            '
            'dgvPesanan
            '
            Me.dgvPesanan.AllowUserToAddRows = False
            Me.dgvPesanan.AllowUserToDeleteRows = False
            Me.dgvPesanan.AllowUserToResizeRows = False
            Me.dgvPesanan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvPesanan.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
            Me.dgvPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvPesanan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvPesananCol1, Me.dgvPesananCol2, Me.dgvPesananCol3, Me.dgvPesananCol4, Me.dgvPesananCol5})
            Me.dgvPesanan.Location = New System.Drawing.Point(20, 230)
            Me.dgvPesanan.MultiSelect = False
            Me.dgvPesanan.Name = "dgvPesanan"
            Me.dgvPesanan.ReadOnly = True
            Me.dgvPesanan.RowHeadersVisible = False
            Me.dgvPesanan.RowHeadersWidth = 51
            Me.dgvPesanan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPesanan.Size = New System.Drawing.Size(1150, 325)
            Me.dgvPesanan.TabIndex = 2
            '
            'dgvPesananCol1
            '
            Me.dgvPesananCol1.HeaderText = "No. Pesanan"
            Me.dgvPesananCol1.MinimumWidth = 6
            Me.dgvPesananCol1.Name = "dgvPesananCol1"
            Me.dgvPesananCol1.ReadOnly = True
            Me.dgvPesananCol1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPesananCol2
            '
            Me.dgvPesananCol2.HeaderText = "Pelanggan"
            Me.dgvPesananCol2.MinimumWidth = 6
            Me.dgvPesananCol2.Name = "dgvPesananCol2"
            Me.dgvPesananCol2.ReadOnly = True
            Me.dgvPesananCol2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPesananCol3
            '
            Me.dgvPesananCol3.HeaderText = "Kode Layanan"
            Me.dgvPesananCol3.MinimumWidth = 6
            Me.dgvPesananCol3.Name = "dgvPesananCol3"
            Me.dgvPesananCol3.ReadOnly = True
            Me.dgvPesananCol3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPesananCol4
            '
            Me.dgvPesananCol4.HeaderText = "Tanggal"
            Me.dgvPesananCol4.MinimumWidth = 6
            Me.dgvPesananCol4.Name = "dgvPesananCol4"
            Me.dgvPesananCol4.ReadOnly = True
            Me.dgvPesananCol4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPesananCol5
            '
            Me.dgvPesananCol5.HeaderText = "Status"
            Me.dgvPesananCol5.MinimumWidth = 6
            Me.dgvPesananCol5.Name = "dgvPesananCol5"
            Me.dgvPesananCol5.ReadOnly = True
            Me.dgvPesananCol5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'tpCekLayanan
            '
            Me.tpCekLayanan.BackColor = System.Drawing.Color.CadetBlue
            Me.tpCekLayanan.Controls.Add(Me.lblTitleCekLayanan)
            Me.tpCekLayanan.Controls.Add(Me.txtCariCekLayanan)
            Me.tpCekLayanan.Controls.Add(Me.lblCariCekLayanan)
            Me.tpCekLayanan.Controls.Add(Me.dgvCekLayanan)
            Me.tpCekLayanan.ForeColor = System.Drawing.Color.CadetBlue
            Me.tpCekLayanan.Location = New System.Drawing.Point(4, 28)
            Me.tpCekLayanan.Name = "tpCekLayanan"
            Me.tpCekLayanan.Size = New System.Drawing.Size(1202, 558)
            Me.tpCekLayanan.TabIndex = 2
            Me.tpCekLayanan.Text = "Cek Layanan"
            '
            'lblTitleCekLayanan
            '
            Me.lblTitleCekLayanan.BackColor = System.Drawing.Color.Transparent
            Me.lblTitleCekLayanan.Font = New System.Drawing.Font("Bookman Old Style", 17.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitleCekLayanan.ForeColor = System.Drawing.Color.White
            Me.lblTitleCekLayanan.Location = New System.Drawing.Point(528, 15)
            Me.lblTitleCekLayanan.Name = "lblTitleCekLayanan"
            Me.lblTitleCekLayanan.Size = New System.Drawing.Size(1120, 35)
            Me.lblTitleCekLayanan.TabIndex = 0
            Me.lblTitleCekLayanan.Text = "CEK LAYANAN"
            Me.lblTitleCekLayanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtCariCekLayanan
            '
            Me.txtCariCekLayanan.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtCariCekLayanan.Location = New System.Drawing.Point(22, 62)
            Me.txtCariCekLayanan.Name = "txtCariCekLayanan"
            Me.txtCariCekLayanan.Size = New System.Drawing.Size(285, 27)
            Me.txtCariCekLayanan.TabIndex = 1
            '
            'lblCariCekLayanan
            '
            Me.lblCariCekLayanan.BackColor = System.Drawing.Color.Transparent
            Me.lblCariCekLayanan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCariCekLayanan.ForeColor = System.Drawing.Color.Red
            Me.lblCariCekLayanan.Location = New System.Drawing.Point(22, 37)
            Me.lblCariCekLayanan.Name = "lblCariCekLayanan"
            Me.lblCariCekLayanan.Size = New System.Drawing.Size(250, 22)
            Me.lblCariCekLayanan.TabIndex = 2
            Me.lblCariCekLayanan.Text = "Cari data..."
            Me.lblCariCekLayanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dgvCekLayanan
            '
            Me.dgvCekLayanan.AllowUserToAddRows = False
            Me.dgvCekLayanan.AllowUserToDeleteRows = False
            Me.dgvCekLayanan.AllowUserToResizeRows = False
            Me.dgvCekLayanan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvCekLayanan.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
            Me.dgvCekLayanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvCekLayanan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvCekLayananCol1, Me.dgvCekLayananCol2, Me.dgvCekLayananCol3, Me.dgvCekLayananCol4, Me.dgvCekLayananCol5})
            Me.dgvCekLayanan.Location = New System.Drawing.Point(20, 115)
            Me.dgvCekLayanan.MultiSelect = False
            Me.dgvCekLayanan.Name = "dgvCekLayanan"
            Me.dgvCekLayanan.ReadOnly = True
            Me.dgvCekLayanan.RowHeadersVisible = False
            Me.dgvCekLayanan.RowHeadersWidth = 51
            Me.dgvCekLayanan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCekLayanan.Size = New System.Drawing.Size(1150, 440)
            Me.dgvCekLayanan.TabIndex = 4
            '
            'dgvCekLayananCol1
            '
            Me.dgvCekLayananCol1.HeaderText = "Kode Layanan"
            Me.dgvCekLayananCol1.MinimumWidth = 6
            Me.dgvCekLayananCol1.Name = "dgvCekLayananCol1"
            Me.dgvCekLayananCol1.ReadOnly = True
            Me.dgvCekLayananCol1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvCekLayananCol2
            '
            Me.dgvCekLayananCol2.HeaderText = "Nama Layanan"
            Me.dgvCekLayananCol2.MinimumWidth = 6
            Me.dgvCekLayananCol2.Name = "dgvCekLayananCol2"
            Me.dgvCekLayananCol2.ReadOnly = True
            Me.dgvCekLayananCol2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvCekLayananCol3
            '
            Me.dgvCekLayananCol3.HeaderText = "Jenis Layanan"
            Me.dgvCekLayananCol3.MinimumWidth = 6
            Me.dgvCekLayananCol3.Name = "dgvCekLayananCol3"
            Me.dgvCekLayananCol3.ReadOnly = True
            Me.dgvCekLayananCol3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvCekLayananCol4
            '
            Me.dgvCekLayananCol4.HeaderText = "Harga"
            Me.dgvCekLayananCol4.MinimumWidth = 6
            Me.dgvCekLayananCol4.Name = "dgvCekLayananCol4"
            Me.dgvCekLayananCol4.ReadOnly = True
            Me.dgvCekLayananCol4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvCekLayananCol5
            '
            Me.dgvCekLayananCol5.HeaderText = "Estimasi"
            Me.dgvCekLayananCol5.MinimumWidth = 6
            Me.dgvCekLayananCol5.Name = "dgvCekLayananCol5"
            Me.dgvCekLayananCol5.ReadOnly = True
            Me.dgvCekLayananCol5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'tpCekPengerjaan
            '
            Me.tpCekPengerjaan.BackColor = System.Drawing.Color.CadetBlue
            Me.tpCekPengerjaan.Controls.Add(Me.lblTitleCekPengerjaan)
            Me.tpCekPengerjaan.Controls.Add(Me.txtCariCekPengerjaan)
            Me.tpCekPengerjaan.Controls.Add(Me.lblCariCekPengerjaan)
            Me.tpCekPengerjaan.Controls.Add(Me.dgvCekPengerjaan)
            Me.tpCekPengerjaan.ForeColor = System.Drawing.Color.CadetBlue
            Me.tpCekPengerjaan.Location = New System.Drawing.Point(4, 28)
            Me.tpCekPengerjaan.Name = "tpCekPengerjaan"
            Me.tpCekPengerjaan.Size = New System.Drawing.Size(1202, 558)
            Me.tpCekPengerjaan.TabIndex = 3
            Me.tpCekPengerjaan.Text = "Cek Pengerjaan"
            '
            'lblTitleCekPengerjaan
            '
            Me.lblTitleCekPengerjaan.BackColor = System.Drawing.Color.Transparent
            Me.lblTitleCekPengerjaan.Font = New System.Drawing.Font("Bookman Old Style", 17.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitleCekPengerjaan.ForeColor = System.Drawing.Color.White
            Me.lblTitleCekPengerjaan.Location = New System.Drawing.Point(478, 12)
            Me.lblTitleCekPengerjaan.Name = "lblTitleCekPengerjaan"
            Me.lblTitleCekPengerjaan.Size = New System.Drawing.Size(1120, 35)
            Me.lblTitleCekPengerjaan.TabIndex = 0
            Me.lblTitleCekPengerjaan.Text = "CEK PENGERJAAN"
            Me.lblTitleCekPengerjaan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtCariCekPengerjaan
            '
            Me.txtCariCekPengerjaan.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtCariCekPengerjaan.Location = New System.Drawing.Point(22, 62)
            Me.txtCariCekPengerjaan.Name = "txtCariCekPengerjaan"
            Me.txtCariCekPengerjaan.Size = New System.Drawing.Size(285, 27)
            Me.txtCariCekPengerjaan.TabIndex = 1
            '
            'lblCariCekPengerjaan
            '
            Me.lblCariCekPengerjaan.BackColor = System.Drawing.Color.Transparent
            Me.lblCariCekPengerjaan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCariCekPengerjaan.ForeColor = System.Drawing.Color.Red
            Me.lblCariCekPengerjaan.Location = New System.Drawing.Point(22, 37)
            Me.lblCariCekPengerjaan.Name = "lblCariCekPengerjaan"
            Me.lblCariCekPengerjaan.Size = New System.Drawing.Size(250, 22)
            Me.lblCariCekPengerjaan.TabIndex = 2
            Me.lblCariCekPengerjaan.Text = "Cari data..."
            Me.lblCariCekPengerjaan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dgvCekPengerjaan
            '
            Me.dgvCekPengerjaan.AllowUserToAddRows = False
            Me.dgvCekPengerjaan.AllowUserToDeleteRows = False
            Me.dgvCekPengerjaan.AllowUserToResizeRows = False
            Me.dgvCekPengerjaan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvCekPengerjaan.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
            Me.dgvCekPengerjaan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvCekPengerjaan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvCekPengerjaanCol1, Me.dgvCekPengerjaanCol2, Me.dgvCekPengerjaanCol3, Me.dgvCekPengerjaanCol4, Me.dgvCekPengerjaanCol5, Me.dgvCekPengerjaanCol6})
            Me.dgvCekPengerjaan.Location = New System.Drawing.Point(20, 115)
            Me.dgvCekPengerjaan.MultiSelect = False
            Me.dgvCekPengerjaan.Name = "dgvCekPengerjaan"
            Me.dgvCekPengerjaan.ReadOnly = True
            Me.dgvCekPengerjaan.RowHeadersVisible = False
            Me.dgvCekPengerjaan.RowHeadersWidth = 51
            Me.dgvCekPengerjaan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCekPengerjaan.Size = New System.Drawing.Size(1150, 440)
            Me.dgvCekPengerjaan.TabIndex = 4
            '
            'dgvCekPengerjaanCol1
            '
            Me.dgvCekPengerjaanCol1.HeaderText = "No. Pengerjaan"
            Me.dgvCekPengerjaanCol1.MinimumWidth = 6
            Me.dgvCekPengerjaanCol1.Name = "dgvCekPengerjaanCol1"
            Me.dgvCekPengerjaanCol1.ReadOnly = True
            Me.dgvCekPengerjaanCol1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvCekPengerjaanCol2
            '
            Me.dgvCekPengerjaanCol2.HeaderText = "No. Pesanan"
            Me.dgvCekPengerjaanCol2.MinimumWidth = 6
            Me.dgvCekPengerjaanCol2.Name = "dgvCekPengerjaanCol2"
            Me.dgvCekPengerjaanCol2.ReadOnly = True
            Me.dgvCekPengerjaanCol2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvCekPengerjaanCol3
            '
            Me.dgvCekPengerjaanCol3.HeaderText = "Teknisi"
            Me.dgvCekPengerjaanCol3.MinimumWidth = 6
            Me.dgvCekPengerjaanCol3.Name = "dgvCekPengerjaanCol3"
            Me.dgvCekPengerjaanCol3.ReadOnly = True
            Me.dgvCekPengerjaanCol3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvCekPengerjaanCol4
            '
            Me.dgvCekPengerjaanCol4.HeaderText = "Mulai"
            Me.dgvCekPengerjaanCol4.MinimumWidth = 6
            Me.dgvCekPengerjaanCol4.Name = "dgvCekPengerjaanCol4"
            Me.dgvCekPengerjaanCol4.ReadOnly = True
            Me.dgvCekPengerjaanCol4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvCekPengerjaanCol5
            '
            Me.dgvCekPengerjaanCol5.HeaderText = "Selesai"
            Me.dgvCekPengerjaanCol5.MinimumWidth = 6
            Me.dgvCekPengerjaanCol5.Name = "dgvCekPengerjaanCol5"
            Me.dgvCekPengerjaanCol5.ReadOnly = True
            Me.dgvCekPengerjaanCol5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvCekPengerjaanCol6
            '
            Me.dgvCekPengerjaanCol6.HeaderText = "Status"
            Me.dgvCekPengerjaanCol6.MinimumWidth = 6
            Me.dgvCekPengerjaanCol6.Name = "dgvCekPengerjaanCol6"
            Me.dgvCekPengerjaanCol6.ReadOnly = True
            Me.dgvCekPengerjaanCol6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
            Me.Panel1.Controls.Add(Me.lblBrand)
            Me.Panel1.Controls.Add(Me.lblActor)
            Me.Panel1.Controls.Add(Me.btnLogout)
            Me.Panel1.Controls.Add(Me.PictureBox1)
            Me.Panel1.Location = New System.Drawing.Point(0, -6)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1254, 100)
            Me.Panel1.TabIndex = 16
            '
            'lblBrand
            '
            Me.lblBrand.BackColor = System.Drawing.Color.Transparent
            Me.lblBrand.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBrand.ForeColor = System.Drawing.Color.White
            Me.lblBrand.Location = New System.Drawing.Point(143, 33)
            Me.lblBrand.Name = "lblBrand"
            Me.lblBrand.Size = New System.Drawing.Size(940, 57)
            Me.lblBrand.TabIndex = 9
            Me.lblBrand.Text = " SISTEM INFORMASI PENGELOLAAN SERVIS SEPATU Shoelusi"
            Me.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblActor
            '
            Me.lblActor.BackColor = System.Drawing.Color.Transparent
            Me.lblActor.Font = New System.Drawing.Font("Lucida Bright", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblActor.ForeColor = System.Drawing.Color.White
            Me.lblActor.Location = New System.Drawing.Point(1126, 13)
            Me.lblActor.Name = "lblActor"
            Me.lblActor.Size = New System.Drawing.Size(86, 45)
            Me.lblActor.TabIndex = 10
            Me.lblActor.Text = "Kasir"
            Me.lblActor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnLogout
            '
            Me.btnLogout.BackColor = System.Drawing.Color.SteelBlue
            Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLogout.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnLogout.ForeColor = System.Drawing.Color.White
            Me.btnLogout.Location = New System.Drawing.Point(1103, 61)
            Me.btnLogout.Name = "btnLogout"
            Me.btnLogout.Size = New System.Drawing.Size(135, 34)
            Me.btnLogout.TabIndex = 11
            Me.btnLogout.Text = "Keluar Akun"
            Me.btnLogout.UseVisualStyleBackColor = False
            '
            'PictureBox1
            '
            Me.PictureBox1.Image = Global.Resources.shoelusi_logo
            Me.PictureBox1.Location = New System.Drawing.Point(12, 23)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(86, 67)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 8
            Me.PictureBox1.TabStop = False
            '
            'TabPage1
            '
            Me.TabPage1.BackColor = System.Drawing.Color.CadetBlue
            Me.TabPage1.Controls.Add(Me.DataGridView1)
            Me.TabPage1.Controls.Add(Me.Label7)
            Me.TabPage1.Controls.Add(Me.Panel2)
            Me.TabPage1.Location = New System.Drawing.Point(4, 28)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(1202, 558)
            Me.TabPage1.TabIndex = 4
            Me.TabPage1.Text = "Detail Produk"
            '
            'Panel2
            '
            Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.Panel2.Controls.Add(Me.ComboBox2)
            Me.Panel2.Controls.Add(Me.ComboBox1)
            Me.Panel2.Controls.Add(Me.Label10)
            Me.Panel2.Controls.Add(Me.TextBox9)
            Me.Panel2.Controls.Add(Me.Label9)
            Me.Panel2.Controls.Add(Me.TextBox8)
            Me.Panel2.Controls.Add(Me.Label8)
            Me.Panel2.Controls.Add(Me.TextBox7)
            Me.Panel2.Controls.Add(Me.Label1)
            Me.Panel2.Controls.Add(Me.TextBox1)
            Me.Panel2.Controls.Add(Me.Label2)
            Me.Panel2.Controls.Add(Me.Label3)
            Me.Panel2.Controls.Add(Me.Label4)
            Me.Panel2.Controls.Add(Me.TextBox3)
            Me.Panel2.Controls.Add(Me.Label5)
            Me.Panel2.Controls.Add(Me.Label6)
            Me.Panel2.Controls.Add(Me.TextBox4)
            Me.Panel2.Controls.Add(Me.TextBox5)
            Me.Panel2.Controls.Add(Me.Button1)
            Me.Panel2.Controls.Add(Me.Button2)
            Me.Panel2.Controls.Add(Me.Button3)
            Me.Panel2.Controls.Add(Me.Button4)
            Me.Panel2.Location = New System.Drawing.Point(23, 72)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(1150, 212)
            Me.Panel2.TabIndex = 2
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.White
            Me.Label1.Location = New System.Drawing.Point(15, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(190, 23)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Kode Produk"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'TextBox1
            '
            Me.TextBox1.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.TextBox1.Location = New System.Drawing.Point(15, 43)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(190, 27)
            Me.TextBox1.TabIndex = 1
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.White
            Me.Label2.Location = New System.Drawing.Point(217, 16)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(190, 23)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Kode Pesanan"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.White
            Me.Label3.Location = New System.Drawing.Point(419, 16)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(190, 23)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Jenis Layanan"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.White
            Me.Label4.Location = New System.Drawing.Point(621, 16)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(190, 23)
            Me.Label4.TabIndex = 6
            Me.Label4.Text = "Kondisi Sepatu"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'TextBox3
            '
            Me.TextBox3.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.TextBox3.Location = New System.Drawing.Point(621, 43)
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.Size = New System.Drawing.Size(190, 27)
            Me.TextBox3.TabIndex = 7
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.White
            Me.Label5.Location = New System.Drawing.Point(823, 16)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(190, 23)
            Me.Label5.TabIndex = 8
            Me.Label5.Text = "Jenis Sepatu"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.White
            Me.Label6.Location = New System.Drawing.Point(1018, 16)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(119, 23)
            Me.Label6.TabIndex = 20
            Me.Label6.Text = "Bahan Sepatu"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'TextBox4
            '
            Me.TextBox4.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.TextBox4.Location = New System.Drawing.Point(823, 43)
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.Size = New System.Drawing.Size(190, 27)
            Me.TextBox4.TabIndex = 9
            '
            'TextBox5
            '
            Me.TextBox5.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.TextBox5.Location = New System.Drawing.Point(1018, 43)
            Me.TextBox5.Name = "TextBox5"
            Me.TextBox5.Size = New System.Drawing.Size(119, 27)
            Me.TextBox5.TabIndex = 21
            '
            'Button1
            '
            Me.Button1.BackColor = System.Drawing.Color.Teal
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.Button1.ForeColor = System.Drawing.Color.White
            Me.Button1.Location = New System.Drawing.Point(18, 161)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(100, 34)
            Me.Button1.TabIndex = 10
            Me.Button1.Text = "Tambah"
            Me.Button1.UseVisualStyleBackColor = False
            '
            'Button2
            '
            Me.Button2.BackColor = System.Drawing.Color.LightSeaGreen
            Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.Button2.ForeColor = System.Drawing.Color.White
            Me.Button2.Location = New System.Drawing.Point(124, 161)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(100, 34)
            Me.Button2.TabIndex = 11
            Me.Button2.Text = "Ubah"
            Me.Button2.UseVisualStyleBackColor = False
            '
            'Button3
            '
            Me.Button3.BackColor = System.Drawing.Color.Brown
            Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.Button3.ForeColor = System.Drawing.Color.White
            Me.Button3.Location = New System.Drawing.Point(913, 161)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(100, 34)
            Me.Button3.TabIndex = 12
            Me.Button3.Text = "Hapus"
            Me.Button3.UseVisualStyleBackColor = False
            '
            'Button4
            '
            Me.Button4.BackColor = System.Drawing.SystemColors.ControlDarkDark
            Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.Button4.ForeColor = System.Drawing.Color.White
            Me.Button4.Location = New System.Drawing.Point(1023, 161)
            Me.Button4.Name = "Button4"
            Me.Button4.Size = New System.Drawing.Size(114, 34)
            Me.Button4.TabIndex = 13
            Me.Button4.Text = "Bersihkan"
            Me.Button4.UseVisualStyleBackColor = False
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.Transparent
            Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.White
            Me.Label7.Location = New System.Drawing.Point(535, 17)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(255, 52)
            Me.Label7.TabIndex = 3
            Me.Label7.Text = "Detail Produk"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'TextBox7
            '
            Me.TextBox7.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.TextBox7.Location = New System.Drawing.Point(18, 114)
            Me.TextBox7.Name = "TextBox7"
            Me.TextBox7.Size = New System.Drawing.Size(190, 27)
            Me.TextBox7.TabIndex = 23
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.Transparent
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.White
            Me.Label8.Location = New System.Drawing.Point(15, 88)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(190, 23)
            Me.Label8.TabIndex = 24
            Me.Label8.Text = "Jumlah Sepatu"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'TextBox8
            '
            Me.TextBox8.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.TextBox8.Location = New System.Drawing.Point(220, 114)
            Me.TextBox8.Name = "TextBox8"
            Me.TextBox8.Size = New System.Drawing.Size(190, 27)
            Me.TextBox8.TabIndex = 25
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.White
            Me.Label9.Location = New System.Drawing.Point(220, 88)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(190, 23)
            Me.Label9.TabIndex = 26
            Me.Label9.Text = "Harga Layanan"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'TextBox9
            '
            Me.TextBox9.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.TextBox9.Location = New System.Drawing.Point(422, 114)
            Me.TextBox9.Name = "TextBox9"
            Me.TextBox9.Size = New System.Drawing.Size(190, 27)
            Me.TextBox9.TabIndex = 27
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.Transparent
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.Color.White
            Me.Label10.Location = New System.Drawing.Point(419, 88)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(190, 23)
            Me.Label10.TabIndex = 28
            Me.Label10.Text = "Estimasi Pengerjaan"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'DataGridView1
            '
            Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DataGridView1.Location = New System.Drawing.Point(23, 290)
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.RowHeadersWidth = 51
            Me.DataGridView1.RowTemplate.Height = 24
            Me.DataGridView1.Size = New System.Drawing.Size(1150, 262)
            Me.DataGridView1.TabIndex = 4
            '
            'ComboBox1
            '
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Location = New System.Drawing.Point(217, 44)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(190, 27)
            Me.ComboBox1.TabIndex = 29
            '
            'ComboBox2
            '
            Me.ComboBox2.FormattingEnabled = True
            Me.ComboBox2.Location = New System.Drawing.Point(422, 42)
            Me.ComboBox2.Name = "ComboBox2"
            Me.ComboBox2.Size = New System.Drawing.Size(190, 27)
            Me.ComboBox2.TabIndex = 30
            '
            'FrmKasir
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.CadetBlue
            Me.ClientSize = New System.Drawing.Size(1250, 710)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.tabMain)
            Me.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.ForeColor = System.Drawing.Color.BurlyWood
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.Name = "FrmKasir"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Shoelusi - Kasir"
            Me.tabMain.ResumeLayout(False)
            Me.tpPenjualan.ResumeLayout(False)
            Me.pnlPenjualan.ResumeLayout(False)
            Me.pnlPenjualan.PerformLayout()
            CType(Me.dgvPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpPesanan.ResumeLayout(False)
            Me.pnlPesanan.ResumeLayout(False)
            Me.pnlPesanan.PerformLayout()
            CType(Me.dgvPesanan, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpCekLayanan.ResumeLayout(False)
            Me.tpCekLayanan.PerformLayout()
            CType(Me.dgvCekLayanan, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpCekPengerjaan.ResumeLayout(False)
            Me.tpCekPengerjaan.PerformLayout()
            CType(Me.dgvCekPengerjaan, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Private components As System.ComponentModel.IContainer
        Friend WithEvents tabMain As System.Windows.Forms.TabControl
        Friend WithEvents tpPenjualan As System.Windows.Forms.TabPage
        Friend WithEvents lblTitlePenjualan As System.Windows.Forms.Label
        Friend WithEvents pnlPenjualan As System.Windows.Forms.Panel
        Friend WithEvents lbltxtPenjualanKode As System.Windows.Forms.Label
        Friend WithEvents txtPenjualanKode As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtPenjualanPesanan As System.Windows.Forms.Label
        Friend WithEvents txtPenjualanPesanan As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtPenjualanTanggal As System.Windows.Forms.Label
        Friend WithEvents dtpPenjualanTanggal As System.Windows.Forms.DateTimePicker
        Friend WithEvents lbltxtPenjualanTotal As System.Windows.Forms.Label
        Friend WithEvents txtPenjualanTotal As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtPenjualanMetode As System.Windows.Forms.Label
        Friend WithEvents lbltxtPenjualanJumlah As System.Windows.Forms.Label
        Friend WithEvents txtPenjualanMetode As System.Windows.Forms.TextBox
        Friend WithEvents txtPenjualanJumlah As System.Windows.Forms.TextBox
        Friend WithEvents btnTambahPenjualan As System.Windows.Forms.Button
        Friend WithEvents btnUbahPenjualan As System.Windows.Forms.Button
        Friend WithEvents btnHapusPenjualan As System.Windows.Forms.Button
        Friend WithEvents btnBersihkanPenjualan As System.Windows.Forms.Button
        Friend WithEvents dgvPenjualan As System.Windows.Forms.DataGridView
        Friend WithEvents dgvPenjualanCol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPenjualanCol2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPenjualanCol3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPenjualanCol4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPenjualanCol5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents tpPesanan As System.Windows.Forms.TabPage
        Friend WithEvents lblTitlePesanan As System.Windows.Forms.Label
        Friend WithEvents pnlPesanan As System.Windows.Forms.Panel
        Friend WithEvents lbltxtPesananNo As System.Windows.Forms.Label
        Friend WithEvents txtPesananNo As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtPesananPelanggan As System.Windows.Forms.Label
        Friend WithEvents txtPesananPelanggan As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtPesananLayanan As System.Windows.Forms.Label
        Friend WithEvents txtPesananLayanan As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtPesananTanggal As System.Windows.Forms.Label
        Friend WithEvents dtpPesananTanggal As System.Windows.Forms.DateTimePicker
        Friend WithEvents lbltxtPesananStatus As System.Windows.Forms.Label
        Friend WithEvents txtPesananStatus As System.Windows.Forms.TextBox
        Friend WithEvents btnTambahPesanan As System.Windows.Forms.Button
        Friend WithEvents btnUbahPesanan As System.Windows.Forms.Button
        Friend WithEvents btnHapusPesanan As System.Windows.Forms.Button
        Friend WithEvents btnBersihkanPesanan As System.Windows.Forms.Button
        Friend WithEvents dgvPesanan As System.Windows.Forms.DataGridView
        Friend WithEvents dgvPesananCol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPesananCol2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPesananCol3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPesananCol4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPesananCol5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents tpCekLayanan As System.Windows.Forms.TabPage
        Friend WithEvents lblTitleCekLayanan As System.Windows.Forms.Label
        Friend WithEvents txtCariCekLayanan As System.Windows.Forms.TextBox
        Friend WithEvents lblCariCekLayanan As System.Windows.Forms.Label
        Friend WithEvents dgvCekLayanan As System.Windows.Forms.DataGridView
        Friend WithEvents dgvCekLayananCol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvCekLayananCol2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvCekLayananCol3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvCekLayananCol4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvCekLayananCol5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents tpCekPengerjaan As System.Windows.Forms.TabPage
        Friend WithEvents lblTitleCekPengerjaan As System.Windows.Forms.Label
        Friend WithEvents txtCariCekPengerjaan As System.Windows.Forms.TextBox
        Friend WithEvents lblCariCekPengerjaan As System.Windows.Forms.Label
        Friend WithEvents dgvCekPengerjaan As System.Windows.Forms.DataGridView
        Friend WithEvents dgvCekPengerjaanCol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvCekPengerjaanCol2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvCekPengerjaanCol3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvCekPengerjaanCol4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvCekPengerjaanCol5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvCekPengerjaanCol6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents lblBrand As System.Windows.Forms.Label
        Friend WithEvents lblActor As System.Windows.Forms.Label
        Friend WithEvents btnLogout As System.Windows.Forms.Button
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents Button2 As System.Windows.Forms.Button
        Friend WithEvents Button3 As System.Windows.Forms.Button
        Friend WithEvents Button4 As System.Windows.Forms.Button
        Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
        Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
        Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    End Class
End Namespace
