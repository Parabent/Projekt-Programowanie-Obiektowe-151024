namespace GłodnyGoku
{
    partial class WyborPostaci
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
            this.ButtonGoku = new System.Windows.Forms.Button();
            this.ButtonVegeta = new System.Windows.Forms.Button();
            this.ButtonGohan = new System.Windows.Forms.Button();
            this.gohan = new System.Windows.Forms.PictureBox();
            this.vegeta = new System.Windows.Forms.PictureBox();
            this.goku = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gohan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vegeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goku)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonGoku
            // 
            this.ButtonGoku.Location = new System.Drawing.Point(33, 352);
            this.ButtonGoku.Name = "ButtonGoku";
            this.ButtonGoku.Size = new System.Drawing.Size(226, 44);
            this.ButtonGoku.TabIndex = 3;
            this.ButtonGoku.Text = "GOKU";
            this.ButtonGoku.UseVisualStyleBackColor = true;
            this.ButtonGoku.Click += new System.EventHandler(this.ButtonGoku_Click);
            // 
            // ButtonVegeta
            // 
            this.ButtonVegeta.Location = new System.Drawing.Point(330, 352);
            this.ButtonVegeta.Name = "ButtonVegeta";
            this.ButtonVegeta.Size = new System.Drawing.Size(226, 44);
            this.ButtonVegeta.TabIndex = 4;
            this.ButtonVegeta.Text = "VEGETA";
            this.ButtonVegeta.UseVisualStyleBackColor = true;
            this.ButtonVegeta.Click += new System.EventHandler(this.ButtonVegeta_Click);
            // 
            // ButtonGohan
            // 
            this.ButtonGohan.Location = new System.Drawing.Point(604, 352);
            this.ButtonGohan.Name = "ButtonGohan";
            this.ButtonGohan.Size = new System.Drawing.Size(226, 44);
            this.ButtonGohan.TabIndex = 5;
            this.ButtonGohan.Text = "GOHAN";
            this.ButtonGohan.UseVisualStyleBackColor = true;
            this.ButtonGohan.Click += new System.EventHandler(this.ButtonGohan_Click);
            // 
            // gohan
            // 
            this.gohan.Image = global::GłodnyGoku.Properties.Resources.gohanDuzy;
            this.gohan.Location = new System.Drawing.Point(604, 126);
            this.gohan.Name = "gohan";
            this.gohan.Size = new System.Drawing.Size(226, 202);
            this.gohan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gohan.TabIndex = 2;
            this.gohan.TabStop = false;
            // 
            // vegeta
            // 
            this.vegeta.Image = global::GłodnyGoku.Properties.Resources.vegetaDuzy;
            this.vegeta.Location = new System.Drawing.Point(330, 126);
            this.vegeta.Name = "vegeta";
            this.vegeta.Size = new System.Drawing.Size(226, 202);
            this.vegeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vegeta.TabIndex = 1;
            this.vegeta.TabStop = false;
            // 
            // goku
            // 
            this.goku.BackColor = System.Drawing.Color.Transparent;
            this.goku.Image = global::GłodnyGoku.Properties.Resources.gokuDuzy;
            this.goku.Location = new System.Drawing.Point(24, 78);
            this.goku.Name = "goku";
            this.goku.Size = new System.Drawing.Size(261, 259);
            this.goku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goku.TabIndex = 0;
            this.goku.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 91);
            this.label1.TabIndex = 15;
            this.label1.Text = "WYBIERZ POSTAĆ";
            // 
            // WyborPostaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonGohan);
            this.Controls.Add(this.ButtonVegeta);
            this.Controls.Add(this.ButtonGoku);
            this.Controls.Add(this.gohan);
            this.Controls.Add(this.vegeta);
            this.Controls.Add(this.goku);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "WyborPostaci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WyborPostaci";
            ((System.ComponentModel.ISupportInitialize)(this.gohan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vegeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox goku;
        private System.Windows.Forms.PictureBox vegeta;
        private System.Windows.Forms.PictureBox gohan;
        private System.Windows.Forms.Button ButtonGoku;
        private System.Windows.Forms.Button ButtonVegeta;
        private System.Windows.Forms.Button ButtonGohan;
        private System.Windows.Forms.Label label1;
    }
}