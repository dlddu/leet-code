public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        if (source == destination) return true;
        
        var map = new List<int>[n];
        
        foreach (var pair in edges)
        {
            var (a, b) = (pair[0], pair[1]);
            if (map[a] == null) map[a] = new List<int>();
            map[a].Add(b);
            if (map[b] == null) map[b] = new List<int>();
            map[b].Add(a);
        }
        
        if (map[source] == null) return false;

        var visited = new bool[n];
        var current = new Stack<int>();
        foreach (var node in map[source])
        {
            if (node == destination) return true;
            current.Push(node);
        }

        while (current.TryPop(out var candidate))
        {
            if (candidate == destination) return true;
            if (map[candidate] == null) return false;
            if (visited[candidate]) continue;
            visited[candidate] = true;

            foreach (var node in map[candidate])
            {
                if (node == destination) return true;
                current.Push(node);
            }
        }

        return false;
    }
}