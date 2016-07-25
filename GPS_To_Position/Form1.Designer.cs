namespace GPS_To_Position
{
    partial class Form1
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
            this.TextGPS = new System.Windows.Forms.RichTextBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.combo_COMS = new System.Windows.Forms.ComboBox();
            this.textB_Baudios = new System.Windows.Forms.TextBox();
            this.textB_Lat = new System.Windows.Forms.TextBox();
            this.textB_Long = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextGPS
            // 
            this.TextGPS.EnableAutoDragDrop = true;
            this.TextGPS.Location = new System.Drawing.Point(300, 28);
            this.TextGPS.Name = "TextGPS";
            this.TextGPS.Size = new System.Drawing.Size(379, 207);
            this.TextGPS.TabIndex = 0;
            this.TextGPS.Text = "";
            this.TextGPS.TextChanged += new System.EventHandler(this.TextGPS_TextChanged);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(12, 12);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(75, 23);
            this.button_Connect.TabIndex = 1;
            this.button_Connect.Text = "Conect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // combo_COMS
            // 
            this.combo_COMS.FormattingEnabled = true;
            this.combo_COMS.Location = new System.Drawing.Point(108, 14);
            this.combo_COMS.Name = "combo_COMS";
            this.combo_COMS.Size = new System.Drawing.Size(70, 21);
            this.combo_COMS.TabIndex = 2;
            // 
            // textB_Baudios
            // 
            this.textB_Baudios.Location = new System.Drawing.Point(198, 15);
            this.textB_Baudios.Name = "textB_Baudios";
            this.textB_Baudios.Size = new System.Drawing.Size(70, 20);
            this.textB_Baudios.TabIndex = 3;
            this.textB_Baudios.Text = "9600";
            // 
            // textB_Lat
            // 
            this.textB_Lat.Location = new System.Drawing.Point(108, 119);
            this.textB_Lat.Name = "textB_Lat";
            this.textB_Lat.Size = new System.Drawing.Size(100, 20);
            this.textB_Lat.TabIndex = 4;
            // 
            // textB_Long
            // 
            this.textB_Long.Location = new System.Drawing.Point(108, 156);
            this.textB_Long.Name = "textB_Long";
            this.textB_Long.Size = new System.Drawing.Size(100, 20);
            this.textB_Long.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Latitud";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Longitd";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 266);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textB_Long);
            this.Controls.Add(this.textB_Lat);
            this.Controls.Add(this.textB_Baudios);
            this.Controls.Add(this.combo_COMS);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.TextGPS);
            this.Name = "Form1";
            this.Text = "GPS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextGPS;
        private System.Windows.Forms.Button button_Connect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox combo_COMS;
        private System.Windows.Forms.TextBox textB_Baudios;
        private System.Windows.Forms.TextBox textB_Lat;
        private System.Windows.Forms.TextBox textB_Long;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

