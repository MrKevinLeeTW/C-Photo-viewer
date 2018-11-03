namespace Photo_viewer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.right = new System.Windows.Forms.Button();
            this.automatic = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(468, 532);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(75, 41);
            this.right.TabIndex = 6;
            this.right.Text = ">>>";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // automatic
            // 
            this.automatic.Location = new System.Drawing.Point(304, 532);
            this.automatic.Name = "automatic";
            this.automatic.Size = new System.Drawing.Size(75, 41);
            this.automatic.TabIndex = 9;
            this.automatic.Text = "|| / >";
            this.automatic.UseVisualStyleBackColor = true;
            this.automatic.Click += new System.EventHandler(this.automatic_Click);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(149, 532);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(75, 41);
            this.left.TabIndex = 7;
            this.left.Text = "<<<";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(66, 439);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(75, 45);
            this.select.TabIndex = 8;
            this.select.Text = "選擇";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(46, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 386);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 605);
            this.Controls.Add(this.right);
            this.Controls.Add(this.automatic);
            this.Controls.Add(this.left);
            this.Controls.Add(this.select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "相片檢視器 Photo viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button automatic;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

