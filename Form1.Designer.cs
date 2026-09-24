namespace CalculatorApp
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
            this.lblNumberOne = new System.Windows.Forms.Label();
            this.txtNumberOne = new System.Windows.Forms.TextBox();
            this.lblNumberTwo = new System.Windows.Forms.Label();
            this.txtNumberTwo = new System.Windows.Forms.TextBox();
            this.lblCommand = new System.Windows.Forms.Label();
            this.cmbCommand = new System.Windows.Forms.ComboBox();
            this.lblAnswerTitle = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumberOne
            // 
            this.lblNumberOne.AutoSize = true;
            this.lblNumberOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNumberOne.ForeColor = System.Drawing.Color.White;
            this.lblNumberOne.Location = new System.Drawing.Point(38, 20);
            this.lblNumberOne.Name = "lblNumberOne";
            this.lblNumberOne.Size = new System.Drawing.Size(111, 20);
            this.lblNumberOne.TabIndex = 0;
            this.lblNumberOne.Text = "Number one";
            // 
            // txtNumberOne
            // 
            this.txtNumberOne.Location = new System.Drawing.Point(42, 45);
            this.txtNumberOne.Name = "txtNumberOne";
            this.txtNumberOne.Size = new System.Drawing.Size(260, 20);
            this.txtNumberOne.TabIndex = 1;
            this.txtNumberOne.Text = "0";
            // 
            // lblNumberTwo
            // 
            this.lblNumberTwo.AutoSize = true;
            this.lblNumberTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNumberTwo.ForeColor = System.Drawing.Color.White;
            this.lblNumberTwo.Location = new System.Drawing.Point(38, 95);
            this.lblNumberTwo.Name = "lblNumberTwo";
            this.lblNumberTwo.Size = new System.Drawing.Size(110, 20);
            this.lblNumberTwo.TabIndex = 2;
            this.lblNumberTwo.Text = "Number two";
            // 
            // txtNumberTwo
            // 
            this.txtNumberTwo.Location = new System.Drawing.Point(42, 120);
            this.txtNumberTwo.Name = "txtNumberTwo";
            this.txtNumberTwo.Size = new System.Drawing.Size(260, 20);
            this.txtNumberTwo.TabIndex = 3;
            this.txtNumberTwo.Text = "0";
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCommand.ForeColor = System.Drawing.Color.White;
            this.lblCommand.Location = new System.Drawing.Point(38, 168);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(89, 20);
            this.lblCommand.TabIndex = 4;
            this.lblCommand.Text = "Command";
            // 
            // cmbCommand
            // 
            this.cmbCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommand.FormattingEnabled = true;
            this.cmbCommand.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbCommand.Location = new System.Drawing.Point(42, 193);
            this.cmbCommand.Name = "cmbCommand";
            this.cmbCommand.Size = new System.Drawing.Size(260, 21);
            this.cmbCommand.TabIndex = 5;
            // 
            // lblAnswerTitle
            // 
            this.lblAnswerTitle.AutoSize = true;
            this.lblAnswerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblAnswerTitle.ForeColor = System.Drawing.Color.White;
            this.lblAnswerTitle.Location = new System.Drawing.Point(38, 245);
            this.lblAnswerTitle.Name = "lblAnswerTitle";
            this.lblAnswerTitle.Size = new System.Drawing.Size(72, 20);
            this.lblAnswerTitle.TabIndex = 6;
            this.lblAnswerTitle.Text = "Answer:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblAnswer.ForeColor = System.Drawing.Color.White;
            this.lblAnswer.Location = new System.Drawing.Point(130, 245);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(18, 20);
            this.lblAnswer.TabIndex = 7;
            this.lblAnswer.Text = "0";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(42, 285);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(260, 40);
            this.btnResult.TabIndex = 8;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(42, 345);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(260, 40);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(344, 411);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblAnswerTitle);
            this.Controls.Add(this.cmbCommand);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.txtNumberTwo);
            this.Controls.Add(this.lblNumberTwo);
            this.Controls.Add(this.txtNumberOne);
            this.Controls.Add(this.lblNumberOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNumberOne;
        private System.Windows.Forms.TextBox txtNumberOne;
        private System.Windows.Forms.Label lblNumberTwo;
        private System.Windows.Forms.TextBox txtNumberTwo;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.ComboBox cmbCommand;
        private System.Windows.Forms.Label lblAnswerTitle;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnClear;
    }
}
