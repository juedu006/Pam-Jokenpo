
namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            picker.SelectedIndex = 0;
        }

        int pontP1 = 0;
        int pontP2 = 0;
 
        private void Start_Clicked(object sender, EventArgs e)
        {
            player.Text = valueEntry.Text;
            Random rnd = new Random();

            int sortP2 = rnd.Next(0, 3);

            string selectedItem = picker.SelectedItem.ToString();

            // 0 = pedra
            // 1 = papel
            // 2 = tesoura

            switch (selectedItem)
            {
                case "Pedra":
                    ImgPlayer1.Source = "pedra-removebg.png";
                    if (sortP2 == 2)
                    {
                        ImgPlayer2.Source = "tesoura-removebg.png";
                        visorResult.Text = "Você ganhou!!!";
                        pontP1++;
                        pontuacao1.Text = pontP1.ToString();
                    }
                    else if (sortP2 == 1)
                    {
                        ImgPlayer2.Source = "papel-removebg.png";
                        visorResult.Text = "Você perdeu :(";
                        pontP2++;
                        pontuacao2.Text = pontP2.ToString();
                    }
                    else
                    {
                        ImgPlayer2.Source = "pedra-removebg.png";
                        visorResult.Text = "Empate!";
                    }
                    break;
                case "Papel":
                    ImgPlayer1.Source = "papel-removebg.png";
                    if (sortP2 == 2)
                    {
                        ImgPlayer2.Source = "tesoura-removebg.png";
                        visorResult.Text = "Você perdeu :(";
                        pontP2++;
                        pontuacao2.Text = pontP2.ToString();
                    }
                    else if (sortP2 == 1)
                    {
                        ImgPlayer2.Source = "papel-removebg.png";
                        visorResult.Text = "Empate!";
                    }
                    else
                    {
                        ImgPlayer2.Source = "pedra-removebg.png";
                        visorResult.Text = "Você ganhou!!!";
                        pontP1++;
                        pontuacao1.Text = pontP1.ToString();
                    }
                    break;
                case "Tesoura":
                    ImgPlayer1.Source = "tesoura-removebg.png";
                    if (sortP2 == 2)
                    {
                        ImgPlayer2.Source = "tesoura-removebg.png";
                        visorResult.Text = "Empate!";
                    }
                    else if (sortP2 == 1)
                    {
                        ImgPlayer2.Source = "papel-removebg.png";
                        visorResult.Text = "Você ganhou!!!";
                        pontP1++;
                        pontuacao1.Text = pontP1.ToString();
                    }
                    else
                    {
                        ImgPlayer2.Source = "pedra-removebg.png";
                        visorResult.Text = "Você perdeu :(";
                        pontP2++;
                        pontuacao2.Text = pontP2.ToString();
                    }
                    break;
            }   
        }
        private void Reset_Clicked(object sender, EventArgs e)
        {
            pontP1 = 0;
            pontuacao1.Text = pontP1.ToString();
            pontP2 = 0;
            pontuacao2.Text = pontP1.ToString();
            visorResult.Text = "";
        }
    }
}