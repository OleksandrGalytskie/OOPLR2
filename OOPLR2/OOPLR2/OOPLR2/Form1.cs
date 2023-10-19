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
            name = Interaction.InputBox("назва риби");
            mass = Convert.ToDouble(Interaction.InputBox("Маса риби:"));
            price = Convert.ToDouble(Interaction.InputBox("Ціна за кг:"));
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
            this.name = "Риба за замовчуванням";
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
                return "Це не риба";
            }
            else
                if (mass <= 10)
            {
                return "Це маленька риба";
            }
            else
            {
                return "Це велика риба";
            }
        }
        public void Info()
        {
            MessageBox.Show($"Ваша риба: {this.name} має вагу {this.mass} кілограм та коштує {this.cost} грн за кілограм.\nЦіна риби: {GetFullPrice()} грн. \nТип риби: {GetTypeSize()}.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}