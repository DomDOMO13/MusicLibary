namespace musicplayer
{
    partial class Delete
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
            deleteBtn = new Button();
            nameTb = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.Location = new Point(138, 161);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(150, 56);
            deleteBtn.TabIndex = 9;
            deleteBtn.Text = "Search";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // nameTb
            // 
            nameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTb.Location = new Point(28, 89);
            nameTb.Name = "nameTb";
            nameTb.Size = new Size(371, 34);
            nameTb.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 45);
            label3.Name = "label3";
            label3.Size = new Size(77, 31);
            label3.TabIndex = 7;
            label3.Text = "Name";
            // 
            // Delete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(430, 264);
            Controls.Add(deleteBtn);
            Controls.Add(nameTb);
            Controls.Add(label3);
            Name = "Delete";
            Text = "Delete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteBtn;
        private TextBox nameTb;
        private Label label3;
    }
}