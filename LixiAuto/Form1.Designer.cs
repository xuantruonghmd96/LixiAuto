namespace LixiAuto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.tbxScreenSavePath = new System.Windows.Forms.TextBox();
            this.LblCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numHue = new System.Windows.Forms.NumericUpDown();
            this.numSaturation = new System.Windows.Forms.NumericUpDown();
            this.numBrightness = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(189, 102);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(81, 78);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbxScreenSavePath
            // 
            this.tbxScreenSavePath.Location = new System.Drawing.Point(34, 36);
            this.tbxScreenSavePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxScreenSavePath.Name = "tbxScreenSavePath";
            this.tbxScreenSavePath.Size = new System.Drawing.Size(114, 27);
            this.tbxScreenSavePath.TabIndex = 1;
            this.tbxScreenSavePath.Tag = "";
            this.tbxScreenSavePath.Text = "D:\\Downloads\\LixiAutoOutput";
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCount.Location = new System.Drawing.Point(200, 43);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(51, 20);
            this.LblCount.TabIndex = 2;
            this.LblCount.Text = "Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saturation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Brightness";
            // 
            // numHue
            // 
            this.numHue.Location = new System.Drawing.Point(110, 86);
            this.numHue.Name = "numHue";
            this.numHue.Size = new System.Drawing.Size(46, 27);
            this.numHue.TabIndex = 9;
            // 
            // numSaturation
            // 
            this.numSaturation.Location = new System.Drawing.Point(110, 119);
            this.numSaturation.Name = "numSaturation";
            this.numSaturation.Size = new System.Drawing.Size(46, 27);
            this.numSaturation.TabIndex = 10;
            // 
            // numBrightness
            // 
            this.numBrightness.Location = new System.Drawing.Point(110, 152);
            this.numBrightness.Name = "numBrightness";
            this.numBrightness.Size = new System.Drawing.Size(46, 27);
            this.numBrightness.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 314);
            this.Controls.Add(this.numBrightness);
            this.Controls.Add(this.numSaturation);
            this.Controls.Add(this.numHue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.tbxScreenSavePath);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStart;
        private TextBox tbxScreenSavePath;
        private Label LblCount;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numHue;
        private NumericUpDown numSaturation;
        private NumericUpDown numBrightness;
    }
}