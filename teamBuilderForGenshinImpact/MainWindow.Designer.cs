
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
            this.charactList = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.yourCharactersGroupbox = new System.Windows.Forms.GroupBox();
            this.mainTitleLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.resonanceGroupbox = new System.Windows.Forms.GroupBox();
            this.resonanceCheckBox = new System.Windows.Forms.CheckedListBox();
            this.createButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.charactersGroupbox.SuspendLayout();
            this.yourCharactersGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.resonanceGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close app";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // charactersGroupbox
            // 
            this.charactersGroupbox.Controls.Add(this.list);
            this.charactersGroupbox.Location = new System.Drawing.Point(324, 80);
            this.charactersGroupbox.Name = "charactersGroupbox";
            this.charactersGroupbox.Size = new System.Drawing.Size(316, 410);
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
            this.list.Size = new System.Drawing.Size(304, 380);
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
            // charactList
            // 
            this.charactList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.charactList.HideSelection = false;
            this.charactList.Location = new System.Drawing.Point(6, 22);
            this.charactList.Name = "charactList";
            this.charactList.Size = new System.Drawing.Size(285, 380);
            this.charactList.TabIndex = 6;
            this.charactList.UseCompatibleStateImageBehavior = false;
            this.charactList.View = System.Windows.Forms.View.Details;
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
            this.yourCharactersGroupbox.Controls.Add(this.charactList);
            this.yourCharactersGroupbox.Location = new System.Drawing.Point(859, 80);
            this.yourCharactersGroupbox.Name = "yourCharactersGroupbox";
            this.yourCharactersGroupbox.Size = new System.Drawing.Size(297, 410);
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
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(667, 147);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(160, 33);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // resonanceGroupbox
            // 
            this.resonanceGroupbox.Controls.Add(this.resonanceCheckBox);
            this.resonanceGroupbox.Location = new System.Drawing.Point(646, 231);
            this.resonanceGroupbox.Name = "resonanceGroupbox";
            this.resonanceGroupbox.Size = new System.Drawing.Size(207, 139);
            this.resonanceGroupbox.TabIndex = 11;
            this.resonanceGroupbox.TabStop = false;
            this.resonanceGroupbox.Text = "Elementary resonance";
            // 
            // resonanceCheckBox
            // 
            this.resonanceCheckBox.FormattingEnabled = true;
            this.resonanceCheckBox.Items.AddRange(new object[] {
            "Electro",
            "Pyro",
            "Anemo",
            "Cryo",
            "Geo",
            "Hydro"});
            this.resonanceCheckBox.Location = new System.Drawing.Point(2, 22);
            this.resonanceCheckBox.Name = "resonanceCheckBox";
            this.resonanceCheckBox.Size = new System.Drawing.Size(199, 112);
            this.resonanceCheckBox.TabIndex = 14;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createButton.Location = new System.Drawing.Point(646, 376);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(207, 114);
            this.createButton.TabIndex = 12;
            this.createButton.Text = "START";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(667, 186);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(160, 33);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 573);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.resonanceGroupbox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.mainTitleLabel);
            this.Controls.Add(this.yourCharactersGroupbox);
            this.Controls.Add(this.charactersGroupbox);
            this.Controls.Add(this.closeButton);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.charactersGroupbox.ResumeLayout(false);
            this.yourCharactersGroupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.resonanceGroupbox.ResumeLayout(false);
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
        private System.Windows.Forms.ListView charactList;
        private System.Windows.Forms.GroupBox yourCharactersGroupbox;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label mainTitleLabel;
        private System.Windows.Forms.Button addButton;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox resonanceGroupbox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.CheckedListBox resonanceCheckBox;
    }
}