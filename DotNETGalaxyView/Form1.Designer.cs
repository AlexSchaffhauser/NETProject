namespace DotNETGalaxyView
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.planetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.planetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btn_ColPlanet = new System.Windows.Forms.Button();
            this.planetDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_ViewBuildings = new System.Windows.Forms.Button();
            this.btn_AbandonPlanet = new System.Windows.Forms.Button();
            this.btn_CollectResource = new System.Windows.Forms.Button();
            this.buildingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.planetBindingNavigator)).BeginInit();
            this.planetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // planetBindingNavigator
            // 
            this.planetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.planetBindingNavigator.BindingSource = this.planetBindingSource;
            this.planetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.planetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.planetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.planetBindingNavigatorSaveItem});
            this.planetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.planetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.planetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.planetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.planetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.planetBindingNavigator.Name = "planetBindingNavigator";
            this.planetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.planetBindingNavigator.Size = new System.Drawing.Size(680, 25);
            this.planetBindingNavigator.TabIndex = 0;
            this.planetBindingNavigator.Text = "bindingNavigator1";
            this.planetBindingNavigator.Visible = false;
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
            // planetBindingNavigatorSaveItem
            // 
            this.planetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.planetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("planetBindingNavigatorSaveItem.Image")));
            this.planetBindingNavigatorSaveItem.Name = "planetBindingNavigatorSaveItem";
            this.planetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.planetBindingNavigatorSaveItem.Text = "Save Data";
            this.planetBindingNavigatorSaveItem.Click += new System.EventHandler(this.planetBindingNavigatorSaveItem_Click);
            // 
            // btn_ColPlanet
            // 
            this.btn_ColPlanet.Location = new System.Drawing.Point(12, 45);
            this.btn_ColPlanet.Name = "btn_ColPlanet";
            this.btn_ColPlanet.Size = new System.Drawing.Size(121, 23);
            this.btn_ColPlanet.TabIndex = 3;
            this.btn_ColPlanet.Text = "Colonize New Planet";
            this.btn_ColPlanet.UseVisualStyleBackColor = true;
            this.btn_ColPlanet.Click += new System.EventHandler(this.btn_ColPlanet_Click);
            // 
            // planetDataGridView
            // 
            this.planetDataGridView.AutoGenerateColumns = false;
            this.planetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.planetDataGridView.DataSource = this.planetBindingSource;
            this.planetDataGridView.Location = new System.Drawing.Point(207, 45);
            this.planetDataGridView.Name = "planetDataGridView";
            this.planetDataGridView.ReadOnly = true;
            this.planetDataGridView.Size = new System.Drawing.Size(243, 229);
            this.planetDataGridView.TabIndex = 3;
            // 
            // btn_ViewBuildings
            // 
            this.btn_ViewBuildings.Location = new System.Drawing.Point(534, 45);
            this.btn_ViewBuildings.Name = "btn_ViewBuildings";
            this.btn_ViewBuildings.Size = new System.Drawing.Size(133, 23);
            this.btn_ViewBuildings.TabIndex = 4;
            this.btn_ViewBuildings.Text = "View Buildings";
            this.btn_ViewBuildings.UseVisualStyleBackColor = true;
            this.btn_ViewBuildings.Click += new System.EventHandler(this.btn_ViewBuildings_Click);
            // 
            // btn_AbandonPlanet
            // 
            this.btn_AbandonPlanet.Location = new System.Drawing.Point(534, 74);
            this.btn_AbandonPlanet.Name = "btn_AbandonPlanet";
            this.btn_AbandonPlanet.Size = new System.Drawing.Size(133, 23);
            this.btn_AbandonPlanet.TabIndex = 5;
            this.btn_AbandonPlanet.Text = "Abandon Planet";
            this.btn_AbandonPlanet.UseVisualStyleBackColor = true;
            this.btn_AbandonPlanet.Click += new System.EventHandler(this.btn_AbandonPlanet_Click);
            // 
            // btn_CollectResource
            // 
            this.btn_CollectResource.Location = new System.Drawing.Point(534, 103);
            this.btn_CollectResource.Name = "btn_CollectResource";
            this.btn_CollectResource.Size = new System.Drawing.Size(133, 23);
            this.btn_CollectResource.TabIndex = 6;
            this.btn_CollectResource.Text = "Collect Resource";
            this.btn_CollectResource.UseVisualStyleBackColor = true;
            this.btn_CollectResource.Click += new System.EventHandler(this.btn_CollectResource_Click);
            // 
            // buildingsBindingSource
            // 
            this.buildingsBindingSource.DataMember = "Buildings";
            this.buildingsBindingSource.DataSource = this.planetBindingSource;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PlanetId";
            this.dataGridViewTextBoxColumn1.HeaderText = "PlanetId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // planetBindingSource
            // 
            this.planetBindingSource.DataSource = typeof(DotNETGalaxyView.Planet);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PlanetResources";
            this.dataGridViewTextBoxColumn3.HeaderText = "Resources";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PlanetName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 299);
            this.Controls.Add(this.btn_CollectResource);
            this.Controls.Add(this.btn_AbandonPlanet);
            this.Controls.Add(this.btn_ViewBuildings);
            this.Controls.Add(this.planetDataGridView);
            this.Controls.Add(this.btn_ColPlanet);
            this.Controls.Add(this.planetBindingNavigator);
            this.Name = "Form1";
            this.Text = "Galaxy";
            ((System.ComponentModel.ISupportInitialize)(this.planetBindingNavigator)).EndInit();
            this.planetBindingNavigator.ResumeLayout(false);
            this.planetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource planetBindingSource;
        private System.Windows.Forms.BindingNavigator planetBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton planetBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource buildingsBindingSource;
        private System.Windows.Forms.Button btn_ColPlanet;
        private System.Windows.Forms.DataGridView planetDataGridView;
        private System.Windows.Forms.Button btn_ViewBuildings;
        private System.Windows.Forms.Button btn_AbandonPlanet;
        private System.Windows.Forms.Button btn_CollectResource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

