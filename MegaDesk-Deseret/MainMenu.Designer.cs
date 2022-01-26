namespace MegaDesk
{
    partial class MainMenu
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
            this.addQuoteBtn = new System.Windows.Forms.Button();
            this.viewQuotesBtn = new System.Windows.Forms.Button();
            this.searchQuotesBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addQuoteBtn
            // 
            this.addQuoteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addQuoteBtn.Location = new System.Drawing.Point(30, 43);
            this.addQuoteBtn.Name = "addQuoteBtn";
            this.addQuoteBtn.Size = new System.Drawing.Size(230, 71);
            this.addQuoteBtn.TabIndex = 0;
            this.addQuoteBtn.Text = "&Add New Quote";
            this.addQuoteBtn.UseVisualStyleBackColor = true;
            this.addQuoteBtn.Click += new System.EventHandler(this.addQuoteBtn_Click);
            // 
            // viewQuotesBtn
            // 
            this.viewQuotesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewQuotesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.viewQuotesBtn.Location = new System.Drawing.Point(30, 129);
            this.viewQuotesBtn.Name = "viewQuotesBtn";
            this.viewQuotesBtn.Size = new System.Drawing.Size(230, 71);
            this.viewQuotesBtn.TabIndex = 1;
            this.viewQuotesBtn.Text = "&View Quotes";
            this.viewQuotesBtn.UseVisualStyleBackColor = true;
            this.viewQuotesBtn.Click += new System.EventHandler(this.viewQuotesBtn_Click);
            // 
            // searchQuotesBtn
            // 
            this.searchQuotesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchQuotesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchQuotesBtn.Location = new System.Drawing.Point(30, 215);
            this.searchQuotesBtn.Name = "searchQuotesBtn";
            this.searchQuotesBtn.Size = new System.Drawing.Size(230, 71);
            this.searchQuotesBtn.TabIndex = 2;
            this.searchQuotesBtn.Text = "&Search Quotes";
            this.searchQuotesBtn.UseVisualStyleBackColor = true;
            this.searchQuotesBtn.Click += new System.EventHandler(this.searchQuotesBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exitBtn.Location = new System.Drawing.Point(30, 302);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(230, 71);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.searchQuotesBtn);
            this.Controls.Add(this.viewQuotesBtn);
            this.Controls.Add(this.addQuoteBtn);
            this.Name = "MainMenu";
            this.Text = "MegaDesk-Bolander";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addQuoteBtn;
        private System.Windows.Forms.Button viewQuotesBtn;
        private System.Windows.Forms.Button searchQuotesBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

