using System.Collections.Generic;
using TmTech.Control.Model;

namespace TmTech.Control
{
    public interface ITreeview
    {
        void BindDataSource<T>(IList<T> lstSource);
        void AddNode<T>(T nodeInsert, bool parentNode = true) where T : TreeNodeModel;
        void UpdateNode<T>(T nodeUpdate, bool parentNode = true) where T : TreeNodeModel;
        void DeleteNode<T>(T nodeDelete, bool parentNode = true) where T : TreeNodeModel;
        void UpdateOrInsertNode<T>(T node, bool parrentNode = true) where T : TreeNodeModel;
    }
}
