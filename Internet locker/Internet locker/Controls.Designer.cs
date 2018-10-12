namespace Internet_locker
{
    partial class Controls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controls));
            this.Lock = new System.Windows.Forms.Button();
            this.Unlock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lock
            // 
            this.Lock.Location = new System.Drawing.Point(177, 88);
            this.Lock.Name = "Lock";
            this.Lock.Size = new System.Drawing.Size(75, 23);
            this.Lock.TabIndex = 0;
            this.Lock.Text = "Lock";
            this.Lock.UseVisualStyleBackColor = true;
            this.Lock.Click += new System.EventHandler(this.LockUnlockControls);
            // 
            // Unlock
            // 
            this.Unlock.Location = new System.Drawing.Point(12, 88);
            this.Unlock.Name = "Unlock";
            this.Unlock.Size = new System.Drawing.Size(75, 23);
            this.Unlock.TabIndex = 1;
            this.Unlock.Text = "Unlock";
            this.Unlock.UseVisualStyleBackColor = true;
            this.Unlock.Click += new System.EventHandler(this.LockUnlockControls);
            // 
            // Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 205);
            this.Controls.Add(this.Unlock);
            this.Controls.Add(this.Lock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Controls";
            this.Text = "Net Locker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Controls_FormClosing);
            this.Click += new System.EventHandler(this.LockUnlockControls);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Lock;
        private System.Windows.Forms.Button Unlock;
    }
}