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
            this.SuspendLayout();
            // 
            // MainButton
            // 
            this.MainButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.MainButton.Location = new System.Drawing.Point(323, 130);
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
            this.ClockDisplay.Location = new System.Drawing.Point(297, 190);
            this.ClockDisplay.Name = "ClockDisplay";
            this.ClockDisplay.Size = new System.Drawing.Size(160, 45);
            this.ClockDisplay.TabIndex = 1;
            this.ClockDisplay.Text = "00:00:00";
            this.ClockDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainProgressBar
            // 
            this.MainProgressBar.Location = new System.Drawing.Point(305, 12);
            this.MainProgressBar.Name = "MainProgressBar";
            this.MainProgressBar.Size = new System.Drawing.Size(145, 22);
            this.MainProgressBar.TabIndex = 2;
            // 
            // WinText
            // 
            this.WinText.AutoSize = true;
            this.WinText.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.WinText.ForeColor = System.Drawing.Color.Transparent;
            this.WinText.Location = new System.Drawing.Point(456, 9);
            this.WinText.Name = "WinText";
            this.WinText.Size = new System.Drawing.Size(136, 40);
            this.WinText.TabIndex = 3;
            this.WinText.Text = "You Win!";
            // 
            // ClickAmount10
            // 
            this.ClickAmount10.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ClickAmount10.Location = new System.Drawing.Point(172, 74);
            this.ClickAmount10.Name = "ClickAmount10";
            this.ClickAmount10.Size = new System.Drawing.Size(86, 44);
            this.ClickAmount10.TabIndex = 4;
            this.ClickAmount10.Text = "10";
            this.ClickAmount10.UseVisualStyleBackColor = true;
            this.ClickAmount10.Click += new System.EventHandler(this.ClickAmount10_Click);
            // 
            // ClickAmount25
            // 
            this.ClickAmount25.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ClickAmount25.Location = new System.Drawing.Point(323, 74);
            this.ClickAmount25.Name = "ClickAmount25";
            this.ClickAmount25.Size = new System.Drawing.Size(99, 44);
            this.ClickAmount25.TabIndex = 5;
            this.ClickAmount25.Text = "25";
            this.ClickAmount25.UseVisualStyleBackColor = true;
            this.ClickAmount25.Click += new System.EventHandler(this.ClickAmount25_Click);
            // 
            // ClickAmount50
            // 
            this.ClickAmount50.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ClickAmount50.Location = new System.Drawing.Point(454, 74);
            this.ClickAmount50.Name = "ClickAmount50";
            this.ClickAmount50.Size = new System.Drawing.Size(117, 44);
            this.ClickAmount50.TabIndex = 6;
            this.ClickAmount50.Text = "50";
            this.ClickAmount50.UseVisualStyleBackColor = true;
            this.ClickAmount50.Click += new System.EventHandler(this.ClickAmount50_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

