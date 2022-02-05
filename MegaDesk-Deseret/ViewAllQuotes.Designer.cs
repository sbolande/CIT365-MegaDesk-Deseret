namespace MegaDesk_Deseret
{
    partial class ViewAllQuotes
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
            this.components = new System.ComponentModel.Container();
            this.menuBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesktopMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrawerCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculateQuote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductionDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jsonDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jsonDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBtn
            // 
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.menuBtn.Location = new System.Drawing.Point(937, 373);
            this.menuBtn.Margin = new System.Windows.Forms.Padding(2);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(135, 31);
            this.menuBtn.TabIndex = 4;
            this.menuBtn.Text = "Go &Back";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.DesktopMaterial,
            this.Width,
            this.Depth,
            this.DrawerCount,
            this.CalculateQuote,
            this.ProductionDays});
            this.dataGridView1.Location = new System.Drawing.Point(10, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1059, 343);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 125;
            // 
            // DesktopMaterial
            // 
            this.DesktopMaterial.HeaderText = "Desktop Material";
            this.DesktopMaterial.MinimumWidth = 6;
            this.DesktopMaterial.Name = "DesktopMaterial";
            this.DesktopMaterial.ReadOnly = true;
            this.DesktopMaterial.Width = 125;
            // 
            // Width
            // 
            this.Width.HeaderText = "Width";
            this.Width.MinimumWidth = 6;
            this.Width.Name = "Width";
            this.Width.ReadOnly = true;
            this.Width.Width = 125;
            // 
            // Depth
            // 
            this.Depth.HeaderText = "Depth";
            this.Depth.MinimumWidth = 6;
            this.Depth.Name = "Depth";
            this.Depth.ReadOnly = true;
            this.Depth.Width = 125;
            // 
            // DrawerCount
            // 
            this.DrawerCount.HeaderText = "Drawer Count";
            this.DrawerCount.MinimumWidth = 6;
            this.DrawerCount.Name = "DrawerCount";
            this.DrawerCount.ReadOnly = true;
            this.DrawerCount.Width = 125;
            // 
            // CalculateQuote
            // 
            this.CalculateQuote.HeaderText = "Quote";
            this.CalculateQuote.MinimumWidth = 6;
            this.CalculateQuote.Name = "CalculateQuote";
            this.CalculateQuote.ReadOnly = true;
            this.CalculateQuote.Width = 125;
            // 
            // ProductionDays
            // 
            this.ProductionDays.HeaderText = "Production Days";
            this.ProductionDays.MinimumWidth = 6;
            this.ProductionDays.Name = "ProductionDays";
            this.ProductionDays.ReadOnly = true;
            this.ProductionDays.Width = 125;
            // 
            // jsonDataBindingSource
            // 
            this.jsonDataBindingSource.DataSource = typeof(MegaDesk_Deseret.JsonData);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 415);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jsonDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource jsonDataBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesktopMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrawerCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalculateQuote;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductionDays;
    }
}