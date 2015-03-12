<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Pan1 = New System.Windows.Forms.Panel()
        Me.vatlab = New System.Windows.Forms.Label()
        Me.changelab = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.itemlab = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pricelab = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.totlab = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.subtotlab = New System.Windows.Forms.Label()
        Me.stocklab = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.checkoutbut = New System.Windows.Forms.Button()
        Me.exitbut = New System.Windows.Forms.Button()
        Me.pricebut = New System.Windows.Forms.Button()
        Me.paid = New System.Windows.Forms.TextBox()
        Me.pricetxt = New System.Windows.Forms.TextBox()
        Me.itemtxt = New System.Windows.Forms.TextBox()
        Me.stocktxt = New System.Windows.Forms.TextBox()
        Me.ordstockbut = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListBox7 = New System.Windows.Forms.ListBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ListBox6 = New System.Windows.Forms.ListBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Pan1.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'Pan1
        '
        Me.Pan1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Pan1.Controls.Add(Me.vatlab)
        Me.Pan1.Controls.Add(Me.changelab)
        Me.Pan1.Controls.Add(Me.label7)
        Me.Pan1.Controls.Add(Me.itemlab)
        Me.Pan1.Controls.Add(Me.Label12)
        Me.Pan1.Controls.Add(Me.pricelab)
        Me.Pan1.Controls.Add(Me.ListBox1)
        Me.Pan1.Controls.Add(Me.ListBox2)
        Me.Pan1.Controls.Add(Me.ListBox3)
        Me.Pan1.Controls.Add(Me.Label10)
        Me.Pan1.Controls.Add(Me.Label9)
        Me.Pan1.Controls.Add(Me.Label8)
        Me.Pan1.Controls.Add(Me.totlab)
        Me.Pan1.Controls.Add(Me.Label6)
        Me.Pan1.Controls.Add(Me.Label5)
        Me.Pan1.Controls.Add(Me.subtotlab)
        Me.Pan1.Controls.Add(Me.stocklab)
        Me.Pan1.Controls.Add(Me.Label2)
        Me.Pan1.Controls.Add(Me.Label1)
        Me.Pan1.Location = New System.Drawing.Point(12, 12)
        Me.Pan1.Name = "Pan1"
        Me.Pan1.Size = New System.Drawing.Size(700, 193)
        Me.Pan1.TabIndex = 0
        '
        'vatlab
        '
        Me.vatlab.AutoSize = true
        Me.vatlab.Location = New System.Drawing.Point(373, 162)
        Me.vatlab.Name = "vatlab"
        Me.vatlab.Size = New System.Drawing.Size(14, 13)
        Me.vatlab.TabIndex = 12
        Me.vatlab.Text = "#"
        Me.vatlab.Visible = false
        '
        'changelab
        '
        Me.changelab.AutoSize = true
        Me.changelab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.changelab.Location = New System.Drawing.Point(217, 159)
        Me.changelab.Name = "changelab"
        Me.changelab.Size = New System.Drawing.Size(15, 13)
        Me.changelab.TabIndex = 11
        Me.changelab.Text = "#"
        '
        'label7
        '
        Me.label7.AutoSize = true
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label7.Location = New System.Drawing.Point(77, 159)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(73, 13)
        Me.label7.TabIndex = 10
        Me.label7.Text = "Change (£):"
        '
        'itemlab
        '
        Me.itemlab.AutoSize = true
        Me.itemlab.Location = New System.Drawing.Point(218, 24)
        Me.itemlab.Name = "itemlab"
        Me.itemlab.Size = New System.Drawing.Size(14, 13)
        Me.itemlab.TabIndex = 1
        Me.itemlab.Text = "#"
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Location = New System.Drawing.Point(77, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Price (£):"
        '
        'pricelab
        '
        Me.pricelab.AutoSize = true
        Me.pricelab.Location = New System.Drawing.Point(218, 49)
        Me.pricelab.Name = "pricelab"
        Me.pricelab.Size = New System.Drawing.Size(14, 13)
        Me.pricelab.TabIndex = 3
        Me.pricelab.Text = "#"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = true
        Me.ListBox1.Location = New System.Drawing.Point(323, 38)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(159, 121)
        Me.ListBox1.TabIndex = 4
        '
        'ListBox2
        '
        Me.ListBox2.Enabled = false
        Me.ListBox2.FormattingEnabled = true
        Me.ListBox2.Location = New System.Drawing.Point(509, 38)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(72, 121)
        Me.ListBox2.TabIndex = 5
        '
        'ListBox3
        '
        Me.ListBox3.Enabled = false
        Me.ListBox3.FormattingEnabled = true
        Me.ListBox3.Location = New System.Drawing.Point(610, 38)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(72, 121)
        Me.ListBox3.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Location = New System.Drawing.Point(607, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Stock level"
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Location = New System.Drawing.Point(506, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Location = New System.Drawing.Point(320, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Product"
        '
        'totlab
        '
        Me.totlab.AutoSize = true
        Me.totlab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.totlab.Location = New System.Drawing.Point(218, 146)
        Me.totlab.Name = "totlab"
        Me.totlab.Size = New System.Drawing.Size(15, 13)
        Me.totlab.TabIndex = 6
        Me.totlab.Text = "#"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(77, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total (£):"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(77, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sub total (£):"
        '
        'subtotlab
        '
        Me.subtotlab.AutoSize = true
        Me.subtotlab.Location = New System.Drawing.Point(218, 98)
        Me.subtotlab.Name = "subtotlab"
        Me.subtotlab.Size = New System.Drawing.Size(14, 13)
        Me.subtotlab.TabIndex = 3
        Me.subtotlab.Text = "#"
        '
        'stocklab
        '
        Me.stocklab.AutoSize = true
        Me.stocklab.Location = New System.Drawing.Point(218, 71)
        Me.stocklab.Name = "stocklab"
        Me.stocklab.Size = New System.Drawing.Size(14, 13)
        Me.stocklab.TabIndex = 2
        Me.stocklab.Text = "#"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(77, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Stock level:"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(77, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item:"
        '
        'checkoutbut
        '
        Me.checkoutbut.Enabled = false
        Me.checkoutbut.Location = New System.Drawing.Point(301, 212)
        Me.checkoutbut.Name = "checkoutbut"
        Me.checkoutbut.Size = New System.Drawing.Size(132, 51)
        Me.checkoutbut.TabIndex = 10
        Me.checkoutbut.Text = "Checkout"
        Me.checkoutbut.UseVisualStyleBackColor = true
        '
        'exitbut
        '
        Me.exitbut.Location = New System.Drawing.Point(570, 36)
        Me.exitbut.Name = "exitbut"
        Me.exitbut.Size = New System.Drawing.Size(94, 69)
        Me.exitbut.TabIndex = 12
        Me.exitbut.Text = "Exit"
        Me.exitbut.UseVisualStyleBackColor = true
        '
        'pricebut
        '
        Me.pricebut.Enabled = false
        Me.pricebut.Location = New System.Drawing.Point(461, 211)
        Me.pricebut.Name = "pricebut"
        Me.pricebut.Size = New System.Drawing.Size(107, 23)
        Me.pricebut.TabIndex = 14
        Me.pricebut.Text = "Change price"
        Me.pricebut.UseVisualStyleBackColor = true
        '
        'paid
        '
        Me.paid.Enabled = false
        Me.paid.Location = New System.Drawing.Point(125, 245)
        Me.paid.Name = "paid"
        Me.paid.Size = New System.Drawing.Size(100, 20)
        Me.paid.TabIndex = 16
        '
        'pricetxt
        '
        Me.pricetxt.Enabled = false
        Me.pricetxt.Location = New System.Drawing.Point(461, 240)
        Me.pricetxt.Name = "pricetxt"
        Me.pricetxt.Size = New System.Drawing.Size(107, 20)
        Me.pricetxt.TabIndex = 17
        '
        'itemtxt
        '
        Me.itemtxt.Enabled = false
        Me.itemtxt.Location = New System.Drawing.Point(125, 214)
        Me.itemtxt.Name = "itemtxt"
        Me.itemtxt.Size = New System.Drawing.Size(100, 20)
        Me.itemtxt.TabIndex = 18
        '
        'stocktxt
        '
        Me.stocktxt.Enabled = false
        Me.stocktxt.Location = New System.Drawing.Point(587, 240)
        Me.stocktxt.Name = "stocktxt"
        Me.stocktxt.Size = New System.Drawing.Size(107, 20)
        Me.stocktxt.TabIndex = 19
        '
        'ordstockbut
        '
        Me.ordstockbut.Enabled = false
        Me.ordstockbut.Location = New System.Drawing.Point(587, 212)
        Me.ordstockbut.Name = "ordstockbut"
        Me.ordstockbut.Size = New System.Drawing.Size(107, 23)
        Me.ordstockbut.TabIndex = 20
        Me.ordstockbut.Text = "Modify stock"
        Me.ordstockbut.UseVisualStyleBackColor = true
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(12, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Number of items:"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(12, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Ammount paid (£):"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.ListBox7)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.exitbut)
        Me.Panel1.Controls.Add(Me.ListBox4)
        Me.Panel1.Controls.Add(Me.ListBox5)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.ListBox6)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Location = New System.Drawing.Point(15, 271)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(697, 120)
        Me.Panel1.TabIndex = 23
        '
        'ListBox7
        '
        Me.ListBox7.Enabled = false
        Me.ListBox7.FormattingEnabled = true
        Me.ListBox7.Location = New System.Drawing.Point(414, 36)
        Me.ListBox7.Name = "ListBox7"
        Me.ListBox7.Size = New System.Drawing.Size(111, 69)
        Me.ListBox7.TabIndex = 20
        '
        'Label16
        '
        Me.Label16.AutoSize = true
        Me.Label16.Location = New System.Drawing.Point(411, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Quantity sold:"
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Location = New System.Drawing.Point(127, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "#"
        '
        'ListBox4
        '
        Me.ListBox4.Enabled = false
        Me.ListBox4.FormattingEnabled = true
        Me.ListBox4.Location = New System.Drawing.Point(15, 36)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(159, 69)
        Me.ListBox4.TabIndex = 13
        '
        'ListBox5
        '
        Me.ListBox5.Enabled = false
        Me.ListBox5.FormattingEnabled = true
        Me.ListBox5.Location = New System.Drawing.Point(297, 36)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(111, 69)
        Me.ListBox5.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = true
        Me.Label15.Location = New System.Drawing.Point(12, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Product sold:"
        '
        'ListBox6
        '
        Me.ListBox6.Enabled = false
        Me.ListBox6.FormattingEnabled = true
        Me.ListBox6.Location = New System.Drawing.Point(180, 36)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(111, 69)
        Me.ListBox6.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Location = New System.Drawing.Point(180, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Price sold at:"
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Location = New System.Drawing.Point(294, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Stock level:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 399)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ordstockbut)
        Me.Controls.Add(Me.stocktxt)
        Me.Controls.Add(Me.itemtxt)
        Me.Controls.Add(Me.pricetxt)
        Me.Controls.Add(Me.paid)
        Me.Controls.Add(Me.checkoutbut)
        Me.Controls.Add(Me.pricebut)
        Me.Controls.Add(Me.Pan1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MainForm"
        Me.Text = "Checkout"
        Me.Pan1.ResumeLayout(false)
        Me.Pan1.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Pan1 As System.Windows.Forms.Panel
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents totlab As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents subtotlab As System.Windows.Forms.Label
    Friend WithEvents stocklab As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents itemlab As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents pricelab As System.Windows.Forms.Label
    Friend WithEvents checkoutbut As System.Windows.Forms.Button
    Friend WithEvents exitbut As System.Windows.Forms.Button
    Friend WithEvents pricebut As System.Windows.Forms.Button
    Friend WithEvents paid As System.Windows.Forms.TextBox
    Friend WithEvents pricetxt As System.Windows.Forms.TextBox
    Friend WithEvents itemtxt As System.Windows.Forms.TextBox
    Friend WithEvents stocktxt As System.Windows.Forms.TextBox
    Friend WithEvents ordstockbut As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents changelab As System.Windows.Forms.Label
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents vatlab As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ListBox7 As System.Windows.Forms.ListBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox5 As System.Windows.Forms.ListBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ListBox6 As System.Windows.Forms.ListBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
