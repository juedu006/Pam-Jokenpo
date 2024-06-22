using CommunityToolkit.Mvvm.ComponentModel;
using MauiApp1.Models;
using System;

namespace MauiApp1.ViewModels
{
    internal partial class GameViewModel : ObservableObject
    {
        [ObservableProperty]
        private string nome;

        [ObservableProperty]
        private string pontuacao;

        [ObservableProperty]
        private string imagemJogador;

        [ObservableProperty]
        private string imagemInimigo;

        [ObservableProperty]
        private string resultado;

        [ObservableProperty]
        private Choice escolhaJogador;

        private Player jogador;

        public GameViewModel()
        {
            jogador = new Player();
        }

        public void Jogar()
        {
            Player inimigo = new Player();
            inimigo.MakeChoice();
            jogador.Choice = EscolhaJogador;

            if (inimigo.Choice == jogador.Choice)
            {
                Resultado = "Empatou!";
            }
            else
            {
                Resultado = DeterminarVencedor(jogador.Choice, inimigo.Choice);
            }
        }

        private string DeterminarVencedor(Choice escolhaJogador, Choice escolhaInimigo)
        {
            // Implementa a lógica para determinar o vencedor com base na escolha do jogador e do inimigo
            // Esta é apenas uma implementação de exemplo
            if ((escolhaJogador == Choice.Rock && escolhaInimigo == Choice.Scissors) ||
                (escolhaJogador == Choice.Scissors && escolhaInimigo == Choice.Paper) ||
                (escolhaJogador == Choice.Paper && escolhaInimigo == Choice.Rock))
            {
                return "Jogador venceu!";
            }
            else
            {
                return "Inimigo venceu!";
            }
        }
    }
}