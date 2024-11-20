namespace musicplayer.Delete
{
    partial class DeleteConfirm
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
            label1 = new Label();
            yesBtn = new Button();
            noBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 54);
            label1.Name = "label1";
            label1.Size = new Size(468, 31);
            label1.TabIndex = 0;
            label1.Text = "Are you sure you want to delete this song?";
            // 
            // yesBtn
            // 
            yesBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            yesBtn.Location = new Point(102, 128);
            yesBtn.Name = "yesBtn";
            yesBtn.Size = new Size(119, 48);
            yesBtn.TabIndex = 1;
            yesBtn.Text = "Yes";
            yesBtn.UseVisualStyleBackColor = true;
            // 
            // noBtn
            // 
            noBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            noBtn.Location = new Point(296, 128);
            noBtn.Name = "noBtn";
            noBtn.Size = new Size(119, 48);
            noBtn.TabIndex = 2;
            noBtn.Text = "No";
            noBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteConfirm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 215);
            Controls.Add(noBtn);
            Controls.Add(yesBtn);
            Controls.Add(label1);
            Name = "DeleteConfirm";
            Text = "DeleteConfirm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button yesBtn;
        private Button noBtn;
    }
}