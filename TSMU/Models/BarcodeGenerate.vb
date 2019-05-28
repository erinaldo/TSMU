﻿Imports System.Collections.ObjectModel

Public Class BarcodeGenerate

    Public Property ObjDetails() As New Collection(Of BarcodeDet)

    Public Function GetAllDataGrid() As DataTable
        Try
            Dim ls_SP As String =
            "SELECT [BarcodeID] ID
                ,[TglUpload]
                ,[KodePart]
                ,[CustomerID]
                ,[CustomerName]
                ,[InvetoryID]
                ,[SFG/FG]
                ,[PartName]
                ,[PartNo]
                ,[Colour]
                ,[JobNo]
                ,[QtyLabel]
                ,[WarnaPasscard]
                ,[LokalExport]
                ,[Site]
                ,UploadBy
            FROM [BarcodeGenerate]"
            Dim dtTable As New DataTable
            dtTable = GetDataTable(ls_SP)
            Return dtTable
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Sub InsertData()
        Try
            Using Conn1 As New SqlClient.SqlConnection(GetConnString)
                Conn1.Open()
                Using Trans1 As SqlClient.SqlTransaction = Conn1.BeginTransaction
                    gh_Trans = New InstanceVariables.TransactionHelper
                    gh_Trans.Command.Connection = Conn1
                    gh_Trans.Command.Transaction = Trans1

                    Try
                        DeleteData()
                        For i As Integer = 0 To ObjDetails.Count - 1
                            With ObjDetails(i)
                                .InsertData()
                            End With
                        Next

                        Trans1.Commit()
                    Catch ex As Exception
                        Trans1.Rollback()
                        Throw
                    Finally
                        gh_Trans = Nothing
                    End Try
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub DeleteData()
        Try
            Dim sql As String = "Delete From [BarcodeGenerate] Where Site = " & QVal(gh_Common.Site) & " AND UploadBy = " & QVal(gh_Common.Username) & ""
            ExecQuery(sql)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function PrintQRCOde(KodePart As String, Site As String, Username As String) As DataSet
        Dim ds As dsLaporan
        Try
            Dim sql As String =
            "SELECT 
                [KodePart]
                ,[InvetoryID] InvtID
                ,[SFG/FG] Status
                ,[PartName]
                ,[PartNo]
                ,[Colour] Color
                ,[JobNo]
                ,[QtyLabel] Qty
                ,0 as No
                ,WarnaPasscard Warna
                ,LokalExport as LR
            FROM [BarcodeGenerate] WHERE KodePart = " & QVal(KodePart) & " AND Site=" & QVal(Site) & " AND LOWER(UploadBy)=" & QVal(Username) & ""
            ds = New dsLaporan
            ds = GetDsReport(sql, "QRCode")
        Catch ex As Exception
            Throw ex
        End Try
        Return ds
    End Function

    Public Sub InsertLog(Bulan As String, KodePart As String, No As Integer)
        Try
            Dim Ada As Boolean = CheckLog(Bulan, KodePart)
            If Ada Then
                Dim _udpate As String = "Update BarcodePrintLog Set No =" & QVal(No) & "
                                        WHERE Bulan = " & QVal(Bulan) & " AND KodePart = " & QVal(KodePart) & " AND Site = " & QVal(gh_Common.Site) & ""
                ExecQuery(_udpate)
            Else
                Dim Query As String = String.Empty
                Query = "INSERT INTO [BarcodePrintLog]
                        ([KodePart],[Bulan],[Site],[No],[Printedby],[PrintedDate])
                        Values(" & QVal(KodePart) & "," & QVal(Bulan) & "," & QVal(gh_Common.Site) & "," & QVal(No) & "
                            ," & QVal(gh_Common.Username) & ",GETDATE())"
                ExecQuery(Query)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GetNoPrint(Bulan As String, KodePart As String) As Integer
        Dim hasil As Integer
        Try
            Dim sql As String = "SELECT No From BarcodePrintLog WHERE Bulan = " & QVal(Bulan) & " AND KodePart = " & QVal(KodePart) & " AND Site = " & QVal(gh_Common.Site) & ""
            Dim dt As DataTable
            dt = GetDataTable(sql)
            If dt.Rows.Count > 0 Then
                hasil = Convert.ToInt32(dt.Rows(0)(0))
            End If
            Return hasil
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function CheckLog(Bulan As String, KodePart As String) As Boolean
        Dim hasil As Boolean
        Try
            Dim sql As String = "SELECT * FROM BarcodePrintLog Where Bulan = " & QVal(Bulan) & " AND KodePart = " & QVal(KodePart) & " AND Site = " & QVal(gh_Common.Site) & ""
            Dim dt As New DataTable
            dt = GetDataTable(sql)
            If dt.Rows.Count > 0 Then
                hasil = True
            End If
            Return hasil
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CheckLastNo(Bulan As String, KodePart As String, No As Integer) As Boolean
        Dim hasil As Boolean
        Try
            Dim sql As String = "SELECT * FROM BarcodePrintLog Where Bulan = " & QVal(Bulan) & " AND KodePart = " & QVal(KodePart) & " AND Site = " & QVal(gh_Common.Site) & " AND No Between 1 AND " & QVal(No) & ""
            Dim dt As New DataTable
            dt = GetDataTable(sql)
            If dt.Rows.Count > 0 Then
                hasil = True
            End If
            Return hasil
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function PrintQRCOdeCkr(KodePart As String, Site As String) As DataSet
        Dim ds As dsLaporan
        Try
            Dim sql As String =
            "SELECT 
                [KodePart]
                ,[InvetoryID] InvtID
                ,[SFG/FG] Status
                ,[PartName]
                ,[PartNo]
                ,[Colour] Color
                ,[JobNo]
                ,[QtyLabel] Qty
                ,0 as No
                ,WarnaPasscard Warna
                ,LokalExport as LR
            FROM [BarcodeGenerate] WHERE KodePart = " & QVal(KodePart) & " AND Site=" & QVal(Site) & ""
            ds = New dsLaporan
            ds = GetDsReport(sql, "QRCode")
        Catch ex As Exception
            Throw ex
        End Try
        Return ds
    End Function
