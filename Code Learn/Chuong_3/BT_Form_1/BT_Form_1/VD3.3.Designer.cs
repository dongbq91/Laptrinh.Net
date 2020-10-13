namespace BT_Form_1
{
    partial class VD3p1
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
            this.TD1 = new System.Windows.Forms.Label();
            this.TD2 = new System.Windows.Forms.Label();
            this.TD3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TD1
            // 
            this.TD1.AutoSize = true;
            this.TD1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TD1.Location = new System.Drawing.Point(241, 43);
            this.TD1.Name = "TD1";
            this.TD1.Size = new System.Drawing.Size(344, 40);
            this.TD1.TabIndex = 0;
            this.TD1.Text = "Lập Trình C# Cơ Bản";
            this.TD1.Click += new System.EventHandler(this.TD1_Click);
            // 
            // TD2
            // 
            this.TD2.AutoSize = true;
            this.TD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TD2.Location = new System.Drawing.Point(357, 108);
            this.TD2.Name = "TD2";
            this.TD2.Size = new System.Drawing.Size(92, 18);
            this.TD2.TabIndex = 1;
            this.TD2.Text = " - - - o0o - - -";
            // 
            // TD3
            // 
            this.TD3.AutoSize = true;
            this.TD3.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TD3.Location = new System.Drawing.Point(47, 158);
            this.TD3.Name = "TD3";
            this.TD3.Size = new System.Drawing.Size(723, 73);
            this.TD3.TabIndex = 2;
            this.TD3.Text = "Chương Trình Minh Họa";
            // 
            // VD3p1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 260);
            this.Controls.Add(this.TD1);
            this.Controls.Add(this.TD3);
            this.Controls.Add(this.TD2);
            this.Name = "VD3p1";
            this.Text = "VD3";
            this.Load += new System.EventHandler(this.VD3p1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TD1;
        private System.Windows.Forms.Label TD2;
        private System.Windows.Forms.Label TD3;
    }
}