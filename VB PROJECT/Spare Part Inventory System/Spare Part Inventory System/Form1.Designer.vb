<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Tabregister = New System.Windows.Forms.TabPage()
        Me.grplogin = New System.Windows.Forms.GroupBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.password = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcategory = New System.Windows.Forms.TextBox()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnprevious = New System.Windows.Forms.Button()
        Me.btnadding = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtboxpartname = New System.Windows.Forms.TextBox()
        Me.txtboxunitprice = New System.Windows.Forms.TextBox()
        Me.txtboxserialnumber = New System.Windows.Forms.TextBox()
        Me.lblunitprice = New System.Windows.Forms.Label()
        Me.lblcategory = New System.Windows.Forms.Label()
        Me.lblpartname = New System.Windows.Forms.Label()
        Me.lblserialno = New System.Windows.Forms.Label()
        Me.Lblregister = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.Tabadd = New System.Windows.Forms.TabPage()
        Me.grpitemdeatails = New System.Windows.Forms.GroupBox()
        Me.txtboxdesc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnend = New System.Windows.Forms.Button()
        Me.btnnewsave = New System.Windows.Forms.Button()
        Me.txtserialnumber = New System.Windows.Forms.TextBox()
        Me.grpsummary = New System.Windows.Forms.GroupBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.lbltotalprice = New System.Windows.Forms.Label()
        Me.txtunitprice = New System.Windows.Forms.TextBox()
        Me.lblquantity = New System.Windows.Forms.Label()
        Me.lblserialnumber = New System.Windows.Forms.Label()
        Me.lbltransactiondate = New System.Windows.Forms.Label()
        Me.lbltansaction = New System.Windows.Forms.Label()
        Me.Tablist = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btntoend = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.btnnewentry = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btntoexit = New System.Windows.Forms.Button()
        Me.NewSparePartStockInBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalPriceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_sparesDataSet = New Spare_Part_Inventory_System.Db_sparesDataSet()
        Me.InventoryListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewSparePartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SerialNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerialNumberDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StorageLocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_priceTableAdapter = New Spare_Part_Inventory_System.Db_sparesDataSetTableAdapters.Total_priceTableAdapter()
        Me.Inventory_listTableAdapter = New Spare_Part_Inventory_System.Db_sparesDataSetTableAdapters.Inventory_listTableAdapter()
        Me.New_Spare_PartTableAdapter = New Spare_Part_Inventory_System.Db_sparesDataSetTableAdapters.New_Spare_PartTableAdapter()
        Me.NewSparePartBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Stock_InTableAdapter = New Spare_Part_Inventory_System.Db_sparesDataSetTableAdapters.Stock_InTableAdapter()
        Me.NewSparePartBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.Tabregister.SuspendLayout()
        Me.grplogin.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.Tabadd.SuspendLayout()
        Me.grpitemdeatails.SuspendLayout()
        Me.grpsummary.SuspendLayout()
        Me.Tablist.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewSparePartStockInBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalPriceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_sparesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewSparePartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewSparePartBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewSparePartBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Tabregister)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1036, 623)
        Me.TabControl1.TabIndex = 0
        '
        'Tabregister
        '
        Me.Tabregister.BackColor = System.Drawing.Color.Transparent
        Me.Tabregister.Controls.Add(Me.txtcategory)
        Me.Tabregister.Controls.Add(Me.btnnext)
        Me.Tabregister.Controls.Add(Me.btnprevious)
        Me.Tabregister.Controls.Add(Me.btnadding)
        Me.Tabregister.Controls.Add(Me.btnlogout)
        Me.Tabregister.Controls.Add(Me.btnclose)
        Me.Tabregister.Controls.Add(Me.btnsave)
        Me.Tabregister.Controls.Add(Me.txtboxpartname)
        Me.Tabregister.Controls.Add(Me.txtboxunitprice)
        Me.Tabregister.Controls.Add(Me.txtboxserialnumber)
        Me.Tabregister.Controls.Add(Me.lblunitprice)
        Me.Tabregister.Controls.Add(Me.lblcategory)
        Me.Tabregister.Controls.Add(Me.lblpartname)
        Me.Tabregister.Controls.Add(Me.lblserialno)
        Me.Tabregister.Controls.Add(Me.Lblregister)
        Me.Tabregister.ForeColor = System.Drawing.SystemColors.Control
        Me.Tabregister.Location = New System.Drawing.Point(4, 39)
        Me.Tabregister.Name = "Tabregister"
        Me.Tabregister.Padding = New System.Windows.Forms.Padding(3)
        Me.Tabregister.Size = New System.Drawing.Size(1028, 580)
        Me.Tabregister.TabIndex = 0
        Me.Tabregister.Text = "RegisterPart"
        '
        'grplogin
        '
        Me.grplogin.BackgroundImage = CType(resources.GetObject("grplogin.BackgroundImage"), System.Drawing.Image)
        Me.grplogin.Controls.Add(Me.btnlogin)
        Me.grplogin.Controls.Add(Me.txtpassword)
        Me.grplogin.Controls.Add(Me.txtusername)
        Me.grplogin.Controls.Add(Me.Label4)
        Me.grplogin.Controls.Add(Me.btnexit)
        Me.grplogin.Controls.Add(Me.btnreset)
        Me.grplogin.Controls.Add(Me.password)
        Me.grplogin.Controls.Add(Me.username)
        Me.grplogin.Controls.Add(Me.Label1)
        Me.grplogin.Location = New System.Drawing.Point(22, 12)
        Me.grplogin.Name = "grplogin"
        Me.grplogin.Size = New System.Drawing.Size(1139, 605)
        Me.grplogin.TabIndex = 0
        Me.grplogin.TabStop = False
        Me.grplogin.Text = "Login"
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.OldLace
        Me.btnlogin.ForeColor = System.Drawing.Color.Indigo
        Me.btnlogin.Location = New System.Drawing.Point(280, 356)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(86, 46)
        Me.btnlogin.TabIndex = 7
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(280, 308)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(228, 20)
        Me.txtpassword.TabIndex = 6
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(279, 222)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(228, 20)
        Me.txtusername.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Orange
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(95, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(725, 47)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "DAVE'S AUTOSPARES INVENTORY SYSTEM"
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.OldLace
        Me.btnexit.ForeColor = System.Drawing.Color.Indigo
        Me.btnexit.Location = New System.Drawing.Point(513, 356)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 46)
        Me.btnexit.TabIndex = 3
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.OldLace
        Me.btnreset.ForeColor = System.Drawing.Color.Indigo
        Me.btnreset.Location = New System.Drawing.Point(399, 356)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 46)
        Me.btnreset.TabIndex = 3
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(274, 266)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(118, 24)
        Me.password.TabIndex = 2
        Me.password.Text = "PASSWORD"
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.username.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(276, 188)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(117, 24)
        Me.username.TabIndex = 1
        Me.username.Text = "USERNAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'txtcategory
        '
        Me.txtcategory.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TotalPriceBindingSource, "Category", True))
        Me.txtcategory.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.InventoryListBindingSource, "Category", True))
        Me.txtcategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtcategory.Location = New System.Drawing.Point(359, 235)
        Me.txtcategory.Name = "txtcategory"
        Me.txtcategory.Size = New System.Drawing.Size(252, 35)
        Me.txtcategory.TabIndex = 18
        Me.txtcategory.Tag = ""
        '
        'btnnext
        '
        Me.btnnext.ForeColor = System.Drawing.Color.Indigo
        Me.btnnext.Location = New System.Drawing.Point(533, 395)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(75, 36)
        Me.btnnext.TabIndex = 17
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btnprevious
        '
        Me.btnprevious.ForeColor = System.Drawing.Color.Indigo
        Me.btnprevious.Location = New System.Drawing.Point(410, 395)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.Size = New System.Drawing.Size(113, 36)
        Me.btnprevious.TabIndex = 16
        Me.btnprevious.Text = "Previous"
        Me.btnprevious.UseVisualStyleBackColor = True
        '
        'btnadding
        '
        Me.btnadding.ForeColor = System.Drawing.Color.Indigo
        Me.btnadding.Location = New System.Drawing.Point(320, 395)
        Me.btnadding.Name = "btnadding"
        Me.btnadding.Size = New System.Drawing.Size(75, 36)
        Me.btnadding.TabIndex = 15
        Me.btnadding.Text = "Add"
        Me.btnadding.UseVisualStyleBackColor = True
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.Black
        Me.btnlogout.Location = New System.Drawing.Point(928, 6)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(94, 39)
        Me.btnlogout.TabIndex = 14
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.ForeColor = System.Drawing.Color.Indigo
        Me.btnclose.Location = New System.Drawing.Point(716, 395)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 36)
        Me.btnclose.TabIndex = 13
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.ForeColor = System.Drawing.Color.Indigo
        Me.btnsave.Location = New System.Drawing.Point(625, 395)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 36)
        Me.btnsave.TabIndex = 12
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'txtboxpartname
        '
        Me.txtboxpartname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TotalPriceBindingSource, "Part Name", True))
        Me.txtboxpartname.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.InventoryListBindingSource, "Part Name", True))
        Me.txtboxpartname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtboxpartname.Location = New System.Drawing.Point(359, 171)
        Me.txtboxpartname.Name = "txtboxpartname"
        Me.txtboxpartname.Size = New System.Drawing.Size(235, 35)
        Me.txtboxpartname.TabIndex = 11
        Me.txtboxpartname.Tag = ""
        '
        'txtboxunitprice
        '
        Me.txtboxunitprice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TotalPriceBindingSource, "Unit Price", True))
        Me.txtboxunitprice.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.InventoryListBindingSource, "Unit Price", True))
        Me.txtboxunitprice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtboxunitprice.Location = New System.Drawing.Point(359, 303)
        Me.txtboxunitprice.Name = "txtboxunitprice"
        Me.txtboxunitprice.Size = New System.Drawing.Size(100, 35)
        Me.txtboxunitprice.TabIndex = 9
        Me.txtboxunitprice.Tag = ""
        '
        'txtboxserialnumber
        '
        Me.txtboxserialnumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TotalPriceBindingSource, "Serial Number", True))
        Me.txtboxserialnumber.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.InventoryListBindingSource, "Serial Number", True))
        Me.txtboxserialnumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtboxserialnumber.Location = New System.Drawing.Point(359, 119)
        Me.txtboxserialnumber.Name = "txtboxserialnumber"
        Me.txtboxserialnumber.Size = New System.Drawing.Size(235, 35)
        Me.txtboxserialnumber.TabIndex = 8
        Me.txtboxserialnumber.Tag = ""
        '
        'lblunitprice
        '
        Me.lblunitprice.AutoSize = True
        Me.lblunitprice.BackColor = System.Drawing.Color.Khaki
        Me.lblunitprice.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunitprice.ForeColor = System.Drawing.Color.Purple
        Me.lblunitprice.Location = New System.Drawing.Point(203, 303)
        Me.lblunitprice.Name = "lblunitprice"
        Me.lblunitprice.Size = New System.Drawing.Size(121, 30)
        Me.lblunitprice.TabIndex = 6
        Me.lblunitprice.Text = "Unit Price :"
        '
        'lblcategory
        '
        Me.lblcategory.AutoSize = True
        Me.lblcategory.BackColor = System.Drawing.Color.Khaki
        Me.lblcategory.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcategory.ForeColor = System.Drawing.Color.Purple
        Me.lblcategory.Location = New System.Drawing.Point(203, 235)
        Me.lblcategory.Name = "lblcategory"
        Me.lblcategory.Size = New System.Drawing.Size(113, 30)
        Me.lblcategory.TabIndex = 5
        Me.lblcategory.Text = "Category :"
        '
        'lblpartname
        '
        Me.lblpartname.AutoSize = True
        Me.lblpartname.BackColor = System.Drawing.Color.Khaki
        Me.lblpartname.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpartname.ForeColor = System.Drawing.Color.Purple
        Me.lblpartname.Location = New System.Drawing.Point(203, 171)
        Me.lblpartname.Name = "lblpartname"
        Me.lblpartname.Size = New System.Drawing.Size(129, 30)
        Me.lblpartname.TabIndex = 3
        Me.lblpartname.Text = "Part Name :"
        '
        'lblserialno
        '
        Me.lblserialno.AutoSize = True
        Me.lblserialno.BackColor = System.Drawing.Color.Khaki
        Me.lblserialno.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblserialno.ForeColor = System.Drawing.Color.Purple
        Me.lblserialno.Location = New System.Drawing.Point(203, 120)
        Me.lblserialno.Name = "lblserialno"
        Me.lblserialno.Size = New System.Drawing.Size(109, 30)
        Me.lblserialno.TabIndex = 2
        Me.lblserialno.Text = "SerialNo :"
        '
        'Lblregister
        '
        Me.Lblregister.AutoSize = True
        Me.Lblregister.BackColor = System.Drawing.Color.Gold
        Me.Lblregister.Font = New System.Drawing.Font("Leelawadee UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblregister.ForeColor = System.Drawing.Color.Purple
        Me.Lblregister.Location = New System.Drawing.Point(308, 16)
        Me.Lblregister.Name = "Lblregister"
        Me.Lblregister.Size = New System.Drawing.Size(286, 37)
        Me.Lblregister.TabIndex = 1
        Me.Lblregister.Text = "REGISTER NEW PART"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.TabControl2)
        Me.TabPage2.ForeColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Location = New System.Drawing.Point(4, 39)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1028, 580)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Stock-in"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(923, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 39)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.Tabadd)
        Me.TabControl2.Controls.Add(Me.Tablist)
        Me.TabControl2.Location = New System.Drawing.Point(6, 21)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(911, 553)
        Me.TabControl2.TabIndex = 0
        '
        'Tabadd
        '
        Me.Tabadd.Controls.Add(Me.grpitemdeatails)
        Me.Tabadd.Controls.Add(Me.lbltransactiondate)
        Me.Tabadd.Controls.Add(Me.lbltansaction)
        Me.Tabadd.Location = New System.Drawing.Point(4, 39)
        Me.Tabadd.Name = "Tabadd"
        Me.Tabadd.Padding = New System.Windows.Forms.Padding(3)
        Me.Tabadd.Size = New System.Drawing.Size(903, 510)
        Me.Tabadd.TabIndex = 0
        Me.Tabadd.Text = "Add"
        Me.Tabadd.UseVisualStyleBackColor = True
        '
        'grpitemdeatails
        '
        Me.grpitemdeatails.Controls.Add(Me.txtboxdesc)
        Me.grpitemdeatails.Controls.Add(Me.Label2)
        Me.grpitemdeatails.Controls.Add(Me.btnnew)
        Me.grpitemdeatails.Controls.Add(Me.btnend)
        Me.grpitemdeatails.Controls.Add(Me.btnnewsave)
        Me.grpitemdeatails.Controls.Add(Me.txtserialnumber)
        Me.grpitemdeatails.Controls.Add(Me.grpsummary)
        Me.grpitemdeatails.Controls.Add(Me.lblserialnumber)
        Me.grpitemdeatails.Location = New System.Drawing.Point(10, 52)
        Me.grpitemdeatails.Name = "grpitemdeatails"
        Me.grpitemdeatails.Size = New System.Drawing.Size(856, 452)
        Me.grpitemdeatails.TabIndex = 7
        Me.grpitemdeatails.TabStop = False
        Me.grpitemdeatails.Text = "Item Details"
        '
        'txtboxdesc
        '
        Me.txtboxdesc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryListBindingSource, "Description", True))
        Me.txtboxdesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtboxdesc.Location = New System.Drawing.Point(328, 96)
        Me.txtboxdesc.Name = "txtboxdesc"
        Me.txtboxdesc.Size = New System.Drawing.Size(423, 35)
        Me.txtboxdesc.TabIndex = 17
        Me.txtboxdesc.Tag = "NewSparePartBindingSource - Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Khaki
        Me.Label2.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Purple
        Me.Label2.Location = New System.Drawing.Point(168, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 30)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Description :"
        '
        'btnnew
        '
        Me.btnnew.ForeColor = System.Drawing.Color.Indigo
        Me.btnnew.Location = New System.Drawing.Point(333, 396)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(75, 36)
        Me.btnnew.TabIndex = 15
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnend
        '
        Me.btnend.ForeColor = System.Drawing.Color.Indigo
        Me.btnend.Location = New System.Drawing.Point(623, 396)
        Me.btnend.Name = "btnend"
        Me.btnend.Size = New System.Drawing.Size(75, 36)
        Me.btnend.TabIndex = 14
        Me.btnend.Text = "Close"
        Me.btnend.UseVisualStyleBackColor = True
        '
        'btnnewsave
        '
        Me.btnnewsave.ForeColor = System.Drawing.Color.Indigo
        Me.btnnewsave.Location = New System.Drawing.Point(477, 396)
        Me.btnnewsave.Name = "btnnewsave"
        Me.btnnewsave.Size = New System.Drawing.Size(75, 36)
        Me.btnnewsave.TabIndex = 13
        Me.btnnewsave.Text = "Save"
        Me.btnnewsave.UseVisualStyleBackColor = True
        '
        'txtserialnumber
        '
        Me.txtserialnumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryListBindingSource, "Serial Number", True))
        Me.txtserialnumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtserialnumber.Location = New System.Drawing.Point(327, 45)
        Me.txtserialnumber.Name = "txtserialnumber"
        Me.txtserialnumber.Size = New System.Drawing.Size(315, 35)
        Me.txtserialnumber.TabIndex = 12
        '
        'grpsummary
        '
        Me.grpsummary.Controls.Add(Me.TextBox9)
        Me.grpsummary.Controls.Add(Me.txtquantity)
        Me.grpsummary.Controls.Add(Me.lblprice)
        Me.grpsummary.Controls.Add(Me.lbltotalprice)
        Me.grpsummary.Controls.Add(Me.txtunitprice)
        Me.grpsummary.Controls.Add(Me.lblquantity)
        Me.grpsummary.Location = New System.Drawing.Point(220, 158)
        Me.grpsummary.Name = "grpsummary"
        Me.grpsummary.Size = New System.Drawing.Size(476, 207)
        Me.grpsummary.TabIndex = 9
        Me.grpsummary.TabStop = False
        Me.grpsummary.Text = "Summary"
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TotalPriceBindingSource, "Total", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.TextBox9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox9.Location = New System.Drawing.Point(194, 140)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(137, 35)
        Me.TextBox9.TabIndex = 12
        '
        'txtquantity
        '
        Me.txtquantity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TotalPriceBindingSource, "Quantity", True))
        Me.txtquantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtquantity.Location = New System.Drawing.Point(194, 93)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(137, 35)
        Me.txtquantity.TabIndex = 11
        Me.txtquantity.Tag = "InventoryListBindingSource - Quantity"
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.BackColor = System.Drawing.Color.Khaki
        Me.lblprice.ForeColor = System.Drawing.Color.Purple
        Me.lblprice.Location = New System.Drawing.Point(34, 50)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(115, 30)
        Me.lblprice.TabIndex = 6
        Me.lblprice.Text = "Unit Price:"
        '
        'lbltotalprice
        '
        Me.lbltotalprice.AutoSize = True
        Me.lbltotalprice.BackColor = System.Drawing.Color.Khaki
        Me.lbltotalprice.ForeColor = System.Drawing.Color.Purple
        Me.lbltotalprice.Location = New System.Drawing.Point(34, 143)
        Me.lbltotalprice.Name = "lbltotalprice"
        Me.lbltotalprice.Size = New System.Drawing.Size(129, 30)
        Me.lbltotalprice.TabIndex = 8
        Me.lbltotalprice.Text = "Total Price :"
        '
        'txtunitprice
        '
        Me.txtunitprice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewSparePartBindingSource, "Unit Price", True))
        Me.txtunitprice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtunitprice.Location = New System.Drawing.Point(195, 45)
        Me.txtunitprice.Name = "txtunitprice"
        Me.txtunitprice.Size = New System.Drawing.Size(137, 35)
        Me.txtunitprice.TabIndex = 10
        '
        'lblquantity
        '
        Me.lblquantity.AutoSize = True
        Me.lblquantity.BackColor = System.Drawing.Color.Khaki
        Me.lblquantity.ForeColor = System.Drawing.Color.Purple
        Me.lblquantity.Location = New System.Drawing.Point(34, 97)
        Me.lblquantity.Name = "lblquantity"
        Me.lblquantity.Size = New System.Drawing.Size(111, 30)
        Me.lblquantity.TabIndex = 7
        Me.lblquantity.Text = "Quantity :"
        '
        'lblserialnumber
        '
        Me.lblserialnumber.AutoSize = True
        Me.lblserialnumber.BackColor = System.Drawing.Color.Khaki
        Me.lblserialnumber.ForeColor = System.Drawing.Color.Purple
        Me.lblserialnumber.Location = New System.Drawing.Point(145, 45)
        Me.lblserialnumber.Name = "lblserialnumber"
        Me.lblserialnumber.Size = New System.Drawing.Size(160, 30)
        Me.lblserialnumber.TabIndex = 4
        Me.lblserialnumber.Text = "SerialNumber :"
        '
        'lbltransactiondate
        '
        Me.lbltransactiondate.AutoSize = True
        Me.lbltransactiondate.BackColor = System.Drawing.Color.Khaki
        Me.lbltransactiondate.ForeColor = System.Drawing.Color.Purple
        Me.lbltransactiondate.Location = New System.Drawing.Point(530, 14)
        Me.lbltransactiondate.Name = "lbltransactiondate"
        Me.lbltransactiondate.Size = New System.Drawing.Size(178, 30)
        Me.lbltransactiondate.TabIndex = 6
        Me.lbltransactiondate.Text = "Transaction Date"
        '
        'lbltansaction
        '
        Me.lbltansaction.AutoSize = True
        Me.lbltansaction.BackColor = System.Drawing.Color.Khaki
        Me.lbltansaction.ForeColor = System.Drawing.Color.Purple
        Me.lbltansaction.Location = New System.Drawing.Point(6, 14)
        Me.lbltansaction.Name = "lbltansaction"
        Me.lbltansaction.Size = New System.Drawing.Size(175, 30)
        Me.lbltansaction.TabIndex = 3
        Me.lbltansaction.Text = "Transaction No :"
        '
        'Tablist
        '
        Me.Tablist.Controls.Add(Me.DataGridView1)
        Me.Tablist.Controls.Add(Me.btntoend)
        Me.Tablist.Location = New System.Drawing.Point(4, 39)
        Me.Tablist.Name = "Tablist"
        Me.Tablist.Padding = New System.Windows.Forms.Padding(3)
        Me.Tablist.Size = New System.Drawing.Size(903, 510)
        Me.Tablist.TabIndex = 1
        Me.Tablist.Text = "List"
        Me.Tablist.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Highlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SerialNumberDataGridViewTextBoxColumn, Me.PartNameDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TotalPriceBindingSource
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(6, 32)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(901, 418)
        Me.DataGridView1.TabIndex = 16
        '
        'btntoend
        '
        Me.btntoend.ForeColor = System.Drawing.Color.Indigo
        Me.btntoend.Location = New System.Drawing.Point(758, 456)
        Me.btntoend.Name = "btntoend"
        Me.btntoend.Size = New System.Drawing.Size(75, 36)
        Me.btntoend.TabIndex = 15
        Me.btntoend.Text = "Close"
        Me.btntoend.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridView2)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.btnrefresh)
        Me.TabPage3.Controls.Add(Me.btnnewentry)
        Me.TabPage3.Controls.Add(Me.btnedit)
        Me.TabPage3.Controls.Add(Me.btntoexit)
        Me.TabPage3.ForeColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Location = New System.Drawing.Point(4, 39)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1028, 580)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "InventoryList"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.MenuHighlight
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SerialNumberDataGridViewTextBoxColumn1, Me.PartNameDataGridViewTextBoxColumn1, Me.DescriptionDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn1, Me.UnitPriceDataGridViewTextBoxColumn1, Me.QuantityDataGridViewTextBoxColumn1, Me.StorageLocationDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.InventoryListBindingSource
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView2.Location = New System.Drawing.Point(15, 18)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(882, 494)
        Me.DataGridView2.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(931, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 39)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Logout"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnrefresh
        '
        Me.btnrefresh.ForeColor = System.Drawing.Color.Indigo
        Me.btnrefresh.Location = New System.Drawing.Point(381, 518)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(98, 36)
        Me.btnrefresh.TabIndex = 18
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'btnnewentry
        '
        Me.btnnewentry.ForeColor = System.Drawing.Color.Indigo
        Me.btnnewentry.Location = New System.Drawing.Point(525, 518)
        Me.btnnewentry.Name = "btnnewentry"
        Me.btnnewentry.Size = New System.Drawing.Size(75, 36)
        Me.btnnewentry.TabIndex = 17
        Me.btnnewentry.Text = "New"
        Me.btnnewentry.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.ForeColor = System.Drawing.Color.Indigo
        Me.btnedit.Location = New System.Drawing.Point(658, 518)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 36)
        Me.btnedit.TabIndex = 16
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btntoexit
        '
        Me.btntoexit.ForeColor = System.Drawing.Color.Indigo
        Me.btntoexit.Location = New System.Drawing.Point(800, 518)
        Me.btntoexit.Name = "btntoexit"
        Me.btntoexit.Size = New System.Drawing.Size(75, 36)
        Me.btntoexit.TabIndex = 15
        Me.btntoexit.Text = "Close"
        Me.btntoexit.UseVisualStyleBackColor = True
        '
        'NewSparePartStockInBindingSource
        '
        Me.NewSparePartStockInBindingSource.DataMember = "New Spare PartStock In"
        Me.NewSparePartStockInBindingSource.DataSource = Me.NewSparePartBindingSource
        '
        'TotalPriceBindingSource
        '
        Me.TotalPriceBindingSource.DataMember = "Total price"
        Me.TotalPriceBindingSource.DataSource = Me.Db_sparesDataSet
        '
        'Db_sparesDataSet
        '
        Me.Db_sparesDataSet.DataSetName = "Db_sparesDataSet"
        Me.Db_sparesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventoryListBindingSource
        '
        Me.InventoryListBindingSource.DataMember = "Inventory list"
        Me.InventoryListBindingSource.DataSource = Me.Db_sparesDataSet
        '
        'NewSparePartBindingSource
        '
        Me.NewSparePartBindingSource.DataMember = "New Spare Part"
        Me.NewSparePartBindingSource.DataSource = Me.Db_sparesDataSet
        '
        'SerialNumberDataGridViewTextBoxColumn
        '
        Me.SerialNumberDataGridViewTextBoxColumn.DataPropertyName = "Serial Number"
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.SerialNumberDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.SerialNumberDataGridViewTextBoxColumn.HeaderText = "Serial Number"
        Me.SerialNumberDataGridViewTextBoxColumn.Name = "SerialNumberDataGridViewTextBoxColumn"
        '
        'PartNameDataGridViewTextBoxColumn
        '
        Me.PartNameDataGridViewTextBoxColumn.DataPropertyName = "Part Name"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.PartNameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.PartNameDataGridViewTextBoxColumn.HeaderText = "Part Name"
        Me.PartNameDataGridViewTextBoxColumn.Name = "PartNameDataGridViewTextBoxColumn"
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.CategoryDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        '
        'UnitPriceDataGridViewTextBoxColumn
        '
        Me.UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "Unit Price"
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.UnitPriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.UnitPriceDataGridViewTextBoxColumn.HeaderText = "Unit Price"
        Me.UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.QuantityDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.TotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SerialNumberDataGridViewTextBoxColumn1
        '
        Me.SerialNumberDataGridViewTextBoxColumn1.DataPropertyName = "Serial Number"
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.SerialNumberDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle7
        Me.SerialNumberDataGridViewTextBoxColumn1.HeaderText = "Serial Number"
        Me.SerialNumberDataGridViewTextBoxColumn1.Name = "SerialNumberDataGridViewTextBoxColumn1"
        '
        'PartNameDataGridViewTextBoxColumn1
        '
        Me.PartNameDataGridViewTextBoxColumn1.DataPropertyName = "Part Name"
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        Me.PartNameDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle8
        Me.PartNameDataGridViewTextBoxColumn1.HeaderText = "Part Name"
        Me.PartNameDataGridViewTextBoxColumn1.Name = "PartNameDataGridViewTextBoxColumn1"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        Me.DescriptionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'CategoryDataGridViewTextBoxColumn1
        '
        Me.CategoryDataGridViewTextBoxColumn1.DataPropertyName = "Category"
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        Me.CategoryDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle10
        Me.CategoryDataGridViewTextBoxColumn1.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn1.Name = "CategoryDataGridViewTextBoxColumn1"
        '
        'UnitPriceDataGridViewTextBoxColumn1
        '
        Me.UnitPriceDataGridViewTextBoxColumn1.DataPropertyName = "Unit Price"
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        Me.UnitPriceDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle11
        Me.UnitPriceDataGridViewTextBoxColumn1.HeaderText = "Unit Price"
        Me.UnitPriceDataGridViewTextBoxColumn1.Name = "UnitPriceDataGridViewTextBoxColumn1"
        '
        'QuantityDataGridViewTextBoxColumn1
        '
        Me.QuantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity"
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        Me.QuantityDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle12
        Me.QuantityDataGridViewTextBoxColumn1.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn1.Name = "QuantityDataGridViewTextBoxColumn1"
        '
        'StorageLocationDataGridViewTextBoxColumn
        '
        Me.StorageLocationDataGridViewTextBoxColumn.DataPropertyName = "Storage Location"
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        Me.StorageLocationDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle13
        Me.StorageLocationDataGridViewTextBoxColumn.HeaderText = "Storage Location"
        Me.StorageLocationDataGridViewTextBoxColumn.Name = "StorageLocationDataGridViewTextBoxColumn"
        '
        'Total_priceTableAdapter
        '
        Me.Total_priceTableAdapter.ClearBeforeFill = True
        '
        'Inventory_listTableAdapter
        '
        Me.Inventory_listTableAdapter.ClearBeforeFill = True
        '
        'New_Spare_PartTableAdapter
        '
        Me.New_Spare_PartTableAdapter.ClearBeforeFill = True
        '
        'NewSparePartBindingSource1
        '
        Me.NewSparePartBindingSource1.DataMember = "New Spare Part"
        Me.NewSparePartBindingSource1.DataSource = Me.Db_sparesDataSet
        '
        'Stock_InTableAdapter
        '
        Me.Stock_InTableAdapter.ClearBeforeFill = True
        '
        'NewSparePartBindingSource2
        '
        Me.NewSparePartBindingSource2.DataMember = "New Spare Part"
        Me.NewSparePartBindingSource2.DataSource = Me.Db_sparesDataSet
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 708)
        Me.Controls.Add(Me.grplogin)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "MAIN"
        Me.TabControl1.ResumeLayout(False)
        Me.Tabregister.ResumeLayout(False)
        Me.Tabregister.PerformLayout()
        Me.grplogin.ResumeLayout(False)
        Me.grplogin.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.Tabadd.ResumeLayout(False)
        Me.Tabadd.PerformLayout()
        Me.grpitemdeatails.ResumeLayout(False)
        Me.grpitemdeatails.PerformLayout()
        Me.grpsummary.ResumeLayout(False)
        Me.grpsummary.PerformLayout()
        Me.Tablist.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewSparePartStockInBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalPriceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_sparesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewSparePartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewSparePartBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewSparePartBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Tabregister As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents grplogin As GroupBox
    Friend WithEvents btnexit As Button
    Friend WithEvents btnreset As Button
    Friend WithEvents password As Label
    Friend WithEvents username As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnlogin As Button
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Lblregister As Label
    Friend WithEvents lblserialno As Label
    Friend WithEvents lblcategory As Label
    Friend WithEvents lblpartname As Label
    Friend WithEvents lblunitprice As Label
    Friend WithEvents txtboxpartname As TextBox
    Friend WithEvents txtboxunitprice As TextBox
    Friend WithEvents txtboxserialnumber As TextBox
    Friend WithEvents btnclose As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents Tabadd As TabPage
    Friend WithEvents grpitemdeatails As GroupBox
    Friend WithEvents grpsummary As GroupBox
    Friend WithEvents lblprice As Label
    Friend WithEvents lbltotalprice As Label
    Friend WithEvents lblquantity As Label
    Friend WithEvents lblserialnumber As Label
    Friend WithEvents lbltransactiondate As Label
    Friend WithEvents lbltansaction As Label
    Friend WithEvents Tablist As TabPage
    Friend WithEvents txtserialnumber As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents txtunitprice As TextBox
    Friend WithEvents btnnew As Button
    Friend WithEvents btnend As Button
    Friend WithEvents btnnewsave As Button
    Friend WithEvents btntoend As Button
    Friend WithEvents btnrefresh As Button
    Friend WithEvents btnnewentry As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btntoexit As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Db_sparesDataSet As Db_sparesDataSet
    Friend WithEvents TotalPriceBindingSource As BindingSource
    Friend WithEvents Total_priceTableAdapter As Db_sparesDataSetTableAdapters.Total_priceTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents InventoryListBindingSource As BindingSource
    Friend WithEvents Inventory_listTableAdapter As Db_sparesDataSetTableAdapters.Inventory_listTableAdapter
    Friend WithEvents SerialNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PartNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SerialNumberDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PartNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StorageLocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NewSparePartBindingSource As BindingSource
    Friend WithEvents New_Spare_PartTableAdapter As Db_sparesDataSetTableAdapters.New_Spare_PartTableAdapter
    Friend WithEvents NewSparePartBindingSource1 As BindingSource
    Friend WithEvents NewSparePartStockInBindingSource As BindingSource
    Friend WithEvents Stock_InTableAdapter As Db_sparesDataSetTableAdapters.Stock_InTableAdapter
    Friend WithEvents NewSparePartBindingSource2 As BindingSource
    Friend WithEvents btnadding As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents btnprevious As Button
    Friend WithEvents txtcategory As TextBox
    Friend WithEvents txtboxdesc As TextBox
    Friend WithEvents Label2 As Label
End Class
