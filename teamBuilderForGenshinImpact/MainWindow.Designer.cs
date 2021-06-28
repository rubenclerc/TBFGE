
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
            this.pyroRadio = new System.Windows.Forms.RadioButton();
            this.resonanceGroupbox = new System.Windows.Forms.GroupBox();
            this.cryoRadio = new System.Windows.Forms.RadioButton();
            this.anemoRadio = new System.Windows.Forms.RadioButton();
            this.geoRadio = new System.Windows.Forms.RadioButton();
            this.electroRadio = new System.Windows.Forms.RadioButton();
            this.hydroRadio = new System.Windows.Forms.RadioButton();
            this.createButton = new System.Windows.Forms.Button();
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
            this.charactList.Size = new System.Drawing.Size(263, 409);
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
            this.yourCharactersGroupbox.Location = new System.Drawing.Point(819, 80);
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
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(624, 192);
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
            // pyroRadio
            // 
            this.pyroRadio.AutoSize = true;
            this.pyroRadio.Location = new System.Drawing.Point(6, 22);
            this.pyroRadio.Name = "pyroRadio";
            this.pyroRadio.Size = new System.Drawing.Size(49, 19);
            this.pyroRadio.TabIndex = 10;
            this.pyroRadio.TabStop = true;
            this.pyroRadio.Text = "Pyro";
            this.pyroRadio.UseVisualStyleBackColor = true;
            // 
            // resonanceGroupbox
            // 
            this.resonanceGroupbox.Controls.Add(this.cryoRadio);
            this.resonanceGroupbox.Controls.Add(this.anemoRadio);
            this.resonanceGroupbox.Controls.Add(this.geoRadio);
            this.resonanceGroupbox.Controls.Add(this.electroRadio);
            this.resonanceGroupbox.Controls.Add(this.hydroRadio);
            this.resonanceGroupbox.Controls.Add(this.pyroRadio);
            this.resonanceGroupbox.Location = new System.Drawing.Point(606, 231);
            this.resonanceGroupbox.Name = "resonanceGroupbox";
            this.resonanceGroupbox.Size = new System.Drawing.Size(207, 174);
            this.resonanceGroupbox.TabIndex = 11;
            this.resonanceGroupbox.TabStop = false;
            this.resonanceGroupbox.Text = "Elementary resonance";
            // 
            // cryoRadio
            // 
            this.cryoRadio.AutoSize = true;
            this.cryoRadio.Location = new System.Drawing.Point(7, 152);
            this.cryoRadio.Name = "cryoRadio";
            this.cryoRadio.Size = new System.Drawing.Size(50, 19);
            this.cryoRadio.TabIndex = 15;
            this.cryoRadio.TabStop = true;
            this.cryoRadio.Text = "Cryo";
            this.cryoRadio.UseVisualStyleBackColor = true;
            // 
            // anemoRadio
            // 
            this.anemoRadio.AutoSize = true;
            this.anemoRadio.Location = new System.Drawing.Point(7, 126);
            this.anemoRadio.Name = "anemoRadio";
            this.anemoRadio.Size = new System.Drawing.Size(64, 19);
            this.anemoRadio.TabIndex = 14;
            this.anemoRadio.TabStop = true;
            this.anemoRadio.Text = "Anemo";
            this.anemoRadio.UseVisualStyleBackColor = true;
            // 
            // geoRadio
            // 
            this.geoRadio.AutoSize = true;
            this.geoRadio.Location = new System.Drawing.Point(7, 100);
            this.geoRadio.Name = "geoRadio";
            this.geoRadio.Size = new System.Drawing.Size(46, 19);
            this.geoRadio.TabIndex = 13;
            this.geoRadio.TabStop = true;
            this.geoRadio.Text = "Geo";
            this.geoRadio.UseVisualStyleBackColor = true;
            // 
            // electroRadio
            // 
            this.electroRadio.AutoSize = true;
            this.electroRadio.Location = new System.Drawing.Point(6, 74);
            this.electroRadio.Name = "electroRadio";
            this.electroRadio.Size = new System.Drawing.Size(61, 19);
            this.electroRadio.TabIndex = 12;
            this.electroRadio.TabStop = true;
            this.electroRadio.Text = "Electro";
            this.electroRadio.UseVisualStyleBackColor = true;
            // 
            // hydroRadio
            // 
            this.hydroRadio.AutoSize = true;
            this.hydroRadio.Location = new System.Drawing.Point(7, 48);
            this.hydroRadio.Name = "hydroRadio";
            this.hydroRadio.Size = new System.Drawing.Size(58, 19);
            this.hydroRadio.TabIndex = 11;
            this.hydroRadio.TabStop = true;
            this.hydroRadio.Text = "Hydro";
            this.hydroRadio.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createButton.Location = new System.Drawing.Point(606, 411);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(207, 106);
            this.createButton.TabIndex = 12;
            this.createButton.Text = "START";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 570);
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
            this.resonanceGroupbox.PerformLayout();
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
        private System.Windows.Forms.RadioButton pyroRadio;
        private System.Windows.Forms.RadioButton cryoRadio;
        private System.Windows.Forms.RadioButton anemoRadio;
        private System.Windows.Forms.RadioButton geoRadio;
        private System.Windows.Forms.RadioButton electroRadio;
        private System.Windows.Forms.RadioButton hydroRadio;
        private System.Windows.Forms.Button createButton;
    }
}