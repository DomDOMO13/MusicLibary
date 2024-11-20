namespace musicplayer
{
    partial class Search
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
            searchBtn = new Button();
            nameTb = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // searchBtn
            // 
            searchBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBtn.Location = new Point(140, 162);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(150, 56);
            searchBtn.TabIndex = 12;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // nameTb
            // 
            nameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTb.Location = new Point(30, 90);
            nameTb.Name = "nameTb";
            nameTb.Size = new Size(371, 34);
            nameTb.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 46);
            label3.Name = "label3";
            label3.Size = new Size(77, 31);
            label3.TabIndex = 10;
            label3.Text = "Name";
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(430, 264);
            Controls.Add(searchBtn);
            Controls.Add(nameTb);
            Controls.Add(label3);
            Name = "Search";
            Text = "Search";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchBtn;
        private TextBox nameTb;
        private Label label3;
    }
}