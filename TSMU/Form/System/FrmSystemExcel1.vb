﻿Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports DevExpress.XtraEditors.Controls

Public Class FrmSystemExcel1
    Dim fc_class As New clsSales_Budget
    Dim GridData As DataTable = Nothing
    Dim Gridfilter As DataTable = Nothing
    Dim a As Integer = 0
    Dim b As Integer = 0
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByRef dt As DataTable, ByVal x As Integer)
        ' This call is required by the Windows Form Designer.
        Me.New()
        ' Add any initialization after the InitializeComponent() call.
        GridData = dt
        a = x
    End Sub
    ReadOnly Property Tahun As String
        Get
            Return _cmbTahun.Text.Trim
        End Get
    End Property
    ReadOnly Property Tahun1 As String
        Get
            Return TxtTahun2.Text.Trim
        End Get
    End Property
    ReadOnly Property Customer As String
        Get
            Return _cmbCust.Text.Trim
        End Get
    End Property

    ReadOnly Property Bulan As String
        Get
            Return _cmbBulan.Text.Trim
        End Get
    End Property

    ReadOnly Property tab As Integer
        Get
            Return XtraTabControl1.SelectedTabPageIndex
        End Get
    End Property
    Private Sub FrmSystemExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillComboTahun()
        FillComboTahun1()
        FillComboCustomer()
        FillComboBulan()
        lblStatus.Text = ""
        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub
    Private Sub FillComboTahun()
        Dim tahun() As String = {"", DateTime.Today.Year.ToString, (DateTime.Today.Year - 1).ToString, (DateTime.Today.Year - 2).ToString}
        _cmbTahun.Properties.Items.Clear()
        For Each var As String In tahun
            _cmbTahun.Properties.Items.Add(var)
        Next
    End Sub
    Private Sub FillComboTahun1()
        Dim tahun() As String = {"", DateTime.Today.Year.ToString, (DateTime.Today.Year - 1).ToString, (DateTime.Today.Year - 2).ToString}
        TxtTahun2.Properties.Items.Clear()
        For Each var As String In tahun
            TxtTahun2.Properties.Items.Add(var)
        Next
    End Sub

    Private Sub FillComboBulan()
        Dim tahun() As String = {"", "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "November", "Desember"}
        _cmbBulan.Properties.Items.Clear()
        For Each var As String In tahun
            _cmbBulan.Properties.Items.Add(var)
        Next
    End Sub

    Private Sub FillComboCustomer()
        Dim dtTabel As New DataTable
        dtTabel = fc_class.getCusstID_Solomon
        Dim dr As DataRow = dtTabel.NewRow
        dr("CustId") = ""
        dtTabel.Rows.InsertAt(dr, 0)
        _cmbCust.Properties.Items.Clear()
        For i As Integer = 0 To dtTabel.Rows.Count - 1
            _cmbCust.Properties.Items.Add(dtTabel.Rows(i)("CustId"))
        Next
    End Sub
    Dim path As String
    Dim path2 As String

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
            MessageBox.Show("Exception Occured while releasing object " + ex.ToString())
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub _txtExcel_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles _txtExcel.ButtonClick
        Try
            OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
            Dim result As DialogResult = OpenFileDialog1.ShowDialog()
            ' Test result.
            If result = Windows.Forms.DialogResult.OK Then
                path = OpenFileDialog1.FileName
                'path = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
                'MsgBox(path)
                Dim text As String = System.IO.File.ReadAllText(path)
                _txtExcel.Text = path
                'Me.Text = text.Length.ToString
            End If
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub

    Private Sub _btnExport_Click(sender As Object, e As EventArgs) Handles _btnExport.Click
        Try
            If XtraTabControl1.SelectedTabPageIndex = 0 Then
                If lblStatus.Text <> "" Then
                    Throw New Exception("Proses masih berjalan !")
                End If

                If _cmbTahun.Text = "" Then
                    _cmbTahun.Focus()
                    Throw New Exception("Pilih Tahun !")
                End If
                If _cmbBulan.Text = "" Then
                    _cmbBulan.Focus()
                    Throw New Exception("Pilih Bulan !")
                End If
                If _txtExcel.Text = "" Then
                    _txtExcel.Focus()
                    Throw New Exception("Pilih Excel yang  akan di upload !")
                End If
                Dim connString As String = String.Empty
                Dim extension As String = System.IO.Path.GetExtension(path)
                Select Case extension
                    Case ".xls"
                        'Excel 97-03

                        connString = ConfigurationManager.ConnectionStrings("Excel03ConString").ConnectionString
                        Exit Select
                    Case ".xlsx"
                        'Excel 07 or higher
                        connString = ConfigurationManager.ConnectionStrings("Excel07+ConString").ConnectionString
                        Exit Select

                End Select
                connString = String.Format(connString, path)
                Using excel_con As New OleDbConnection(connString)
                    excel_con.Open()
                    Dim sheet1 As String = excel_con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing).Rows(0)("TABLE_NAME").ToString()
                    Using oda As New OleDbDataAdapter((Convert.ToString("SELECT * FROM [") & sheet1) + "]", excel_con)
                        oda.Fill(GridData)
                    End Using
                    excel_con.Close()
                End Using
            Else
                If lblStatus.Text <> "" Then
                    Throw New Exception("Proses masih berjalan !")
                End If

                If TxtTahun2.Text = "" Then
                    TxtTahun2.Focus()
                    Throw New Exception("Pilih Tahun !")
                End If

                If TxtFile2.Text = "" Then
                    TxtFile2.Focus()
                    Throw New Exception("Pilih Excel yang  akan di upload !")
                End If
                Dim connString As String = String.Empty
                Dim extension As String = System.IO.Path.GetExtension(path2)
                Select Case extension
                    Case ".xls"
                        'Excel 97-03

                        connString = ConfigurationManager.ConnectionStrings("Excel03ConString").ConnectionString
                        Exit Select
                    Case ".xlsx"
                        'Excel 07 or higher
                        connString = ConfigurationManager.ConnectionStrings("Excel07+ConString").ConnectionString
                        Exit Select

                End Select
                connString = String.Format(connString, path2)
                Using excel_con As New OleDbConnection(connString)
                    excel_con.Open()
                    Dim sheet1 As String = excel_con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing).Rows(0)("TABLE_NAME").ToString()
                    Using oda As New OleDbDataAdapter((Convert.ToString("SELECT * FROM [") & sheet1) + "]", excel_con)
                        oda.Fill(GridData)
                    End Using
                    excel_con.Close()
                End Using
            End If
            Me.Close()
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub

    Private Sub TxtFile2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles TxtFile2.ButtonClick
        Try
            OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
            Dim result As DialogResult = OpenFileDialog1.ShowDialog()
            ' Test result.
            If result = Windows.Forms.DialogResult.OK Then
                path2 = OpenFileDialog1.FileName
                'path = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
                'MsgBox(path)
                Dim text As String = System.IO.File.ReadAllText(path2)
                TxtFile2.Text = path2
                'Me.Text = text.Length.ToString
            End If
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub
End Class