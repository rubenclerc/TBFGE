
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
            this.closeButton = new System.Windows.Forms.Button();
            this.charactersGroupbox = new System.Windows.Forms.GroupBox();
            this.list = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.yourCharactersGroupbox = new System.Windows.Forms.GroupBox();
            this.mainTitleLabel = new System.Windows.Forms.Label();
            this.charactersGroupbox.SuspendLayout();
            this.yourCharactersGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 12);
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
            this.charactersGroupbox.Location = new System.Drawing.Point(324, 80);
            this.charactersGroupbox.Name = "charactersGroupbox";
            this.charactersGroupbox.Size = new System.Drawing.Size(276, 437);
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
            this.list.Size = new System.Drawing.Size(264, 409);
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(263, 415);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Vision";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Rarity";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Weapon";
            // 
            // yourCharactersGroupbox
            // 
            this.yourCharactersGroupbox.Controls.Add(this.listView1);
            this.yourCharactersGroupbox.Location = new System.Drawing.Point(625, 80);
            this.yourCharactersGroupbox.Name = "yourCharactersGroupbox";
            this.yourCharactersGroupbox.Size = new System.Drawing.Size(275, 437);
            this.yourCharactersGroupbox.TabIndex = 7;
            this.yourCharactersGroupbox.TabStop = false;
            this.yourCharactersGroupbox.Text = "Your characters";
            // 
            // mainTitleLabel
            // 
            this.mainTitleLabel.AutoSize = true;
            this.mainTitleLabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainTitleLabel.Location = new System.Drawing.Point(-1, 147);
            this.mainTitleLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.mainTitleLabel.Name = "mainTitleLabel";
            this.mainTitleLabel.Size = new System.Drawing.Size(325, 258);
            this.mainTitleLabel.TabIndex = 8;
            this.mainTitleLabel.Text = "Select  your characters";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 535);
            this.Controls.Add(this.mainTitleLabel);
            this.Controls.Add(this.yourCharactersGroupbox);
            this.Controls.Add(this.charactersGroupbox);
            this.Controls.Add(this.closeButton);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.charactersGroupbox.ResumeLayout(false);
            this.yourCharactersGroupbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader rarity;
        private System.Windows.Forms.ColumnHeader weapon;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox charactersGroupbox;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox yourCharactersGroupbox;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label mainTitleLabel;
    }
}