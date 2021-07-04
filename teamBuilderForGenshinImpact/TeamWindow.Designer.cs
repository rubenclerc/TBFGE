
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
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.downloadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newTeamListView
            // 
            this.newTeamListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.newTeamListView.HideSelection = false;
            this.newTeamListView.Location = new System.Drawing.Point(31, 12);
            this.newTeamListView.Name = "newTeamListView";
            this.newTeamListView.Size = new System.Drawing.Size(386, 204);
            this.newTeamListView.TabIndex = 0;
            this.newTeamListView.UseCompatibleStateImageBehavior = false;
            this.newTeamListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Vision";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Rarity";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Weapon";
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(150, 234);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(129, 26);
            this.downloadButton.TabIndex = 1;
            this.downloadButton.Text = "Download my team";
            this.downloadButton.UseVisualStyleBackColor = true;
            // 
            // TeamWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 290);
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
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}