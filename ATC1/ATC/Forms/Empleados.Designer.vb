<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleados
    Inherits HtmlForm

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim RealNameLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empleados))
        Me.users = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdentificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ATCDataSet = New StyleSalon.ATCDataSet()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.RealNameTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.usersAddBtn = New System.Windows.Forms.Button()
        Me.usersEditBtn = New System.Windows.Forms.Button()
        Me.usersDeleteBtn = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.searchPanel = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.usersBackBtn = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.EmpleadosTableAdapter = New StyleSalon.ATCDataSetTableAdapters.EmpleadosTableAdapter()
        Me.TableAdapterManager = New StyleSalon.ATCDataSetTableAdapters.TableAdapterManager()
        IdLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        RealNameLabel = New System.Windows.Forms.Label()
        Me.users.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ATCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.searchPanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usersBackBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(188, 16)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(39, 29)
        IdLabel.TabIndex = 0
        IdLabel.Text = "Id:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(188, 57)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(160, 29)
        NameLabel.TabIndex = 2
        NameLabel.Text = "Identificación:"
        '
        'RealNameLabel
        '
        RealNameLabel.AutoSize = True
        RealNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RealNameLabel.Location = New System.Drawing.Point(188, 98)
        RealNameLabel.Name = "RealNameLabel"
        RealNameLabel.Size = New System.Drawing.Size(107, 29)
        RealNameLabel.TabIndex = 8
        RealNameLabel.Text = "Nombre:"
        '
        'users
        '
        Me.users.AutoScroll = True
        Me.users.Controls.Add(Me.SplitContainer1)
        Me.users.Controls.Add(Me.Panel3)
        Me.users.Dock = System.Windows.Forms.DockStyle.Fill
        Me.users.Location = New System.Drawing.Point(0, 100)
        Me.users.Name = "users"
        Me.users.Size = New System.Drawing.Size(798, 372)
        Me.users.TabIndex = 19
        Me.users.Tag = "move,0"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ClientesDataGridView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel4)
        Me.SplitContainer1.Size = New System.Drawing.Size(798, 267)
        Me.SplitContainer1.SplitterDistance = 270
        Me.SplitContainer1.TabIndex = 22
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.AllowUserToAddRows = False
        Me.ClientesDataGridView.AllowUserToDeleteRows = False
        Me.ClientesDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientesDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ClientesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClientesDataGridView.AutoGenerateColumns = False
        Me.ClientesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ClientesDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ClientesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ClientesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ClientesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdentificacionDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn})
        Me.ClientesDataGridView.DataSource = Me.EmpleadosBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ClientesDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.ClientesDataGridView.GridColor = System.Drawing.Color.WhiteSmoke
        Me.ClientesDataGridView.Location = New System.Drawing.Point(13, 15)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.ReadOnly = True
        Me.ClientesDataGridView.RowHeadersVisible = False
        Me.ClientesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ClientesDataGridView.Size = New System.Drawing.Size(245, 236)
        Me.ClientesDataGridView.TabIndex = 21
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdentificacionDataGridViewTextBoxColumn
        '
        Me.IdentificacionDataGridViewTextBoxColumn.DataPropertyName = "Identificacion"
        Me.IdentificacionDataGridViewTextBoxColumn.HeaderText = "Identificacion"
        Me.IdentificacionDataGridViewTextBoxColumn.Name = "IdentificacionDataGridViewTextBoxColumn"
        Me.IdentificacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.ATCDataSet
        '
        'ATCDataSet
        '
        Me.ATCDataSet.DataSetName = "ATCDataSet"
        Me.ATCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.IdTextBox)
        Me.Panel4.Controls.Add(IdLabel)
        Me.Panel4.Controls.Add(NameLabel)
        Me.Panel4.Controls.Add(Me.RealNameTextBox)
        Me.Panel4.Controls.Add(Me.NameTextBox)
        Me.Panel4.Controls.Add(RealNameLabel)
        Me.Panel4.Location = New System.Drawing.Point(42, 45)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(451, 176)
        Me.Panel4.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.EmpleadosBindingSource, "Foto", True))
        Me.PictureBox1.ErrorImage = Global.StyleSalon.My.Resources.Resources.user2
        Me.PictureBox1.InitialImage = Global.StyleSalon.My.Resources.Resources.user2
        Me.PictureBox1.Location = New System.Drawing.Point(26, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 156)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'IdTextBox
        '
        Me.IdTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Id", True))
        Me.IdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(354, 13)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(83, 35)
        Me.IdTextBox.TabIndex = 1
        '
        'RealNameTextBox
        '
        Me.RealNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RealNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Nombre", True))
        Me.RealNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RealNameTextBox.Location = New System.Drawing.Point(354, 95)
        Me.RealNameTextBox.Name = "RealNameTextBox"
        Me.RealNameTextBox.Size = New System.Drawing.Size(83, 35)
        Me.RealNameTextBox.TabIndex = 9
        '
        'NameTextBox
        '
        Me.NameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Identificacion", True))
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(354, 54)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(83, 35)
        Me.NameTextBox.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.btnguardar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 267)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5, 5, 7, 5)
        Me.Panel3.Size = New System.Drawing.Size(798, 105)
        Me.Panel3.TabIndex = 21
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel5.Controls.Add(Me.usersAddBtn)
        Me.Panel5.Controls.Add(Me.usersEditBtn)
        Me.Panel5.Controls.Add(Me.usersDeleteBtn)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(5, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(707, 95)
        Me.Panel5.TabIndex = 22
        '
        'usersAddBtn
        '
        Me.usersAddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.usersAddBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.usersAddBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.usersAddBtn.FlatAppearance.BorderSize = 0
        Me.usersAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.usersAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.usersAddBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.usersAddBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.usersAddBtn.Image = Global.StyleSalon.My.Resources.Resources.add
        Me.usersAddBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.usersAddBtn.Location = New System.Drawing.Point(470, 0)
        Me.usersAddBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.usersAddBtn.Name = "usersAddBtn"
        Me.usersAddBtn.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.usersAddBtn.Size = New System.Drawing.Size(79, 95)
        Me.usersAddBtn.TabIndex = 23
        Me.usersAddBtn.Tag = "5"
        Me.usersAddBtn.Text = "Agregar"
        Me.usersAddBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.usersAddBtn.UseVisualStyleBackColor = False
        Me.usersAddBtn.Visible = False
        '
        'usersEditBtn
        '
        Me.usersEditBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.usersEditBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.usersEditBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.usersEditBtn.FlatAppearance.BorderSize = 0
        Me.usersEditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.usersEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.usersEditBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.usersEditBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.usersEditBtn.Image = Global.StyleSalon.My.Resources.Resources.edit
        Me.usersEditBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.usersEditBtn.Location = New System.Drawing.Point(549, 0)
        Me.usersEditBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.usersEditBtn.Name = "usersEditBtn"
        Me.usersEditBtn.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.usersEditBtn.Size = New System.Drawing.Size(79, 95)
        Me.usersEditBtn.TabIndex = 22
        Me.usersEditBtn.Tag = "5"
        Me.usersEditBtn.Text = "Editar"
        Me.usersEditBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.usersEditBtn.UseVisualStyleBackColor = False
        Me.usersEditBtn.Visible = False
        '
        'usersDeleteBtn
        '
        Me.usersDeleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.usersDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.usersDeleteBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.usersDeleteBtn.FlatAppearance.BorderSize = 0
        Me.usersDeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.usersDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.usersDeleteBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.usersDeleteBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.usersDeleteBtn.Image = Global.StyleSalon.My.Resources.Resources.delete
        Me.usersDeleteBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.usersDeleteBtn.Location = New System.Drawing.Point(628, 0)
        Me.usersDeleteBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.usersDeleteBtn.Name = "usersDeleteBtn"
        Me.usersDeleteBtn.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.usersDeleteBtn.Size = New System.Drawing.Size(79, 95)
        Me.usersDeleteBtn.TabIndex = 21
        Me.usersDeleteBtn.Tag = "5"
        Me.usersDeleteBtn.Text = "Quitar"
        Me.usersDeleteBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.usersDeleteBtn.UseVisualStyleBackColor = False
        Me.usersDeleteBtn.Visible = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnguardar.FlatAppearance.BorderSize = 0
        Me.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnguardar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnguardar.Image = Global.StyleSalon.My.Resources.Resources.save
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnguardar.Location = New System.Drawing.Point(712, 5)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.btnguardar.Size = New System.Drawing.Size(79, 95)
        Me.btnguardar.TabIndex = 21
        Me.btnguardar.Tag = "5"
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnguardar.UseVisualStyleBackColor = False
        Me.btnguardar.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.searchPanel)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.usersBackBtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(20, 30, 0, 0)
        Me.Panel2.Size = New System.Drawing.Size(798, 100)
        Me.Panel2.TabIndex = 20
        '
        'searchPanel
        '
        Me.searchPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchPanel.Controls.Add(Me.TextBox1)
        Me.searchPanel.Controls.Add(Me.PictureBox2)
        Me.searchPanel.Location = New System.Drawing.Point(509, 33)
        Me.searchPanel.Name = "searchPanel"
        Me.searchPanel.Size = New System.Drawing.Size(282, 61)
        Me.searchPanel.TabIndex = 17
        Me.searchPanel.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(28, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(239, 35)
        Me.TextBox1.TabIndex = 15
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.StyleSalon.My.Resources.Resources.search1
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 61)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(68, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 50)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Empleados"
        '
        'usersBackBtn
        '
        Me.usersBackBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.usersBackBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.usersBackBtn.Image = Global.StyleSalon.My.Resources.Resources.back
        Me.usersBackBtn.Location = New System.Drawing.Point(20, 30)
        Me.usersBackBtn.Name = "usersBackBtn"
        Me.usersBackBtn.Size = New System.Drawing.Size(48, 70)
        Me.usersBackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.usersBackBtn.TabIndex = 0
        Me.usersBackBtn.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.users)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(1, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(798, 472)
        Me.Panel1.TabIndex = 21
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AgendaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Me.EmpleadosTableAdapter
        Me.TableAdapterManager.ServiciosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = StyleSalon.ATCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.ClientSize = New System.Drawing.Size(800, 503)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(800, 503)
        Me.Name = "Empleados"
        Me.Padding = New System.Windows.Forms.Padding(1, 30, 1, 1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salon Style - Configuración de Conexión"
        Me.users.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ATCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.searchPanel.ResumeLayout(False)
        Me.searchPanel.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usersBackBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents users As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents usersBackBtn As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ClientesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RealNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents usersAddBtn As System.Windows.Forms.Button
    Friend WithEvents usersEditBtn As System.Windows.Forms.Button
    Friend WithEvents usersDeleteBtn As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents searchPanel As System.Windows.Forms.Panel
    Friend WithEvents ATCDataSet As StyleSalon.ATCDataSet
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As StyleSalon.ATCDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents TableAdapterManager As StyleSalon.ATCDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdentificacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
