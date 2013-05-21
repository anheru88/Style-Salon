<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Servicios
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Servicios))
        Me.users = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ServiciosDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ATCDataSet = New StyleSalon.ATCDataSet()
        Me.DuracionNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
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
        Me.ServiciosTableAdapter = New StyleSalon.ATCDataSetTableAdapters.ServiciosTableAdapter()
        Me.TableAdapterManager = New StyleSalon.ATCDataSetTableAdapters.TableAdapterManager()
        IdLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.users.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ServiciosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ATCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DuracionNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.searchPanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usersBackBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(109, 39)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(39, 29)
        IdLabel.TabIndex = 0
        IdLabel.Text = "Id:"
        IdLabel.Visible = False
        '
        'NombreLabel
        '
        NombreLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(109, 80)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(107, 29)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(109, 121)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(147, 29)
        DescripcionLabel.TabIndex = 4
        DescripcionLabel.Text = "Descripcion:"
        '
        'ValorLabel
        '
        ValorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        ValorLabel.AutoSize = True
        ValorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ValorLabel.Location = New System.Drawing.Point(109, 162)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(75, 29)
        ValorLabel.TabIndex = 6
        ValorLabel.Text = "Valor:"
        '
        'Label1
        '
        Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(109, 202)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(103, 29)
        Label1.TabIndex = 10
        Label1.Text = "Tiempo:"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.ServiciosDataGridView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DuracionNumericUpDown)
        Me.SplitContainer1.Panel2.Controls.Add(IdLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.IdTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(NombreLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.NombreTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(DescripcionLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DescripcionTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(ValorLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ValorTextBox)
        Me.SplitContainer1.Size = New System.Drawing.Size(798, 267)
        Me.SplitContainer1.SplitterDistance = 337
        Me.SplitContainer1.TabIndex = 22
        '
        'ServiciosDataGridView
        '
        Me.ServiciosDataGridView.AllowUserToAddRows = False
        Me.ServiciosDataGridView.AllowUserToDeleteRows = False
        Me.ServiciosDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ServiciosDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ServiciosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServiciosDataGridView.AutoGenerateColumns = False
        Me.ServiciosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ServiciosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ServiciosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ServiciosDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ServiciosDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ServiciosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ServiciosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ServiciosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.ValorDataGridViewTextBoxColumn})
        Me.ServiciosDataGridView.DataSource = Me.ServiciosBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ServiciosDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.ServiciosDataGridView.GridColor = System.Drawing.Color.WhiteSmoke
        Me.ServiciosDataGridView.Location = New System.Drawing.Point(20, 15)
        Me.ServiciosDataGridView.Name = "ServiciosDataGridView"
        Me.ServiciosDataGridView.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ServiciosDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.ServiciosDataGridView.RowHeadersVisible = False
        Me.ServiciosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ServiciosDataGridView.Size = New System.Drawing.Size(297, 236)
        Me.ServiciosDataGridView.TabIndex = 21
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValorDataGridViewTextBoxColumn
        '
        Me.ValorDataGridViewTextBoxColumn.DataPropertyName = "Valor"
        Me.ValorDataGridViewTextBoxColumn.HeaderText = "Valor"
        Me.ValorDataGridViewTextBoxColumn.Name = "ValorDataGridViewTextBoxColumn"
        Me.ValorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ServiciosBindingSource
        '
        Me.ServiciosBindingSource.DataMember = "Servicios"
        Me.ServiciosBindingSource.DataSource = Me.ATCDataSet
        '
        'ATCDataSet
        '
        Me.ATCDataSet.DataSetName = "ATCDataSet"
        Me.ATCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DuracionNumericUpDown
        '
        Me.DuracionNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DuracionNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ServiciosBindingSource, "Duracion", True))
        Me.DuracionNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DuracionNumericUpDown.Location = New System.Drawing.Point(271, 200)
        Me.DuracionNumericUpDown.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.DuracionNumericUpDown.Name = "DuracionNumericUpDown"
        Me.DuracionNumericUpDown.Size = New System.Drawing.Size(100, 35)
        Me.DuracionNumericUpDown.TabIndex = 9
        '
        'IdTextBox
        '
        Me.IdTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiciosBindingSource, "Id", True))
        Me.IdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(271, 36)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 35)
        Me.IdTextBox.TabIndex = 1
        Me.IdTextBox.Visible = False
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiciosBindingSource, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(271, 77)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 35)
        Me.NombreTextBox.TabIndex = 3
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiciosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(271, 118)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(100, 35)
        Me.DescripcionTextBox.TabIndex = 5
        '
        'ValorTextBox
        '
        Me.ValorTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiciosBindingSource, "Valor", True))
        Me.ValorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorTextBox.Location = New System.Drawing.Point(271, 159)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(100, 35)
        Me.ValorTextBox.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Panel3.Controls.Add(Me.usersAddBtn)
        Me.Panel3.Controls.Add(Me.usersEditBtn)
        Me.Panel3.Controls.Add(Me.usersDeleteBtn)
        Me.Panel3.Controls.Add(Me.btnguardar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 267)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5, 5, 7, 5)
        Me.Panel3.Size = New System.Drawing.Size(798, 105)
        Me.Panel3.TabIndex = 21
        '
        'usersAddBtn
        '
        Me.usersAddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.usersAddBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.usersAddBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.usersAddBtn.FlatAppearance.BorderSize = 0
        Me.usersAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.usersAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.usersAddBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.usersAddBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.usersAddBtn.Image = Global.StyleSalon.My.Resources.Resources.add
        Me.usersAddBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.usersAddBtn.Location = New System.Drawing.Point(475, 5)
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
        Me.usersEditBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.usersEditBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.usersEditBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.usersEditBtn.FlatAppearance.BorderSize = 0
        Me.usersEditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.usersEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.usersEditBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.usersEditBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.usersEditBtn.Image = Global.StyleSalon.My.Resources.Resources.edit
        Me.usersEditBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.usersEditBtn.Location = New System.Drawing.Point(554, 5)
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
        Me.usersDeleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.usersDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.usersDeleteBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.usersDeleteBtn.FlatAppearance.BorderSize = 0
        Me.usersDeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.usersDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.usersDeleteBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.usersDeleteBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.usersDeleteBtn.Image = Global.StyleSalon.My.Resources.Resources.delete
        Me.usersDeleteBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.usersDeleteBtn.Location = New System.Drawing.Point(633, 5)
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
        Me.btnguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnguardar.FlatAppearance.BorderSize = 0
        Me.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(210, Byte), Integer))
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
        Me.searchPanel.Location = New System.Drawing.Point(492, 33)
        Me.searchPanel.Name = "searchPanel"
        Me.searchPanel.Size = New System.Drawing.Size(299, 61)
        Me.searchPanel.TabIndex = 17
        Me.searchPanel.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(28, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(268, 35)
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
        Me.Label2.Size = New System.Drawing.Size(165, 50)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Servicios"
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
        'ServiciosTableAdapter
        '
        Me.ServiciosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AgendaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.ServiciosTableAdapter = Me.ServiciosTableAdapter
        Me.TableAdapterManager.UpdateOrder = StyleSalon.ATCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'Servicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.ClientSize = New System.Drawing.Size(800, 503)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(800, 503)
        Me.Name = "Servicios"
        Me.Padding = New System.Windows.Forms.Padding(1, 30, 1, 1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anfitrión - Configuración de Conexión"
        Me.users.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ServiciosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ATCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DuracionNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
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
    Friend WithEvents ServiciosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents usersAddBtn As System.Windows.Forms.Button
    Friend WithEvents usersEditBtn As System.Windows.Forms.Button
    Friend WithEvents usersDeleteBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents searchPanel As System.Windows.Forms.Panel
    Friend WithEvents ATCDataSet As StyleSalon.ATCDataSet
    Friend WithEvents ServiciosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ServiciosTableAdapter As StyleSalon.ATCDataSetTableAdapters.ServiciosTableAdapter
    Friend WithEvents TableAdapterManager As StyleSalon.ATCDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ValorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DuracionNumericUpDown As System.Windows.Forms.NumericUpDown

End Class
