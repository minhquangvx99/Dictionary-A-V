namespace Dictionary.GUI
{
    partial class frmLearn
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.cbWord = new System.Windows.Forms.ComboBox();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCheck.Location = new System.Drawing.Point(183, 421);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(202, 31);
            this.btnCheck.TabIndex = 14;
            this.btnCheck.Text = "Kiểm tra đáp án";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            this.btnCheck.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.btnCheck.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // cbWord
            // 
            this.cbWord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbWord.FormattingEnabled = true;
            this.cbWord.Location = new System.Drawing.Point(13, 25);
            this.cbWord.Name = "cbWord";
            this.cbWord.Size = new System.Drawing.Size(151, 395);
            this.cbWord.TabIndex = 15;
            this.cbWord.SelectedIndexChanged += new System.EventHandler(this.cbWord_SelectedIndexChanged);
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(28, 277);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(110, 21);
            this.rbD.TabIndex = 11;
            this.rbD.TabStop = true;
            this.rbD.Text = "radioButton4";
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(28, 201);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(110, 21);
            this.rbC.TabIndex = 10;
            this.rbC.TabStop = true;
            this.rbC.Text = "radioButton3";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(28, 125);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(110, 21);
            this.rbB.TabIndex = 9;
            this.rbB.TabStop = true;
            this.rbB.Text = "radioButton2";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(28, 49);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(110, 21);
            this.rbA.TabIndex = 8;
            this.rbA.TabStop = true;
            this.rbA.Text = "radioButton1";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chọn nghĩa Tiếng Việt đúng cho từ đã chọn ở bên:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImage = global::Dictionary.Properties.Resources.backg;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbA);
            this.groupBox1.Controls.Add(this.rbB);
            this.groupBox1.Controls.Add(this.rbC);
            this.groupBox1.Controls.Add(this.rbD);
            this.groupBox1.Location = new System.Drawing.Point(183, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 403);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // frmLearn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dictionary.Properties.Resources.backg;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbWord);
            this.Controls.Add(this.btnCheck);
            this.Name = "frmLearn";
            this.Text = "frmLearn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLearn_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ComboBox cbWord;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}