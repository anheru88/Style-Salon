<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agenda
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
        Dim FechaLabel As System.Windows.Forms.Label
        Dim ClienteLabel As System.Windows.Forms.Label
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim ServicioLabel As System.Windows.Forms.Label
        Dim TiempoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim IdLabel1 As System.Windows.Forms.Label
        Dim FechaLabel1 As System.Windows.Forms.Label
        Dim ClienteLabel1 As System.Windows.Forms.Label
        Dim UsuarioLabel1 As System.Windows.Forms.Label
        Dim ServicioLabel1 As System.Windows.Forms.Label
        Dim TiempoLabel1 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agenda))
        Me.users = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.calendario = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.employeesPanel = New System.Windows.Forms.Panel()
        Me.employeesContainer = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.timeLinePanel = New System.Windows.Forms.Panel()
        Me.timeLineContainer = New System.Windows.Forms.Panel()
        Me.dateLbl = New System.Windows.Forms.Label()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.AgendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ATCDataSet = New StyleSalon.ATCDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.HoraDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdTextBox1 = New System.Windows.Forms.TextBox()
        Me.TiempoNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ServicioComboBox = New System.Windows.Forms.ComboBox()
        Me.ServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioComboBox = New System.Windows.Forms.ComboBox()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteComboBox = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FechaDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.ServicioTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.AgendaScreen = New System.Windows.Forms.Panel()
        Me.meses = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.años = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgendaTableAdapter = New StyleSalon.ATCDataSetTableAdapters.AgendaTableAdapter()
        Me.TableAdapterManager = New StyleSalon.ATCDataSetTableAdapters.TableAdapterManager()
        Me.ClientesTableAdapter = New StyleSalon.ATCDataSetTableAdapters.ClientesTableAdapter()
        Me.EmpleadosTableAdapter = New StyleSalon.ATCDataSetTableAdapters.EmpleadosTableAdapter()
        Me.ServiciosTableAdapter = New StyleSalon.ATCDataSetTableAdapters.ServiciosTableAdapter()
        Me.move = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        IdLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        ClienteLabel = New System.Windows.Forms.Label()
        UsuarioLabel = New System.Windows.Forms.Label()
        ServicioLabel = New System.Windows.Forms.Label()
        TiempoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        IdLabel1 = New System.Windows.Forms.Label()
        FechaLabel1 = New System.Windows.Forms.Label()
        ClienteLabel1 = New System.Windows.Forms.Label()
        UsuarioLabel1 = New System.Windows.Forms.Label()
        ServicioLabel1 = New System.Windows.Forms.Label()
        TiempoLabel1 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Me.users.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.employeesPanel.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.timeLinePanel.SuspendLayout()
        CType(Me.AgendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ATCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TiempoNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.searchPanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usersBackBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AgendaScreen.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(62, 1339)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(20, 15)
        IdLabel.TabIndex = 0
        IdLabel.Text = "Id:"
        '
        'FechaLabel
        '
        FechaLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(62, 1367)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(44, 15)
        FechaLabel.TabIndex = 2
        FechaLabel.Text = "Fecha:"
        '
        'ClienteLabel
        '
        ClienteLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        ClienteLabel.AutoSize = True
        ClienteLabel.Location = New System.Drawing.Point(62, 1393)
        ClienteLabel.Name = "ClienteLabel"
        ClienteLabel.Size = New System.Drawing.Size(48, 15)
        ClienteLabel.TabIndex = 4
        ClienteLabel.Text = "Cliente:"
        '
        'UsuarioLabel
        '
        UsuarioLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Location = New System.Drawing.Point(62, 1420)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(53, 15)
        UsuarioLabel.TabIndex = 6
        UsuarioLabel.Text = "Usuario:"
        '
        'ServicioLabel
        '
        ServicioLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        ServicioLabel.AutoSize = True
        ServicioLabel.Location = New System.Drawing.Point(62, 1447)
        ServicioLabel.Name = "ServicioLabel"
        ServicioLabel.Size = New System.Drawing.Size(53, 15)
        ServicioLabel.TabIndex = 8
        ServicioLabel.Text = "Servicio:"
        '
        'TiempoLabel
        '
        TiempoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        TiempoLabel.AutoSize = True
        TiempoLabel.Location = New System.Drawing.Point(62, 1474)
        TiempoLabel.Name = "TiempoLabel"
        TiempoLabel.Size = New System.Drawing.Size(52, 15)
        TiempoLabel.TabIndex = 10
        TiempoLabel.Text = "Tiempo:"
        '
        'Label1
        '
        Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(177, 1474)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(51, 15)
        Label1.TabIndex = 13
        Label1.Text = "Minutos"
        '
        'IdLabel1
        '
        IdLabel1.AutoSize = True
        IdLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel1.Location = New System.Drawing.Point(25, 40)
        IdLabel1.Name = "IdLabel1"
        IdLabel1.Size = New System.Drawing.Size(39, 29)
        IdLabel1.TabIndex = 13
        IdLabel1.Text = "Id:"
        '
        'FechaLabel1
        '
        FechaLabel1.AutoSize = True
        FechaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel1.Location = New System.Drawing.Point(25, 82)
        FechaLabel1.Name = "FechaLabel1"
        FechaLabel1.Size = New System.Drawing.Size(86, 29)
        FechaLabel1.TabIndex = 15
        FechaLabel1.Text = "Fecha:"
        '
        'ClienteLabel1
        '
        ClienteLabel1.AutoSize = True
        ClienteLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClienteLabel1.Location = New System.Drawing.Point(25, 163)
        ClienteLabel1.Name = "ClienteLabel1"
        ClienteLabel1.Size = New System.Drawing.Size(95, 29)
        ClienteLabel1.TabIndex = 17
        ClienteLabel1.Text = "Cliente:"
        '
        'UsuarioLabel1
        '
        UsuarioLabel1.AutoSize = True
        UsuarioLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsuarioLabel1.Location = New System.Drawing.Point(25, 205)
        UsuarioLabel1.Name = "UsuarioLabel1"
        UsuarioLabel1.Size = New System.Drawing.Size(130, 29)
        UsuarioLabel1.TabIndex = 19
        UsuarioLabel1.Text = "Empleado:"
        '
        'ServicioLabel1
        '
        ServicioLabel1.AutoSize = True
        ServicioLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ServicioLabel1.Location = New System.Drawing.Point(25, 246)
        ServicioLabel1.Name = "ServicioLabel1"
        ServicioLabel1.Size = New System.Drawing.Size(106, 29)
        ServicioLabel1.TabIndex = 21
        ServicioLabel1.Text = "Servicio:"
        '
        'TiempoLabel1
        '
        TiempoLabel1.AutoSize = True
        TiempoLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TiempoLabel1.Location = New System.Drawing.Point(25, 287)
        TiempoLabel1.Name = "TiempoLabel1"
        TiempoLabel1.Size = New System.Drawing.Size(103, 29)
        TiempoLabel1.TabIndex = 23
        TiempoLabel1.Text = "Tiempo:"
        TiempoLabel1.Visible = False
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.Location = New System.Drawing.Point(241, 290)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(97, 29)
        Label12.TabIndex = 28
        Label12.Text = "Minutos"
        Label12.Visible = False
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.Location = New System.Drawing.Point(25, 123)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(65, 29)
        Label13.TabIndex = 30
        Label13.Text = "Hora"
        '
        'users
        '
        Me.users.AutoScroll = True
        Me.users.Controls.Add(Me.SplitContainer1)
        Me.users.Controls.Add(Me.Panel3)
        Me.users.Dock = System.Windows.Forms.DockStyle.Fill
        Me.users.Location = New System.Drawing.Point(0, 100)
        Me.users.Name = "users"
        Me.users.Size = New System.Drawing.Size(998, 657)
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
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.calendario)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(998, 552)
        Me.SplitContainer1.SplitterDistance = 293
        Me.SplitContainer1.TabIndex = 22
        '
        'calendario
        '
        Me.calendario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.calendario.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.calendario.ColumnCount = 7
        Me.calendario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.calendario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.calendario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.calendario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.calendario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.calendario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.calendario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.calendario.Location = New System.Drawing.Point(3, 68)
        Me.calendario.Name = "calendario"
        Me.calendario.RowCount = 6
        Me.calendario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.calendario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.calendario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.calendario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.calendario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.calendario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.calendario.Size = New System.Drawing.Size(287, 481)
        Me.calendario.TabIndex = 4
        Me.calendario.Tag = "1"
        Me.calendario.Visible = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.13615!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.86385!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label11, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(42, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(213, 37)
        Me.TableLayoutPanel3.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 30)
        Me.Label10.TabIndex = 19
        Me.Label10.Tag = "1"
        Me.Label10.Text = "septiembre"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(147, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 30)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "2013"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.StyleSalon.My.Resources.Resources.back1
        Me.PictureBox3.Location = New System.Drawing.Point(-5, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(41, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.StyleSalon.My.Resources.Resources._next
        Me.PictureBox1.Location = New System.Drawing.Point(261, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 3, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 47)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(287, 18)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(243, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 18)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Sábado"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Domingo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(203, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 18)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Viernes"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(43, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Lunes"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(163, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 18)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Jueves"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(83, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 18)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Martes"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(123, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Miércoles"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.PictureBox8)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PictureBox6)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PictureBox7)
        Me.SplitContainer2.Panel1.Controls.Add(Me.employeesPanel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PictureBox5)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PictureBox4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.timeLinePanel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.dateLbl)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Label1)
        Me.SplitContainer2.Panel2.Controls.Add(IdLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.IdTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer2.Panel2.Controls.Add(FechaLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.FechaDateTimePicker)
        Me.SplitContainer2.Panel2.Controls.Add(ClienteLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.ClienteTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(UsuarioLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.UsuarioTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(ServicioLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.ServicioTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(TiempoLabel)
        Me.SplitContainer2.Size = New System.Drawing.Size(701, 552)
        Me.SplitContainer2.SplitterDistance = 249
        Me.SplitContainer2.TabIndex = 0
        '
        'PictureBox8
        '
        Me.PictureBox8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox8.Location = New System.Drawing.Point(166, 290)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(79, 75)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 28
        Me.PictureBox8.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = Global.StyleSalon.My.Resources.Resources._next
        Me.PictureBox6.Location = New System.Drawing.Point(93, 34)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(56, 86)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 27
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Image = Global.StyleSalon.My.Resources.Resources.back
        Me.PictureBox7.Location = New System.Drawing.Point(20, 34)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(54, 86)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 26
        Me.PictureBox7.TabStop = False
        '
        'employeesPanel
        '
        Me.employeesPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.employeesPanel.Controls.Add(Me.employeesContainer)
        Me.employeesPanel.Location = New System.Drawing.Point(77, 34)
        Me.employeesPanel.Name = "employeesPanel"
        Me.employeesPanel.Size = New System.Drawing.Size(29, 86)
        Me.employeesPanel.TabIndex = 25
        '
        'employeesContainer
        '
        Me.employeesContainer.AutoSize = True
        Me.employeesContainer.Location = New System.Drawing.Point(1, 0)
        Me.employeesContainer.Name = "employeesContainer"
        Me.employeesContainer.Size = New System.Drawing.Size(210, 86)
        Me.employeesContainer.TabIndex = 26
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.StyleSalon.My.Resources.Resources.Navigation_Down
        Me.PictureBox5.Location = New System.Drawing.Point(166, 388)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(80, 48)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 24
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.StyleSalon.My.Resources.Resources.Navigation_up
        Me.PictureBox4.Location = New System.Drawing.Point(167, 228)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(80, 48)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 23
        Me.PictureBox4.TabStop = False
        '
        'timeLinePanel
        '
        Me.timeLinePanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.timeLinePanel.Controls.Add(Me.timeLineContainer)
        Me.timeLinePanel.Location = New System.Drawing.Point(17, 126)
        Me.timeLinePanel.Name = "timeLinePanel"
        Me.timeLinePanel.Size = New System.Drawing.Size(143, 415)
        Me.timeLinePanel.TabIndex = 22
        '
        'timeLineContainer
        '
        Me.timeLineContainer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.timeLineContainer.AutoSize = True
        Me.timeLineContainer.Location = New System.Drawing.Point(3, 0)
        Me.timeLineContainer.Name = "timeLineContainer"
        Me.timeLineContainer.Size = New System.Drawing.Size(137, 96)
        Me.timeLineContainer.TabIndex = 23
        '
        'dateLbl
        '
        Me.dateLbl.AutoSize = True
        Me.dateLbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dateLbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateLbl.Location = New System.Drawing.Point(13, 8)
        Me.dateLbl.Name = "dateLbl"
        Me.dateLbl.Size = New System.Drawing.Size(189, 20)
        Me.dateLbl.TabIndex = 19
        Me.dateLbl.Tag = "1"
        Me.dateLbl.Text = "Lunes 1 de enero de 2013"
        Me.dateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IdTextBox
        '
        Me.IdTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(121, 1336)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(3227, 21)
        Me.IdTextBox.TabIndex = 1
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
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.HoraDateTimePicker)
        Me.Panel1.Controls.Add(Label13)
        Me.Panel1.Controls.Add(Me.IdTextBox1)
        Me.Panel1.Controls.Add(Label12)
        Me.Panel1.Controls.Add(TiempoLabel1)
        Me.Panel1.Controls.Add(Me.TiempoNumericUpDown)
        Me.Panel1.Controls.Add(ServicioLabel1)
        Me.Panel1.Controls.Add(Me.ServicioComboBox)
        Me.Panel1.Controls.Add(UsuarioLabel1)
        Me.Panel1.Controls.Add(Me.UsuarioComboBox)
        Me.Panel1.Controls.Add(ClienteLabel1)
        Me.Panel1.Controls.Add(Me.ClienteComboBox)
        Me.Panel1.Controls.Add(Me.FechaDateTimePicker1)
        Me.Panel1.Controls.Add(IdLabel1)
        Me.Panel1.Controls.Add(FechaLabel1)
        Me.Panel1.Location = New System.Drawing.Point(12, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(429, 366)
        Me.Panel1.TabIndex = 30
        '
        'HoraDateTimePicker
        '
        Me.HoraDateTimePicker.CustomFormat = "hh:mm tt"
        Me.HoraDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoraDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.HoraDateTimePicker.Location = New System.Drawing.Point(161, 118)
        Me.HoraDateTimePicker.Name = "HoraDateTimePicker"
        Me.HoraDateTimePicker.ShowUpDown = True
        Me.HoraDateTimePicker.Size = New System.Drawing.Size(170, 35)
        Me.HoraDateTimePicker.TabIndex = 31
        '
        'IdTextBox1
        '
        Me.IdTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "Id", True))
        Me.IdTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox1.Location = New System.Drawing.Point(161, 36)
        Me.IdTextBox1.Name = "IdTextBox1"
        Me.IdTextBox1.Size = New System.Drawing.Size(74, 35)
        Me.IdTextBox1.TabIndex = 14
        '
        'TiempoNumericUpDown
        '
        Me.TiempoNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AgendaBindingSource, "Tiempo", True))
        Me.TiempoNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TiempoNumericUpDown.Location = New System.Drawing.Point(161, 288)
        Me.TiempoNumericUpDown.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.TiempoNumericUpDown.Minimum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.TiempoNumericUpDown.Name = "TiempoNumericUpDown"
        Me.TiempoNumericUpDown.Size = New System.Drawing.Size(74, 35)
        Me.TiempoNumericUpDown.TabIndex = 27
        Me.TiempoNumericUpDown.Value = New Decimal(New Integer() {15, 0, 0, 0})
        Me.TiempoNumericUpDown.Visible = False
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
        Me.ServicioComboBox.Location = New System.Drawing.Point(161, 245)
        Me.ServicioComboBox.Name = "ServicioComboBox"
        Me.ServicioComboBox.Size = New System.Drawing.Size(239, 37)
        Me.ServicioComboBox.TabIndex = 26
        Me.ServicioComboBox.ValueMember = "Id"
        '
        'ServiciosBindingSource
        '
        Me.ServiciosBindingSource.DataMember = "Servicios"
        Me.ServiciosBindingSource.DataSource = Me.ATCDataSet
        '
        'UsuarioComboBox
        '
        Me.UsuarioComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsuarioComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.UsuarioComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.UsuarioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AgendaBindingSource, "Empleado", True))
        Me.UsuarioComboBox.DataSource = Me.EmpleadosBindingSource
        Me.UsuarioComboBox.DisplayMember = "Nombre"
        Me.UsuarioComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioComboBox.FormattingEnabled = True
        Me.UsuarioComboBox.Location = New System.Drawing.Point(161, 202)
        Me.UsuarioComboBox.Name = "UsuarioComboBox"
        Me.UsuarioComboBox.Size = New System.Drawing.Size(239, 37)
        Me.UsuarioComboBox.TabIndex = 25
        Me.UsuarioComboBox.ValueMember = "Id"
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
        Me.ClienteComboBox.Location = New System.Drawing.Point(161, 159)
        Me.ClienteComboBox.Name = "ClienteComboBox"
        Me.ClienteComboBox.Size = New System.Drawing.Size(239, 37)
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
        Me.FechaDateTimePicker1.CustomFormat = ""
        Me.FechaDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AgendaBindingSource, "Fecha", True))
        Me.FechaDateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker1.Location = New System.Drawing.Point(161, 77)
        Me.FechaDateTimePicker1.Name = "FechaDateTimePicker1"
        Me.FechaDateTimePicker1.Size = New System.Drawing.Size(170, 35)
        Me.FechaDateTimePicker1.TabIndex = 16
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AgendaBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(121, 1363)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(3227, 21)
        Me.FechaDateTimePicker.TabIndex = 3
        '
        'ClienteTextBox
        '
        Me.ClienteTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "Cliente", True))
        Me.ClienteTextBox.Location = New System.Drawing.Point(121, 1390)
        Me.ClienteTextBox.Name = "ClienteTextBox"
        Me.ClienteTextBox.Size = New System.Drawing.Size(3227, 21)
        Me.ClienteTextBox.TabIndex = 5
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "Empleado", True))
        Me.UsuarioTextBox.Location = New System.Drawing.Point(121, 1417)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(3227, 21)
        Me.UsuarioTextBox.TabIndex = 7
        '
        'ServicioTextBox
        '
        Me.ServicioTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServicioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgendaBindingSource, "Servicio", True))
        Me.ServicioTextBox.Location = New System.Drawing.Point(121, 1444)
        Me.ServicioTextBox.Name = "ServicioTextBox"
        Me.ServicioTextBox.Size = New System.Drawing.Size(3227, 21)
        Me.ServicioTextBox.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.usersAddBtn)
        Me.Panel3.Controls.Add(Me.usersEditBtn)
        Me.Panel3.Controls.Add(Me.usersDeleteBtn)
        Me.Panel3.Controls.Add(Me.btnguardar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 552)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5, 5, 7, 5)
        Me.Panel3.Size = New System.Drawing.Size(998, 105)
        Me.Panel3.TabIndex = 21
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
        Me.Button2.Location = New System.Drawing.Point(84, 5)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Button2.Size = New System.Drawing.Size(79, 95)
        Me.Button2.TabIndex = 25
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
        Me.Button1.Location = New System.Drawing.Point(5, 5)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Button1.Size = New System.Drawing.Size(79, 95)
        Me.Button1.TabIndex = 24
        Me.Button1.Tag = "5"
        Me.Button1.Text = "Nuevo Cliente"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'usersAddBtn
        '
        Me.usersAddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.usersAddBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.usersAddBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.usersAddBtn.FlatAppearance.BorderSize = 0
        Me.usersAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.usersAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.usersAddBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.usersAddBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.usersAddBtn.Image = Global.StyleSalon.My.Resources.Resources.add
        Me.usersAddBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.usersAddBtn.Location = New System.Drawing.Point(675, 5)
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
        Me.usersEditBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.usersEditBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.usersEditBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.usersEditBtn.FlatAppearance.BorderSize = 0
        Me.usersEditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.usersEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.usersEditBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.usersEditBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.usersEditBtn.Image = Global.StyleSalon.My.Resources.Resources.edit
        Me.usersEditBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.usersEditBtn.Location = New System.Drawing.Point(754, 5)
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
        Me.usersDeleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.usersDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.usersDeleteBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.usersDeleteBtn.FlatAppearance.BorderSize = 0
        Me.usersDeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.usersDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.usersDeleteBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.usersDeleteBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.usersDeleteBtn.Image = Global.StyleSalon.My.Resources.Resources.delete
        Me.usersDeleteBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.usersDeleteBtn.Location = New System.Drawing.Point(833, 5)
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
        Me.btnguardar.Location = New System.Drawing.Point(912, 5)
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
        Me.Panel2.Size = New System.Drawing.Size(998, 100)
        Me.Panel2.TabIndex = 20
        '
        'searchPanel
        '
        Me.searchPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchPanel.Controls.Add(Me.TextBox1)
        Me.searchPanel.Controls.Add(Me.PictureBox2)
        Me.searchPanel.Location = New System.Drawing.Point(594, 44)
        Me.searchPanel.Name = "searchPanel"
        Me.searchPanel.Size = New System.Drawing.Size(397, 50)
        Me.searchPanel.TabIndex = 17
        Me.searchPanel.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(28, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(357, 35)
        Me.TextBox1.TabIndex = 15
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.StyleSalon.My.Resources.Resources.search1
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 50)
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
        Me.Label2.Size = New System.Drawing.Size(149, 50)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Agenda"
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
        'AgendaScreen
        '
        Me.AgendaScreen.Controls.Add(Me.users)
        Me.AgendaScreen.Controls.Add(Me.Panel2)
        Me.AgendaScreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AgendaScreen.Location = New System.Drawing.Point(1, 30)
        Me.AgendaScreen.Name = "AgendaScreen"
        Me.AgendaScreen.Size = New System.Drawing.Size(998, 757)
        Me.AgendaScreen.TabIndex = 21
        '
        'meses
        '
        Me.meses.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.meses.Name = "meses"
        Me.meses.Size = New System.Drawing.Size(61, 4)
        '
        'años
        '
        Me.años.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.años.Name = "meses"
        Me.años.Size = New System.Drawing.Size(61, 4)
        '
        'AgendaTableAdapter
        '
        Me.AgendaTableAdapter.ClearBeforeFill = True
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
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'ServiciosTableAdapter
        '
        Me.ServiciosTableAdapter.ClearBeforeFill = True
        '
        'move
        '
        Me.move.Enabled = True
        Me.move.Interval = 50
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'Agenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.ClientSize = New System.Drawing.Size(1000, 788)
        Me.Controls.Add(Me.AgendaScreen)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1000, 1003)
        Me.Name = "Agenda"
        Me.Padding = New System.Windows.Forms.Padding(1, 30, 1, 1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salon Style - Configuración de Conexión"
        Me.users.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.employeesPanel.ResumeLayout(False)
        Me.employeesPanel.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.timeLinePanel.ResumeLayout(False)
        Me.timeLinePanel.PerformLayout()
        CType(Me.AgendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ATCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TiempoNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.searchPanel.ResumeLayout(False)
        Me.searchPanel.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usersBackBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AgendaScreen.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents users As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents usersBackBtn As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents AgendaScreen As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents usersAddBtn As System.Windows.Forms.Button
    Friend WithEvents usersEditBtn As System.Windows.Forms.Button
    Friend WithEvents usersDeleteBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents searchPanel As System.Windows.Forms.Panel
    Friend WithEvents ATCDataSet As StyleSalon.ATCDataSet
    Friend WithEvents AgendaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AgendaTableAdapter As StyleSalon.ATCDataSetTableAdapters.AgendaTableAdapter
    Friend WithEvents TableAdapterManager As StyleSalon.ATCDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ServicioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents calendario As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents meses As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents años As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents IdTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TiempoNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ServicioComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ClienteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As StyleSalon.ATCDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents ServiciosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ServiciosTableAdapter As StyleSalon.ATCDataSetTableAdapters.ServiciosTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents HoraDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateLbl As System.Windows.Forms.Label
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As StyleSalon.ATCDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents UsuarioComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents timeLinePanel As System.Windows.Forms.Panel
    Friend WithEvents move As System.Windows.Forms.Timer
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents timeLineContainer As System.Windows.Forms.Panel
    Friend WithEvents employeesPanel As System.Windows.Forms.Panel
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents employeesContainer As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
