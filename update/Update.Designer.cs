namespace musicplayer
{
    partial class Update
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
            nameTb = new TextBox();
            label3 = new Label();
            updateBtn = new Button();
            genreTb = new TextBox();
            label1 = new Label();
            artistTb = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // nameTb
            // 
            nameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTb.Location = new Point(49, 75);
            nameTb.Name = "nameTb";
            nameTb.Size = new Size(371, 34);
            nameTb.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 31);
            label3.Name = "label3";
            label3.Size = new Size(77, 31);
            label3.TabIndex = 10;
            label3.Text = "Name";
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.Location = new Point(144, 326);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(150, 56);
            updateBtn.TabIndex = 15;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // genreTb
            // 
            genreTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genreTb.Location = new Point(49, 168);
            genreTb.Name = "genreTb";
            genreTb.Size = new Size(371, 34);
            genreTb.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 124);
            label1.Name = "label1";
            label1.Size = new Size(77, 31);
            label1.TabIndex = 13;
            label1.Text = "Genre";
            // 
            // artistTb
            // 
            artistTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            artistTb.Location = new Point(49, 263);
            artistTb.Name = "artistTb";
            artistTb.Size = new Size(371, 34);
            artistTb.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 219);
            label2.Name = "label2";
            label2.Size = new Size(75, 31);
            label2.TabIndex = 16;
            label2.Text = "Artist";
            // 
            // Update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(466, 433);
            Controls.Add(artistTb);
            Controls.Add(label2);
            Controls.Add(updateBtn);
            Controls.Add(genreTb);
            Controls.Add(label1);
            Controls.Add(nameTb);
            Controls.Add(label3);
            Name = "Update";
            Text = "Update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTb;
        private Label label3;
        private Button updateBtn;
        private TextBox genreTb;
        private Label label1;
        private TextBox artistTb;
        private Label label2;
    }
}