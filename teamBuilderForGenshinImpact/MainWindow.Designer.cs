
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
            this.charactersList = new System.Windows.Forms.ListView();
            this.c_name = new System.Windows.Forms.ColumnHeader();
            this.c_vision = new System.Windows.Forms.ColumnHeader();
            this.c_rarity = new System.Windows.Forms.ColumnHeader();
            this.c_weapon = new System.Windows.Forms.ColumnHeader("(aucun)");
            this.refreshButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.charactersGroupbox = new System.Windows.Forms.GroupBox();
            this.charactersGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // charactersList
            // 
            this.charactersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c_name,
            this.c_vision,
            this.c_rarity,
            this.c_weapon});
            this.charactersList.HideSelection = false;
            this.charactersList.Location = new System.Drawing.Point(6, 22);
            this.charactersList.Name = "charactersList";
            this.charactersList.Size = new System.Drawing.Size(875, 415);
            this.charactersList.TabIndex = 0;
            this.charactersList.UseCompatibleStateImageBehavior = false;
            this.charactersList.View = System.Windows.Forms.View.Details;
            // 
            // c_name
            // 
            this.c_name.Text = "c_name";
            // 
            // c_vision
            // 
            this.c_vision.Text = "c_vision";
            // 
            // c_rarity
            // 
            this.c_rarity.Text = "c_rarity";
            // 
            // c_weapon
            // 
            this.c_weapon.Text = "c_weapon";
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
            this.charactersGroupbox.Controls.Add(this.charactersList);
            this.charactersGroupbox.Location = new System.Drawing.Point(13, 80);
            this.charactersGroupbox.Name = "charactersGroupbox";
            this.charactersGroupbox.Size = new System.Drawing.Size(887, 443);
            this.charactersGroupbox.TabIndex = 4;
            this.charactersGroupbox.TabStop = false;
            this.charactersGroupbox.Text = "Characters  list";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 535);
            this.Controls.Add(this.charactersGroupbox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.refreshButton);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.charactersGroupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView charactersList;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader c_vision;
        private System.Windows.Forms.ColumnHeader rarity;
        private System.Windows.Forms.ColumnHeader weapon;
        private System.Windows.Forms.ColumnHeader c_name;
        private System.Windows.Forms.ColumnHeader c_rarity;
        private System.Windows.Forms.ColumnHeader c_weapon;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox charactersGroupbox;
    }
}