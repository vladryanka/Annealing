using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static Annealing.Graph;


namespace Annealing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            tMinInp.Text = "0";
            tMaxInp.Text = "100";
            alphaInp.Text = "0,5";
        }

        double tMin = 0;
        double tMax = 0;
        double alpha = 0.99d;
        String length;
        Graph graph = new Graph();

        private async Task parseFileAsync(string filename)
        {
            
            StreamReader reader = new StreamReader(filename);
            string number = "";
            int currentVertex = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (graph.getVertex() == 0)
                {
                    graph.setVertex(Convert.ToInt32(line));
                }
                else
                {
                    List<int> matrixLine = new List<int>();
                    for (int i = 0; i < line.Length; i++)
                    {

                        while (line[i] != ' ')
                        {
                            number += line[i];
                            if (i == line.Length - 1)
                            {
                                break;
                            }
                            i++;
                        }
                        if (line[i] == ' ' || i == line.Length - 1)
                        {

                            matrixLine.Add(Convert.ToInt32(number));
                            number = "";

                        }
                    }
                    graph.setEdges(matrixLine, currentVertex);
                    currentVertex++;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            parseFileAsync(filename);
            StringBuilder sb = new StringBuilder();
            foreach (List<int> innerList in graph.getEdges())
            {
                foreach (int number in innerList)
                {
                    sb.Append(number + " ");
                }
                sb.AppendLine();
            }

            textBox1.Text = sb.ToString();
        }
        private void button2_Click(object sender, EventArgs e) {
            AnnealingClass annealing = new AnnealingClass();
            length = annealing.Annealing(tMin, tMax,alpha,length,graph);
            lengthInp.Text = length;
            wayInp.Text = annealing.getWay();

        }
        private void Form1_Load(object sender, EventArgs e) { }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tMinInp_TextChanged(object sender, EventArgs e)
        {
            tMin = Convert.ToInt32(tMinInp.Text);
        }

        private void tMaxInp_TextChanged(object sender, EventArgs e)
        {
            tMax = Convert.ToInt32(tMaxInp.Text);
        }

        private void alphaInp_TextChanged(object sender, EventArgs e)
        {
            alpha = Convert.ToDouble(alphaInp.Text);
        }
        
        
        private void lengthInp_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
