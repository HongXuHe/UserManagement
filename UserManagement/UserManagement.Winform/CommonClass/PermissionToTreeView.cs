using MapperConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagement.Dtos;
using UserManagement.IRepository;

namespace UserManagement.Winform.CommonClass
{
    public class PermissionToTreeView
    {
        /// <summary>
        /// add nested permissions to permission list
        /// </summary>
        /// <param name="permissions">all permissions</param>
        /// <param name="userPermissions">user's permissions</param>
        /// <param name="treeNode"></param>
        /// <returns></returns>
        public static TreeNode AddPermissionToTreeView(List<PermissionDto> permissions, List<PermissionDto> userPermissions, TreeNode treeNode, IPermissionRepo _permissionRepo)
        {
            foreach (var permission in permissions)
            {
                // treeNode = new TreeNode(permission.PermissionName);
                treeNode.Nodes.Add(permission.PermissionName);
                if (userPermissions.Any(p => p.PermissionName == permission.PermissionName))
                {
                    treeNode.LastNode.Checked = true;
                    treeNode.Checked = true;
                }
                else
                {
                    treeNode.LastNode.Checked = false;
                }
                var childPermissions = Mapping.Mapper.Map<List<PermissionDto>>(_permissionRepo.GetList(p => p.ParentId == permission.Id.ToString()).ToList());
                AddPermissionToTreeView(childPermissions, userPermissions, treeNode.LastNode, _permissionRepo);
            }
            return treeNode;
        }
    }
}
