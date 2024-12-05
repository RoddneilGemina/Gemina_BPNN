
using Backprop;

namespace Gemina_BPNN

{
    public partial class Form1 : Form
    {
        NeuralNet nn1;
        NeuralNet nn2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nn1 = new NeuralNet(2, 1000, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 1000; x++)
            {
                nn1.setInputs(0, 0.0);
                nn1.setInputs(1, 0.0);
                nn1.setDesiredOutput(0, 0.0);
                nn1.learn();

                nn1.setInputs(0, 0.0);
                nn1.setInputs(1, 1.0);
                nn1.setDesiredOutput(0, 1.0);
                nn1.learn();

                nn1.setInputs(0, 1.0);
                nn1.setInputs(1, 1.0);
                nn1.setDesiredOutput(0, 1.0);
                nn1.learn();

                nn1.setInputs(0, 1.0);
                nn1.setInputs(1, 0.0);
                nn1.setDesiredOutput(0, 1.0);
                nn1.learn();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nn1.setInputs(0, Convert.ToDouble(textBox1.Text));
            nn1.setInputs(1, Convert.ToDouble(textBox2.Text));
            nn1.run();
            textBox3.Text = "" + nn1.getOuputData(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nn2 = new NeuralNet(4, 4, 1);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 10000; x++)
            {
                nn2.setInputs(0, 0.0);
                nn2.setInputs(1, 0.0);
                nn2.setInputs(2, 0.0);
                nn2.setInputs(3, 0.0);
                nn2.setDesiredOutput(0, 0.0);
                nn2.learn();

                nn2.setInputs(0, 0.0);
                nn2.setInputs(1, 0.0);
                nn2.setInputs(2, 0.0);
                nn2.setInputs(3, 1.0);
                nn2.setDesiredOutput(0, 0.0);
                nn2.learn();

                nn2.setInputs(0, 0.0);
                nn2.setInputs(1, 0.0);
                nn2.setInputs(2, 1.0);
                nn2.setInputs(3, 1.0);
                nn2.setDesiredOutput(0, 0.0);
                nn2.learn();

                nn2.setInputs(0, 0.0);
                nn2.setInputs(1, 1.0);
                nn2.setInputs(2, 1.0);
                nn2.setInputs(3, 1.0);
                nn2.setDesiredOutput(0, 0.0);
                nn2.learn();

                nn2.setInputs(0, 1.0);
                nn2.setInputs(1, 1.0);
                nn2.setInputs(2, 1.0);
                nn2.setInputs(3, 1.0);
                nn2.setDesiredOutput(0, 1.0);
                nn2.learn();

                nn2.setInputs(0, 1.0);
                nn2.setInputs(1, 0.0);
                nn2.setInputs(2, 0.0);
                nn2.setInputs(3, 0.0);
                nn2.setDesiredOutput(0, 0.0);
                nn2.learn();

                nn2.setInputs(0, 1.0);
                nn2.setInputs(1, 1.0);
                nn2.setInputs(2, 0.0);
                nn2.setInputs(3, 0.0);
                nn2.setDesiredOutput(0, 0.0);
                nn2.learn();

                nn2.setInputs(0, 1.0);
                nn2.setInputs(1, 1.0);
                nn2.setInputs(2, 1.0);
                nn2.setInputs(3, 0.0);
                nn2.setDesiredOutput(0, 0.0);
                nn2.learn();

                nn2.setInputs(0, 1.0);
                nn2.setInputs(1, 1.0);
                nn2.setInputs(2, 0.0);
                nn2.setInputs(3, 1.0);
                nn2.setDesiredOutput(0, 0.0);
                nn2.learn();

                nn2.setInputs(0, 1.0);
                nn2.setInputs(1, 0.0);
                nn2.setInputs(2, 1.0);
                nn2.setInputs(3, 1.0);
                nn2.setDesiredOutput(0, 0.0);
                nn2.learn();

                nn2.setInputs(0, 1.0);
                nn2.setInputs(1, 0.0);
                nn2.setInputs(2, 1.0);
                nn2.setInputs(3, 0.0);
                nn2.setDesiredOutput(0, 0.0);
                nn2.learn();

                nn2.setInputs(0, 0.0);
                nn2.setInputs(1, 1.0);
                nn2.setInputs(2, 0.0);
                nn2.setInputs(3, 1.0);
                nn2.setDesiredOutput(0, 0.0);
                nn2.learn();

                nn2.setInputs(0, 1.0);
                nn2.setInputs(1, 0.0);
                nn2.setInputs(2, 0.0);
                nn2.setInputs(3, 1.0);
                nn2.setDesiredOutput(0, 0.0);
                nn2.learn();

                nn2.setInputs(0, 0.0);
                nn2.setInputs(1, 1.0);
                nn2.setInputs(2, 1.0);
                nn2.setInputs(3, 0.0);
                nn2.setDesiredOutput(0, 0.0);
                nn2.learn();

                nn2.setInputs(0, 0.0);
                nn2.setInputs(1, 0.0);
                nn2.setInputs(2, 1.0);
                nn2.setInputs(3, 0.0);
                nn2.setDesiredOutput(0, 0.0);
                nn2.learn();

                nn2.setInputs(0, 0.0);
                nn2.setInputs(1, 1.0);
                nn2.setInputs(2, 0.0);
                nn2.setInputs(3, 0.0);
                nn2.setDesiredOutput(0, 0.0);
                nn2.learn();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            nn2.setInputs(0, Convert.ToDouble(textBox4.Text));
            nn2.setInputs(1, Convert.ToDouble(textBox5.Text));
            nn2.setInputs(2, Convert.ToDouble(textBox6.Text));
            nn2.setInputs(3, Convert.ToDouble(textBox7.Text));
            nn2.run();
            textBox8.Text = "" + nn2.getOuputData(0);
        }
    }
}
