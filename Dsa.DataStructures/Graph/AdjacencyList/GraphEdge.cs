#nullable disable
namespace Dsa.DataStructures.Graph.AdjacencyList
{
    public sealed class GraphEdge
    {
        public GraphEdge() { }

        public GraphEdge(int to, int weight)
        {
            this.To = to;
            this.Weight = weight;
        }

        public int To { get; set; }

        public int Weight { get; set; }
    }
}
