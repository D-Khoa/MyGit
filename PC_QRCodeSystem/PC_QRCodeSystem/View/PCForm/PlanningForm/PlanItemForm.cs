using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PC_QRCodeSystem.Model;

namespace PC_QRCodeSystem.View
{
    public partial class PlanItemForm : FormCommon
    {
        pts_plan planData { get; set; }
        pts_item itemData { get; set; }
        pts_stock stockData { get; set; }

        m_mes_user userData { get; set; }
        pts_destination desData { get; set; }

        public PlanItemForm(pts_plan inPlan)
        {
            InitializeComponent();
            planData = new pts_plan();
            itemData = new pts_item();
            stockData = new pts_stock();
            userData = new m_mes_user();
            desData = new pts_destination();
            UpdateFields(inPlan);
            UpdateGrid(true);
        }

        #region BUTTONS EVENT
        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region SUB EVENT
        private void UpdateFields(pts_plan inPlan)
        {
            desData.GetListDestination(inPlan.destination_cd, string.Empty);
            lbPlanCD.Text = inPlan.plan_cd;
            lbSetNum.Text = inPlan.set_number;
            lbModelName.Text = inPlan.model_cd;
            lbPlanQty.Text = inPlan.plan_qty.ToString();
            lbUser.Text = inPlan.plan_usercd + ": " + userData.GetUser(inPlan.plan_usercd).user_name;
            lbDestination.Text = inPlan.destination_cd + ": " + desData.listdestination[0].destination_name;
        }

        private void UpdateGrid(bool isSearch)
        {
            if (isSearch)
            {
                stockData.SearchItem(new pts_stock
                {
                    order_no = lbSetNum.Text
                });
            }
            dgvData.DataSource = stockData.listStockItems;
        }
        #endregion
    }
}
