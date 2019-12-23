using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Huffman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richOutput.Text= "";
            if (textInput.Text != "")
            {
                List<huffmanNode> nodes = new List<huffmanNode>();
                Runs r = new Runs();
                nodes = r.inputkhiyanche(textInput.Text);
                richOutput.AppendText("***Symbols--------Frequency***");
                r.PrintCode(nodes,richOutput);
                r.getTree(nodes);
                r.setCode("", nodes[0]);
                //pMethods.PrintTree(0, nodeList[0]);
                richOutput.AppendText(Environment.NewLine + Environment.NewLine + "**Huffman code**");
                r.PrintLeaf(nodes[0],richOutput);
            }
            else
                MessageBox.Show("ERORR----Enter string");
        }
    }
}
