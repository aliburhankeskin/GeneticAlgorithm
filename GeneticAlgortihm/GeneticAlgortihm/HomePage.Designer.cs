namespace GeneticAlgortihm
{
    partial class GeneticAlgoirthm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop = new System.Windows.Forms.Panel();
            this.groupBoxSeckin = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelExclusiveness = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxValue = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTwo = new System.Windows.Forms.RadioButton();
            this.radioButtonOne = new System.Windows.Forms.RadioButton();
            this.numericUpDownGenarationCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownExclusivenessCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownMutationProbability = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownCrossProbability = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownPopulationCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownMaxValueForPerson = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownMinValueForPerson = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.groupBoxSeckin.SuspendLayout();
            this.groupBoxValue.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenarationCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExclusivenessCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMutationProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCrossProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopulationCount)).BeginInit();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxValueForPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinValueForPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.groupBoxSeckin);
            this.panelTop.Controls.Add(this.groupBoxValue);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1360, 387);
            this.panelTop.TabIndex = 0;
            // 
            // groupBoxSeckin
            // 
            this.groupBoxSeckin.Controls.Add(this.flowLayoutPanelExclusiveness);
            this.groupBoxSeckin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSeckin.Location = new System.Drawing.Point(709, 0);
            this.groupBoxSeckin.Name = "groupBoxSeckin";
            this.groupBoxSeckin.Size = new System.Drawing.Size(651, 387);
            this.groupBoxSeckin.TabIndex = 2;
            this.groupBoxSeckin.TabStop = false;
            this.groupBoxSeckin.Text = "Seçkin Liste";
            // 
            // flowLayoutPanelExclusiveness
            // 
            this.flowLayoutPanelExclusiveness.AutoScroll = true;
            this.flowLayoutPanelExclusiveness.AutoSize = true;
            this.flowLayoutPanelExclusiveness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelExclusiveness.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelExclusiveness.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanelExclusiveness.Name = "flowLayoutPanelExclusiveness";
            this.flowLayoutPanelExclusiveness.Size = new System.Drawing.Size(645, 366);
            this.flowLayoutPanelExclusiveness.TabIndex = 0;
            // 
            // groupBoxValue
            // 
            this.groupBoxValue.Controls.Add(this.groupBox2);
            this.groupBoxValue.Controls.Add(this.groupBox1);
            this.groupBoxValue.Controls.Add(this.numericUpDownExclusivenessCount);
            this.groupBoxValue.Controls.Add(this.label4);
            this.groupBoxValue.Controls.Add(this.numericUpDownMutationProbability);
            this.groupBoxValue.Controls.Add(this.label3);
            this.groupBoxValue.Controls.Add(this.numericUpDownCrossProbability);
            this.groupBoxValue.Controls.Add(this.label2);
            this.groupBoxValue.Controls.Add(this.numericUpDownPopulationCount);
            this.groupBoxValue.Controls.Add(this.label1);
            this.groupBoxValue.Controls.Add(this.buttonStart);
            this.groupBoxValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxValue.Location = new System.Drawing.Point(0, 0);
            this.groupBoxValue.Name = "groupBoxValue";
            this.groupBoxValue.Size = new System.Drawing.Size(709, 387);
            this.groupBoxValue.TabIndex = 1;
            this.groupBoxValue.TabStop = false;
            this.groupBoxValue.Text = "Başlangıç Değerleri";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTwo);
            this.groupBox1.Controls.Add(this.radioButtonOne);
            this.groupBox1.Controls.Add(this.numericUpDownGenarationCount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(343, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 191);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sonlanma Ölçütü";
            // 
            // radioButtonTwo
            // 
            this.radioButtonTwo.AutoSize = true;
            this.radioButtonTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonTwo.Location = new System.Drawing.Point(159, 56);
            this.radioButtonTwo.Name = "radioButtonTwo";
            this.radioButtonTwo.Size = new System.Drawing.Size(177, 29);
            this.radioButtonTwo.TabIndex = 12;
            this.radioButtonTwo.Text = "Uygunluk Değeri";
            this.radioButtonTwo.UseVisualStyleBackColor = true;
            // 
            // radioButtonOne
            // 
            this.radioButtonOne.AutoSize = true;
            this.radioButtonOne.Checked = true;
            this.radioButtonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonOne.Location = new System.Drawing.Point(25, 56);
            this.radioButtonOne.Name = "radioButtonOne";
            this.radioButtonOne.Size = new System.Drawing.Size(113, 29);
            this.radioButtonOne.TabIndex = 11;
            this.radioButtonOne.TabStop = true;
            this.radioButtonOne.Text = "İterasyon";
            this.radioButtonOne.UseVisualStyleBackColor = true;
            // 
            // numericUpDownGenarationCount
            // 
            this.numericUpDownGenarationCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownGenarationCount.Location = new System.Drawing.Point(195, 120);
            this.numericUpDownGenarationCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownGenarationCount.Name = "numericUpDownGenarationCount";
            this.numericUpDownGenarationCount.Size = new System.Drawing.Size(120, 30);
            this.numericUpDownGenarationCount.TabIndex = 10;
            this.numericUpDownGenarationCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jenarason Sayısı:";
            // 
            // numericUpDownExclusivenessCount
            // 
            this.numericUpDownExclusivenessCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownExclusivenessCount.Location = new System.Drawing.Point(208, 189);
            this.numericUpDownExclusivenessCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownExclusivenessCount.Name = "numericUpDownExclusivenessCount";
            this.numericUpDownExclusivenessCount.Size = new System.Drawing.Size(120, 30);
            this.numericUpDownExclusivenessCount.TabIndex = 8;
            this.numericUpDownExclusivenessCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seçkinlik :";
            // 
            // numericUpDownMutationProbability
            // 
            this.numericUpDownMutationProbability.DecimalPlaces = 4;
            this.numericUpDownMutationProbability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownMutationProbability.Increment = new decimal(new int[] {
            5,
            0,
            0,
            262144});
            this.numericUpDownMutationProbability.Location = new System.Drawing.Point(208, 138);
            this.numericUpDownMutationProbability.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMutationProbability.Name = "numericUpDownMutationProbability";
            this.numericUpDownMutationProbability.Size = new System.Drawing.Size(120, 30);
            this.numericUpDownMutationProbability.TabIndex = 6;
            this.numericUpDownMutationProbability.Value = new decimal(new int[] {
            10,
            0,
            0,
            262144});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mutasyon Oranı : ";
            // 
            // numericUpDownCrossProbability
            // 
            this.numericUpDownCrossProbability.DecimalPlaces = 2;
            this.numericUpDownCrossProbability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownCrossProbability.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownCrossProbability.Location = new System.Drawing.Point(208, 86);
            this.numericUpDownCrossProbability.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCrossProbability.Name = "numericUpDownCrossProbability";
            this.numericUpDownCrossProbability.Size = new System.Drawing.Size(120, 30);
            this.numericUpDownCrossProbability.TabIndex = 4;
            this.numericUpDownCrossProbability.Value = new decimal(new int[] {
            60,
            0,
            0,
            131072});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Çaprazlama Oranı :";
            // 
            // numericUpDownPopulationCount
            // 
            this.numericUpDownPopulationCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownPopulationCount.Location = new System.Drawing.Point(208, 37);
            this.numericUpDownPopulationCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownPopulationCount.Name = "numericUpDownPopulationCount";
            this.numericUpDownPopulationCount.Size = new System.Drawing.Size(120, 30);
            this.numericUpDownPopulationCount.TabIndex = 2;
            this.numericUpDownPopulationCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Populasyon boyutu :";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Maroon;
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(3, 327);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(703, 57);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "BAŞLA";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.chart1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 387);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1360, 441);
            this.panelBottom.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(1360, 441);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.numericUpDownMinValueForPerson);
            this.groupBox2.Controls.Add(this.numericUpDownMaxValueForPerson);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(17, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 81);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekstra Bilgi";
            // 
            // numericUpDownMaxValueForPerson
            // 
            this.numericUpDownMaxValueForPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownMaxValueForPerson.Location = new System.Drawing.Point(559, 34);
            this.numericUpDownMaxValueForPerson.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownMaxValueForPerson.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownMaxValueForPerson.Name = "numericUpDownMaxValueForPerson";
            this.numericUpDownMaxValueForPerson.Size = new System.Drawing.Size(87, 30);
            this.numericUpDownMaxValueForPerson.TabIndex = 10;
            this.numericUpDownMaxValueForPerson.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(18, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(375, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Bireylerin Değer Aralığı (Denklemdeki Xi) :";
            // 
            // numericUpDownMinValueForPerson
            // 
            this.numericUpDownMinValueForPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownMinValueForPerson.Location = new System.Drawing.Point(439, 34);
            this.numericUpDownMinValueForPerson.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownMinValueForPerson.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownMinValueForPerson.Name = "numericUpDownMinValueForPerson";
            this.numericUpDownMinValueForPerson.Size = new System.Drawing.Size(87, 30);
            this.numericUpDownMinValueForPerson.TabIndex = 11;
            this.numericUpDownMinValueForPerson.Value = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(532, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "-";
            // 
            // GeneticAlgoirthm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 828);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GeneticAlgoirthm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genetik Algoritma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            this.groupBoxSeckin.ResumeLayout(false);
            this.groupBoxSeckin.PerformLayout();
            this.groupBoxValue.ResumeLayout(false);
            this.groupBoxValue.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenarationCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExclusivenessCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMutationProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCrossProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopulationCount)).EndInit();
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxValueForPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinValueForPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.GroupBox groupBoxValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonTwo;
        private System.Windows.Forms.RadioButton radioButtonOne;
        private System.Windows.Forms.NumericUpDown numericUpDownGenarationCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownExclusivenessCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownMutationProbability;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownCrossProbability;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownPopulationCount;
        private System.Windows.Forms.GroupBox groupBoxSeckin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelExclusiveness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownMinValueForPerson;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxValueForPerson;
        private System.Windows.Forms.Label label6;
    }
}

