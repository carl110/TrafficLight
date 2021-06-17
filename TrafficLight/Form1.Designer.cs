
namespace TrafficLight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.picTrafficLight = new System.Windows.Forms.PictureBox();
            this.btnTrafficLight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrafficLight)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(202, 247);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 34);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picTrafficLight
            // 
            this.picTrafficLight.Image = ((System.Drawing.Image)(resources.GetObject("picTrafficLight.Image")));
            this.picTrafficLight.Location = new System.Drawing.Point(350, 50);
            this.picTrafficLight.Name = "picTrafficLight";
            this.picTrafficLight.Size = new System.Drawing.Size(64, 53);
            this.picTrafficLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTrafficLight.TabIndex = 2;
            this.picTrafficLight.TabStop = false;
            // 
            // btnTrafficLight
            // 
            this.btnTrafficLight.Location = new System.Drawing.Point(320, 247);
            this.btnTrafficLight.Name = "btnTrafficLight";
            this.btnTrafficLight.Size = new System.Drawing.Size(112, 34);
            this.btnTrafficLight.TabIndex = 3;
            this.btnTrafficLight.Text = "TrafficLight";
            this.btnTrafficLight.UseVisualStyleBackColor = true;
            this.btnTrafficLight.Click += new System.EventHandler(this.btnTrafficLight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 944);
            this.Controls.Add(this.btnTrafficLight);
            this.Controls.Add(this.picTrafficLight);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrafficLight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picTrafficLight;
        private System.Windows.Forms.Button btnTrafficLight;
    }
}

