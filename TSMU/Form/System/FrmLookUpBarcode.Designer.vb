﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLookUpBarcode
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLookUpBarcode))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtKodePart = New DevExpress.XtraEditors.TextEdit()
        Me.CmbBulan = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TxtFrom = New DevExpress.XtraEditors.SpinEdit()
        Me.TxtTo = New DevExpress.XtraEditors.SpinEdit()
        Me.TxtSite = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnPrint = New System.Windows.Forms.ToolStripButton()
        Me.txtNo = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TxtKodePart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbBulan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.txtNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtNo)
        Me.LayoutControl1.Controls.Add(Me.Panel1)
        Me.LayoutControl1.Controls.Add(Me.TxtKodePart)
        Me.LayoutControl1.Controls.Add(Me.CmbBulan)
        Me.LayoutControl1.Controls.Add(Me.TxtFrom)
        Me.LayoutControl1.Controls.Add(Me.TxtTo)
        Me.LayoutControl1.Controls.Add(Me.TxtSite)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(296, 231)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(165, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(119, 20)
        Me.Panel1.TabIndex = 6
        '
        'TxtKodePart
        '
        Me.TxtKodePart.Location = New System.Drawing.Point(66, 36)
        Me.TxtKodePart.Name = "TxtKodePart"
        Me.TxtKodePart.Size = New System.Drawing.Size(218, 20)
        Me.TxtKodePart.StyleController = Me.LayoutControl1
        Me.TxtKodePart.TabIndex = 2
        '
        'CmbBulan
        '
        Me.CmbBulan.Location = New System.Drawing.Point(66, 60)
        Me.CmbBulan.Name = "CmbBulan"
        Me.CmbBulan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbBulan.Properties.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.CmbBulan.Size = New System.Drawing.Size(95, 20)
        Me.CmbBulan.StyleController = Me.LayoutControl1
        Me.CmbBulan.TabIndex = 3
        '
        'TxtFrom
        '
        Me.TxtFrom.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TxtFrom.Location = New System.Drawing.Point(66, 84)
        Me.TxtFrom.Name = "TxtFrom"
        Me.TxtFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFrom.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.TxtFrom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TxtFrom.Size = New System.Drawing.Size(95, 20)
        Me.TxtFrom.StyleController = Me.LayoutControl1
        Me.TxtFrom.TabIndex = 4
        '
        'TxtTo
        '
        Me.TxtTo.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TxtTo.Location = New System.Drawing.Point(220, 84)
        Me.TxtTo.Name = "TxtTo"
        Me.TxtTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtTo.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.TxtTo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TxtTo.Size = New System.Drawing.Size(64, 20)
        Me.TxtTo.StyleController = Me.LayoutControl1
        Me.TxtTo.TabIndex = 5
        '
        'TxtSite
        '
        Me.TxtSite.Location = New System.Drawing.Point(66, 12)
        Me.TxtSite.Name = "TxtSite"
        Me.TxtSite.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtSite.Properties.Items.AddRange(New Object() {"INJECTION", "PAINTING"})
        Me.TxtSite.Size = New System.Drawing.Size(218, 20)
        Me.TxtSite.StyleController = Me.LayoutControl1
        Me.TxtSite.TabIndex = 1
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem2, Me.LayoutControlItem1, Me.LayoutControlItem7})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(296, 231)
        Me.Root.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(266, 96)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(10, 115)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TxtKodePart
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(276, 24)
        Me.LayoutControlItem3.Text = "Kode Part"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(51, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TxtFrom
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(153, 24)
        Me.LayoutControlItem4.Text = "Page From"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(51, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.TxtTo
        Me.LayoutControlItem5.Location = New System.Drawing.Point(153, 72)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(123, 24)
        Me.LayoutControlItem5.Text = "To"
        Me.LayoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(50, 20)
        Me.LayoutControlItem5.TextToControlDistance = 5
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.TxtSite
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(276, 24)
        Me.LayoutControlItem6.Text = "Proses"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(51, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.CmbBulan
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(153, 24)
        Me.LayoutControlItem2.Text = "Bulan"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(51, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Panel1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(153, 48)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(123, 24)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnPrint})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(296, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnPrint
        '
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(52, 22)
        Me.BtnPrint.Text = "Print"
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(12, 108)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 60.0!, System.Drawing.FontStyle.Bold)
        Me.txtNo.Properties.Appearance.Options.UseFont = True
        Me.txtNo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNo.Size = New System.Drawing.Size(262, 104)
        Me.txtNo.StyleController = Me.LayoutControl1
        Me.txtNo.TabIndex = 7
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtNo
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(266, 115)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'FrmLookUpBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 256)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLookUpBarcode"
        Me.Text = "Filter"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TxtKodePart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbBulan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.txtNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnPrint As ToolStripButton
    Friend WithEvents TxtKodePart As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CmbBulan As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TxtFrom As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TxtTo As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TxtSite As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
End Class
