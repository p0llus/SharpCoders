using System;
using System.Security.Cryptography.X509Certificates;

namespace ByteBank
{
    public class Program
    {
        private static char lerNovamente = 'n';
        public static string LerValidaNumeros(int qualMenu)
        {
            int numLidoCont = 0, menuCont = 0;
            //char lerNovamente = 'n'; talvez implementar return duplo.
            string numLido = "";
            switch (qualMenu)
            {
                case 0: case 1: menuCont = 4; break;
                case 2: case 3: case 4: menuCont = 2147483647; break;
            }
            do
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.D0: case ConsoleKey.NumPad0: numLido += "0"; numLidoCont++; lerNovamente = 'n'; break;
                    case ConsoleKey.D1: case ConsoleKey.NumPad1: numLido += "1"; numLidoCont++; lerNovamente = 'n'; break;
                    case ConsoleKey.D2: case ConsoleKey.NumPad2: numLido += "2"; numLidoCont++; lerNovamente = 'n'; break;
                    case ConsoleKey.D3: case ConsoleKey.NumPad3: numLido += "3"; numLidoCont++; lerNovamente = 'n'; break;
                    case ConsoleKey.D4: case ConsoleKey.NumPad4: numLido += "4"; numLidoCont++; lerNovamente = 'n'; break;
                    case ConsoleKey.D5: case ConsoleKey.NumPad5: numLido += "5"; numLidoCont++; lerNovamente = 'n'; break;
                    case ConsoleKey.D6: case ConsoleKey.NumPad6: numLido += "6"; numLidoCont++; lerNovamente = 'n'; break;
                    case ConsoleKey.D7: case ConsoleKey.NumPad7: numLido += "7"; numLidoCont++; lerNovamente = 'n'; break;
                    case ConsoleKey.D8: case ConsoleKey.NumPad8: numLido += "8"; numLidoCont++; lerNovamente = 'n'; break;
                    case ConsoleKey.D9: case ConsoleKey.NumPad9: numLido += "9"; numLidoCont++; lerNovamente = 'n'; break;
                    case ConsoleKey.Enter: lerNovamente = 'n'; numLidoCont = menuCont; break;
                    default:
                        Console.Clear();
                        Console.Write("Caracter inválido, digite novamente!");
                        Console.ReadKey(); numLido = ""; numLidoCont = 0; lerNovamente = 's'; break;
                }
                if (lerNovamente == 's') break;
            } while (numLidoCont != menuCont); return numLido;
        }
        public static void Main()
        {
            int qtdContas = 3, indexLogin = 1, idConta = 0, idContaTransf = 0, opcaoMenu = 0;
            char logado = 'n', contaValidada = 'n', senhaValidada = 'n';
            string numLido;
            string[,] contas = {{"0", "1234", "1234","José Carlos Alvarenga", "10000"},
                                {"1", "3333", "3333","Maria Alvina Pereiran", "99999"},
                                {"2", "6669", "6669","Divo Iluminado da Vil", "50000"}};
            do
            {
                do
                { // LOGIN - CONTA E SENHA
                    Console.Clear();
                    if (indexLogin == 1) { Console.Write($"Digite o número da sua conta: "); opcaoMenu = 0; }
                    if (indexLogin == 2) { Console.Write("Digite sua senha: "); senhaValidada = 's'; opcaoMenu = 1; }
                    numLido = LerValidaNumeros(opcaoMenu);
                    if (lerNovamente == 'n') break;
                } while (true);
                if (indexLogin == 1)
                {
                    for (int i = 0; i != qtdContas; i++)
                    {
                        if (numLido == contas[i, indexLogin]) { contaValidada = 's'; idConta = i; indexLogin = 2; }
                    }
                    if (contaValidada == 'n') { Console.Clear(); Console.Write("Conta iválida!"); Console.ReadKey(); }
                }
                if (senhaValidada == 's' && indexLogin == 2)
                {
                    if (numLido == contas[idConta, indexLogin]) { logado = 's'; Console.Clear(); Console.Write("Logado!"); Console.ReadKey(); }
                    else { Console.Clear(); Console.Write("Senha errada!"); Console.ReadKey(); }
                }
                while (logado == 's')
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine($"{contas[idConta, 3]}");
                        Console.WriteLine($"Conta: {contas[idConta, 2]}");
                        Console.WriteLine($"Saldo: R$ {contas[idConta, 4]},00");
                        Console.WriteLine();
                        Console.WriteLine("1 - Saque");
                        Console.WriteLine("2 - Depósito");
                        Console.WriteLine("3 - Transferência");
                        Console.WriteLine("4 - Logout");
                        Console.Write("Menu: ");
                        ConsoleKeyInfo keyInfo = Console.ReadKey();
                        switch (keyInfo.Key)
                        {
                            // MENU SAQUE
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                            caseSaque:
                                Console.Clear();
                                Console.WriteLine("1 - Saque");
                                Console.Write("R$ "); numLido = LerValidaNumeros(2);
                                if (lerNovamente == 's') goto caseSaque;
                                else
                                {
                                    int saldo = int.Parse(contas[idConta, 4]);
                                    int numLidoInt = int.Parse(numLido);
                                    saldo -= numLidoInt;
                                    if (saldo < 0) { Console.WriteLine(); Console.WriteLine("Saldo insuficiente!"); Console.ReadKey(); break; }
                                    else { contas[idConta, 4] = saldo.ToString(); break; }
                                }
                            // MENU DEPÓSITO
                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                            caseDeposito:
                                Console.Clear();
                                Console.WriteLine("2 - Depósito");
                                Console.Write("R$ "); numLido = LerValidaNumeros(3);
                                if (lerNovamente == 's') goto caseDeposito;
                                else
                                {
                                    int saldo = int.Parse(contas[idConta, 4]);
                                    int numLidoInt = int.Parse(numLido);
                                    saldo += numLidoInt;
                                    contas[idConta, 4] = saldo.ToString(); break;
                                }
                            // MENU TRANSFERÊNCIA
                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                            caseTransferencia:
                                Console.Clear();
                                Console.WriteLine("3 - Transferência");
                                Console.Write("R$ "); numLido = LerValidaNumeros(3);
                                if (lerNovamente == 's') goto caseTransferencia;
                                else
                                {
                                    int saldo = int.Parse(contas[idConta, 4]);
                                    int numLidoInt = int.Parse(numLido);
                                    saldo -= numLidoInt;
                                    if (saldo < 0) { Console.WriteLine(); Console.WriteLine("Saldo insuficiente!"); Console.ReadKey(); break; }
                                    else
                                    {
                                        contas[idConta, 4] = saldo.ToString();
                                    caseTransfConta:
                                        contaValidada = 'n';
                                        Console.Clear();
                                        Console.WriteLine("3 - Transferência");
                                        Console.Write("Conta: "); numLido = LerValidaNumeros(0);
                                        for (int i = 0; i != qtdContas; i++)
                                        {
                                            if (numLido == contas[i, indexLogin] && i != idConta) { contaValidada = 's'; idContaTransf = i; }
                                        }
                                        if (contaValidada == 'n') { Console.Clear(); Console.Write("Conta iválida!"); Console.ReadKey(); goto caseTransfConta; }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Comprovante de Transferência");
                                            Console.WriteLine();
                                            Console.WriteLine($"{contas[idContaTransf, 3]}");
                                            Console.WriteLine($"R$ {numLidoInt}");
                                            int saldoTransferencia = int.Parse(contas[idContaTransf, 4]);
                                            saldoTransferencia += numLidoInt;
                                            contas[idContaTransf, 4] = saldoTransferencia.ToString(); Console.ReadKey(); break;
                                        }
                                    }
                                }
                            // MENU LOGOUT
                            case ConsoleKey.D4:
                            case ConsoleKey.NumPad4:
                                logado = 'n'; contaValidada = 'n'; senhaValidada = 'n'; indexLogin = 1;
                                Console.Clear(); Console.Write("Desconectado!"); Console.ReadKey(); break;
                            default:
                                Console.WriteLine();
                                Console.Write("Opção inválida, digite novamente!");
                                Console.ReadKey(); break;
                        }
                        if (opcaoMenu != 0) break;
                    } while (true);
                }
            } while (true);
        }
    }
}