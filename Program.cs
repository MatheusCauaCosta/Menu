using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;

namespace Primeiro_TIM
{//inicio projeto
    class Program
    {//inicio programa
        static void Main(string[] args)
        {//função inicio

            int opc;
            do
            {

                Clear();
                WriteLine("Menu: ");
                WriteLine("=========================");
                WriteLine("{1} consulta siglas e estados");
                WriteLine("{2} consulta dia/mes");
                WriteLine("{3} numeros por extenso");
                WriteLine("{4} Fim");
                WriteLine("=========================");
                WriteLine("Escolha uma opção");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {//inicio caso opc
                    case 1:
                        {
                            estados();
                            break;
                        }
                    case 2:
                        {
                            dia_mes();
                            break;
                        }
                    case 3:
                        {
                            extenso();
                            break;
                        }
                    case 4:
                        {
                            Fim();
                            break;
                        }
                    default:
                        {
                            WriteLine("[ *** opção invalida ***]");
                            Thread.Sleep(2000);
                            break;
                        }

                }//fim caso opc
            } while (opc != 4);
        }//fim função inicio
        private static string continuar()
        {//inicio função continuar

            string reposta;
            WriteLine("\ndeseja continuar:s/n");
            reposta = (ReadLine());

            return reposta;

        }//fim função continuar
        static void dia_mes()
        {//função dia mês
            do
            {
                Clear();
                int m, ds;

                string[] mes = {"","Janeiro", "Fevereiro", "Marco", "Abril", "Maio", "Junho",
                        "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};

                string[] dia = { "", "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sabado" };

                WriteLine("Digite o numero de um mês: ");
                m = int.Parse(ReadLine());

                WriteLine("Digite o numero de um dia de semana: ");
                ds = int.Parse(ReadLine());

                if (m < 1 || m > 12)
                {
                    WriteLine("OPÇÃO INVALIDA");

                }
                else
                {
                    WriteLine("\n" + m + " corresponde a " + mes[m] + "\n");
                }
                if (ds < 1 || ds > 7)
                {
                    WriteLine("OPÇÃO INVALIDA");
                }
                else
                {
                    WriteLine("\n" + ds + " corresponde a " + dia[ds] + "\n");
                }

            } while (continuar() == "s");



        }//fim função dia e mês
        static void estados()
        {//inicio estados
            do
            {
                string[,] estado = new string[27, 3];
                int i;
                string texto;
                bool achou;
                Clear();
                estado[0, 0] = "AC"; estado[0, 1] = "Acre"; estado[0, 2] = "Rio Branco";
                estado[1, 0] = "AL"; estado[1, 1] = "Alagoas"; estado[1, 2] = "Maceió";
                estado[2, 0] = "AP"; estado[2, 1] = "Amapá"; estado[2, 2] = "Macapá";
                estado[3, 0] = "AM"; estado[3, 1] = "Amazonas"; estado[3, 2] = "Manaus";
                estado[4, 0] = "BA"; estado[4, 1] = "Bahia"; estado[4, 2] = "Salvador";
                estado[5, 0] = "CE"; estado[5, 1] = "Ceará"; estado[5, 2] = "Fortaleza";
                estado[6, 0] = "ES"; estado[6, 1] = "Espírito Santo"; estado[6, 2] = "Vitória";
                estado[7, 0] = "GO"; estado[7, 1] = "Goiás"; estado[7, 2] = "Goiânia";
                estado[8, 0] = "MA"; estado[8, 1] = "Maranhão"; estado[8, 2] = "São Luis";
                estado[9, 0] = "MT"; estado[9, 1] = "Mato Grosso"; estado[9, 2] = "Cuiabá";
                estado[10, 0] = "MS"; estado[10, 1] = "Mato Grosso do Sul"; estado[10, 2] = "Campo Grande";
                estado[11, 0] = "MG"; estado[11, 1] = "Minas Gerais"; estado[11, 2] = "Belo Horizonte";
                estado[12, 0] = "PA"; estado[12, 1] = "Pará"; estado[12, 2] = "Belém";
                estado[13, 0] = "PB"; estado[13, 1] = "paraíba"; estado[13, 2] = "João Pessoa";
                estado[14, 0] = "PR"; estado[14, 1] = "Paraná"; estado[14, 2] = "Curitiba";
                estado[15, 0] = "PE"; estado[15, 1] = "Pernanbuco"; estado[15, 2] = "Recife";
                estado[16, 0] = "PI"; estado[16, 1] = "Piauí"; estado[16, 2] = "Teresinha";
                estado[17, 0] = "RJ"; estado[17, 1] = "Rio de Janeiro"; estado[17, 2] = "Rio de Janeiro";
                estado[18, 0] = "RN"; estado[18, 1] = "Rio Grande do Norte"; estado[18, 2] = "Natal";
                estado[19, 0] = "RS"; estado[19, 1] = "Rio Grande do Sul"; estado[19, 2] = "Porto Alegre";
                estado[20, 0] = "RO"; estado[20, 1] = "Rondônia"; estado[20, 2] = "Porto Velho";
                estado[21, 0] = "RR"; estado[21, 1] = "Roraima"; estado[21, 2] = "Boa Vista";
                estado[22, 0] = "SC"; estado[22, 1] = "Santa Catarina"; estado[22, 2] = "Florianópolis";
                estado[23, 0] = "SP"; estado[23, 1] = "São Paulo"; estado[23, 2] = "São Paulo";
                estado[24, 0] = "SE"; estado[24, 1] = "Sergipe"; estado[24, 2] = "Aracaju";
                estado[25, 0] = "TO"; estado[25, 1] = "Tocantins"; estado[25, 2] = "Palmas";
                estado[26, 0] = "DF"; estado[26, 1] = "Distrito Federal"; estado[26, 2] = "Brasília";

                WriteLine("antes de começar tome cuidado com os acentos");
                Thread.Sleep(4000);
                Clear();

                WriteLine("digite a sigla, nome do estado ou capital");
                texto = (ReadLine());
                achou = false;

                for (i = 0; i < 26; i++)
                {

                    if (texto == estado[i, 0])
                    {
                        WriteLine(texto + " corresponde " + estado[i, 1] + " e sua capital " + estado[i, 2]);
                        achou = true;
                    }

                    else if (texto == estado[i, 1])
                    {
                        WriteLine(texto + " corresponde " + estado[i, 0] + " e sua capital " + estado[i, 2]);
                        achou = true;
                    }

                    else if (texto == estado[i, 2])
                    {
                        WriteLine(texto + " corresponde " + estado[i, 1] + " e sua sigla " + estado[i, 0]);
                        achou = true;
                    }
                }// fim repetição

                if (!achou)
                {
                    WriteLine("sigla, estado ou capital não encontrado");
                }

            } while (continuar() == "s");
        }//fim estados e siglas
        static void extenso()
        {

            do
            {
                string[] unidade ={"zero", "um", "dois", "tres", "quatro", "cinco", "seis",
                          "sete", "oito", "nove", "dez", "onze", "doze", "treze", "quatorze", "quinze",
                          "dezesseis", "dezessete", "dezoito", "dezenove"};

                string[] dezena ={"", "", "vinte", "trinta", "quarenta", "cinquenta",
                        "sessenta", "setenta", "oitenta", "noventa"};

                string[] centena ={"", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos",
                          "seiscentos", "setecentos", "oitocentos", "novecentos"};

                int n, d, u, c;

                Clear();

                WriteLine("Digite um numero entre (0-1000): ");
                n = int.Parse(ReadLine());

                if (n < 0 || n > 1000)
                {
                    WriteLine("Número fora da faixa");
                }
                else if (n < 20)
                {
                    WriteLine(unidade[n]);
                }
                else if (n < 100)
                {
                    u = n / 10;
                    d = n % 10;

                    if (n >= 2)
                    {
                        WriteLine(dezena[u]);

                        if (d != 0)
                        {
                            WriteLine(unidade[d]);
                        }
                    }
                    else
                    {
                        WriteLine(unidade[n]);
                    }
                }
                else if (n == 100)
                {
                    Write("Cem");
                }
                else if (n == 1000)
                {
                    Write("Mil");
                }
                else if (n < 1000)
                {
                    c = n / 100;
                    d = n % 100;
                    u = d / 10;
                    d = d % 10;

                    WriteLine(centena[c]);

                    if (u >= 2)
                    {
                        Write(" e " + dezena[u]);
                        if (d != 0)
                        {
                            Write(" e " + unidade[d]);
                        }
                    }
                    else
                    {
                        if (u == 1)
                        {
                            Write(" e " + unidade[10 + d]);
                        }
                        else if (d != 0)
                        {
                            Write(" e " + unidade[d]);
                        }
                    }
                }//fim
            } while (continuar() == "s");
        }//fim programa
        static void Fim()
        {
            WriteLine("");
        }
    }//fim programa

}//fim projeto