End Class

Public Class BarcodeDet
    Public Property Colour As String
    Public Property CustomerID As String
    Public Property CustomerName As String
    Public Property InventoryID As String
    Public Property JobNo As String
    Public Property KodePart As String
    Public Property LokalExport As String
    Public Property PartCode As String
    Public Property PartName As String
    Public Property PartNo As String
    Public Property QtyLabel As Integer
    Public Property SFGFG As String
    Public Property Target As String
    Public Property TglUpload As DateTime
    Public Property UploadBy As String
    Public Property WarnaPasscard As String
    Public Property Site As String
    Public Sub InsertData()
        Try
            Dim Query As String = String.Empty
            Query = "INSERT INTO [BarcodeGenerate]
            ([TglUpload],[KodePart],[CustomerID],[CustomerName],[InvetoryID]
                ,[SFG/FG],[PartName],[PartNo],[Colour]
                ,[JobNo],[QtyLabel],[WarnaPasscard]
                ,LokalExport,[Site],[UploadBy])
            Values(GETDATE()," & QVal(KodePart) & "," & QVal(CustomerID) & "," & QVal(CustomerName) & "," & QVal(InventoryID) & "
                ," & QVal(SFGFG) & "," & QVal(PartName) & "," & QVal(PartNo) & "," & QVal(Colour) & "
                ," & QVal(JobNo) & "," & QVal(QtyLabel) & "," & QVal(WarnaPasscard) & "
                ," & QVal(LokalExport) & "," & QVal(Site) & "," & QVal(UploadBy) & ")"
            ExecQuery(Query)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
