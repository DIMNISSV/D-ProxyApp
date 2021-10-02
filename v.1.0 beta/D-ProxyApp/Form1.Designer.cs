
namespace D_ProxyApp
{
    partial class MainFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.setBestBtn = new System.Windows.Forms.Button();
            this.setBtn = new System.Windows.Forms.Button();
            this.offBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.trayBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.proxy = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.exEdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SetExBtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // setBestBtn
            // 
            this.setBestBtn.BackColor = System.Drawing.Color.Transparent;
            this.setBestBtn.Location = new System.Drawing.Point(13, 12);
            this.setBestBtn.Name = "setBestBtn";
            this.setBestBtn.Size = new System.Drawing.Size(235, 159);
            this.setBestBtn.TabIndex = 0;
            this.setBestBtn.Text = "Лучший выбор (Автоматическая проверка и замена прокси)";
            this.setBestBtn.UseVisualStyleBackColor = false;
            this.setBestBtn.Click += new System.EventHandler(this.setBestBtn_Click);
            // 
            // setBtn
            // 
            this.setBtn.BackColor = System.Drawing.Color.Transparent;
            this.setBtn.Location = new System.Drawing.Point(12, 243);
            this.setBtn.Name = "setBtn";
            this.setBtn.Size = new System.Drawing.Size(235, 29);
            this.setBtn.TabIndex = 1;
            this.setBtn.Text = "Установить свой прокси";
            this.setBtn.UseVisualStyleBackColor = false;
            this.setBtn.Click += new System.EventHandler(this.setBtn_Click);
            // 
            // offBtn
            // 
            this.offBtn.BackColor = System.Drawing.Color.Transparent;
            this.offBtn.Location = new System.Drawing.Point(35, 177);
            this.offBtn.Name = "offBtn";
            this.offBtn.Size = new System.Drawing.Size(192, 29);
            this.offBtn.TabIndex = 2;
            this.offBtn.Text = "Выключить прокси";
            this.offBtn.UseVisualStyleBackColor = false;
            this.offBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(13, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Страна (Из двух букв например ru/kz/us. Так же можно через запятую (без пробелов)" +
    ", Например: ru,kz,us)";
            this.textBox1.Size = new System.Drawing.Size(88, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(153, 277);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(94, 29);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // trayBtn
            // 
            this.trayBtn.Location = new System.Drawing.Point(12, 277);
            this.trayBtn.Name = "trayBtn";
            this.trayBtn.Size = new System.Drawing.Size(85, 29);
            this.trayBtn.TabIndex = 6;
            this.trayBtn.Text = "В трей";
            this.trayBtn.UseVisualStyleBackColor = true;
            this.trayBtn.Click += new System.EventHandler(this.trayBtn_Click);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "   ";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "D-ProxyApp";
            this.notifyIcon1.Visible = true;
            // 
            // proxy
            // 
            this.proxy.Location = new System.Drawing.Point(12, 333);
            this.proxy.Name = "proxy";
            this.proxy.PlaceholderText = "socks=IP:PORT";
            this.proxy.Size = new System.Drawing.Size(235, 27);
            this.proxy.TabIndex = 8;
            this.proxy.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Исключения:";
            // 
            // exEdt
            // 
            this.exEdt.Location = new System.Drawing.Point(261, 36);
            this.exEdt.Multiline = true;
            this.exEdt.Name = "exEdt";
            this.exEdt.PlaceholderText = "Не использовать прокси";
            this.exEdt.Size = new System.Drawing.Size(108, 164);
            this.exEdt.TabIndex = 11;
            this.exEdt.Leave += new System.EventHandler(this.exEdt_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(261, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 90);
            this.label4.TabIndex = 12;
            this.label4.Text = "На этих сайтах\r\nне будет прокси\r\nРазделять \";\"\r\nПример:\r\ngoo.gl;whats.app;\r\nTAB  " +
    "- применить";
            // 
            // SetExBtn
            // 
            this.SetExBtn.Location = new System.Drawing.Point(107, 210);
            this.SetExBtn.Name = "SetExBtn";
            this.SetExBtn.Size = new System.Drawing.Size(140, 26);
            this.SetExBtn.TabIndex = 13;
            this.SetExBtn.Text = "Исключения";
            this.SetExBtn.UseVisualStyleBackColor = true;
            this.SetExBtn.Click += new System.EventHandler(this.SetExBtn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel1.Location = new System.Drawing.Point(103, 275);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(44, 30);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "сайт\r\nавтора";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(372, 402);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.SetExBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exEdt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.proxy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trayBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.offBtn);
            this.Controls.Add(this.setBtn);
            this.Controls.Add(this.setBestBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "D-ProxyApp";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setBestBtn;
        private System.Windows.Forms.Button setBtn;
        private System.Windows.Forms.Button offBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button trayBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox proxy;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox exEdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SetExBtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

