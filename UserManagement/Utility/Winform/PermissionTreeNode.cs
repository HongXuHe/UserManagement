using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace UserManagement.Utility.Winform
{
    public class PermissionTreeNode
    {
        /// <summary>
        /// check and uncheck treenode according to their parent node
        /// </summary>
        /// <param name="node">parent node</param>
        /// <param name="isChecked">is parent node checked</param>
        public static void CheckTreeViewNode(TreeNode node, bool isChecked, List<string> permissionList)
        {
            //var tableList =_userRepo.GetDataBaseTables(x => true).Select(x => x.Substring(22)).ToList();
            if (node.Nodes.Count == 0)
            {
                PermissionListAddRemove(node, permissionList);
            }
            foreach (TreeNode item in node.Nodes)
            {
                item.Checked = isChecked;
                if (item.Nodes.Count > 0)
                {
                    CheckTreeViewNode(item, item.Checked, permissionList);
                    // PermissionListAddRemove(item);
                }
                PermissionListAddRemove(item, permissionList);

            }
        }

        /// <summary>
        /// permission list add/remove to field in _permissionList
        /// </summary>
        /// <param name="node"></param>
        public static void PermissionListAddRemove(TreeNode node, List<string> permissionList)
        {
            if (node.Nodes.Count == 0)
            {
                if (!permissionList.Contains(node.Text))
                {
                    if (node.Checked)
                    {
                        permissionList.Add(node.Text);
                    }
                }
                else
                {
                    if (!node.Checked)
                    {
                        permissionList.Remove(node.Text);
                    }

                }
            }
        }
    }
}
