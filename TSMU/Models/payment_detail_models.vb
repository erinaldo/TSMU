﻿Public Class payment_detail_models
    Public Property cek1 As Boolean
    Public Property cek2 As Boolean
    Public Property cek3 As Boolean
    Public Property cek4 As Boolean
    Public Property cmdm As Double
    Public Property CuryID As String
    Public Property Dpp As Double
    Public Property id As Integer
    Public Property Jml_Invoice As Double
    Public Property ket As String
    Public Property No_Faktur As String
    Public Property No_Invoice As String
    Public Property Pph As Double
    Public Property Ppn As Double
    Public Property releaser As String
    Public Property tax As String
    Public Property Tgl_Invoice As DateTime
    Public Property vrno As String

    Public Function GetPaymentByVoucherNo() As DataTable
        Try
            Dim sql As String = "SELECT RTRIM([No_Invoice]) InvcNbr
                      ,[Tgl_Invoice] InvcDate
                      ,RTRIM([No_Faktur]) fp
                      ,[CuryID] CuryId
                      ,[Jml_Invoice] Amount
                      ,[Dpp] DPP
                      ,[Ppn]
                      ,[Pph] PPH
                      ,[cek1] [Check]
                      ,[cek4]
                  FROM [Payment_Detail1] where RTRIM(vrno)=" & QVal(vrno.TrimEnd) & ""
            Dim dt As New DataTable
            dt = MainModul.GetDataTable_Solomon(sql)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetVendor() As DataTable
        Try
            Dim sql As String = "SELECT 
 	                                RTRIM(VendID) [Vendor ID],
	                                RTRIM(namedetail) Name,
	                                RTRIM(bank) Bank,
	                                RTRIM(norek) [No Rek.],
                                    RTRIM(name1) [Penerima],
	                                curyid [Currency]
                                FROM dbo.payment_norek1"
            Dim dt As New DataTable
            dt = MainModul.GetDataTable_Solomon(sql)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetBank() As DataTable
        Try
            Dim sql As String = "SELECT 
 	                                RTRIM(BankAcct) [Bank ID],
	                                RTRIM(CashAcctName) Name
                                FROM dbo.cashacct"
            Dim dt As New DataTable
            dt = MainModul.GetDataTable_Solomon(sql)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetDataGridCM_New(VendorID As String) As DataTable
        Try
            Dim sql As String = "SELECT Ardoc.docdate as tgl
                                    ,Ardoc.CuryId
                                    ,Ardoc.batnbr as Bacth
                                    ,Ardoc.refnbr as no_invoice
                                    ,Batch.CuryCrTot as TotalCMDM 
                                    , convert(bit,0) as [Check]
                                FROM Ardoc inner join 
                                    CashAcct  on Ardoc.BankAcct=CashAcct.BankAcct  inner join 
                                    Batch on Ardoc.BatNbr=Batch.BatNbr  inner join 
                                    customer  on Ardoc.custid=customer.custid inner join 
                                    vendor on customer.user5=vendor.vendid 
                                where Batch.user1='' 
                                    AND RTRIM(vendor.VendId)=" & QVal(VendorID.TrimEnd) & ""
            Dim dt As New DataTable
            dt = MainModul.GetDataTable_Solomon(sql)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetDataGridCM_Edit(VendorID As String) As DataTable
        Try
            Dim sql As String = "SELECT Ardoc.docdate as tgl
                                    ,Ardoc.CuryId
                                    ,Ardoc.batnbr as Bacth
                                    ,Ardoc.refnbr as no_invoice
                                    ,Batch.CuryCrTot as total_cmdm 
                                FROM Ardoc inner join 
                                    CashAcct  on Ardoc.BankAcct=CashAcct.BankAcct  inner join 
                                    Batch on Ardoc.BatNbr=Batch.BatNbr  inner join 
                                    customer  on Ardoc.custid=customer.custid inner join 
                                    vendor on customer.user5=vendor.vendid 
                                where Batch.user1='' 
                                    AND vendor.name=" & QVal(VendorID) & ""
            Dim dt As New DataTable
            dt = MainModul.GetDataTable_Solomon(sql)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetGridDetailPaymentByVendorID(VendorId) As DataTable
        Try
            Dim dt As New DataTable
            Dim sql As String =
                "PROSES_VOUCHER_APNOTPAYYMENT1_New"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            pParam(0) = New SqlClient.SqlParameter("@vendorID", SqlDbType.VarChar)
            pParam(0).Value = VendorId
            dt = MainModul.GetDataTableByCommand_SP_Solomon(sql, pParam)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Sub InsertDetails()
        Try

            Dim ls_SP As String = " " & vbCrLf &
                                    "INSERT INTO Payment_Detail1 (vrno,No_Invoice,Tgl_Invoice,Jml_Invoice,CuryID,Ppn,Dpp,Pph,No_Faktur,cek1) " & vbCrLf &
                                    "Values(" & QVal(Me.vrno) & ", " & vbCrLf &
                                    "       " & QVal(Me.No_Invoice) & ", " & vbCrLf &
                                    "       " & QVal(Me.Tgl_Invoice) & ", " & vbCrLf &
                                    "       " & QVal(Me.Jml_Invoice) & ", " & vbCrLf &
                                    "       " & QVal(Me.CuryID) & ", " & vbCrLf &
                                    "       " & QVal(Me.Ppn) & ", " & vbCrLf &
                                    "       " & QVal(Me.Dpp) & ", " & vbCrLf &
                                    "       " & QVal(Me.Pph) & ", " & vbCrLf &
                                    "       " & QVal(Me.No_Faktur) & ", " & vbCrLf &
                                    "       " & QVal(Me.cek1) & ")"
            MainModul.ExecQuery_Solomon(ls_SP)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub UpdateApDocUser4()
        Try

            Dim ls_SP As String = "UPDATE apdoc SET user4=1 WHERE InvcNbr = " & QVal(No_Invoice) & ""
            MainModul.ExecQuery_Solomon(ls_SP)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub DeleteDetail(ByVal _vrno As String)
        Try
            Dim ls_SP As String = "DELETE FROM Payment_Detail1 WHERE rtrim(vrno)=" & QVal(_vrno.TrimEnd) & ""
            MainModul.ExecQuery_Solomon(ls_SP)
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Public Sub UpdateCheckDetailByVrnoInvcId()
        Try

            Dim ls_SP As String = "UPDATE Payment_Detail1 SET Cek1=0 WHERE vrno= " & QVal(vrno) & " AND No_Invoice = " & QVal(No_Invoice) & ""
            MainModul.ExecQuery_Solomon(ls_SP)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
