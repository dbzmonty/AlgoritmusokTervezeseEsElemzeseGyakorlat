namespace _30_Gyakorlas_Rajzolos_Y
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
            this.scr_level = new System.Windows.Forms.HScrollBar();
            this.lbl_level = new System.Windows.Forms.Label();
            this.Canvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // scr_level
            // 
            this.scr_level.LargeChange = 1;
            this.scr_level.Location = new System.Drawing.Point(9, 9);
            this.scr_level.Maximum = 5;
            this.scr_level.Minimum = 1;
            this.scr_level.Name = "scr_level";
            this.scr_level.Size = new System.Drawing.Size(720, 20);
            this.scr_level.TabIndex = 0;
            this.scr_level.Value = 1;
            this.scr_level.ValueChanged += new System.EventHandler(this.scr_level_ValueChanged);
            // 
            // lbl_level
            // 
            this.lbl_level.AutoSize = true;
            this.lbl_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_level.Location = new System.Drawing.Point(732, 9);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(18, 20);
            this.lbl_level.TabIndex = 1;
            this.lbl_level.Text = "1";
            // 
            // Canvas
            // 
            this.Canvas.Location = new System.Drawing.Point(13, 33);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(759, 516);
            this.Canvas.TabIndex = 2;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.lbl_level);
            this.Controls.Add(this.scr_level);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar scr_level;
        private System.Windows.Forms.Label lbl_level;
        private System.Windows.Forms.PictureBox Canvas;
    }
}

