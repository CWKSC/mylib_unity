using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Alpha.DataStructure
{
    public partial class Graph
    {

        public static void Test()
        {

            GraphNode<string> A = new GraphNode<string>("A");
            GraphNode<string> B = new GraphNode<string>("B");
            GraphNode<string> C = new GraphNode<string>("C");
            GraphNode<string> D = new GraphNode<string>("D");
            GraphNode<string> E = new GraphNode<string>("E");
            GraphNode<string> F = new GraphNode<string>("F");
            GraphNode<string> G = new GraphNode<string>("G");
            GraphNode<string> H = new GraphNode<string>("H");
            GraphNode<string> I = new GraphNode<string>("I");

            A.AddChilds(H, C);
            B.AddChild(C);
            C.AddChilds(A, B, D, E);
            D.AddChilds(C, E, F);
            E.AddChilds(C, D);
            F.AddChilds(D, G);
            G.AddChilds(F, H);
            H.AddChilds(A, G);

            Graph<string> graph = new Graph<string>(A, B, C, D, E, F, G, H);
            (bool isExistPath, List<GraphNode<string>> path) = graph.BFS(B, I);
            if (isExistPath)
            {
                path.ForEach(node => Console.WriteLine(node.data));
            }
            else
            {
                Console.WriteLine("No exist path");
            }



        }

    }
}
