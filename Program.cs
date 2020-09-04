using System;
using System.Collections.Generic;
using System.Collections;
namespace DFS
{
    class Program
    {
        static void Main(string[] args)
        {
            int nodes = 7;
            Graph aList = new Graph(nodes);
            aList.AddEdges(0,1);
            aList.AddEdges(0,2);
            aList.AddEdges(1,3);
            aList.AddEdges(2,4);
            aList.AddEdges(3,5);
            aList.AddEdges(4,5);
            aList.AddEdges(4,6);
            aList.DeepFisrtSearch(0);
        }
    }

    // graph

    class Graph{

       List<List<int>> graph;
        bool [] visited;
        public Graph(int nodes){
            graph= new List<List<int>>();
            visited = new bool[nodes];
            for (int i = 0; i < nodes; i++)
            {
                graph.Insert(i, new List<int>());
            }
        }

        public void AddEdges(int start, int end){
            graph[start].Add(end);
            graph[end].Add(start);
        }

        public void DeepFisrtSearch(int startingNode){
            Stack<int> storedVistedNode = new Stack<int>();
            storedVistedNode.Push(startingNode);
            visited[startingNode]= true;

            while(storedVistedNode.Count!= 0){
              int node = storedVistedNode.Pop();
              Console.Write(node+ " ");
              List<int> connectedNodes = graph[node];

              foreach (var item in connectedNodes )
              {
                  if(visited[item]!=true){
                      storedVistedNode.Push(item);
                      visited[item]=true;
                  }
              }
            
            }
        }
    }
}
