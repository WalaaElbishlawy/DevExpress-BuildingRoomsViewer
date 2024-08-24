namespace DXApplication1
{
    partial class BuildingRoomsViewr
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxBuildings = new DevExpress.XtraEditors.ComboBoxEdit();
            this.treeListRooms = new DevExpress.XtraTreeList.TreeList();
            this.labelTreeList = new System.Windows.Forms.Label();
            this.labelBuilding = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBuildings.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel.Controls.Add(this.comboBoxBuildings, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.treeListRooms, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelTreeList, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelBuilding, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(2000, 1142);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // comboBoxBuildings
            // 
            this.comboBoxBuildings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxBuildings.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxBuildings.Location = new System.Drawing.Point(408, 8);
            this.comboBoxBuildings.Margin = new System.Windows.Forms.Padding(8);
            this.comboBoxBuildings.Name = "comboBoxBuildings";
            this.comboBoxBuildings.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxBuildings.Size = new System.Drawing.Size(1584, 41);
            this.comboBoxBuildings.TabIndex = 0;
            this.comboBoxBuildings.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBuildings_SelectedIndexChanged);
            // 
            // treeListRooms
            // 
            this.treeListRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListRooms.FixedLineWidth = 5;
            this.treeListRooms.HorzScrollStep = 7;
            this.treeListRooms.Location = new System.Drawing.Point(408, 110);
            this.treeListRooms.Margin = new System.Windows.Forms.Padding(8);
            this.treeListRooms.Name = "treeListRooms";
            this.treeListRooms.Size = new System.Drawing.Size(1584, 1024);
            this.treeListRooms.TabIndex = 1;
            this.treeListRooms.TreeLevelWidth = 45;
            this.treeListRooms.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListRooms_FocusedNodeChanged);
            // 
            // labelTreeList
            // 
            this.labelTreeList.AutoSize = true;
            this.labelTreeList.Location = new System.Drawing.Point(8, 102);
            this.labelTreeList.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelTreeList.Name = "labelTreeList";
            this.labelTreeList.Size = new System.Drawing.Size(99, 34);
            this.labelTreeList.TabIndex = 3;
            this.labelTreeList.Text = "Rooms";
            this.labelTreeList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBuilding
            // 
            this.labelBuilding.AutoSize = true;
            this.labelBuilding.Location = new System.Drawing.Point(8, 0);
            this.labelBuilding.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelBuilding.Name = "labelBuilding";
            this.labelBuilding.Size = new System.Drawing.Size(122, 34);
            this.labelBuilding.TabIndex = 2;
            this.labelBuilding.Text = "Building:";
            this.labelBuilding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BuildingRoomsViewr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2000, 1142);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "BuildingRoomsViewr";
            this.Text = "Building Room Viewer";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBuildings.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListRooms)).EndInit();
            this.ResumeLayout(false);

        }

        private void treeListRooms_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e) { }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxBuildings;
        private DevExpress.XtraTreeList.TreeList treeListRooms;
        private System.Windows.Forms.Label labelBuilding;
        private System.Windows.Forms.Label labelTreeList;
    }
}