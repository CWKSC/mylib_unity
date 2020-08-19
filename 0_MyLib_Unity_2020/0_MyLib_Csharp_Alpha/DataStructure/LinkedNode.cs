using MyLib_Csharp_Alpha.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MyLib_Csharp_Alpha.DataStructure
{
    public class LinkedNode
    {
        public List<LinkedNode> childrens = new List<LinkedNode>();
        public LinkedNode(params LinkedNode[] childs) => childrens.AddRange(childs);
        public void AddChild(params LinkedNode[] childs) => childrens.AddRange(childs);
        public void RemoveChild(params LinkedNode[] childs) => childs.ForEach(ele => childrens.Remove(ele));
        public void LinkTo(LinkedNode other)
        {
            AddChild(other);
            other.AddChild(this);
        }
    }


    public class LinkedNode<T>
    {
        public LinkedList<LinkedNode<T>> childrens = new LinkedList<LinkedNode<T>>();
        public T data;
        public LinkedNode(T data) => this.data = data;
        public LinkedNode(params LinkedNode<T>[] childs)
        {
            for (int i = 0; i < childs.Length; i++)
            {
                childrens.AddLast(childs[i]);
            }
        }

        public void AddChild(LinkedNode<T> child) => childrens.AddLast(child);

        public void RemoveChild(LinkedNode<T> child) => childrens.Remove(child);

        public void LinkTo(LinkedNode<T> other)
        {
            AddChild(other);
            other.AddChild(this);
        }

        public LinkedNode<T> ForEach(Action<LinkedNode<T>> forEach)
        {
            foreach (LinkedNode<T> child in childrens)
            {
                forEach(child);
            }
            return this;
        }

    }

    public class LinkedNode<T, Class> where Class : LinkedNode<T, Class>
    {

        public T data;
        public LinkedList<Class> childrens = new LinkedList<Class>();

        public LinkedNode(T data) => this.data = data;

        public LinkedNode(params Class[] childs)
        {
            for (int i = 0; i < childs.Length; i++)
            {
                childrens.AddLast(childs[i]);
            }
        }

        public void AddChild(Class child) => childrens.AddLast(child);
        public void AddChilds(params Class[] childs)
        {
            for (int i = 0; i < childs.Length; i++)
            {
                childrens.AddLast(childs[i]);
            }
        }

        public void RemoveChild(Class child) => childrens.Remove(child);

        public LinkedNode<T, Class> ForEach(Action<Class> forEach)
        {
            foreach (Class child in childrens)
            {
                forEach(child);
            }
            return this;
        }

    }



}
