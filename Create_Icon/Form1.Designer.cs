namespace Create_Icon
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PictureBoxClear = new System.Windows.Forms.PictureBox();
            this.BtnExport = new System.Windows.Forms.Button();
            this.BtnImport = new System.Windows.Forms.Button();
            this.pictureBox_Android = new System.Windows.Forms.PictureBox();
            this.PictureBoxDEL = new System.Windows.Forms.PictureBox();
            this.pictureBox_IOS = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.RichTextBox();
            this.DU_Height = new System.Windows.Forms.DomainUpDown();
            this.DU_Width = new System.Windows.Forms.DomainUpDown();
            this.CB_TypeFile = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Android)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDEL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_IOS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(70, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(113, 25);
            label1.TabIndex = 1;
            label1.Text = "Resize Icon";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 65);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Create_Icon.Properties.Resources.resize;
            this.pictureBox3.Location = new System.Drawing.Point(12, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.PictureBoxClear);
            this.panel2.Controls.Add(this.BtnExport);
            this.panel2.Controls.Add(this.BtnImport);
            this.panel2.Controls.Add(this.pictureBox_Android);
            this.panel2.Controls.Add(this.PictureBoxDEL);
            this.panel2.Controls.Add(this.pictureBox_IOS);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(92, 478);
            this.panel2.TabIndex = 1;
            // 
            // PictureBoxClear
            // 
            this.PictureBoxClear.Image = global::Create_Icon.Properties.Resources.broom_480px;
            this.PictureBoxClear.InitialImage = null;
            this.PictureBoxClear.Location = new System.Drawing.Point(3, 392);
            this.PictureBoxClear.Name = "PictureBoxClear";
            this.PictureBoxClear.Size = new System.Drawing.Size(89, 70);
            this.PictureBoxClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxClear.TabIndex = 4;
            this.PictureBoxClear.TabStop = false;
            this.PictureBoxClear.Click += new System.EventHandler(this.PictureBoxClear_Click);
            // 
            // BtnExport
            // 
            this.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnExport.ForeColor = System.Drawing.Color.White;
            this.BtnExport.Location = new System.Drawing.Point(12, 74);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(70, 40);
            this.BtnExport.TabIndex = 3;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // BtnImport
            // 
            this.BtnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnImport.ForeColor = System.Drawing.Color.White;
            this.BtnImport.Location = new System.Drawing.Point(12, 17);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(70, 40);
            this.BtnImport.TabIndex = 2;
            this.BtnImport.Text = "Import";
            this.BtnImport.UseVisualStyleBackColor = true;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // pictureBox_Android
            // 
            this.pictureBox_Android.Image = global::Create_Icon.Properties.Resources.android;
            this.pictureBox_Android.InitialImage = null;
            this.pictureBox_Android.Location = new System.Drawing.Point(3, 134);
            this.pictureBox_Android.Name = "pictureBox_Android";
            this.pictureBox_Android.Size = new System.Drawing.Size(89, 70);
            this.pictureBox_Android.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Android.TabIndex = 0;
            this.pictureBox_Android.TabStop = false;
            this.pictureBox_Android.Click += new System.EventHandler(this.PictureBox_Android_Click);
            // 
            // PictureBoxDEL
            // 
            this.PictureBoxDEL.Image = global::Create_Icon.Properties.Resources.delete_bin_480px;
            this.PictureBoxDEL.InitialImage = null;
            this.PictureBoxDEL.Location = new System.Drawing.Point(3, 306);
            this.PictureBoxDEL.Name = "PictureBoxDEL";
            this.PictureBoxDEL.Size = new System.Drawing.Size(89, 70);
            this.PictureBoxDEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxDEL.TabIndex = 5;
            this.PictureBoxDEL.TabStop = false;
            this.PictureBoxDEL.Click += new System.EventHandler(this.PictureBoxDEL_Click);
            // 
            // pictureBox_IOS
            // 
            this.pictureBox_IOS.Image = global::Create_Icon.Properties.Resources.apple;
            this.pictureBox_IOS.Location = new System.Drawing.Point(3, 220);
            this.pictureBox_IOS.Name = "pictureBox_IOS";
            this.pictureBox_IOS.Size = new System.Drawing.Size(89, 70);
            this.pictureBox_IOS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_IOS.TabIndex = 1;
            this.pictureBox_IOS.TabStop = false;
            this.pictureBox_IOS.Click += new System.EventHandler(this.PictureBox_IOS_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Panel);
            this.groupBox1.Controls.Add(this.DU_Height);
            this.groupBox1.Controls.Add(this.DU_Width);
            this.groupBox1.Controls.Add(this.CB_TypeFile);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(118, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 445);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "px";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "px";
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Panel.ForeColor = System.Drawing.Color.White;
            this.Panel.Location = new System.Drawing.Point(44, 211);
            this.Panel.Name = "Panel";
            this.Panel.ReadOnly = true;
            this.Panel.Size = new System.Drawing.Size(445, 198);
            this.Panel.TabIndex = 4;
            this.Panel.Text = "Panel";
            // 
            // DU_Height
            // 
            this.DU_Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DU_Height.Location = new System.Drawing.Point(246, 69);
            this.DU_Height.Name = "DU_Height";
            this.DU_Height.Size = new System.Drawing.Size(160, 28);
            this.DU_Height.TabIndex = 3;
            this.DU_Height.Text = "Height";
            // 
            // DU_Width
            // 
            this.DU_Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DU_Width.Location = new System.Drawing.Point(44, 69);
            this.DU_Width.Name = "DU_Width";
            this.DU_Width.Size = new System.Drawing.Size(160, 28);
            this.DU_Width.TabIndex = 1;
            this.DU_Width.Text = "Width";
            // 
            // CB_TypeFile
            // 
            this.CB_TypeFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_TypeFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CB_TypeFile.FormattingEnabled = true;
            this.CB_TypeFile.Items.AddRange(new object[] {
            "PNG",
            "JPG",
            "BMP"});
            this.CB_TypeFile.Location = new System.Drawing.Point(44, 137);
            this.CB_TypeFile.Name = "CB_TypeFile";
            this.CB_TypeFile.Size = new System.Drawing.Size(445, 30);
            this.CB_TypeFile.TabIndex = 0;
            this.CB_TypeFile.Text = "Type File Export";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(685, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Android)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDEL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_IOS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox_IOS;
        private System.Windows.Forms.PictureBox pictureBox_Android;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DomainUpDown DU_Height;
        private System.Windows.Forms.DomainUpDown DU_Width;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.RichTextBox Panel;
        private System.Windows.Forms.ComboBox CB_TypeFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PictureBoxClear;
        private System.Windows.Forms.PictureBox PictureBoxDEL;
    }
}

