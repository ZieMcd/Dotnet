namespace First_time_making_an_app
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
            this.components = new System.ComponentModel.Container();
            this.edtNum1 = new System.Windows.Forms.TextBox();
            this.edtNum2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.edtOuput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // edtNum1
            // 
            this.edtNum1.Location = new System.Drawing.Point(12, 12);
            this.edtNum1.Name = "edtNum1";
            this.edtNum1.Size = new System.Drawing.Size(72, 20);
            this.edtNum1.TabIndex = 0;
            // 
            // edtNum2
            // 
            this.edtNum2.Location = new System.Drawing.Point(121, 12);
            this.edtNum2.Name = "edtNum2";
            this.edtNum2.Size = new System.Drawing.Size(66, 20);
            this.edtNum2.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edtOuput
            // 
            this.edtOuput.Location = new System.Drawing.Point(46, 94);
            this.edtOuput.Name = "edtOuput";
            this.edtOuput.Size = new System.Drawing.Size(100, 20);
            this.edtOuput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 150);
            this.Controls.Add(this.edtOuput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edtNum2);
            this.Controls.Add(this.edtNum1);
            this.Name = "Form1";
            this.Text = "Only Add";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edtNum1;
        private System.Windows.Forms.TextBox edtNum2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox edtOuput;
    }
}

