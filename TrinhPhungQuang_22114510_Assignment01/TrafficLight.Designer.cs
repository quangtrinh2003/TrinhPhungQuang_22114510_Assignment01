namespace TrinhPhungQuang_22114510_Assignment01
{
    partial class TrafficLight
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
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_general = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_ver = new System.Windows.Forms.TextBox();
            this.pnl_control = new System.Windows.Forms.Panel();
            this.spt_dark = new System.Windows.Forms.Splitter();
            this.txt_green = new System.Windows.Forms.TextBox();
            this.txt_yellow = new System.Windows.Forms.TextBox();
            this.txt_red = new System.Windows.Forms.TextBox();
            this.btn_green_off = new System.Windows.Forms.Button();
            this.btn_green_on = new System.Windows.Forms.Button();
            this.btn_yellow_off = new System.Windows.Forms.Button();
            this.btn_yellow_on = new System.Windows.Forms.Button();
            this.btn_red_off = new System.Windows.Forms.Button();
            this.btn_red_on = new System.Windows.Forms.Button();
            this.pnl_check = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnl_top.SuspendLayout();
            this.pnl_control.SuspendLayout();
            this.pnl_check.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.IndianRed;
            this.pnl_top.Controls.Add(this.btn_about);
            this.pnl_top.Controls.Add(this.btn_setting);
            this.pnl_top.Controls.Add(this.btn_general);
            this.pnl_top.Controls.Add(this.panel1);
            this.pnl_top.Controls.Add(this.txt_ver);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(800, 113);
            this.pnl_top.TabIndex = 0;
            // 
            // btn_about
            // 
            this.btn_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about.Location = new System.Drawing.Point(517, 25);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(142, 66);
            this.btn_about.TabIndex = 3;
            this.btn_about.Text = "Thông tin";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setting.Location = new System.Drawing.Point(264, 25);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(142, 66);
            this.btn_setting.TabIndex = 2;
            this.btn_setting.Text = "Cài đặt";
            this.btn_setting.UseVisualStyleBackColor = true;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn_general
            // 
            this.btn_general.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_general.Location = new System.Drawing.Point(12, 25);
            this.btn_general.Name = "btn_general";
            this.btn_general.Size = new System.Drawing.Size(142, 66);
            this.btn_general.TabIndex = 1;
            this.btn_general.Text = "Màn hình chính";
            this.btn_general.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // txt_ver
            // 
            this.txt_ver.BackColor = System.Drawing.Color.IndianRed;
            this.txt_ver.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ver.Location = new System.Drawing.Point(697, 0);
            this.txt_ver.Multiline = true;
            this.txt_ver.Name = "txt_ver";
            this.txt_ver.Size = new System.Drawing.Size(103, 21);
            this.txt_ver.TabIndex = 0;
            this.txt_ver.Text = "Made by Quang";
            // 
            // pnl_control
            // 
            this.pnl_control.BackColor = System.Drawing.Color.Red;
            this.pnl_control.Controls.Add(this.spt_dark);
            this.pnl_control.Controls.Add(this.txt_green);
            this.pnl_control.Controls.Add(this.txt_yellow);
            this.pnl_control.Controls.Add(this.txt_red);
            this.pnl_control.Controls.Add(this.btn_green_off);
            this.pnl_control.Controls.Add(this.btn_green_on);
            this.pnl_control.Controls.Add(this.btn_yellow_off);
            this.pnl_control.Controls.Add(this.btn_yellow_on);
            this.pnl_control.Controls.Add(this.btn_red_off);
            this.pnl_control.Controls.Add(this.btn_red_on);
            this.pnl_control.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_control.Location = new System.Drawing.Point(0, 113);
            this.pnl_control.Name = "pnl_control";
            this.pnl_control.Size = new System.Drawing.Size(406, 337);
            this.pnl_control.TabIndex = 1;
            // 
            // spt_dark
            // 
            this.spt_dark.BackColor = System.Drawing.Color.Black;
            this.spt_dark.Location = new System.Drawing.Point(0, 0);
            this.spt_dark.Name = "spt_dark";
            this.spt_dark.Size = new System.Drawing.Size(3, 337);
            this.spt_dark.TabIndex = 9;
            this.spt_dark.TabStop = false;
            // 
            // txt_green
            // 
            this.txt_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_green.Location = new System.Drawing.Point(320, 263);
            this.txt_green.Name = "txt_green";
            this.txt_green.Size = new System.Drawing.Size(56, 30);
            this.txt_green.TabIndex = 8;
            this.txt_green.Text = "Xanh";
            // 
            // txt_yellow
            // 
            this.txt_yellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_yellow.Location = new System.Drawing.Point(320, 156);
            this.txt_yellow.Name = "txt_yellow";
            this.txt_yellow.Size = new System.Drawing.Size(56, 30);
            this.txt_yellow.TabIndex = 7;
            this.txt_yellow.Text = "Vàng";
            // 
            // txt_red
            // 
            this.txt_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_red.Location = new System.Drawing.Point(330, 47);
            this.txt_red.Name = "txt_red";
            this.txt_red.Size = new System.Drawing.Size(35, 30);
            this.txt_red.TabIndex = 6;
            this.txt_red.Text = "Đỏ";
            this.txt_red.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_green_off
            // 
            this.btn_green_off.Location = new System.Drawing.Point(161, 249);
            this.btn_green_off.Name = "btn_green_off";
            this.btn_green_off.Size = new System.Drawing.Size(114, 64);
            this.btn_green_off.TabIndex = 5;
            this.btn_green_off.Text = "OFF";
            this.btn_green_off.UseVisualStyleBackColor = true;
            // 
            // btn_green_on
            // 
            this.btn_green_on.Location = new System.Drawing.Point(15, 249);
            this.btn_green_on.Name = "btn_green_on";
            this.btn_green_on.Size = new System.Drawing.Size(114, 64);
            this.btn_green_on.TabIndex = 4;
            this.btn_green_on.Text = "ON";
            this.btn_green_on.UseVisualStyleBackColor = true;
            // 
            // btn_yellow_off
            // 
            this.btn_yellow_off.Location = new System.Drawing.Point(161, 142);
            this.btn_yellow_off.Name = "btn_yellow_off";
            this.btn_yellow_off.Size = new System.Drawing.Size(114, 64);
            this.btn_yellow_off.TabIndex = 3;
            this.btn_yellow_off.Text = "OFF";
            this.btn_yellow_off.UseVisualStyleBackColor = true;
            // 
            // btn_yellow_on
            // 
            this.btn_yellow_on.Location = new System.Drawing.Point(15, 142);
            this.btn_yellow_on.Name = "btn_yellow_on";
            this.btn_yellow_on.Size = new System.Drawing.Size(114, 64);
            this.btn_yellow_on.TabIndex = 2;
            this.btn_yellow_on.Text = "ON";
            this.btn_yellow_on.UseVisualStyleBackColor = true;
            // 
            // btn_red_off
            // 
            this.btn_red_off.Location = new System.Drawing.Point(161, 33);
            this.btn_red_off.Name = "btn_red_off";
            this.btn_red_off.Size = new System.Drawing.Size(114, 64);
            this.btn_red_off.TabIndex = 1;
            this.btn_red_off.Text = "OFF";
            this.btn_red_off.UseVisualStyleBackColor = true;
            // 
            // btn_red_on
            // 
            this.btn_red_on.Location = new System.Drawing.Point(15, 33);
            this.btn_red_on.Name = "btn_red_on";
            this.btn_red_on.Size = new System.Drawing.Size(114, 64);
            this.btn_red_on.TabIndex = 0;
            this.btn_red_on.Text = "ON";
            this.btn_red_on.UseVisualStyleBackColor = true;
            // 
            // pnl_check
            // 
            this.pnl_check.BackColor = System.Drawing.Color.Firebrick;
            this.pnl_check.Controls.Add(this.textBox1);
            this.pnl_check.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_check.Location = new System.Drawing.Point(401, 113);
            this.pnl_check.Name = "pnl_check";
            this.pnl_check.Size = new System.Drawing.Size(399, 337);
            this.pnl_check.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(111, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 67);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "\r\n       Chưa kết nối!";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // TrafficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_check);
            this.Controls.Add(this.pnl_control);
            this.Controls.Add(this.pnl_top);
            this.Name = "TrafficLight";
            this.Text = "Traffic Light Control";
            this.Load += new System.EventHandler(this.TrafficLight_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_control.ResumeLayout(false);
            this.pnl_control.PerformLayout();
            this.pnl_check.ResumeLayout(false);
            this.pnl_check.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_ver;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn_general;
        private System.Windows.Forms.Panel pnl_control;
        private System.Windows.Forms.Panel pnl_check;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_yellow_off;
        private System.Windows.Forms.Button btn_yellow_on;
        private System.Windows.Forms.Button btn_red_off;
        private System.Windows.Forms.Button btn_red_on;
        private System.Windows.Forms.Button btn_green_off;
        private System.Windows.Forms.Button btn_green_on;
        private System.Windows.Forms.TextBox txt_red;
        private System.Windows.Forms.TextBox txt_yellow;
        private System.Windows.Forms.TextBox txt_green;
        private System.Windows.Forms.Splitter spt_dark;
    }
}

