namespace MegaDesk_Deseret
{
    partial class SearchQuotes
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
            this.menuBtn = new System.Windows.Forms.Button();
            this.rushOptLabel = new System.Windows.Forms.Label();
            this.materialOpts = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.listViewResults = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // menuBtn
            // 
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.menuBtn.Location = new System.Drawing.Point(456, 325);
            this.menuBtn.Margin = new System.Windows.Forms.Padding(2);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(135, 31);
            this.menuBtn.TabIndex = 3;
            this.menuBtn.Text = "Go &Back";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // rushOptLabel
            // 
            this.rushOptLabel.AutoSize = true;
            this.rushOptLabel.CausesValidation = false;
            this.rushOptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rushOptLabel.Location = new System.Drawing.Point(12, 16);
            this.rushOptLabel.Name = "rushOptLabel";
            this.rushOptLabel.Size = new System.Drawing.Size(115, 17);
            this.rushOptLabel.TabIndex = 0;
            this.rushOptLabel.Text = "Surface Material:";
            // 
            // materialOpts
            // 
            this.materialOpts.DropDownWidth = 157;
            this.materialOpts.FormattingEnabled = true;
            this.materialOpts.ItemHeight = 13;
            this.materialOpts.Location = new System.Drawing.Point(134, 12);
            this.materialOpts.Name = "materialOpts";
            this.materialOpts.Size = new System.Drawing.Size(157, 21);
            this.materialOpts.TabIndex = 1;
            this.materialOpts.SelectedIndexChanged += new System.EventHandler(this.materialOpts_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(306, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 24);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // listViewResults
            // 
            this.listViewResults.HideSelection = false;
            this.listViewResults.Location = new System.Drawing.Point(12, 48);
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Size = new System.Drawing.Size(579, 272);
            this.listViewResults.TabIndex = 0;
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            this.listViewResults.View = System.Windows.Forms.View.Details;
            this.listViewResults.SelectedIndexChanged += new System.EventHandler(this.listViewResults_SelectedIndexChanged);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.listViewResults);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.materialOpts);
            this.Controls.Add(this.rushOptLabel);
            this.Controls.Add(this.menuBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Label rushOptLabel;
        private System.Windows.Forms.ComboBox materialOpts;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView listViewResults;
    }
}