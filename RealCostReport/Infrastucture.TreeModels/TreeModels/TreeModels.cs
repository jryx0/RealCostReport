using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.TreeModels.TreeModels
{
    public class LeafBase
    {
        public int Id { set; get; }
        public String Name { set; get; }
        public int Level { set; get; }

        public virtual void CopyNodeValue(LeafBase leaf)
        {
            this.Id = leaf.Id;
            this.Level = leaf.Level;
            this.Name = leaf.Name;
        }
    }

    public class TreeBase<T> where T : new()
    {
        public int Id { set; get; }

        public T Node { set; get; }

        public TreeStauts Status { set; get; }
        public TreeBase<T> Parent { set; get; }
        public virtual List<TreeBase<T>> Child { set; get; }
    }

    public class LabelTrees
    {
        public int id { set; get; }

        public String Labels { set; get; }
        public TreeBase<LeafBase> LabelTree { set; get; }
    }


    public enum TreeStauts
    {
        Unchanged,
        NewNode,
        Delete,
        Modified
    }
}
