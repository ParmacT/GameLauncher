
namespace WinFormsApp1
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
            this.starttor = new System.Windows.Forms.Button();
            this.Farcry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Beat_Saber = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Bn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SteamVR = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // starttor
            // 
            this.starttor.Image = ((System.Drawing.Image)(resources.GetObject("starttor.Image")));
            this.starttor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.starttor.Location = new System.Drawing.Point(21, 12);
            this.starttor.Name = "starttor";
            this.starttor.Size = new System.Drawing.Size(228, 223);
            this.starttor.TabIndex = 0;
            this.starttor.UseVisualStyleBackColor = true;
            this.starttor.Click += new System.EventHandler(this.button1_Click);
            // 
            // Farcry
            // 
            this.Farcry.Image = ((System.Drawing.Image)(resources.GetObject("Farcry.Image")));
            this.Farcry.Location = new System.Drawing.Point(266, 12);
            this.Farcry.Name = "Farcry";
            this.Farcry.Size = new System.Drawing.Size(266, 223);
            this.Farcry.TabIndex = 1;
            this.Farcry.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Farcry.UseVisualStyleBackColor = true;
            this.Farcry.Click += new System.EventHandler(this.Farcry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tor Browser";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "FarCry 5";
            // 
            // Beat_Saber
            // 
            this.Beat_Saber.Image = ((System.Drawing.Image)(resources.GetObject("Beat_Saber.Image")));
            this.Beat_Saber.Location = new System.Drawing.Point(575, 12);
            this.Beat_Saber.Name = "Beat_Saber";
            this.Beat_Saber.Size = new System.Drawing.Size(234, 225);
            this.Beat_Saber.TabIndex = 4;
            this.Beat_Saber.UseVisualStyleBackColor = true;
            this.Beat_Saber.Click += new System.EventHandler(this.Beat_Saber_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(664, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Beat Saber";
            // 
            // Bn
            // 
            this.Bn.BackColor = System.Drawing.SystemColors.Control;
            this.Bn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bn.Image = ((System.Drawing.Image)(resources.GetObject("Bn.Image")));
            this.Bn.Location = new System.Drawing.Point(833, 12);
            this.Bn.Name = "Bn";
            this.Bn.Size = new System.Drawing.Size(251, 223);
            this.Bn.TabIndex = 6;
            this.Bn.UseVisualStyleBackColor = false;
            this.Bn.Click += new System.EventHandler(this.Bn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(921, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "BoneWorks";
            // 
            // SteamVR
            // 
            this.SteamVR.Image = ((System.Drawing.Image)(resources.GetObject("SteamVR.Image")));
            this.SteamVR.Location = new System.Drawing.Point(21, 256);
            this.SteamVR.Name = "SteamVR";
            this.SteamVR.Size = new System.Drawing.Size(321, 217);
            this.SteamVR.TabIndex = 8;
            this.SteamVR.UseVisualStyleBackColor = true;
            this.SteamVR.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "SteamVR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1119, 523);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(194, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Launcher Base Made by TheCracker";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1329, 554);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 547);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SteamVR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Bn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Beat_Saber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Farcry);
            this.Controls.Add(this.starttor);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        

        private System.Windows.Forms.Button starttor;
        //RENAME TO ALL YOUR GAMES HERE 
        
        //TOR BROWSER HERE
        public string Tor = "C:\\Users\\Administrator\\Desktop\\Tor Browser\\Browser\\firefox.exe";
        private System.Windows.Forms.Button Farcry;
        
        //FARCRY 5 HERE
        public string FarCry5 = "D:\\Far Cry 5\\bin\\FarCry5.exe";
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Beat_Saber;

        //BEATSABER HERE
        public string Beatsaber = "D:\\VR\\Beat.Saber.v1.14.0\\Beat Saber.exe";
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bn;
        private System.Windows.Forms.Label label4;

        //BONEWORKS HERE
        public string Boneworks = "D:\\VR\\BONEWORKS\\BONEWORKS.exr";
private System.Windows.Forms.Button SteamVR;
        private System.Windows.Forms.Label label5;

        //SteamVR HERE
        public string Steamv = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\SteamVR\\bin\\win64\\vrstartup.exe";
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

