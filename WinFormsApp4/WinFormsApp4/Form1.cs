namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        List<Pet> petsList = new List<Pet>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.petsList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                this.petsList.Add((rnd.Next() % 3) switch
                {
                    0 => Cat.Generate(),
                    1 => Dog.Generate(),
                    2 => Cow.Generate(),
                    _ => throw new InvalidOperationException("Invalid pet type")
                });
            }
            ShowInfo();

        }
        private void ShowInfo()
        {
            int dogsCount = 0;
            int catsCount = 0;
            int cowsCount = 0;

            foreach (var pet in this.petsList)
            {

                if (pet is Dog)
                {
                    dogsCount += 1;
                }
                else if (pet is Cow)
                {
                    cowsCount += 1;
                }
                else if (pet is Cat)
                {
                    catsCount += 1;
                }
            }

            txtInfo.Text = "Кошки\tСобаки\tКоровы";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", catsCount, dogsCount, cowsCount);

            queue.Text = "";
            foreach (var pet in petsList)
            {
                queue.Text += pet switch
                {
                    Dog => "\nСобака",
                    Cow => "\nКорова",
                    Cat => "\nКошка",
                    _ => ""
                };
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.petsList.Count == 0)
            {
                txtOut.Text = "Пусто Q_Q";
                return;
            }

            var pet = this.petsList[0];
            this.petsList.RemoveAt(0);

            txtOut.Text = pet.GetInfo();

            ShowInfo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void queue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
