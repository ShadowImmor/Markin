using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сalculator_calor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Activity_comboBox.SelectedIndex = 2;
            Male_radioButton.Checked = true;
            calculator  = new Calculator();
            imt_form = new IMT();
            exercise_form = new Exercise();
        }

        private Calculator calculator;
        private IMT imt_form;
        private Exercise exercise_form;


        class Calculator
        {
            double weight_2, height_2, countCalor;
            int year, iMT;
            string activ, gender, worldHO;
            public void Calculate_button_Click(Form1 form1)
            {
                height_2 = (double)form1.Height_numericUpDown.Value;
                weight_2 = (double)form1.Weight_numericUpDown.Value;
                year = (int)form1.Year_numericUpDown.Value;
                countCalor = 10 * weight_2 + 6.25 * height_2 - 5 * year;
                if (form1.Male_radioButton.Checked == true)
                {
                    countCalor += 5;
                    gender = "мужчины";
                }
                else
                {
                    countCalor -= 161;
                    gender = "женщины";
                }
                switch (form1.Activity_comboBox.SelectedIndex)
                {
                    case 0:
                        {
                            countCalor *= 1.2;
                            activ = "минимальной";
                            break;
                        }
                    case 1:
                        {
                            countCalor *= 1.375;
                            activ = "легкой";
                            break;
                        }
                    case 2:
                        {
                            countCalor *= 1.55;
                            activ = "средней";
                            break;
                        }
                    case 3:
                        {
                            countCalor *= 1.7;
                            activ = "высокой";
                            break;
                        }
                    case 4:
                        {
                            countCalor *= 1.9;
                            activ = "экстремальной";
                            break;
                        }
                }
                form1.Resultat_richTextBox.Text = "Для сохранения веса суточная потебность в калориях " + gender + " возрастом " + year + " лет и весом " + weight_2 + " кг., при росте " + height_2 + " см. и " + activ + " активности:" + (int)countCalor + "ккал\n";

                iMT = (int)(weight_2 / (height_2 / 100 * height_2 / 100));
                form1.Resultat_richTextBox.Text += "Для роста " + height_2  + " см., при весе " + weight_2 + " кг.индекс массы тела равен:" + iMT + "\n";
                if (iMT < 16)
                    worldHO = "выраженный дефицит массы тела";
                else if (iMT < 18.5)
                    worldHO = "недостаточную массу тела";
                else if (iMT < 24.99)
                    worldHO = ", что масса тела в норме";
                else if (iMT < 30)
                    worldHO = "избыточную массу тела";
                else if (iMT < 35)
                    worldHO = "ожирение";
                else if (iMT < 40)
                    worldHO = "резкое ожирение";
                else worldHO = "очень резкое ожирение";
                form1.Resultat_richTextBox.Text += "Согласно рекомендациям ВОЗ такой ИМТ означает " + worldHO + "\n";

                form1.Resultat_richTextBox.Text += "Для набора веса рекомендуется потребление " + (int)(countCalor * 1.2) + " ккал в день, а для похудения стоит употреблять порядка " + (int)(countCalor * 0.8) + " ккал в день" + "\n";
            }
        }
        private void Male_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(Male_radioButton.Checked == true)
            {
                Height_numericUpDown.Value = 180;
                Weight_numericUpDown.Value = 80;
                Year_numericUpDown.Value = 30;
                Activity_comboBox.SelectedIndex = 2;
            }
        }

        private void Woman_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Woman_radioButton.Checked == true)
            {
                Height_numericUpDown.Value = 170;
                Weight_numericUpDown.Value = 60;
                Year_numericUpDown.Value = 30;
                Activity_comboBox.SelectedIndex = 2;
            }
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            if (Male_radioButton.Checked == true)
            {
                Height_numericUpDown.Value = 180;
                Weight_numericUpDown.Value = 80;
            }
            else
            {
                Height_numericUpDown.Value = 170;
                Weight_numericUpDown.Value = 60;
            }
            Year_numericUpDown.Value = 30;
            Activity_comboBox.SelectedIndex = 2;
            Resultat_richTextBox.Clear();
        }

        private void таблицаИМТПоВОЗToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            imt_form.Show();
        }

        private void нагрузкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exercise_form.Show();
        }

        private void Calculate_button_Click(object sender, EventArgs e)
        {
            calculator.Calculate_button_Click(this);
        }
    }
}
