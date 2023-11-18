namespace Dsa.Recursion
{
    using System.Drawing;

    public class MazeSolver
    {
        private static readonly Point[] Dir = new[]
        {
            new Point { X = -1, Y = 0 },
            new Point { X = 1, Y = 0 },
            new Point { X = 0, Y = -1 },
            new Point { X = 0, Y = 1 },
        };

        private static bool Walk(string[] maze, char wall, Point curr, Point end, bool[][] seen, ICollection<Point> path)
        {
            // off the map
            if (curr.X < 0 || curr.X >= maze[0].Length || curr.Y < 0 || curr.Y >= maze.Length)
            {
                return false;
            }

            // on a wall
            if (maze[curr.Y].ToCharArray()[curr.X] == wall)
            {
                return false;
            }

            if (curr.X == end.X && curr.Y == end.Y)
            {
                path.Append(end);
                return true;
            }

            if (seen[curr.Y][curr.X])
            {
                return false;
            }

            // pre
            seen[curr.Y][curr.X] = true;
            path.Append(curr);

            // recurse
            for (var i = 0; i < Dir.Length; i++)
            {
                var currentDir = Dir[i];
                var walkSuccess = Walk(maze, wall, new Point
                {
                    X = curr.X + currentDir.X,
                    Y = curr.Y + currentDir.Y,
                }, end, seen, path);

                if (walkSuccess)
                {
                    return true;
                }
            }

            // post
            path.Remove(curr);

            return false;
        }

        public static IEnumerable<Point> Solve(string[] maze, char wall, Point start, Point end)
        {
            var length = maze.Length;
            var width = maze[0].Length;
            var path = new List<Point>();

            var seen = new bool[length][];

            Walk(maze, wall, start, end, seen, path);

            return path;
        }
    }
}
