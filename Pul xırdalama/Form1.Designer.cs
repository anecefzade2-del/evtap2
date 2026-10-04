namespace pulxırdalama
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtMebleg = new System.Windows.Forms.TextBox();
            this.btnXirdala = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.pb10 = new System.Windows.Forms.PictureBox();
            this.lbl10 = new System.Windows.Forms.Label();
            this.pb20 = new System.Windows.Forms.PictureBox();
            this.lbl20 = new System.Windows.Forms.Label();
            this.pb50 = new System.Windows.Forms.PictureBox();
            this.lbl50 = new System.Windows.Forms.Label();
            this.pb100 = new System.Windows.Forms.PictureBox();
            this.lbl100 = new System.Windows.Forms.Label();
            this.pb200 = new System.Windows.Forms.PictureBox();
            this.lbl200 = new System.Windows.Forms.Label();
            this.pb500 = new System.Windows.Forms.PictureBox();
            this.lbl500 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb200)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb500)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelLeft.Controls.Add(this.lblTitle);
            this.panelLeft.Controls.Add(this.txtMebleg);
            this.panelLeft.Controls.Add(this.btnXirdala);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(320, 520);
            this.panelLeft.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(20, 180);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Xırdalanacaq məbləğ";
            // 
            // txtMebleg
            // 
            this.txtMebleg.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMebleg.Location = new System.Drawing.Point(24, 220);
            this.txtMebleg.Name = "txtMebleg";
            this.txtMebleg.Size = new System.Drawing.Size(260, 29);
            this.txtMebleg.TabIndex = 1;
            this.txtMebleg.TextChanged += new System.EventHandler(this.txtMebleg_TextChanged);
            // 
            // btnXirdala
            // 
            this.btnXirdala.BackColor = System.Drawing.Color.LightGray;
            this.btnXirdala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXirdala.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnXirdala.Location = new System.Drawing.Point(24, 280);
            this.btnXirdala.Name = "btnXirdala";
            this.btnXirdala.Size = new System.Drawing.Size(260, 45);
            this.btnXirdala.TabIndex = 2;
            this.btnXirdala.Text = "Xırdala";
            this.btnXirdala.UseVisualStyleBackColor = false;
            this.btnXirdala.Click += new System.EventHandler(this.btnXirdala_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Teal;
            this.panelRight.Controls.Add(this.pb1);
            this.panelRight.Controls.Add(this.lbl1);
            this.panelRight.Controls.Add(this.pb5);
            this.panelRight.Controls.Add(this.lbl5);
            this.panelRight.Controls.Add(this.pb10);
            this.panelRight.Controls.Add(this.lbl10);
            this.panelRight.Controls.Add(this.pb20);
            this.panelRight.Controls.Add(this.lbl20);
            this.panelRight.Controls.Add(this.pb50);
            this.panelRight.Controls.Add(this.lbl50);
            this.panelRight.Controls.Add(this.pb100);
            this.panelRight.Controls.Add(this.lbl100);
            this.panelRight.Controls.Add(this.pb200);
            this.panelRight.Controls.Add(this.lbl200);
            this.panelRight.Controls.Add(this.pb500);
            this.panelRight.Controls.Add(this.lbl500);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(320, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(564, 520);
            this.panelRight.TabIndex = 1;
            // 
            // pb1
            // 
            this.pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb1.Image = global::pulxırdalama.Properties.Resources._1_manat___2020___obv;
            this.pb1.Location = new System.Drawing.Point(30, 20);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(160, 90);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(200, 55);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(51, 20);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "label1";
            // 
            // pb5
            // 
            this.pb5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb5.Image = global::pulxırdalama.Properties.Resources._5_manat_obv;
            this.pb5.Location = new System.Drawing.Point(30, 140);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(160, 90);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb5.TabIndex = 2;
            this.pb5.TabStop = false;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl5.ForeColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(200, 175);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(51, 20);
            this.lbl5.TabIndex = 3;
            this.lbl5.Text = "label2";
            // 
            // pb10
            // 
            this.pb10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb10.Image = global::pulxırdalama.Properties.Resources._10_manat_obv;
            this.pb10.Location = new System.Drawing.Point(30, 260);
            this.pb10.Name = "pb10";
            this.pb10.Size = new System.Drawing.Size(160, 90);
            this.pb10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb10.TabIndex = 4;
            this.pb10.TabStop = false;
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl10.ForeColor = System.Drawing.Color.White;
            this.lbl10.Location = new System.Drawing.Point(200, 295);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(51, 20);
            this.lbl10.TabIndex = 5;
            this.lbl10.Text = "label3";
            // 
            // pb20
            // 
            this.pb20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb20.Image = global::pulxırdalama.Properties.Resources._20_manat_obv;
            this.pb20.Location = new System.Drawing.Point(30, 380);
            this.pb20.Name = "pb20";
            this.pb20.Size = new System.Drawing.Size(160, 90);
            this.pb20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb20.TabIndex = 6;
            this.pb20.TabStop = false;
            // 
            // lbl20
            // 
            this.lbl20.AutoSize = true;
            this.lbl20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl20.ForeColor = System.Drawing.Color.White;
            this.lbl20.Location = new System.Drawing.Point(200, 415);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(51, 20);
            this.lbl20.TabIndex = 7;
            this.lbl20.Text = "label4";
            // 
            // pb50
            // 
            this.pb50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb50.Image = global::pulxırdalama.Properties.Resources._50_manat_front;
            this.pb50.Location = new System.Drawing.Point(290, 20);
            this.pb50.Name = "pb50";
            this.pb50.Size = new System.Drawing.Size(160, 90);
            this.pb50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb50.TabIndex = 8;
            this.pb50.TabStop = false;
            // 
            // lbl50
            // 
            this.lbl50.AutoSize = true;
            this.lbl50.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl50.Location = new System.Drawing.Point(460, 55);
            this.lbl50.Name = "lbl50";
            this.lbl50.Size = new System.Drawing.Size(51, 20);
            this.lbl50.TabIndex = 9;
            this.lbl50.Text = "label5";
            // 
            // pb100
            // 
            this.pb100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb100.Image = global::pulxırdalama.Properties.Resources._100_manat_obv;
            this.pb100.Location = new System.Drawing.Point(290, 140);
            this.pb100.Name = "pb100";
            this.pb100.Size = new System.Drawing.Size(160, 90);
            this.pb100.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb100.TabIndex = 10;
            this.pb100.TabStop = false;
            // 
            // lbl100
            // 
            this.lbl100.AutoSize = true;
            this.lbl100.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl100.ForeColor = System.Drawing.Color.White;
            this.lbl100.Location = new System.Drawing.Point(460, 175);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(51, 20);
            this.lbl100.TabIndex = 11;
            this.lbl100.Text = "label6";
            // 
            // pb200
            // 
            this.pb200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb200.Image = global::pulxırdalama.Properties.Resources._200_Azerbaijani_manat_in_2018_Reverse;
            this.pb200.Location = new System.Drawing.Point(290, 260);
            this.pb200.Name = "pb200";
            this.pb200.Size = new System.Drawing.Size(160, 90);
            this.pb200.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb200.TabIndex = 12;
            this.pb200.TabStop = false;
            // 
            // lbl200
            // 
            this.lbl200.AutoSize = true;
            this.lbl200.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl200.ForeColor = System.Drawing.Color.White;
            this.lbl200.Location = new System.Drawing.Point(460, 295);
            this.lbl200.Name = "lbl200";
            this.lbl200.Size = new System.Drawing.Size(51, 20);
            this.lbl200.TabIndex = 13;
            this.lbl200.Text = "label7";
            // 
            // pb500
            // 
            this.pb500.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb500.Image = global::pulxırdalama.Properties.Resources.Azerbaijan_500_manat_Karabakh_obverse;
            this.pb500.Location = new System.Drawing.Point(290, 380);
            this.pb500.Name = "pb500";
            this.pb500.Size = new System.Drawing.Size(160, 90);
            this.pb500.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb500.TabIndex = 14;
            this.pb500.TabStop = false;
            // 
            // lbl500
            // 
            this.lbl500.AutoSize = true;
            this.lbl500.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl500.ForeColor = System.Drawing.Color.White;
            this.lbl500.Location = new System.Drawing.Point(460, 415);
            this.lbl500.Name = "lbl500";
            this.lbl500.Size = new System.Drawing.Size(51, 20);
            this.lbl500.TabIndex = 15;
            this.lbl500.Text = "label8";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 520);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb200)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb500)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtMebleg;
        private System.Windows.Forms.Button btnXirdala;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.PictureBox pb10;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.PictureBox pb20;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.PictureBox pb50;
        private System.Windows.Forms.Label lbl50;
        private System.Windows.Forms.PictureBox pb100;
        private System.Windows.Forms.Label lbl100;
        private System.Windows.Forms.PictureBox pb200;
        private System.Windows.Forms.Label lbl200;
        private System.Windows.Forms.PictureBox pb500;
        private System.Windows.Forms.Label lbl500;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}