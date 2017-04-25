namespace ZamanlanmisGorev.UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GorevPanel = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SiraText = new System.Windows.Forms.TextBox();
            this.DosyaSecButton = new System.Windows.Forms.Button();
            this.PazarCheck = new System.Windows.Forms.CheckBox();
            this.CumartesiCheck = new System.Windows.Forms.CheckBox();
            this.CumaCheck = new System.Windows.Forms.CheckBox();
            this.PersembeCheck = new System.Windows.Forms.CheckBox();
            this.CarsambaCheck = new System.Windows.Forms.CheckBox();
            this.SaliCheck = new System.Windows.Forms.CheckBox();
            this.PazartesiCheck = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.KapanisSaatiTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.AcilisSaatiTimePicker = new System.Windows.Forms.DateTimePicker();
            this.OncesiniKapatCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ParamterelerText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UygulamaText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AdText = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GorevPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(654, 127);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // GorevPanel
            // 
            this.GorevPanel.Controls.Add(this.label6);
            this.GorevPanel.Controls.Add(this.SiraText);
            this.GorevPanel.Controls.Add(this.DosyaSecButton);
            this.GorevPanel.Controls.Add(this.PazarCheck);
            this.GorevPanel.Controls.Add(this.CumartesiCheck);
            this.GorevPanel.Controls.Add(this.CumaCheck);
            this.GorevPanel.Controls.Add(this.PersembeCheck);
            this.GorevPanel.Controls.Add(this.CarsambaCheck);
            this.GorevPanel.Controls.Add(this.SaliCheck);
            this.GorevPanel.Controls.Add(this.PazartesiCheck);
            this.GorevPanel.Controls.Add(this.label5);
            this.GorevPanel.Controls.Add(this.KapanisSaatiTimePicker);
            this.GorevPanel.Controls.Add(this.label4);
            this.GorevPanel.Controls.Add(this.AcilisSaatiTimePicker);
            this.GorevPanel.Controls.Add(this.OncesiniKapatCheck);
            this.GorevPanel.Controls.Add(this.label3);
            this.GorevPanel.Controls.Add(this.ParamterelerText);
            this.GorevPanel.Controls.Add(this.label2);
            this.GorevPanel.Controls.Add(this.UygulamaText);
            this.GorevPanel.Controls.Add(this.label1);
            this.GorevPanel.Controls.Add(this.AdText);
            this.GorevPanel.Enabled = false;
            this.GorevPanel.Location = new System.Drawing.Point(12, 145);
            this.GorevPanel.Name = "GorevPanel";
            this.GorevPanel.Size = new System.Drawing.Size(654, 114);
            this.GorevPanel.TabIndex = 2;
            this.GorevPanel.TabStop = false;
            this.GorevPanel.Text = "groupBox1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(571, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Sıra:";
            // 
            // SiraText
            // 
            this.SiraText.Location = new System.Drawing.Point(605, 49);
            this.SiraText.Name = "SiraText";
            this.SiraText.Size = new System.Drawing.Size(22, 20);
            this.SiraText.TabIndex = 19;
            // 
            // DosyaSecButton
            // 
            this.DosyaSecButton.Location = new System.Drawing.Point(199, 45);
            this.DosyaSecButton.Name = "DosyaSecButton";
            this.DosyaSecButton.Size = new System.Drawing.Size(31, 23);
            this.DosyaSecButton.TabIndex = 18;
            this.DosyaSecButton.Text = "...";
            this.DosyaSecButton.UseVisualStyleBackColor = true;
            this.DosyaSecButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // PazarCheck
            // 
            this.PazarCheck.AutoSize = true;
            this.PazarCheck.Location = new System.Drawing.Point(574, 22);
            this.PazarCheck.Name = "PazarCheck";
            this.PazarCheck.Size = new System.Drawing.Size(53, 17);
            this.PazarCheck.TabIndex = 17;
            this.PazarCheck.Text = "Pazar";
            this.PazarCheck.UseVisualStyleBackColor = true;
            // 
            // CumartesiCheck
            // 
            this.CumartesiCheck.AutoSize = true;
            this.CumartesiCheck.Location = new System.Drawing.Point(495, 77);
            this.CumartesiCheck.Name = "CumartesiCheck";
            this.CumartesiCheck.Size = new System.Drawing.Size(72, 17);
            this.CumartesiCheck.TabIndex = 16;
            this.CumartesiCheck.Text = "Cumartesi";
            this.CumartesiCheck.UseVisualStyleBackColor = true;
            // 
            // CumaCheck
            // 
            this.CumaCheck.AutoSize = true;
            this.CumaCheck.Location = new System.Drawing.Point(495, 51);
            this.CumaCheck.Name = "CumaCheck";
            this.CumaCheck.Size = new System.Drawing.Size(53, 17);
            this.CumaCheck.TabIndex = 15;
            this.CumaCheck.Text = "Cuma";
            this.CumaCheck.UseVisualStyleBackColor = true;
            // 
            // PersembeCheck
            // 
            this.PersembeCheck.AutoSize = true;
            this.PersembeCheck.Location = new System.Drawing.Point(495, 22);
            this.PersembeCheck.Name = "PersembeCheck";
            this.PersembeCheck.Size = new System.Drawing.Size(73, 17);
            this.PersembeCheck.TabIndex = 14;
            this.PersembeCheck.Text = "Perşembe";
            this.PersembeCheck.UseVisualStyleBackColor = true;
            // 
            // CarsambaCheck
            // 
            this.CarsambaCheck.AutoSize = true;
            this.CarsambaCheck.Location = new System.Drawing.Point(420, 76);
            this.CarsambaCheck.Name = "CarsambaCheck";
            this.CarsambaCheck.Size = new System.Drawing.Size(73, 17);
            this.CarsambaCheck.TabIndex = 13;
            this.CarsambaCheck.Text = "Çarşamba";
            this.CarsambaCheck.UseVisualStyleBackColor = true;
            // 
            // SaliCheck
            // 
            this.SaliCheck.AutoSize = true;
            this.SaliCheck.Location = new System.Drawing.Point(420, 50);
            this.SaliCheck.Name = "SaliCheck";
            this.SaliCheck.Size = new System.Drawing.Size(43, 17);
            this.SaliCheck.TabIndex = 12;
            this.SaliCheck.Text = "Salı";
            this.SaliCheck.UseVisualStyleBackColor = true;
            // 
            // PazartesiCheck
            // 
            this.PazartesiCheck.AutoSize = true;
            this.PazartesiCheck.Location = new System.Drawing.Point(420, 21);
            this.PazartesiCheck.Name = "PazartesiCheck";
            this.PazartesiCheck.Size = new System.Drawing.Size(69, 17);
            this.PazartesiCheck.TabIndex = 11;
            this.PazartesiCheck.Text = "Pazartesi";
            this.PazartesiCheck.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kapanış Saati:";
            // 
            // KapanisSaatiTimePicker
            // 
            this.KapanisSaatiTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.KapanisSaatiTimePicker.Location = new System.Drawing.Point(313, 71);
            this.KapanisSaatiTimePicker.Name = "KapanisSaatiTimePicker";
            this.KapanisSaatiTimePicker.ShowUpDown = true;
            this.KapanisSaatiTimePicker.Size = new System.Drawing.Size(83, 20);
            this.KapanisSaatiTimePicker.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Açılış Saati:";
            // 
            // AcilisSaatiTimePicker
            // 
            this.AcilisSaatiTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.AcilisSaatiTimePicker.Location = new System.Drawing.Point(313, 45);
            this.AcilisSaatiTimePicker.Name = "AcilisSaatiTimePicker";
            this.AcilisSaatiTimePicker.ShowUpDown = true;
            this.AcilisSaatiTimePicker.Size = new System.Drawing.Size(83, 20);
            this.AcilisSaatiTimePicker.TabIndex = 7;
            // 
            // OncesiniKapatCheck
            // 
            this.OncesiniKapatCheck.AutoSize = true;
            this.OncesiniKapatCheck.Location = new System.Drawing.Point(237, 21);
            this.OncesiniKapatCheck.Name = "OncesiniKapatCheck";
            this.OncesiniKapatCheck.Size = new System.Drawing.Size(166, 17);
            this.OncesiniKapatCheck.TabIndex = 6;
            this.OncesiniKapatCheck.Text = "Açık Olan Uygulamaları Kapat";
            this.OncesiniKapatCheck.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parametreler:";
            // 
            // ParamterelerText
            // 
            this.ParamterelerText.Location = new System.Drawing.Point(93, 71);
            this.ParamterelerText.Name = "ParamterelerText";
            this.ParamterelerText.Size = new System.Drawing.Size(100, 20);
            this.ParamterelerText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Uygulama:";
            // 
            // UygulamaText
            // 
            this.UygulamaText.Location = new System.Drawing.Point(93, 45);
            this.UygulamaText.Name = "UygulamaText";
            this.UygulamaText.Size = new System.Drawing.Size(100, 20);
            this.UygulamaText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad:";
            // 
            // AdText
            // 
            this.AdText.Location = new System.Drawing.Point(93, 19);
            this.AdText.Name = "AdText";
            this.AdText.Size = new System.Drawing.Size(100, 20);
            this.AdText.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 26);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Yeni";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(170, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Kaydet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(249, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "İptal";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(328, 264);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Sil";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 295);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Açılışta Çalışsın";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(91, 264);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Düzenle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 315);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GorevPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(697, 354);
            this.MinimumSize = new System.Drawing.Size(697, 354);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zamanlanmış Görev";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GorevPanel.ResumeLayout(false);
            this.GorevPanel.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox GorevPanel;
        private System.Windows.Forms.CheckBox OncesiniKapatCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ParamterelerText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UygulamaText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker KapanisSaatiTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker AcilisSaatiTimePicker;
        private System.Windows.Forms.Button DosyaSecButton;
        private System.Windows.Forms.CheckBox PazarCheck;
        private System.Windows.Forms.CheckBox CumartesiCheck;
        private System.Windows.Forms.CheckBox CumaCheck;
        private System.Windows.Forms.CheckBox PersembeCheck;
        private System.Windows.Forms.CheckBox CarsambaCheck;
        private System.Windows.Forms.CheckBox SaliCheck;
        private System.Windows.Forms.CheckBox PazartesiCheck;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SiraText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.Button button6;
    }
}

