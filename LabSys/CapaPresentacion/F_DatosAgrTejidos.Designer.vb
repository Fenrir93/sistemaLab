<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_DatosAgrTejidos

    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_DatosAgrTejidos))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txNlab = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtMuestreador = New System.Windows.Forms.DateTimePicker
        Me.cbMuestreador = New System.Windows.Forms.ComboBox
        Me.MUESTREADORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabsysDataSet3 = New LabSys.LabsysDataSet3
        Me.txMuestras = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label24 = New System.Windows.Forms.Label
        Me.chSA = New System.Windows.Forms.CheckBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rbApaSA = New System.Windows.Forms.RadioButton
        Me.rbApaNormal = New System.Windows.Forms.RadioButton
        Me.rbApaAnormal = New System.Windows.Forms.RadioButton
        Me.Label23 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.rbDenSA = New System.Windows.Forms.RadioButton
        Me.rbDenAlta = New System.Windows.Forms.RadioButton
        Me.rbDenTradicional = New System.Windows.Forms.RadioButton
        Me.rbDenBaja = New System.Windows.Forms.RadioButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rbVigSA = New System.Windows.Forms.RadioButton
        Me.rbVigAlto = New System.Windows.Forms.RadioButton
        Me.rbVigNormal2 = New System.Windows.Forms.RadioButton
        Me.rbVigNormal = New System.Windows.Forms.RadioButton
        Me.rbVigNorma = New System.Windows.Forms.RadioButton
        Me.rbVigBajo = New System.Windows.Forms.RadioButton
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbCarSA = New System.Windows.Forms.RadioButton
        Me.rbCarAlto = New System.Windows.Forms.RadioButton
        Me.rbCarNormal2 = New System.Windows.Forms.RadioButton
        Me.rbCarNormal = New System.Windows.Forms.RadioButton
        Me.rbCarNorma = New System.Windows.Forms.RadioButton
        Me.rbCarBajo = New System.Windows.Forms.RadioButton
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbRtoSA = New System.Windows.Forms.RadioButton
        Me.rbRtoAlto = New System.Windows.Forms.RadioButton
        Me.rbRtoNormal2 = New System.Windows.Forms.RadioButton
        Me.rbRtoNormal = New System.Windows.Forms.RadioButton
        Me.rbRtoNorma = New System.Windows.Forms.RadioButton
        Me.rbRtoBajo = New System.Windows.Forms.RadioButton
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnAceptarOK = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txCuartel1 = New System.Windows.Forms.TextBox
        Me.txCuartel2 = New System.Windows.Forms.TextBox
        Me.txObservacion = New System.Windows.Forms.TextBox
        Me.txEdad = New System.Windows.Forms.TextBox
        Me.cbLocalidad = New System.Windows.Forms.ComboBox
        Me.LOCALIDADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabsysDataSet7 = New LabSys.LabsysDataSet7
        Me.cbVariedad = New System.Windows.Forms.ComboBox
        Me.ESPECIEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabsysDataSet6 = New LabSys.LabsysDataSet6
        Me.cbTejido = New System.Windows.Forms.ComboBox
        Me.TEJIDOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabsysDataSet8 = New LabSys.LabsysDataSet8
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbEspecie = New System.Windows.Forms.ComboBox
        Me.ESPECIEBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txPredio = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.ESPECIEBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgDatArgTejidos = New System.Windows.Forms.DataGridView
        Me.Nlab = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cuartel1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cuartel2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tejido = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.especie = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Variedad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Edad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.rto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Car = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Vig = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Den = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Apa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Muestreador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FMuestreo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Predio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.MUESTREADORESTableAdapter = New LabSys.LabsysDataSet3TableAdapters.MUESTREADORESTableAdapter
        Me.ESPECIETableAdapter = New LabSys.LabsysDataSet6TableAdapters.ESPECIETableAdapter
        Me.LOCALIDADTableAdapter = New LabSys.LabsysDataSet7TableAdapters.LOCALIDADTableAdapter
        Me.ESPECIETableAdapter1 = New LabSys.LabsysDataSet8TableAdapters.ESPECIETableAdapter
        Me.TEJIDOTableAdapter = New LabSys.LabsysDataSet8TableAdapters.TEJIDOTableAdapter
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.MUESTREADORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabsysDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LOCALIDADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabsysDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESPECIEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabsysDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEJIDOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabsysDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESPECIEBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESPECIEBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDatArgTejidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.txNlab)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtMuestreador)
        Me.Panel1.Controls.Add(Me.cbMuestreador)
        Me.Panel1.Controls.Add(Me.txMuestras)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-3, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(995, 57)
        Me.Panel1.TabIndex = 0
        '
        'txNlab
        '
        Me.txNlab.BackColor = System.Drawing.Color.White
        Me.txNlab.Location = New System.Drawing.Point(89, 16)
        Me.txNlab.Name = "txNlab"
        Me.txNlab.ReadOnly = True
        Me.txNlab.Size = New System.Drawing.Size(74, 21)
        Me.txNlab.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(735, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Muestreador"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(418, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Muestreador"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nº Lab"
        '
        'dtMuestreador
        '
        Me.dtMuestreador.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtMuestreador.Location = New System.Drawing.Point(841, 14)
        Me.dtMuestreador.Name = "dtMuestreador"
        Me.dtMuestreador.Size = New System.Drawing.Size(125, 21)
        Me.dtMuestreador.TabIndex = 4
        '
        'cbMuestreador
        '
        Me.cbMuestreador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbMuestreador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbMuestreador.DataSource = Me.MUESTREADORESBindingSource
        Me.cbMuestreador.DisplayMember = "MUE_NOMBRE"
        Me.cbMuestreador.FormattingEnabled = True
        Me.cbMuestreador.Location = New System.Drawing.Point(502, 15)
        Me.cbMuestreador.Name = "cbMuestreador"
        Me.cbMuestreador.Size = New System.Drawing.Size(181, 23)
        Me.cbMuestreador.TabIndex = 3
        Me.cbMuestreador.ValueMember = "MUE_NOMBRE"
        '
        'MUESTREADORESBindingSource
        '
        Me.MUESTREADORESBindingSource.DataMember = "MUESTREADORES"
        Me.MUESTREADORESBindingSource.DataSource = Me.LabsysDataSet3
        '
        'LabsysDataSet3
        '
        Me.LabsysDataSet3.DataSetName = "LabsysDataSet3"
        Me.LabsysDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txMuestras
        '
        Me.txMuestras.BackColor = System.Drawing.Color.White
        Me.txMuestras.Location = New System.Drawing.Point(299, 15)
        Me.txMuestras.Name = "txMuestras"
        Me.txMuestras.Size = New System.Drawing.Size(66, 21)
        Me.txMuestras.TabIndex = 2
        Me.txMuestras.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(233, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Muestras"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.chSA)
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.btnAceptarOK)
        Me.Panel2.Controls.Add(Me.btnLimpiar)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txCuartel1)
        Me.Panel2.Controls.Add(Me.txCuartel2)
        Me.Panel2.Controls.Add(Me.txObservacion)
        Me.Panel2.Controls.Add(Me.txEdad)
        Me.Panel2.Controls.Add(Me.cbLocalidad)
        Me.Panel2.Controls.Add(Me.cbVariedad)
        Me.Panel2.Controls.Add(Me.cbTejido)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.cbEspecie)
        Me.Panel2.Controls.Add(Me.txPredio)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(-3, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(995, 241)
        Me.Panel2.TabIndex = 10
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(169, 117)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(55, 15)
        Me.Label24.TabIndex = 79
        Me.Label24.Text = "- Normal"
        '
        'chSA
        '
        Me.chSA.AutoSize = True
        Me.chSA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chSA.Checked = True
        Me.chSA.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chSA.Location = New System.Drawing.Point(627, 205)
        Me.chSA.Name = "chSA"
        Me.chSA.Size = New System.Drawing.Size(153, 19)
        Me.chSA.TabIndex = 39
        Me.chSA.Text = "Seleccionar todos s/ant"
        Me.chSA.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbApaSA)
        Me.GroupBox5.Controls.Add(Me.rbApaNormal)
        Me.GroupBox5.Controls.Add(Me.rbApaAnormal)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Location = New System.Drawing.Point(494, 165)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(474, 30)
        Me.GroupBox5.TabIndex = 78
        Me.GroupBox5.TabStop = False
        '
        'rbApaSA
        '
        Me.rbApaSA.AutoSize = True
        Me.rbApaSA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbApaSA.Checked = True
        Me.rbApaSA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rbApaSA.Location = New System.Drawing.Point(419, 9)
        Me.rbApaSA.Name = "rbApaSA"
        Me.rbApaSA.Size = New System.Drawing.Size(51, 19)
        Me.rbApaSA.TabIndex = 38
        Me.rbApaSA.TabStop = True
        Me.rbApaSA.Text = "s/ant"
        Me.rbApaSA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbApaSA.UseVisualStyleBackColor = True
        '
        'rbApaNormal
        '
        Me.rbApaNormal.AutoSize = True
        Me.rbApaNormal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbApaNormal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rbApaNormal.Location = New System.Drawing.Point(220, 9)
        Me.rbApaNormal.Name = "rbApaNormal"
        Me.rbApaNormal.Size = New System.Drawing.Size(66, 19)
        Me.rbApaNormal.TabIndex = 37
        Me.rbApaNormal.Text = "Normal"
        Me.rbApaNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbApaNormal.UseVisualStyleBackColor = True
        '
        'rbApaAnormal
        '
        Me.rbApaAnormal.AutoSize = True
        Me.rbApaAnormal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbApaAnormal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rbApaAnormal.Location = New System.Drawing.Point(101, 9)
        Me.rbApaAnormal.Name = "rbApaAnormal"
        Me.rbApaAnormal.Size = New System.Drawing.Size(71, 19)
        Me.rbApaAnormal.TabIndex = 36
        Me.rbApaAnormal.Text = "Anormal"
        Me.rbApaAnormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbApaAnormal.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(3, 10)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(71, 15)
        Me.Label23.TabIndex = 67
        Me.Label23.Text = "Apariencia :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbDenSA)
        Me.GroupBox4.Controls.Add(Me.rbDenAlta)
        Me.GroupBox4.Controls.Add(Me.rbDenTradicional)
        Me.GroupBox4.Controls.Add(Me.rbDenBaja)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Location = New System.Drawing.Point(494, 133)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(474, 30)
        Me.GroupBox4.TabIndex = 75
        Me.GroupBox4.TabStop = False
        '
        'rbDenSA
        '
        Me.rbDenSA.AutoSize = True
        Me.rbDenSA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbDenSA.Checked = True
        Me.rbDenSA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rbDenSA.Location = New System.Drawing.Point(419, 9)
        Me.rbDenSA.Name = "rbDenSA"
        Me.rbDenSA.Size = New System.Drawing.Size(51, 19)
        Me.rbDenSA.TabIndex = 35
        Me.rbDenSA.TabStop = True
        Me.rbDenSA.Text = "s/ant"
        Me.rbDenSA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbDenSA.UseVisualStyleBackColor = True
        '
        'rbDenAlta
        '
        Me.rbDenAlta.AutoSize = True
        Me.rbDenAlta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbDenAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rbDenAlta.Location = New System.Drawing.Point(329, 9)
        Me.rbDenAlta.Name = "rbDenAlta"
        Me.rbDenAlta.Size = New System.Drawing.Size(45, 19)
        Me.rbDenAlta.TabIndex = 34
        Me.rbDenAlta.Text = "Alta"
        Me.rbDenAlta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbDenAlta.UseVisualStyleBackColor = True
        '
        'rbDenTradicional
        '
        Me.rbDenTradicional.AutoSize = True
        Me.rbDenTradicional.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbDenTradicional.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rbDenTradicional.Location = New System.Drawing.Point(200, 9)
        Me.rbDenTradicional.Name = "rbDenTradicional"
        Me.rbDenTradicional.Size = New System.Drawing.Size(86, 19)
        Me.rbDenTradicional.TabIndex = 33
        Me.rbDenTradicional.Text = "Tradicional"
        Me.rbDenTradicional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbDenTradicional.UseVisualStyleBackColor = True
        '
        'rbDenBaja
        '
        Me.rbDenBaja.AutoSize = True
        Me.rbDenBaja.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbDenBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rbDenBaja.Location = New System.Drawing.Point(122, 9)
        Me.rbDenBaja.Name = "rbDenBaja"
        Me.rbDenBaja.Size = New System.Drawing.Size(50, 19)
        Me.rbDenBaja.TabIndex = 32
        Me.rbDenBaja.Text = "Baja"
        Me.rbDenBaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbDenBaja.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 15)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Dens. Plantas :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbVigSA)
        Me.GroupBox3.Controls.Add(Me.rbVigAlto)
        Me.GroupBox3.Controls.Add(Me.rbVigNormal2)
        Me.GroupBox3.Controls.Add(Me.rbVigNormal)
        Me.GroupBox3.Controls.Add(Me.rbVigNorma)
        Me.GroupBox3.Controls.Add(Me.rbVigBajo)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 196)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(474, 30)
        Me.GroupBox3.TabIndex = 73
        Me.GroupBox3.TabStop = False
        '
        'rbVigSA
        '
        Me.rbVigSA.AutoSize = True
        Me.rbVigSA.Checked = True
        Me.rbVigSA.Location = New System.Drawing.Point(431, 11)
        Me.rbVigSA.Name = "rbVigSA"
        Me.rbVigSA.Size = New System.Drawing.Size(14, 13)
        Me.rbVigSA.TabIndex = 31
        Me.rbVigSA.TabStop = True
        Me.rbVigSA.UseVisualStyleBackColor = True
        '
        'rbVigAlto
        '
        Me.rbVigAlto.AutoSize = True
        Me.rbVigAlto.Location = New System.Drawing.Point(367, 11)
        Me.rbVigAlto.Name = "rbVigAlto"
        Me.rbVigAlto.Size = New System.Drawing.Size(14, 13)
        Me.rbVigAlto.TabIndex = 30
        Me.rbVigAlto.UseVisualStyleBackColor = True
        '
        'rbVigNormal2
        '
        Me.rbVigNormal2.AutoSize = True
        Me.rbVigNormal2.Location = New System.Drawing.Point(310, 10)
        Me.rbVigNormal2.Name = "rbVigNormal2"
        Me.rbVigNormal2.Size = New System.Drawing.Size(14, 13)
        Me.rbVigNormal2.TabIndex = 29
        Me.rbVigNormal2.UseVisualStyleBackColor = True
        '
        'rbVigNormal
        '
        Me.rbVigNormal.AutoSize = True
        Me.rbVigNormal.Location = New System.Drawing.Point(242, 11)
        Me.rbVigNormal.Name = "rbVigNormal"
        Me.rbVigNormal.Size = New System.Drawing.Size(14, 13)
        Me.rbVigNormal.TabIndex = 28
        Me.rbVigNormal.UseVisualStyleBackColor = True
        '
        'rbVigNorma
        '
        Me.rbVigNorma.AutoSize = True
        Me.rbVigNorma.Location = New System.Drawing.Point(183, 11)
        Me.rbVigNorma.Name = "rbVigNorma"
        Me.rbVigNorma.Size = New System.Drawing.Size(14, 13)
        Me.rbVigNorma.TabIndex = 27
        Me.rbVigNorma.UseVisualStyleBackColor = True
        '
        'rbVigBajo
        '
        Me.rbVigBajo.AutoSize = True
        Me.rbVigBajo.Location = New System.Drawing.Point(131, 10)
        Me.rbVigBajo.Name = "rbVigBajo"
        Me.rbVigBajo.Size = New System.Drawing.Size(14, 13)
        Me.rbVigBajo.TabIndex = 26
        Me.rbVigBajo.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 15)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Vigor Plantas :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbCarSA)
        Me.GroupBox2.Controls.Add(Me.rbCarAlto)
        Me.GroupBox2.Controls.Add(Me.rbCarNormal2)
        Me.GroupBox2.Controls.Add(Me.rbCarNormal)
        Me.GroupBox2.Controls.Add(Me.rbCarNorma)
        Me.GroupBox2.Controls.Add(Me.rbCarBajo)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 165)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(473, 30)
        Me.GroupBox2.TabIndex = 71
        Me.GroupBox2.TabStop = False
        '
        'rbCarSA
        '
        Me.rbCarSA.AutoSize = True
        Me.rbCarSA.Checked = True
        Me.rbCarSA.Location = New System.Drawing.Point(431, 11)
        Me.rbCarSA.Name = "rbCarSA"
        Me.rbCarSA.Size = New System.Drawing.Size(14, 13)
        Me.rbCarSA.TabIndex = 25
        Me.rbCarSA.TabStop = True
        Me.rbCarSA.UseVisualStyleBackColor = True
        '
        'rbCarAlto
        '
        Me.rbCarAlto.AutoSize = True
        Me.rbCarAlto.Location = New System.Drawing.Point(367, 11)
        Me.rbCarAlto.Name = "rbCarAlto"
        Me.rbCarAlto.Size = New System.Drawing.Size(14, 13)
        Me.rbCarAlto.TabIndex = 24
        Me.rbCarAlto.UseVisualStyleBackColor = True
        '
        'rbCarNormal2
        '
        Me.rbCarNormal2.AutoSize = True
        Me.rbCarNormal2.Location = New System.Drawing.Point(310, 10)
        Me.rbCarNormal2.Name = "rbCarNormal2"
        Me.rbCarNormal2.Size = New System.Drawing.Size(14, 13)
        Me.rbCarNormal2.TabIndex = 23
        Me.rbCarNormal2.UseVisualStyleBackColor = True
        '
        'rbCarNormal
        '
        Me.rbCarNormal.AutoSize = True
        Me.rbCarNormal.Location = New System.Drawing.Point(242, 11)
        Me.rbCarNormal.Name = "rbCarNormal"
        Me.rbCarNormal.Size = New System.Drawing.Size(14, 13)
        Me.rbCarNormal.TabIndex = 22
        Me.rbCarNormal.UseVisualStyleBackColor = True
        '
        'rbCarNorma
        '
        Me.rbCarNorma.AutoSize = True
        Me.rbCarNorma.Location = New System.Drawing.Point(183, 11)
        Me.rbCarNorma.Name = "rbCarNorma"
        Me.rbCarNorma.Size = New System.Drawing.Size(14, 13)
        Me.rbCarNorma.TabIndex = 21
        Me.rbCarNorma.UseVisualStyleBackColor = True
        '
        'rbCarBajo
        '
        Me.rbCarBajo.AutoSize = True
        Me.rbCarBajo.Location = New System.Drawing.Point(131, 10)
        Me.rbCarBajo.Name = "rbCarBajo"
        Me.rbCarBajo.Size = New System.Drawing.Size(14, 13)
        Me.rbCarBajo.TabIndex = 20
        Me.rbCarBajo.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 15)
        Me.Label18.TabIndex = 60
        Me.Label18.Text = "Carga Actual :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbRtoSA)
        Me.GroupBox1.Controls.Add(Me.rbRtoAlto)
        Me.GroupBox1.Controls.Add(Me.rbRtoNormal2)
        Me.GroupBox1.Controls.Add(Me.rbRtoNormal)
        Me.GroupBox1.Controls.Add(Me.rbRtoNorma)
        Me.GroupBox1.Controls.Add(Me.rbRtoBajo)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(474, 30)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        '
        'rbRtoSA
        '
        Me.rbRtoSA.AutoSize = True
        Me.rbRtoSA.Checked = True
        Me.rbRtoSA.Location = New System.Drawing.Point(432, 12)
        Me.rbRtoSA.Name = "rbRtoSA"
        Me.rbRtoSA.Size = New System.Drawing.Size(14, 13)
        Me.rbRtoSA.TabIndex = 19
        Me.rbRtoSA.TabStop = True
        Me.rbRtoSA.UseVisualStyleBackColor = True
        '
        'rbRtoAlto
        '
        Me.rbRtoAlto.AutoSize = True
        Me.rbRtoAlto.Location = New System.Drawing.Point(368, 12)
        Me.rbRtoAlto.Name = "rbRtoAlto"
        Me.rbRtoAlto.Size = New System.Drawing.Size(14, 13)
        Me.rbRtoAlto.TabIndex = 18
        Me.rbRtoAlto.UseVisualStyleBackColor = True
        '
        'rbRtoNormal2
        '
        Me.rbRtoNormal2.AutoSize = True
        Me.rbRtoNormal2.Location = New System.Drawing.Point(311, 11)
        Me.rbRtoNormal2.Name = "rbRtoNormal2"
        Me.rbRtoNormal2.Size = New System.Drawing.Size(14, 13)
        Me.rbRtoNormal2.TabIndex = 17
        Me.rbRtoNormal2.UseVisualStyleBackColor = True
        '
        'rbRtoNormal
        '
        Me.rbRtoNormal.AutoSize = True
        Me.rbRtoNormal.Location = New System.Drawing.Point(243, 12)
        Me.rbRtoNormal.Name = "rbRtoNormal"
        Me.rbRtoNormal.Size = New System.Drawing.Size(14, 13)
        Me.rbRtoNormal.TabIndex = 16
        Me.rbRtoNormal.UseVisualStyleBackColor = True
        '
        'rbRtoNorma
        '
        Me.rbRtoNorma.AutoSize = True
        Me.rbRtoNorma.Location = New System.Drawing.Point(184, 12)
        Me.rbRtoNorma.Name = "rbRtoNorma"
        Me.rbRtoNorma.Size = New System.Drawing.Size(14, 13)
        Me.rbRtoNorma.TabIndex = 15
        Me.rbRtoNorma.UseVisualStyleBackColor = True
        '
        'rbRtoBajo
        '
        Me.rbRtoBajo.AutoSize = True
        Me.rbRtoBajo.Location = New System.Drawing.Point(132, 11)
        Me.rbRtoBajo.Name = "rbRtoBajo"
        Me.rbRtoBajo.Size = New System.Drawing.Size(14, 13)
        Me.rbRtoBajo.TabIndex = 14
        Me.rbRtoBajo.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 15)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Rto. Anterior :"
        '
        'btnAceptarOK
        '
        Me.btnAceptarOK.Image = CType(resources.GetObject("btnAceptarOK.Image"), System.Drawing.Image)
        Me.btnAceptarOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptarOK.Location = New System.Drawing.Point(840, 201)
        Me.btnAceptarOK.Name = "btnAceptarOK"
        Me.btnAceptarOK.Size = New System.Drawing.Size(47, 23)
        Me.btnAceptarOK.TabIndex = 40
        Me.btnAceptarOK.Text = "OK"
        Me.btnAceptarOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptarOK.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(893, 201)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 41
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(373, 21)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(61, 15)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "Localidad"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(373, 45)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 15)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "Variedad"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(731, 45)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 15)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Edad"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(373, 71)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 15)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Observación"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(129, 117)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 15)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Bajo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(230, 117)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 15)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Normal"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(296, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 15)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "+Normal"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(365, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 15)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Alto"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(428, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "s/ant"
        '
        'txCuartel1
        '
        Me.txCuartel1.Location = New System.Drawing.Point(89, 68)
        Me.txCuartel1.MaxLength = 16
        Me.txCuartel1.Name = "txCuartel1"
        Me.txCuartel1.Size = New System.Drawing.Size(110, 21)
        Me.txCuartel1.TabIndex = 11
        '
        'txCuartel2
        '
        Me.txCuartel2.Location = New System.Drawing.Point(204, 68)
        Me.txCuartel2.MaxLength = 16
        Me.txCuartel2.Name = "txCuartel2"
        Me.txCuartel2.Size = New System.Drawing.Size(110, 21)
        Me.txCuartel2.TabIndex = 12
        '
        'txObservacion
        '
        Me.txObservacion.Location = New System.Drawing.Point(454, 68)
        Me.txObservacion.Name = "txObservacion"
        Me.txObservacion.Size = New System.Drawing.Size(514, 21)
        Me.txObservacion.TabIndex = 13
        '
        'txEdad
        '
        Me.txEdad.Location = New System.Drawing.Point(786, 42)
        Me.txEdad.Name = "txEdad"
        Me.txEdad.Size = New System.Drawing.Size(182, 21)
        Me.txEdad.TabIndex = 10
        '
        'cbLocalidad
        '
        Me.cbLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbLocalidad.DataSource = Me.LOCALIDADBindingSource
        Me.cbLocalidad.DisplayMember = "LOCALIDAD"
        Me.cbLocalidad.FormattingEnabled = True
        Me.cbLocalidad.Location = New System.Drawing.Point(454, 16)
        Me.cbLocalidad.Name = "cbLocalidad"
        Me.cbLocalidad.Size = New System.Drawing.Size(178, 23)
        Me.cbLocalidad.TabIndex = 6
        Me.cbLocalidad.ValueMember = "LOCALIDAD"
        '
        'LOCALIDADBindingSource
        '
        Me.LOCALIDADBindingSource.DataMember = "LOCALIDAD"
        Me.LOCALIDADBindingSource.DataSource = Me.LabsysDataSet7
        '
        'LabsysDataSet7
        '
        Me.LabsysDataSet7.DataSetName = "LabsysDataSet7"
        Me.LabsysDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbVariedad
        '
        Me.cbVariedad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbVariedad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbVariedad.DataSource = Me.ESPECIEBindingSource
        Me.cbVariedad.DisplayMember = "variedad"
        Me.cbVariedad.FormattingEnabled = True
        Me.cbVariedad.Location = New System.Drawing.Point(454, 42)
        Me.cbVariedad.Name = "cbVariedad"
        Me.cbVariedad.Size = New System.Drawing.Size(178, 23)
        Me.cbVariedad.TabIndex = 9
        Me.cbVariedad.ValueMember = "variedad"
        '
        'ESPECIEBindingSource
        '
        Me.ESPECIEBindingSource.DataMember = "ESPECIE"
        Me.ESPECIEBindingSource.DataSource = Me.LabsysDataSet6
        '
        'LabsysDataSet6
        '
        Me.LabsysDataSet6.DataSetName = "LabsysDataSet6"
        Me.LabsysDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbTejido
        '
        Me.cbTejido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbTejido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTejido.DataSource = Me.TEJIDOBindingSource
        Me.cbTejido.DisplayMember = "tejido"
        Me.cbTejido.FormattingEnabled = True
        Me.cbTejido.Location = New System.Drawing.Point(786, 16)
        Me.cbTejido.Name = "cbTejido"
        Me.cbTejido.Size = New System.Drawing.Size(182, 23)
        Me.cbTejido.TabIndex = 7
        Me.cbTejido.ValueMember = "tejido"
        '
        'TEJIDOBindingSource
        '
        Me.TEJIDOBindingSource.DataMember = "TEJIDO"
        Me.TEJIDOBindingSource.DataSource = Me.LabsysDataSet8
        '
        'LabsysDataSet8
        '
        Me.LabsysDataSet8.DataSetName = "LabsysDataSet8"
        Me.LabsysDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(731, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tejido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Cuartel"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Predio"
        '
        'cbEspecie
        '
        Me.cbEspecie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbEspecie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbEspecie.DataSource = Me.ESPECIEBindingSource2
        Me.cbEspecie.DisplayMember = "ESP_ESPECIE"
        Me.cbEspecie.FormattingEnabled = True
        Me.cbEspecie.Location = New System.Drawing.Point(89, 42)
        Me.cbEspecie.Name = "cbEspecie"
        Me.cbEspecie.Size = New System.Drawing.Size(225, 23)
        Me.cbEspecie.TabIndex = 8
        Me.cbEspecie.ValueMember = "ESP_ESPECIE"
        '
        'ESPECIEBindingSource2
        '
        Me.ESPECIEBindingSource2.DataMember = "ESPECIE"
        Me.ESPECIEBindingSource2.DataSource = Me.LabsysDataSet8
        '
        'txPredio
        '
        Me.txPredio.Location = New System.Drawing.Point(89, 18)
        Me.txPredio.Name = "txPredio"
        Me.txPredio.Size = New System.Drawing.Size(225, 21)
        Me.txPredio.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Especie"
        '
        'ESPECIEBindingSource1
        '
        Me.ESPECIEBindingSource1.DataMember = "ESPECIE"
        Me.ESPECIEBindingSource1.DataSource = Me.LabsysDataSet6
        '
        'dgDatArgTejidos
        '
        Me.dgDatArgTejidos.AllowUserToAddRows = False
        Me.dgDatArgTejidos.AllowUserToDeleteRows = False
        Me.dgDatArgTejidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatArgTejidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nlab, Me.Cuartel1, Me.Cuartel2, Me.Tejido, Me.especie, Me.Variedad, Me.Edad, Me.rto, Me.Car, Me.Vig, Me.Den, Me.Apa, Me.F1, Me.F2, Me.Observacion, Me.Muestreador, Me.FMuestreo, Me.Predio, Me.Localidad})
        Me.dgDatArgTejidos.Location = New System.Drawing.Point(-3, 299)
        Me.dgDatArgTejidos.Name = "dgDatArgTejidos"
        Me.dgDatArgTejidos.ReadOnly = True
        Me.dgDatArgTejidos.Size = New System.Drawing.Size(995, 418)
        Me.dgDatArgTejidos.TabIndex = 42
        '
        'Nlab
        '
        Me.Nlab.HeaderText = "Nlab"
        Me.Nlab.Name = "Nlab"
        Me.Nlab.ReadOnly = True
        Me.Nlab.Width = 60
        '
        'Cuartel1
        '
        Me.Cuartel1.HeaderText = "Cuartel(1)"
        Me.Cuartel1.Name = "Cuartel1"
        Me.Cuartel1.ReadOnly = True
        Me.Cuartel1.Width = 90
        '
        'Cuartel2
        '
        Me.Cuartel2.HeaderText = "Cuartel(2)"
        Me.Cuartel2.Name = "Cuartel2"
        Me.Cuartel2.ReadOnly = True
        Me.Cuartel2.Width = 90
        '
        'Tejido
        '
        Me.Tejido.HeaderText = "Tejido"
        Me.Tejido.Name = "Tejido"
        Me.Tejido.ReadOnly = True
        Me.Tejido.Width = 70
        '
        'especie
        '
        Me.especie.HeaderText = "Especie"
        Me.especie.Name = "especie"
        Me.especie.ReadOnly = True
        Me.especie.Width = 70
        '
        'Variedad
        '
        Me.Variedad.HeaderText = "Variedad"
        Me.Variedad.Name = "Variedad"
        Me.Variedad.ReadOnly = True
        Me.Variedad.Width = 70
        '
        'Edad
        '
        Me.Edad.HeaderText = "Edad"
        Me.Edad.Name = "Edad"
        Me.Edad.ReadOnly = True
        Me.Edad.Width = 30
        '
        'rto
        '
        Me.rto.HeaderText = "Rto"
        Me.rto.Name = "rto"
        Me.rto.ReadOnly = True
        Me.rto.Width = 30
        '
        'Car
        '
        Me.Car.HeaderText = "Car"
        Me.Car.Name = "Car"
        Me.Car.ReadOnly = True
        Me.Car.Width = 30
        '
        'Vig
        '
        Me.Vig.HeaderText = "Vig"
        Me.Vig.Name = "Vig"
        Me.Vig.ReadOnly = True
        Me.Vig.Width = 30
        '
        'Den
        '
        Me.Den.HeaderText = "Den"
        Me.Den.Name = "Den"
        Me.Den.ReadOnly = True
        Me.Den.Width = 30
        '
        'Apa
        '
        Me.Apa.HeaderText = "Apa"
        Me.Apa.Name = "Apa"
        Me.Apa.ReadOnly = True
        Me.Apa.Width = 30
        '
        'F1
        '
        Me.F1.HeaderText = "F1"
        Me.F1.Name = "F1"
        Me.F1.ReadOnly = True
        Me.F1.Width = 30
        '
        'F2
        '
        Me.F2.HeaderText = "F2"
        Me.F2.Name = "F2"
        Me.F2.ReadOnly = True
        Me.F2.Width = 30
        '
        'Observacion
        '
        Me.Observacion.HeaderText = "Observación"
        Me.Observacion.Name = "Observacion"
        Me.Observacion.ReadOnly = True
        Me.Observacion.Width = 150
        '
        'Muestreador
        '
        Me.Muestreador.HeaderText = "Muestreador"
        Me.Muestreador.Name = "Muestreador"
        Me.Muestreador.ReadOnly = True
        '
        'FMuestreo
        '
        Me.FMuestreo.HeaderText = "F.Muestreo"
        Me.FMuestreo.Name = "FMuestreo"
        Me.FMuestreo.ReadOnly = True
        Me.FMuestreo.Width = 60
        '
        'Predio
        '
        Me.Predio.HeaderText = "Predio"
        Me.Predio.Name = "Predio"
        Me.Predio.ReadOnly = True
        '
        'Localidad
        '
        Me.Localidad.HeaderText = "Localidad"
        Me.Localidad.Name = "Localidad"
        Me.Localidad.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.btnAceptar)
        Me.Panel3.Location = New System.Drawing.Point(-3, 718)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(995, 51)
        Me.Panel3.TabIndex = 20
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(431, 11)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(85, 27)
        Me.btnAceptar.TabIndex = 43
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'MUESTREADORESTableAdapter
        '
        Me.MUESTREADORESTableAdapter.ClearBeforeFill = True
        '
        'ESPECIETableAdapter
        '
        Me.ESPECIETableAdapter.ClearBeforeFill = True
        '
        'LOCALIDADTableAdapter
        '
        Me.LOCALIDADTableAdapter.ClearBeforeFill = True
        '
        'ESPECIETableAdapter1
        '
        Me.ESPECIETableAdapter1.ClearBeforeFill = True
        '
        'TEJIDOTableAdapter
        '
        Me.TEJIDOTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(522, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 27)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Imprimir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'F_DatosAgrTejidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(995, 772)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dgDatArgTejidos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "F_DatosAgrTejidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Agronómicos Tejidos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MUESTREADORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabsysDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LOCALIDADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabsysDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESPECIEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabsysDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEJIDOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabsysDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESPECIEBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESPECIEBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDatArgTejidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtMuestreador As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbMuestreador As System.Windows.Forms.ComboBox
    Friend WithEvents txMuestras As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cbLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents cbVariedad As System.Windows.Forms.ComboBox
    Friend WithEvents cbTejido As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbEspecie As System.Windows.Forms.ComboBox
    Friend WithEvents txPredio As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txCuartel1 As System.Windows.Forms.TextBox
    Friend WithEvents txCuartel2 As System.Windows.Forms.TextBox
    Friend WithEvents txObservacion As System.Windows.Forms.TextBox
    Friend WithEvents txEdad As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptarOK As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents dgDatArgTejidos As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Nlab As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuartel1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuartel2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tejido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents especie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Variedad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Edad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Car As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vig As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Den As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Muestreador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FMuestreo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Predio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbCarSA As System.Windows.Forms.RadioButton
    Friend WithEvents rbCarAlto As System.Windows.Forms.RadioButton
    Friend WithEvents rbCarNormal2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbCarNormal As System.Windows.Forms.RadioButton
    Friend WithEvents rbCarNorma As System.Windows.Forms.RadioButton
    Friend WithEvents rbCarBajo As System.Windows.Forms.RadioButton
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbRtoSA As System.Windows.Forms.RadioButton
    Friend WithEvents rbRtoAlto As System.Windows.Forms.RadioButton
    Friend WithEvents rbRtoNormal2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbRtoNormal As System.Windows.Forms.RadioButton
    Friend WithEvents rbRtoNorma As System.Windows.Forms.RadioButton
    Friend WithEvents rbRtoBajo As System.Windows.Forms.RadioButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbDenSA As System.Windows.Forms.RadioButton
    Friend WithEvents rbDenAlta As System.Windows.Forms.RadioButton
    Friend WithEvents rbDenTradicional As System.Windows.Forms.RadioButton
    Friend WithEvents rbDenBaja As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbVigSA As System.Windows.Forms.RadioButton
    Friend WithEvents rbVigAlto As System.Windows.Forms.RadioButton
    Friend WithEvents rbVigNormal2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbVigNormal As System.Windows.Forms.RadioButton
    Friend WithEvents rbVigNorma As System.Windows.Forms.RadioButton
    Friend WithEvents rbVigBajo As System.Windows.Forms.RadioButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rbApaSA As System.Windows.Forms.RadioButton
    Friend WithEvents rbApaNormal As System.Windows.Forms.RadioButton
    Friend WithEvents rbApaAnormal As System.Windows.Forms.RadioButton
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents chSA As System.Windows.Forms.CheckBox

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents txNlab As System.Windows.Forms.TextBox
    Friend WithEvents LabsysDataSet3 As LabSys.LabsysDataSet3
    Friend WithEvents MUESTREADORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MUESTREADORESTableAdapter As LabSys.LabsysDataSet3TableAdapters.MUESTREADORESTableAdapter
    Friend WithEvents LabsysDataSet6 As LabSys.LabsysDataSet6
    Friend WithEvents ESPECIEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ESPECIETableAdapter As LabSys.LabsysDataSet6TableAdapters.ESPECIETableAdapter
    Friend WithEvents LabsysDataSet7 As LabSys.LabsysDataSet7
    Friend WithEvents LOCALIDADBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOCALIDADTableAdapter As LabSys.LabsysDataSet7TableAdapters.LOCALIDADTableAdapter
    Friend WithEvents ESPECIEBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents LabsysDataSet8 As LabSys.LabsysDataSet8
    Friend WithEvents ESPECIEBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ESPECIETableAdapter1 As LabSys.LabsysDataSet8TableAdapters.ESPECIETableAdapter
    Friend WithEvents TEJIDOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TEJIDOTableAdapter As LabSys.LabsysDataSet8TableAdapters.TEJIDOTableAdapter
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
