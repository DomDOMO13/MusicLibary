namespace musicplayer
{
    partial class AddMenu
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
            label2 = new Label();
            nameTb = new TextBox();
            genreTb = new TextBox();
            artistTb = new TextBox();
            label3 = new Label();
            addBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 27);
            label1.Name = "label1";
            label1.Size = new Size(77, 31);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 129);
            label2.Name = "label2";
            label2.Size = new Size(77, 31);
            label2.TabIndex = 1;
            label2.Text = "Genre";
            // 
            // nameTb
            // 
            nameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTb.Location = new Point(30, 72);
            nameTb.Name = "nameTb";
            nameTb.Size = new Size(371, 34);
            nameTb.TabIndex = 2;
            // 
            // genreTb
            // 
            genreTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genreTb.Location = new Point(30, 173);
            genreTb.Name = "genreTb";
            genreTb.Size = new Size(371, 34);
            genreTb.TabIndex = 3;
            // 
            // artistTb
            // 
            artistTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            artistTb.Location = new Point(30, 279);
            artistTb.Name = "artistTb";
            artistTb.Size = new Size(371, 34);
            artistTb.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 235);
            label3.Name = "label3";
            label3.Size = new Size(75, 31);
            label3.TabIndex = 4;
            label3.Text = "Artist";
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(140, 351);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(150, 56);
            addBtn.TabIndex = 6;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // AddMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(431, 438);
            Controls.Add(addBtn);
            Controls.Add(artistTb);
            Controls.Add(label3);
            Controls.Add(genreTb);
            Controls.Add(nameTb);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddMenu";
            Text = "AddMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nameTb;
        private TextBox genreTb;
        private TextBox artistTb;
        private Label label3;
        private Button addBtn;
    }
}