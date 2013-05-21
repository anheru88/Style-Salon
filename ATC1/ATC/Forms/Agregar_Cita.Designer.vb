<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Cita
    Inherits System.Windows.Forms.HtmlForm

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
        Dim FechaLabel1 As System.Windows.Forms.Label
        Dim IdLabel1 As System.Windows.Forms.Label
        Dim ClienteLabel1 As System.Windows.Forms.Label
        Dim UsuarioLabel1 As System.Windows.Forms.Label
        Dim ServicioLabel1 As System.Windows.Forms.Label
        Dim TiempoLabel1 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar_Cita))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.Back_Boton = New System.Windows.Forms.PictureBox()
        Me.Label_Agenda = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label_Mensaje = New System.Windows.Forms.Label()
        Me.HoraDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdTextBox1 = New System.Windows.Forms.TextBox()
        Me.TiempoNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ServicioComboBox = New System.Windows.Forms.ComboBox()
        Me.AgendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ATCDataSet = New StyleSalon.ATCDataSet()
        Me.ServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosComboBox = New System.Windows.Forms.ComboBox()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteComboBox = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FechaDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ClientesTableAdapter = New StyleSalon.ATCDataSetTableAdapters.ClientesTableAdapter()
        Me.AgendaTableAdapter = New StyleSalon.ATCDataSetTableAdapters.AgendaTableAdapter()
        Me.EmpleadosTableAdapter = New StyleSalon.ATCDataSetTableAdapters.EmpleadosTableAdapter()
        Me.ServiciosTableAdapter = New StyleSalon.ATCDataSetTableAdapters.ServiciosTableAdapter()
        Me.TableAdapterManager = New StyleSalon.ATCDataSetTableAdapters.TableAdapterManager()
        FechaLabel1 = New System.Windows.Forms.Label()
        IdLabel1 = New System.Windows.Forms.Label()
        ClienteLabel1 = New System.Windows.Forms.Label()
        UsuarioLabel1 = New System.Windows.Forms.Label()
        ServicioLabel1 = New System.Windows.Forms.Label()
        TiempoLabel1 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.Back_Boton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.TiempoNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ATCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FechaLabel1
        '
        FechaLabel1.AutoSize = True
        FechaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel1.Location = New System.Drawing.Point(25, 103)
        FechaLabel1.Name = "FechaLabel1"
        FechaLabel1.Size = New System.Drawing.Size(86, 29)
        FechaLabel1.TabIndex = 15
        FechaLabel1.Text = "Fecha:"
        '
        'IdLabel1
        '
        IdLabel1.AutoSize = True
        IdLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel1.Location = New System.Drawing.Point(25, 61)
        IdLabel1.Name = "IdLabel1"
        IdLabel1.Size = New System.Drawing.Size(39, 29)
        IdLabel1.TabIndex = 13
        IdLabel1.Text = "Id:"
        IdLabel1.Visible = False
        '
        'ClienteLabel1
        '
        ClienteLabel1.AutoSize = True
        ClienteLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClienteLabel1.Location = New System.Drawing.Point(25, 184)
        ClienteLabel1.Name = "ClienteLabel1"
        ClienteLabel1.Size = New System.Drawing.Size(95, 29)
        ClienteLabel1.TabIndex = 17
        ClienteLabel1.Text = "Cliente:"
        '
        'UsuarioLabel1
        '
        UsuarioLabel1.AutoSize = True
        UsuarioLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsuarioLabel1.Location = New System.Drawing.Point(25, 226)
        UsuarioLabel1.Name = "UsuarioLabel1"
        UsuarioLabel1.Size = New System.Drawing.Size(130, 29)
        UsuarioLabel1.TabIndex = 19
        UsuarioLabel1.Text = "Empleado:"
        '
        'ServicioLabel1
        '
        ServicioLabel1.AutoSize = True
        ServicioLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ServicioLabel1.Location = New System.Drawing.Point(25, 267)
        ServicioLabel1.Name = "ServicioLabel1"
        ServicioLabel1.Size = New System.Drawing.Size(106, 29)
        ServicioLabel1.TabIndex = 21
        ServicioLabel1.Text = "Servicio:"
        '
        'TiempoLabel1
        '
        TiempoLabel1.AutoSize = True
        TiempoLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TiempoLabel1.Location = New System.Drawing.Point(25, 308)
        TiempoLabel1.Name = "TiempoLabel1"
        TiempoLabel1.Size = New System.Drawing.Size(103, 29)
        TiempoLabel1.TabIndex = 23
        TiempoLabel1.Text = "Tiempo:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.Location = New System.Drawing.Point(241, 311)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(97, 29)
        Label12.TabIndex = 28
        Label12.Text = "Minutos"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.Location = New System.Drawing.Point(25, 144)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(65, 29)
        Label13.TabIndex = 30
        Label13.Text = "Hora"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.btnguardar)
        Me.Panel3.Location = New System.Drawing.Point(11, 587)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(932, 108)
        Me.Panel3.TabIndex = 32
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.Image = Global.StyleSalon.My.Resources.Resources.search
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(158, 0)
        Me.Button3.Margin = New System.Windows.Forms.Padding(5)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Button3.Size = New System.Drawing.Size(79, 108)
        Me.Button3.TabIndex = 33
        Me.Button3.Tag = "5"
        Me.Button3.Text = "Consulta"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(79, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Button2.Size = New System.Drawing.Size(79, 108)
        Me.Button2.TabIndex = 32
        Me.Button2.Tag = "5"
        Me.Button2.Text = "Nuevo Servicio"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Button1.Size = New System.Drawing.Size(79, 108)
        Me.Button1.TabIndex = 31
        Me.Button1.Tag = "5"
        Me.Button1.Text = "Nuevo Cliente"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnguardar.FlatAppearance.BorderSize = 0
        Me.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnguardar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnguardar.Image = Global.StyleSalon.My.Resources.Resources.save
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnguardar.Location = New System.Drawing.Point(853, 0)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.btnguardar.Size = New System.Drawing.Size(79, 108)
        Me.btnguardar.TabIndex = 28
        Me.btnguardar.Tag = "5"
        Me.btnguardar.Text = "Guardar Evento"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'Back_Boton
        '
        Me.Back_Boton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Back_Boton.Image = Global.StyleSalon.My.Resources.Resources.back
        Me.Back_Boton.Location = New System.Drawing.Point(11, 10)
        Me.Back_Boton.Name = "Back_Boton"
        Me.Back_Boton.Size = New System.Drawing.Size(48, 48)
        Me.Back_Boton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Back_Boton.TabIndex = 33
        Me.Back_Boton.TabStop = False
        '
        'Label_Agenda
        '
        Me.Label_Agenda.AutoSize = True
        Me.Label_Agenda.Font = New System.Drawing.Font("Segoe UI", 27.8!)
        Me.Label_Agenda.Location = New System.Drawing.Point(77, 10)
        Me.Label_Agenda.Name = "Label_Agenda"
        Me.Label_Agenda.Size = New System.Drawing.Size(152, 51)
        Me.Label_Agenda.TabIndex = 34
        Me.Label_Agenda.Text = "Agenda"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.Label_Mensaje)
        Me.Panel2.Controls.Add(Me.HoraDateTimePicker)
        Me.Panel2.Controls.Add(Label13)
        Me.Panel2.Controls.Add(Me.IdTextBox1)
        Me.Panel2.Controls.Add(Label12)
        Me.Panel2.Controls.Add(TiempoLabel1)
        Me.Panel2.Controls.Add(Me.TiempoNumericUpDown)
        Me.Panel2.Controls.Add(ServicioLabel1)
        Me.Panel2.Controls.Add(Me.ServicioComboBox)
        Me.Panel2.Controls.Add(UsuarioLabel1)
        Me.Panel2.Controls.Add(Me.EmpleadosComboBox)
        Me.Panel2.Controls.Add(ClienteLabel1)
        Me.Panel2.Controls.Add(Me.ClienteComboBox)
        Me.Panel2.Controls.Add(Me.FechaDateTimePicker1)
        Me.Panel2.Controls.Add(IdLabel1)
        Me.Panel2.Controls.Add(FechaLabel1)
        Me.Panel2.Location = New System.Drawing.Point(86, 125)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(857, 457)
        Me.Panel2.TabIndex = 35
        '
        'Label_Mensaje
        '
        Me.Label_Mensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Mensaje.AutoSize = True
        Me.Label_Mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Mensaje.ForeColor = System.Drawing.Color.Red
        Me.Label_Mensaje.Location = New System.Drawing.Point(25, 17)
        Me.Label_Mensaje.Name = "Label_Mensaje"
        Me.Label_Mensaje.Size = New System.Drawing.Size(77, 25)
        Me.Label_Mensaje.TabIndex = 32
        Me.Label_Mensaje.Text = "Label1"
        '
        'HoraDateTimePicker
        '
        Me.HoraDateTimePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HoraDateTimePicker.CustomFormat = "H:mm"
        Me.HoraDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoraDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.HoraDateTimePicker.Location = New System.Drawing.Point(161, 139)
        Me.HoraDateTimePicker.Name = "HoraDateTimePicker"
        Me.HoraDateTimePicker.ShowUpDown = True
        Me.HoraDateTimePicker.Size = New System.Drawing.Size(618, 35)
        Me.HoraDateTimePicker.TabIndex = 31
        '
        'IdTextBox1
        '
        Me.IdTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox1.Location = New System.Drawing.Point(161, 57)
        Me.IdTextBox1.Name = "IdTextBox1"
        Me.IdTextBox1.Size = New System.Drawing.Size(74, 35)
        Me.IdTextBox1.TabIndex = 14
        Me.IdTextBox1.Visible = False
        '
        'TiempoNumericUpDown
        '
        Me.TiempoNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TiempoNumericUpDown.Location = New System.Drawing.Point(161, 309)
        Me.TiempoNumericUpDown.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.TiempoNumericUpDown.Minimum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.TiempoNumericUpDown.Name = "TiempoNumericUpDown"
        Me.TiempoNumericUpDown.Size = New System.Drawing.Size(74, 35)
        Me.TiempoNumericUpDown.TabIndex = 27
        Me.TiempoNumericUpDown.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'ServicioComboBox
        '
        Me.ServicioComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServicioComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ServicioComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ServicioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AgendaBindingSource, "Servicio", True))
        Me.ServicioComboBox.DataSource = Me.ServiciosBindingSource
        Me.ServicioComboBox.DisplayMember = "Nombre"
        Me.ServicioComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServicioComboBox.FormattingEnabled = True
        Me.ServicioComboBox.Location = New System.Drawing.Point(162, 266)
        Me.ServicioComboBox.Name = "ServicioComboBox"
        Me.ServicioComboBox.Size = New System.Drawing.Size(618, 37)
        Me.ServicioComboBox.TabIndex = 26
        Me.ServicioComboBox.ValueMember = "Id"
        '
        'AgendaBindingSource
        '
        Me.AgendaBindingSource.DataMember = "Agenda"
        Me.AgendaBindingSource.DataSource = Me.ATCDataSet
        '
        'ATCDataSet
        '
        Me.ATCDataSet.DataSetName = "ATCDataSet"
        Me.ATCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ServiciosBindingSource
        '
        Me.ServiciosBindingSource.DataMember = "Servicios"
        Me.ServiciosBindingSource.DataSource = Me.ATCDataSet
        '
        'EmpleadosComboBox
        '
        Me.EmpleadosComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmpleadosComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.EmpleadosComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EmpleadosComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AgendaBindingSource, "Empleado", True))
        Me.EmpleadosComboBox.DataSource = Me.EmpleadosBindingSource
        Me.EmpleadosComboBox.DisplayMember = "Nombre"
        Me.EmpleadosComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpleadosComboBox.FormattingEnabled = True
        Me.EmpleadosComboBox.Location = New System.Drawing.Point(161, 223)
        Me.EmpleadosComboBox.Name = "EmpleadosComboBox"
        Me.EmpleadosComboBox.Size = New System.Drawing.Size(618, 37)
        Me.EmpleadosComboBox.TabIndex = 25
        Me.EmpleadosComboBox.ValueMember = "Id"
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.ATCDataSet
        '
        'ClienteComboBox
        '
        Me.ClienteComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClienteComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ClienteComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ClienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AgendaBindingSource, "Cliente", True))
        Me.ClienteComboBox.DataSource = Me.ClientesBindingSource
        Me.ClienteComboBox.DisplayMember = "Nombre"
        Me.ClienteComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteComboBox.FormattingEnabled = True
        Me.ClienteComboBox.Location = New System.Drawing.Point(161, 180)
        Me.ClienteComboBox.Name = "ClienteComboBox"
        Me.ClienteComboBox.Size = New System.Drawing.Size(618, 37)
        Me.ClienteComboBox.TabIndex = 24
        Me.ClienteComboBox.ValueMember = "Id"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.ATCDataSet
        '
        'FechaDateTimePicker1
        '
        Me.FechaDateTimePicker1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaDateTimePicker1.CustomFormat = ""
        Me.FechaDateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker1.Location = New System.Drawing.Point(161, 98)
        Me.FechaDateTimePicker1.Name = "FechaDateTimePicker1"
        Me.FechaDateTimePicker1.Size = New System.Drawing.Size(618, 35)
        Me.FechaDateTimePicker1.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label_Agenda)
        Me.Panel1.Controls.Add(Me.Back_Boton)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(960, 786)
        Me.Panel1.TabIndex = 0
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'AgendaTableAdapter
        '
        Me.AgendaTableAdapter.ClearBeforeFill = True
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'ServiciosTableAdapter
        '
        Me.ServiciosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AgendaTableAdapter = Me.AgendaTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.EmpleadosTableAdapter = Me.EmpleadosTableAdapter
        Me.TableAdapterManager.ServiciosTableAdapter = Me.ServiciosTableAdapter
        Me.TableAdapterManager.UpdateOrder = StyleSalon.ATCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'Agregar_Cita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.ClientSize = New System.Drawing.Size(962, 788)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Agregar_Cita"
        Me.Panel3.ResumeLayout(False)
        CType(Me.Back_Boton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TiempoNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ATCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents Back_Boton As System.Windows.Forms.PictureBox
    Friend WithEvents Label_Agenda As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label_Mensaje As System.Windows.Forms.Label
    Friend WithEvents HoraDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents IdTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TiempoNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ServicioComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EmpleadosComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ClienteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FechaDateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ATCDataSet As StyleSalon.ATCDataSet
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As StyleSalon.ATCDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents AgendaTableAdapter As StyleSalon.ATCDataSetTableAdapters.AgendaTableAdapter
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As StyleSalon.ATCDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents ServiciosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ServiciosTableAdapter As StyleSalon.ATCDataSetTableAdapters.ServiciosTableAdapter
    Friend WithEvents AgendaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As StyleSalon.ATCDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
