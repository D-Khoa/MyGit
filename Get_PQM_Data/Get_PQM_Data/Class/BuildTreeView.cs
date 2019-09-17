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
        public static void GetRoot(this TreeView TreeViewName, string RootName, List<string> ListRoots)
        {
            if(RootName != "")
            {
                TreeNode Root = new TreeNode(RootName);
                TreeViewName.Nodes.Add(Root);
                foreach (string Roots in ListRoots)
                    Root.Nodes.Add(Roots);
            }
            else
            {
                foreach (string Roots in ListRoots)
                    TreeViewName.Nodes.Add(Roots);
            }
        }

        public static void GetNodes(this TreeNode RootName, List<string> ListNodes)
        {
            foreach (string Nodes in ListNodes)
                RootName.Nodes.Add(Nodes);
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
            ListNodes.Clear();
            foreach(TreeNode Node in RootName)
            {
                if (Node.Checked)
                {
                        ListNodes.Add(Node.Text);
                }
                if (Node.Nodes.Count > 0) Node.Nodes.SelectNodes(ref ListNodes);
            }
            ListNodes = ListNodes.Distinct().ToList();
        }
    }
}
