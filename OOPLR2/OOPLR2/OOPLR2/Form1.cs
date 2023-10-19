using Microsoft.VisualBasic;

namespace OOPLR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            double mass;
            double price;
            name = Interaction.InputBox("����� ����");
            mass = Convert.ToDouble(Interaction.InputBox("���� ����:"));
            price = Convert.ToDouble(Interaction.InputBox("ֳ�� �� ��:"));
            Fish fishKaras = new Fish(mass, name, price);
            fishKaras.Info();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fish fishKaras = new Fish();
            fishKaras.Info();
        }
    }
    public class Fish
    {
        public double mass;
        public string name;
        public double cost;
        public Fish()
        {
            this.name = "���� �� �������������";
        }
        public Fish(double mass, string name, double cost)
        {
            this.mass = mass;
            this.name = name;
            this.cost = cost;
        }

        public double GetFullPrice()
        {
            return mass * cost;
        }
        public string GetTypeSize()
        {
            if (mass <= 0)
            {
                return "�� �� ����";
            }
            else
                if (mass <= 10)
            {
                return "�� �������� ����";
            }
            else
            {
                return "�� ������ ����";
            }
        }
        public void Info()
        {
            MessageBox.Show($"���� ����: {this.name} �� ���� {this.mass} ������� �� ����� {this.cost} ��� �� �������.\nֳ�� ����: {GetFullPrice()} ���. \n��� ����: {GetTypeSize()}.", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}