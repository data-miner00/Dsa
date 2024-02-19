namespace Dsa.Problems
{
    using System;
    using System.Collections.Generic;

    public static class GraphConnection
    {
        public class Node
        {
            public IEnumerable<Node> Connections { get; set; }

            required public string Name { get; set; }
        }

        public static bool IsConnectedDFS(Node start, Node target, HashSet<Node> visited)
        {
            if (start == target)
            {
                return true;
            }

            visited.Add(start);

            foreach (var node in start.Connections)
            {
                if (!visited.Contains(node))
                {
                    if (IsConnectedDFS(node, target, visited))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool IsConnectedBFS(Node start, Node target, Queue<Node> visited)
        {
            if (start == target)
            {
                return true;
            }

            foreach (var node in start.Connections)
            {
                visited.Enqueue(node);
            }

            while (visited.Count > 0)
            {
                if (IsConnectedBFS(visited.Dequeue(), target, visited))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsConnectedBFSChatGPT(Node start, Node target)
        {
            HashSet<Node> visited = new();
            Queue<Node> queue = new();

            visited.Add(start);
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (current == target)
                {
                    return true;
                }

                foreach (var node in current.Connections)
                {
                    if (!visited.Contains(node))
                    {
                        visited.Add(node);
                        queue.Enqueue(node);
                    }
                }
            }

            return false;
        }

        public static void Demo()
        {
            var nodeA = new Node { Name = "A" };
            var nodeB = new Node { Name = "B" };
            var nodeC = new Node { Name = "C" };
            var nodeD = new Node { Name = "D" };
            var nodeE = new Node { Name = "E" };

            nodeA.Connections = [nodeB];
            nodeB.Connections = [nodeA, nodeE, nodeC];
            nodeC.Connections = [nodeD, nodeA];
            nodeD.Connections = [];
            nodeE.Connections = [];

            Console.WriteLine("Is A connected to E? "+ IsConnectedDFS(nodeA, nodeE, []).ToString());
            Console.WriteLine("Is A connected to D? "+ IsConnectedDFS(nodeA, nodeD, []).ToString());
            Console.WriteLine("Is B connected to A? "+ IsConnectedDFS(nodeB, nodeA, []).ToString());
            Console.WriteLine("Is C connected to E? "+ IsConnectedDFS(nodeC, nodeE, []).ToString());
            Console.WriteLine("Is E connected to B? "+ IsConnectedDFS(nodeE, nodeB, []).ToString());
            Console.WriteLine(new string('-', 10));
            Console.WriteLine("Is A connected to E? "+ IsConnectedBFS(nodeA, nodeE, []).ToString());
            Console.WriteLine("Is A connected to D? "+ IsConnectedBFS(nodeA, nodeD, []).ToString());
            Console.WriteLine("Is B connected to A? "+ IsConnectedBFS(nodeB, nodeA, []).ToString());
            Console.WriteLine("Is C connected to E? "+ IsConnectedBFS(nodeC, nodeE, []).ToString());
            Console.WriteLine("Is E connected to B? "+ IsConnectedBFS(nodeE, nodeB, []).ToString());
        }
    }
}
