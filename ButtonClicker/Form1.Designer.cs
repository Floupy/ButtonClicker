namespace ButtonClicker
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
            this.components = new System.ComponentModel.Container();
            this.MainButton = new System.Windows.Forms.Button();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.ClockDisplay = new System.Windows.Forms.Label();
            this.MainProgressBar = new System.Windows.Forms.ProgressBar();
            this.WinText = new System.Windows.Forms.Label();
            this.ClickAmount10 = new System.Windows.Forms.Button();
            this.ClickAmount25 = new System.Windows.Forms.Button();
            this.ClickAmount50 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ClicksPerSecondShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainButton
            // 
            this.MainButton.Enabled = false;
            this.MainButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.MainButton.Location = new System.Drawing.Point(312, 147);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(112, 57);
            this.MainButton.TabIndex = 0;
            this.MainButton.Text = "Button";
            this.MainButton.UseVisualStyleBackColor = true;
            this.MainButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 1;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // ClockDisplay
            // 
            this.ClockDisplay.AutoSize = true;
            this.ClockDisplay.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ClockDisplay.Location = new System.Drawing.Point(292, 23);
            this.ClockDisplay.Name = "ClockDisplay";
            this.ClockDisplay.Size = new System.Drawing.Size(160, 45);
            this.ClockDisplay.TabIndex = 1;
            this.ClockDisplay.Text = "00:00:00";
            this.ClockDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainProgressBar
            // 
            this.MainProgressBar.Location = new System.Drawing.Point(289, 81);
            this.MainProgressBar.Name = "MainProgressBar";
            this.MainProgressBar.Size = new System.Drawing.Size(163, 38);
            this.MainProgressBar.TabIndex = 2;
            // 
            // WinText
            // 
            this.WinText.AutoSize = true;
            this.WinText.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.WinText.ForeColor = System.Drawing.Color.Black;
            this.WinText.Location = new System.Drawing.Point(260, 223);
            this.WinText.Name = "WinText";
            this.WinText.Size = new System.Drawing.Size(223, 67);
            this.WinText.TabIndex = 3;
            this.WinText.Text = "You Win!";
            this.WinText.Visible = false;
            // 
            // ClickAmount10
            // 
            this.ClickAmount10.BackColor = System.Drawing.Color.White;
            this.ClickAmount10.FlatAppearance.BorderSize = 0;
            this.ClickAmount10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClickAmount10.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ClickAmount10.ForeColor = System.Drawing.Color.Black;
            this.ClickAmount10.Location = new System.Drawing.Point(565, 245);
            this.ClickAmount10.Margin = new System.Windows.Forms.Padding(0);
            this.ClickAmount10.Name = "ClickAmount10";
            this.ClickAmount10.Size = new System.Drawing.Size(50, 50);
            this.ClickAmount10.TabIndex = 4;
            this.ClickAmount10.Text = "10";
            this.ClickAmount10.UseVisualStyleBackColor = false;
            this.ClickAmount10.Click += new System.EventHandler(this.ClickAmount10_Click);
            // 
            // ClickAmount25
            // 
            this.ClickAmount25.BackColor = System.Drawing.Color.White;
            this.ClickAmount25.FlatAppearance.BorderSize = 0;
            this.ClickAmount25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClickAmount25.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ClickAmount25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClickAmount25.Location = new System.Drawing.Point(635, 245);
            this.ClickAmount25.Margin = new System.Windows.Forms.Padding(0);
            this.ClickAmount25.Name = "ClickAmount25";
            this.ClickAmount25.Size = new System.Drawing.Size(50, 50);
            this.ClickAmount25.TabIndex = 5;
            this.ClickAmount25.Text = "25";
            this.ClickAmount25.UseVisualStyleBackColor = false;
            this.ClickAmount25.Click += new System.EventHandler(this.ClickAmount25_Click);
            // 
            // ClickAmount50
            // 
            this.ClickAmount50.BackColor = System.Drawing.Color.White;
            this.ClickAmount50.FlatAppearance.BorderSize = 0;
            this.ClickAmount50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClickAmount50.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ClickAmount50.ForeColor = System.Drawing.Color.Black;
            this.ClickAmount50.Location = new System.Drawing.Point(708, 245);
            this.ClickAmount50.Margin = new System.Windows.Forms.Padding(0);
            this.ClickAmount50.Name = "ClickAmount50";
            this.ClickAmount50.Size = new System.Drawing.Size(50, 50);
            this.ClickAmount50.TabIndex = 6;
            this.ClickAmount50.Text = "50";
            this.ClickAmount50.UseVisualStyleBackColor = false;
            this.ClickAmount50.Click += new System.EventHandler(this.ClickAmount50_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(595, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Click amount";
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ResetButton.Location = new System.Drawing.Point(28, 236);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(115, 58);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ClicksPerSecondShow
            // 
            this.ClicksPerSecondShow.AutoSize = true;
            this.ClicksPerSecondShow.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ClicksPerSecondShow.Location = new System.Drawing.Point(51, 185);
            this.ClicksPerSecondShow.Name = "ClicksPerSecondShow";
            this.ClicksPerSecondShow.Size = new System.Drawing.Size(83, 33);
            this.ClicksPerSecondShow.TabIndex = 9;
            this.ClicksPerSecondShow.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.ClicksPerSecondShow);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClickAmount50);
            this.Controls.Add(this.ClickAmount25);
            this.Controls.Add(this.ClickAmount10);
            this.Controls.Add(this.WinText);
            this.Controls.Add(this.MainProgressBar);
            this.Controls.Add(this.ClockDisplay);
            this.Controls.Add(this.MainButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Label ClockDisplay;
        private System.Windows.Forms.ProgressBar MainProgressBar;
        private System.Windows.Forms.Label WinText;
        private System.Windows.Forms.Button ClickAmount10;
        private System.Windows.Forms.Button ClickAmount25;
        private System.Windows.Forms.Button ClickAmount50;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label ClicksPerSecondShow;
    }
}

