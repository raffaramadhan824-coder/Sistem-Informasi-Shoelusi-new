Imports System
Imports System.Windows.Forms

Namespace Shoelusi
    Partial Public Class FrmPemilik
        Private activeAccountId As String
        Private isReloadingSales As Boolean

        Public Sub New()
            InitializeComponent()
            tpCekPenjualan.Text = "Penjualan"
            lblTitleCekPenjualan.Text = "PENJUALAN"

            Dim statusColumn As New DataGridViewCheckBoxColumn()
            statusColumn.Name = "StatusPenjualanOwner"
            statusColumn.HeaderText = "Status Penjualan"
            statusColumn.ToolTipText = "Dicentang = Disetujui; kosong = Ditolak; tanda minus = Menunggu"
            statusColumn.TrueValue = "Disetujui"
            statusColumn.FalseValue = "Ditolak"
            statusColumn.IndeterminateValue = "Menunggu"
            statusColumn.ValueType = GetType(String)
            statusColumn.ThreeState = True
            statusColumn.Width = 110
            dgvCekPenjualan.Columns.Add(statusColumn)

            dgvCekPenjualan.ReadOnly = False
            For Each column As DataGridViewColumn In dgvCekPenjualan.Columns
                column.ReadOnly = True
            Next
            statusColumn.ReadOnly = False

            AddHandler dgvCekPenjualan.CurrentCellDirtyStateChanged,
                Sub(sender, e)
                    If dgvCekPenjualan.IsCurrentCellDirty AndAlso
                       dgvCekPenjualan.CurrentCell IsNot Nothing AndAlso
                       dgvCekPenjualan.CurrentCell.OwningColumn.Name = "StatusPenjualanOwner" Then
                        dgvCekPenjualan.CommitEdit(DataGridViewDataErrorContexts.Commit)
                    End If
                End Sub
            AddHandler dgvCekPenjualan.CellValueChanged, AddressOf SaveSalesStatusFromGrid

            BindPageActions()
            BindSearch(dgvAkun)
            BindSearch(dgvPersetujuanBB)
            BindSearch(dgvDataLayanan)
            AddHandler btnLogout.Click, AddressOf LogoutClick
            AddHandler Me.Load, Sub(sender, e) ReloadData()
        End Sub

        Public Sub New(noId As String)
            Me.New()
            activeAccountId = noId
        End Sub

        Private Sub LogoutClick(sender As Object, e As EventArgs)
            Me.Close()
        End Sub

        Private Sub BindPageActions()
            dgvAkunCol5.Visible = False
            txtAkunStatus.UseSystemPasswordChar = True
            AddHandler btnTambahAkun.Click, Sub(sender, e) SaveAccount(True)
            AddHandler btnUbahAkun.Click, Sub(sender, e) SaveAccount(False)
            AddHandler btnHapusAkun.Click, AddressOf DeleteAccount
            AddHandler btnBersihkanAkun.Click, Sub(sender, e) ClearAccountInputs()
            AddHandler dgvAkun.CurrentCellChanged, Sub(sender, e) ShowSelectedAccount()
            AddHandler btnSetujuiPersetujuanBB.Click, Sub(sender, e) SetStatusPengadaan("Disetujui")
            AddHandler btnTolakPersetujuanBB.Click, Sub(sender, e) SetStatusPengadaan("Ditolak")
            BindCrud(dgvDataLayanan, New Control() {txtLayananKode, txtLayananNama, txtLayananDeskripsi, txtLayananHarga, txtLayananEstimasi},
                     btnTambahDataLayanan, btnUbahDataLayanan, btnHapusDataLayanan, btnBersihkanDataLayanan, "Data Layanan",
                     AddressOf ReloadData, AddressOf SaveService, Sub(code) DeleteRecord(Services, "Kode_Layanan", code))
            ModuleUtama.BindSearch(Me.dgvCekPenjualan, Me.txtCariCekPenjualan)
        End Sub

        Private Sub ReloadData()
            LoadAccounts()
            LoadGrid(dgvPersetujuanBB, SelectApprovals)
            LoadGrid(dgvDataLayanan, SelectServices)
            ReloadSalesGrid()
        End Sub

        Private Sub ReloadSalesGrid()
            isReloadingSales = True
            Try
                LoadGrid(dgvCekPenjualan, SelectSalesSummary, keyColumn:=0)
            Finally
                isReloadingSales = False
            End Try
        End Sub

        Private Sub SaveSalesStatusFromGrid(sender As Object, e As DataGridViewCellEventArgs)
            If isReloadingSales OrElse e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Return
            If dgvCekPenjualan.Columns(e.ColumnIndex).Name <> "StatusPenjualanOwner" Then Return

            Dim row = dgvCekPenjualan.Rows(e.RowIndex)
            If row.IsNewRow OrElse row.Tag Is Nothing Then Return

            Dim saleCode = Convert.ToString(row.Tag)
            Dim newStatus = Convert.ToString(row.Cells(e.ColumnIndex).Value).Trim()

            If newStatus <> "Menunggu" AndAlso newStatus <> "Disetujui" AndAlso newStatus <> "Ditolak" Then
                MessageBox.Show("Status penjualan tidak dikenali.", "Penjualan")
                ReloadSalesGrid()
                Return
            End If

            Try
                Dim currentSale = ReadRows(
                    "SELECT Status_Penjualan FROM Data_Penjualan WHERE Kode_Penjualan = ?",
                    saleCode)

                If currentSale.Rows.Count <> 1 Then
                    Throw New InvalidOperationException("Data penjualan sudah tidak tersedia.")
                End If

                Dim rawStatus As String = Nothing
                If Not currentSale.Rows(0).IsNull("Status_Penjualan") Then
                    rawStatus = Convert.ToString(currentSale.Rows(0)("Status_Penjualan")).Trim()
                End If

                Dim currentStatus = If(String.IsNullOrEmpty(rawStatus), "Menunggu", rawStatus)

                If currentStatus <> "Menunggu" AndAlso currentStatus <> "Disetujui" AndAlso currentStatus <> "Ditolak" Then
                    Throw New InvalidOperationException("Status penjualan di database tidak dikenali: " & currentStatus)
                End If

                If String.Equals(currentStatus, newStatus, StringComparison.OrdinalIgnoreCase) Then
                    ReloadSalesGrid()
                    Return
                End If

                Dim confirmation = MessageBox.Show(
                    "Ubah status penjualan " & saleCode & " dari " & currentStatus & " menjadi " & newStatus & "?",
                    "Konfirmasi Status Penjualan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)

                If confirmation <> DialogResult.Yes Then
                    ReloadSalesGrid()
                    Return
                End If

                Dim changed As Integer
                If rawStatus Is Nothing Then
                    changed = ExecuteChange(
                        "UPDATE Data_Penjualan SET Status_Penjualan = ? WHERE Kode_Penjualan = ? AND Status_Penjualan IS NULL",
                        newStatus, saleCode)
                Else
                    changed = ExecuteChange(
                        "UPDATE Data_Penjualan SET Status_Penjualan = ? WHERE Kode_Penjualan = ? AND Status_Penjualan = ?",
                        newStatus, saleCode, rawStatus)
                End If

                If changed <> 1 Then
                    Throw New InvalidOperationException("Status penjualan berubah. Muat ulang data dan coba lagi.")
                End If

                MessageBox.Show("Status penjualan berhasil diubah menjadi " & newStatus & ".", "Penjualan")
                ReloadSalesGrid()

            Catch ex As Exception
                MessageBox.Show("Gagal memperbarui status penjualan. " & ex.Message, "Penjualan")
                ReloadSalesGrid()
            End Try
        End Sub

        Private Sub SaveService(previousCode As String, fields As String())
            Dim code = RequireCode(fields(0), "LY")
            Dim name = RequireText(fields(1), "nama layanan")
            Dim category = RequireText(fields(2), "jenis layanan")
            Dim price = RequireAmount(fields(3), "harga", True)
            Dim estimate = RequireText(fields(4), "estimasi pengerjaan")
            If previousCode Is Nothing Then
                SaveRecord(Services, "Kode_Layanan", Nothing, code,
                           {"Nama_Layanan", "Jenis_Layanan", "Harga_Layanan", "Estimasi_Pengerjaan", "No_ID"},
                           {name, category, price, estimate, activeAccountId})
            Else
                SaveRecord(Services, "Kode_Layanan", previousCode, code,
                           {"Nama_Layanan", "Jenis_Layanan", "Harga_Layanan", "Estimasi_Pengerjaan"},
                           {name, category, price, estimate})
            End If
        End Sub

        Private Sub LoadAccounts()
            ModuleUtama.LoadGrid(dgvAkun, "SELECT [No_ID], [Nama], [Divisi] FROM [Data Akun] ORDER BY [No_ID]")
            ClearAccountInputs()
        End Sub

        Private Sub ClearAccountInputs()
            dgvAkun.CurrentCell = Nothing
            dgvAkun.ClearSelection()
            ModuleUtama.ClearInputs(New TextBox() {txtAkunID, txtAkunNama, txtAkunRole, txtAkunStatus})
            txtAkunID.ReadOnly = False
        End Sub

        Private Sub ShowSelectedAccount()
            Dim row = dgvAkun.CurrentRow
            If row Is Nothing Then Return
            txtAkunID.Text = Convert.ToString(row.Cells(0).Value)
            txtAkunNama.Text = Convert.ToString(row.Cells(1).Value)
            txtAkunRole.Text = Convert.ToString(row.Cells(2).Value)
            txtAkunStatus.Clear()
            txtAkunID.ReadOnly = True
        End Sub

        Private Sub SaveAccount(adding As Boolean)
            Dim row = ActualSelection(dgvAkun)
            If Not adding AndAlso row Is Nothing Then
                MessageBox.Show("Pilih akun yang ingin diubah.", "Data Akun")
                Return
            End If

            Dim id = txtAkunID.Text.Trim()
            Dim name = txtAkunNama.Text.Trim()
            Dim division = ModuleUtama.AccountDivision(txtAkunRole.Text)
            If id = "" OrElse name = "" OrElse division = "" Then
                MessageBox.Show("Isi No ID, nama, dan salah satu divisi: Kasir, Teknisi, Staf Gudang, atau Pemilik.", "Data Akun")
                Return
            End If
            If String.Equals(id, activeAccountId, StringComparison.OrdinalIgnoreCase) AndAlso division <> "Pemilik" Then
                MessageBox.Show("Divisi akun yang sedang digunakan harus tetap Pemilik.", "Data Akun")
                Return
            End If
            Dim changePin As Boolean = adding OrElse txtAkunStatus.Text.Length > 0
            Dim pin As Integer
            If changePin AndAlso Not ModuleUtama.TryReadPin(txtAkunStatus.Text, pin) Then
                MessageBox.Show("Masukkan kata sandi berupa angka tanpa nol di depan, maksimal 2147483647.", "Data Akun")
                Return
            End If

            Try
                Dim changed As Integer
                If adding Then
                    id = RequireCode(id, "SL")
                    changed = ModuleUtama.ExecuteChange("INSERT INTO [Data Akun] ([No_ID], [Nama], [Divisi], [Kata Sandi]) VALUES (?, ?, ?, ?)", id, name, division, pin)
                ElseIf changePin Then
                    changed = ModuleUtama.ExecuteChange("UPDATE [Data Akun] SET [Nama] = ?, [Divisi] = ?, [Kata Sandi] = ? WHERE [No_ID] = ?", name, division, pin, id)
                Else
                    changed = ModuleUtama.ExecuteChange("UPDATE [Data Akun] SET [Nama] = ?, [Divisi] = ? WHERE [No_ID] = ?", name, division, id)
                End If
                If changed <> 1 Then Throw New InvalidOperationException("Akun yang dipilih sudah tidak tersedia.")
            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan akun. " & ex.Message, "Data Akun")
                Return
            End Try
            RefreshAfterWrite(AddressOf LoadAccounts)
        End Sub

        Private Sub DeleteAccount(sender As Object, e As EventArgs)
            Dim row = ActualSelection(dgvAkun)
            If row Is Nothing Then Return
            Dim id = Convert.ToString(row.Cells(0).Value)
            If String.Equals(id, activeAccountId, StringComparison.OrdinalIgnoreCase) Then
                MessageBox.Show("Akun yang sedang digunakan tidak bisa dihapus.", "Data Akun")
                Return
            End If
            If MessageBox.Show("Hapus akun " & id & "?", "Data Akun", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
            Try
                For Each table In {"Data_Layanan", "Data_Pemesanan", "Data_Penjualan", "Data_Penggunaan_Bahan_Baku", "Data_Pengadaan_Bahan_Baku", "Data_Pengerjaan"}
                    If CInt(ModuleUtama.ReadRows("SELECT COUNT(*) FROM [" & table & "] WHERE [No_ID] = ?", id).Rows(0)(0)) > 0 Then
                        MessageBox.Show("Akun ini masih terhubung dengan data di " & table & ".", "Data Akun")
                        Return
                    End If
                Next
                ModuleUtama.ExecuteChange("DELETE FROM [Data Akun] WHERE [No_ID] = ?", id)
                LoadAccounts()
            Catch ex As Exception
                MessageBox.Show("Gagal menghapus akun. " & ex.Message, "Data Akun")
            End Try
        End Sub

        Private Sub SetStatusPengadaan(status As String)
            Dim row = ActualSelection(dgvPersetujuanBB)

            If row Is Nothing Then
                MessageBox.Show("Pilih pengadaan yang ingin diputuskan.", "Persetujuan Pengadaan")
                Return
            End If

            Dim purchaseCode = Convert.ToString(row.Tag)
            Dim currentStatus = Convert.ToString(row.Cells(4).Value).Trim()
            Dim newStatus = status.Trim()

            If Not String.Equals(newStatus, "Disetujui", StringComparison.OrdinalIgnoreCase) AndAlso
       Not String.Equals(newStatus, "Ditolak", StringComparison.OrdinalIgnoreCase) Then
                MessageBox.Show("Status tujuan tidak valid.", "Persetujuan Pengadaan")
                Return
            End If

            If String.Equals(currentStatus, "Diterima", StringComparison.OrdinalIgnoreCase) Then
                MessageBox.Show("Pengadaan yang sudah diterima tidak dapat diubah keputusannya.", "Persetujuan Pengadaan")
                Return
            End If

            If Not String.Equals(currentStatus, "Menunggu", StringComparison.OrdinalIgnoreCase) AndAlso
       Not String.Equals(currentStatus, "Disetujui", StringComparison.OrdinalIgnoreCase) AndAlso
       Not String.Equals(currentStatus, "Ditolak", StringComparison.OrdinalIgnoreCase) Then
                MessageBox.Show("Status pengadaan tidak dikenali.", "Persetujuan Pengadaan")
                Return
            End If

            If String.Equals(currentStatus, newStatus, StringComparison.OrdinalIgnoreCase) Then
                MessageBox.Show("Pengadaan sudah berstatus " & newStatus & ".", "Persetujuan Pengadaan")
                Return
            End If

            Dim confirmation = MessageBox.Show(
        "Apakah Anda yakin ingin mengubah status pengadaan " & purchaseCode &
        " dari " & currentStatus & " menjadi " & newStatus & "?",
        "Konfirmasi Perubahan Status",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

            If confirmation <> DialogResult.Yes Then Return

            Try
                Dim changed = ExecuteChange(
            "UPDATE Data_Pengadaan_Bahan_Baku SET Status_Pengadaan = ? " &
            "WHERE Kode_Pengadaan = ? AND Status_Pengadaan IN (?, ?, ?)",
            newStatus, purchaseCode, "Menunggu", "Disetujui", "Ditolak")

                If changed <> 1 Then
                    MessageBox.Show("Status tidak berhasil diubah. Periksa kembali data pengadaan.", "Persetujuan Pengadaan")
                Else
                    MessageBox.Show("Status pengadaan berhasil diubah menjadi " & newStatus & ".", "Persetujuan Pengadaan")
                End If

                LoadGrid(dgvPersetujuanBB, SelectApprovals)

            Catch ex As Exception
                MessageBox.Show("Gagal memperbarui pengadaan. " & ex.Message, "Persetujuan Pengadaan")
            End Try
        End Sub

        Private Sub FrmPemilik_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace