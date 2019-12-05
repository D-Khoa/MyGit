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
                nodename.Name = node.account_code_cd;
                nodename.Text = node.account_code_cd + " : " + node.account_code_name;
                trvOther.Nodes["account_cd"].Nodes.Add(nodename);
            }
            ValueObjectList<RankInfoVo> rankCode = (ValueObjectList<RankInfoVo>)DefaultCbmInvoker
                                                 .Invoke(new GetRankInfoCbm(), new RankInfoVo());
            foreach (RankInfoVo node in rankCode.GetList())
            {
                TreeNode nodename = new TreeNode();
                nodename.Name = node.rank_cd;
                nodename.Text = node.rank_cd + " : " + node.rank_name;
                trvOther.Nodes["rank_cd"].Nodes.Add(nodename);
            }
            ValueObjectList<AccountLocationVo> sectionCode = (ValueObjectList<AccountLocationVo>)DefaultCbmInvoker
                                                           .Invoke(new GetAccountLocationCbm(), new AccountLocationVo());
            foreach (AccountLocationVo node in sectionCode.GetList())
            {
                TreeNode nodename = new TreeNode();
                nodename.Name = node.account_location_cd;
                nodename.Text = node.account_location_cd + " : " + node.account_location_name;
                trvOther.Nodes["account_location_cd"].Nodes.Add(nodename);
            }
            ValueObjectList<LocationInfoVo> locationCode = (ValueObjectList<LocationInfoVo>)DefaultCbmInvoker
                                                         .Invoke(new GetLocationInfoCbm(), new LocationInfoVo());
            foreach (LocationInfoVo node in locationCode.GetList())
            {
                TreeNode nodename = new TreeNode();
                nodename.Name = node.location_id;
                nodename.Text = node.location_name;
                trvOther.Nodes["location_cd"].Nodes.Add(nodename);
            }
            ValueObjectList<InvertoryTimeVo> invertoryTime = (ValueObjectList<InvertoryTimeVo>)DefaultCbmInvoker
                                                           .Invoke(new GetInvertoryTimeCbm(), new InvertoryTimeVo());
            foreach (InvertoryTimeVo node in invertoryTime.GetList())
            {
                TreeNode nodename = new TreeNode();
                nodename.Name = node.invertory_time_id;
                nodename.Text = node.invertory_time_name;
                trvOther.Nodes["invertory_time_cd"].Nodes.Add(nodename);
            }
            ValueObjectList<FactoryInfoVo> factoryCode = (ValueObjectList<FactoryInfoVo>)DefaultCbmInvoker
                                                       .Invoke(new GetInvertoryTimeCbm(), new FactoryInfoVo());
            foreach (FactoryInfoVo node in factoryCode.GetList())
            {
                TreeNode nodename = new TreeNode();
                nodename.Name = node.factory_cd;
                nodename.Text = node.factory_name;
                trvOther.Nodes["invertory_time_cd"].Nodes.Add(nodename);
            }
            #endregion
        }

        #region BUTTONS
        private void btnSearch_Click(object sender, EventArgs e)
        {
            CheckTreeView(trvAsset);
            CheckTreeView(trvOther);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnDepreciation_Click(object sender, EventArgs e)
        {

        }

        private void btnTransferAsset_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
        #endregion

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

        private string CheckList(TreeNode root)
        {
            string list = "'1'";
            foreach (TreeNode node in root.Nodes)
            {
                if (node.Checked)
                    list += ",'" + node.Name + "'";
            }
            return list;
        }

        private void CheckTreeView(TreeView tree)
        {
            foreach (TreeNode root in tree.Nodes)
            {
                if (root.Name == "asset_model")
                    Vo.list_asset_model = CheckList(root);
                if (root.Name == "asset_type")
                    Vo.list_asset_type = CheckList(root);
                if (root.Name == "asset_invoice")
                    Vo.list_asset_invoice = CheckList(root);
                if (root.Name == "asset_label")
                    Vo.list_asset_label = CheckList(root);
                if (root.Name == "account_cd")
                    Vo.list_account_cd = CheckList(root);
                if (root.Name == "account_location_cd")
                    Vo.list_account_location = CheckList(root);
                if (root.Name == "location_cd")
                    Vo.list_location = CheckList(root);
                if (root.Name == "invertory_times_cd")
                    Vo.list_invertory_times = CheckList(root);
                if (root.Name == "rank_cd")
                    Vo.list_rank = CheckList(root);
                if (root.Name == "factory_cd")
                    Vo.list_factory = CheckList(root);
            }
        }
        #endregion
    }
}
