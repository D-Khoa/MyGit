using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Common;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2019Dao;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm.Nidec2019Cbm;


namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.NidecForm2019
{
    public partial class AccountManager2019Form : FormCommonNCVP
    {
        AccountManagerVo Vo = new AccountManagerVo();

        public AccountManager2019Form()
        {
            InitializeComponent();
        }

        private void AccountManager2019Form_Load(object sender, EventArgs e)
        {
            #region GET NODES FROM DATABASE
            ValueObjectList<AssetInfoVo> assetInfo = (ValueObjectList<AssetInfoVo>)DefaultCbmInvoker
                                                   .Invoke(new GetAssetInfoCbm(), new AssetInfoVo());
            foreach (string node in assetInfo.GetList().Select(x => x.asset_model).Distinct())
            {
                trvAsset.Nodes["asset_model"].Nodes.Add(node);
            }
            foreach (string node in assetInfo.GetList().Select(x => x.asset_type).Distinct())
            {
                trvAsset.Nodes["asset_type"].Nodes.Add(node);
            }
            foreach (string node in assetInfo.GetList().Select(x => x.asset_invoice).Distinct())
            {
                trvAsset.Nodes["asset_invoice"].Nodes.Add(node);
            }
            foreach (string node in assetInfo.GetList().Select(x => x.label_status).Distinct())
            {
                trvAsset.Nodes["label_status"].Nodes.Add(node);
            }
            ValueObjectList<AccountCodeVo> accountCode = (ValueObjectList<AccountCodeVo>)DefaultCbmInvoker
                                                       .Invoke(new GetAccountCodeCbm(), new AccountCodeVo());
            foreach (AccountCodeVo node in accountCode.GetList())
            {
                TreeNode nodename = new TreeNode();
                nodename.Name = node.account_code_id.ToString();
                nodename.Text = node.account_code_cd + " : " + node.account_code_name;
                trvOther.Nodes["account_cd"].Nodes.Add(nodename);
            }
            ValueObjectList<RankInfoVo> rankCode = (ValueObjectList<RankInfoVo>)DefaultCbmInvoker
                                                 .Invoke(new GetRankInfoCbm(), new RankInfoVo());
            foreach (RankInfoVo node in rankCode.GetList())
            {
                TreeNode nodename = new TreeNode();
                nodename.Name = node.rank_id.ToString();
                nodename.Text = node.rank_cd + " : " + node.rank_name;
                trvOther.Nodes["rank_cd"].Nodes.Add(nodename);
            }
            ValueObjectList<AccountLocationVo> sectionCode = (ValueObjectList<AccountLocationVo>)DefaultCbmInvoker
                                                           .Invoke(new GetAccountLocationCbm(), new AccountLocationVo());
            foreach (AccountLocationVo node in sectionCode.GetList())
            {
                TreeNode nodename = new TreeNode();
                nodename.Name = node.account_location_id.ToString();
                nodename.Text = node.account_location_cd + " : " + node.account_location_name;
                trvOther.Nodes["account_location_cd"].Nodes.Add(nodename);
            }
            ValueObjectList<LocationInfoVo> locationCode = (ValueObjectList<LocationInfoVo>)DefaultCbmInvoker
                                                         .Invoke(new GetLocationInfoCbm(), new LocationInfoVo());
            foreach (LocationInfoVo node in locationCode.GetList())
            {
                TreeNode nodename = new TreeNode();
                nodename.Name = node.location_id.ToString();
                nodename.Text = node.location_cd + " : " + node.location_name;
                trvOther.Nodes["location_cd"].Nodes.Add(nodename);
            }
            ValueObjectList<InvertoryTimeVo> invertoryTime = (ValueObjectList<InvertoryTimeVo>)DefaultCbmInvoker
                                                           .Invoke(new GetInvertoryTimeCbm(), new InvertoryTimeVo());
            foreach (InvertoryTimeVo node in invertoryTime.GetList())
            {
                TreeNode nodename = new TreeNode();
                nodename.Name = node.invertory_time_id.ToString();
                nodename.Text = node.invertory_time_name;
                trvOther.Nodes["invertory_time_cd"].Nodes.Add(nodename);
            }
            ValueObjectList<FactoryInfoVo> factoryCode = (ValueObjectList<FactoryInfoVo>)DefaultCbmInvoker
                                                       .Invoke(new GetFactoryInfoCbm(), new FactoryInfoVo());
            foreach (FactoryInfoVo node in factoryCode.GetList())
            {
                TreeNode nodename = new TreeNode();
                nodename.Name = node.factory_cd;
                nodename.Text = node.factory_name;
                trvOther.Nodes["factory_cd"].Nodes.Add(nodename);
            }
            ValueObjectList<UnitInfoVo> unitCode = (ValueObjectList<UnitInfoVo>)DefaultCbmInvoker
                                           .Invoke(new GetUnitInfoCbm(), new UnitInfoVo());
            foreach (UnitInfoVo node in unitCode.GetList())
            {
                TreeNode nodename = new TreeNode();
                nodename.Name = node.unit_id.ToString();
                nodename.Text = node.unit_name;
                trvOther.Nodes["unit_cd"].Nodes.Add(nodename);
            }
            #endregion
        }

        #region BUTTONS
        private void btnSearch_Click(object sender, EventArgs e)
        {
            CheckTreeView(trvAsset, false);
            CheckTreeView(trvOther, true);
            Vo = (AccountManagerVo)DefaultCbmInvoker.Invoke(new GetAccountInfoCbm(), Vo);
            UpdateGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Renew();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (Vo.table.Rows.Count > 0)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Excel Documents (*.xlsx)|*.xlsx|Excel Documents 97-2003 (*.xls)|*.xls|All file (*.*)|*.*";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    sf.FileName.CreateExcelWorkBook();
                    Vo.table.DatatableToExcel();
                    sf.FileName.SaveAndExit(true);
                    Cursor = Cursors.Default;
                }
            }
        }

        private void btnDepreciation_Click(object sender, EventArgs e)
        {

        }

        private void btnTransferAsset_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void UpdateGrid()
        {
            dgvAccountData.DataSource = Vo.table;
            dgvAccountData.AutoResizeColumnHeadersHeight();
            dgvAccountData.Refresh();
            tsRowCounter.Text = Vo.table.Rows.Count + " rows";
        }

        private void CounterCost()
        {
            InvertoryTimeVo maxInvertory = (InvertoryTimeVo)DefaultCbmInvoker.Invoke(new GetInvertoryTimeMaxCbm(), new InvertoryTimeVo());
            int totalMachine = (int)Vo.table.Compute("sum(Qty)", "");
            int invertoryMachine = (int)Vo.table.Compute("sum(Qty)", "");
            int totalMachine = (int)Vo.table.Compute("sum(Qty)", "Qty > 0");
            int totalMachine = (int)Vo.table.Compute("sum(Qty)", "Qty > 0");

        }

        private void Renew()
        {
            Vo = new AccountManagerVo();
            dgvAccountData.DataSource = null;
            dgvAccCounter.DataSource = null;
            dgvAccountDep.DataSource = null;
            dgvRankDep.DataSource = null;
            foreach (TreeNode root in trvAsset.Nodes)
                root.Checked = false;
            foreach (TreeNode root in trvOther.Nodes)
                root.Checked = false;
        }

        private void txtAssetCode_TextChanged(object sender, EventArgs e)
        {
            if (txtAssetCode.Text.Length > 10)
            {
                txtAssetCode.Text.Remove(10);
            }
        }

        #region TREEVIEW CHECKBOX
        private void trvAsset_AfterCheck(object sender, TreeViewEventArgs e)
        {
            Nodes_Check(e.Node, e.Node.Checked);
        }

        private void trvOther_AfterCheck(object sender, TreeViewEventArgs e)
        {
            Nodes_Check(e.Node, e.Node.Checked);
        }

        private void Nodes_Check(TreeNode root, bool check)
        {
            foreach (TreeNode node in root.Nodes)
            {
                node.Checked = check;
                Nodes_Check(node, node.Checked);
            }
        }

        private string CheckList(TreeNode root, bool name)
        {
            string list = "'0'";
            foreach (TreeNode node in root.Nodes)
            {
                if (node.Checked && !name)
                    list += ",'" + node.Text + "'";
                if (node.Checked && name)
                    list += ",'" + node.Name + "'";
            }
            return list;
        }

        private void CheckTreeView(TreeView tree, bool name)
        {
            Vo.value_expired = false;
            Vo.value_valid = false;
            foreach (TreeNode root in tree.Nodes)
            {
                if (root.Name == "asset_model")
                    Vo.list_asset_model = CheckList(root, name);
                if (root.Name == "asset_type")
                    Vo.list_asset_type = CheckList(root, name);
                if (root.Name == "asset_invoice")
                    Vo.list_asset_invoice = CheckList(root, name);
                if (root.Name == "label_status")
                    Vo.list_asset_label = CheckList(root, name);
                if (root.Name == "account_cd")
                    Vo.list_account_cd = CheckList(root, name);
                if (root.Name == "account_location_cd")
                    Vo.list_account_location = CheckList(root, name);
                if (root.Name == "location_cd")
                    Vo.list_location = CheckList(root, name);
                if (root.Name == "invertory_time_cd")
                    Vo.list_invertory_times = CheckList(root, name);
                if (root.Name == "rank_cd")
                    Vo.list_rank = CheckList(root, name);
                if (root.Name == "factory_cd")
                    Vo.list_factory = CheckList(root, name);
                if (root.Name == "unit_cd")
                    Vo.list_unit = CheckList(root, name);
                if (root.Name == "net_value" && root.Nodes["valid"].Checked)
                    Vo.value_valid = true;
                if (root.Name == "net_value" && root.Nodes["expired"].Checked)
                    Vo.value_expired = true;
            }
        }
        #endregion

        private void dgvAccountData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }
    }
}
