public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        // 출발지와 목적지가 동일
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
        
        // 출발지에 연결된 그래프가 없음
        if (map[source] == null) return false;

        // 방문 여부 기록
        var visited = new bool[n];
        
        // 스택으로 DFS
        var current = new Stack<int>();
        current.PushRange(map[source]);

        while (current.TryPop(out var candidate))
        {
            if (candidate == destination) return true; // 도착
            if (map[candidate] == null) return false; // 진행 불가능
            if (visited[candidate]) continue; // 이미 방문
            
            visited[candidate] = true;
            current.PushRange(map[candidate]);
        }

        return false;
    }
}

internal static class Extension
{
    internal static void PushRange(this Stack<int> a, List<int> b)
    {
        foreach (var n in b) a.Push(n);
    }
}