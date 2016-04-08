namespace KarmaConvertor
{
    partial class KarmaConvertor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KarmaConvertor));
            this.Forge = new System.Windows.Forms.Timer(this.components);
            this.Realforge = new System.Windows.Forms.Timer(this.components);
            this.testTimer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblXas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblYas = new System.Windows.Forms.Label();
            this.MouseTrackTimer = new System.Windows.Forms.Timer(this.components);
            this.Status = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Forge
            // 
            this.Forge.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Realforge
            // 
            this.Realforge.Tick += new System.EventHandler(this.Realforge_Tick);
            // 
            // testTimer1
            // 
            this.testTimer1.Tick += new System.EventHandler(this.testTimer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lblXas
            // 
            this.lblXas.AutoSize = true;
            this.lblXas.BackColor = System.Drawing.Color.Black;
            this.lblXas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXas.ForeColor = System.Drawing.Color.White;
            this.lblXas.Location = new System.Drawing.Point(12, 212);
            this.lblXas.Name = "lblXas";
            this.lblXas.Size = new System.Drawing.Size(52, 20);
            this.lblXas.TabIndex = 2;
            this.lblXas.Text = "lblXas";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(83, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Set PackCount";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(197, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "Return PackCount value";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.BackColor = System.Drawing.Color.Black;
            this.lblYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYas.ForeColor = System.Drawing.Color.White;
            this.lblYas.Location = new System.Drawing.Point(12, 232);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(52, 20);
            this.lblYas.TabIndex = 5;
            this.lblYas.Text = "lblYas";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.BackColor = System.Drawing.Color.Black;
            this.Status.ForeColor = System.Drawing.Color.White;
            this.Status.Location = new System.Drawing.Point(13, 159);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(128, 13);
            this.Status.TabIndex = 6;
            this.Status.Text = "Currently: Waiting for start";
            this.Status.Click += new System.EventHandler(this.label1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cursor Posision:";
            // 
            // KarmaConvertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblXas);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KarmaConvertor";
            this.Text = "KarmaConvert Bot V0.6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Forge;
        private System.Windows.Forms.Timer Realforge;
        private System.Windows.Forms.Timer testTimer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblXas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Timer MouseTrackTimer;
        private System.Windows.Forms.Label Status;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
    }
}

