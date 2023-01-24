namespace _13_Kantor_halmaz
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
            this.sb_level = new System.Windows.Forms.HScrollBar();
            this.lbl_level = new System.Windows.Forms.Label();
            this.canvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // sb_level
            // 
            this.sb_level.LargeChange = 1;
            this.sb_level.Location = new System.Drawing.Point(13, 13);
            this.sb_level.Maximum = 7;
            this.sb_level.Minimum = 1;
            this.sb_level.Name = "sb_level";
            this.sb_level.Size = new System.Drawing.Size(670, 22);
            this.sb_level.TabIndex = 0;
            this.sb_level.Value = 1;
            this.sb_level.ValueChanged += new System.EventHandler(this.sb_level_ValueChanged);
            // 
            // lbl_level
            // 
            this.lbl_level.AutoSize = true;
            this.lbl_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_level.Location = new System.Drawing.Point(702, 13);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(20, 24);
            this.lbl_level.TabIndex = 1;
            this.lbl_level.Text = "1";
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(12, 48);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(760, 502);
            this.canvas.TabIndex = 2;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.lbl_level);
            this.Controls.Add(this.sb_level);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar sb_level;
        private System.Windows.Forms.Label lbl_level;
        private System.Windows.Forms.PictureBox canvas;
    }
}

