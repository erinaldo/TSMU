﻿Imports System.Collections.ObjectModel
Public Class clsSales_Budget
    Dim _Query As String

    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property


    Private _tahun As String
    Public Property Tahun() As String
        Get
            Return _tahun
        End Get
        Set(ByVal value As String)
            _tahun = value
        End Set
    End Property

    Private _custid As String
    Public Property CustomerId() As String
        Get
            Return _custid
        End Get
        Set(ByVal value As String)
            _custid = value
        End Set
    End Property

    Private _customer As String
    Public Property Customer() As String
        Get
            Return _customer
        End Get
        Set(ByVal value As String)
            _customer = value
        End Set
    End Property
    Private _invtid As String
    Public Property InvtId() As String
        Get
            Return _invtid
        End Get
        Set(ByVal value As String)
            _invtid = value
        End Set
    End Property
    Private _descr As String
    Public Property Descr() As String
        Get
            Return _descr
        End Get
        Set(ByVal value As String)
            _descr = value
        End Set
    End Property
    Private _partno As String
    Public Property PartNo() As String
        Get
            Return _partno
        End Get
        Set(ByVal value As String)
            _partno = value
        End Set
    End Property

    'Private _partname As String
    'Public Property PartNo() As String
    '    Get
    '        Return _partno
    '    End Get
    '    Set(ByVal value As String)
    '        _partno = value
    '    End Set
    'End Property

    Private _model As String
    Public Property Model() As String
        Get
            Return _model
        End Get
        Set(ByVal value As String)
            _model = value
        End Set
    End Property

    Private _oe_re As String
    Public Property Oe_Re() As String
        Get
            Return _oe_re
        End Get
        Set(ByVal value As String)
            _oe_re = value
        End Set
    End Property
    Private _in_sub As String
    Public Property In_Sub() As String
        Get
            Return _in_sub
        End Get
        Set(ByVal value As String)
            _in_sub = value
        End Set
    End Property

    Private _site As String
    Public Property Site() As String
        Get
            Return _site
        End Get
        Set(ByVal value As String)
            _site = value
        End Set
    End Property

    Private _jan_qty As Single
    Public Property Jan_Qty() As Single
        Get
            Return _jan_qty
        End Get
        Set(ByVal value As Single)
            _jan_qty = value
        End Set
    End Property
    Private _feb_qty As Single
    Public Property Feb_Qty() As Single
        Get
            Return _feb_qty
        End Get
        Set(ByVal value As Single)
            _feb_qty = value
        End Set
    End Property

    Private _mar_qty As Single
    Public Property Mar_Qty() As Single
        Get
            Return _mar_qty
        End Get
        Set(ByVal value As Single)
            _mar_qty = value
        End Set
    End Property

    Private _april_qty As Single
    Public Property April_Qty() As Single
        Get
            Return _april_qty
        End Get
        Set(ByVal value As Single)
            _april_qty = value
        End Set
    End Property

    Private _mei_qty As Single
    Public Property Mei_Qty() As Single
        Get
            Return _mei_qty
        End Get
        Set(ByVal value As Single)
            _mei_qty = value
        End Set
    End Property

    Private _jun_qty As Single
    Public Property Jun_Qty() As Single
        Get
            Return _jun_qty
        End Get
        Set(ByVal value As Single)
            _jun_qty = value
        End Set
    End Property

    Private _jul_qty As Single
    Public Property Jul_Qty() As Single
        Get
            Return _jul_qty
        End Get
        Set(ByVal value As Single)
            _jul_qty = value
        End Set
    End Property

    Private _agt_qty As Single
    Public Property Agt_Qty() As Single
        Get
            Return _agt_qty
        End Get
        Set(ByVal value As Single)
            _agt_qty = value
        End Set
    End Property

    Private _sep_qty As Single
    Public Property Sep_Qty() As Single
        Get
            Return _sep_qty
        End Get
        Set(ByVal value As Single)
            _sep_qty = value
        End Set
    End Property

    Private _okt_qty As Single
    Public Property Okt_Qty() As Single
        Get
            Return _okt_qty
        End Get
        Set(ByVal value As Single)
            _okt_qty = value
        End Set
    End Property

    Private _nov_qty As Single
    Public Property Nov_Qty() As Single
        Get
            Return _nov_qty
        End Get
        Set(ByVal value As Single)
            _nov_qty = value
        End Set
    End Property

    Private _des_qty As Single
    Public Property Des_Qty() As Single
        Get
            Return _des_qty
        End Get
        Set(ByVal value As Single)
            _des_qty = value
        End Set
    End Property
    Private _jan_harga As Single
    Public Property Jan_Harga() As Single
        Get
            Return _jan_harga
        End Get
        Set(ByVal value As Single)
            _jan_harga = value
        End Set
    End Property

    Private _feb_harga As Single
    Public Property Feb_Harga() As Single
        Get
            Return _feb_harga
        End Get
        Set(ByVal value As Single)
            _feb_harga = value
        End Set
    End Property

    Private _mar_harga As Single
    Public Property Mar_Harga() As Single
        Get
            Return _mar_harga
        End Get
        Set(ByVal value As Single)
            _mar_harga = value
        End Set
    End Property

    Private _apr_harga As Single
    Public Property Apr_Harga() As Single
        Get
            Return _apr_harga
        End Get
        Set(ByVal value As Single)
            _apr_harga = value
        End Set
    End Property

    Private _mei_harga As Single
    Public Property Mei_Harga() As Single
        Get
            Return _mei_harga
        End Get
        Set(ByVal value As Single)
            _mei_harga = value
        End Set
    End Property

    Private _jun_harga As Single
    Public Property Jun_Harga() As Single
        Get
            Return _jun_harga
        End Get
        Set(ByVal value As Single)
            _jun_harga = value
        End Set
    End Property

    Private _jul_harga As Single
    Public Property Jul_Harga() As Single
        Get
            Return _jul_harga
        End Get
        Set(ByVal value As Single)
            _jul_harga = value
        End Set
    End Property

    Private _agt_harga As Single
    Public Property Agt_Harga() As Single
        Get
            Return _agt_harga
        End Get
        Set(ByVal value As Single)
            _agt_harga = value
        End Set
    End Property

    Private _sep_harga As Single
    Public Property Sep_Harga() As Single
        Get
            Return _sep_harga
        End Get
        Set(ByVal value As Single)
            _sep_harga = value
        End Set
    End Property

    Private _okt_harga As Single
    Public Property Okt_Harga() As Single
        Get
            Return _okt_harga
        End Get
        Set(ByVal value As Single)
            _okt_harga = value
        End Set
    End Property

    Private _nov_harga As Single
    Public Property Nov_Harga() As Single
        Get
            Return _nov_harga
        End Get
        Set(ByVal value As Single)
            _nov_harga = value
        End Set
    End Property

    Private _des_harga As Single
    Public Property Des_Harga() As Single
        Get
            Return _des_harga
        End Get
        Set(ByVal value As Single)
            _des_harga = value
        End Set
    End Property

    Private _revisi As Integer
    Public Property Revisi() As Integer
        Get
            Return _revisi
        End Get
        Set(ByVal value As Integer)
            _revisi = value
        End Set
    End Property


    Public Sub New()
        Me._Query = "select acctid as [Account ID], acctname [Account Name], tipe [Type] from tipeacct order by AcctID"
    End Sub
    Public Function GetAllDataGrid(ByVal ls_Filter As String) As DataTable
        Try
            Dim ls_SP As String = "sp_sales_budget_GetDataGrid"
            Dim dtTable As New DataTable
            dtTable = GetDataTableByCommand_SP(ls_SP)
            'If dtTable IsNot Nothing AndAlso dtTable.Rows.Count > 0 Then
            '    With dtTable.Rows(0)
            '        Me._id = Trim(.Item("ID") & "")
            '    End With
            'End If
            Return dtTable
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function getCusst_Solomon() As DataTable
        Try
            Dim query As String = "select CustId [Customer ID], [Name] from Customer order by [Name]"
            Dim dtTable As New DataTable
            dtTable = GetDataTable_Solomon(query)
            Return dtTable
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function getCusstID_Solomon() As DataTable
        Try
            Dim query As String = "select distinct CustId from Customer where left(custid,1) <> '0'"
            Dim dtTable As New DataTable
            dtTable = GetDataTable_Solomon(query)
            Return dtTable
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function getPartNo_Solomon(ByVal cust As String) As DataTable
        Try
            Dim query As String = "select AlternateID,InvtID,Descr from itemxref where altIDType='C' and EntityID= " & QVal(cust) & " order by EntityID,AlternateID"
            Dim dtTable As New DataTable
            dtTable = GetDataTable_Solomon(query)
            Return dtTable
        Catch ex As Exception
            Throw
        End Try
    End Function

    'Public Function GetAllData() As DataTable
    '    Try
    '        Dim ls_SP As String = "select bomid as [BoM ID],invtid as [Inventory ID], descr as Description, siteid as Site " & _
    '            "from bomh order by bomid"
    '        Dim dtTable As New DataTable
    '        dtTable = GetDataTableByCommand(ls_SP)

    '        Return dtTable
    '    Catch ex As Exception
    '        Throw
    '    End Try
    'End Function
    Public Sub getDataByID(ByVal ID As String)
        Try
            Dim query As String = "sp_sales_budget_getDatabyID"

            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}

            pParam(0) = New SqlClient.SqlParameter("@id", SqlDbType.Int)
            pParam(0).Value = ID

            Dim dtTable As New DataTable
            dtTable = GetDataTableByCommand_SP(query, pParam)
            If dtTable IsNot Nothing AndAlso dtTable.Rows.Count > 0 Then
                With dtTable.Rows(0)
                    Me._id = Trim(.Item("ID") & "")
                    Me._tahun = Trim(.Item("tahun") & "")
                    Me._custid = Trim(.Item("custid") & "")
                    Me._customer = Trim(.Item("customer") & "")
                    Me._invtid = Trim(.Item("invtid") & "")
                    Me._descr = Trim(.Item("descr") & "")
                    Me._partno = Trim(.Item("partno") & "")
                    Me._model = Trim(.Item("model") & "")
                    Me._oe_re = Trim(.Item("oe_re") & "")
                    Me._in_sub = Trim(.Item("in_sub") & "")
                    Me._site = Trim(.Item("site") & "")
                    Me._jan_qty = Trim(.Item("jan_qty") & "")
                    Me._feb_qty = Trim(.Item("feb_qty") & "")
                    Me._mar_qty = Trim(.Item("mar_qty") & "")
                    Me._april_qty = Trim(.Item("apr_qty") & "")
                    Me._mei_qty = Trim(.Item("mei_qty") & "")
                    Me._jun_qty = Trim(.Item("jun_qty") & "")
                    Me._jul_qty = Trim(.Item("jul_qty") & "")
                    Me._agt_qty = Trim(.Item("agt_qty") & "")
                    Me._sep_qty = Trim(.Item("sep_qty") & "")
                    Me._okt_qty = Trim(.Item("okt_qty") & "")
                    Me._nov_qty = Trim(.Item("nov_qty") & "")
                    Me._des_qty = Trim(.Item("des_qty") & "")
                    Me._jan_harga = Trim(.Item("jan_harga") & "")
                    Me._feb_harga = Trim(.Item("feb_harga") & "")
                    Me._mar_harga = Trim(.Item("mar_harga") & "")
                    Me._apr_harga = Trim(.Item("apr_harga") & "")
                    Me._mei_harga = Trim(.Item("mei_harga") & "")
                    Me._jun_harga = Trim(.Item("jun_harga") & "")
                    Me._jul_harga = Trim(.Item("jul_harga") & "")
                    Me._agt_harga = Trim(.Item("agt_harga") & "")
                    Me._sep_harga = Trim(.Item("sep_harga") & "")
                    Me._okt_harga = Trim(.Item("okt_harga") & "")
                    Me._nov_harga = Trim(.Item("nov_harga") & "")
                    Me._des_harga = Trim(.Item("des_harga") & "")
                End With
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub getDataByInvt(ByVal ID As String)
        Try
            Dim query As String = "select * from tipeacct where AcctID = " & QVal(ID) & " order by AcctID"
            Dim dtTable As New DataTable
            dtTable = MainModul.GetDataTableByCommand(query)
            If dtTable IsNot Nothing AndAlso dtTable.Rows.Count > 0 Then
                With dtTable.Rows(0)
                    Me._tahun = Trim(.Item("acctid") & "")
                    Me._custid = Trim(.Item("acctname") & "")
                    Me._customer = Trim(.Item("tie") & "")
                End With
            Else
                _tahun = ""
                _custid = ""
                _customer = ""
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub ValidateInsert()
        If Me._partno = "" OrElse Me._tahun = "" OrElse Me._invtid = "" Then
            Err.Raise(ErrNumber, , GetMessage(MessageEnum.PropertyKosong))
        End If
        Try
            Dim ls_SP As String = "Select top 1 tahun,partno,invtid from Budget where tahun = " & QVal(Me._tahun) & " and invtid= " & QVal(Me._invtid) & " and partno = " & QVal(Me._partno) & ""
            Dim dtTable As New DataTable
            dtTable = MainModul.GetDataTableByCommand(ls_SP)
            If dtTable IsNot Nothing AndAlso dtTable.Rows.Count > 0 Then
                Err.Raise(ErrNumber, , GetMessage(MessageEnum.InsertGagal) & _
                "[" & Me._partno & "]")
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub
#Region "CRUD"
    Public Sub Insert()
        
        Try
            Dim query As String = "INSERT INTO Budget " & vbCrLf & _
            "   ( " & vbCrLf & _
            "       [tahun],[custid],[customer],[invtid],[descr],[partno],[model],[oe_re],[in_sub],[site] " & vbCrLf & _
            "       , [jan_qty],[feb_qty],[mar_qty],[apr_qty],[mei_qty],[jun_qty],[jul_qty],[agt_qty] " & vbCrLf & _
            "       , [sep_qty],[okt_qty],[nov_qty] ,[des_qty],[jan_harga],[feb_harga],[mar_harga] " & vbCrLf & _
            "       , [apr_harga],[mei_harga],[jun_harga],[jul_harga],[agt_harga],[sep_harga],[okt_harga] " & vbCrLf & _
            "       , [nov_harga],[des_harga],[revisi], created_date, created_by " & vbCrLf & _
            "   ) " & vbCrLf & _
            "OUTPUT INSERTED.ID " & vbCrLf & _
            "VALUES " & vbCrLf & _
            "   ( " & vbCrLf & _
            "       " & QVal(Me._tahun) & " " & vbCrLf & _
            "       , " & QVal(Me._custid) & " " & vbCrLf & _
            "       , " & QVal(Me._customer) & " " & vbCrLf & _
            "       , " & QVal(Me._invtid) & " " & vbCrLf & _
            "       , " & QVal(Me._descr) & " " & vbCrLf & _
            "       , " & QVal(Me._partno) & " " & vbCrLf & _
            "       , " & QVal(Me._model) & " " & vbCrLf & _
            "       , " & QVal(Me._oe_re) & " " & vbCrLf & _
            "       , " & QVal(Me._in_sub) & " " & vbCrLf & _
            "       , " & QVal(Me._site) & " " & vbCrLf & _
            "       , " & QVal(Me._jan_qty) & " " & vbCrLf & _
            "       , " & QVal(Me._feb_qty) & " " & vbCrLf & _
            "       , " & QVal(Me._mar_qty) & " " & vbCrLf & _
            "       , " & QVal(Me._april_qty) & " " & vbCrLf & _
            "       , " & QVal(Me._mei_qty) & " " & vbCrLf & _
            "       , " & QVal(Me._jun_qty) & " " & vbCrLf & _
            "       , " & QVal(Me._jul_qty) & " " & vbCrLf & _
            "       , " & QVal(Me._agt_qty) & " " & vbCrLf & _
            "       , " & QVal(Me._sep_qty) & " " & vbCrLf & _
            "       , " & QVal(Me._okt_qty) & " " & vbCrLf & _
            "       , " & QVal(Me._nov_qty) & " " & vbCrLf & _
            "       , " & QVal(Me._des_qty) & " " & vbCrLf & _
            "       , " & QVal(Me._jan_harga) & " " & vbCrLf & _
            "       , " & QVal(Me._feb_harga) & " " & vbCrLf & _
            "       , " & QVal(Me._mar_harga) & " " & vbCrLf & _
            "       , " & QVal(Me._apr_harga) & " " & vbCrLf & _
            "       , " & QVal(Me._mei_harga) & " " & vbCrLf & _
            "       , " & QVal(Me._jun_harga) & " " & vbCrLf & _
            "       , " & QVal(Me._jul_harga) & " " & vbCrLf & _
            "       , " & QVal(Me._agt_harga) & " " & vbCrLf & _
            "       , " & QVal(Me._sep_harga) & " " & vbCrLf & _
            "       , " & QVal(Me._okt_harga) & " " & vbCrLf & _
            "       , " & QVal(Me._nov_harga) & " " & vbCrLf & _
            "       , " & QVal(Me._des_harga) & " " & vbCrLf & _
            "       , 0 " & vbCrLf & _
            "       , GETDATE() " & vbCrLf & _
            "       , " & QVal(gh_Common.Username) & " " & vbCrLf & _
            "   )"
            'Dim li_Row = GetDataTableByCommand(query)
            Dim dtTable As New DataTable
            dtTable = MainModul.GetDataTableByCommand(query)
            If dtTable IsNot Nothing AndAlso dtTable.Rows.Count > 0 Then
                With dtTable.Rows(0)
                    Me._id = Trim(.Item("ID") & "")
                End With
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Public Sub Update()
        Try
            Dim revisi As Integer
            If Me._revisi = 0 Then
                revisi = 1
            ElseIf Me._revisi = 1 Then
                revisi = 2
            Else
                revisi = 2
            End If


            Dim query As String = "UPDATE Budget " & vbCrLf & _
            "   SET [tahun] = " & QVal(Me._tahun) & " " & vbCrLf & _
            "      ,[custid] = " & QVal(Me._custid) & " " & vbCrLf & _
            "      ,[customer] = " & QVal(Me._customer) & " " & vbCrLf & _
            "      ,[invtid] = " & QVal(Me._invtid) & " " & vbCrLf & _
            "      ,[descr] = " & QVal(Me._descr) & " " & vbCrLf & _
            "      ,[partno] = " & QVal(Me._partno) & " " & vbCrLf & _
            "      ,[model] = " & QVal(Me._model) & " " & vbCrLf & _
            "      ,[oe_re] = " & QVal(_oe_re) & " " & vbCrLf & _
            "      ,[in_sub] = " & QVal(Me._in_sub) & " " & vbCrLf & _
            "      ,[site] = " & QVal(Me._site) & " " & vbCrLf & _
            "      ,[jan_qty] = " & QVal(Me._jan_qty) & " " & vbCrLf & _
            "      ,[feb_qty] = " & QVal(Me._feb_qty) & " " & vbCrLf & _
            "      ,[mar_qty] = " & QVal(Me._mar_qty) & " " & vbCrLf & _
            "      ,[apr_qty] = " & QVal(Me._april_qty) & " " & vbCrLf & _
            "      ,[mei_qty] = " & QVal(Me._mei_qty) & " " & vbCrLf & _
            "      ,[jun_qty] = " & QVal(Me._jun_qty) & " " & vbCrLf & _
            "      ,[jul_qty] = " & QVal(Me._jul_qty) & " " & vbCrLf & _
            "      ,[agt_qty] = " & QVal(Me._agt_qty) & " " & vbCrLf & _
            "      ,[sep_qty] = " & QVal(Me._sep_qty) & " " & vbCrLf & _
            "      ,[okt_qty] = " & QVal(Me._okt_qty) & " " & vbCrLf & _
            "      ,[nov_qty] = " & QVal(Me._nov_qty) & " " & vbCrLf & _
            "      ,[des_qty] = " & QVal(Me._des_qty) & " " & vbCrLf & _
            "      ,[jan_harga] = " & QVal(Me._jan_harga) & " " & vbCrLf & _
            "      ,[feb_harga] = " & QVal(Me._feb_harga) & " " & vbCrLf & _
            "      ,[mar_harga] = " & QVal(Me._mar_harga) & " " & vbCrLf & _
            "      ,[apr_harga] = " & QVal(Me._apr_harga) & " " & vbCrLf & _
            "      ,[mei_harga] = " & QVal(Me._mei_harga) & " " & vbCrLf & _
            "      ,[jun_harga] = " & QVal(Me._jun_harga) & " " & vbCrLf & _
            "      ,[jul_harga] = " & QVal(Me._jul_harga) & " " & vbCrLf & _
            "      ,[agt_harga] = " & QVal(Me._agt_harga) & " " & vbCrLf & _
            "      ,[sep_harga] = " & QVal(Me._sep_harga) & " " & vbCrLf & _
            "      ,[okt_harga] = " & QVal(Me._okt_harga) & " " & vbCrLf & _
            "      ,[nov_harga] = " & QVal(Me._nov_harga) & " " & vbCrLf & _
            "      ,[des_harga] = " & QVal(Me._des_harga) & " " & vbCrLf & _
            "      ,[revisi] = " & QVal(revisi) & " " & vbCrLf & _
            "      ,[update_date] = GETDATE() " & vbCrLf & _
            "      ,[updated_by] = " & QVal(gh_Common.Username) & " " & vbCrLf & _
            "   OUTPUT INSERTED.ID " & vbCrLf & _
            "   WHERE [id] = " & QVal(Me._id) & " "
            'Dim li_Row = ExecQuery(query)
            Dim dtTable As New DataTable
            dtTable = MainModul.GetDataTableByCommand(query)
            If dtTable IsNot Nothing AndAlso dtTable.Rows.Count > 0 Then
                With dtTable.Rows(0)
                    Me._id = Trim(.Item("ID") & "")
                End With
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Public Sub Delete()
        Try
            Dim query As String = "DELETE FROM Budget " & vbCrLf & _
            "WHERE id = " & QVal(Me._id) & " "
            Dim li_Row = MainModul.ExecQuery(query)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub Delete_byTahun()
        Try
            Dim query As String = "DELETE FROM Budget " & vbCrLf &
            "WHERE tahun = " & QVal(Me._tahun) & " AND partno= " & QVal(Me._partno) & " AND invtid = " & QVal(Me._invtid) & " AND custid = " & QVal(Me._custid) & ""
            Dim li_Row = MainModul.ExecQuery(query)
        Catch ex As Exception
            Throw
        End Try
    End Sub
#End Region
End Class

