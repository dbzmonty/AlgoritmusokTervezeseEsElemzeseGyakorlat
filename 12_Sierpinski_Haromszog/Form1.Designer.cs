namespace _12_Sierpinski_Haromszog
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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.scrollBar = new System.Windows.Forms.HScrollBar();
            this.lbl_szint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(12, 45);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(712, 578);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // scrollBar
            // 
            this.scrollBar.LargeChange = 1;
            this.scrollBar.Location = new System.Drawing.Point(9, 9);
            this.scrollBar.Maximum = 10;
            this.scrollBar.Minimum = 1;
            this.scrollBar.Name = "scrollBar";
            this.scrollBar.Size = new System.Drawing.Size(663, 22);
            this.scrollBar.TabIndex = 1;
            this.scrollBar.Value = 1;
            this.scrollBar.ValueChanged += new System.EventHandler(this.scrollBar_ValueChanged);
            // 
            // lbl_szint
            // 
            this.lbl_szint.AutoSize = true;
            this.lbl_szint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_szint.Location = new System.Drawing.Point(684, 9);
            this.lbl_szint.Name = "lbl_szint";
            this.lbl_szint.Size = new System.Drawing.Size(20, 24);
            this.lbl_szint.TabIndex = 2;
            this.lbl_szint.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 635);
            this.Controls.Add(this.lbl_szint);
            this.Controls.Add(this.scrollBar);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.HScrollBar scrollBar;
        private System.Windows.Forms.Label lbl_szint;
    }
}

