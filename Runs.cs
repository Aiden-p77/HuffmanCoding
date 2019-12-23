using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.IO;

namespace Huffman
{
    class Runs
    {
        public List<huffmanNode> inputkhiyanche(string str)
        {
            List<huffmanNode> nodeList = new List<huffmanNode>();
            try
            {                
                char[] charArr = str.ToCharArray();
                for (int i = 0; i < charArr.Length; i++)
                {
                    if (nodeList.Exists(x => x.symbol == charArr[i].ToString()))
                        nodeList[nodeList.FindIndex(y => y.symbol == charArr[i].ToString())].frequencyIncrease();
                    else
                        nodeList.Add(new huffmanNode(charArr[i].ToString()));
                }
                nodeList.Sort();
                return nodeList;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public void getTree(List<huffmanNode> nodeList)
        {
            while (nodeList.Count > 1)  
            {
                huffmanNode node1 = nodeList[0]; 
                nodeList.RemoveAt(0);            
                huffmanNode node2 = nodeList[0]; 
                nodeList.RemoveAt(0);            
                nodeList.Add(new huffmanNode(node1, node2));
                nodeList.Sort();
            }
        }


        
        public void setCode(string code, huffmanNode Nodes)
        {
            if (Nodes == null)
                return;
            if (Nodes.leftTree == null && Nodes.rightTree == null)
            {
                Nodes.code = code;
                return;
            }
            setCode(code + "0", Nodes.leftTree);
            setCode(code + "1", Nodes.rightTree);
        }


        
     /*   public void PrintTree(int level, huffmanNode node)
        {
            if (node == null)
                return;
            for (int i = 0; i < level; i++)
            {
                Console.Write("\t");
            }
            Console.Write("[" + node.symbol + "]");
            Console.WriteLine("(" + node.code + ")");
            PrintTree(level + 1, node.rightTree);
            PrintTree(level + 1, node.leftTree);
        } */


        
        public void PrintCode(List<huffmanNode> nodeList,RichTextBox rich)
        {
            foreach (var item in nodeList)
                //Console.WriteLine("Symbol :{"+item.symbol+"}   -Frequency :{"+item.frequency+"}");
                rich.AppendText(Environment.NewLine + 
                    "Symbol :{" + item.symbol + "} -- Frequency :{" + item.frequency + "}");
        }


        
        public void PrintLeaf(huffmanNode nodeList,RichTextBox rich)
        {
            if (nodeList == null)
                return;
            if (nodeList.leftTree == null && nodeList.rightTree == null)
            {
                //Console.WriteLine("Symbol :{" + nodeList.symbol + "}   -Code :{" + nodeList.code + "}");
                rich.AppendText(Environment.NewLine + 
                    "Symbol :{" + nodeList.symbol + "} -- Code :{" + nodeList.code + "}");
                return;
            }
            PrintLeaf(nodeList.leftTree,rich);
            PrintLeaf(nodeList.rightTree,rich);
        }
    }
}
