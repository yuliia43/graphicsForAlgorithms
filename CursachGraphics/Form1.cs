using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork.Methods;

namespace CursachGraphics
{
    public partial class Form1 : Form
    {
        private AlgorithmsRuntimeCounter counter;
        public Form1()
        {
            InitializeComponent();
            counter = new AlgorithmsRuntimeCounter();
            frankChart.Series[0].Name = "Frank Wolf";
            geneticChart.Series[0].Name = "Genetic";
            annealChart.Series[0].Name = "Simulated Annealing";
            avgChart.Series[0].Name = "Frank Wolf";
            avgChart.Series[1].Name = "Genetic";
            avgChart.Series[2].Name = "Simulated Annealing";
            frankChart.ChartAreas["ChartArea1"].AxisX.Title = "n";
            geneticChart.ChartAreas["ChartArea1"].AxisX.Title = "n";
            annealChart.ChartAreas["ChartArea1"].AxisX.Title = "n";
            avgChart.ChartAreas["ChartArea1"].AxisX.Title = "n";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timeButton_Click(object sender, EventArgs e)
        {
            frankChart.Series[0].Points.Clear();
            geneticChart.Series[0].Points.Clear();
            annealChart.Series[0].Points.Clear();
            avgChart.Series[0].Points.Clear();
            avgChart.Series[1].Points.Clear();
            avgChart.Series[2].Points.Clear();
            frankChart.Titles.Clear();
            geneticChart.Titles.Clear();
            annealChart.Titles.Clear();
            avgChart.Titles.Clear();
            for (int i = 2; i < numOfIterations.Value; i++)
            {
                CounterResult res = counter.CountTime(10, i,
                    decimal.ToInt32(sumIntervalStart.Value), decimal.ToInt32(sumIntervalEnd.Value),
                    decimal.ToInt32(amountIntervalStart.Value), decimal.ToInt32(amountIntervalEnd.Value));
                frankChart.Series[0].Points.AddXY(i, res.WolfAvg);
                geneticChart.Series[0].Points.AddXY(i, res.GeneticAvg);
                annealChart.Series[0].Points.AddXY(i, res.AnnealAvg);
                avgChart.Series[0].Points.AddXY(i, res.WolfAvg);
                avgChart.Series[1].Points.AddXY(i, res.GeneticAvg);
                avgChart.Series[2].Points.AddXY(i, res.AnnealAvg);

            }

            frankChart.ChartAreas["ChartArea1"].AxisY.Title = "Execution time";
            geneticChart.ChartAreas["ChartArea1"].AxisY.Title = "Execution time";
            annealChart.ChartAreas["ChartArea1"].AxisY.Title = "Execution time";
            avgChart.ChartAreas["ChartArea1"].AxisY.Title = "Execution time";
            frankChart.Titles.Add("Залежність часу виконання програми від кількості продуктів");
            geneticChart.Titles.Add("Залежність часу виконання програми від кількості продуктів");
            annealChart.Titles.Add("Залежність часу виконання програми від кількості продуктів");
            avgChart.Titles.Add("Залежність часу виконання програми від кількості продуктів");
        }

        private void accuracyButton_Click(object sender, EventArgs e)
        {
            frankChart.Series[0].Points.Clear();
            geneticChart.Series[0].Points.Clear();
            annealChart.Series[0].Points.Clear();
            avgChart.Series[0].Points.Clear();
            avgChart.Series[1].Points.Clear();
            avgChart.Series[2].Points.Clear();
            frankChart.Titles.Clear();
            geneticChart.Titles.Clear();
            annealChart.Titles.Clear();
            avgChart.Titles.Clear();
            for (int i = 2; i < numOfIterations.Value; i++)
            {
                CounterResult res = counter.CountTime(10, i,
                    decimal.ToInt32(sumIntervalStart.Value), decimal.ToInt32(sumIntervalEnd.Value),
                    decimal.ToInt32(amountIntervalStart.Value), decimal.ToInt32(amountIntervalEnd.Value));
                frankChart.Series[0].Points.AddXY(i, res.FrankBetter / 10);
                geneticChart.Series[0].Points.AddXY(i, res.GeneticBetter / 10);
                annealChart.Series[0].Points.AddXY(i, res.AnnealBetter / 10);
                avgChart.Series[0].Points.AddXY(i, res.FrankBetter / 10);
                avgChart.Series[1].Points.AddXY(i, res.GeneticBetter / 10);
                avgChart.Series[2].Points.AddXY(i, res.AnnealBetter / 10);
            }
            frankChart.ChartAreas["ChartArea1"].AxisY.Title = "% of better solutions";
            geneticChart.ChartAreas["ChartArea1"].AxisY.Title = "% of better solutions";
            annealChart.ChartAreas["ChartArea1"].AxisY.Title = "% of better solutions";
            avgChart.ChartAreas["ChartArea1"].AxisY.Title = "% of better solutions";
            frankChart.Titles.Add("Залежність точності від кількості продуктів");
            geneticChart.Titles.Add("Залежність точності від кількості продуктів");
            annealChart.Titles.Add("Залежність точності від кількості продуктів");
            avgChart.Titles.Add("Залежність точності від кількості продуктів");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
