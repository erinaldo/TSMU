﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBankReceipt_Detail
    Inherits TSMU.baseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.TxtTgl = New DevExpress.XtraEditors.DateEdit()
        Me.TxtNoRekTujuanname = New DevExpress.XtraEditors.TextEdit()
        Me.TxtRemark = New DevExpress.XtraEditors.TextEdit()
        Me.TxtCheckNo = New DevExpress.XtraEditors.TextEdit()
        Me.TxtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPerpost = New DevExpress.XtraEditors.TextEdit()
        Me.TxtNoBukti = New DevExpress.XtraEditors.TextEdit()
        Me.TxtNoRekTujuan = New DevExpress.XtraEditors.ButtonEdit()
        Me.TxtCuryID = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TxtTgl.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTgl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNoRekTujuanname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCheckNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPerpost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNoBukti.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNoRekTujuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCuryID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.TxtTgl)
        Me.LayoutControl1.Controls.Add(Me.TxtNoRekTujuanname)
        Me.LayoutControl1.Controls.Add(Me.TxtRemark)
        Me.LayoutControl1.Controls.Add(Me.TxtCheckNo)
        Me.LayoutControl1.Controls.Add(Me.TxtAmount)
        Me.LayoutControl1.Controls.Add(Me.TxtPerpost)
        Me.LayoutControl1.Controls.Add(Me.TxtNoBukti)
        Me.LayoutControl1.Controls.Add(Me.TxtNoRekTujuan)
        Me.LayoutControl1.Controls.Add(Me.TxtCuryID)
        Me.LayoutControl1.Location = New System.Drawing.Point(37, 61)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(754, 162)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'TxtTgl
        '
        Me.TxtTgl.EditValue = Nothing
        Me.TxtTgl.Location = New System.Drawing.Point(95, 12)
        Me.TxtTgl.Name = "TxtTgl"
        Me.TxtTgl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtTgl.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtTgl.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.TxtTgl.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TxtTgl.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.TxtTgl.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TxtTgl.Properties.Mask.EditMask = ""
        Me.TxtTgl.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TxtTgl.Size = New System.Drawing.Size(106, 20)
        Me.TxtTgl.StyleController = Me.LayoutControl1
        Me.TxtTgl.TabIndex = 8
        '
        'TxtNoRekTujuanname
        '
        Me.TxtNoRekTujuanname.Enabled = False
        Me.TxtNoRekTujuanname.Location = New System.Drawing.Point(205, 36)
        Me.TxtNoRekTujuanname.Name = "TxtNoRekTujuanname"
        Me.TxtNoRekTujuanname.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtNoRekTujuanname.Properties.Appearance.Options.UseBackColor = True
        Me.TxtNoRekTujuanname.Size = New System.Drawing.Size(537, 20)
        Me.TxtNoRekTujuanname.StyleController = Me.LayoutControl1
        Me.TxtNoRekTujuanname.TabIndex = 14
        '
        'TxtRemark
        '
        Me.TxtRemark.Location = New System.Drawing.Point(95, 84)
        Me.TxtRemark.Name = "TxtRemark"
        Me.TxtRemark.Size = New System.Drawing.Size(647, 20)
        Me.TxtRemark.StyleController = Me.LayoutControl1
        Me.TxtRemark.TabIndex = 12
        '
        'TxtCheckNo
        '
        Me.TxtCheckNo.Location = New System.Drawing.Point(95, 60)
        Me.TxtCheckNo.Name = "TxtCheckNo"
        Me.TxtCheckNo.Size = New System.Drawing.Size(273, 20)
        Me.TxtCheckNo.StyleController = Me.LayoutControl1
        Me.TxtCheckNo.TabIndex = 11
        '
        'TxtAmount
        '
        Me.TxtAmount.Location = New System.Drawing.Point(618, 60)
        Me.TxtAmount.Name = "TxtAmount"
        Me.TxtAmount.Size = New System.Drawing.Size(124, 20)
        Me.TxtAmount.StyleController = Me.LayoutControl1
        Me.TxtAmount.TabIndex = 10
        '
        'TxtPerpost
        '
        Me.TxtPerpost.Location = New System.Drawing.Point(615, 12)
        Me.TxtPerpost.Name = "TxtPerpost"
        Me.TxtPerpost.Size = New System.Drawing.Size(127, 20)
        Me.TxtPerpost.StyleController = Me.LayoutControl1
        Me.TxtPerpost.TabIndex = 5
        '
        'TxtNoBukti
        '
        Me.TxtNoBukti.Enabled = False
        Me.TxtNoBukti.Location = New System.Drawing.Point(288, 12)
        Me.TxtNoBukti.Name = "TxtNoBukti"
        Me.TxtNoBukti.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtNoBukti.Properties.Appearance.Options.UseBackColor = True
        Me.TxtNoBukti.Size = New System.Drawing.Size(240, 20)
        Me.TxtNoBukti.StyleController = Me.LayoutControl1
        Me.TxtNoBukti.TabIndex = 4
        '
        'TxtNoRekTujuan
        '
        Me.TxtNoRekTujuan.Location = New System.Drawing.Point(95, 36)
        Me.TxtNoRekTujuan.Name = "TxtNoRekTujuan"
        Me.TxtNoRekTujuan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TxtNoRekTujuan.Size = New System.Drawing.Size(106, 20)
        Me.TxtNoRekTujuan.StyleController = Me.LayoutControl1
        Me.TxtNoRekTujuan.TabIndex = 8
        '
        'TxtCuryID
        '
        Me.TxtCuryID.Location = New System.Drawing.Point(455, 60)
        Me.TxtCuryID.Name = "TxtCuryID"
        Me.TxtCuryID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtCuryID.Properties.Items.AddRange(New Object() {"CHF ", "EUR ", "HKD ", "IDR ", "JPY ", "MXM ", "RM  ", "SGD ", "USD "})
        Me.TxtCuryID.Size = New System.Drawing.Size(76, 20)
        Me.TxtCuryID.StyleController = Me.LayoutControl1
        Me.TxtCuryID.TabIndex = 9
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem9, Me.LayoutControlItem2, Me.LayoutControlItem11, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem3})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(754, 162)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TxtNoBukti
        Me.LayoutControlItem1.Location = New System.Drawing.Point(193, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(327, 24)
        Me.LayoutControlItem1.Text = "No Bukti"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(80, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 96)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(734, 46)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.TxtNoRekTujuan
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(193, 24)
        Me.LayoutControlItem5.Text = "Rekening Tujuan"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.TxtCuryID
        Me.LayoutControlItem6.Location = New System.Drawing.Point(360, 48)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(163, 24)
        Me.LayoutControlItem6.Text = "Currency"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.TxtRemark
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(734, 24)
        Me.LayoutControlItem9.Text = "Remark"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TxtPerpost
        Me.LayoutControlItem2.Location = New System.Drawing.Point(520, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(214, 24)
        Me.LayoutControlItem2.Text = "Perpost"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.TxtNoRekTujuanname
        Me.LayoutControlItem11.Location = New System.Drawing.Point(193, 24)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(541, 24)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.TxtAmount
        Me.LayoutControlItem7.Location = New System.Drawing.Point(523, 48)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(211, 24)
        Me.LayoutControlItem7.Text = "Amount"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.TxtCheckNo
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(360, 24)
        Me.LayoutControlItem8.Text = "Check No/Giro"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TxtTgl
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(193, 24)
        Me.LayoutControlItem3.Text = "Tanggal"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(80, 13)
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'FrmBankReceipt_Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(828, 581)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "FrmBankReceipt_Detail"
        Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TxtTgl.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTgl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNoRekTujuanname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCheckNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPerpost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNoBukti.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNoRekTujuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCuryID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents TxtTgl As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TxtNoRekTujuanname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtRemark As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtCheckNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPerpost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtNoBukti As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtNoRekTujuan As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents TxtCuryID As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents errProvider As ErrorProvider
End Class
