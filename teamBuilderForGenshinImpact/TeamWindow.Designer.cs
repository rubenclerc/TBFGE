
namespace teamBuilderForGenshinImpact
{
    partial class TeamWindow
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
            this.newTeamListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.downloadButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newTeamListView
            // 
            this.newTeamListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5});
            this.newTeamListView.HideSelection = false;
            this.newTeamListView.Location = new System.Drawing.Point(224, 83);
            this.newTeamListView.Name = "newTeamListView";
            this.newTeamListView.Size = new System.Drawing.Size(178, 117);
            this.newTeamListView.TabIndex = 0;
            this.newTeamListView.UseCompatibleStateImageBehavior = false;
            this.newTeamListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Role";
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(247, 206);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(129, 27);
            this.downloadButton.TabIndex = 1;
            this.downloadButton.Text = "Download my team";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(13, 13);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close app";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // TeamWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 381);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.newTeamListView);
            this.Name = "TeamWindow";
            this.Text = "TeamWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView newTeamListView;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button closeButton;
    }
}