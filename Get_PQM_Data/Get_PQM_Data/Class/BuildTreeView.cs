using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Get_PQM_Data
{
    public static class BuildTreeView
    {
        public static void GetRoot(this TreeView TreeViewName, string RootName, List<string> ListNodes)
        {
            if(RootName != "")
            {
                TreeNode Root = new TreeNode(RootName);
                TreeViewName.Nodes.Add(Root);
                foreach (string NodeName in ListNodes)
                    Root.Nodes.Add(NodeName);
            }
            else
            {
                foreach (string NodeName in ListNodes)
                    TreeViewName.Nodes.Add(NodeName);
            }
        }

        public static void CheckedNode(this TreeNode RootName, bool RootChecked)
        {
            foreach(TreeNode Node in RootName.Nodes)
            {
                if (Node.Checked != RootChecked) Node.Checked = RootChecked;
                if (Node.Nodes.Count > 0) Node.CheckedNode(RootChecked);
            }
        }

        public static void SelectNodes(this TreeNodeCollection RootName, ref List<string> ListNodes)
        {
            foreach(TreeNode Node in RootName)
            {
                if (Node.Checked) ListNodes.Add(Node.Text);
                if (Node.Nodes.Count > 0) Node.Nodes.SelectNodes(ref ListNodes);
            }
        }
    }
}
