﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSuspend_Detail
    Inherits TSMU.baseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.TxtStatus = New DevExpress.XtraEditors.TextEdit()
        Me.TxtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.TxtRemark = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPrNo = New DevExpress.XtraEditors.TextEdit()
        Me.TxtNoSuspend = New DevExpress.XtraEditors.TextEdit()
        Me.TxtTgl = New DevExpress.XtraEditors.DateEdit()
        Me.TxtDep = New DevExpress.XtraEditors.ButtonEdit()
        Me.TxtCurrency = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Label9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Label10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me._subaccount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GSubAccount = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me._account = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GAccount = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me._description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._subtotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GAmount = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TxtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNoSuspend.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTgl.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTgl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCurrency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSubAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.TxtStatus)
        Me.LayoutControl1.Controls.Add(Me.TxtTotal)
        Me.LayoutControl1.Controls.Add(Me.TxtRemark)
        Me.LayoutControl1.Controls.Add(Me.TxtPrNo)
        Me.LayoutControl1.Controls.Add(Me.TxtNoSuspend)
        Me.LayoutControl1.Controls.Add(Me.TxtTgl)
        Me.LayoutControl1.Controls.Add(Me.TxtDep)
        Me.LayoutControl1.Controls.Add(Me.TxtCurrency)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(796, 112)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'TxtStatus
        '
        Me.TxtStatus.Location = New System.Drawing.Point(550, 36)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.Properties.ReadOnly = True
        Me.TxtStatus.Size = New System.Drawing.Size(234, 20)
        Me.TxtStatus.StyleController = Me.LayoutControl1
        Me.TxtStatus.TabIndex = 12
        '
        'TxtTotal
        '
        Me.TxtTotal.EditValue = "0"
        Me.TxtTotal.Location = New System.Drawing.Point(304, 60)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.TxtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TxtTotal.Properties.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(178, 20)
        Me.TxtTotal.StyleController = Me.LayoutControl1
        Me.TxtTotal.TabIndex = 9
        '
        'TxtRemark
        '
        Me.TxtRemark.Location = New System.Drawing.Point(550, 12)
        Me.TxtRemark.Name = "TxtRemark"
        Me.TxtRemark.Size = New System.Drawing.Size(234, 20)
        Me.TxtRemark.StyleController = Me.LayoutControl1
        Me.TxtRemark.TabIndex = 6
        '
        'TxtPrNo
        '
        Me.TxtPrNo.Location = New System.Drawing.Point(76, 36)
        Me.TxtPrNo.Name = "TxtPrNo"
        Me.TxtPrNo.Size = New System.Drawing.Size(160, 20)
        Me.TxtPrNo.StyleController = Me.LayoutControl1
        Me.TxtPrNo.TabIndex = 5
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Isi PR No"
        ConditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.DxValidationProvider1.SetValidationRule(Me.TxtPrNo, ConditionValidationRule3)
        '
        'TxtNoSuspend
        '
        Me.TxtNoSuspend.Location = New System.Drawing.Point(76, 12)
        Me.TxtNoSuspend.Name = "TxtNoSuspend"
        Me.TxtNoSuspend.Properties.ReadOnly = True
        Me.TxtNoSuspend.Size = New System.Drawing.Size(160, 20)
        Me.TxtNoSuspend.StyleController = Me.LayoutControl1
        Me.TxtNoSuspend.TabIndex = 4
        '
        'TxtTgl
        '
        Me.TxtTgl.EditValue = Nothing
        Me.TxtTgl.Location = New System.Drawing.Point(304, 36)
        Me.TxtTgl.Name = "TxtTgl"
        Me.TxtTgl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtTgl.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtTgl.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.TxtTgl.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TxtTgl.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.TxtTgl.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TxtTgl.Properties.Mask.EditMask = ""
        Me.TxtTgl.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TxtTgl.Size = New System.Drawing.Size(178, 20)
        Me.TxtTgl.StyleController = Me.LayoutControl1
        Me.TxtTgl.TabIndex = 7
        '
        'TxtDep
        '
        Me.TxtDep.Location = New System.Drawing.Point(76, 60)
        Me.TxtDep.Name = "TxtDep"
        Me.TxtDep.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TxtDep.Size = New System.Drawing.Size(160, 20)
        Me.TxtDep.StyleController = Me.LayoutControl1
        Me.TxtDep.TabIndex = 11
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Isi Departemen"
        ConditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.DxValidationProvider1.SetValidationRule(Me.TxtDep, ConditionValidationRule1)
        '
        'TxtCurrency
        '
        Me.TxtCurrency.Location = New System.Drawing.Point(304, 12)
        Me.TxtCurrency.Name = "TxtCurrency"
        Me.TxtCurrency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtCurrency.Properties.Items.AddRange(New Object() {"IDR", "USD"})
        Me.TxtCurrency.Size = New System.Drawing.Size(178, 20)
        Me.TxtCurrency.StyleController = Me.LayoutControl1
        Me.TxtCurrency.TabIndex = 8
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem5, Me.LayoutControlItem4, Me.LayoutControlItem3, Me.Label9, Me.Label10, Me.LayoutControlItem6})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(796, 112)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TxtNoSuspend
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(228, 24)
        Me.LayoutControlItem1.Text = "No. Suspend"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(61, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 72)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(776, 20)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TxtPrNo
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(228, 24)
        Me.LayoutControlItem2.Text = "PRNo"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.TxtCurrency
        Me.LayoutControlItem5.Location = New System.Drawing.Point(228, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(246, 24)
        Me.LayoutControlItem5.Text = "Currency"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TxtTgl
        Me.LayoutControlItem4.Location = New System.Drawing.Point(228, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(246, 24)
        Me.LayoutControlItem4.Text = "Date"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TxtRemark
        Me.LayoutControlItem3.Location = New System.Drawing.Point(474, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(302, 24)
        Me.LayoutControlItem3.Text = "Remark"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(61, 13)
        '
        'Label9
        '
        Me.Label9.Control = Me.TxtDep
        Me.Label9.Location = New System.Drawing.Point(0, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(228, 24)
        Me.Label9.Text = "Dept"
        Me.Label9.TextSize = New System.Drawing.Size(61, 13)
        '
        'Label10
        '
        Me.Label10.Control = Me.TxtStatus
        Me.Label10.Location = New System.Drawing.Point(474, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(302, 48)
        Me.Label10.Text = "Status"
        Me.Label10.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.TxtTotal
        Me.LayoutControlItem6.Location = New System.Drawing.Point(228, 48)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(246, 24)
        Me.LayoutControlItem6.Text = "Total"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(61, 13)
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.Location = New System.Drawing.Point(12, 143)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.GAmount, Me.GSubAccount, Me.GAccount})
        Me.Grid.Size = New System.Drawing.Size(772, 426)
        Me.Grid.TabIndex = 3
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me._subaccount, Me._account, Me._description, Me._subtotal})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        '_subaccount
        '
        Me._subaccount.Caption = "SubAccount"
        Me._subaccount.ColumnEdit = Me.GSubAccount
        Me._subaccount.FieldName = "SubAccount"
        Me._subaccount.Name = "_subaccount"
        Me._subaccount.Visible = True
        Me._subaccount.VisibleIndex = 0
        '
        'GSubAccount
        '
        Me.GSubAccount.AutoHeight = False
        Me.GSubAccount.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.GSubAccount.Name = "GSubAccount"
        '
        '_account
        '
        Me._account.Caption = "Account"
        Me._account.ColumnEdit = Me.GAccount
        Me._account.FieldName = "Account"
        Me._account.Name = "_account"
        Me._account.Visible = True
        Me._account.VisibleIndex = 1
        '
        'GAccount
        '
        Me.GAccount.AutoHeight = False
        Me.GAccount.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.GAccount.Name = "GAccount"
        '
        '_description
        '
        Me._description.Caption = "Description"
        Me._description.FieldName = "Description"
        Me._description.Name = "_description"
        Me._description.Visible = True
        Me._description.VisibleIndex = 2
        '
        '_subtotal
        '
        Me._subtotal.Caption = "Amount"
        Me._subtotal.ColumnEdit = Me.GAmount
        Me._subtotal.FieldName = "Amount"
        Me._subtotal.Name = "_subtotal"
        Me._subtotal.Visible = True
        Me._subtotal.VisibleIndex = 3
        '
        'GAmount
        '
        Me.GAmount.AutoHeight = False
        Me.GAmount.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GAmount.Name = "GAmount"
        '
        'DxValidationProvider1
        '
        Me.DxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.[Auto]
        '
        'FrmSuspend_Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(796, 581)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "FrmSuspend_Detail"
        Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
        Me.Controls.SetChildIndex(Me.Grid, 0)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TxtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNoSuspend.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTgl.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTgl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCurrency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSubAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents TxtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtRemark As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtTgl As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents _subaccount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents _account As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents _description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents _subtotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GAmount As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents GSubAccount As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GAccount As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents TxtNoSuspend As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Label9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TxtDep As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents TxtStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TxtCurrency As DevExpress.XtraEditors.ComboBoxEdit
End Class
