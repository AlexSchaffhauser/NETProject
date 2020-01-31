namespace DotNETGalaxyView
{
    partial class Form3
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
            System.Windows.Forms.Label planetNameLabel;
            System.Windows.Forms.Label planetResourcesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.planetNameTextBox = new System.Windows.Forms.TextBox();
            this.planetResourcesTextBox = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Upgrade = new System.Windows.Forms.Button();
            this.buildingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buildingsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buildingsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.buildingsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            planetNameLabel = new System.Windows.Forms.Label();
            planetResourcesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingNavigator)).BeginInit();
            this.buildingsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // planetNameLabel
            // 
            planetNameLabel.AutoSize = true;
            planetNameLabel.Location = new System.Drawing.Point(58, 33);
            planetNameLabel.Name = "planetNameLabel";
            planetNameLabel.Size = new System.Drawing.Size(71, 13);
            planetNameLabel.TabIndex = 13;
            planetNameLabel.Text = "Planet Name:";
            // 
            // planetResourcesLabel
            // 
            planetResourcesLabel.AutoSize = true;
            planetResourcesLabel.Location = new System.Drawing.Point(58, 69);
            planetResourcesLabel.Name = "planetResourcesLabel";
            planetResourcesLabel.Size = new System.Drawing.Size(98, 13);
            planetResourcesLabel.TabIndex = 15;
            planetResourcesLabel.Text = "Current Resources:";
            // 
            // planetNameTextBox
            // 
            this.planetNameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.planetNameTextBox.Location = new System.Drawing.Point(167, 30);
            this.planetNameTextBox.Name = "planetNameTextBox";
            this.planetNameTextBox.ReadOnly = true;
            this.planetNameTextBox.Size = new System.Drawing.Size(196, 20);
            this.planetNameTextBox.TabIndex = 14;
            this.planetNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // planetResourcesTextBox
            // 
            this.planetResourcesTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.planetResourcesTextBox.Location = new System.Drawing.Point(167, 66);
            this.planetResourcesTextBox.Name = "planetResourcesTextBox";
            this.planetResourcesTextBox.ReadOnly = true;
            this.planetResourcesTextBox.Size = new System.Drawing.Size(196, 20);
            this.planetResourcesTextBox.TabIndex = 16;
            this.planetResourcesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(210, 229);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(104, 23);
            this.btn_Delete.TabIndex = 12;
            this.btn_Delete.Text = "Demolish Building";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Upgrade
            // 
            this.btn_Upgrade.Location = new System.Drawing.Point(61, 229);
            this.btn_Upgrade.Name = "btn_Upgrade";
            this.btn_Upgrade.Size = new System.Drawing.Size(111, 23);
            this.btn_Upgrade.TabIndex = 10;
            this.btn_Upgrade.Text = "Upgrade Building";
            this.btn_Upgrade.UseVisualStyleBackColor = true;
            this.btn_Upgrade.Click += new System.EventHandler(this.btn_Upgrade_Click);
            // 
            // buildingsBindingSource
            // 
            this.buildingsBindingSource.DataSource = typeof(DotNETGalaxyView.ObservableListSource<DotNETGalaxyView.Building>);
            // 
            // buildingsBindingNavigator
            // 
            this.buildingsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.buildingsBindingNavigator.BindingSource = this.buildingsBindingSource;
            this.buildingsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.buildingsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.buildingsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.buildingsBindingNavigatorSaveItem});
            this.buildingsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.buildingsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.buildingsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.buildingsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.buildingsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.buildingsBindingNavigator.Name = "buildingsBindingNavigator";
            this.buildingsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.buildingsBindingNavigator.Size = new System.Drawing.Size(632, 25);
            this.buildingsBindingNavigator.TabIndex = 17;
            this.buildingsBindingNavigator.Text = "bindingNavigator1";
            this.buildingsBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // buildingsBindingNavigatorSaveItem
            // 
            this.buildingsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buildingsBindingNavigatorSaveItem.Enabled = false;
            this.buildingsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("buildingsBindingNavigatorSaveItem.Image")));
            this.buildingsBindingNavigatorSaveItem.Name = "buildingsBindingNavigatorSaveItem";
            this.buildingsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.buildingsBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // buildingsDataGridView
            // 
            this.buildingsDataGridView.AutoGenerateColumns = false;
            this.buildingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buildingsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6});
            this.buildingsDataGridView.DataSource = this.buildingsBindingSource;
            this.buildingsDataGridView.Location = new System.Drawing.Point(61, 105);
            this.buildingsDataGridView.Name = "buildingsDataGridView";
            this.buildingsDataGridView.ReadOnly = true;
            this.buildingsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.buildingsDataGridView.Size = new System.Drawing.Size(343, 94);
            this.buildingsDataGridView.TabIndex = 17;
            this.buildingsDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.buildingsDataGridView_DefaultValuesNeeded);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PlanetId";
            this.dataGridViewTextBoxColumn5.HeaderText = "PlanetId";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // planetBindingSource
            // 
            this.planetBindingSource.DataSource = typeof(DotNETGalaxyView.Planet);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Planet";
            this.dataGridViewTextBoxColumn6.HeaderText = "Planet";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BuildingLevel";
            this.dataGridViewTextBoxColumn4.HeaderText = "Level";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BuildingCost";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BuildingName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BuildingId";
            this.dataGridViewTextBoxColumn1.HeaderText = "BuildingId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 283);
            this.Controls.Add(this.buildingsDataGridView);
            this.Controls.Add(this.buildingsBindingNavigator);
            this.Controls.Add(planetNameLabel);
            this.Controls.Add(this.planetNameTextBox);
            this.Controls.Add(planetResourcesLabel);
            this.Controls.Add(this.planetResourcesTextBox);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Upgrade);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingNavigator)).EndInit();
            this.buildingsBindingNavigator.ResumeLayout(false);
            this.buildingsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox planetNameTextBox;
        private System.Windows.Forms.TextBox planetResourcesTextBox;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Upgrade;
        private System.Windows.Forms.BindingNavigator buildingsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton buildingsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView buildingsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource planetBindingSource;
        private System.Windows.Forms.BindingSource buildingsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}