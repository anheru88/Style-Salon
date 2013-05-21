<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim CedulaLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.users = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ATCDataSet = New StyleSalon.ATCDataSet()
        Me.MesCumpleañosNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.DiaCumpleañosNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.CedulaTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
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
        Me.TableAdapterManager = New StyleSalon.ATCDataSetTableAdapters.TableAdapterManager()
        Me.ClientesTableAdapter = New StyleSalon.ATCDataSetTableAdapters.ClientesTableAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        IdLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CedulaLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.users.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ATCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesCumpleañosNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaCumpleañosNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
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
        IdLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(79, 92)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(39, 29)
        IdLabel.TabIndex = 0
        IdLabel.Text = "Id:"
        IdLabel.UseWaitCursor = True
        '
        'NombreLabel
        '
        NombreLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(79, 133)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(107, 29)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        NombreLabel.UseWaitCursor = True
        '
        'CedulaLabel
        '
        CedulaLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CedulaLabel.AutoSize = True
        CedulaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CedulaLabel.Location = New System.Drawing.Point(79, 174)
        CedulaLabel.Name = "CedulaLabel"
        CedulaLabel.Size = New System.Drawing.Size(96, 29)
        CedulaLabel.TabIndex = 4
        CedulaLabel.Text = "Cedula:"
        CedulaLabel.UseWaitCursor = True
        '
        'EmailLabel
        '
        EmailLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(79, 215)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(80, 29)
        EmailLabel.TabIndex = 6
        EmailLabel.Text = "Email:"
        EmailLabel.UseWaitCursor = True
        '
        'TelefonoLabel
        '
        TelefonoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.Location = New System.Drawing.Point(79, 256)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(116, 29)
        TelefonoLabel.TabIndex = 8
        TelefonoLabel.Text = "Telefono:"
        TelefonoLabel.UseWaitCursor = True
        '
        'CelularLabel
        '
        CelularLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CelularLabel.AutoSize = True
        CelularLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CelularLabel.Location = New System.Drawing.Point(79, 297)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(96, 29)
        CelularLabel.TabIndex = 10
        CelularLabel.Text = "Celular:"
        CelularLabel.UseWaitCursor = True
        '
        'DireccionLabel
        '
        DireccionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DireccionLabel.AutoSize = True
        DireccionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionLabel.Location = New System.Drawing.Point(79, 338)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(121, 29)
        DireccionLabel.TabIndex = 12
        DireccionLabel.Text = "Direccion:"
        DireccionLabel.UseWaitCursor = True
        '
        'Label3
        '
        Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(79, 423)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(202, 29)
        Label3.TabIndex = 21
        Label3.Text = "Mes cumpleaños:"
        Label3.UseWaitCursor = True
        '
        'Label1
        '
        Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(79, 378)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(192, 29)
        Label1.TabIndex = 20
        Label1.Text = "Día cumpleaños:"
        Label1.UseWaitCursor = True
        '
        'users
        '
        Me.users.AutoScroll = True
        Me.users.Controls.Add(Me.SplitContainer1)
        Me.users.Controls.Add(Me.Panel3)
        Me.users.Dock = System.Windows.Forms.DockStyle.Fill
        Me.users.Location = New System.Drawing.Point(0, 100)
        Me.users.Name = "users"
        Me.users.Size = New System.Drawing.Size(1035, 657)
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
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.MesCumpleañosNumericUpDown)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DiaCumpleañosNumericUpDown)
        Me.SplitContainer1.Panel2.Controls.Add(IdLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.IdTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(NombreLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DireccionTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.NombreTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(DireccionLabel)
        Me.SplitContainer1.Panel2.Controls.Add(CedulaLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CelularTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CedulaTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(CelularLabel)
        Me.SplitContainer1.Panel2.Controls.Add(EmailLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TelefonoTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EmailTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(TelefonoLabel)
        Me.SplitContainer1.Panel2.UseWaitCursor = True
        Me.SplitContainer1.Size = New System.Drawing.Size(1035, 552)
        Me.SplitContainer1.SplitterDistance = 392
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ClientesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.CelularDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn})
        Me.ClientesDataGridView.DataSource = Me.ClientesBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(239, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ClientesDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.ClientesDataGridView.GridColor = System.Drawing.Color.WhiteSmoke
        Me.ClientesDataGridView.Location = New System.Drawing.Point(20, 15)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ClientesDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.ClientesDataGridView.RowHeadersVisible = False
        Me.ClientesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ClientesDataGridView.Size = New System.Drawing.Size(352, 521)
        Me.ClientesDataGridView.TabIndex = 21
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
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "Cedula"
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        Me.CedulaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CelularDataGridViewTextBoxColumn
        '
        Me.CelularDataGridViewTextBoxColumn.DataPropertyName = "Celular"
        Me.CelularDataGridViewTextBoxColumn.HeaderText = "Celular"
        Me.CelularDataGridViewTextBoxColumn.Name = "CelularDataGridViewTextBoxColumn"
        Me.CelularDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.ATCDataSet
        '
        'ATCDataSet
        '
        Me.ATCDataSet.DataSetName = "ATCDataSet"
        Me.ATCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MesCumpleañosNumericUpDown
        '
        Me.MesCumpleañosNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MesCumpleañosNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClientesBindingSource, "MesCumpleaños", True))
        Me.MesCumpleañosNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MesCumpleañosNumericUpDown.Location = New System.Drawing.Point(287, 417)
        Me.MesCumpleañosNumericUpDown.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.MesCumpleañosNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MesCumpleañosNumericUpDown.Name = "MesCumpleañosNumericUpDown"
        Me.MesCumpleañosNumericUpDown.Size = New System.Drawing.Size(224, 35)
        Me.MesCumpleañosNumericUpDown.TabIndex = 19
        Me.MesCumpleañosNumericUpDown.UseWaitCursor = True
        Me.MesCumpleañosNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DiaCumpleañosNumericUpDown
        '
        Me.DiaCumpleañosNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DiaCumpleañosNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClientesBindingSource, "DiaCumpleaños", True))
        Me.DiaCumpleañosNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiaCumpleañosNumericUpDown.Location = New System.Drawing.Point(287, 376)
        Me.DiaCumpleañosNumericUpDown.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.DiaCumpleañosNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DiaCumpleañosNumericUpDown.Name = "DiaCumpleañosNumericUpDown"
        Me.DiaCumpleañosNumericUpDown.Size = New System.Drawing.Size(224, 35)
        Me.DiaCumpleañosNumericUpDown.TabIndex = 18
        Me.DiaCumpleañosNumericUpDown.UseWaitCursor = True
        Me.DiaCumpleañosNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'IdTextBox
        '
        Me.IdTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Id", True))
        Me.IdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(287, 89)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(66, 35)
        Me.IdTextBox.TabIndex = 1
        Me.IdTextBox.UseWaitCursor = True
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Direccion", True))
        Me.DireccionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionTextBox.Location = New System.Drawing.Point(287, 335)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(310, 35)
        Me.DireccionTextBox.TabIndex = 13
        Me.DireccionTextBox.UseWaitCursor = True
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(287, 130)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(310, 35)
        Me.NombreTextBox.TabIndex = 3
        Me.NombreTextBox.UseWaitCursor = True
        '
        'CelularTextBox
        '
        Me.CelularTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Celular", True))
        Me.CelularTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CelularTextBox.Location = New System.Drawing.Point(287, 294)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(310, 35)
        Me.CelularTextBox.TabIndex = 11
        Me.CelularTextBox.UseWaitCursor = True
        '
        'CedulaTextBox
        '
        Me.CedulaTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CedulaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Cedula", True))
        Me.CedulaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CedulaTextBox.Location = New System.Drawing.Point(287, 171)
        Me.CedulaTextBox.Name = "CedulaTextBox"
        Me.CedulaTextBox.Size = New System.Drawing.Size(310, 35)
        Me.CedulaTextBox.TabIndex = 5
        Me.CedulaTextBox.UseWaitCursor = True
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(287, 253)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(310, 35)
        Me.TelefonoTextBox.TabIndex = 9
        Me.TelefonoTextBox.UseWaitCursor = True
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(287, 212)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(310, 35)
        Me.EmailTextBox.TabIndex = 7
        Me.EmailTextBox.UseWaitCursor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Panel3.Controls.Add(Me.usersAddBtn)
        Me.Panel3.Controls.Add(Me.usersEditBtn)
        Me.Panel3.Controls.Add(Me.usersDeleteBtn)
        Me.Panel3.Controls.Add(Me.btnguardar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 552)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5, 5, 7, 5)
        Me.Panel3.Size = New System.Drawing.Size(1035, 105)
        Me.Panel3.TabIndex = 21
        '
        'usersAddBtn
        '
        Me.usersAddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.usersAddBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.usersAddBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.usersAddBtn.FlatAppearance.BorderSize = 0
        Me.usersAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.usersAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.usersAddBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.usersAddBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.usersAddBtn.Image = Global.StyleSalon.My.Resources.Resources.add
        Me.usersAddBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.usersAddBtn.Location = New System.Drawing.Point(712, 5)
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
        Me.usersEditBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.usersEditBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.usersEditBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.usersEditBtn.FlatAppearance.BorderSize = 0
        Me.usersEditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.usersEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.usersEditBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.usersEditBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.usersEditBtn.Image = Global.StyleSalon.My.Resources.Resources.edit
        Me.usersEditBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.usersEditBtn.Location = New System.Drawing.Point(791, 5)
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
        Me.usersDeleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.usersDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.usersDeleteBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.usersDeleteBtn.FlatAppearance.BorderSize = 0
        Me.usersDeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.usersDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.usersDeleteBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.usersDeleteBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.usersDeleteBtn.Image = Global.StyleSalon.My.Resources.Resources.delete
        Me.usersDeleteBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.usersDeleteBtn.Location = New System.Drawing.Point(870, 5)
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
        Me.btnguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnguardar.FlatAppearance.BorderSize = 0
        Me.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnguardar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnguardar.Image = Global.StyleSalon.My.Resources.Resources.save
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnguardar.Location = New System.Drawing.Point(949, 5)
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
        Me.Panel2.Size = New System.Drawing.Size(1035, 100)
        Me.Panel2.TabIndex = 20
        '
        'searchPanel
        '
        Me.searchPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchPanel.Controls.Add(Me.TextBox1)
        Me.searchPanel.Controls.Add(Me.PictureBox2)
        Me.searchPanel.Location = New System.Drawing.Point(662, 30)
        Me.searchPanel.Name = "searchPanel"
        Me.searchPanel.Size = New System.Drawing.Size(366, 64)
        Me.searchPanel.TabIndex = 17
        Me.searchPanel.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(28, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(335, 35)
        Me.TextBox1.TabIndex = 15
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.StyleSalon.My.Resources.Resources.search1
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 64)
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
        Me.Label2.Size = New System.Drawing.Size(151, 50)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Clientes"
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
        Me.Panel1.Size = New System.Drawing.Size(1035, 757)
        Me.Panel1.TabIndex = 21
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AgendaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.ServiciosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = StyleSalon.ATCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.ClientSize = New System.Drawing.Size(1037, 788)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Clientes"
        Me.Padding = New System.Windows.Forms.Padding(1, 30, 1, 1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anfitrión - Configuración de Conexión"
        Me.users.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ATCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesCumpleañosNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaCumpleañosNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ClientesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ATCDataSet As StyleSalon.ATCDataSet
    Friend WithEvents TableAdapterManager As StyleSalon.ATCDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents usersAddBtn As System.Windows.Forms.Button
    Friend WithEvents usersEditBtn As System.Windows.Forms.Button
    Friend WithEvents usersDeleteBtn As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents searchPanel As System.Windows.Forms.Panel
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As StyleSalon.ATCDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CelularTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CedulaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CelularDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MesCumpleañosNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents DiaCumpleañosNumericUpDown As System.Windows.Forms.NumericUpDown

End Class
