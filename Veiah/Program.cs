using System;
using System.Security.Cryptography.X509Certificates;

namespace Veiah {
    public class Program {
        public static void Main() {

            char pos1 = '1', pos2 = '2', pos3 = '3', pos4 = '4', pos5 = '5', pos6 = '6', pos7 = '7', pos8 = '8', pos9 = '9',
                 jogador = 'X', vitoria = 'n', avanca = 's';
            int numJogadas = 0;
            do {
                Console.Clear();
                Console.WriteLine("      ║     ║");
                Console.WriteLine($"   {pos1}  ║  {pos2}  ║  {pos3}");
                Console.WriteLine("      ║     ║");
                Console.WriteLine(" ═════╬═════╬═════");
                Console.WriteLine("      ║     ║");
                Console.WriteLine($"   {pos4}  ║  {pos5}  ║  {pos6}");
                Console.WriteLine("      ║     ║");
                Console.WriteLine(" ═════╬═════╬═════");
                Console.WriteLine("      ║     ║");
                Console.WriteLine($"   {pos7}  ║  {pos8}  ║  {pos9}");
                Console.WriteLine("      ║     ║");
                Console.WriteLine();
                if (avanca == 'n') {
                    Console.Write("Escolha um número válido! "); avanca = 's'; Console.ReadKey();
                    if (jogador == 'X') jogador = 'O'; else jogador = 'X'; // repete o jogador
                }
                else {
                    if (vitoria == 'n' && numJogadas == 9) { Console.Write("Deu veiah!"); Console.WriteLine(); break; }
                    if (vitoria == 's') { Console.Write($"O jogador [ {jogador} ] venceu!"); Console.WriteLine(); break; }
                    if (jogador == 'X') jogador = 'O'; else jogador = 'X'; // troca o jogador a cada rodada
                    Console.Write($"Digite o número da posição! Jogador [ {jogador} ] ");
                    ConsoleKeyInfo pLida = Console.ReadKey(); // valida tecla e posição
                    if ((pLida.Key == ConsoleKey.D1 || pLida.Key == ConsoleKey.NumPad1) && pos1 == '1') { pos1 = jogador; numJogadas++; }
                    else if ((pLida.Key == ConsoleKey.D2 || pLida.Key == ConsoleKey.NumPad2) && pos2 == '2') { pos2 = jogador; numJogadas++; }
                    else if ((pLida.Key == ConsoleKey.D3 || pLida.Key == ConsoleKey.NumPad3) && pos3 == '3') { pos3 = jogador; numJogadas++; }
                    else if ((pLida.Key == ConsoleKey.D4 || pLida.Key == ConsoleKey.NumPad4) && pos4 == '4') { pos4 = jogador; numJogadas++; }
                    else if ((pLida.Key == ConsoleKey.D5 || pLida.Key == ConsoleKey.NumPad5) && pos5 == '5') { pos5 = jogador; numJogadas++; }
                    else if ((pLida.Key == ConsoleKey.D6 || pLida.Key == ConsoleKey.NumPad6) && pos6 == '6') { pos6 = jogador; numJogadas++; }
                    else if ((pLida.Key == ConsoleKey.D7 || pLida.Key == ConsoleKey.NumPad7) && pos7 == '7') { pos7 = jogador; numJogadas++; }
                    else if ((pLida.Key == ConsoleKey.D8 || pLida.Key == ConsoleKey.NumPad8) && pos8 == '8') { pos8 = jogador; numJogadas++; }
                    else if ((pLida.Key == ConsoleKey.D9 || pLida.Key == ConsoleKey.NumPad9) && pos9 == '9') { pos9 = jogador; numJogadas++; }
                    else avanca = 'n';
                } // valida vitoria
                if (pos1 == pos2 && pos2 == pos3) vitoria = 's';
                if (pos4 == pos5 && pos5 == pos6) vitoria = 's';
                if (pos7 == pos8 && pos8 == pos9) vitoria = 's';
                if (pos1 == pos4 && pos4 == pos7) vitoria = 's';
                if (pos2 == pos5 && pos5 == pos8) vitoria = 's';
                if (pos3 == pos6 && pos6 == pos9) vitoria = 's';
                if (pos1 == pos5 && pos5 == pos9) vitoria = 's';
                if (pos7 == pos5 && pos5 == pos3) vitoria = 's';
            } while (true);
        }
    }
}