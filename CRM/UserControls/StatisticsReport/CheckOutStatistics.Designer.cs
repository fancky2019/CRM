using CRM.UserControls;

namespace WMS.UserControls.InOutStockManager
{
    partial class CheckOutStatistics
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.pageNavigator = new CRM.UserControls.PageNavigator();
            this.gridProductDetail = new DevExpress.XtraGrid.GridControl();
            this.gridViewProductDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribeDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridProductSource = new DevExpress.XtraGrid.GridControl();
            this.gridViewProductSource = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.teUserName = new DevExpress.XtraEditors.TextEdit();
            this.sbtnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.tePhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.pageNavigator);
            this.layoutControl1.Controls.Add(this.gridProductDetail);
            this.layoutControl1.Controls.Add(this.gridProductSource);
            this.layoutControl1.Controls.Add(this.teUserName);
            this.layoutControl1.Controls.Add(this.sbtnQuery);
            this.layoutControl1.Controls.Add(this.tePhoneNumber);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(839, 387, 904, 557);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(844, 700);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // pageNavigator
            // 
            this.pageNavigator.Location = new System.Drawing.Point(33, 286);
            this.pageNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pageNavigator.Name = "pageNavigator";
            this.pageNavigator.Size = new System.Drawing.Size(787, 31);
            this.pageNavigator.Skip = 0;
            this.pageNavigator.TabIndex = 15;
            this.pageNavigator.Total = 0;
            this.pageNavigator.PageIndexChanged += new System.Action<int, int>(this.pageNavigator1_PageIndexChanged);
            // 
            // gridProductDetail
            // 
            this.gridProductDetail.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridProductDetail.Location = new System.Drawing.Point(33, 364);
            this.gridProductDetail.MainView = this.gridViewProductDetail;
            this.gridProductDetail.Margin = new System.Windows.Forms.Padding(4);
            this.gridProductDetail.Name = "gridProductDetail";
            this.gridProductDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.ribeDelete});
            this.gridProductDetail.Size = new System.Drawing.Size(787, 312);
            this.gridProductDetail.TabIndex = 7;
            this.gridProductDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductDetail});
            // 
            // gridViewProductDetail
            // 
            this.gridViewProductDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcProductName,
            this.gridColumn7,
            this.gridColumn6,
            this.gridColumn5,
            this.gcCount,
            this.gridColumn9});
            this.gridViewProductDetail.DetailHeight = 327;
            this.gridViewProductDetail.GridControl = this.gridProductDetail;
            this.gridViewProductDetail.Name = "gridViewProductDetail";
            this.gridViewProductDetail.OptionsMenu.EnableColumnMenu = false;
            this.gridViewProductDetail.OptionsView.ShowGroupPanel = false;
            this.gridViewProductDetail.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewProductDetail_InvalidRowException);
            this.gridViewProductDetail.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewProductDetail_ValidateRow);
            // 
            // gcProductName
            // 
            this.gcProductName.AppearanceHeader.Options.UseTextOptions = true;
            this.gcProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcProductName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gcProductName.Caption = "产品名称";
            this.gcProductName.FieldName = "ProductName";
            this.gcProductName.MinWidth = 17;
            this.gcProductName.Name = "gcProductName";
            this.gcProductName.OptionsColumn.AllowEdit = false;
            this.gcProductName.OptionsColumn.AllowFocus = false;
            this.gcProductName.OptionsColumn.AllowMove = false;
            this.gcProductName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gcProductName.OptionsFilter.AllowFilter = false;
            this.gcProductName.Visible = true;
            this.gcProductName.VisibleIndex = 0;
            this.gcProductName.Width = 123;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn7.Caption = "价格";
            this.gridColumn7.FieldName = "Price";
            this.gridColumn7.MinWidth = 17;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowFocus = false;
            this.gridColumn7.OptionsColumn.AllowMove = false;
            this.gridColumn7.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn7.OptionsFilter.AllowFilter = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 123;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "折扣";
            this.gridColumn6.FieldName = "Discount";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.OptionsColumn.AllowMove = false;
            this.gridColumn6.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn6.OptionsFilter.AllowFilter = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 66;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "折后价";
            this.gridColumn5.FieldName = "DiscountPrice";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.OptionsColumn.AllowMove = false;
            this.gridColumn5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn5.OptionsFilter.AllowFilter = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 66;
            // 
            // gcCount
            // 
            this.gcCount.AppearanceHeader.Options.UseTextOptions = true;
            this.gcCount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcCount.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gcCount.Caption = "实付价";
            this.gcCount.FieldName = "RealityPrice";
            this.gcCount.MinWidth = 17;
            this.gcCount.Name = "gcCount";
            this.gcCount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gcCount.OptionsFilter.AllowFilter = false;
            this.gcCount.Visible = true;
            this.gcCount.VisibleIndex = 5;
            this.gcCount.Width = 70;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repositoryItemTextEdit1_KeyDown);
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn9.Caption = "积分";
            this.gridColumn9.FieldName = "BonusPoints";
            this.gridColumn9.MinWidth = 17;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.OptionsColumn.AllowFocus = false;
            this.gridColumn9.OptionsColumn.AllowMove = false;
            this.gridColumn9.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn9.OptionsFilter.AllowFilter = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            this.gridColumn9.Width = 38;
            // 
            // ribeDelete
            // 
            this.ribeDelete.AutoHeight = false;
            this.ribeDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "删除", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.ribeDelete.Name = "ribeDelete";
            this.ribeDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ribeDelete.Click += new System.EventHandler(this.ribeDelete_Click);
            // 
            // gridProductSource
            // 
            this.gridProductSource.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridProductSource.Location = new System.Drawing.Point(33, 67);
            this.gridProductSource.MainView = this.gridViewProductSource;
            this.gridProductSource.Margin = new System.Windows.Forms.Padding(4);
            this.gridProductSource.Name = "gridProductSource";
            this.gridProductSource.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridProductSource.Size = new System.Drawing.Size(787, 215);
            this.gridProductSource.TabIndex = 4;
            this.gridProductSource.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductSource});
            // 
            // gridViewProductSource
            // 
            this.gridViewProductSource.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn10});
            this.gridViewProductSource.DetailHeight = 327;
            this.gridViewProductSource.GridControl = this.gridProductSource;
            this.gridViewProductSource.Name = "gridViewProductSource";
            this.gridViewProductSource.OptionsMenu.EnableColumnMenu = false;
            this.gridViewProductSource.OptionsSelection.CheckBoxSelectorColumnWidth = 22;
            this.gridViewProductSource.OptionsSelection.MultiSelect = true;
            this.gridViewProductSource.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewProductSource.OptionsView.ShowGroupPanel = false;
            this.gridViewProductSource.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewProductSource_SelectionChanged);
            this.gridViewProductSource.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridViewProductSource_MouseDown);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.MinWidth = 17;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 66;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.Caption = "套餐名称";
            this.gridColumn2.FieldName = "ProductName";
            this.gridColumn2.MinWidth = 17;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.AllowMove = false;
            this.gridColumn2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 120;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn3.Caption = "价格";
            this.gridColumn3.FieldName = "Price";
            this.gridColumn3.MinWidth = 17;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsColumn.AllowMove = false;
            this.gridColumn3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn3.OptionsFilter.AllowFilter = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 120;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn4.Caption = "折扣";
            this.gridColumn4.FieldName = "Discount";
            this.gridColumn4.MaxWidth = 52;
            this.gridColumn4.MinWidth = 17;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsColumn.AllowMove = false;
            this.gridColumn4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn4.OptionsFilter.AllowFilter = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 52;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn10.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn10.Caption = "积分";
            this.gridColumn10.FieldName = "BonusPoints";
            this.gridColumn10.MinWidth = 17;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.OptionsColumn.AllowFocus = false;
            this.gridColumn10.OptionsColumn.AllowMove = false;
            this.gridColumn10.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn10.OptionsFilter.AllowFilter = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            this.gridColumn10.Width = 22;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // teUserName
            // 
            this.teUserName.Location = new System.Drawing.Point(323, 43);
            this.teUserName.Margin = new System.Windows.Forms.Padding(4);
            this.teUserName.Name = "teUserName";
            this.teUserName.Size = new System.Drawing.Size(100, 20);
            this.teUserName.StyleController = this.layoutControl1;
            this.teUserName.TabIndex = 5;
            // 
            // sbtnQuery
            // 
            this.sbtnQuery.Location = new System.Drawing.Point(772, 43);
            this.sbtnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.sbtnQuery.Name = "sbtnQuery";
            this.sbtnQuery.Size = new System.Drawing.Size(48, 20);
            this.sbtnQuery.StyleController = this.layoutControl1;
            this.sbtnQuery.TabIndex = 6;
            this.sbtnQuery.Text = "查询";
            this.sbtnQuery.Click += new System.EventHandler(this.sbtnQuery_Click);
            // 
            // tePhoneNumber
            // 
            this.tePhoneNumber.Location = new System.Drawing.Point(97, 43);
            this.tePhoneNumber.Name = "tePhoneNumber";
            this.tePhoneNumber.Size = new System.Drawing.Size(157, 20);
            this.tePhoneNumber.StyleController = this.layoutControl1;
            this.tePhoneNumber.TabIndex = 17;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(844, 700);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "添加产品";
            this.layoutControlGroup3.ExpandButtonVisible = true;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem12,
            this.layoutControlItem6,
            this.layoutControlItem2,
            this.emptySpaceItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(824, 321);
            this.layoutControlGroup3.Text = "账单";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sbtnQuery;
            this.layoutControlItem3.FillControlToClientArea = false;
            this.layoutControlItem3.Location = new System.Drawing.Point(739, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(61, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(52, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(61, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = " ";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(4, 14);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridProductSource;
            this.layoutControlItem1.FillControlToClientArea = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(186, 22);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(800, 219);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = " ";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(4, 14);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.pageNavigator;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 243);
            this.layoutControlItem12.MaxSize = new System.Drawing.Size(0, 35);
            this.layoutControlItem12.MinSize = new System.Drawing.Size(99, 35);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(800, 35);
            this.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem12.Text = " ";
            this.layoutControlItem12.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem12.TextSize = new System.Drawing.Size(4, 14);
            this.layoutControlItem12.TextToControlDistance = 5;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.tePhoneNumber;
            this.layoutControlItem6.FillControlToClientArea = false;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(119, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(234, 24);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "  会员手机：";
            this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(68, 14);
            this.layoutControlItem6.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.teUserName;
            this.layoutControlItem2.FillControlToClientArea = false;
            this.layoutControlItem2.Location = new System.Drawing.Point(234, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(219, 22);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(143, 22);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(169, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "会员名称：";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 14);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(403, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(336, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.ExpandButtonVisible = true;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 321);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(824, 359);
            this.layoutControlGroup2.Text = "账单明细";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridProductDetail;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(800, 316);
            this.layoutControlItem4.Text = " ";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(4, 14);
            this.layoutControlItem4.TextToControlDistance = 5;
            // 
            // CheckOutStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CheckOutStatistics";
            this.Size = new System.Drawing.Size(844, 700);
            this.Load += new System.EventHandler(this.CheckOutManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridProductDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductDetail;
        private DevExpress.XtraGrid.GridControl gridProductSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductSource;
        private DevExpress.XtraEditors.TextEdit teUserName;
        private DevExpress.XtraEditors.SimpleButton sbtnQuery;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gcProductName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gcCount;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribeDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private PageNavigator pageNavigator;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraEditors.TextEdit tePhoneNumber;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
