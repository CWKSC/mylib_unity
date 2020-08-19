using MyLib_Csharp_Alpha.CommonClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Alpha.DataStructure
{
    public partial class Graph
    {
        public readonly List<GraphNode> nodes = new List<GraphNode>();
        public Graph(params GraphNode[] nodes) => this.nodes.AddRange(nodes);
        public void AddNode(params GraphNode[] nodes) => this.nodes.AddRange(nodes);
        public void RemoveNode(params GraphNode[] nodes) => nodes.ForEach(ele => this.nodes.Remove(ele));
        public void AddEdge(GraphNode a, GraphNode b) => a.LinkTo(b);
    }


    public partial class Graph<T>
    {
        public readonly LinkedList<GraphNode<T>> nodes = new LinkedList<GraphNode<T>>();

        public Graph(params GraphNode<T>[] nodes)
        {
            for (int i = 0; i < nodes.Length; i++)
            {
                this.nodes.AddLast(nodes[i]);
            }
        }

        public Graph<T> AddNode(GraphNode<T> node)
        {
            nodes.AddLast(node);
            return this;
        }

        public Graph<T> RemoveNode(GraphNode<T> node)
        {
            nodes.Remove(node);
            return this;
        }

        public Graph<T> AddEdge(GraphNode<T> a, GraphNode<T> b)
        {
            a.LinkTo(b);
            return this;
        }

        public Graph<T> ForEach(Action<GraphNode<T>> forEach)
        {
            foreach (GraphNode<T> node in nodes)
            {
                forEach(node);
            }
            return this;
        }

        public (bool, List<GraphNode<T>>) BFS(GraphNode<T> start, GraphNode<T> goal)
        {
            if (start == goal) return (true, new List<GraphNode<T>>() { goal });
            start.visited = true;

            List<GraphNode<T>> queue = new List<GraphNode<T>> { start };
            while (queue.Count != 0)
            {
                GraphNode<T> removeNode = queue[0];
                queue.Remove(removeNode);
                foreach (var child in removeNode.childrens)
                {
                    if (!child.visited)
                    {
                        child.visited = true;
                        child.from = removeNode;
                        queue.Add(child);
                    }
                    if (child == goal)
                    {
                        List<GraphNode<T>> result = new List<GraphNode<T>> { goal };
                        GraphNode<T> pathNode = child.from;
                        while (pathNode != start)
                        {
                            result.Add(pathNode);
                            pathNode = pathNode.from;
                        }
                        result.Add(start);
                        result.Reverse();
                        return (true, result);
                    }
                }
            }
            return (false, null);
        }


    }
}
