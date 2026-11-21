Imports System
Imports System.Data
Imports System.Drawing
Imports System.Globalization
Imports System.Linq
Imports System.Windows.Forms

Namespace Shoelusi
    Partial Public Class FrmKasir
        Private activeAccountId As String

        Private productPage As TabPage
        Private txtProdukKodeRuntime As TextBox
        Private cmbProdukPesananRuntime As ComboBox
        Private cmbProdukLayananRuntime As ComboBox
        Private txtProdukKondisiRuntime As TextBox
        Private txtProdukJenisRuntime As TextBox
        Private txtProdukBahanRuntime As TextBox
        Private nudProdukJumlahRuntime As NumericUpDown
        Private txtProdukHargaRuntime As TextBox
        Private txtProdukEstimasiRuntime As TextBox
        Private dgvProdukRuntime As DataGridView
        Private btnTambahProdukRuntime As Button
        Private btnUbahProdukRuntime As Button
        Private btnHapusProdukRuntime As Button
        Private btnBersihkanProdukRuntime As Button
        Private productServiceCatalog As DataTable
        Private loadingProductEditor As Boolean

        Public Sub New()
            InitializeComponent()
            BuildProductTab()
            dgvPesanan.Columns.Add("NamaLayanan", "Nama Layanan")
            dgvPenjualan.Columns.Add("JumlahSepatu", "Jumlah Sepatu")
            dgvPenjualan.Columns.Add("TarifLayanan", "Tarif Rata-rata (Rp)")
            dgvPenjualan.Columns.Add("StatusPenjualan", "Status Penjualan")
            txtPenjualanJumlah.ReadOnly = True
            For Each input In {txtPenjualanKode, txtPenjualanPesanan, txtPenjualanJumlah}
                AddHandler input.TextChanged, Sub(sender, e) PreviewSale()
            Next
            BindPageActions()
            BindSearch(dgvPenjualan)
            BindSearch(dgvPesanan)
            AddHandler btnLogout.Click, Sub(sender, e) Close()
            AddHandler Load, Sub(sender, e) ReloadData()
        End Sub

        Public Sub New(noId As String)
            Me.New()
            activeAccountId = noId
        End Sub

        Private Sub BuildProductTab()
            productPage = tabMain.TabPages.Cast(Of TabPage)().
                FirstOrDefault(Function(page) String.Equals(page.Text.Trim(), "Detail Produk", StringComparison.OrdinalIgnoreCase))

            If productPage Is Nothing Then
                productPage = New TabPage("Detail Produk")
                tabMain.TabPages.Add(productPage)
            End If

            productPage.Controls.Clear()
            productPage.BackColor = Color.CadetBlue

            Dim title As New Label With {
                .Text = "DETAIL PRODUK PESANAN",
                .Font = New Font("Bookman Old Style", 17.0!, FontStyle.Bold),
                .ForeColor = Color.White,
                .BackColor = Color.Transparent,
                .TextAlign = ContentAlignment.MiddleCenter,
                .Location = New Point(20, 8),
                .Size = New Size(1150, 40),
                .Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            }

            Dim inputPanel As New Panel With {
                .BackColor = SystemColors.ActiveCaption,
                .Location = New Point(20, 53),
                .Size = New Size(1150, 178),
                .Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            }

            txtProdukKodeRuntime = AddProductTextBox(inputPanel, "Kode Produk", 15, 34, 140, True)
            cmbProdukPesananRuntime = AddProductComboBox(inputPanel, "Kode Pesanan", 175, 34, 145)
            cmbProdukLayananRuntime = AddProductComboBox(inputPanel, "Jenis Layanan", 340, 34, 165)
            txtProdukJenisRuntime = AddProductTextBox(inputPanel, "Jenis Sepatu", 525, 34, 155, False)
            txtProdukKondisiRuntime = AddProductTextBox(inputPanel, "Kondisi Sepatu", 700, 34, 155, False)
            txtProdukBahanRuntime = AddProductTextBox(inputPanel, "Bahan Sepatu", 875, 34, 155, False)

            nudProdukJumlahRuntime = AddProductNumber(inputPanel, "Jumlah Sepatu", 15, 104, 140)
            txtProdukHargaRuntime = AddProductTextBox(inputPanel, "Harga Layanan (Rp)", 175, 104, 145, True)
            txtProdukEstimasiRuntime = AddProductTextBox(inputPanel, "Estimasi Pengerjaan", 340, 104, 165, True)

            btnTambahProdukRuntime = AddProductButton(inputPanel, "Tambah", 15, 142, Color.Teal)
            btnUbahProdukRuntime = AddProductButton(inputPanel, "Ubah", 115, 142, Color.LightSeaGreen)
            btnHapusProdukRuntime = AddProductButton(inputPanel, "Hapus", 940, 142, Color.Firebrick)
            btnBersihkanProdukRuntime = AddProductButton(inputPanel, "Bersihkan", 1045, 142, Color.DimGray)

            dgvProdukRuntime = New DataGridView With {
                .Name = "dgvProdukRuntime",
                .Location = New Point(20, 240),
                .Size = New Size(1150, Math.Max(230, productPage.ClientSize.Height - 250)),
                .Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right,
                .AllowUserToAddRows = False,
                .AllowUserToDeleteRows = False,
                .AllowUserToResizeRows = False,
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                .BackgroundColor = SystemColors.ActiveBorder,
                .MultiSelect = False,
                .ReadOnly = True,
                .RowHeadersVisible = False,
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            }
            dgvProdukRuntime.Columns.Add("KodeProduk", "Kode Produk")
            dgvProdukRuntime.Columns.Add("KodePesanan", "Kode Pesanan")
            dgvProdukRuntime.Columns.Add("NamaLayanan", "Jenis Layanan")
            dgvProdukRuntime.Columns.Add("JenisSepatu", "Jenis Sepatu")
            dgvProdukRuntime.Columns.Add("KondisiSepatu", "Kondisi Sepatu")
            dgvProdukRuntime.Columns.Add("BahanSepatu", "Bahan Sepatu")
            dgvProdukRuntime.Columns.Add("JumlahSepatu", "Jumlah")
            dgvProdukRuntime.Columns.Add("HargaLayanan", "Harga (Rp)")
            dgvProdukRuntime.Columns.Add("Estimasi", "Estimasi")
            dgvProdukRuntime.Columns.Add("KodeLayananData", "Kode Layanan")
            dgvProdukRuntime.Columns(9).Visible = False

            productPage.Controls.Add(dgvProdukRuntime)
            productPage.Controls.Add(inputPanel)
            productPage.Controls.Add(title)

            AddHandler cmbProdukLayananRuntime.SelectedValueChanged, AddressOf ProductServiceChanged
            AddHandler dgvProdukRuntime.SelectionChanged, AddressOf ProductGridSelectionChanged
            AddHandler btnTambahProdukRuntime.Click, Sub(sender, e) AddProduct()
            AddHandler btnUbahProdukRuntime.Click, Sub(sender, e) UpdateProduct()
            AddHandler btnHapusProdukRuntime.Click, Sub(sender, e) RemoveProduct()
            AddHandler btnBersihkanProdukRuntime.Click, Sub(sender, e) ClearProductEditor()
        End Sub

        Private Function AddProductLabel(parent As Control, caption As String, x As Integer, y As Integer, width As Integer) As Label
            Dim label As New Label With {
                .Text = caption,
                .Font = New Font("Arial", 9.0!, FontStyle.Bold),
                .ForeColor = Color.White,
                .BackColor = Color.Transparent,
                .Location = New Point(x, y),
                .Size = New Size(width, 20)
            }
            parent.Controls.Add(label)
            Return label
        End Function

        Private Function AddProductTextBox(parent As Control, caption As String, x As Integer, y As Integer,
                                           width As Integer, isReadOnly As Boolean) As TextBox
            AddProductLabel(parent, caption, x, y - 24, width)
            Dim input As New TextBox With {
                .Font = New Font("Arial", 10.0!),
                .Location = New Point(x, y),
                .Size = New Size(width, 27),
                .ReadOnly = isReadOnly
            }
            parent.Controls.Add(input)
            Return input
        End Function

        Private Function AddProductComboBox(parent As Control, caption As String, x As Integer, y As Integer,
                                            width As Integer) As ComboBox
            AddProductLabel(parent, caption, x, y - 24, width)
            Dim input As New ComboBox With {
                .Font = New Font("Arial", 10.0!),
                .Location = New Point(x, y),
                .Size = New Size(width, 27),
                .DropDownStyle = ComboBoxStyle.DropDownList
            }
            parent.Controls.Add(input)
            Return input
        End Function

        Private Function AddProductNumber(parent As Control, caption As String, x As Integer, y As Integer,
                                          width As Integer) As NumericUpDown
            AddProductLabel(parent, caption, x, y - 24, width)
            Dim input As New NumericUpDown With {
                .Font = New Font("Arial", 10.0!),
                .Location = New Point(x, y),
                .Size = New Size(width, 27),
                .Minimum = 1D,
                .Maximum = 1000D,
                .Value = 1D,
                .ThousandsSeparator = True
            }
            parent.Controls.Add(input)
            Return input
        End Function

        Private Function AddProductButton(parent As Control, caption As String, x As Integer, y As Integer,
                                          backColor As Color) As Button
            Dim button As New Button With {
                .Text = caption,
                .Font = New Font("Arial", 9.0!, FontStyle.Bold),
                .BackColor = backColor,
                .ForeColor = Color.White,
                .FlatStyle = FlatStyle.Flat,
                .Location = New Point(x, y),
                .Size = New Size(92, 30),
                .UseVisualStyleBackColor = False
            }
            parent.Controls.Add(button)
            Return button
        End Function

        Private Sub BindPageActions()
            BindCrud(dgvPenjualan, New Control() {txtPenjualanKode, txtPenjualanPesanan, dtpPenjualanTanggal, txtPenjualanTotal, txtPenjualanMetode, txtPenjualanJumlah},
                     btnTambahPenjualan, btnUbahPenjualan, btnHapusPenjualan, btnBersihkanPenjualan, "Penjualan",
                     AddressOf ReloadData, AddressOf SaveSale, AddressOf DeleteSale, AddressOf PreviewSale)
            BindCrud(dgvPesanan, New Control() {txtPesananNo, txtPesananPelanggan, txtPesananLayanan, dtpPesananTanggal, txtPesananStatus},
                     btnTambahPesanan, btnUbahPesanan, btnHapusPesanan, btnBersihkanPesanan, "Pesanan",
                     AddressOf ReloadData, AddressOf SaveOrder, Sub(code) DeleteRecord(Orders, "Kode_Pesanan", code))
            BindSearch(dgvCekLayanan, txtCariCekLayanan)
            BindSearch(dgvCekPengerjaan, txtCariCekPengerjaan)
        End Sub

        Private Sub ReloadData()
            Dim codes As New AutoCompleteStringCollection()
            For Each order As DataRow In ReadRows("SELECT Kode_Pesanan FROM Data_Pemesanan ORDER BY Kode_Pesanan").Rows
                codes.Add(CStr(order("Kode_Pesanan")))
            Next
            txtPenjualanPesanan.AutoCompleteCustomSource = codes
            txtPenjualanPesanan.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtPenjualanPesanan.AutoCompleteMode = AutoCompleteMode.SuggestAppend

            LoadGrid(dgvPenjualan, SelectSales)
            LoadGrid(dgvPesanan, SelectOrders)
            LoadGrid(dgvCekLayanan, SelectServices)
            LoadGrid(dgvCekPengerjaan, SelectJobSummary)

            LoadProductChoices()
            LoadGrid(dgvProdukRuntime, SelectProducts, keyColumn:=0)
            ClearProductEditor()
        End Sub

        Private Sub LoadProductChoices()
            cmbProdukPesananRuntime.Items.Clear()
            For Each row As DataRow In ReadRows("SELECT Kode_Pesanan FROM Data_Pemesanan ORDER BY Kode_Pesanan").Rows
                cmbProdukPesananRuntime.Items.Add(Convert.ToString(row("Kode_Pesanan")))
            Next

            productServiceCatalog = ReadRows(SelectServices)
            cmbProdukLayananRuntime.DataSource = Nothing
            cmbProdukLayananRuntime.DisplayMember = "Nama_Layanan"
            cmbProdukLayananRuntime.ValueMember = "Kode_Layanan"
            cmbProdukLayananRuntime.DataSource = productServiceCatalog
            cmbProdukLayananRuntime.SelectedIndex = -1
        End Sub

        Private Sub ProductServiceChanged(sender As Object, e As EventArgs)
            If loadingProductEditor Then Return
            Dim selected = TryCast(cmbProdukLayananRuntime.SelectedItem, DataRowView)
            If selected Is Nothing Then
                txtProdukHargaRuntime.Clear()
                txtProdukEstimasiRuntime.Clear()
                Return
            End If
            txtProdukHargaRuntime.Text = Convert.ToDecimal(selected("Harga_Layanan")).ToString("0.##", CultureInfo.InvariantCulture)
            txtProdukEstimasiRuntime.Text = Convert.ToString(selected("Estimasi_Pengerjaan"))
        End Sub

        Private Sub ProductGridSelectionChanged(sender As Object, e As EventArgs)
            If loadingProductEditor Then Return
            Dim row = dgvProdukRuntime.CurrentRow
            If row Is Nothing OrElse row.IsNewRow OrElse row.Tag Is Nothing Then Return

            loadingProductEditor = True
            txtProdukKodeRuntime.Text = Convert.ToString(row.Cells(0).Value)
            cmbProdukPesananRuntime.SelectedItem = Convert.ToString(row.Cells(1).Value)
            cmbProdukLayananRuntime.SelectedValue = Convert.ToString(row.Cells(9).Value)
            txtProdukJenisRuntime.Text = Convert.ToString(row.Cells(3).Value)
            txtProdukKondisiRuntime.Text = Convert.ToString(row.Cells(4).Value)
            txtProdukBahanRuntime.Text = Convert.ToString(row.Cells(5).Value)

            Dim quantity As Integer
            If Integer.TryParse(Convert.ToString(row.Cells(6).Value), quantity) Then
                nudProdukJumlahRuntime.Value = Math.Max(nudProdukJumlahRuntime.Minimum,
                                                        Math.Min(nudProdukJumlahRuntime.Maximum, quantity))
            Else
                nudProdukJumlahRuntime.Value = 1D
            End If

            txtProdukHargaRuntime.Text = Convert.ToString(row.Cells(7).Value)
            txtProdukEstimasiRuntime.Text = Convert.ToString(row.Cells(8).Value)
            loadingProductEditor = False
        End Sub

        Private Function NextProductCode() As String
            Dim highest As Integer = 0
            For Each row As DataRow In ReadRows("SELECT Kode_Produk FROM Data_Produk").Rows
                Dim code = Convert.ToString(row("Kode_Produk")).Trim()
                If code.StartsWith("PRD", StringComparison.OrdinalIgnoreCase) AndAlso code.Length > 3 Then
                    Dim number As Integer
                    If Integer.TryParse(code.Substring(3), NumberStyles.None, CultureInfo.InvariantCulture, number) Then
                        highest = Math.Max(highest, number)
                    End If
                End If
            Next
            Return "PRD" & (highest + 1).ToString("000", CultureInfo.InvariantCulture)
        End Function

        Private Sub ClearProductEditor()
            loadingProductEditor = True
            txtProdukKodeRuntime.Text = ""
            cmbProdukPesananRuntime.SelectedIndex = -1
            cmbProdukLayananRuntime.SelectedIndex = -1
            txtProdukJenisRuntime.Clear()
            txtProdukKondisiRuntime.Clear()
            txtProdukBahanRuntime.Clear()
            nudProdukJumlahRuntime.Value = 1D
            txtProdukHargaRuntime.Clear()
            txtProdukEstimasiRuntime.Clear()
            loadingProductEditor = False

            Try
                txtProdukKodeRuntime.Text = NextProductCode()
            Catch
                txtProdukKodeRuntime.Text = ""
            End Try
            dgvProdukRuntime.ClearSelection()
            dgvProdukRuntime.CurrentCell = Nothing
        End Sub

        Private Sub AddProduct()
            Try
                SaveProduct(Nothing)
                ReloadData()
                MessageBox.Show("Detail produk berhasil ditambahkan.", "Detail Produk", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Gagal menambahkan produk. " & ex.Message, "Detail Produk", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End Sub

        Private Sub UpdateProduct()
            Dim row = ActualSelection(dgvProdukRuntime)
            If row Is Nothing Then
                MessageBox.Show("Pilih detail produk yang ingin diubah.", "Detail Produk")
                Return
            End If
            Try
                SaveProduct(Convert.ToString(row.Tag))
                ReloadData()
                MessageBox.Show("Detail produk berhasil diubah.", "Detail Produk", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Gagal mengubah produk. " & ex.Message, "Detail Produk", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End Sub

        Private Sub SaveProduct(previousCode As String)
            Dim productCode = If(previousCode Is Nothing, NextProductCode(), previousCode)
            Dim orderCode = RequireCode(Convert.ToString(cmbProdukPesananRuntime.SelectedItem), "PM")
            Dim serviceCode = RequireCode(Convert.ToString(cmbProdukLayananRuntime.SelectedValue), "LY")
            Dim shoeType = RequireText(txtProdukJenisRuntime.Text, "jenis sepatu")
            Dim condition = RequireText(txtProdukKondisiRuntime.Text, "kondisi sepatu")
            Dim material = RequireText(txtProdukBahanRuntime.Text, "bahan sepatu")
            Dim quantity = CInt(nudProdukJumlahRuntime.Value)

            Dim service = ReadRows(
                "SELECT Harga_Layanan, Estimasi_Pengerjaan FROM Data_Layanan WHERE Kode_Layanan = ?",
                serviceCode)
            If service.Rows.Count <> 1 OrElse service.Rows(0).IsNull("Harga_Layanan") Then
                Throw New ArgumentException("Layanan yang dipilih belum memiliki harga.")
            End If

            Dim price = CDec(service.Rows(0)("Harga_Layanan"))
            Dim estimate = RequireText(Convert.ToString(service.Rows(0)("Estimasi_Pengerjaan")), "estimasi pengerjaan")
            Dim columns As String() = {
                "Kode_Pesanan", "Kode_Layanan", "Jenis_Sepatu", "Kondisi_Sepatu",
                "Bahan_Sepatu", "Jumlah_Sepatu", "Harga_Layanan_Transaksi", "Estimasi_Pengerjaan"
            }
            Dim values As Object() = {
                orderCode, serviceCode, shoeType, condition, material, quantity, price, estimate
            }

            SaveRecord(Products, "Kode_Produk", previousCode, productCode, columns, values)
        End Sub

        Private Sub RemoveProduct()
            Dim row = ActualSelection(dgvProdukRuntime)
            If row Is Nothing Then Return

            Dim productCode = Convert.ToString(row.Tag)
            If MessageBox.Show("Hapus detail produk " & productCode & "?", "Konfirmasi",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

            Try
                Dim jobs = ReadRows("SELECT COUNT(*) AS Jumlah FROM Data_Pengerjaan WHERE Kode_Produk = ?", productCode)
                If jobs.Rows.Count > 0 AndAlso Convert.ToInt32(jobs.Rows(0)("Jumlah")) > 0 Then
                    Throw New InvalidOperationException("Produk sudah memiliki data pengerjaan dan tidak dapat dihapus.")
                End If
                DeleteRecord(Products, "Kode_Produk", productCode)
                ReloadData()
            Catch ex As Exception
                MessageBox.Show("Gagal menghapus produk. " & ex.Message, "Detail Produk", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End Sub

        Private Function ReadOrderProductTotals(orderCode As String) As DataRow
            Dim totals = ReadRows(
                "SELECT SUM(Jumlah_Sepatu) AS TotalJumlah, SUM(Jumlah_Sepatu * Harga_Layanan_Transaksi) AS TotalBiaya " &
                "FROM Data_Produk WHERE Kode_Pesanan = ?",
                orderCode)
            If totals.Rows.Count = 0 Then Return Nothing
            Return totals.Rows(0)
        End Function

        Private Sub PreviewSale()
            Dim orderCode = txtPenjualanPesanan.Text.Trim().ToUpperInvariant()
            If orderCode.Length = 0 Then
                txtPenjualanJumlah.Text = ""
                txtPenjualanTotal.Text = ""
                Return
            End If

            Try
                Dim totals = ReadOrderProductTotals(orderCode)
                If totals IsNot Nothing AndAlso Not totals.IsNull("TotalJumlah") AndAlso Not totals.IsNull("TotalBiaya") Then
                    Dim quantity = Convert.ToInt32(totals("TotalJumlah"))
                    Dim total = CDec(totals("TotalBiaya"))
                    txtPenjualanJumlah.Text = quantity.ToString(CultureInfo.InvariantCulture)
                    txtPenjualanTotal.Text = DecimalText(total)
                    Return
                End If

                Dim current = dgvPenjualan.CurrentRow
                If current IsNot Nothing AndAlso
                   String.Equals(Convert.ToString(current.Cells(1).Value), orderCode, StringComparison.OrdinalIgnoreCase) Then
                    txtPenjualanJumlah.Text = Convert.ToString(current.Cells(5).Value)
                    txtPenjualanTotal.Text = Convert.ToString(current.Cells(3).Value)
                    Return
                End If
            Catch
            End Try

            txtPenjualanJumlah.Text = ""
            txtPenjualanTotal.Text = ""
        End Sub

        Private Sub SaveSale(previousCode As String, fields As String())
            Dim code = RequireCode(fields(0), "PJ")
            Dim orderCode = RequireCode(fields(1), "PM")
            Dim pickup = DateText(RequireDate(fields(2)))
            Dim paymentStatus = RequireText(fields(4), "status pembayaran")

            If previousCode IsNot Nothing Then
                Dim currentSale = ReadRows(
                    "SELECT Status_Penjualan FROM Data_Penjualan WHERE Kode_Penjualan = ?",
                    previousCode)

                If currentSale.Rows.Count <> 1 Then
                    Throw New InvalidOperationException("Data penjualan sudah tidak tersedia.")
                End If

                Dim currentStatus = If(currentSale.Rows(0).IsNull("Status_Penjualan"),
                                       "Menunggu",
                                       Convert.ToString(currentSale.Rows(0)("Status_Penjualan")).Trim())

                If currentStatus <> "" AndAlso
                   Not String.Equals(currentStatus, "Menunggu", StringComparison.OrdinalIgnoreCase) Then
                    Throw New ArgumentException("Penjualan yang sudah diputuskan Owner tidak dapat diubah oleh kasir.")
                End If
            End If

            Dim quantity As Integer = 0
            Dim total As Decimal = 0D
            Dim totals = ReadOrderProductTotals(orderCode)
            If totals IsNot Nothing AndAlso Not totals.IsNull("TotalJumlah") AndAlso Not totals.IsNull("TotalBiaya") Then
                quantity = Convert.ToInt32(totals("TotalJumlah"))
                total = CDec(totals("TotalBiaya"))
            End If

            If quantity < 1 OrElse total <= 0D Then
                If previousCode IsNot Nothing Then
                    Dim oldSale = ReadRows(
                        "SELECT Jumlah_Sepatu, Harga_Layanan_Transaksi, Total_Biaya FROM Data_Penjualan WHERE Kode_Penjualan = ? AND Kode_Pemesanan = ?",
                        code, orderCode)
                    If oldSale.Rows.Count = 1 Then
                        Integer.TryParse(Convert.ToString(oldSale.Rows(0)("Jumlah_Sepatu")), quantity)
                        If Not oldSale.Rows(0).IsNull("Total_Biaya") Then
                            TryReadAmount(Convert.ToString(oldSale.Rows(0)("Total_Biaya")), total)
                        End If
                    End If
                End If
            End If

            If quantity < 1 OrElse total <= 0D Then
                Throw New ArgumentException("Pesanan ini belum memiliki detail produk. Tambahkan sepatu pada tab Detail Produk terlebih dahulu.")
            End If

            Dim averageRate = Decimal.Round(total / quantity, 2)
            Dim columns As String() = {
                "Kode_Pemesanan", "Tanggal_Pengambilan", "Total_Biaya",
                "Status_Pembayaran", "Jumlah_Sepatu", "Harga_Layanan_Transaksi"
            }
            Dim values As Object() = {
                orderCode, pickup, DecimalText(total), paymentStatus,
                quantity.ToString(CultureInfo.InvariantCulture), averageRate
            }

            If previousCode Is Nothing Then
                Array.Resize(columns, columns.Length + 2)
                Array.Resize(values, values.Length + 2)
                columns(columns.Length - 2) = "No_ID"
                columns(columns.Length - 1) = "Status_Penjualan"
                values(values.Length - 2) = activeAccountId
                values(values.Length - 1) = "Menunggu"
            End If

            SaveRecord(Sales, "Kode_Penjualan", previousCode, code, columns, values)
        End Sub

        Private Sub DeleteSale(code As String)
            Dim sale = ReadRows(
                "SELECT Status_Penjualan FROM Data_Penjualan WHERE Kode_Penjualan = ?",
                code)

            If sale.Rows.Count <> 1 Then
                Throw New InvalidOperationException("Data penjualan sudah tidak tersedia.")
            End If

            Dim status = If(sale.Rows(0).IsNull("Status_Penjualan"),
                            "Menunggu",
                            Convert.ToString(sale.Rows(0)("Status_Penjualan")).Trim())

            If status <> "" AndAlso
               Not String.Equals(status, "Menunggu", StringComparison.OrdinalIgnoreCase) Then
                Throw New ArgumentException("Penjualan yang sudah diputuskan Owner tidak dapat dihapus oleh kasir.")
            End If

            DeleteRecord(Sales, "Kode_Penjualan", code)
        End Sub

        Private Sub SaveOrder(previousCode As String, fields As String())
            Dim code = RequireCode(fields(0), "PM")
            Dim customer = RequireText(fields(1), "nama pelanggan")
            Dim serviceCode = RequireCode(fields(2), "LY")
            Dim orderDate = RequireDate(fields(3))
            Dim status = RequireText(fields(4), "status pesanan")
            Dim service = ReadRows("SELECT Estimasi_Pengerjaan FROM Data_Layanan WHERE Kode_Layanan = ?", serviceCode)
            If service.Rows.Count = 0 Then Throw New ArgumentException("Kode layanan belum terdaftar.")
            If previousCode Is Nothing Then
                SaveRecord(Orders, "Kode_Pesanan", Nothing, code,
                           {"Nama_Konsumen", "Kode_Layanan", "Tanggal_Pemesanan", "Status_Pesanan", "Estimasi_Pengerjaan", "No_ID"},
                           {customer, serviceCode, orderDate, status, Convert.ToString(service.Rows(0)(0)), activeAccountId})
            Else
                SaveRecord(Orders, "Kode_Pesanan", previousCode, code,
                           {"Nama_Konsumen", "Kode_Layanan", "Tanggal_Pemesanan", "Status_Pesanan"},
                           {customer, serviceCode, orderDate, status})
            End If
        End Sub

        Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

        End Sub
    End Class
End Namespace
