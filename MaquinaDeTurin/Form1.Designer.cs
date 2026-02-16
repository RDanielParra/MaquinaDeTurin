namespace MaquinaDeTurin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gbxDatosMT = new GroupBox();
            button2 = new Button();
            cbxPosicionIni = new ComboBox();
            lblPosIni = new Label();
            btnCapturarCadena = new Button();
            label1 = new Label();
            btnAlfabeto = new Button();
            txtCadena = new TextBox();
            lblCadena = new Label();
            lblAlfabeto = new Label();
            txtAlfabeto = new TextBox();
            gbxOperaciones = new GroupBox();
            btnBorrarCadDer = new Button();
            btnBorrarCadIzq = new Button();
            btnBorrarCadena = new Button();
            btnSobrescribir = new Button();
            btnGuardarS = new Button();
            btnEscribirSDer = new Button();
            btnEscribirSIzq = new Button();
            cbxEscribirSimb = new ComboBox();
            lblEscribirSimb = new Label();
            btnEliminarHastaDer = new Button();
            btnEliminarHastaIzq = new Button();
            cbxEliminarHasta = new ComboBox();
            lblEliminarSHasta = new Label();
            btnEliminar1SIgualDer = new Button();
            btnEliminar1SIgualIzq = new Button();
            cbxEliminar1SIgual = new ComboBox();
            label3 = new Label();
            btnEliminarDifDer = new Button();
            btnEliminarDifIzq = new Button();
            cbxEliminarSDif = new ComboBox();
            lblEliminarSDif = new Label();
            btnEliminarIgualDer = new Button();
            btnEliminarIgualIzq = new Button();
            cbxEliminarSIgual = new ComboBox();
            lblEliminarSIgual = new Label();
            btnBuscarDifDer = new Button();
            btnBuscarDifIzq = new Button();
            cbxBuscarSDif = new ComboBox();
            lblBuscarSDif = new Label();
            btnBuscarIgualDer = new Button();
            btnBuscarIgualIzq = new Button();
            cbxBuscarSIgual = new ComboBox();
            lblBuscarSIgual = new Label();
            groupBox1 = new GroupBox();
            btnBuscarCadena = new Button();
            radBuscarRevesCadDer = new RadioButton();
            radBuscarRevesCadIzq = new RadioButton();
            radBuscarCadDer = new RadioButton();
            radBuscarCadIzq = new RadioButton();
            txtBuscarCadena = new TextBox();
            label2 = new Label();
            button3 = new Button();
            btnCopiarCad = new Button();
            dtgCinta = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            txtCompuesta = new TextBox();
            button4 = new Button();
            button5 = new Button();
            txtMovimientos = new TextBox();
            label6 = new Label();
            tpCadena = new ToolTip(components);
            btnMarcar = new Button();
            btnVolverAMarca = new Button();
            btnDesmarcar = new Button();
            btnEliminarHastaMarca = new Button();
            gbxDatosMT.SuspendLayout();
            gbxOperaciones.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCinta).BeginInit();
            SuspendLayout();
            // 
            // gbxDatosMT
            // 
            gbxDatosMT.Controls.Add(button2);
            gbxDatosMT.Controls.Add(cbxPosicionIni);
            gbxDatosMT.Controls.Add(lblPosIni);
            gbxDatosMT.Controls.Add(btnCapturarCadena);
            gbxDatosMT.Controls.Add(label1);
            gbxDatosMT.Controls.Add(btnAlfabeto);
            gbxDatosMT.Controls.Add(txtCadena);
            gbxDatosMT.Controls.Add(lblCadena);
            gbxDatosMT.Controls.Add(lblAlfabeto);
            gbxDatosMT.Controls.Add(txtAlfabeto);
            gbxDatosMT.Location = new Point(10, 9);
            gbxDatosMT.Margin = new Padding(2, 3, 2, 3);
            gbxDatosMT.Name = "gbxDatosMT";
            gbxDatosMT.Padding = new Padding(2, 3, 2, 3);
            gbxDatosMT.Size = new Size(343, 241);
            gbxDatosMT.TabIndex = 0;
            gbxDatosMT.TabStop = false;
            gbxDatosMT.Text = "Máquina de Turing";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Enabled = false;
            button2.Location = new Point(5, 195);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(329, 32);
            button2.TabIndex = 9;
            button2.Text = "Encender Máquina de Turing";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // cbxPosicionIni
            // 
            cbxPosicionIni.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPosicionIni.FormattingEnabled = true;
            cbxPosicionIni.Location = new Point(169, 161);
            cbxPosicionIni.Margin = new Padding(2, 3, 2, 3);
            cbxPosicionIni.Name = "cbxPosicionIni";
            cbxPosicionIni.Size = new Size(53, 28);
            cbxPosicionIni.TabIndex = 8;
            // 
            // lblPosIni
            // 
            lblPosIni.AutoSize = true;
            lblPosIni.Location = new Point(5, 163);
            lblPosIni.Margin = new Padding(2, 0, 2, 0);
            lblPosIni.Name = "lblPosIni";
            lblPosIni.Size = new Size(170, 20);
            lblPosIni.TabIndex = 7;
            lblPosIni.Text = "Posición de celda inicial:";
            // 
            // btnCapturarCadena
            // 
            btnCapturarCadena.BackColor = SystemColors.ActiveCaption;
            btnCapturarCadena.Enabled = false;
            btnCapturarCadena.Location = new Point(77, 113);
            btnCapturarCadena.Margin = new Padding(2, 3, 2, 3);
            btnCapturarCadena.Name = "btnCapturarCadena";
            btnCapturarCadena.Size = new Size(203, 33);
            btnCapturarCadena.TabIndex = 6;
            btnCapturarCadena.Text = "Capturar Cadena";
            btnCapturarCadena.UseVisualStyleBackColor = false;
            btnCapturarCadena.Click += btnCapturarCadena_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 89);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 5;
            label1.Text = "Space = blanco";
            // 
            // btnAlfabeto
            // 
            btnAlfabeto.BackColor = SystemColors.ActiveCaption;
            btnAlfabeto.Location = new Point(201, 39);
            btnAlfabeto.Margin = new Padding(2, 3, 2, 3);
            btnAlfabeto.Name = "btnAlfabeto";
            btnAlfabeto.Size = new Size(133, 32);
            btnAlfabeto.TabIndex = 3;
            btnAlfabeto.Text = "Capturar Alfabeto";
            btnAlfabeto.UseVisualStyleBackColor = false;
            btnAlfabeto.Click += btnAlfabeto_Click;
            // 
            // txtCadena
            // 
            txtCadena.Enabled = false;
            txtCadena.Location = new Point(77, 84);
            txtCadena.Margin = new Padding(2, 3, 2, 3);
            txtCadena.Name = "txtCadena";
            txtCadena.Size = new Size(121, 27);
            txtCadena.TabIndex = 4;
            txtCadena.TextChanged += txtCadena_TextChanged;
            txtCadena.KeyDown += txtCadena_KeyDown;
            txtCadena.KeyPress += txtCadena_KeyPress;
            // 
            // lblCadena
            // 
            lblCadena.AutoSize = true;
            lblCadena.Location = new Point(5, 89);
            lblCadena.Margin = new Padding(2, 0, 2, 0);
            lblCadena.Name = "lblCadena";
            lblCadena.Size = new Size(62, 20);
            lblCadena.TabIndex = 2;
            lblCadena.Text = "Cadena:";
            // 
            // lblAlfabeto
            // 
            lblAlfabeto.AutoSize = true;
            lblAlfabeto.Location = new Point(5, 41);
            lblAlfabeto.Margin = new Padding(2, 0, 2, 0);
            lblAlfabeto.Name = "lblAlfabeto";
            lblAlfabeto.Size = new Size(70, 20);
            lblAlfabeto.TabIndex = 1;
            lblAlfabeto.Text = "Alfabeto:";
            // 
            // txtAlfabeto
            // 
            txtAlfabeto.Location = new Point(77, 43);
            txtAlfabeto.Margin = new Padding(2, 3, 2, 3);
            txtAlfabeto.Name = "txtAlfabeto";
            txtAlfabeto.Size = new Size(121, 27);
            txtAlfabeto.TabIndex = 0;
            txtAlfabeto.KeyPress += txtAlfabeto_KeyPress;
            // 
            // gbxOperaciones
            // 
            gbxOperaciones.Controls.Add(btnBorrarCadDer);
            gbxOperaciones.Controls.Add(btnBorrarCadIzq);
            gbxOperaciones.Controls.Add(btnBorrarCadena);
            gbxOperaciones.Controls.Add(btnSobrescribir);
            gbxOperaciones.Controls.Add(btnGuardarS);
            gbxOperaciones.Controls.Add(btnEscribirSDer);
            gbxOperaciones.Controls.Add(btnEscribirSIzq);
            gbxOperaciones.Controls.Add(cbxEscribirSimb);
            gbxOperaciones.Controls.Add(lblEscribirSimb);
            gbxOperaciones.Controls.Add(btnEliminarHastaDer);
            gbxOperaciones.Controls.Add(btnEliminarHastaIzq);
            gbxOperaciones.Controls.Add(cbxEliminarHasta);
            gbxOperaciones.Controls.Add(lblEliminarSHasta);
            gbxOperaciones.Controls.Add(btnEliminar1SIgualDer);
            gbxOperaciones.Controls.Add(btnEliminar1SIgualIzq);
            gbxOperaciones.Controls.Add(cbxEliminar1SIgual);
            gbxOperaciones.Controls.Add(label3);
            gbxOperaciones.Controls.Add(btnEliminarDifDer);
            gbxOperaciones.Controls.Add(btnEliminarDifIzq);
            gbxOperaciones.Controls.Add(cbxEliminarSDif);
            gbxOperaciones.Controls.Add(lblEliminarSDif);
            gbxOperaciones.Controls.Add(btnEliminarIgualDer);
            gbxOperaciones.Controls.Add(btnEliminarIgualIzq);
            gbxOperaciones.Controls.Add(cbxEliminarSIgual);
            gbxOperaciones.Controls.Add(lblEliminarSIgual);
            gbxOperaciones.Controls.Add(btnBuscarDifDer);
            gbxOperaciones.Controls.Add(btnBuscarDifIzq);
            gbxOperaciones.Controls.Add(cbxBuscarSDif);
            gbxOperaciones.Controls.Add(lblBuscarSDif);
            gbxOperaciones.Controls.Add(btnBuscarIgualDer);
            gbxOperaciones.Controls.Add(btnBuscarIgualIzq);
            gbxOperaciones.Controls.Add(cbxBuscarSIgual);
            gbxOperaciones.Controls.Add(lblBuscarSIgual);
            gbxOperaciones.Location = new Point(358, 9);
            gbxOperaciones.Margin = new Padding(2, 3, 2, 3);
            gbxOperaciones.Name = "gbxOperaciones";
            gbxOperaciones.Padding = new Padding(2, 3, 2, 3);
            gbxOperaciones.Size = new Size(826, 241);
            gbxOperaciones.TabIndex = 1;
            gbxOperaciones.TabStop = false;
            gbxOperaciones.Text = "Operaciones";
            // 
            // btnBorrarCadDer
            // 
            btnBorrarCadDer.BackColor = SystemColors.ActiveCaption;
            btnBorrarCadDer.Enabled = false;
            btnBorrarCadDer.Location = new Point(703, 189);
            btnBorrarCadDer.Margin = new Padding(2, 3, 2, 3);
            btnBorrarCadDer.Name = "btnBorrarCadDer";
            btnBorrarCadDer.Size = new Size(119, 47);
            btnBorrarCadDer.TabIndex = 32;
            btnBorrarCadDer.Text = "Borrar la cadena hacia la der";
            btnBorrarCadDer.UseVisualStyleBackColor = false;
            btnBorrarCadDer.Click += btnBorrarCadDer_Click;
            // 
            // btnBorrarCadIzq
            // 
            btnBorrarCadIzq.BackColor = SystemColors.ActiveCaption;
            btnBorrarCadIzq.Enabled = false;
            btnBorrarCadIzq.Location = new Point(583, 189);
            btnBorrarCadIzq.Margin = new Padding(2, 3, 2, 3);
            btnBorrarCadIzq.Name = "btnBorrarCadIzq";
            btnBorrarCadIzq.Size = new Size(119, 47);
            btnBorrarCadIzq.TabIndex = 31;
            btnBorrarCadIzq.Text = "Borrar la cadena hacia la izq";
            btnBorrarCadIzq.UseVisualStyleBackColor = false;
            btnBorrarCadIzq.Click += btnBorrarCadIzq_Click;
            // 
            // btnBorrarCadena
            // 
            btnBorrarCadena.BackColor = SystemColors.ActiveCaption;
            btnBorrarCadena.Enabled = false;
            btnBorrarCadena.Location = new Point(583, 153);
            btnBorrarCadena.Margin = new Padding(2, 3, 2, 3);
            btnBorrarCadena.Name = "btnBorrarCadena";
            btnBorrarCadena.Size = new Size(239, 29);
            btnBorrarCadena.TabIndex = 30;
            btnBorrarCadena.Text = "Borrar la cadena";
            btnBorrarCadena.UseVisualStyleBackColor = false;
            btnBorrarCadena.Click += btnBorrarCadena_Click;
            // 
            // btnSobrescribir
            // 
            btnSobrescribir.BackColor = SystemColors.ActiveCaption;
            btnSobrescribir.Enabled = false;
            btnSobrescribir.Location = new Point(709, 120);
            btnSobrescribir.Margin = new Padding(2, 3, 2, 3);
            btnSobrescribir.Name = "btnSobrescribir";
            btnSobrescribir.Size = new Size(113, 27);
            btnSobrescribir.TabIndex = 29;
            btnSobrescribir.Text = "Sobrescribir";
            btnSobrescribir.UseVisualStyleBackColor = false;
            btnSobrescribir.Click += btnSobrescribir_Click;
            // 
            // btnGuardarS
            // 
            btnGuardarS.BackColor = SystemColors.ActiveCaption;
            btnGuardarS.Enabled = false;
            btnGuardarS.Location = new Point(583, 120);
            btnGuardarS.Margin = new Padding(2, 3, 2, 3);
            btnGuardarS.Name = "btnGuardarS";
            btnGuardarS.Size = new Size(119, 27);
            btnGuardarS.TabIndex = 28;
            btnGuardarS.Text = "Guardar Simb.";
            btnGuardarS.UseVisualStyleBackColor = false;
            btnGuardarS.Click += btnGuardarS_Click;
            // 
            // btnEscribirSDer
            // 
            btnEscribirSDer.BackColor = SystemColors.ActiveCaption;
            btnEscribirSDer.Enabled = false;
            btnEscribirSDer.Location = new Point(746, 75);
            btnEscribirSDer.Margin = new Padding(2, 3, 2, 3);
            btnEscribirSDer.Name = "btnEscribirSDer";
            btnEscribirSDer.Size = new Size(65, 33);
            btnEscribirSDer.TabIndex = 27;
            btnEscribirSDer.Text = "Der ->";
            btnEscribirSDer.UseVisualStyleBackColor = false;
            btnEscribirSDer.Visible = false;
            btnEscribirSDer.Click += btnEscribirSDer_Click;
            // 
            // btnEscribirSIzq
            // 
            btnEscribirSIzq.BackColor = SystemColors.ActiveCaption;
            btnEscribirSIzq.Enabled = false;
            btnEscribirSIzq.Location = new Point(601, 75);
            btnEscribirSIzq.Margin = new Padding(2, 3, 2, 3);
            btnEscribirSIzq.Name = "btnEscribirSIzq";
            btnEscribirSIzq.Size = new Size(141, 33);
            btnEscribirSIzq.TabIndex = 26;
            btnEscribirSIzq.Text = "Escribir";
            btnEscribirSIzq.UseVisualStyleBackColor = false;
            btnEscribirSIzq.Click += btnEscribirSIzq_Click;
            // 
            // cbxEscribirSimb
            // 
            cbxEscribirSimb.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEscribirSimb.FormattingEnabled = true;
            cbxEscribirSimb.Location = new Point(613, 44);
            cbxEscribirSimb.Margin = new Padding(2, 3, 2, 3);
            cbxEscribirSimb.Name = "cbxEscribirSimb";
            cbxEscribirSimb.Size = new Size(115, 28);
            cbxEscribirSimb.TabIndex = 25;
            // 
            // lblEscribirSimb
            // 
            lblEscribirSimb.AutoSize = true;
            lblEscribirSimb.Location = new Point(602, 21);
            lblEscribirSimb.Margin = new Padding(2, 0, 2, 0);
            lblEscribirSimb.Name = "lblEscribirSimb";
            lblEscribirSimb.Size = new Size(219, 20);
            lblEscribirSimb.TabIndex = 24;
            lblEscribirSimb.Text = "Escribir símbolo en celda actual";
            // 
            // btnEliminarHastaDer
            // 
            btnEliminarHastaDer.BackColor = SystemColors.ActiveCaption;
            btnEliminarHastaDer.Enabled = false;
            btnEliminarHastaDer.Location = new Point(488, 177);
            btnEliminarHastaDer.Margin = new Padding(2, 3, 2, 3);
            btnEliminarHastaDer.Name = "btnEliminarHastaDer";
            btnEliminarHastaDer.Size = new Size(65, 37);
            btnEliminarHastaDer.TabIndex = 23;
            btnEliminarHastaDer.Text = "Der ->";
            btnEliminarHastaDer.UseVisualStyleBackColor = false;
            btnEliminarHastaDer.Click += btnEliminarHastaDer_Click;
            // 
            // btnEliminarHastaIzq
            // 
            btnEliminarHastaIzq.BackColor = SystemColors.ActiveCaption;
            btnEliminarHastaIzq.Enabled = false;
            btnEliminarHastaIzq.Location = new Point(413, 177);
            btnEliminarHastaIzq.Margin = new Padding(2, 3, 2, 3);
            btnEliminarHastaIzq.Name = "btnEliminarHastaIzq";
            btnEliminarHastaIzq.Size = new Size(65, 37);
            btnEliminarHastaIzq.TabIndex = 22;
            btnEliminarHastaIzq.Text = "<- Izq";
            btnEliminarHastaIzq.UseVisualStyleBackColor = false;
            btnEliminarHastaIzq.Click += btnEliminarHastaIzq_Click;
            // 
            // cbxEliminarHasta
            // 
            cbxEliminarHasta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEliminarHasta.FormattingEnabled = true;
            cbxEliminarHasta.Location = new Point(425, 147);
            cbxEliminarHasta.Margin = new Padding(2, 3, 2, 3);
            cbxEliminarHasta.Name = "cbxEliminarHasta";
            cbxEliminarHasta.Size = new Size(115, 28);
            cbxEliminarHasta.TabIndex = 21;
            // 
            // lblEliminarSHasta
            // 
            lblEliminarSHasta.AutoSize = true;
            lblEliminarSHasta.Location = new Point(413, 124);
            lblEliminarSHasta.Margin = new Padding(2, 0, 2, 0);
            lblEliminarSHasta.Name = "lblEliminarSHasta";
            lblEliminarSHasta.Size = new Size(166, 20);
            lblEliminarSHasta.TabIndex = 20;
            lblEliminarSHasta.Text = "Eliminar símbolos hasta";
            // 
            // btnEliminar1SIgualDer
            // 
            btnEliminar1SIgualDer.BackColor = SystemColors.ActiveCaption;
            btnEliminar1SIgualDer.Enabled = false;
            btnEliminar1SIgualDer.Location = new Point(488, 75);
            btnEliminar1SIgualDer.Margin = new Padding(2, 3, 2, 3);
            btnEliminar1SIgualDer.Name = "btnEliminar1SIgualDer";
            btnEliminar1SIgualDer.Size = new Size(65, 37);
            btnEliminar1SIgualDer.TabIndex = 19;
            btnEliminar1SIgualDer.Text = "Der ->";
            btnEliminar1SIgualDer.UseVisualStyleBackColor = false;
            btnEliminar1SIgualDer.Click += btnEliminar1SIgualDer_Click;
            // 
            // btnEliminar1SIgualIzq
            // 
            btnEliminar1SIgualIzq.BackColor = SystemColors.ActiveCaption;
            btnEliminar1SIgualIzq.Enabled = false;
            btnEliminar1SIgualIzq.Location = new Point(413, 75);
            btnEliminar1SIgualIzq.Margin = new Padding(2, 3, 2, 3);
            btnEliminar1SIgualIzq.Name = "btnEliminar1SIgualIzq";
            btnEliminar1SIgualIzq.Size = new Size(65, 37);
            btnEliminar1SIgualIzq.TabIndex = 18;
            btnEliminar1SIgualIzq.Text = "<- Izq";
            btnEliminar1SIgualIzq.UseVisualStyleBackColor = false;
            btnEliminar1SIgualIzq.Click += btnEliminar1SIgualIzq_Click;
            // 
            // cbxEliminar1SIgual
            // 
            cbxEliminar1SIgual.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEliminar1SIgual.FormattingEnabled = true;
            cbxEliminar1SIgual.Location = new Point(425, 44);
            cbxEliminar1SIgual.Margin = new Padding(2, 3, 2, 3);
            cbxEliminar1SIgual.Name = "cbxEliminar1SIgual";
            cbxEliminar1SIgual.Size = new Size(115, 28);
            cbxEliminar1SIgual.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 21);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(180, 20);
            label3.TabIndex = 16;
            label3.Text = "Eliminar símbolo igual (1)";
            // 
            // btnEliminarDifDer
            // 
            btnEliminarDifDer.BackColor = SystemColors.ActiveCaption;
            btnEliminarDifDer.Enabled = false;
            btnEliminarDifDer.Location = new Point(281, 177);
            btnEliminarDifDer.Margin = new Padding(2, 3, 2, 3);
            btnEliminarDifDer.Name = "btnEliminarDifDer";
            btnEliminarDifDer.Size = new Size(65, 37);
            btnEliminarDifDer.TabIndex = 15;
            btnEliminarDifDer.Text = "Der ->";
            btnEliminarDifDer.UseVisualStyleBackColor = false;
            btnEliminarDifDer.Click += btnEliminarDifDer_Click;
            // 
            // btnEliminarDifIzq
            // 
            btnEliminarDifIzq.BackColor = SystemColors.ActiveCaption;
            btnEliminarDifIzq.Enabled = false;
            btnEliminarDifIzq.Location = new Point(207, 177);
            btnEliminarDifIzq.Margin = new Padding(2, 3, 2, 3);
            btnEliminarDifIzq.Name = "btnEliminarDifIzq";
            btnEliminarDifIzq.Size = new Size(65, 37);
            btnEliminarDifIzq.TabIndex = 14;
            btnEliminarDifIzq.Text = "<- Izq";
            btnEliminarDifIzq.UseVisualStyleBackColor = false;
            btnEliminarDifIzq.Click += btnEliminarDifIzq_Click;
            // 
            // cbxEliminarSDif
            // 
            cbxEliminarSDif.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEliminarSDif.FormattingEnabled = true;
            cbxEliminarSDif.Location = new Point(218, 147);
            cbxEliminarSDif.Margin = new Padding(2, 3, 2, 3);
            cbxEliminarSDif.Name = "cbxEliminarSDif";
            cbxEliminarSDif.Size = new Size(115, 28);
            cbxEliminarSDif.TabIndex = 13;
            // 
            // lblEliminarSDif
            // 
            lblEliminarSDif.AutoSize = true;
            lblEliminarSDif.Location = new Point(207, 124);
            lblEliminarSDif.Margin = new Padding(2, 0, 2, 0);
            lblEliminarSDif.Name = "lblEliminarSDif";
            lblEliminarSDif.Size = new Size(191, 20);
            lblEliminarSDif.TabIndex = 12;
            lblEliminarSDif.Text = "Eliminar símbolos diferente";
            // 
            // btnEliminarIgualDer
            // 
            btnEliminarIgualDer.BackColor = SystemColors.ActiveCaption;
            btnEliminarIgualDer.Enabled = false;
            btnEliminarIgualDer.Location = new Point(281, 75);
            btnEliminarIgualDer.Margin = new Padding(2, 3, 2, 3);
            btnEliminarIgualDer.Name = "btnEliminarIgualDer";
            btnEliminarIgualDer.Size = new Size(65, 37);
            btnEliminarIgualDer.TabIndex = 11;
            btnEliminarIgualDer.Text = "Der ->";
            btnEliminarIgualDer.UseVisualStyleBackColor = false;
            btnEliminarIgualDer.Click += btnEliminarIgualDer_Click;
            // 
            // btnEliminarIgualIzq
            // 
            btnEliminarIgualIzq.BackColor = SystemColors.ActiveCaption;
            btnEliminarIgualIzq.Enabled = false;
            btnEliminarIgualIzq.Location = new Point(207, 75);
            btnEliminarIgualIzq.Margin = new Padding(2, 3, 2, 3);
            btnEliminarIgualIzq.Name = "btnEliminarIgualIzq";
            btnEliminarIgualIzq.Size = new Size(65, 37);
            btnEliminarIgualIzq.TabIndex = 10;
            btnEliminarIgualIzq.Text = "<- Izq";
            btnEliminarIgualIzq.UseVisualStyleBackColor = false;
            btnEliminarIgualIzq.Click += btnEliminarIgualIzq_Click;
            // 
            // cbxEliminarSIgual
            // 
            cbxEliminarSIgual.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEliminarSIgual.FormattingEnabled = true;
            cbxEliminarSIgual.Location = new Point(218, 44);
            cbxEliminarSIgual.Margin = new Padding(2, 3, 2, 3);
            cbxEliminarSIgual.Name = "cbxEliminarSIgual";
            cbxEliminarSIgual.Size = new Size(115, 28);
            cbxEliminarSIgual.TabIndex = 9;
            // 
            // lblEliminarSIgual
            // 
            lblEliminarSIgual.AutoSize = true;
            lblEliminarSIgual.Location = new Point(207, 21);
            lblEliminarSIgual.Margin = new Padding(2, 0, 2, 0);
            lblEliminarSIgual.Name = "lblEliminarSIgual";
            lblEliminarSIgual.Size = new Size(164, 20);
            lblEliminarSIgual.TabIndex = 8;
            lblEliminarSIgual.Text = "Eliminar símbolos igual";
            // 
            // btnBuscarDifDer
            // 
            btnBuscarDifDer.BackColor = SystemColors.ActiveCaption;
            btnBuscarDifDer.Enabled = false;
            btnBuscarDifDer.Location = new Point(80, 177);
            btnBuscarDifDer.Margin = new Padding(2, 3, 2, 3);
            btnBuscarDifDer.Name = "btnBuscarDifDer";
            btnBuscarDifDer.Size = new Size(65, 37);
            btnBuscarDifDer.TabIndex = 7;
            btnBuscarDifDer.Text = "Der ->";
            btnBuscarDifDer.UseVisualStyleBackColor = false;
            btnBuscarDifDer.Click += btnBuscarDifDer_Click;
            // 
            // btnBuscarDifIzq
            // 
            btnBuscarDifIzq.BackColor = SystemColors.ActiveCaption;
            btnBuscarDifIzq.Enabled = false;
            btnBuscarDifIzq.Location = new Point(5, 177);
            btnBuscarDifIzq.Margin = new Padding(2, 3, 2, 3);
            btnBuscarDifIzq.Name = "btnBuscarDifIzq";
            btnBuscarDifIzq.Size = new Size(65, 37);
            btnBuscarDifIzq.TabIndex = 6;
            btnBuscarDifIzq.Text = "<- Izq";
            btnBuscarDifIzq.UseVisualStyleBackColor = false;
            btnBuscarDifIzq.Click += btnBuscarDifIzq_Click;
            // 
            // cbxBuscarSDif
            // 
            cbxBuscarSDif.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBuscarSDif.FormattingEnabled = true;
            cbxBuscarSDif.Location = new Point(17, 147);
            cbxBuscarSDif.Margin = new Padding(2, 3, 2, 3);
            cbxBuscarSDif.Name = "cbxBuscarSDif";
            cbxBuscarSDif.Size = new Size(115, 28);
            cbxBuscarSDif.TabIndex = 5;
            // 
            // lblBuscarSDif
            // 
            lblBuscarSDif.AutoSize = true;
            lblBuscarSDif.Location = new Point(5, 124);
            lblBuscarSDif.Margin = new Padding(2, 0, 2, 0);
            lblBuscarSDif.Name = "lblBuscarSDif";
            lblBuscarSDif.Size = new Size(174, 20);
            lblBuscarSDif.TabIndex = 4;
            lblBuscarSDif.Text = "Buscar símbolo diferente";
            // 
            // btnBuscarIgualDer
            // 
            btnBuscarIgualDer.BackColor = SystemColors.ActiveCaption;
            btnBuscarIgualDer.Enabled = false;
            btnBuscarIgualDer.Location = new Point(80, 75);
            btnBuscarIgualDer.Margin = new Padding(2, 3, 2, 3);
            btnBuscarIgualDer.Name = "btnBuscarIgualDer";
            btnBuscarIgualDer.Size = new Size(65, 37);
            btnBuscarIgualDer.TabIndex = 3;
            btnBuscarIgualDer.Text = "Der ->";
            btnBuscarIgualDer.UseVisualStyleBackColor = false;
            btnBuscarIgualDer.Click += btnBuscarIgualDer_Click;
            // 
            // btnBuscarIgualIzq
            // 
            btnBuscarIgualIzq.BackColor = SystemColors.ActiveCaption;
            btnBuscarIgualIzq.Enabled = false;
            btnBuscarIgualIzq.Location = new Point(5, 75);
            btnBuscarIgualIzq.Margin = new Padding(2, 3, 2, 3);
            btnBuscarIgualIzq.Name = "btnBuscarIgualIzq";
            btnBuscarIgualIzq.Size = new Size(65, 37);
            btnBuscarIgualIzq.TabIndex = 2;
            btnBuscarIgualIzq.Text = "<- Izq";
            btnBuscarIgualIzq.UseVisualStyleBackColor = false;
            btnBuscarIgualIzq.Click += btnBuscarIgualIzq_Click;
            // 
            // cbxBuscarSIgual
            // 
            cbxBuscarSIgual.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBuscarSIgual.FormattingEnabled = true;
            cbxBuscarSIgual.Location = new Point(17, 44);
            cbxBuscarSIgual.Margin = new Padding(2, 3, 2, 3);
            cbxBuscarSIgual.Name = "cbxBuscarSIgual";
            cbxBuscarSIgual.Size = new Size(115, 28);
            cbxBuscarSIgual.TabIndex = 1;
            // 
            // lblBuscarSIgual
            // 
            lblBuscarSIgual.AutoSize = true;
            lblBuscarSIgual.Location = new Point(5, 21);
            lblBuscarSIgual.Margin = new Padding(2, 0, 2, 0);
            lblBuscarSIgual.Name = "lblBuscarSIgual";
            lblBuscarSIgual.Size = new Size(147, 20);
            lblBuscarSIgual.TabIndex = 0;
            lblBuscarSIgual.Text = "Buscar símbolo igual";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscarCadena);
            groupBox1.Controls.Add(radBuscarRevesCadDer);
            groupBox1.Controls.Add(radBuscarRevesCadIzq);
            groupBox1.Controls.Add(radBuscarCadDer);
            groupBox1.Controls.Add(radBuscarCadIzq);
            groupBox1.Controls.Add(txtBuscarCadena);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btnCopiarCad);
            groupBox1.Location = new Point(10, 265);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(343, 287);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operaciones con Cadena";
            // 
            // btnBuscarCadena
            // 
            btnBuscarCadena.Location = new Point(5, 227);
            btnBuscarCadena.Margin = new Padding(2, 3, 2, 3);
            btnBuscarCadena.Name = "btnBuscarCadena";
            btnBuscarCadena.Size = new Size(329, 27);
            btnBuscarCadena.TabIndex = 8;
            btnBuscarCadena.Text = "Buscar cadena";
            btnBuscarCadena.UseVisualStyleBackColor = true;
            btnBuscarCadena.Visible = false;
            btnBuscarCadena.Click += btnBuscarCadena_Click;
            // 
            // radBuscarRevesCadDer
            // 
            radBuscarRevesCadDer.AutoSize = true;
            radBuscarRevesCadDer.Location = new Point(177, 176);
            radBuscarRevesCadDer.Margin = new Padding(2, 3, 2, 3);
            radBuscarRevesCadDer.Name = "radBuscarRevesCadDer";
            radBuscarRevesCadDer.Size = new Size(156, 24);
            radBuscarRevesCadDer.TabIndex = 7;
            radBuscarRevesCadDer.Text = "Buscar al revés der.";
            radBuscarRevesCadDer.UseVisualStyleBackColor = true;
            radBuscarRevesCadDer.Visible = false;
            // 
            // radBuscarRevesCadIzq
            // 
            radBuscarRevesCadIzq.AutoSize = true;
            radBuscarRevesCadIzq.Location = new Point(5, 176);
            radBuscarRevesCadIzq.Margin = new Padding(2, 3, 2, 3);
            radBuscarRevesCadIzq.Name = "radBuscarRevesCadIzq";
            radBuscarRevesCadIzq.Size = new Size(154, 24);
            radBuscarRevesCadIzq.TabIndex = 6;
            radBuscarRevesCadIzq.Text = "Buscar al revés izq.";
            radBuscarRevesCadIzq.UseVisualStyleBackColor = true;
            radBuscarRevesCadIzq.Visible = false;
            // 
            // radBuscarCadDer
            // 
            radBuscarCadDer.AutoSize = true;
            radBuscarCadDer.Location = new Point(177, 137);
            radBuscarCadDer.Margin = new Padding(2, 3, 2, 3);
            radBuscarCadDer.Name = "radBuscarCadDer";
            radBuscarCadDer.Size = new Size(130, 24);
            radBuscarCadDer.TabIndex = 5;
            radBuscarCadDer.Text = "Buscar a la der.";
            radBuscarCadDer.UseVisualStyleBackColor = true;
            radBuscarCadDer.Visible = false;
            // 
            // radBuscarCadIzq
            // 
            radBuscarCadIzq.AutoSize = true;
            radBuscarCadIzq.Checked = true;
            radBuscarCadIzq.Location = new Point(5, 137);
            radBuscarCadIzq.Margin = new Padding(2, 3, 2, 3);
            radBuscarCadIzq.Name = "radBuscarCadIzq";
            radBuscarCadIzq.Size = new Size(128, 24);
            radBuscarCadIzq.TabIndex = 4;
            radBuscarCadIzq.TabStop = true;
            radBuscarCadIzq.Text = "Buscar a la izq.";
            radBuscarCadIzq.UseVisualStyleBackColor = true;
            radBuscarCadIzq.Visible = false;
            // 
            // txtBuscarCadena
            // 
            txtBuscarCadena.Location = new Point(119, 91);
            txtBuscarCadena.Margin = new Padding(2, 3, 2, 3);
            txtBuscarCadena.Name = "txtBuscarCadena";
            txtBuscarCadena.Size = new Size(217, 27);
            txtBuscarCadena.TabIndex = 3;
            txtBuscarCadena.Visible = false;
            txtBuscarCadena.KeyPress += txtBuscarCadena_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 91);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Buscar cadena";
            label2.Visible = false;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(159, 32);
            button3.Margin = new Padding(2, 3, 2, 3);
            button3.Name = "button3";
            button3.Size = new Size(175, 27);
            button3.TabIndex = 1;
            button3.Text = "Copiar cadena al revés";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnCopiarCad
            // 
            btnCopiarCad.Enabled = false;
            btnCopiarCad.Location = new Point(5, 32);
            btnCopiarCad.Margin = new Padding(2, 3, 2, 3);
            btnCopiarCad.Name = "btnCopiarCad";
            btnCopiarCad.Size = new Size(135, 27);
            btnCopiarCad.TabIndex = 0;
            btnCopiarCad.Text = "Copiar cadena";
            btnCopiarCad.UseVisualStyleBackColor = true;
            btnCopiarCad.Click += btnCopiarCad_Click;
            // 
            // dtgCinta
            // 
            dtgCinta.AllowUserToAddRows = false;
            dtgCinta.AllowUserToDeleteRows = false;
            dtgCinta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCinta.Location = new Point(366, 284);
            dtgCinta.Margin = new Padding(2, 3, 2, 3);
            dtgCinta.Name = "dtgCinta";
            dtgCinta.ReadOnly = true;
            dtgCinta.RowHeadersWidth = 62;
            dtgCinta.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dtgCinta.Size = new Size(814, 92);
            dtgCinta.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 261);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 4;
            label4.Text = "Cinta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(358, 425);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 5;
            label5.Text = "Compuesta";
            // 
            // txtCompuesta
            // 
            txtCompuesta.Location = new Point(358, 448);
            txtCompuesta.Margin = new Padding(2, 3, 2, 3);
            txtCompuesta.Multiline = true;
            txtCompuesta.Name = "txtCompuesta";
            txtCompuesta.ReadOnly = true;
            txtCompuesta.Size = new Size(814, 43);
            txtCompuesta.TabIndex = 6;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Enabled = false;
            button4.Location = new Point(362, 381);
            button4.Margin = new Padding(2, 3, 2, 3);
            button4.Name = "button4";
            button4.Size = new Size(213, 29);
            button4.TabIndex = 7;
            button4.Text = "<- Mover a la Izquierda";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Enabled = false;
            button5.Location = new Point(576, 381);
            button5.Margin = new Padding(2, 3, 2, 3);
            button5.Name = "button5";
            button5.Size = new Size(213, 29);
            button5.TabIndex = 8;
            button5.Text = "Mover a la Derecha ->";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // txtMovimientos
            // 
            txtMovimientos.Location = new Point(358, 517);
            txtMovimientos.Margin = new Padding(2, 3, 2, 3);
            txtMovimientos.Multiline = true;
            txtMovimientos.Name = "txtMovimientos";
            txtMovimientos.ReadOnly = true;
            txtMovimientos.ScrollBars = ScrollBars.Vertical;
            txtMovimientos.Size = new Size(814, 99);
            txtMovimientos.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(358, 495);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 9;
            label6.Text = "Movimientos";
            // 
            // btnMarcar
            // 
            btnMarcar.BackColor = SystemColors.ActiveCaption;
            btnMarcar.Enabled = false;
            btnMarcar.Location = new Point(808, 381);
            btnMarcar.Margin = new Padding(2, 3, 2, 3);
            btnMarcar.Name = "btnMarcar";
            btnMarcar.Size = new Size(90, 27);
            btnMarcar.TabIndex = 11;
            btnMarcar.Text = "Marcar";
            btnMarcar.UseVisualStyleBackColor = false;
            btnMarcar.Click += btnMarcar_Click;
            // 
            // btnVolverAMarca
            // 
            btnVolverAMarca.BackColor = SystemColors.ActiveCaption;
            btnVolverAMarca.Enabled = false;
            btnVolverAMarca.Location = new Point(919, 383);
            btnVolverAMarca.Margin = new Padding(2, 3, 2, 3);
            btnVolverAMarca.Name = "btnVolverAMarca";
            btnVolverAMarca.Size = new Size(167, 27);
            btnVolverAMarca.TabIndex = 12;
            btnVolverAMarca.Text = "Volver a marca";
            btnVolverAMarca.UseVisualStyleBackColor = false;
            btnVolverAMarca.Click += btnVolverAMarca_Click;
            // 
            // btnDesmarcar
            // 
            btnDesmarcar.BackColor = SystemColors.ActiveCaption;
            btnDesmarcar.Enabled = false;
            btnDesmarcar.Location = new Point(1090, 381);
            btnDesmarcar.Margin = new Padding(2, 3, 2, 3);
            btnDesmarcar.Name = "btnDesmarcar";
            btnDesmarcar.Size = new Size(90, 27);
            btnDesmarcar.TabIndex = 13;
            btnDesmarcar.Text = "Desmarcar";
            btnDesmarcar.UseVisualStyleBackColor = false;
            btnDesmarcar.Click += btnDesmarcar_Click;
            // 
            // btnEliminarHastaMarca
            // 
            btnEliminarHastaMarca.BackColor = SystemColors.ActiveCaption;
            btnEliminarHastaMarca.Enabled = false;
            btnEliminarHastaMarca.Location = new Point(687, 411);
            btnEliminarHastaMarca.Margin = new Padding(2, 3, 2, 3);
            btnEliminarHastaMarca.Name = "btnEliminarHastaMarca";
            btnEliminarHastaMarca.Size = new Size(224, 31);
            btnEliminarHastaMarca.TabIndex = 14;
            btnEliminarHastaMarca.Text = "Eliminar hasta llegar a marca";
            btnEliminarHastaMarca.UseVisualStyleBackColor = false;
            btnEliminarHastaMarca.Visible = false;
            btnEliminarHastaMarca.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 633);
            Controls.Add(btnEliminarHastaMarca);
            Controls.Add(btnDesmarcar);
            Controls.Add(btnVolverAMarca);
            Controls.Add(btnMarcar);
            Controls.Add(txtMovimientos);
            Controls.Add(label6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(txtCompuesta);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtgCinta);
            Controls.Add(groupBox1);
            Controls.Add(gbxOperaciones);
            Controls.Add(gbxDatosMT);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            ShowIcon = false;
            Text = "Simulador de Máquina de Turing";
            gbxDatosMT.ResumeLayout(false);
            gbxDatosMT.PerformLayout();
            gbxOperaciones.ResumeLayout(false);
            gbxOperaciones.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCinta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxDatosMT;
        private Label lblAlfabeto;
        private TextBox txtAlfabeto;
        private Button btnAlfabeto;
        private TextBox txtCadena;
        private Label lblCadena;
        private Button btnCapturarCadena;
        private Label label1;
        private Label lblPosIni;
        private Button button2;
        private ComboBox cbxPosicionIni;
        private GroupBox gbxOperaciones;
        private Label lblBuscarSIgual;
        private Button btnBuscarDifDer;
        private Button btnBuscarDifIzq;
        private ComboBox cbxBuscarSDif;
        private Label lblBuscarSDif;
        private Button btnBuscarIgualDer;
        private Button btnBuscarIgualIzq;
        private ComboBox cbxBuscarSIgual;
        private Button btnEliminarIgualDer;
        private Button btnEliminarIgualIzq;
        private ComboBox cbxEliminarSIgual;
        private Label lblEliminarSIgual;
        private Button btnEliminarDifDer;
        private Button btnEliminarDifIzq;
        private ComboBox cbxEliminarSDif;
        private Label lblEliminarSDif;
        private Button btnEliminarHastaDer;
        private Button btnEliminarHastaIzq;
        private ComboBox cbxEliminarHasta;
        private Label lblEliminarSHasta;
        private Button btnEliminar1SIgualDer;
        private Button btnEliminar1SIgualIzq;
        private ComboBox cbxEliminar1SIgual;
        private Label label3;
        private Button btnEscribirSDer;
        private Button btnEscribirSIzq;
        private ComboBox cbxEscribirSimb;
        private Label lblEscribirSimb;
        private Button btnBorrarCadena;
        private Button btnSobrescribir;
        private Button btnGuardarS;
        private Button btnBorrarCadDer;
        private Button btnBorrarCadIzq;
        private GroupBox groupBox1;
        private Button button3;
        private Button btnCopiarCad;
        private Button btnBuscarCadena;
        private RadioButton radBuscarRevesCadDer;
        private RadioButton radBuscarRevesCadIzq;
        private RadioButton radBuscarCadDer;
        private RadioButton radBuscarCadIzq;
        private TextBox txtBuscarCadena;
        private Label label2;
        private DataGridView dtgCinta;
        private Label label4;
        private Label label5;
        private TextBox txtCompuesta;
        private Button button4;
        private Button button5;
        private TextBox txtMovimientos;
        private Label label6;
        private ToolTip tpCadena;
        private Button btnMarcar;
        private Button btnVolverAMarca;
        private Button btnDesmarcar;
        private Button btnEliminarHastaMarca;
    }
}
