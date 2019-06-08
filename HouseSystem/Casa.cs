using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseSystem
{
    class Casa : IDivulga, IContabil
    {

        public String endereco { get; set; }
        public String proprietario { get; set; }
        public float valor { get; set; }
        public Comodo cozinha { get; set; }
        public List<Comodo> banheiros { get; set; }
        public Comodo sala { get; set; }
        public List<Comodo> quartos { get; set; }

        public Casa()
        {
            cozinha = new Cozinha();
            banheiros = new List<Comodo>();
            sala = new Sala();
            quartos = new List<Comodo>();
        }

        public float calculaIPTU()
        {
            return (float)(valor * 0.01) + 300; ;
        }

        public void mostraInfos()
        {
            Console.WriteLine("Informações do Imóvel");
            Console.WriteLine("Endereço: " + endereco);
            Console.WriteLine("Proprietário: " + proprietario);
            Console.WriteLine("Valor: " + valor);
            int countBanheiros = 0;
            int countQuartos = 0;
            foreach(Banheiro banheiro in banheiros)
            {
                countBanheiros++;
                Console.WriteLine("O banheiro " + countBanheiros + " Possui Chuveiro? " + (banheiro.temChuveiro == true ? "SIM" : "NÃO"));
                Console.WriteLine("O banheiro " + countBanheiros + " Possui Espelho? " + (banheiro.temEspelho == true ? "SIM" : "NÃO"));
                Console.WriteLine("O banheiro " + countBanheiros + " Possui Vaso Sanitário? " + (banheiro.temVasoSanitario == true ? "SIM" : "NÃO"));
                Console.WriteLine("O banheiro " + countBanheiros + " Possui " + banheiro.comprimento + " de comprimento.");
                Console.WriteLine("O banheiro " + countBanheiros + " Possui " + banheiro.largura + " de largura.");
            }
            foreach (Quarto quarto in quartos)
            {
                countQuartos++;
                Console.WriteLine("O quarto " + countQuartos + " Possui Armário Embutido? " + (quarto.temArmarioEmbutido == true ? "SIM" : "NÃO"));
                Console.WriteLine("O quarto " + countQuartos + " Possui Suite? " + (quarto.temSuite == true ? "SIM" : "NÃO"));
                Console.WriteLine("O quarto " + countQuartos + " Possui " + quarto.comprimento + " de comprimento.");
                Console.WriteLine("O quarto " + countQuartos + " Possui " + quarto.largura + " de largura.");
            }
            Console.WriteLine("O Sala Possui Painel? " + (((Sala)sala).temPainel == true ? "SIM" : "NÃO"));
            Console.WriteLine("O Sala Possui " + cozinha.comprimento + " de comprimento.");
            Console.WriteLine("O Sala Possui " + cozinha.largura + " de largura.");

            Console.WriteLine("O Cozinha Possui Geladeira? " + (((Cozinha)cozinha).temGeladeira == true ? "SIM" : "NÃO"));
            Console.WriteLine("O Cozinha Possui " + ((Cozinha)cozinha).numArmarios + " Armários");
            Console.WriteLine("O Cozinha Possui " + cozinha.comprimento + " de comprimento.");
            Console.WriteLine("O Cozinha Possui " + cozinha.largura + " de largura.");
        }
    }
}
