namespace BKI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;

        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;

        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;

        private System.Windows.Forms.Button btnOK;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();

            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();

            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();

            this.btnOK = new System.Windows.Forms.Button();

            this.pictureBox1 = new System.Windows.Forms.PictureBox();

            this.lblResult = new System.Windows.Forms.Label();

            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();

            this.SuspendLayout();

           

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(680, 680);

            this.BackColor = System.Drawing.Color.White;

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "BKI Hesablama";

           
            this.panelLeft.BackColor =
                System.Drawing.Color.FromArgb(60, 60, 60);

            this.panelLeft.Location =
                new System.Drawing.Point(0, 0);

            this.panelLeft.Name = "panelLeft";

            this.panelLeft.Size =
                new System.Drawing.Size(300, 680);

            this.panelLeft.TabIndex = 0;

           

            this.lblHeight.AutoSize = true;

            this.lblHeight.ForeColor =
                System.Drawing.Color.White;

            this.lblHeight.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Regular);

            this.lblHeight.Location =
                new System.Drawing.Point(63, 120);

            this.lblHeight.Name = "lblHeight";

            this.lblHeight.Size =
                new System.Drawing.Size(45, 19);

            this.lblHeight.Text = "Height";

           

            this.txtHeight.BackColor =
                System.Drawing.Color.White;

            this.txtHeight.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtHeight.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F);

            this.txtHeight.Location =
                new System.Drawing.Point(63, 140);

            this.txtHeight.Name = "txtHeight";

            this.txtHeight.Size =
                new System.Drawing.Size(172, 27);

            this.txtHeight.TabIndex = 0;

            

            this.lblWeight.AutoSize = true;

            this.lblWeight.ForeColor =
                System.Drawing.Color.White;

            this.lblWeight.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.lblWeight.Location =
                new System.Drawing.Point(63, 195);

            this.lblWeight.Name = "lblWeight";

            this.lblWeight.Size =
                new System.Drawing.Size(50, 19);

            this.lblWeight.Text = "Weight";

          

            this.txtWeight.BackColor =
                System.Drawing.Color.White;

            this.txtWeight.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtWeight.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F);

            this.txtWeight.Location =
                new System.Drawing.Point(63, 215);

            this.txtWeight.Name = "txtWeight";

            this.txtWeight.Size =
                new System.Drawing.Size(172, 27);

            this.txtWeight.TabIndex = 1;

         

            this.btnOK.BackColor =
                System.Drawing.Color.FromArgb(255, 128, 0);

            this.btnOK.FlatAppearance.BorderColor =
                System.Drawing.Color.White;

            this.btnOK.FlatAppearance.BorderSize = 2;

            this.btnOK.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnOK.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F,
                    System.Drawing.FontStyle.Regular);

            this.btnOK.ForeColor =
                System.Drawing.Color.Black;

            this.btnOK.Location =
                new System.Drawing.Point(65, 320);

            this.btnOK.Name = "btnOK";

            this.btnOK.Size =
                new System.Drawing.Size(170, 100);

            this.btnOK.TabIndex = 2;

            this.btnOK.Text = "OK";

            this.btnOK.UseVisualStyleBackColor = false;

            this.btnOK.Click +=
                new System.EventHandler(this.btnOK_Click);

          

            this.panelLeft.Controls.Add(this.lblHeight);
            this.panelLeft.Controls.Add(this.txtHeight);

            this.panelLeft.Controls.Add(this.lblWeight);
            this.panelLeft.Controls.Add(this.txtWeight);

            this.panelLeft.Controls.Add(this.btnOK);

        

            this.panelRight.BackColor =
                System.Drawing.Color.White;

            this.panelRight.Location =
                new System.Drawing.Point(300, 0);

            this.panelRight.Name = "panelRight";

            this.panelRight.Size =
                new System.Drawing.Size(380, 680);

            this.panelRight.TabIndex = 1;



            this.pictureBox1.BackColor =
                System.Drawing.Color.White;

            this.pictureBox1.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.pictureBox1.Location =
                new System.Drawing.Point(15, 40);

            this.pictureBox1.Name = "pictureBox1";

            this.pictureBox1.Size =
                new System.Drawing.Size(350, 450);

            this.pictureBox1.SizeMode =
                System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.pictureBox1.TabIndex = 3;

            this.pictureBox1.TabStop = false;

       

            this.lblResult.AutoSize = false;

            this.lblResult.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    14F,
                    System.Drawing.FontStyle.Bold);

            this.lblResult.ForeColor =
                System.Drawing.Color.FromArgb(50, 50, 50);

            this.lblResult.Location =
                new System.Drawing.Point(20, 510);

            this.lblResult.Name = "lblResult";

            this.lblResult.Size =
                new System.Drawing.Size(340, 100);

            this.lblResult.Text =
                "BKI nəticəsi";

            this.lblResult.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;



            this.panelRight.Controls.Add(this.pictureBox1);
            this.panelRight.Controls.Add(this.lblResult);



            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);



            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();

            this.panelRight.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)
                (this.pictureBox1)).EndInit();

            this.ResumeLayout(false);
        }
    }
}
