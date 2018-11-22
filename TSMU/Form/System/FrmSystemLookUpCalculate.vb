﻿Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Public Class FrmSystemLookUpCalculate
    Dim fc_class As New clsSales_Budget
    Dim GridData As DataTable = Nothing
    Dim Gridfilter As DataTable = Nothing
    Dim a As Integer = 0
    Dim b As Integer = 0
    Dim _class As New clsCalcultateBoM
    Dim _classdetail As New clsCalculateBoMdetail
    Dim _clsTrans As New clsCalculateBoMTrans
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal dt As DataTable)
        ' This call is required by the Windows Form Designer.
        Me.New()
        ' Add any initialization after the InitializeComponent() call.
        GridData = dt
    End Sub
    ReadOnly Property Tahun As String
        Get
            Return _cmbTahun.Text.Trim
        End Get
    End Property
    ReadOnly Property Customer As String
        Get
            Return _cmbSemester.Text.Trim
        End Get
    End Property
    Private Sub FrmSystemLookUpCalculate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillComboTahun()
        TabControl1.TabPages(0).BackColor = tabcolour
        ProgressBar1.Visible = False
    End Sub
    Private Sub FillComboTahun()
        Dim tahun() As String = {"", DateTime.Today.Year.ToString, (DateTime.Today.Year - 1).ToString, (DateTime.Today.Year - 2).ToString}
        _cmbTahun.Items.Clear()
        For Each var As String In tahun
            _cmbTahun.Items.Add(var)
        Next
    End Sub
    Dim jan As Single
    Dim feb As Single
    Dim mar As Single
    Dim apr As Single
    Dim mei As Single
    Dim jun As Single
    Dim jul As Single
    Dim agust As Single
    Dim sep As Single
    Dim okt As Single
    Dim nov As Single
    Dim des As Single
    Dim bomidH1 As String
    Dim inv As String
    Private Async Sub _btnExport_Click(sender As Object, e As EventArgs) Handles _btnExport.Click
        Try
            If ProgressBar1.Visible = True Then
                Throw New Exception("Process already running, Please wait !")
            End If
            'Cursor = Cursors.WaitCursor
            ProgressBar1.Visible = True
            ProgressBar1.Style = ProgressBarStyle.Marquee
            Await Task.Run(Sub() CalculatedBoM())
            MsgBox("Process Done !")

        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub
    Dim strSemester As Integer
    Dim strTahun As String
    Private Sub CalculatedBoM()
        Try

            Invoke(Sub()
                       strSemester = _cmbSemester.SelectedIndex
                       strTahun = _cmbTahun.Text
                   End Sub)
            If strTahun = "" Then
                Throw New Exception("Silahkan pilih tahun !")
            End If
            If strSemester = 1 Then
                Dim IsBudgetAlreadyCalculated As Boolean
                IsBudgetAlreadyCalculated = _class.IsBudgetSemester1Exist(strTahun, strSemester)
                If IsBudgetAlreadyCalculated Then
                    If MsgBox("Budget untuk tahun " & strTahun & " semester " & strSemester & " sudah di hitung, Calculate ulang ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                        _class.DeleteBugetByYearAndSemester(strTahun, strSemester)
                        proses_semester1()
                    Else
                        ProgressBar1.Invoke(Sub() ProgressBar1.Visible = False)
                        Exit Sub
                    End If
                Else
                    proses_semester1()
                End If

            ElseIf strSemester = 2 Then
                Dim IsBudgetAlreadyCalculated As Boolean
                IsBudgetAlreadyCalculated = _class.IsBudgetSemester1Exist(strTahun, strSemester)
                If IsBudgetAlreadyCalculated Then
                    If MsgBox("Budget untuk tahun " & strTahun & " semester " & strSemester & " sudah di hitung, Calculate ulang ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                        _class.DeleteBugetByYearAndSemester(strTahun, strSemester)
                        proses_semester2()
                    Else
                        ProgressBar1.Invoke(Sub() ProgressBar1.Visible = False)
                        Exit Sub
                    End If
                Else
                    proses_semester2()
                End If
            Else
                If strPesan1 = "" AndAlso strPesan2 = "" Then
                    proses_semester1()
                    proses_semester2()
                Else
                    Throw New Exception(IIf(strPesan1 = "", strPesan2, strPesan1))
                End If
            End If
            ProgressBar1.Invoke(Sub() ProgressBar1.Visible = False)
            'Cursor = Cursors.Default

        Catch ex As Exception
            ProgressBar1.Invoke(Sub() ProgressBar1.Visible = False)
            'Cursor = Cursors.Default
            Throw ex
        End Try
    End Sub
    Dim strPesan1 As String
    Dim strPesan2 As String
    Private Sub proses_semester2()
        Dim dt2 As New DataTable
        dt2 = _class.GetBudgetSemester2(strTahun)
        If dt2.Rows.Count = 0 Then
            strPesan1 = "Data to calculate is empty !"
            Exit Sub
        End If
        For i As Integer = 0 To GridData.Rows.Count - 1
            Dim bomidH As String = ""
            Dim invtid As String = ""
            Dim descr As String = ""
            Dim unit As String = ""
            Dim qty As Single = 0
            Dim level0 As String = ""
            Dim level1 As String = ""
            Dim level2 As String = ""
            Dim level3 As String = ""
            Dim level4 As String = ""
            bomidH = GridData.Rows(i).Item("Bom ID").ToString
            'invtid = GridData.Rows(i).Item("Bom ID").ToString
            descr = GridData.Rows(i).Item("Description").ToString
            unit = GridData.Rows(i).Item("Unit").ToString
            qty = GridData.Rows(i).Item("Qty").ToString
            level0 = GridData.Rows(i).Item("Level 0").ToString
            level1 = GridData.Rows(i).Item("Level 1").ToString
            level2 = GridData.Rows(i).Item("Level 2").ToString
            level3 = GridData.Rows(i).Item("Level 3").ToString
            level4 = GridData.Rows(i).Item("Level 4").ToString
            'qty = GridData.Rows(i).Item("Qty")

            If level0 <> "" Then
                bomidH1 = bomidH
                inv = level0
                Dim strYear As String = ""
                Dim strCust As String = ""
                Invoke(Sub()
                           strYear = _cmbTahun.Text
                           strCust = _cmbSemester.Text
                       End Sub)
                With _class
                    .bomId = bomidH
                    .invtid = level0
                    .descr = descr
                    .Semester = "2"
                    .Tahun = strYear
                    .Total = 0
                    .InsertHeader()
                End With

            Else
                For j As Integer = 0 To dt2.Rows.Count - 1
                    Dim invtidD As String = ""
                    invtid = dt2.Rows(j).Item("invtid").ToString
                    jul = 0
                    agust = 0
                    sep = 0
                    okt = 0
                    nov = 0
                    des = 0
                    If inv = invtid Then
                        jul = dt2.Rows(j).Item("jul_qty")
                        agust = dt2.Rows(j).Item("agt_qty")
                        sep = dt2.Rows(j).Item("sep_qty")
                        okt = dt2.Rows(j).Item("okt_qty")
                        nov = dt2.Rows(j).Item("nov_qty")
                        des = dt2.Rows(j).Item("des_qty")
                        Exit For
                    End If
                Next

                With _classdetail
                    .bomId = bomidH1
                    If level0 = "" AndAlso level1 <> "" AndAlso level2 = "" AndAlso level3 = "" AndAlso level4 = "" Then
                        .invtid = level1
                        .level = "level1"
                    ElseIf level0 = "" AndAlso level1 = "" AndAlso level2 <> "" AndAlso level3 = "" AndAlso level4 = "" Then
                        .invtid = level2
                        .level = "level2"
                    ElseIf level0 = "" AndAlso level1 = "" AndAlso level2 = "" AndAlso level3 <> "" AndAlso level4 = "" Then
                        .invtid = level3
                        .level = "level3"
                    ElseIf level0 = "" AndAlso level1 = "" AndAlso level2 = "" AndAlso level3 = "" AndAlso level4 <> "" Then
                        .invtid = level4
                        .level = "level4"
                    End If
                    .descr = descr
                    .unit = unit

                    .jul_qty = qty * jul
                    .agust_qty = qty * agust
                    .sep_qty = qty * sep
                    .okt_qty = qty * okt
                    .nov_qty = qty * nov
                    .des_qty = qty * des
                    .InsertDetails()
                End With
                '_clsTrans.Fc_classdetail.Add(_classdetail)
            End If

            '_clsTrans.InsertCalculatedBoM()
        Next
    End Sub

    Private Sub proses_semester1()

        Dim dt1 As New DataTable
        dt1 = _class.GetBudgetSemester1(strTahun)
        If dt1.Rows.Count = 0 Then
            strPesan2 = "Data to calculate is empty !"
            Exit Sub
        End If
        For i As Integer = 0 To GridData.Rows.Count - 1
            Dim bomidH As String = ""
            Dim invtid As String = ""
            Dim descr As String = ""
            Dim unit As String = ""
            Dim qty As Single = 0
            Dim level0 As String = ""
            Dim level1 As String = ""
            Dim level2 As String = ""
            Dim level3 As String = ""
            Dim level4 As String = ""
            bomidH = GridData.Rows(i).Item("Bom ID").ToString
            'invtid = GridData.Rows(i).Item("Bom ID").ToString
            descr = GridData.Rows(i).Item("Description").ToString
            unit = GridData.Rows(i).Item("Unit").ToString
            qty = GridData.Rows(i).Item("Qty").ToString
            level0 = GridData.Rows(i).Item("Level 0").ToString
            level1 = GridData.Rows(i).Item("Level 1").ToString
            level2 = GridData.Rows(i).Item("Level 2").ToString
            level3 = GridData.Rows(i).Item("Level 3").ToString
            level4 = GridData.Rows(i).Item("Level 4").ToString
            'qty = GridData.Rows(i).Item("Qty")

            If level0 <> "" Then
                bomidH1 = bomidH
                inv = level0
                Dim strYear As String = ""
                Dim strCust As String = ""
                Invoke(Sub()
                           strYear = _cmbTahun.Text
                           strCust = _cmbSemester.Text
                       End Sub)
                With _class
                    .bomId = bomidH
                    .invtid = level0
                    .descr = descr
                    .Semester = "1"
                    .Tahun = strYear
                    .Total = 0
                    .InsertHeader()
                End With

            Else
                For j As Integer = 0 To dt1.Rows.Count - 1
                    Dim invtidD As String = ""
                    invtid = dt1.Rows(j).Item("invtid").ToString
                    jan = 0
                    feb = 0
                    mar = 0
                    apr = 0
                    mei = 0
                    jun = 0
                    If inv = invtid Then
                        jan = dt1.Rows(j).Item("jan_qty")
                        feb = dt1.Rows(j).Item("feb_qty")
                        apr = dt1.Rows(j).Item("mar_qty")
                        mar = dt1.Rows(j).Item("apr_qty")
                        mei = dt1.Rows(j).Item("mei_qty")
                        jun = dt1.Rows(j).Item("jun_qty")
                        Exit For
                    End If
                Next

                With _classdetail
                    .bomId = bomidH1
                    If level0 = "" AndAlso level1 <> "" AndAlso level2 = "" AndAlso level3 = "" AndAlso level4 = "" Then
                        .invtid = level1
                        .level = "level1"
                    ElseIf level0 = "" AndAlso level1 = "" AndAlso level2 <> "" AndAlso level3 = "" AndAlso level4 = "" Then
                        .invtid = level2
                        .level = "level2"
                    ElseIf level0 = "" AndAlso level1 = "" AndAlso level2 = "" AndAlso level3 <> "" AndAlso level4 = "" Then
                        .invtid = level3
                        .level = "level3"
                    ElseIf level0 = "" AndAlso level1 = "" AndAlso level2 = "" AndAlso level3 = "" AndAlso level4 <> "" Then
                        .invtid = level4
                        .level = "level4"
                    End If
                    .descr = descr
                    .unit = unit

                    .Jan_qty = qty * jan
                    .feb_qty = qty * feb
                    .mar_qty = qty * jan
                    .apr_qty = qty * apr
                    .mei_qty = qty * mei
                    .jun_qty = qty * jun
                    .InsertDetails()
                End With
                '_clsTrans.Fc_classdetail.Add(_classdetail)
            End If

            '_clsTrans.InsertCalculatedBoM()
        Next
    End Sub
End Class