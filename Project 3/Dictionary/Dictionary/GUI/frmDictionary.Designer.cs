namespace Dictionary.GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbEng = new System.Windows.Forms.TextBox();
            this.txbViet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNotify = new System.Windows.Forms.Label();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSpeakE = new System.Windows.Forms.Button();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(372, 388);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(324, 52);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm vào mục yêu thích";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            // 
            // txbEng
            // 
            this.txbEng.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEng.Location = new System.Drawing.Point(144, 13);
            this.txbEng.Margin = new System.Windows.Forms.Padding(4);
            this.txbEng.Multiline = true;
            this.txbEng.Name = "txbEng";
            this.txbEng.Size = new System.Drawing.Size(322, 42);
            this.txbEng.TabIndex = 4;
            this.txbEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbEng.TextChanged += new System.EventHandler(this.txbEng_TextChanged);
            // 
            // txbViet
            // 
            this.txbViet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbViet.Location = new System.Drawing.Point(144, 67);
            this.txbViet.Margin = new System.Windows.Forms.Padding(4);
            this.txbViet.Multiline = true;
            this.txbViet.Name = "txbViet";
            this.txbViet.ReadOnly = true;
            this.txbViet.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbViet.Size = new System.Drawing.Size(535, 245);
            this.txbViet.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ cần tra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kết quả";
            // 
            // lbNotify
            // 
            this.lbNotify.BackColor = System.Drawing.Color.Transparent;
            this.lbNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotify.ForeColor = System.Drawing.Color.Red;
            this.lbNotify.Location = new System.Drawing.Point(144, 320);
            this.lbNotify.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNotify.Name = "lbNotify";
            this.lbNotify.Size = new System.Drawing.Size(535, 46);
            this.lbNotify.TabIndex = 8;
            this.lbNotify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picSearch
            // 
            this.picSearch.BackColor = System.Drawing.Color.Yellow;
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(71, 320);
            this.picSearch.Margin = new System.Windows.Forms.Padding(4);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(65, 46);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 9;
            this.picSearch.TabStop = false;
            this.picSearch.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(702, 321);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 49);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSpeakE
            // 
            this.btnSpeakE.Image = ((System.Drawing.Image)(resources.GetObject("btnSpeakE.Image")));
            this.btnSpeakE.Location = new System.Drawing.Point(473, 13);
            this.btnSpeakE.Name = "btnSpeakE";
            this.btnSpeakE.Size = new System.Drawing.Size(48, 42);
            this.btnSpeakE.TabIndex = 11;
            this.btnSpeakE.UseVisualStyleBackColor = true;
            this.btnSpeakE.Click += new System.EventHandler(this.btnSpeakE_Click);
            // 
            // btnFavorite
            // 
            this.btnFavorite.BackColor = System.Drawing.Color.PaleGreen;
            this.btnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFavorite.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavorite.Location = new System.Drawing.Point(67, 388);
            this.btnFavorite.Margin = new System.Windows.Forms.Padding(4);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(255, 52);
            this.btnFavorite.TabIndex = 13;
            this.btnFavorite.Text = "Danh mục yêu thích";
            this.btnFavorite.UseVisualStyleBackColor = false;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            this.btnFavorite.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            this.btnFavorite.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.btnSpeakE);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.picSearch);
            this.Controls.Add(this.lbNotify);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbViet);
            this.Controls.Add(this.txbEng);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DICTIONARY";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbEng;
        private System.Windows.Forms.TextBox txbViet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNotify;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSpeakE;
        private System.Windows.Forms.Button btnFavorite;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

