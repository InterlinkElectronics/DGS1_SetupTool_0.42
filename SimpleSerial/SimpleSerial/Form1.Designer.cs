namespace SimpleSerial
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonStartUART = new System.Windows.Forms.Button();
            this.buttonStopUART = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.buttonRead = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelCOMPort = new System.Windows.Forms.Label();
            this.buttonZero = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonEEPROM = new System.Windows.Forms.Button();
            this.buttonBarCode = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelPPB = new System.Windows.Forms.Label();
            this.buttonContinuousRead = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonAveraging = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonReadLMP = new System.Windows.Forms.Button();
            this.buttonSpan = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStartUART
            // 
            this.buttonStartUART.BackColor = System.Drawing.Color.Maroon;
            this.buttonStartUART.ForeColor = System.Drawing.Color.White;
            this.buttonStartUART.Location = new System.Drawing.Point(118, 12);
            this.buttonStartUART.Name = "buttonStartUART";
            this.buttonStartUART.Size = new System.Drawing.Size(100, 23);
            this.buttonStartUART.TabIndex = 0;
            this.buttonStartUART.Text = "Open COM Port";
            this.buttonStartUART.UseVisualStyleBackColor = false;
            this.buttonStartUART.Click += new System.EventHandler(this.buttonStartUART_Click);
            // 
            // buttonStopUART
            // 
            this.buttonStopUART.BackColor = System.Drawing.Color.Maroon;
            this.buttonStopUART.Enabled = false;
            this.buttonStopUART.ForeColor = System.Drawing.Color.White;
            this.buttonStopUART.Location = new System.Drawing.Point(12, 12);
            this.buttonStopUART.Name = "buttonStopUART";
            this.buttonStopUART.Size = new System.Drawing.Size(100, 23);
            this.buttonStopUART.TabIndex = 1;
            this.buttonStopUART.Text = "Close COM Port";
            this.buttonStopUART.UseVisualStyleBackColor = false;
            this.buttonStopUART.Click += new System.EventHandler(this.buttonStopUART_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 186);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(418, 373);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM16";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // buttonRead
            // 
            this.buttonRead.BackColor = System.Drawing.Color.Maroon;
            this.buttonRead.ForeColor = System.Drawing.Color.White;
            this.buttonRead.Location = new System.Drawing.Point(224, 157);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(100, 23);
            this.buttonRead.TabIndex = 17;
            this.buttonRead.Text = "Read Sensor";
            this.buttonRead.UseVisualStyleBackColor = false;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(224, 15);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown1.TabIndex = 39;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelCOMPort
            // 
            this.labelCOMPort.AutoSize = true;
            this.labelCOMPort.Location = new System.Drawing.Point(280, 17);
            this.labelCOMPort.Name = "labelCOMPort";
            this.labelCOMPort.Size = new System.Drawing.Size(53, 13);
            this.labelCOMPort.TabIndex = 40;
            this.labelCOMPort.Text = "COM Port";
            // 
            // buttonZero
            // 
            this.buttonZero.BackColor = System.Drawing.Color.Maroon;
            this.buttonZero.ForeColor = System.Drawing.Color.White;
            this.buttonZero.Location = new System.Drawing.Point(12, 99);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(100, 23);
            this.buttonZero.TabIndex = 34;
            this.buttonZero.Text = "Set Zero";
            this.buttonZero.UseVisualStyleBackColor = false;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonEEPROM
            // 
            this.buttonEEPROM.BackColor = System.Drawing.Color.Maroon;
            this.buttonEEPROM.ForeColor = System.Drawing.Color.White;
            this.buttonEEPROM.Location = new System.Drawing.Point(12, 157);
            this.buttonEEPROM.Name = "buttonEEPROM";
            this.buttonEEPROM.Size = new System.Drawing.Size(100, 23);
            this.buttonEEPROM.TabIndex = 41;
            this.buttonEEPROM.Text = "Read EEPROM";
            this.buttonEEPROM.UseVisualStyleBackColor = false;
            this.buttonEEPROM.Click += new System.EventHandler(this.buttonEEPROM_Click);
            // 
            // buttonBarCode
            // 
            this.buttonBarCode.BackColor = System.Drawing.Color.Maroon;
            this.buttonBarCode.ForeColor = System.Drawing.Color.White;
            this.buttonBarCode.Location = new System.Drawing.Point(12, 41);
            this.buttonBarCode.Name = "buttonBarCode";
            this.buttonBarCode.Size = new System.Drawing.Size(100, 23);
            this.buttonBarCode.TabIndex = 42;
            this.buttonBarCode.Text = "Set Barcode";
            this.buttonBarCode.UseVisualStyleBackColor = false;
            this.buttonBarCode.Click += new System.EventHandler(this.buttonBarCode_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(312, 20);
            this.textBox2.TabIndex = 43;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(898, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 20);
            this.textBox3.TabIndex = 44;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // labelPPB
            // 
            this.labelPPB.AutoSize = true;
            this.labelPPB.Location = new System.Drawing.Point(954, 17);
            this.labelPPB.Name = "labelPPB";
            this.labelPPB.Size = new System.Drawing.Size(28, 13);
            this.labelPPB.TabIndex = 45;
            this.labelPPB.Text = "PPB";
            // 
            // buttonContinuousRead
            // 
            this.buttonContinuousRead.BackColor = System.Drawing.Color.Maroon;
            this.buttonContinuousRead.ForeColor = System.Drawing.Color.White;
            this.buttonContinuousRead.Location = new System.Drawing.Point(441, 12);
            this.buttonContinuousRead.Name = "buttonContinuousRead";
            this.buttonContinuousRead.Size = new System.Drawing.Size(451, 23);
            this.buttonContinuousRead.TabIndex = 46;
            this.buttonContinuousRead.Text = "Continuous Read and Log to C:\\Users\\Public\\Public Documents\\KWJ";
            this.buttonContinuousRead.UseVisualStyleBackColor = false;
            this.buttonContinuousRead.Click += new System.EventHandler(this.buttonContinuousRead_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(441, 41);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "PPB";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(541, 518);
            this.chart1.TabIndex = 47;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // buttonAveraging
            // 
            this.buttonAveraging.BackColor = System.Drawing.Color.Maroon;
            this.buttonAveraging.ForeColor = System.Drawing.Color.White;
            this.buttonAveraging.Location = new System.Drawing.Point(12, 70);
            this.buttonAveraging.Name = "buttonAveraging";
            this.buttonAveraging.Size = new System.Drawing.Size(100, 23);
            this.buttonAveraging.TabIndex = 48;
            this.buttonAveraging.Text = "Set Average";
            this.buttonAveraging.UseVisualStyleBackColor = false;
            this.buttonAveraging.Click += new System.EventHandler(this.buttonAveraging_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(118, 72);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 49;
            // 
            // buttonReadLMP
            // 
            this.buttonReadLMP.BackColor = System.Drawing.Color.Maroon;
            this.buttonReadLMP.ForeColor = System.Drawing.Color.White;
            this.buttonReadLMP.Location = new System.Drawing.Point(118, 157);
            this.buttonReadLMP.Name = "buttonReadLMP";
            this.buttonReadLMP.Size = new System.Drawing.Size(100, 23);
            this.buttonReadLMP.TabIndex = 50;
            this.buttonReadLMP.Text = "Read LMP";
            this.buttonReadLMP.UseVisualStyleBackColor = false;
            this.buttonReadLMP.Click += new System.EventHandler(this.buttonReadLMP_Click);
            // 
            // buttonSpan
            // 
            this.buttonSpan.BackColor = System.Drawing.Color.Maroon;
            this.buttonSpan.ForeColor = System.Drawing.Color.White;
            this.buttonSpan.Location = new System.Drawing.Point(12, 128);
            this.buttonSpan.Name = "buttonSpan";
            this.buttonSpan.Size = new System.Drawing.Size(100, 23);
            this.buttonSpan.TabIndex = 51;
            this.buttonSpan.Text = "Set Span";
            this.buttonSpan.UseVisualStyleBackColor = false;
            this.buttonSpan.Click += new System.EventHandler(this.buttonSpan_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(118, 130);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "(1-300)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "PPM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(994, 571);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.buttonSpan);
            this.Controls.Add(this.buttonReadLMP);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.buttonAveraging);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonContinuousRead);
            this.Controls.Add(this.labelPPB);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonBarCode);
            this.Controls.Add(this.buttonEEPROM);
            this.Controls.Add(this.labelCOMPort);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonStartUART);
            this.Controls.Add(this.buttonStopUART);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonRead);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPEC DSDK Tool v0.42";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartUART;
        private System.Windows.Forms.Button buttonStopUART;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelCOMPort;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonEEPROM;
        private System.Windows.Forms.Button buttonBarCode;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelPPB;
        private System.Windows.Forms.Button buttonContinuousRead;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonAveraging;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonReadLMP;
        private System.Windows.Forms.Button buttonSpan;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

