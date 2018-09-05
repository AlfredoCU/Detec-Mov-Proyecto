namespace DetecMov
{
    partial class DeteMov
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeteMov));
            this.cbCamara = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.lblDectMov = new System.Windows.Forms.Label();
            this.txtDetcMov = new System.Windows.Forms.TextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.vspCamara = new AForge.Controls.VideoSourcePlayer();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.gbTiposDetec = new System.Windows.Forms.GroupBox();
            this.lblDetecccion = new System.Windows.Forms.Label();
            this.lblDetenccion2 = new System.Windows.Forms.Label();
            this.lblDetenccion1 = new System.Windows.Forms.Label();
            this.rbDetector9 = new System.Windows.Forms.RadioButton();
            this.rbDetector10 = new System.Windows.Forms.RadioButton();
            this.rbDetector7 = new System.Windows.Forms.RadioButton();
            this.rbDetector12 = new System.Windows.Forms.RadioButton();
            this.rbDetector4 = new System.Windows.Forms.RadioButton();
            this.rbDetector11 = new System.Windows.Forms.RadioButton();
            this.rbDetector5 = new System.Windows.Forms.RadioButton();
            this.rbDetector6 = new System.Windows.Forms.RadioButton();
            this.rbDetector3 = new System.Windows.Forms.RadioButton();
            this.rbDetector8 = new System.Windows.Forms.RadioButton();
            this.rbDetector2 = new System.Windows.Forms.RadioButton();
            this.rbDetector1 = new System.Windows.Forms.RadioButton();
            this.pbCamaraColor = new System.Windows.Forms.PictureBox();
            this.tcMenu = new System.Windows.Forms.TabControl();
            this.tpDetcMov = new System.Windows.Forms.TabPage();
            this.tpReconicimientoColor = new System.Windows.Forms.TabPage();
            this.cbCamaraColor = new System.Windows.Forms.ComboBox();
            this.cbActivarColor = new System.Windows.Forms.CheckBox();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.gbTipoVision = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rbNegro = new System.Windows.Forms.RadioButton();
            this.rbOriginal = new System.Windows.Forms.RadioButton();
            this.btnSalirColor = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.pbLogo1 = new System.Windows.Forms.PictureBox();
            this.btnIniciarColor = new System.Windows.Forms.Button();
            this.btnCapturarColor = new System.Windows.Forms.Button();
            this.btnDetenerColor = new System.Windows.Forms.Button();
            this.colorD = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbTiposDetec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamaraColor)).BeginInit();
            this.tcMenu.SuspendLayout();
            this.tpDetcMov.SuspendLayout();
            this.tpReconicimientoColor.SuspendLayout();
            this.gbColor.SuspendLayout();
            this.gbTipoVision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCamara
            // 
            this.cbCamara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCamara.FormattingEnabled = true;
            this.cbCamara.Location = new System.Drawing.Point(12, 13);
            this.cbCamara.Name = "cbCamara";
            this.cbCamara.Size = new System.Drawing.Size(345, 24);
            this.cbCamara.TabIndex = 0;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.Green;
            this.btnIniciar.Location = new System.Drawing.Point(376, 13);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(145, 32);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.ForeColor = System.Drawing.Color.Red;
            this.btnDetener.Location = new System.Drawing.Point(376, 51);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(145, 32);
            this.btnDetener.TabIndex = 2;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.ForeColor = System.Drawing.Color.Blue;
            this.btnCapturar.Location = new System.Drawing.Point(376, 89);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(145, 32);
            this.btnCapturar.TabIndex = 3;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // lblDectMov
            // 
            this.lblDectMov.AutoSize = true;
            this.lblDectMov.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDectMov.Location = new System.Drawing.Point(373, 135);
            this.lblDectMov.Name = "lblDectMov";
            this.lblDectMov.Size = new System.Drawing.Size(137, 13);
            this.lblDectMov.TabIndex = 5;
            this.lblDectMov.Text = "Detencción de Movimiento:";
            // 
            // txtDetcMov
            // 
            this.txtDetcMov.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetcMov.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDetcMov.Location = new System.Drawing.Point(376, 167);
            this.txtDetcMov.Name = "txtDetcMov";
            this.txtDetcMov.Size = new System.Drawing.Size(145, 24);
            this.txtDetcMov.TabIndex = 6;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(376, 239);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(145, 106);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 7;
            this.pbLogo.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(376, 197);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(145, 32);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // vspCamara
            // 
            this.vspCamara.Location = new System.Drawing.Point(12, 51);
            this.vspCamara.Name = "vspCamara";
            this.vspCamara.Size = new System.Drawing.Size(345, 294);
            this.vspCamara.TabIndex = 9;
            this.vspCamara.VideoSource = null;
            this.vspCamara.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.vspCamara_NewFrame);
            // 
            // tiempo
            // 
            this.tiempo.Enabled = true;
            this.tiempo.Interval = 10;
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // gbTiposDetec
            // 
            this.gbTiposDetec.Controls.Add(this.lblDetecccion);
            this.gbTiposDetec.Controls.Add(this.lblDetenccion2);
            this.gbTiposDetec.Controls.Add(this.lblDetenccion1);
            this.gbTiposDetec.Controls.Add(this.rbDetector9);
            this.gbTiposDetec.Controls.Add(this.rbDetector10);
            this.gbTiposDetec.Controls.Add(this.rbDetector7);
            this.gbTiposDetec.Controls.Add(this.rbDetector12);
            this.gbTiposDetec.Controls.Add(this.rbDetector4);
            this.gbTiposDetec.Controls.Add(this.rbDetector11);
            this.gbTiposDetec.Controls.Add(this.rbDetector5);
            this.gbTiposDetec.Controls.Add(this.rbDetector6);
            this.gbTiposDetec.Controls.Add(this.rbDetector3);
            this.gbTiposDetec.Controls.Add(this.rbDetector8);
            this.gbTiposDetec.Controls.Add(this.rbDetector2);
            this.gbTiposDetec.Controls.Add(this.rbDetector1);
            this.gbTiposDetec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbTiposDetec.Location = new System.Drawing.Point(540, 12);
            this.gbTiposDetec.Name = "gbTiposDetec";
            this.gbTiposDetec.Size = new System.Drawing.Size(319, 333);
            this.gbTiposDetec.TabIndex = 10;
            this.gbTiposDetec.TabStop = false;
            this.gbTiposDetec.Text = "Tipos de Detencción";
            // 
            // lblDetecccion
            // 
            this.lblDetecccion.AutoSize = true;
            this.lblDetecccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDetecccion.Location = new System.Drawing.Point(6, 225);
            this.lblDetecccion.Name = "lblDetecccion";
            this.lblDetecccion.Size = new System.Drawing.Size(306, 26);
            this.lblDetecccion.TabIndex = 14;
            this.lblDetecccion.Text = "El detector de movimiento basado en dos continúa la diferencia\r\nde cuadros:\r\n";
            // 
            // lblDetenccion2
            // 
            this.lblDetenccion2.AutoSize = true;
            this.lblDetenccion2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDetenccion2.Location = new System.Drawing.Point(6, 139);
            this.lblDetenccion2.Name = "lblDetenccion2";
            this.lblDetenccion2.Size = new System.Drawing.Size(301, 13);
            this.lblDetenccion2.TabIndex = 13;
            this.lblDetenccion2.Text = "Detector de movimiento basado en modelado de fondo simple:\r\n";
            // 
            // lblDetenccion1
            // 
            this.lblDetenccion1.AutoSize = true;
            this.lblDetenccion1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDetenccion1.Location = new System.Drawing.Point(6, 28);
            this.lblDetenccion1.Name = "lblDetenccion1";
            this.lblDetenccion1.Size = new System.Drawing.Size(299, 26);
            this.lblDetenccion1.TabIndex = 12;
            this.lblDetenccion1.Text = "Detector de movimiento basado en la diferencia con el marco \r\nde fondo predefinid" +
    "o:\r\n";
            // 
            // rbDetector9
            // 
            this.rbDetector9.AutoSize = true;
            this.rbDetector9.Location = new System.Drawing.Point(9, 267);
            this.rbDetector9.Name = "rbDetector9";
            this.rbDetector9.Size = new System.Drawing.Size(83, 17);
            this.rbDetector9.TabIndex = 8;
            this.rbDetector9.TabStop = true;
            this.rbDetector9.Text = "Detección 9";
            this.rbDetector9.UseVisualStyleBackColor = true;
            // 
            // rbDetector10
            // 
            this.rbDetector10.AutoSize = true;
            this.rbDetector10.Location = new System.Drawing.Point(98, 267);
            this.rbDetector10.Name = "rbDetector10";
            this.rbDetector10.Size = new System.Drawing.Size(89, 17);
            this.rbDetector10.TabIndex = 9;
            this.rbDetector10.TabStop = true;
            this.rbDetector10.Text = "Detección 10";
            this.rbDetector10.UseVisualStyleBackColor = true;
            // 
            // rbDetector7
            // 
            this.rbDetector7.AutoSize = true;
            this.rbDetector7.Location = new System.Drawing.Point(187, 162);
            this.rbDetector7.Name = "rbDetector7";
            this.rbDetector7.Size = new System.Drawing.Size(83, 17);
            this.rbDetector7.TabIndex = 6;
            this.rbDetector7.TabStop = true;
            this.rbDetector7.Text = "Detección 7";
            this.rbDetector7.UseVisualStyleBackColor = true;
            // 
            // rbDetector12
            // 
            this.rbDetector12.AutoSize = true;
            this.rbDetector12.Location = new System.Drawing.Point(9, 290);
            this.rbDetector12.Name = "rbDetector12";
            this.rbDetector12.Size = new System.Drawing.Size(89, 17);
            this.rbDetector12.TabIndex = 11;
            this.rbDetector12.TabStop = true;
            this.rbDetector12.Text = "Detección 12";
            this.rbDetector12.UseVisualStyleBackColor = true;
            // 
            // rbDetector4
            // 
            this.rbDetector4.AutoSize = true;
            this.rbDetector4.Location = new System.Drawing.Point(9, 90);
            this.rbDetector4.Name = "rbDetector4";
            this.rbDetector4.Size = new System.Drawing.Size(83, 17);
            this.rbDetector4.TabIndex = 3;
            this.rbDetector4.TabStop = true;
            this.rbDetector4.Text = "Detección 4";
            this.rbDetector4.UseVisualStyleBackColor = true;
            // 
            // rbDetector11
            // 
            this.rbDetector11.AutoSize = true;
            this.rbDetector11.Location = new System.Drawing.Point(193, 267);
            this.rbDetector11.Name = "rbDetector11";
            this.rbDetector11.Size = new System.Drawing.Size(89, 17);
            this.rbDetector11.TabIndex = 10;
            this.rbDetector11.TabStop = true;
            this.rbDetector11.Text = "Detección 11";
            this.rbDetector11.UseVisualStyleBackColor = true;
            // 
            // rbDetector5
            // 
            this.rbDetector5.AutoSize = true;
            this.rbDetector5.Location = new System.Drawing.Point(12, 162);
            this.rbDetector5.Name = "rbDetector5";
            this.rbDetector5.Size = new System.Drawing.Size(83, 17);
            this.rbDetector5.TabIndex = 4;
            this.rbDetector5.TabStop = true;
            this.rbDetector5.Text = "Detección 5";
            this.rbDetector5.UseVisualStyleBackColor = true;
            // 
            // rbDetector6
            // 
            this.rbDetector6.AutoSize = true;
            this.rbDetector6.Location = new System.Drawing.Point(101, 162);
            this.rbDetector6.Name = "rbDetector6";
            this.rbDetector6.Size = new System.Drawing.Size(83, 17);
            this.rbDetector6.TabIndex = 5;
            this.rbDetector6.TabStop = true;
            this.rbDetector6.Text = "Detección 6";
            this.rbDetector6.UseVisualStyleBackColor = true;
            // 
            // rbDetector3
            // 
            this.rbDetector3.AutoSize = true;
            this.rbDetector3.Location = new System.Drawing.Point(187, 67);
            this.rbDetector3.Name = "rbDetector3";
            this.rbDetector3.Size = new System.Drawing.Size(83, 17);
            this.rbDetector3.TabIndex = 2;
            this.rbDetector3.TabStop = true;
            this.rbDetector3.Text = "Detección 3";
            this.rbDetector3.UseVisualStyleBackColor = true;
            // 
            // rbDetector8
            // 
            this.rbDetector8.AutoSize = true;
            this.rbDetector8.Location = new System.Drawing.Point(12, 185);
            this.rbDetector8.Name = "rbDetector8";
            this.rbDetector8.Size = new System.Drawing.Size(83, 17);
            this.rbDetector8.TabIndex = 7;
            this.rbDetector8.TabStop = true;
            this.rbDetector8.Text = "Detección 8";
            this.rbDetector8.UseVisualStyleBackColor = true;
            // 
            // rbDetector2
            // 
            this.rbDetector2.AutoSize = true;
            this.rbDetector2.Location = new System.Drawing.Point(98, 67);
            this.rbDetector2.Name = "rbDetector2";
            this.rbDetector2.Size = new System.Drawing.Size(83, 17);
            this.rbDetector2.TabIndex = 1;
            this.rbDetector2.TabStop = true;
            this.rbDetector2.Text = "Detección 2";
            this.rbDetector2.UseVisualStyleBackColor = true;
            // 
            // rbDetector1
            // 
            this.rbDetector1.AutoSize = true;
            this.rbDetector1.Checked = true;
            this.rbDetector1.Location = new System.Drawing.Point(9, 67);
            this.rbDetector1.Name = "rbDetector1";
            this.rbDetector1.Size = new System.Drawing.Size(83, 17);
            this.rbDetector1.TabIndex = 0;
            this.rbDetector1.TabStop = true;
            this.rbDetector1.Text = "Detección 1";
            this.rbDetector1.UseVisualStyleBackColor = true;
            // 
            // pbCamaraColor
            // 
            this.pbCamaraColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbCamaraColor.Location = new System.Drawing.Point(12, 51);
            this.pbCamaraColor.Name = "pbCamaraColor";
            this.pbCamaraColor.Size = new System.Drawing.Size(345, 295);
            this.pbCamaraColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCamaraColor.TabIndex = 11;
            this.pbCamaraColor.TabStop = false;
            // 
            // tcMenu
            // 
            this.tcMenu.Controls.Add(this.tpDetcMov);
            this.tcMenu.Controls.Add(this.tpReconicimientoColor);
            this.tcMenu.Location = new System.Drawing.Point(0, -1);
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.SelectedIndex = 0;
            this.tcMenu.Size = new System.Drawing.Size(879, 378);
            this.tcMenu.TabIndex = 12;
            // 
            // tpDetcMov
            // 
            this.tpDetcMov.Controls.Add(this.vspCamara);
            this.tpDetcMov.Controls.Add(this.cbCamara);
            this.tpDetcMov.Controls.Add(this.gbTiposDetec);
            this.tpDetcMov.Controls.Add(this.btnIniciar);
            this.tpDetcMov.Controls.Add(this.btnDetener);
            this.tpDetcMov.Controls.Add(this.btnSalir);
            this.tpDetcMov.Controls.Add(this.btnCapturar);
            this.tpDetcMov.Controls.Add(this.pbLogo);
            this.tpDetcMov.Controls.Add(this.lblDectMov);
            this.tpDetcMov.Controls.Add(this.txtDetcMov);
            this.tpDetcMov.Location = new System.Drawing.Point(4, 22);
            this.tpDetcMov.Name = "tpDetcMov";
            this.tpDetcMov.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetcMov.Size = new System.Drawing.Size(871, 352);
            this.tpDetcMov.TabIndex = 0;
            this.tpDetcMov.Text = "Detencción de Movimiento";
            this.tpDetcMov.UseVisualStyleBackColor = true;
            // 
            // tpReconicimientoColor
            // 
            this.tpReconicimientoColor.Controls.Add(this.cbCamaraColor);
            this.tpReconicimientoColor.Controls.Add(this.cbActivarColor);
            this.tpReconicimientoColor.Controls.Add(this.gbColor);
            this.tpReconicimientoColor.Controls.Add(this.pbCamaraColor);
            this.tpReconicimientoColor.Location = new System.Drawing.Point(4, 22);
            this.tpReconicimientoColor.Name = "tpReconicimientoColor";
            this.tpReconicimientoColor.Padding = new System.Windows.Forms.Padding(3);
            this.tpReconicimientoColor.Size = new System.Drawing.Size(871, 352);
            this.tpReconicimientoColor.TabIndex = 1;
            this.tpReconicimientoColor.Text = "Reconocimiento de Color";
            this.tpReconicimientoColor.UseVisualStyleBackColor = true;
            // 
            // cbCamaraColor
            // 
            this.cbCamaraColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCamaraColor.FormattingEnabled = true;
            this.cbCamaraColor.Location = new System.Drawing.Point(12, 13);
            this.cbCamaraColor.Name = "cbCamaraColor";
            this.cbCamaraColor.Size = new System.Drawing.Size(345, 24);
            this.cbCamaraColor.TabIndex = 17;
            // 
            // cbActivarColor
            // 
            this.cbActivarColor.AutoSize = true;
            this.cbActivarColor.Location = new System.Drawing.Point(379, 17);
            this.cbActivarColor.Name = "cbActivarColor";
            this.cbActivarColor.Size = new System.Drawing.Size(181, 17);
            this.cbActivarColor.TabIndex = 16;
            this.cbActivarColor.Text = "Activar Reconocimiento de Color";
            this.cbActivarColor.UseVisualStyleBackColor = true;
            this.cbActivarColor.CheckedChanged += new System.EventHandler(this.cbActivarColor_CheckedChanged);
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.gbTipoVision);
            this.gbColor.Controls.Add(this.btnSalirColor);
            this.gbColor.Controls.Add(this.btnColor);
            this.gbColor.Controls.Add(this.pbLogo1);
            this.gbColor.Controls.Add(this.btnIniciarColor);
            this.gbColor.Controls.Add(this.btnCapturarColor);
            this.gbColor.Controls.Add(this.btnDetenerColor);
            this.gbColor.Location = new System.Drawing.Point(379, 43);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(477, 303);
            this.gbColor.TabIndex = 15;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Reconocimiento de Color";
            // 
            // gbTipoVision
            // 
            this.gbTipoVision.Controls.Add(this.pictureBox3);
            this.gbTipoVision.Controls.Add(this.pictureBox2);
            this.gbTipoVision.Controls.Add(this.rbNegro);
            this.gbTipoVision.Controls.Add(this.rbOriginal);
            this.gbTipoVision.Location = new System.Drawing.Point(169, 121);
            this.gbTipoVision.Name = "gbTipoVision";
            this.gbTipoVision.Size = new System.Drawing.Size(291, 157);
            this.gbTipoVision.TabIndex = 25;
            this.gbTipoVision.TabStop = false;
            this.gbTipoVision.Text = "Tipo de Visión";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(157, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 91);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // rbNegro
            // 
            this.rbNegro.AutoSize = true;
            this.rbNegro.Location = new System.Drawing.Point(163, 31);
            this.rbNegro.Name = "rbNegro";
            this.rbNegro.Size = new System.Drawing.Size(78, 17);
            this.rbNegro.TabIndex = 1;
            this.rbNegro.Text = "Visión Filtro";
            this.rbNegro.UseVisualStyleBackColor = true;
            // 
            // rbOriginal
            // 
            this.rbOriginal.AutoSize = true;
            this.rbOriginal.Checked = true;
            this.rbOriginal.Location = new System.Drawing.Point(48, 31);
            this.rbOriginal.Name = "rbOriginal";
            this.rbOriginal.Size = new System.Drawing.Size(91, 17);
            this.rbOriginal.TabIndex = 0;
            this.rbOriginal.TabStop = true;
            this.rbOriginal.Text = "Visión Original";
            this.rbOriginal.UseVisualStyleBackColor = true;
            // 
            // btnSalirColor
            // 
            this.btnSalirColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirColor.Location = new System.Drawing.Point(18, 143);
            this.btnSalirColor.Name = "btnSalirColor";
            this.btnSalirColor.Size = new System.Drawing.Size(145, 32);
            this.btnSalirColor.TabIndex = 24;
            this.btnSalirColor.Text = "Salir";
            this.btnSalirColor.UseVisualStyleBackColor = true;
            this.btnSalirColor.Click += new System.EventHandler(this.btnSalirColor_Click);
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(169, 29);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(291, 86);
            this.btnColor.TabIndex = 11;
            this.btnColor.Text = "Elegir Colores";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // pbLogo1
            // 
            this.pbLogo1.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo1.Image")));
            this.pbLogo1.Location = new System.Drawing.Point(18, 191);
            this.pbLogo1.Name = "pbLogo1";
            this.pbLogo1.Size = new System.Drawing.Size(145, 106);
            this.pbLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo1.TabIndex = 23;
            this.pbLogo1.TabStop = false;
            // 
            // btnIniciarColor
            // 
            this.btnIniciarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarColor.ForeColor = System.Drawing.Color.Green;
            this.btnIniciarColor.Location = new System.Drawing.Point(18, 29);
            this.btnIniciarColor.Name = "btnIniciarColor";
            this.btnIniciarColor.Size = new System.Drawing.Size(145, 32);
            this.btnIniciarColor.TabIndex = 18;
            this.btnIniciarColor.Text = "Iniciar";
            this.btnIniciarColor.UseVisualStyleBackColor = true;
            this.btnIniciarColor.Click += new System.EventHandler(this.btnIniciarColor_Click);
            // 
            // btnCapturarColor
            // 
            this.btnCapturarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturarColor.ForeColor = System.Drawing.Color.Blue;
            this.btnCapturarColor.Location = new System.Drawing.Point(18, 105);
            this.btnCapturarColor.Name = "btnCapturarColor";
            this.btnCapturarColor.Size = new System.Drawing.Size(145, 32);
            this.btnCapturarColor.TabIndex = 20;
            this.btnCapturarColor.Text = "Capturar";
            this.btnCapturarColor.UseVisualStyleBackColor = true;
            this.btnCapturarColor.Click += new System.EventHandler(this.btnCapturarColor_Click);
            // 
            // btnDetenerColor
            // 
            this.btnDetenerColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetenerColor.ForeColor = System.Drawing.Color.Red;
            this.btnDetenerColor.Location = new System.Drawing.Point(18, 67);
            this.btnDetenerColor.Name = "btnDetenerColor";
            this.btnDetenerColor.Size = new System.Drawing.Size(145, 32);
            this.btnDetenerColor.TabIndex = 19;
            this.btnDetenerColor.Text = "Detener";
            this.btnDetenerColor.UseVisualStyleBackColor = true;
            this.btnDetenerColor.Click += new System.EventHandler(this.btnDetenerColor_Click);
            // 
            // DeteMov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 384);
            this.Controls.Add(this.tcMenu);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DeteMov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detección de Movimiento y Reconocimiento de Color";
            this.Load += new System.EventHandler(this.DeteMov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbTiposDetec.ResumeLayout(false);
            this.gbTiposDetec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamaraColor)).EndInit();
            this.tcMenu.ResumeLayout(false);
            this.tpDetcMov.ResumeLayout(false);
            this.tpDetcMov.PerformLayout();
            this.tpReconicimientoColor.ResumeLayout(false);
            this.tpReconicimientoColor.PerformLayout();
            this.gbColor.ResumeLayout(false);
            this.gbTipoVision.ResumeLayout(false);
            this.gbTipoVision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCamara;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Label lblDectMov;
        private System.Windows.Forms.TextBox txtDetcMov;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnSalir;
        private AForge.Controls.VideoSourcePlayer vspCamara;
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.GroupBox gbTiposDetec;
        private System.Windows.Forms.RadioButton rbDetector12;
        private System.Windows.Forms.RadioButton rbDetector11;
        private System.Windows.Forms.RadioButton rbDetector10;
        private System.Windows.Forms.RadioButton rbDetector9;
        private System.Windows.Forms.RadioButton rbDetector8;
        private System.Windows.Forms.RadioButton rbDetector7;
        private System.Windows.Forms.RadioButton rbDetector6;
        private System.Windows.Forms.RadioButton rbDetector5;
        private System.Windows.Forms.RadioButton rbDetector4;
        private System.Windows.Forms.RadioButton rbDetector3;
        private System.Windows.Forms.RadioButton rbDetector2;
        private System.Windows.Forms.RadioButton rbDetector1;
        private System.Windows.Forms.PictureBox pbCamaraColor;
        private System.Windows.Forms.Label lblDetecccion;
        private System.Windows.Forms.Label lblDetenccion2;
        private System.Windows.Forms.Label lblDetenccion1;
        private System.Windows.Forms.TabControl tcMenu;
        private System.Windows.Forms.TabPage tpDetcMov;
        private System.Windows.Forms.TabPage tpReconicimientoColor;
        private System.Windows.Forms.CheckBox cbActivarColor;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnSalirColor;
        private System.Windows.Forms.PictureBox pbLogo1;
        private System.Windows.Forms.ComboBox cbCamaraColor;
        private System.Windows.Forms.Button btnIniciarColor;
        private System.Windows.Forms.Button btnDetenerColor;
        private System.Windows.Forms.Button btnCapturarColor;
        private System.Windows.Forms.ColorDialog colorD;
        private System.Windows.Forms.GroupBox gbTipoVision;
        private System.Windows.Forms.RadioButton rbNegro;
        private System.Windows.Forms.RadioButton rbOriginal;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

