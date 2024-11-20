namespace musicplayer
{
    partial class MusicMenu
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
            addbtn = new Button();
            deletebtn = new Button();
            updatebtn = new Button();
            searchBtn = new Button();
            SuspendLayout();
            // 
            // addbtn
            // 
            addbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addbtn.Location = new Point(52, 57);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(160, 82);
            addbtn.TabIndex = 0;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = true;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = SystemColors.HighlightText;
            deletebtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletebtn.Location = new Point(256, 57);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(160, 82);
            deletebtn.TabIndex = 1;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = false;
            // 
            // updatebtn
            // 
            updatebtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatebtn.Location = new Point(52, 183);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(160, 82);
            updatebtn.TabIndex = 2;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            searchBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBtn.Location = new Point(256, 183);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(160, 82);
            searchBtn.TabIndex = 3;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // MusicMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(483, 331);
            Controls.Add(searchBtn);
            Controls.Add(updatebtn);
            Controls.Add(deletebtn);
            Controls.Add(addbtn);
            Name = "MusicMenu";
            Text = "MusicMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button addbtn;
        private Button deletebtn;
        private Button updatebtn;
        private Button searchBtn;
    }
}