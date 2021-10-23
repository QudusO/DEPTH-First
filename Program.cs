using System;

namespace dfs
{
    partial class Program
    {
        static Node sample_tree(){
            Node root =
                //new Node("A", new Node ("B",new Node("C"), new Node("D")),
                //new Node("E", new Node("F"), new Node("G", new Node("H"), null)));

                new Node("A", new Node("B", new Node("C"), new Node("D"), new Node("E"), new Node("6")),
                          new Node("F"), new Node("G"), new Node("H"));
            return root;
        }
        static void Main(string[] args)
        {
            Node tree = sample_tree();
            Console.WriteLine("DFS-->");
             dfs_traversal(tree);
            //Console.WriteLine("Hello World!");
        }
    }

    class Node{
        public Node up, left, right, down; 
        public String data;
    

        public Node(String data, Node up , Node left , Node right, Node down){
            this.data = data;
            this.up = up;
            this.left = left;
            this.right = right;
            this.down = down;
        }
        public Node(String data){
            this.data = data;
            this.up = null;
            this.left = null;
            this.right = null;
            this.down = null;
        }
        
    
        
    
    }

}
