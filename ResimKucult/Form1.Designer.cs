namespace ResimKucult
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.lblImageSize = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbBottom = new System.Windows.Forms.RadioButton();
            this.rbCenter = new System.Windows.Forms.RadioButton();
            this.rbTop = new System.Windows.Forms.RadioButton();
            this.lblResizeInfo = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.rbLeft = new System.Windows.Forms.RadioButton();
            this.rbRight = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(384, 299);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(422, 19);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 1;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(422, 45);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 2;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(13, 318);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(75, 23);
            this.btnSelectImage.TabIndex = 3;
            this.btnSelectImage.Text = "Resim Seç";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(422, 72);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(75, 23);
            this.btnResize.TabIndex = 4;
            this.btnResize.Text = "Kırp";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // lblImageSize
            // 
            this.lblImageSize.AutoSize = true;
            this.lblImageSize.Location = new System.Drawing.Point(94, 323);
            this.lblImageSize.Name = "lblImageSize";
            this.lblImageSize.Size = new System.Drawing.Size(0, 13);
            this.lblImageSize.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbRight);
            this.panel1.Controls.Add(this.rbLeft);
            this.panel1.Controls.Add(this.rbBottom);
            this.panel1.Controls.Add(this.rbCenter);
            this.panel1.Controls.Add(this.rbTop);
            this.panel1.Location = new System.Drawing.Point(425, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 158);
            this.panel1.TabIndex = 6;
            // 
            // rbBottom
            // 
            this.rbBottom.AutoSize = true;
            this.rbBottom.Checked = true;
            this.rbBottom.Location = new System.Drawing.Point(86, 13);
            this.rbBottom.Name = "rbBottom";
            this.rbBottom.Size = new System.Drawing.Size(41, 17);
            this.rbBottom.TabIndex = 2;
            this.rbBottom.TabStop = true;
            this.rbBottom.Text = "Üst";
            this.rbBottom.UseVisualStyleBackColor = true;
            // 
            // rbCenter
            // 
            this.rbCenter.AutoSize = true;
            this.rbCenter.Location = new System.Drawing.Point(86, 49);
            this.rbCenter.Name = "rbCenter";
            this.rbCenter.Size = new System.Drawing.Size(45, 17);
            this.rbCenter.TabIndex = 1;
            this.rbCenter.Text = "Orta";
            this.rbCenter.UseVisualStyleBackColor = true;
            // 
            // rbTop
            // 
            this.rbTop.AutoSize = true;
            this.rbTop.Location = new System.Drawing.Point(86, 87);
            this.rbTop.Name = "rbTop";
            this.rbTop.Size = new System.Drawing.Size(37, 17);
            this.rbTop.TabIndex = 0;
            this.rbTop.Text = "Alt";
            this.rbTop.UseVisualStyleBackColor = true;
            // 
            // lblResizeInfo
            // 
            this.lblResizeInfo.AutoSize = true;
            this.lblResizeInfo.Location = new System.Drawing.Point(94, 348);
            this.lblResizeInfo.Name = "lblResizeInfo";
            this.lblResizeInfo.Size = new System.Drawing.Size(0, 13);
            this.lblResizeInfo.TabIndex = 7;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // rbLeft
            // 
            this.rbLeft.AutoSize = true;
            this.rbLeft.Location = new System.Drawing.Point(172, 49);
            this.rbLeft.Name = "rbLeft";
            this.rbLeft.Size = new System.Drawing.Size(44, 17);
            this.rbLeft.TabIndex = 3;
            this.rbLeft.TabStop = true;
            this.rbLeft.Text = "Sağ";
            this.rbLeft.UseVisualStyleBackColor = true;
            // 
            // rbRight
            // 
            this.rbRight.AutoSize = true;
            this.rbRight.Location = new System.Drawing.Point(18, 49);
            this.rbRight.Name = "rbRight";
            this.rbRight.Size = new System.Drawing.Size(40, 17);
            this.rbRight.TabIndex = 4;
            this.rbRight.TabStop = true;
            this.rbRight.Text = "Sol";
            this.rbRight.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nerden Kırpılsın";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResizeInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblImageSize);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Label lblImageSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbBottom;
        private System.Windows.Forms.RadioButton rbCenter;
        private System.Windows.Forms.RadioButton rbTop;
        private System.Windows.Forms.Label lblResizeInfo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RadioButton rbRight;
        private System.Windows.Forms.RadioButton rbLeft;
        private System.Windows.Forms.Label label1;
    }
}

