﻿Public Class FrmUser_Group
    Dim ff_Detail As FrmUser_Group_detail
    Dim dtGrid As DataTable
    Dim fc_Class As New clsGroupUser

    Private Sub FrmUser_Group_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bb_SetDisplayChangeConfirmation = False
        Call LoadGrid()
        Dim dtGrid As New DataTable
        dtGrid = Grid.DataSource
        FilterData = New FrmSystem_FilterData(dtGrid)
    End Sub
    Private Sub LoadGrid()
        Try
            'Grid.ReadOnly = True
            'Grid.AllowSorting = AllowSortingEnum.SingleColumn
            dtGrid = fc_Class.GetAllDataTable(bs_Filter)
            Grid.DataSource = dtGrid
            'If Grid.Rows.Count > 0 Then
            '    Call Proc_EnableButtons(False, False, False, True, True, True, False, False)
            'Else
            '    Call Proc_EnableButtons(False, False, False, True, True, True, False, False)
            'End If
            'Grid.AutoSize = True
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub
    Public Overrides Sub Proc_InputNewData()
        CallFrm()
    End Sub
    Public Overrides Sub Proc_Refresh()
        bs_Filter = ""
        Call LoadGrid()
    End Sub
    Public Overrides Sub Proc_Filter()
        FilterData.Text = "FILTER DATA GROUP"
        FilterData.ShowDialog()
        If Not FilterData.isCancel Then
            bs_Filter = FilterData.strWhereClauseWithoutWhere
            Call FilterGrid()
        End If
        FilterData.Hide()
    End Sub

    Private Sub FilterGrid()
        Try
            'Grid.all = False
            'Grid.AllowSorting = AllowSortingEnum.SingleColumn
            Dim dv As New DataView(dtGrid)
            dv.RowFilter = bs_Filter
            dtGrid = dv.ToTable
            Grid.DataSource = dtGrid
            'If Grid.Rows.Count > 0 Then
            '    Call Proc_EnableButtons(False, False, False, True, True, True, False, False)
            'Else
            '    Call Proc_EnableButtons(False, False, False, True, True, True, False, False)
            'End If
            'Grid.AutoSize = True
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub
    Private Sub CallFrm(Optional ByVal ls_Code As String = "", Optional ByVal ls_Code2 As String = "", Optional ByVal li_Row As Integer = 0)
        If ff_Detail IsNot Nothing AndAlso ff_Detail.Visible Then
            If MsgBox(gs_ConfirmDetailOpen, MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            ff_Detail.Close()
        End If
        ff_Detail = New FrmUser_Group_detail(ls_Code, ls_Code2, Me, li_Row, Grid)
        ff_Detail.MdiParent = MenuUtamaForm
        ff_Detail.StartPosition = FormStartPosition.CenterScreen
        ff_Detail.Show()
    End Sub
    Public Overrides Sub Proc_DeleteData()
        Try
            Dim fc_Class1 As New clsGroupUser
            fc_Class1.UserGroupCode = Trim(Grid.SelectedRows(0).Cells(0).Value)
            fc_Class1.DeleteHeader()
            Call ShowMessage(GetMessage(MessageEnum.HapusBerhasil), MessageTypeEnum.NormalMessage)
            tsBtn_refresh.PerformClick()
            'Grid.RemoveItem(Grid.Row)
            'If Grid.Rows.Count > Grid.Rows.Fixed Then
            '    Call Proc_EnableButtons(True, False, True, True, True, True, False, False)
            'Else
            '    Call Proc_EnableButtons(True, False, False, True, True, True, False, False)
            'End If
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub Grid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellDoubleClick
        Try
            Dim objGrid As DataGridView = sender
            If objGrid.Rows.Count > 0 Then
                Call CallFrm(objGrid.SelectedRows(0).Cells(0).Value.ToString,
                             objGrid.SelectedRows(0).Cells(1).Value.ToString,
                             objGrid.RowCount)
            End If
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub
    Private Sub Grid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Grid.CellMouseDown
        Try
            Dim rowClicked As DataGridView.HitTestInfo = Grid.HitTest(e.X, e.Y)


            'Select Right Clicked Row if its not the header row
            If e.Button = Windows.Forms.MouseButtons.Right AndAlso e.RowIndex > -1 Then
                'Clear any currently sellected rows
                Grid.ClearSelection()
                Me.Grid.Rows(e.RowIndex).Selected = True
                menuContext.Show(Grid, New System.Drawing.Point(e.X, e.Y))
                'CmsRightClick.Show(DgvDelays, New System.Drawing.Point(Windows.Forms.Cursor.Position))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub FrmUser_Group_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If Grid.SelectedRows.Count > 0 Then
                If e.KeyCode = Keys.F1 Then
                    'Dim objGrid As DataGridView = sender
                    If Grid.Rows.Count > 0 Then
                        Call CallFrm(Grid.SelectedRows(0).Cells(0).Value.ToString,
                                     Grid.SelectedRows(0).Cells(1).Value.ToString,
                                     Grid.RowCount)
                    End If
                End If
            End If
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub
End Class
