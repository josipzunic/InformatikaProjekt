using System.ComponentModel;

namespace Datoteke
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.a = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.b = new System.Windows.Forms.Button();
            this.d = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(27, 198);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(260, 36);
            this.a.TabIndex = 1;
            this.a.Text = "button1";
            this.a.UseVisualStyleBackColor = true;
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(311, 198);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(246, 35);
            this.c.TabIndex = 2;
            this.c.Text = "button2";
            this.c.UseVisualStyleBackColor = true;
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(27, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(529, 156);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(27, 254);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(260, 36);
            this.b.TabIndex = 4;
            this.b.Text = "button3";
            this.b.UseVisualStyleBackColor = true;
            this.b.Click += new System.EventHandler(this.b_Click);
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(311, 252);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(245, 39);
            this.d.TabIndex = 5;
            this.d.Text = "button4";
            this.d.UseVisualStyleBackColor = true;
            this.d.Click += new System.EventHandler(this.d_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(199, 332);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 47);
            this.button5.TabIndex = 6;
            this.button5.Text = "Zatvori";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 427);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.d);
            this.Controls.Add(this.b);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.c);
            this.Controls.Add(this.a);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button a;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Button d;
        private System.Windows.Forms.Button c;
    }
}