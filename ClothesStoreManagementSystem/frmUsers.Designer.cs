namespace ClothesStoreManagementSystem
{
    partial class frmUsers
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
            grUsers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grUsers).BeginInit();
            SuspendLayout();
            // 
            // grUsers
            // 
            grUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grUsers.Location = new Point(2, 173);
            grUsers.Name = "grUsers";
            grUsers.RowHeadersWidth = 51;
            grUsers.RowTemplate.Height = 29;
            grUsers.Size = new Size(1210, 471);
            grUsers.TabIndex = 0;
            // 
            // frmUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 644);
            Controls.Add(grUsers);
            Name = "frmUsers";
            Text = "frmUsers";
            Load += frmUsers_Load;
            ((System.ComponentModel.ISupportInitialize)grUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grUsers;
    }
}