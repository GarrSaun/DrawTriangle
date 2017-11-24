namespace DrawTriangle
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
            this.xBox1 = new System.Windows.Forms.TextBox();
            this.yBox3 = new System.Windows.Forms.TextBox();
            this.yBox2 = new System.Windows.Forms.TextBox();
            this.yBox1 = new System.Windows.Forms.TextBox();
            this.xBox3 = new System.Windows.Forms.TextBox();
            this.xBox2 = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xBox1
            // 
            this.xBox1.Location = new System.Drawing.Point(12, 12);
            this.xBox1.Name = "xBox1";
            this.xBox1.Size = new System.Drawing.Size(49, 20);
            this.xBox1.TabIndex = 0;
            // 
            // yBox3
            // 
            this.yBox3.Location = new System.Drawing.Point(67, 64);
            this.yBox3.Name = "yBox3";
            this.yBox3.Size = new System.Drawing.Size(49, 20);
            this.yBox3.TabIndex = 1;
            // 
            // yBox2
            // 
            this.yBox2.Location = new System.Drawing.Point(67, 38);
            this.yBox2.Name = "yBox2";
            this.yBox2.Size = new System.Drawing.Size(49, 20);
            this.yBox2.TabIndex = 2;
            // 
            // yBox1
            // 
            this.yBox1.Location = new System.Drawing.Point(67, 12);
            this.yBox1.Name = "yBox1";
            this.yBox1.Size = new System.Drawing.Size(49, 20);
            this.yBox1.TabIndex = 3;
            // 
            // xBox3
            // 
            this.xBox3.Location = new System.Drawing.Point(12, 64);
            this.xBox3.Name = "xBox3";
            this.xBox3.Size = new System.Drawing.Size(49, 20);
            this.xBox3.TabIndex = 4;
            // 
            // xBox2
            // 
            this.xBox2.Location = new System.Drawing.Point(12, 38);
            this.xBox2.Name = "xBox2";
            this.xBox2.Size = new System.Drawing.Size(49, 20);
            this.xBox2.TabIndex = 5;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(25, 90);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 6;
            this.goButton.Text = "button1";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 329);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.xBox2);
            this.Controls.Add(this.xBox3);
            this.Controls.Add(this.yBox1);
            this.Controls.Add(this.yBox2);
            this.Controls.Add(this.yBox3);
            this.Controls.Add(this.xBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xBox1;
        private System.Windows.Forms.TextBox yBox3;
        private System.Windows.Forms.TextBox yBox2;
        private System.Windows.Forms.TextBox yBox1;
        private System.Windows.Forms.TextBox xBox3;
        private System.Windows.Forms.TextBox xBox2;
        private System.Windows.Forms.Button goButton;
    }
}

