namespace _14_Rekurziv_Fa
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
            this.scr_depth = new System.Windows.Forms.HScrollBar();
            this.lbl_depth_value = new System.Windows.Forms.Label();
            this.lbl_depth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(12, 45);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(760, 505);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // scr_depth
            // 
            this.scr_depth.LargeChange = 1;
            this.scr_depth.Location = new System.Drawing.Point(70, 9);
            this.scr_depth.Maximum = 9;
            this.scr_depth.Minimum = 1;
            this.scr_depth.Name = "scr_depth";
            this.scr_depth.Size = new System.Drawing.Size(642, 22);
            this.scr_depth.TabIndex = 1;
            this.scr_depth.Value = 5;
            this.scr_depth.ValueChanged += new System.EventHandler(this.scr_depth_ValueChanged);
            // 
            // lbl_depth_value
            // 
            this.lbl_depth_value.AutoSize = true;
            this.lbl_depth_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_depth_value.Location = new System.Drawing.Point(736, 7);
            this.lbl_depth_value.Name = "lbl_depth_value";
            this.lbl_depth_value.Size = new System.Drawing.Size(20, 24);
            this.lbl_depth_value.TabIndex = 2;
            this.lbl_depth_value.Text = "5";
            // 
            // lbl_depth
            // 
            this.lbl_depth.AutoSize = true;
            this.lbl_depth.Location = new System.Drawing.Point(12, 15);
            this.lbl_depth.Name = "lbl_depth";
            this.lbl_depth.Size = new System.Drawing.Size(46, 13);
            this.lbl_depth.TabIndex = 3;
            this.lbl_depth.Text = "Mélység";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lbl_depth);
            this.Controls.Add(this.lbl_depth_value);
            this.Controls.Add(this.scr_depth);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.HScrollBar scr_depth;
        private System.Windows.Forms.Label lbl_depth_value;
        private System.Windows.Forms.Label lbl_depth;
    }
}

