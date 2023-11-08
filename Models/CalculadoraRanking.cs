using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CalculadoraPartirdasRankeadas.Models
{
    public class CalculadoraRanking
    {
        public int vitoria { get; set; }
        public int derrota { get; set; }

        public int saldoVitorias { get; set; }

        public void CalcularRanking()
        {
            saldoVitorias = vitoria - derrota;
        }


        public void CalcularNivel()
        {
            string nivel;
            if (saldoVitorias < 10)
            {
                nivel = "Ferro";
                Console.WriteLine($"O Herói tem saldo de {saldoVitorias} e está no nível {nivel}.");
            }
            else if (saldoVitorias > 10 && saldoVitorias < 21)
            {
                nivel = "Bronze";
                Console.WriteLine($"O Herói tem saldo de {saldoVitorias} e está no nível {nivel}.");
            }
            else if (saldoVitorias >= 11 && saldoVitorias <= 20)
            {
                nivel = "Bronze";
                Console.WriteLine($"O Herói tem saldo de {saldoVitorias} e está no nível {nivel}.");
            }
            else if (saldoVitorias >= 21 && saldoVitorias <= 50)
            {
                nivel = "Prata";
                Console.WriteLine($"O Herói tem saldo de {saldoVitorias} e está no nível {nivel}.");
            }
            else if (saldoVitorias >= 51 && saldoVitorias <= 80)
            {
                nivel = "Ouro";
                Console.WriteLine($"O Herói tem saldo de {saldoVitorias} e está no nível {nivel}.");
            }
            else if (saldoVitorias >= 81 && saldoVitorias <= 90)
            {
                nivel = "Diamante";
                Console.WriteLine($"O Herói tem saldo de {saldoVitorias} e está no nível {nivel}.");
            }
            else if (saldoVitorias > 91 && saldoVitorias <= 100)
            {
                nivel = "Lendário";
                Console.WriteLine($"O Herói tem saldo de {saldoVitorias} e está no nível {nivel}.");
            }
            else

                nivel = "Imortal";
            Console.WriteLine($"O Herói tem saldo de {saldoVitorias} e está no nível {nivel}.");


        }
    }
}

