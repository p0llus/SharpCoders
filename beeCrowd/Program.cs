using System;
using System.Security.Cryptography.X509Certificates;

namespace beeCrowd
{
    public class Program
    {
        public static void Main()
        {   /*
            // 1000
            Console.WriteLine("Hello World!");


            // 1001
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int X = A + B;
            Console.WriteLine($"X = {X}");


            // 1002
            double π = 3.14159;
            double raio = double.Parse(Console.ReadLine());
            double B = raio * raio;
            double A = π * B;
            Console.WriteLine($"A={A:F4}");


            // 1003
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int SOMA = A + B;
            Console.WriteLine($"SOMA = {SOMA}");


            // 1004
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int PROD = A * B;
            Console.WriteLine($"PROD = {PROD}");


            // 1005
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double MEDIA = ((A * 3.5) + (B * 7.5)) / (3.5 + 7.5);
            Console.WriteLine($"MEDIA = {MEDIA:F5}");


            // 1006
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            double MEDIA = ((A * 2) + (B * 3) + (C * 5)) / 10;
            Console.WriteLine($"MEDIA = {MEDIA:F1}");


            // 1007
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int DIFERENCA = (A * B) - (C * D);
            Console.WriteLine($"DIFERENCA = {DIFERENCA}");


            // 1008
            int idFuncionario = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine());
            double salario = horasTrabalhadas * valorHora;
            Console.WriteLine($"NUMBER = {idFuncionario}");
            Console.WriteLine($"SALARY = U$ {salario:F2}");
 

            // 1009
            string nomeFuncionario = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine());
            double vendas = double.Parse(Console.ReadLine());
            double comissao = vendas * 0.15;
            double salarioTotal = salarioFixo + comissao;
            Console.WriteLine($"TOTAL = R$ {salarioTotal:F2}");
            

            // 1010
            string[] pec1 = Console.ReadLine().Split();
            int codPec1 = int.Parse(pec1[0]);
            int qtdPec1 = int.Parse(pec1[1]);
            double valPec1 = double.Parse(pec1[2]);
            double totalPec1 = qtdPec1 * valPec1;
            string[] pec2 = Console.ReadLine().Split();
            int codPec2 = int.Parse(pec2[0]);
            int qtdPec2 = int.Parse(pec2[1]);
            double valPec2 = double.Parse(pec2[2]);
            double totalPec2 = qtdPec2 * valPec2;
            double totalPagar = totalPec1 + totalPec2;
            Console.WriteLine($"VALOR A PAGAR: R$ {totalPagar:F2}");
            

            // 1011
            double raio = double.Parse(Console.ReadLine());
            double PI = 3.14159;
            double volume = (4.0/3.0) * PI * raio * raio * raio;
            Console.WriteLine($"VOLUME = {volume:F3}");
            

            // 1012
            string[] medidas = Console.ReadLine().Split();
            double A = double.Parse(medidas[0]);
            double B = double.Parse(medidas[1]);
            double C = double.Parse(medidas[2]);
            double PI = 3.14159;
            double areaTri = (A * C) / 2;
            double areaCir = PI * C * C;
            double areaTra = ((A + B) * C) / 2;
            double areaQua = B * B;
            double areaRet = A * B;
            Console.WriteLine($"TRIANGULO: {areaTri:F3}");
            Console.WriteLine($"CIRCULO: {areaCir:F3}");
            Console.WriteLine($"TRAPEZIO: {areaTra:F3}");
            Console.WriteLine($"QUADRADO: {areaQua:F3}");
            Console.WriteLine($"RETANGULO: {areaRet:F3}");
            

            // 1013
            string[] medidas = Console.ReadLine().Split();
            int A = int.Parse(medidas[0]);
            int B = int.Parse(medidas[1]);
            int C = int.Parse(medidas[2]);
            int maiorAeB = (A + B + Math.Abs(A - B)) / 2;
            int maiorComC = (maiorAeB + C + Math.Abs(maiorAeB - C)) / 2;
            Console.WriteLine($"{maiorComC} eh o maior");
            

            // 1014
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            double consumo = X / Y;
            Console.WriteLine($"{consumo:F3} km/l");
            

            // 1015
            string[] p1 = Console.ReadLine().Split();
            string[] p2 = Console.ReadLine().Split();
            double x1 = double.Parse(p1[0]);
            double y1 = double.Parse(p1[1]);
            double x2 = double.Parse(p2[0]);
            double y2 = double.Parse(p2[1]);
            double distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine($"{distancia:F4}");
            

            // 1016
            int kilometros = int.Parse(Console.ReadLine());
            int tempo = kilometros * 2;
            Console.WriteLine($"{tempo} minutos");
            

            // 1017
            double tempo = double.Parse(Console.ReadLine());
            int velocidade = int.Parse(Console.ReadLine());
            double distancia = tempo * velocidade / 12;
            Console.WriteLine($"{distancia:F3}");
            

            // 1018
            int valor = int.Parse(Console.ReadLine());
            Console.WriteLine(valor);
            int n100, n50, n20, n10, n5, n2, n1;
            n100 = valor / 100;
            valor -= 100 * n100;
            n50 = valor / 50;
            valor -= 50 * n50;
            n20 = valor / 20;
            valor -= 20 * n20;
            n10 = valor / 10;
            valor -= 10 * n10;
            n5 = valor / 5;
            valor -= 5 * n5;
            n2 = valor / 2;
            valor -= 2 * n2;
            n1 = valor;
            valor -= 1 * n1;
            Console.WriteLine($"{n100} nota(s) de R$ 100,00");
            Console.WriteLine($"{n50} nota(s) de R$ 50,00");
            Console.WriteLine($"{n20} nota(s) de R$ 20,00");
            Console.WriteLine($"{n10} nota(s) de R$ 10,00");
            Console.WriteLine($"{n5} nota(s) de R$ 5,00");
            Console.WriteLine($"{n2} nota(s) de R$ 2,00");
            Console.WriteLine($"{n1} nota(s) de R$ 1,00");
            

            // 1019
            int segundosTotais = int.Parse(Console.ReadLine());
            int horas = (segundosTotais / (60 * 60));
            int minutos = ((segundosTotais - (horas * 60 * 60)) / 60);
            int segundos = (segundosTotais - (horas * 60 * 60) - (minutos * 60));
            Console.WriteLine($"{horas}:{minutos}:{segundos}");
            

            // 1020
            int diasTotais = int.Parse(Console.ReadLine());
            int anos = diasTotais / 365;
            diasTotais -= 365 * anos;
            int meses = diasTotais / 30;
            diasTotais -= 30 * meses;
            int dias = diasTotais;
            Console.WriteLine($"{anos} ano(s)");
            Console.WriteLine($"{meses} mes(es)");
            Console.WriteLine($"{dias} dia(s)");
            
            
            // 1021 - feito Hugo
            double vlr = double.Parse(Console.ReadLine());

            int n100 = (int)(vlr / 100);
            vlr -= 100 * n100;
            int n50 = (int)(vlr / 50);
            vlr -= 50 * n50;
            int n20 = (int)(vlr / 20);
            vlr -= 20 * n20;
            int n10 = (int)(vlr / 10);
            vlr -= 10 * n10;
            int n5 = (int)(vlr / 5);
            vlr -= 5 * n5;
            int n2 = (int)(vlr / 2);
            vlr -= 2 * n2;

            int m100, m50, m25, m10, m5;
            vlr *= 100;

            m100 = (int)(vlr / 100);
            vlr -= 100 * m100;
            m50 = (int)(vlr / 50);
            vlr -= 50 * m50;
            m25 = (int)(vlr / 25);
            vlr -= 25 * m25;
            m10 = (int)(vlr / 10);
            vlr -= 10 * m10;
            m5 = (int)(vlr / 5);
            vlr -= 5 * m5;

            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{n100} nota(s) de R$ 100.00");
            Console.WriteLine($"{n50} nota(s) de R$ 50.00");
            Console.WriteLine($"{n20} nota(s) de R$ 20.00");
            Console.WriteLine($"{n10} nota(s) de R$ 10.00");
            Console.WriteLine($"{n5} nota(s) de R$ 5.00");
            Console.WriteLine($"{n2} nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{m100} moeda(s) de R$ 1.00");
            Console.WriteLine($"{m50} moeda(s) de R$ 0.50");
            Console.WriteLine($"{m25} moeda(s) de R$ 0.25");
            Console.WriteLine($"{m10} moeda(s) de R$ 0.10");
            Console.WriteLine($"{m5} moeda(s) de R$ 0.05");
            Console.WriteLine($"{vlr:F0} moeda(s) de R$ 0.01");


            // 1021 menor - avaliar
            double money = double.Parse(Console.ReadLine());
            double[] valor = {100, 50, 20, 10, 5, 2, 1, 0.5, 0.25, 0.1, 0.05, 0.01};
            int quantityOfCash;
            string currencyType = "nota(s)";
            Console.WriteLine("NOTAS:");
            Console.WriteLine(currencyType);
            for (int i = 0; i < valor.Length; i++){
                if(i==6){
                    currencyType = "moeda(s)";
                    Console.WriteLine("MOEDAS");                
                }
                quantityOfCash = (int)(money / valor[i]);
                Console.WriteLine($"{quantityOfCash} {currencyType} de R$ {valor[i].ToString("0.00")}");
                money -= quantityOfCash * valor[i];
                money = Math.Round(money, 2);
            }
            

            // 1035
            string[] valores = Console.ReadLine().Split();
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);
            int C = int.Parse(valores[2]);
            int D = int.Parse(valores[3]);
            if (( B > C ) &&
                ( D > A ) &&
                (( C + D ) > ( A + B )) &&
                ( C >= 0 ) &&
                ( D >= 0 ) &&
                ( A % 2 == 0 )) {
                Console.WriteLine("Valores aceitos");
            }
            else {
                Console.WriteLine("Valores nao aceitos");
            }
            

            // 1036
            string[] valores = Console.ReadLine().Split();
            double A = double.Parse(valores[0]);
            double B = double.Parse(valores[1]);
            double C = double.Parse(valores[2]);
            double X = ( B * B ) - ( 4 * A * C );
            if ( X < 0 ) {
                Console.WriteLine("Impossivel calcular");
            }
            else if ( A == 0 ) {
                Console.WriteLine("Impossivel calcular");
            }
            else {
                double Y = (( -B + Math.Sqrt(X) ) / ( A + A ));
                double Z = (( -B - Math.Sqrt(X) ) / ( A + A ));
                Console.WriteLine($"R1 = {Y:F5}");
                Console.WriteLine($"R2 = {Z:F5}");
            }
            

            // 1037
            double valor = double.Parse(Console.ReadLine());
            if (valor > 75.00 && valor <= 100.00) { Console.WriteLine("Intervalo (75,100]"); }
            else if (valor > 50.00 && valor <= 75.00) { Console.WriteLine("Intervalo (50,75]"); }
            else if (valor > 25.00 && valor <= 50.00) { Console.WriteLine("Intervalo (25,50]"); }
            else if (valor >= 0.00 && valor <= 25.00) { Console.WriteLine("Intervalo [0,25]"); }
            else { Console.WriteLine("Fora de intervalo"); }
            

            // 1038
            string[] pedido = Console.ReadLine().Split();
            int cod = int.Parse(pedido[0]);
            int qtd = int.Parse(pedido[1]);
            double conta;
            if ( cod == 1 ) {
                conta = qtd * 4.00;
                Console.WriteLine($"Total: R$ {conta:F2}");
            }
            else if ( cod == 2 ) {
                conta = qtd * 4.50;
                Console.WriteLine($"Total: R$ {conta:F2}");
            }
            else if (cod == 3) {
                conta = qtd * 5.00;
                Console.WriteLine($"Total: R$ {conta:F2}");
            }
            else if (cod == 4) {
                conta = qtd * 2.00;
                Console.WriteLine($"Total: R$ {conta:F2}");
            }
            else {
                conta = qtd * 1.50;
                Console.WriteLine($"Total: R$ {conta:F2}");
            }
            

            // 1040
            string[] notas = Console.ReadLine().Split();
            double n1 = double.Parse(notas[0]);
            double n2 = double.Parse(notas[1]);
            double n3 = double.Parse(notas[2]);
            double n4 = double.Parse(notas[3]);
            double media = ((( n1 * 2 ) + ( n2 * 3 ) + ( n3 * 4 ) + n4 ) / 10 );
            if ( media == 4.85 ) {
                media = 4.80;
            }
            if ( media >= 7 ) {
                Console.WriteLine($"Media: {media:F1}");
                Console.WriteLine("Aluno aprovado.");
            }
            else if ( media < 5 ) {
                Console.WriteLine($"Media: {media:F1}");
                Console.WriteLine("Aluno reprovado.");
            }
            else {
                Console.WriteLine($"Media: {media:F1}");
                Console.WriteLine("Aluno em exame.");
                double nExame = double.Parse(Console.ReadLine());
                Console.WriteLine($"Nota do exame: {nExame:F1}");
                double mediaExame = ( nExame + media ) / 2;
                if ( mediaExame >= 5) {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine($"Media final: {mediaExame:F1}");
                }
                else {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine($"Media final: {mediaExame:F1}");
                }
            }


            // 1041
            string[] coordenadas = Console.ReadLine().Split();
            double X = double.Parse(coordenadas[0]);
            double Y = double.Parse(coordenadas[1]);
            if ( X == 0 && Y == 0 ) { Console.WriteLine("Origem"); }
            else if ( X != 0 && Y == 0 ) { Console.WriteLine("Eixo X"); }
            else if ( X == 0 && Y != 0 ) { Console.WriteLine("Eixo Y"); }
            else if ( X > 0 && Y > 0 ) { Console.WriteLine("Q1"); }
            else if ( X < 0 && Y > 0 ) { Console.WriteLine("Q2"); }
            else if ( X < 0 && Y < 0 ) { Console.WriteLine("Q3"); }
            else { Console.WriteLine("Q4"); }


            // 1042 - feito
            string[] valores = Console.ReadLine().Split();
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);
            int C = int.Parse(valores[2]);

            int D = A;
            int E = B;
            int F = C;

            if (D > E && D > F){
                int aux = D;
                D = F;
                F = aux;
            } else if (E > D && E > F){
                int aux = E;
                E = F;
                F = aux;
            }
            if (D > E){
                int aux = D;
                D = E;
                E = aux;
            }
            Console.WriteLine($"{D}\n{E}\n{F}\n\n{A}\n{B}\n{C}");


            // 1043
            string[] valores = Console.ReadLine().Split();
            double A = double.Parse(valores[0]);
            double B = double.Parse(valores[1]);
            double C = double.Parse(valores[2]);
            double perimetro = A + B + C;
            double areaTrap = (( A + B ) * C / 2 );
            if (( A < ( B + C )) &&
                ( B < ( A + C )) &&
                ( C < ( A + B ))) {
                Console.WriteLine($"Perimetro = {perimetro:F1}");
            }
            else {
                Console.WriteLine($"Area = {areaTrap:F1}");
            }


            // 1044
            string[] valores = Console.ReadLine().Split();
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);
            int divisao;
            if ( A < B ) {
                divisao = B % A;
            }
            else {
                divisao = A % B;
            }
            if ( divisao == 0 ) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }


            // 1045
            string[] lados = Console.ReadLine().Split();
            double ladoA = double.Parse(lados[0]),
                   ladoB = double.Parse(lados[1]),
                   ladoC = double.Parse(lados[2]);

            if (ladoC > ladoB && ladoC > ladoA) {
                double aux = ladoC;
                ladoC = ladoA;
                ladoA = aux;
            }
            else if (ladoB > ladoA && ladoB > ladoC) {
                double aux = ladoB;
                ladoB = ladoA;
                ladoA = aux;
            }
            if (ladoC > ladoB) {
                double aux = ladoC;
                ladoC = ladoB;
                ladoB = aux;
            }
            if (ladoA >= ladoB + ladoC) {
                Console.WriteLine("NAO FORMA TRIANGULO");
                return;
            }
            if (ladoA * ladoA == ladoB * ladoB + ladoC * ladoC) {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (ladoA * ladoA > ladoB * ladoB + ladoC * ladoC) {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if (ladoA == ladoB && ladoB == ladoC) {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (ladoA == ladoB || ladoB == ladoC || ladoA == ladoC) {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }


            // 1046
            string[] tempos = Console.ReadLine().Split();
            int inicial = int.Parse(tempos[0]);
            int final = int.Parse(tempos[1]);
            if (inicial == final) { 
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            else if (final > inicial) { 
                Console.WriteLine($"O JOGO DUROU {final - inicial} HORA(S)");
            }
            else if (inicial > final) {
                Console.WriteLine($"O JOGO DUROU {(final + 24) - inicial} HORA(S)");
            }
 

            // 1047
            string[] tempos = Console.ReadLine().Split();
            int horaInicial = int.Parse(tempos[0]);
            int minutoInicial = int.Parse(tempos[1]);
            int horaFinal = int.Parse(tempos[2]);
            int minutoFinal = int.Parse(tempos[3]);
            int minutosTotais = ((horaFinal * 60) + minutoFinal) - ((horaInicial * 60) + minutoInicial);
            if (minutosTotais <= 0) {
                minutosTotais += (24 * 60);
            }
            int hora = minutosTotais / 60;
            int minuto = minutosTotais % 60;
            Console.WriteLine($"O JOGO DUROU {hora} HORA(S) E {minuto} MINUTO(S)");


            // 1048
            double salario = double.Parse(Console.ReadLine());
            double reajuste;
            if (salario <= 400.0) { reajuste = 15; }
            else if (salario <= 800.0) { reajuste = 12; }
            else if (salario <= 1200.0) { reajuste = 10; }
            else if (salario <= 2000.0) { reajuste = 7; }
            else { reajuste = 4;  }
            Console.WriteLine($"Novo salario: {(salario + (salario * reajuste / 100)):F2}");
            Console.WriteLine($"Reajuste ganho: {(salario * reajuste / 100):F2}");
            Console.WriteLine($"Em percentual: {reajuste} %");


            // 1049
            string palavra1 = Console.ReadLine();
            string palavra2 = Console.ReadLine();
            string palavra3 = Console.ReadLine();
            if (palavra1 == "vertebrado" && palavra2 == "ave" && palavra3 == "carnivoro") { Console.WriteLine("aguia"); }
            if (palavra1 == "vertebrado" && palavra2 == "ave" && palavra3 == "onivoro") { Console.WriteLine("pomba"); }
            if (palavra1 == "vertebrado" && palavra2 == "mamifero" && palavra3 == "onivoro") { Console.WriteLine("homem"); }
            if (palavra1 == "vertebrado" && palavra2 == "mamifero" && palavra3 == "herbivoro") { Console.WriteLine("vaca"); }
            if (palavra1 == "invertebrado" && palavra2 == "inseto" && palavra3 == "herbivoro") { Console.WriteLine("lagarta"); }
            if (palavra1 == "invertebrado" && palavra2 == "inseto" && palavra3 == "hematofago") { Console.WriteLine("pulga"); }
            if (palavra1 == "invertebrado" && palavra2 == "anelideo" && palavra3 == "hematofago") { Console.WriteLine("sanguessuga"); }
            if (palavra1 == "invertebrado" && palavra2 == "anelideo" && palavra3 == "onivoro") { Console.WriteLine("minhoca"); }


            // 1050
            int DDD = int.Parse(Console.ReadLine());
            if (DDD == 61) { Console.WriteLine("Brasilia"); }
            else if (DDD == 71) { Console.WriteLine("Salvador"); }
            else if (DDD == 11) { Console.WriteLine("Sao Paulo"); }
            else if (DDD == 21) { Console.WriteLine("Rio de Janeiro"); }
            else if (DDD == 32) { Console.WriteLine("Juiz de Fora"); }
            else if (DDD == 19) { Console.WriteLine("Campinas"); }
            else if (DDD == 27) { Console.WriteLine("Vitoria"); }
            else if (DDD == 31) { Console.WriteLine("Belo Horizonte"); }
            else { Console.WriteLine("DDD nao cadastrado"); }


            // 1051
            double salario = double.Parse(Console.ReadLine());
            double valorTaxado = 0, Taxa8 = 0, Taxa18 = 0, Taxa28 = 0;
            if (salario <= 2000.00) {
                Console.WriteLine("Isento");
                return;
            }
            if (salario > 2000.00) {
                valorTaxado = salario - 2000.00;
                Taxa8 = valorTaxado * 0.08;
            }
            if (salario > 3000.0) {
                valorTaxado = salario - 3000.00;
                Taxa18 = valorTaxado * 0.18;
                Taxa8 = 80;
            }
            if (salario > 4500.00) {
                valorTaxado = salario - 4500.00;
                Taxa28 = valorTaxado * 0.28;
                Taxa18 = 270;
                Taxa8 = 80;
            }
            Console.WriteLine($"R$ {(Taxa8 + Taxa18 + Taxa28):F2}");
           

            // 1052
            int mes = int.Parse(Console.ReadLine());
            if (mes == 1) { Console.WriteLine("January"); }
            else if (mes == 2) { Console.WriteLine("February"); }
            else if (mes == 3) { Console.WriteLine("March"); }
            else if (mes == 4) { Console.WriteLine("April"); }
            else if (mes == 5) { Console.WriteLine("May"); }
            else if (mes == 6) { Console.WriteLine("June"); }
            else if (mes == 7) { Console.WriteLine("July"); }
            else if (mes == 8) { Console.WriteLine("August"); }
            else if (mes == 9) { Console.WriteLine("September"); }
            else if (mes == 10) { Console.WriteLine("October"); }
            else if (mes == 11) { Console.WriteLine("November"); }
            else if (mes == 12) { Console.WriteLine("December"); }


            // 1059
            int loop = 2;
            while (loop != 102) {
                Console.WriteLine(loop);
                loop = loop + 2;
            }


            // 1060
            int somador = 0;
            int loop = 1;
            while (loop != 7) {
                loop++;
                double numero = double.Parse(Console.ReadLine());
                if (numero > 0) { somador++; }
            }
            Console.WriteLine($"{somador} valores positivos");


            // 1064
            int totalNumPositivos = 0;
            double somaNumPositivos = 0;
            int loop = 1;
            while (loop != 7) {
                loop++;
                double numLido = double.Parse(Console.ReadLine());
                if (numLido > 0) { 
                    totalNumPositivos++;
                    somaNumPositivos = somaNumPositivos + numLido;                
                }
            }
            Console.WriteLine($"{totalNumPositivos} valores positivos");
            Console.WriteLine($"{somaNumPositivos / totalNumPositivos:F1}");


            // 1065
            int totalNumPares = 0;
            int loop = 0;
            while (loop != 5) {
                loop++;
                double numLido = double.Parse(Console.ReadLine());
                if (numLido % 2 == 0) { totalNumPares++; }
            }
            Console.WriteLine($"{totalNumPares} valores pares");


            // 1066
            int totalNumPar = 0;
            int totalNumImp = 0;
            int totalNumPos = 0;
            int totalNumNeg = 0;
            int loop = 0;
            while (loop != 5) {
                loop++;
                double numLido = double.Parse(Console.ReadLine());
                if (numLido % 2 == 0) { totalNumPar++; }
                else { totalNumImp++; }
                if (numLido > 0) { totalNumPos++; }
                else if (numLido < 0) { totalNumNeg++; }
            }
            Console.WriteLine($"{totalNumPar} valor(es) par(es)");
            Console.WriteLine($"{totalNumImp} valor(es) impar(es)");
            Console.WriteLine($"{totalNumPos} valor(es) positivo(s)");
            Console.WriteLine($"{totalNumNeg} valor(es) negativo(s)");


            // 1067
            int numLido = int.Parse(Console.ReadLine());
            int contNum = 1;
            while (contNum <= numLido) {
                Console.WriteLine(contNum);
                contNum = contNum + 2;
            }


            // 1070
            int numLido = int.Parse(Console.ReadLine());
            if (numLido % 2 == 0) { numLido++; }
            int loop = 0;
            while (loop != 6) {
                loop++;
                Console.WriteLine(numLido);
                numLido = numLido + 2;
            }


            // 1071
            int numLido1 = int.Parse(Console.ReadLine());
            int numLido2 = int.Parse(Console.ReadLine());
            int somaImpares = 0, aux;
            if (numLido1 > numLido2) { aux = numLido2; numLido2 = numLido1; numLido1 = aux; }
            for (int i = numLido1 + 1; i < numLido2; i++) { if (i % 2 != 0) { somaImpares += i; } }
            Console.WriteLine(somaImpares);


            // 1072
            int numLido = int.Parse(Console.ReadLine());
            int numIn = 0, numOut = 0;
            for (int i = 0; i < numLido; i++) {
                int numLidoX = int.Parse(Console.ReadLine());
                if (numLidoX >= 10 && numLidoX <= 20) { numIn++; }
                else { numOut++; }
            }
            Console.WriteLine($"{numIn} in");
            Console.WriteLine($"{numOut} out");


            // 1073
            int numLido = int.Parse(Console.ReadLine());
            for (int i = 2; i <= numLido; i += 2) { Console.WriteLine($"{i}^2 = {i*i}"); }


            // 1074
            int numLido = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numLido; i++) {
                int numLidoX = int.Parse(Console.ReadLine());
                if (numLidoX == 0) { Console.WriteLine("NULL"); }
                else {
                    if (numLidoX % 2 == 0) { Console.Write("EVEN "); }
                    else { Console.Write("ODD "); }
                    if (numLidoX > 0) { Console.WriteLine("POSITIVE"); }
                    else { Console.WriteLine("NEGATIVE"); }
                }
            }


            // 1075
            int numLido = int.Parse(Console.ReadLine());
            for (int i = 1; i < 10000; i++) {
                if (i % numLido == 2) { Console.WriteLine(i); }
            }


            // 1078
            int numLido = int.Parse(Console.ReadLine());
            for (int i = 1; i != 11; i++) { Console.WriteLine($"{i} x {numLido} = {i * numLido}"); }


            // 1079
            int numLido = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numLido; i++) {
                string[] valores = Console.ReadLine().Split();
                double valor1 = double.Parse(valores[0]);
                double valor2 = double.Parse(valores[1]);
                double valor3 = double.Parse(valores[2]);
                double mediaPonderada = ((valor1 * 2) + (valor2 * 3) + (valor3 * 5)) / 10;
                Console.WriteLine($"{mediaPonderada:F1}");
            }


            // 1080
            int numMaior = 0;
            int posicao = 1;
            for (int i = 1; i < 101; i++) {
                int numLido = int.Parse(Console.ReadLine());
                if (i == 1) { numMaior = numLido; posicao = 1; }
                else {
                    if (numLido > numMaior) {
                        numMaior = numLido;
                        posicao = i;
                    }
                }
            }
            Console.WriteLine(numMaior);
            Console.WriteLine(posicao);


            // 1094
            double percRatos = 0, percSapos = 0, percCoelhos = 0, totalCobaias = 0, totalRatos = 0, totalSapos = 0, totalCoelhos = 0;
            int numTestes = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numTestes; i++) {
                string[] valores = Console.ReadLine().Split();
                int numCobaias = int.Parse(valores[0]);
                var animal = valores[1];
                totalCobaias += numCobaias;
                if (animal == "C") { totalCoelhos += numCobaias; }
                else if (animal == "R") { totalRatos += numCobaias; }
                else if (animal == "S") { totalSapos += numCobaias; }
                percCoelhos = (totalCoelhos * 100) / totalCobaias;
                percRatos = (totalRatos * 100) / totalCobaias;
                percSapos = (totalSapos * 100) / totalCobaias;
            }
            Console.WriteLine($"Total: {totalCobaias} cobaias");
            Console.WriteLine($"Total de coelhos: {totalCoelhos}");
            Console.WriteLine($"Total de ratos: {totalRatos}");
            Console.WriteLine($"Total de sapos: {totalSapos}");
            Console.WriteLine($"Percentual de coelhos: {percCoelhos:F2} %");
            Console.WriteLine($"Percentual de ratos: {percRatos:F2} %");
            Console.WriteLine($"Percentual de sapos: {percSapos:F2}  %");


            // 1095
            for (int I = 1, J = 60; J >= 0; I += 3, J -= 5) { Console.WriteLine($"I={I} J={J}"); }


            // 1096
            for (int i = 1; i <= 9; i += 2) {
                for (int I = i, J = 7; J >= 5; J -= 1) { Console.WriteLine($"I={I} J={J}"); }
            }


            // 1097
            int I = 1, J = 7;
            while (I <= 9) {
                Console.WriteLine($"I={I} J={J}");
                Console.WriteLine($"I={I} J={J - 1}");
                Console.WriteLine($"I={I} J={J - 2}");
                I += 2; J += 2;
            }


            // 1098
            int I = 0, J = 0;
            double i, j, valor = 0;
            for (i = 0, j = 1; i < 2; j++) {
                if (I == 0) { Console.WriteLine($"I={i:F0} J={j:F0}"); }
                else { Console.WriteLine($"I={i:F1} J={j:F1}"); }
                J++;
                if (J == 3) {
                    i += 0.2;
                    valor += 0.2;
                    j = valor;
                    J = 0;
                    I++;
                }
                if (I == 5) { I = 0; }
            }


            // 1099
            int numLido = int.Parse(Console.ReadLine());
            for (int i = 0; i < numLido; i++) {
                int somaImpares = 0;
                string[] valores = Console.ReadLine().Split();
                int valor1 = int.Parse(valores[0]);
                int valor2 = int.Parse(valores[1]);
                if (valor1 < valor2) { for (int j = valor1 + 1; j < valor2; j++) { if (j % 2 != 0) { somaImpares += j; } } }
                else { for (int j = valor2 + 1; j < valor1; j++) { if (j % 2 != 0) { somaImpares += j; } } }
                Console.WriteLine(somaImpares);
            }


            // 1101
            do
            {
                string[] valores = Console.ReadLine().Split();
                int M = int.Parse(valores[0]);
                int N = int.Parse(valores[1]);
                if (M > 0 && N > 0)
                {
                    int soma = 0;
                    if (M > N)
                    {
                        for (N = N; N <= M; N++)
                        {
                            Console.Write($"{N} ");
                            soma += N;
                        }
                        Console.WriteLine($"Sum={soma}");
                    }
                    else
                    {
                        for (M = M; M <= N; M++)
                        {
                            Console.Write($"{M} ");
                            soma += M;
                        }
                        Console.WriteLine($"Sum={soma}");
                    }
                }
                else { break; }
            } while(true);


            // 1113
            do {
                string[] valores = Console.ReadLine().Split();
                int valor1 = int.Parse(valores[0]);
                int valor2 = int.Parse(valores[1]);
                if (valor1 != valor2) {
                    if (valor1 > valor2) { Console.WriteLine("Decrescente"); }
                    else { Console.WriteLine("Crescente"); }
                }
                else { break; }
            } while (true);


            // 1114
            do {
                int senha = int.Parse(Console.ReadLine());
                if (senha != 2002) { Console.WriteLine("Senha Invalida"); }
                else { Console.WriteLine("Acesso Permitido"); break; }
            } while (true);


            // 1115
            do {
                string[] valores = Console.ReadLine().Split();
                int valor1 = int.Parse(valores[0]);
                int valor2 = int.Parse(valores[1]);
                if (valor1 == 0 || valor2 == 0) { break; }
                else {
                    if (valor1 > 0 && valor2 > 0) { Console.WriteLine("primeiro"); }
                    if (valor1 > 0 && valor2 < 0) { Console.WriteLine("quarto"); }
                    if (valor1 < 0 && valor2 < 0) { Console.WriteLine("terceiro"); }
                    if (valor1 < 0 && valor2 > 0) { Console.WriteLine("segundo"); }
                }
            } while (true);


            // 1116
            int qtdVezes = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdVezes; i++) {
                string[] valores = Console.ReadLine().Split();
                int valor1 = int.Parse(valores[0]);
                double valor2 = double.Parse(valores[1]);
                if (valor2 == 0) { Console.WriteLine("divisao impossivel"); }
                else { Console.WriteLine($"{(valor1 / valor2):F1}"); }
            }


            // 1117
            double somValidas = 0;
            int contValidas = 0;
            do {
                double nota = double.Parse(Console.ReadLine());
                if (nota >= 0 && nota <= 10) {
                    somValidas = somValidas + nota;
                    contValidas++;
                    if (contValidas == 2) {
                        Console.WriteLine($"media = {(somValidas / 2):F2}");
                        break;
                    }
                }
                else { Console.WriteLine("nota invalida"); }
            } while (true);


            // 1118
            double somValidas = 0;
            int contValidas = 0;
            do {
                double nota = double.Parse(Console.ReadLine());
                if (nota >= 0 && nota <= 10) {
                    somValidas = somValidas + nota;
                    contValidas++;
                    if (contValidas == 2) {
                        Console.WriteLine($"media = {(somValidas / 2):F2}");
                        do {
                            Console.WriteLine("novo calculo (1-sim 2-nao)");
                            var resposta = Console.ReadLine();
                            if (resposta == "2") { return; }
                            else if (resposta == "1") { somValidas = 0; contValidas = 0; break; }
                        } while(true);
                    }
                }
                else { Console.WriteLine("nota invalida"); }
            } while (true);


            // 1131
            int grenais = 0;
            int vitoriasInter = 0;
            int vitoriasGremio = 0;
            int qtdEmpates = 0;
            do {
                grenais++;
                string[] gols = Console.ReadLine().Split();
                int golsInter = int.Parse(gols[0]);
                int golsGremio = int.Parse(gols[1]);
                if (golsInter == golsGremio) { qtdEmpates++; }
                else if (golsInter > golsGremio) { vitoriasInter++; }
                else { vitoriasGremio++; }
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                var resposta = Console.ReadLine();
                if (resposta == "2") {
                    Console.WriteLine($"{grenais} grenais");
                    Console.WriteLine($"Inter:{vitoriasInter}");
                    Console.WriteLine($"Gremio:{vitoriasGremio}");
                    Console.WriteLine($"Empates:{qtdEmpates}");
                    if (vitoriasInter == vitoriasGremio) { Console.WriteLine($"Nao houve vencedor"); }
                    else if (vitoriasInter > vitoriasGremio) { Console.WriteLine($"Inter venceu mais"); }
                    else { Console.WriteLine($"Gremio venceu mais"); }
                    break;
                }
            } while(true);

            
            // 1132
            int numLido1 = int.Parse(Console.ReadLine());
            int numLido2 = int.Parse(Console.ReadLine());
            if (numLido1 > numLido2) { int aux = numLido1; numLido1 = numLido2; numLido2 = aux; }
            int somaDosMultiplos = 0;
            for (int i = numLido1; i <= numLido2; i++) { if (i % 13 != 0) { somaDosMultiplos += i; } }
            Console.WriteLine(somaDosMultiplos); */
        }
    }
}