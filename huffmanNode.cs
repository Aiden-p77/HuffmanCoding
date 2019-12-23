using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    class huffmanNode : IComparable<huffmanNode>
    {
        public string symbol;   
        public int frequency;          
        public string code;            
        public huffmanNode parentNode; 
        public huffmanNode leftTree;   
        public huffmanNode rightTree;  
        public bool isLeaf;            


        public huffmanNode(string value)    
        {
            symbol = value;     
            frequency = 1;     

            rightTree = leftTree = parentNode = null;       

            code = "";          
            isLeaf = true;      
        }


        public huffmanNode(huffmanNode node1, huffmanNode node2)
        {
            
            code = "";
            isLeaf = false;
            parentNode = null;

            
            if (node1.frequency >= node2.frequency)
            {
                rightTree = node1;
                leftTree = node2;
                rightTree.parentNode = leftTree.parentNode = this;    
                symbol = node1.symbol + node2.symbol;
                frequency = node1.frequency + node2.frequency;
            }
            else if (node1.frequency < node2.frequency)
            {
                rightTree = node2;
                leftTree = node1;
                leftTree.parentNode = rightTree.parentNode = this;     
                symbol = node2.symbol + node1.symbol;
                frequency = node2.frequency + node1.frequency;
            }
        }


        public int CompareTo(huffmanNode otherNode) 
        {
            return this.frequency.CompareTo(otherNode.frequency);
        }


        public void frequencyIncrease()             
        {
            frequency++;
        }
    }
}
