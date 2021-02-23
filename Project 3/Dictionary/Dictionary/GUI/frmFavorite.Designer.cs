namespace Dictionary.GUI
{
    partial class frmFavorite
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLearn = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cbWord = new System.Windows.Forms.ComboBox();
            this.btnSpeakEnglish = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbExplaination = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnLearn);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.cbWord);
            this.panel1.Controls.Add(this.btnSpeakEnglish);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 437);
            this.panel1.TabIndex = 0;
            // 
            // btnLearn
            // 
            this.btnLearn.BackColor = System.Drawing.Color.SpringGreen;
            this.btnLearn.Location = new System.Drawing.Point(164, 119);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(61, 53);
            this.btnLearn.TabIndex = 2;
            this.btnLearn.Text = "Luyện tập";
            this.btnLearn.UseVisualStyleBackColor = false;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            this.btnLearn.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            this.btnLearn.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.SpringGreen;
            this.btnRemove.Location = new System.Drawing.Point(169, 73);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(52, 40);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Xoá";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            this.btnRemove.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            this.btnRemove.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            // 
            // cbWord
            // 
            this.cbWord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbWord.FormattingEnabled = true;
            this.cbWord.Location = new System.Drawing.Point(12, 24);
            this.cbWord.Name = "cbWord";
            this.cbWord.Size = new System.Drawing.Size(151, 411);
            this.cbWord.TabIndex = 2;
            this.cbWord.SelectedIndexChanged += new System.EventHandler(this.cbWord_SelectedIndexChanged);
            // 
            // btnSpeakEnglish
            // 
            this.btnSpeakEnglish.Image = global::Dictionary.Properties.Resources.icon_loa;
            this.btnSpeakEnglish.Location = new System.Drawing.Point(169, 24);
            this.btnSpeakEnglish.Name = "btnSpeakEnglish";
            this.btnSpeakEnglish.Size = new System.Drawing.Size(53, 43);
            this.btnSpeakEnglish.TabIndex = 1;
            this.btnSpeakEnglish.UseVisualStyleBackColor = true;
            this.btnSpeakEnglish.Click += new System.EventHandler(this.btnSpeakEnglish_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txbExplaination);
            this.panel2.Location = new System.Drawing.Point(243, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 437);
            this.panel2.TabIndex = 1;
            // 
            // txbExplaination
            // 
            this.txbExplaination.Location = new System.Drawing.Point(18, 24);
            this.txbExplaination.Multiline = true;
            this.txbExplaination.Name = "txbExplaination";
            this.txbExplaination.ReadOnly = true;
            this.txbExplaination.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbExplaination.Size = new System.Drawing.Size(492, 397);
            this.txbExplaination.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Danh sách từ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nội dung";
            // 
            // frmFavorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dictionary.Properties.Resources.backg;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmFavorite";
            this.Text = "frmFavorite";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFavorite_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbExplaination;
        private System.Windows.Forms.Button btnSpeakEnglish;
        private System.Windows.Forms.ComboBox cbWord;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}