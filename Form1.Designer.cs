namespace Hockey_Stats
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
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.Assists = new System.Windows.Forms.NumericUpDown();
            this.Goals = new System.Windows.Forms.NumericUpDown();
            this.Number = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PlayerLock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Assists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goals)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerName
            // 
            this.PlayerName.Location = new System.Drawing.Point(49, 11);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(122, 20);
            this.PlayerName.TabIndex = 1;
            this.PlayerName.TextChanged += new System.EventHandler(this.PlayerName_TextChanged);
            // 
            // Assists
            // 
            this.Assists.InterceptArrowKeys = false;
            this.Assists.Location = new System.Drawing.Point(228, 12);
            this.Assists.Name = "Assists";
            this.Assists.ReadOnly = true;
            this.Assists.Size = new System.Drawing.Size(44, 20);
            this.Assists.TabIndex = 4;
            this.Assists.TabStop = false;
            this.Assists.ValueChanged += new System.EventHandler(this.Assists_ValueChanged);
            // 
            // Goals
            // 
            this.Goals.Cursor = System.Windows.Forms.Cursors.Default;
            this.Goals.InterceptArrowKeys = false;
            this.Goals.Location = new System.Drawing.Point(178, 12);
            this.Goals.Name = "Goals";
            this.Goals.ReadOnly = true;
            this.Goals.Size = new System.Drawing.Size(44, 20);
            this.Goals.TabIndex = 3;
            this.Goals.TabStop = false;
            this.Goals.ValueChanged += new System.EventHandler(this.Goals_ValueChanged);
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(12, 11);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(31, 20);
            this.Number.TabIndex = 0;
            this.Number.TextChanged += new System.EventHandler(this.Number_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PlayerLock
            // 
            this.PlayerLock.Location = new System.Drawing.Point(12, 37);
            this.PlayerLock.Name = "PlayerLock";
            this.PlayerLock.Size = new System.Drawing.Size(159, 23);
            this.PlayerLock.TabIndex = 6;
            this.PlayerLock.Text = "Lock Players";
            this.PlayerLock.UseVisualStyleBackColor = true;
            this.PlayerLock.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.PlayerLock);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Goals);
            this.Controls.Add(this.Assists);
            this.Controls.Add(this.PlayerName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Assists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.NumericUpDown Assists;
        private System.Windows.Forms.NumericUpDown Goals;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PlayerLock;
    }
}

