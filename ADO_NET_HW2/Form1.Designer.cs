namespace ADO_NET_HW2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbx_Querry = new System.Windows.Forms.TextBox();
            this.btn_Fill = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.tbcl_MainTabControl = new System.Windows.Forms.TabControl();
            this.cmbx_Table_List = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txbx_Querry
            // 
            this.txbx_Querry.Location = new System.Drawing.Point(12, 12);
            this.txbx_Querry.Name = "txbx_Querry";
            this.txbx_Querry.Size = new System.Drawing.Size(493, 20);
            this.txbx_Querry.TabIndex = 0;
            // 
            // btn_Fill
            // 
            this.btn_Fill.Location = new System.Drawing.Point(512, 8);
            this.btn_Fill.Name = "btn_Fill";
            this.btn_Fill.Size = new System.Drawing.Size(75, 23);
            this.btn_Fill.TabIndex = 1;
            this.btn_Fill.Text = "Fill";
            this.btn_Fill.UseVisualStyleBackColor = true;
            this.btn_Fill.Click += new System.EventHandler(this.btn_Fill_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(512, 250);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // tbcl_MainTabControl
            // 
            this.tbcl_MainTabControl.Location = new System.Drawing.Point(12, 38);
            this.tbcl_MainTabControl.Name = "tbcl_MainTabControl";
            this.tbcl_MainTabControl.SelectedIndex = 0;
            this.tbcl_MainTabControl.Size = new System.Drawing.Size(494, 235);
            this.tbcl_MainTabControl.TabIndex = 3;
            // 
            // cmbx_Table_List
            // 
            this.cmbx_Table_List.FormattingEnabled = true;
            this.cmbx_Table_List.Items.AddRange(new object[] {
            "Table",
            "List"});
            this.cmbx_Table_List.Location = new System.Drawing.Point(512, 38);
            this.cmbx_Table_List.Name = "cmbx_Table_List";
            this.cmbx_Table_List.Size = new System.Drawing.Size(75, 21);
            this.cmbx_Table_List.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 288);
            this.Controls.Add(this.cmbx_Table_List);
            this.Controls.Add(this.tbcl_MainTabControl);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Fill);
            this.Controls.Add(this.txbx_Querry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_Querry;
        private System.Windows.Forms.Button btn_Fill;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TabControl tbcl_MainTabControl;
        private System.Windows.Forms.ComboBox cmbx_Table_List;
    }
}

