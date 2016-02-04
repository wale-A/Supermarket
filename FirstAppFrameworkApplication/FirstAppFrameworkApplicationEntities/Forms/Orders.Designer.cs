namespace FirstAppFrameworkApplicationEntities.Forms
{
    partial class Orders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formDataGridView1 = new AppFramework.Controls.FormDataGridView();
            this.formDataGridView2 = new AppFramework.Controls.FormDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.runnableFormButton1 = new AppFramework.Controls.RunnableFormButton();
            ((System.ComponentModel.ISupportInitialize)(this.formDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formDataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // formDataGridView1
            // 
            this.formDataGridView1.AllowArgsAssociation = true;
            this.formDataGridView1.AllowUserAdd = true;
            this.formDataGridView1.AllowUserDelete = true;
            this.formDataGridView1.AllowUserToOrderColumns = true;
            this.formDataGridView1.AllowUserUpdate = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.formDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.formDataGridView1.AssociatedDataGrid = null;
            this.formDataGridView1.AutoFields = true;
            this.formDataGridView1.AutoFieldsGroup = "grid";
            this.formDataGridView1.AutoLoad = true;
            this.formDataGridView1.AutoSelectGridOnTabChange = true;
            this.formDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.formDataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.formDataGridView1.Caption = "";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.formDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.formDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.formDataGridView1.Criteria = "";
            this.formDataGridView1.DiscardUserSettings = false;
            this.formDataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.formDataGridView1.DrillDownEnabled = true;
            this.formDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.formDataGridView1.EnittyViewTypeFullName = null;
            this.formDataGridView1.EntityBaseNamespace = "";
            this.formDataGridView1.EntityBaseTypeName = "Order";
            this.formDataGridView1.HelpTopic = null;
            this.formDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.formDataGridView1.Name = "formDataGridView1";
            this.formDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.formDataGridView1.ShowGridFilter = false;
            this.formDataGridView1.Size = new System.Drawing.Size(458, 123);
            this.formDataGridView1.SortColumn = "ID";
            this.formDataGridView1.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.formDataGridView1.StartPosition = AppFramework.Controls.ScrollPosition.First;
            this.formDataGridView1.TabIndex = 1;
            // 
            // formDataGridView2
            // 
            this.formDataGridView2.AllowArgsAssociation = true;
            this.formDataGridView2.AllowUserAdd = true;
            this.formDataGridView2.AllowUserDelete = true;
            this.formDataGridView2.AllowUserToOrderColumns = true;
            this.formDataGridView2.AllowUserUpdate = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            this.formDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.formDataGridView2.AssociatedDataGrid = this.formDataGridView1;
            this.formDataGridView2.AutoFields = true;
            this.formDataGridView2.AutoFieldsGroup = "nonsystem";
            this.formDataGridView2.AutoLoad = true;
            this.formDataGridView2.AutoSelectGridOnTabChange = true;
            this.formDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.formDataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.formDataGridView2.Caption = "";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.formDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.formDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.formDataGridView2.Criteria = "";
            this.formDataGridView2.DiscardUserSettings = false;
            this.formDataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.formDataGridView2.DrillDownEnabled = true;
            this.formDataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.formDataGridView2.EnittyViewTypeFullName = null;
            this.formDataGridView2.EntityBaseNamespace = "";
            this.formDataGridView2.EntityBaseTypeName = "OrderDetails";
            this.formDataGridView2.HelpTopic = null;
            this.formDataGridView2.Location = new System.Drawing.Point(0, 116);
            this.formDataGridView2.Name = "formDataGridView2";
            this.formDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.formDataGridView2.ShowGridFilter = false;
            this.formDataGridView2.Size = new System.Drawing.Size(458, 133);
            this.formDataGridView2.SortColumn = "ID";
            this.formDataGridView2.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.formDataGridView2.StartPosition = AppFramework.Controls.ScrollPosition.First;
            this.formDataGridView2.TabIndex = 2;
            this.formDataGridView2.EntitySaved += new AppFramework.Controls.FormDataGridView.EntitySavedEventHandler(this.formDataGridView2_EntitySaved);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.runnableFormButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(458, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 249);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.formDataGridView1);
            this.panel2.Controls.Add(this.formDataGridView2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 249);
            this.panel2.TabIndex = 4;
            // 
            // runnableFormButton1
            // 
            this.runnableFormButton1.AllowAssociatedGridMultiSelect = true;
            this.runnableFormButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.runnableFormButton1.ArgsValueString = null;
            this.runnableFormButton1.AssociatedDataGrid = this.formDataGridView1;
            this.runnableFormButton1.AutoSize = true;
            this.runnableFormButton1.DiscardUserSettings = false;
            this.runnableFormButton1.EnableEvenIfAssociatedGridIsEmpty = false;
            this.runnableFormButton1.HelpTopic = null;
            this.runnableFormButton1.Location = new System.Drawing.Point(4, 4);
            this.runnableFormButton1.Name = "runnableFormButton1";
            this.runnableFormButton1.ReloadGridAfter = false;
            this.runnableFormButton1.ReloadSelectedEntityAfter = false;
            this.runnableFormButton1.RequiredLicense = "";
            this.runnableFormButton1.RequiredPermissionLevel = AppFramework.AppClasses.AccessLevel.None;
            this.runnableFormButton1.RunnableInteractive = false;
            this.runnableFormButton1.RunnableTypeName = "OrderReport";
            this.runnableFormButton1.RunnableTypeNamespace = "FirstAppFrameworkApplicationEntities.ReportClasses";
            this.runnableFormButton1.SaveCurrentEntity = true;
            this.runnableFormButton1.Size = new System.Drawing.Size(107, 23);
            this.runnableFormButton1.TabIndex = 0;
            this.runnableFormButton1.Text = "Generate Invoice";
            this.runnableFormButton1.UseVisualStyleBackColor = true;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 300);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.formDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formDataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppFramework.Controls.FormDataGridView formDataGridView1;
        private AppFramework.Controls.FormDataGridView formDataGridView2;
        private System.Windows.Forms.Panel panel1;
        private AppFramework.Controls.RunnableFormButton runnableFormButton1;
        private System.Windows.Forms.Panel panel2;
    }
}