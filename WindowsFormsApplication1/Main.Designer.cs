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
            this.radioButtonVendor = new System.Windows.Forms.RadioButton();
            this.radioButtonBag = new System.Windows.Forms.RadioButton();
            this.radioButtonForge = new System.Windows.Forms.RadioButton();
            this.Infobutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
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
            this.textBox1.Size = new System.Drawing.Size(91, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lblXas
            // 
            this.lblXas.AutoSize = true;
            this.lblXas.BackColor = System.Drawing.Color.Black;
            this.lblXas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXas.ForeColor = System.Drawing.Color.White;
            this.lblXas.Location = new System.Drawing.Point(22, 165);
            this.lblXas.Name = "lblXas";
            this.lblXas.Size = new System.Drawing.Size(52, 20);
            this.lblXas.TabIndex = 2;
            this.lblXas.Text = "lblXas";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(109, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Set Freebag Slots";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(190, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "Return Sets ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.BackColor = System.Drawing.Color.Black;
            this.lblYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYas.ForeColor = System.Drawing.Color.White;
            this.lblYas.Location = new System.Drawing.Point(22, 185);
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
            this.Status.Location = new System.Drawing.Point(13, 100);
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
            this.label1.Location = new System.Drawing.Point(18, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cursor Posision:";
            // 
            // radioButtonVendor
            // 
            this.radioButtonVendor.AutoSize = true;
            this.radioButtonVendor.BackColor = System.Drawing.Color.Black;
            this.radioButtonVendor.ForeColor = System.Drawing.Color.White;
            this.radioButtonVendor.Location = new System.Drawing.Point(183, 125);
            this.radioButtonVendor.Name = "radioButtonVendor";
            this.radioButtonVendor.Size = new System.Drawing.Size(89, 17);
            this.radioButtonVendor.TabIndex = 8;
            this.radioButtonVendor.TabStop = true;
            this.radioButtonVendor.Text = "Move Vendor";
            this.radioButtonVendor.UseVisualStyleBackColor = false;
            // 
            // radioButtonBag
            // 
            this.radioButtonBag.AutoSize = true;
            this.radioButtonBag.BackColor = System.Drawing.Color.Black;
            this.radioButtonBag.ForeColor = System.Drawing.Color.White;
            this.radioButtonBag.Location = new System.Drawing.Point(183, 148);
            this.radioButtonBag.Name = "radioButtonBag";
            this.radioButtonBag.Size = new System.Drawing.Size(74, 17);
            this.radioButtonBag.TabIndex = 9;
            this.radioButtonBag.TabStop = true;
            this.radioButtonBag.Text = "Move Bag";
            this.radioButtonBag.UseVisualStyleBackColor = false;
            // 
            // radioButtonForge
            // 
            this.radioButtonForge.AutoSize = true;
            this.radioButtonForge.BackColor = System.Drawing.Color.Black;
            this.radioButtonForge.ForeColor = System.Drawing.Color.White;
            this.radioButtonForge.Location = new System.Drawing.Point(183, 171);
            this.radioButtonForge.Name = "radioButtonForge";
            this.radioButtonForge.Size = new System.Drawing.Size(82, 17);
            this.radioButtonForge.TabIndex = 10;
            this.radioButtonForge.TabStop = true;
            this.radioButtonForge.Text = "Move Forge";
            this.radioButtonForge.UseVisualStyleBackColor = false;
            // 
            // Infobutton
            // 
            this.Infobutton.Location = new System.Drawing.Point(28, 226);
            this.Infobutton.Name = "Infobutton";
            this.Infobutton.Size = new System.Drawing.Size(75, 23);
            this.Infobutton.TabIndex = 11;
            this.Infobutton.Text = "Info";
            this.Infobutton.UseVisualStyleBackColor = true;
            this.Infobutton.Click += new System.EventHandler(this.Infobutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "First fill your free bag slots and click button to set them";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(183, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // KarmaConvertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Infobutton);
            this.Controls.Add(this.radioButtonForge);
            this.Controls.Add(this.radioButtonBag);
            this.Controls.Add(this.radioButtonVendor);
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
        private System.Windows.Forms.RadioButton radioButtonVendor;
        private System.Windows.Forms.RadioButton radioButtonBag;
        private System.Windows.Forms.RadioButton radioButtonForge;
        private System.Windows.Forms.Button Infobutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}

