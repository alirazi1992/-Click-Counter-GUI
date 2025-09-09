namespace ClickCounterGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblCps;
        private System.Windows.Forms.Label lblStreak;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.CheckBox chkSound;
        private System.Windows.Forms.Timer timer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnClick = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblCps = new System.Windows.Forms.Label();
            this.lblStreak = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.chkSound = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClick.Location = new System.Drawing.Point(20, 20);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(140, 48);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "CLICK!";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(170, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 48);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCount.Location = new System.Drawing.Point(20, 80);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(72, 19);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "Count: 0";
            // 
            // lblCps
            // 
            this.lblCps.AutoSize = true;
            this.lblCps.Location = new System.Drawing.Point(20, 105);
            this.lblCps.Name = "lblCps";
            this.lblCps.Size = new System.Drawing.Size(85, 13);
            this.lblCps.TabIndex = 3;
            this.lblCps.Text = "CPS: 0 (best 0)";
            // 
            // lblStreak
            // 
            this.lblStreak.AutoSize = true;
            this.lblStreak.Location = new System.Drawing.Point(20, 125);
            this.lblStreak.Name = "lblStreak";
            this.lblStreak.Size = new System.Drawing.Size(57, 13);
            this.lblStreak.TabIndex = 4;
            this.lblStreak.Text = "Streak: 0";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(20, 148);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(240, 16);
            this.progress.TabIndex = 5;
            // 
            // chkSound
            // 
            this.chkSound.AutoSize = true;
            this.chkSound.Location = new System.Drawing.Point(170, 80);
            this.chkSound.Name = "chkSound";
            this.chkSound.Size = new System.Drawing.Size(92, 17);
            this.chkSound.TabIndex = 6;
            this.chkSound.Text = "Beep on click";
            this.chkSound.UseVisualStyleBackColor = true;
            this.chkSound.CheckedChanged += new System.EventHandler(this.chkSound_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnClick;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.Controls.Add(this.chkSound);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.lblStreak);
            this.Controls.Add(this.lblCps);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Click Counter (Day 14)";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
