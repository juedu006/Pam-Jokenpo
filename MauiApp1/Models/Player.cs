using System;

namespace MauiApp1.Models
{
    internal class Player
    {
        public string Nome { get; set; }
        public string Pontuacao { get; set; }
        public Choice Choice { get; set; }

        public void MakeChoice()
        {
            Choice = (Choice)new Random().Next(3);
        }
    }
}