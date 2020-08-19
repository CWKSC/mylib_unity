using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Alpha.DataStructure
{

    public class GraphNode : LinkedNode
    {
        public GraphNode visitedFrom;
        public bool visited = false;
    }

    //public class GraphNode<T>
    //{

    //}


    public class GraphNode<T> : LinkedNode<T, GraphNode<T>>
    {
        public bool visited = false;
        public GraphNode<T> from;

        public GraphNode(T data) : base(data) { }

        public GraphNode(params GraphNode<T>[] childs) : base(childs) { }

        public void LinkTo(GraphNode<T> other)
        {
            AddChild(other);
            other.AddChild(this);
        }

    }
}
