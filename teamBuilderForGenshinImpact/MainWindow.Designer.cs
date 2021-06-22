
namespace teamBuilderForGenshinImpact
{
    partial class MainWindow
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
            this.refreshButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.charactersGroupbox = new System.Windows.Forms.GroupBox();
            this.list = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.isCon = new System.Windows.Forms.Label();
            this.charactersGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(819, 51);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(13, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // charactersGroupbox
            // 
            this.charactersGroupbox.Controls.Add(this.list);
            this.charactersGroupbox.Location = new System.Drawing.Point(13, 80);
            this.charactersGroupbox.Name = "charactersGroupbox";
            this.charactersGroupbox.Size = new System.Drawing.Size(887, 443);
            this.charactersGroupbox.TabIndex = 4;
            this.charactersGroupbox.TabStop = false;
            this.charactersGroupbox.Text = "Characters  list";
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(6, 22);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(875, 415);
            this.list.TabIndex = 0;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
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
            // isCon
            // 
            this.isCon.AutoSize = true;
            this.isCon.Location = new System.Drawing.Point(124, 12);
            this.isCon.Name = "isCon";
            this.isCon.Size = new System.Drawing.Size(38, 15);
            this.isCon.TabIndex = 5;
            this.isCon.Text = "label1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 535);
            this.Controls.Add(this.isCon);
            this.Controls.Add(this.charactersGroupbox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.refreshButton);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.charactersGroupbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader rarity;
        private System.Windows.Forms.ColumnHeader weapon;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox charactersGroupbox;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label isCon;
    }
}