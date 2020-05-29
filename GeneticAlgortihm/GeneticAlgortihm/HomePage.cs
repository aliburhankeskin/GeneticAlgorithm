using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GeneticAlgortihm
{
    public partial class GeneticAlgoirthm : Form
    {
        private Genetic genetic;
        public GeneticAlgoirthm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void SplineChartCreate()
        {
            this.chart1.Series.Clear();

            this.chart1.Titles.Clear();

            this.chart1.Titles.Add("POPULASYON");

            Series series = this.chart1.Series.Add("BİREYLERİN UYGUNLUK DEĞERLERİ");
            series.ChartType = SeriesChartType.Spline;

            // Grafikte Gösterirken Bireye Göre göstereceği o yüzden
            List<Person> temp = genetic.PersonList.OrderBy(c => c.Value).ToList();

            foreach (var person in temp)
            {
                series.Points.AddXY(person.Value, person.AccordanceValue);
            }
        }

        public void AlgorithmStart()
        {
            int _PopulationCount = (int)numericUpDownPopulationCount.Value;
            int _ExclusivenessCount = (int)numericUpDownExclusivenessCount.Value;
            double _CrossProbability = (double)numericUpDownCrossProbability.Value;
            double _MutationProbability = (double)numericUpDownMutationProbability.Value;
            bool _TerminationType = false;
            int _MaxValueForPerson = (int)numericUpDownMaxValueForPerson.Value;
            int _MinValueForPerson = (int)numericUpDownMinValueForPerson.Value;
            if (radioButtonOne.Checked == true)
            {
                _TerminationType = true;
                int _GenarationCount = (int)numericUpDownGenarationCount.Value;
                genetic = new Genetic(_PopulationCount, _ExclusivenessCount, _CrossProbability, _MutationProbability, _TerminationType, _MaxValueForPerson, _MinValueForPerson, _GenarationCount);
            }
            else
            {
                genetic = new Genetic(_PopulationCount, _ExclusivenessCount, _CrossProbability, _MutationProbability, _TerminationType ,_MaxValueForPerson, _MinValueForPerson );
            }

            // Algoritma Başlangıcı

            genetic.SolveProblem();

            // Seçkin Listeyi Panele Ekleme

            flowLayoutPanelExclusiveness.Controls.Clear();

            Label label;
            int i = 1;
            foreach (var person in genetic.ExclusivenessPersonList)
            {
                label = new Label { AutoSize = true };
                label.Font = new Font(label.Font.FontFamily, 15);
                label.Text = i + ". Birey : " + person.Value.ToString() + " - Uygunluk Değeri : " + person.AccordanceValue.ToString();
                i++;
                flowLayoutPanelExclusiveness.Controls.Add(label);
            }

            // Grafik oluşturma
            SplineChartCreate();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.AlgorithmStart();
        }

    }
}
