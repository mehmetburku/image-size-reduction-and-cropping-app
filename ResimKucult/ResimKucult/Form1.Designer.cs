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
            this.rbRight = new System.Windows.Forms.RadioButton();
            this.rbLeft = new System.Windows.Forms.RadioButton();
            this.rbBottom = new System.Windows.Forms.RadioButton();
            this.rbCenter = new System.Windows.Forms.RadioButton();
            this.rbTop = new System.Windows.Forms.RadioButton();
            this.lblResizeInfo = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.kalite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(16, 15);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(512, 368);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(597, 23);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(4);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(132, 22);
            this.txtWidth.TabIndex = 1;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(597, 58);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(132, 22);
            this.txtHeight.TabIndex = 2;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(16, 398);
            this.btnSelectImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(100, 28);
            this.btnSelectImage.TabIndex = 3;
            this.btnSelectImage.Text = "Resim Seç";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(570, 120);
            this.btnResize.Margin = new System.Windows.Forms.Padding(4);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(100, 28);
            this.btnResize.TabIndex = 4;
            this.btnResize.Text = "Kırp";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // lblImageSize
            // 
            this.lblImageSize.AutoSize = true;
            this.lblImageSize.Location = new System.Drawing.Point(125, 398);
            this.lblImageSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImageSize.Name = "lblImageSize";
            this.lblImageSize.Size = new System.Drawing.Size(0, 16);
            this.lblImageSize.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbRight);
            this.panel1.Controls.Add(this.rbLeft);
            this.panel1.Controls.Add(this.rbBottom);
            this.panel1.Controls.Add(this.rbCenter);
            this.panel1.Controls.Add(this.rbTop);
            this.panel1.Location = new System.Drawing.Point(567, 189);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 194);
            this.panel1.TabIndex = 6;
            // 
            // rbRight
            // 
            this.rbRight.AutoSize = true;
            this.rbRight.Location = new System.Drawing.Point(231, 78);
            this.rbRight.Margin = new System.Windows.Forms.Padding(4);
            this.rbRight.Name = "rbRight";
            this.rbRight.Size = new System.Drawing.Size(53, 20);
            this.rbRight.TabIndex = 4;
            this.rbRight.TabStop = true;
            this.rbRight.Text = "Sağ";
            this.rbRight.UseVisualStyleBackColor = true;
            // 
            // rbLeft
            // 
            this.rbLeft.AutoSize = true;
            this.rbLeft.Location = new System.Drawing.Point(30, 78);
            this.rbLeft.Margin = new System.Windows.Forms.Padding(4);
            this.rbLeft.Name = "rbLeft";
            this.rbLeft.Size = new System.Drawing.Size(48, 20);
            this.rbLeft.TabIndex = 3;
            this.rbLeft.TabStop = true;
            this.rbLeft.Text = "Sol";
            this.rbLeft.UseVisualStyleBackColor = true;
            // 
            // rbBottom
            // 
            this.rbBottom.AutoSize = true;
            this.rbBottom.Checked = true;
            this.rbBottom.Location = new System.Drawing.Point(127, 142);
            this.rbBottom.Margin = new System.Windows.Forms.Padding(4);
            this.rbBottom.Name = "rbBottom";
            this.rbBottom.Size = new System.Drawing.Size(43, 20);
            this.rbBottom.TabIndex = 2;
            this.rbBottom.TabStop = true;
            this.rbBottom.Text = "Alt";
            this.rbBottom.UseVisualStyleBackColor = true;
            this.rbBottom.CheckedChanged += new System.EventHandler(this.rbBottom_CheckedChanged);
            // 
            // rbCenter
            // 
            this.rbCenter.AutoSize = true;
            this.rbCenter.Location = new System.Drawing.Point(127, 78);
            this.rbCenter.Margin = new System.Windows.Forms.Padding(4);
            this.rbCenter.Name = "rbCenter";
            this.rbCenter.Size = new System.Drawing.Size(53, 20);
            this.rbCenter.TabIndex = 1;
            this.rbCenter.Text = "Orta";
            this.rbCenter.UseVisualStyleBackColor = true;
            // 
            // rbTop
            // 
            this.rbTop.AutoSize = true;
            this.rbTop.Location = new System.Drawing.Point(127, 19);
            this.rbTop.Margin = new System.Windows.Forms.Padding(4);
            this.rbTop.Name = "rbTop";
            this.rbTop.Size = new System.Drawing.Size(48, 20);
            this.rbTop.TabIndex = 0;
            this.rbTop.Text = "Üst";
            this.rbTop.UseVisualStyleBackColor = true;
            // 
            // lblResizeInfo
            // 
            this.lblResizeInfo.AutoSize = true;
            this.lblResizeInfo.Location = new System.Drawing.Point(125, 428);
            this.lblResizeInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResizeInfo.Name = "lblResizeInfo";
            this.lblResizeInfo.Size = new System.Drawing.Size(0, 16);
            this.lblResizeInfo.TabIndex = 7;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(653, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nerden Kırpılsın?";
            // 
            // kalite
            // 
            this.kalite.Location = new System.Drawing.Point(597, 90);
            this.kalite.Margin = new System.Windows.Forms.Padding(4);
            this.kalite.Name = "kalite";
            this.kalite.Size = new System.Drawing.Size(132, 22);
            this.kalite.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(567, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Q:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(567, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "W:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(567, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "H:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kalite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResizeInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblImageSize);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox kalite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

