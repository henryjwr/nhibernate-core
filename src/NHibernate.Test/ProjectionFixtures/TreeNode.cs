using Iesi.Collections.Generic;
using NHibernate.Test.ProjectionFixtures;

namespace NHibernate.Test.ProjectionFixtures
{
    public class TreeNode
    {
        public virtual Key Key { get; set; }
        public virtual TreeNode Parent { get; set; }
        public virtual NodeType Type { get; set; }
        public virtual ISet<TreeNode> DirectChildren { get; set; }

        public TreeNode()
        {
            DirectChildren = new HashedSet<TreeNode>();
        }
    }
}