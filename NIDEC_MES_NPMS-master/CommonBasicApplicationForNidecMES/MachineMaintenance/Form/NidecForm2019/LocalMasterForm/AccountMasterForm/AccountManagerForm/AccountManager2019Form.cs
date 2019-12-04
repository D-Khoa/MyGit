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
                trvOther.Nodes["account_code"].Nodes.Add(node.account_code_cd + " : " + node.account_code_name);
            }
            ValueObjectList<RankInfoVo> rankCode = (ValueObjectList<RankInfoVo>)DefaultCbmInvoker
                                               .Invoke(new GetRankInfoCbm(), new RankInfoVo());
            foreach (RankInfoVo node in rankCode.GetList())
            {
                trvOther.Nodes["rank_cd"].Nodes.Add(node.rank_cd + " : " + node.rank_name);
            }
        }

        #region BUTTONS
        private void btnSearch_Click(object sender, EventArgs e)
        {

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

        private void CheckList(TreeNode root, string list)
        {
            list = "'1'";
            foreach (TreeNode node in root.Nodes)
            {
                if (node.Checked)
                    list += ",'" + node.Tag + "'";
            }
        }

        private void CheckTreeView(TreeView tree)
        {
            foreach (TreeNode root in tree.Nodes)
            {
                if (root.Name == "asset_model")
                    CheckList(root, Vo.list_asset_model);
                if (root.Name == "asset_type")
                    CheckList(root, Vo.list_asset_type);
                if (root.Name == "asset_invoice")
                    CheckList(root, Vo.list_asset_invoice);
                if (root.Name == "asset_label")
                    CheckList(root, Vo.list_asset_label);
                if (root.Name == "account_cd")
                    CheckList(root, Vo.list_account_cd);
                if (root.Name == "account_location")
                    CheckList(root, Vo.list_account_location);
                if (root.Name == "location")
                    CheckList(root, Vo.list_location);
                if (root.Name == "invertory_times")
                    CheckList(root, Vo.list_invertory_times);
                if (root.Name == "rank")
                    CheckList(root, Vo.list_rank);
                if (root.Name == "factory")
                    CheckList(root, Vo.list_factory);
            }
        }
        #endregion
    }
}
