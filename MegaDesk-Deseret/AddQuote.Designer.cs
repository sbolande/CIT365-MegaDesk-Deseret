namespace MegaDesk_Deseret
{
    partial class AddQuote
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
            this.width = new System.Windows.Forms.NumericUpDown();
            this.depth = new System.Windows.Forms.NumericUpDown();
            this.drawerCount = new System.Windows.Forms.NumericUpDown();
            this.materialOpts = new System.Windows.Forms.GroupBox();
            this.materialOpt4 = new System.Windows.Forms.RadioButton();
            this.materialOpt3 = new System.Windows.Forms.RadioButton();
            this.materialOpt2 = new System.Windows.Forms.RadioButton();
            this.materialOpt1 = new System.Windows.Forms.RadioButton();
            this.materialOpt0 = new System.Windows.Forms.RadioButton();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.drawerCountLabel = new System.Windows.Forms.Label();
            this.widthLabel2 = new System.Windows.Forms.Label();
            this.depthLabel2 = new System.Windows.Forms.Label();
            this.rushOpt = new System.Windows.Forms.ComboBox();
            this.rushOptLabel = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.lname = new MegaDesk_Deseret.PlaceHolderTextBox();
            this.fname = new MegaDesk_Deseret.PlaceHolderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawerCount)).BeginInit();
            this.materialOpts.SuspendLayout();
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
            this.menuBtn.TabIndex = 8;
            this.menuBtn.Text = "Go &Back";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // width
            // 
            this.width.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.width.Location = new System.Drawing.Point(71, 55);
            this.width.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.width.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(48, 26);
            this.width.TabIndex = 2;
            this.width.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.width.ValueChanged += new System.EventHandler(this.width_ValueChanged);
            this.width.Leave += new System.EventHandler(this.width_ValueChanged);
            // 
            // depth
            // 
            this.depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.depth.Location = new System.Drawing.Point(71, 87);
            this.depth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(48, 26);
            this.depth.TabIndex = 3;
            this.depth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // drawerCount
            // 
            this.drawerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.drawerCount.Location = new System.Drawing.Point(123, 135);
            this.drawerCount.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawerCount.Name = "drawerCount";
            this.drawerCount.Size = new System.Drawing.Size(48, 26);
            this.drawerCount.TabIndex = 8;
            // 
            // materialOpts
            // 
            this.materialOpts.Controls.Add(this.materialOpt4);
            this.materialOpts.Controls.Add(this.materialOpt3);
            this.materialOpts.Controls.Add(this.materialOpt2);
            this.materialOpts.Controls.Add(this.materialOpt1);
            this.materialOpts.Controls.Add(this.materialOpt0);
            this.materialOpts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materialOpts.Location = new System.Drawing.Point(237, 49);
            this.materialOpts.Name = "materialOpts";
            this.materialOpts.Size = new System.Drawing.Size(215, 180);
            this.materialOpts.TabIndex = 6;
            this.materialOpts.TabStop = false;
            this.materialOpts.Text = "Desktop Surface Material";
            // 
            // materialOpt4
            // 
            this.materialOpt4.AutoSize = true;
            this.materialOpt4.Location = new System.Drawing.Point(7, 140);
            this.materialOpt4.Name = "materialOpt4";
            this.materialOpt4.Size = new System.Drawing.Size(63, 24);
            this.materialOpt4.TabIndex = 4;
            this.materialOpt4.Text = "Pine";
            this.materialOpt4.UseVisualStyleBackColor = true;
            // 
            // materialOpt3
            // 
            this.materialOpt3.AutoSize = true;
            this.materialOpt3.Location = new System.Drawing.Point(7, 110);
            this.materialOpt3.Name = "materialOpt3";
            this.materialOpt3.Size = new System.Drawing.Size(83, 24);
            this.materialOpt3.TabIndex = 3;
            this.materialOpt3.Text = "Veneer";
            this.materialOpt3.UseVisualStyleBackColor = true;
            // 
            // materialOpt2
            // 
            this.materialOpt2.AutoSize = true;
            this.materialOpt2.Location = new System.Drawing.Point(7, 80);
            this.materialOpt2.Name = "materialOpt2";
            this.materialOpt2.Size = new System.Drawing.Size(108, 24);
            this.materialOpt2.TabIndex = 2;
            this.materialOpt2.Text = "Rosewood";
            this.materialOpt2.UseVisualStyleBackColor = true;
            // 
            // materialOpt1
            // 
            this.materialOpt1.AutoSize = true;
            this.materialOpt1.Location = new System.Drawing.Point(7, 50);
            this.materialOpt1.Name = "materialOpt1";
            this.materialOpt1.Size = new System.Drawing.Size(60, 24);
            this.materialOpt1.TabIndex = 1;
            this.materialOpt1.Text = "Oak";
            this.materialOpt1.UseVisualStyleBackColor = true;
            // 
            // materialOpt0
            // 
            this.materialOpt0.AutoSize = true;
            this.materialOpt0.Checked = true;
            this.materialOpt0.Location = new System.Drawing.Point(7, 20);
            this.materialOpt0.Name = "materialOpt0";
            this.materialOpt0.Size = new System.Drawing.Size(99, 24);
            this.materialOpt0.TabIndex = 0;
            this.materialOpt0.TabStop = true;
            this.materialOpt0.Text = "Laminate";
            this.materialOpt0.UseVisualStyleBackColor = true;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.CausesValidation = false;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.widthLabel.Location = new System.Drawing.Point(12, 58);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(57, 20);
            this.widthLabel.TabIndex = 10;
            this.widthLabel.Text = "Width:";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.CausesValidation = false;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.depthLabel.Location = new System.Drawing.Point(10, 90);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(59, 20);
            this.depthLabel.TabIndex = 11;
            this.depthLabel.Text = "Depth:";
            // 
            // drawerCountLabel
            // 
            this.drawerCountLabel.AutoSize = true;
            this.drawerCountLabel.CausesValidation = false;
            this.drawerCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.drawerCountLabel.Location = new System.Drawing.Point(10, 138);
            this.drawerCountLabel.Name = "drawerCountLabel";
            this.drawerCountLabel.Size = new System.Drawing.Size(111, 20);
            this.drawerCountLabel.TabIndex = 12;
            this.drawerCountLabel.Text = "# of Drawers:";
            // 
            // widthLabel2
            // 
            this.widthLabel2.AutoSize = true;
            this.widthLabel2.CausesValidation = false;
            this.widthLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.widthLabel2.Location = new System.Drawing.Point(121, 58);
            this.widthLabel2.Name = "widthLabel2";
            this.widthLabel2.Size = new System.Drawing.Size(58, 20);
            this.widthLabel2.TabIndex = 13;
            this.widthLabel2.Text = "inches";
            // 
            // depthLabel2
            // 
            this.depthLabel2.AutoSize = true;
            this.depthLabel2.CausesValidation = false;
            this.depthLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.depthLabel2.Location = new System.Drawing.Point(121, 90);
            this.depthLabel2.Name = "depthLabel2";
            this.depthLabel2.Size = new System.Drawing.Size(58, 20);
            this.depthLabel2.TabIndex = 14;
            this.depthLabel2.Text = "inches";
            // 
            // rushOpt
            // 
            this.rushOpt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rushOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rushOpt.FormattingEnabled = true;
            this.rushOpt.Items.AddRange(new object[] {
            "14 days (standard)",
            "7 days",
            "5 days",
            "3 days"});
            this.rushOpt.Location = new System.Drawing.Point(14, 201);
            this.rushOpt.Name = "rushOpt";
            this.rushOpt.Size = new System.Drawing.Size(157, 28);
            this.rushOpt.TabIndex = 5;
            // 
            // rushOptLabel
            // 
            this.rushOptLabel.AutoSize = true;
            this.rushOptLabel.CausesValidation = false;
            this.rushOptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rushOptLabel.Location = new System.Drawing.Point(10, 180);
            this.rushOptLabel.Name = "rushOptLabel";
            this.rushOptLabel.Size = new System.Drawing.Size(164, 20);
            this.rushOptLabel.TabIndex = 16;
            this.rushOptLabel.Text = "Rush Order Options:";
            // 
            // submitBtn
            // 
            this.submitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.submitBtn.Location = new System.Drawing.Point(205, 325);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(247, 31);
            this.submitBtn.TabIndex = 7;
            this.submitBtn.Text = "&Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // lname
            // 
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.lname.ForeColor = System.Drawing.Color.Gray;
            this.lname.Location = new System.Drawing.Point(199, 12);
            this.lname.Name = "lname";
            this.lname.PlaceHolderText = "Last Name";
            this.lname.Size = new System.Drawing.Size(253, 26);
            this.lname.TabIndex = 1;
            this.lname.Text = "Last Name";
            this.lname.Leave += new System.EventHandler(this.name_ValueChanged);
            // 
            // fname
            // 
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.fname.ForeColor = System.Drawing.Color.Gray;
            this.fname.Location = new System.Drawing.Point(12, 12);
            this.fname.Name = "fname";
            this.fname.PlaceHolderText = "First Name";
            this.fname.Size = new System.Drawing.Size(181, 26);
            this.fname.TabIndex = 0;
            this.fname.Text = "First Name";
            this.fname.Leave += new System.EventHandler(this.name_ValueChanged);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.rushOptLabel);
            this.Controls.Add(this.rushOpt);
            this.Controls.Add(this.depthLabel2);
            this.Controls.Add(this.widthLabel2);
            this.Controls.Add(this.drawerCountLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.materialOpts);
            this.Controls.Add(this.drawerCount);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.width);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.menuBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddQuote";
            this.Text = "Add New Quote";
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawerCount)).EndInit();
            this.materialOpts.ResumeLayout(false);
            this.materialOpts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuBtn;
        private PlaceHolderTextBox fname;
        private PlaceHolderTextBox lname;
        private System.Windows.Forms.NumericUpDown width;
        private System.Windows.Forms.NumericUpDown depth;
        private System.Windows.Forms.NumericUpDown drawerCount;
        private System.Windows.Forms.GroupBox materialOpts;
        private System.Windows.Forms.RadioButton materialOpt4;
        private System.Windows.Forms.RadioButton materialOpt3;
        private System.Windows.Forms.RadioButton materialOpt2;
        private System.Windows.Forms.RadioButton materialOpt1;
        private System.Windows.Forms.RadioButton materialOpt0;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label drawerCountLabel;
        private System.Windows.Forms.Label widthLabel2;
        private System.Windows.Forms.Label depthLabel2;
        private System.Windows.Forms.ComboBox rushOpt;
        private System.Windows.Forms.Label rushOptLabel;
        private System.Windows.Forms.Button submitBtn;
    }
}