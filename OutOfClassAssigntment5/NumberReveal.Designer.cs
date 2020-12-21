namespace OutOfClassAssignment5
{
    partial class NumRevealed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumRevealed));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnNumReveal = new System.Windows.Forms.Button();
            this.lblNumShow = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Thistle;
            this.label1.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your number has been discovered...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Are you ready?";
            // 
            // bttnNumReveal
            // 
            this.bttnNumReveal.BackColor = System.Drawing.Color.Lavender;
            this.bttnNumReveal.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnNumReveal.Location = new System.Drawing.Point(72, 142);
            this.bttnNumReveal.Name = "bttnNumReveal";
            this.bttnNumReveal.Size = new System.Drawing.Size(303, 54);
            this.bttnNumReveal.TabIndex = 2;
            this.bttnNumReveal.Text = "Reveal your Lucky Number...";
            this.bttnNumReveal.UseVisualStyleBackColor = false;
            this.bttnNumReveal.Click += new System.EventHandler(this.bttnNumReveal_Click);
            // 
            // lblNumShow
            // 
            this.lblNumShow.AutoSize = true;
            this.lblNumShow.BackColor = System.Drawing.Color.SlateBlue;
            this.lblNumShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNumShow.Font = new System.Drawing.Font("Gabriola", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumShow.Location = new System.Drawing.Point(192, 293);
            this.lblNumShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumShow.Name = "lblNumShow";
            this.lblNumShow.Size = new System.Drawing.Size(0, 88);
            this.lblNumShow.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // NumRevealed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.lblNumShow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttnNumReveal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name = "NumRevealed";
            this.Text = "Number Revealed";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnNumReveal;
        private System.Windows.Forms.Label lblNumShow;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}