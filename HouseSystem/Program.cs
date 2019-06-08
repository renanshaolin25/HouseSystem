using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Casa casa = new Casa();
            casa.proprietario = "Renan Ribeiro";
            casa.endereco = "Rua Quito Carneiro, 32, bairro Inatel, Cidade Santa Rita";
            casa.valor = 200000;

            Quarto quarto1 = new Quarto();
            quarto1.comprimento = 3;
            quarto1.largura = 4;
            quarto1.temSuite = true;
            quarto1.temArmarioEmbutido = true;
            Quarto quarto2 = new Quarto();
            quarto1.comprimento = 4;
            quarto1.largura = 5;
            quarto1.temSuite = false;
            quarto1.temArmarioEmbutido = false;

            Banheiro banheiro1 = new Banheiro();
            banheiro1.comprimento = 2;
            banheiro1.largura = 3;
            banheiro1.temChuveiro = true;
            banheiro1.temEspelho = true;
            banheiro1.temVasoSanitario = true;
            Banheiro banheiro2 = new Banheiro();
            banheiro2.comprimento = 3;
            banheiro2.largura = 3;
            banheiro2.temChuveiro = true;
            banheiro2.temEspelho = false;
            banheiro2.temVasoSanitario = true;

            casa.sala.comprimento = 5;
            casa.sala.largura = 7;
            ((Sala)casa.sala).temPainel = true;

            casa.cozinha.comprimento = 4;
            casa.cozinha.largura = 5;
            ((Cozinha)casa.cozinha).numArmarios = 3;
            ((Cozinha)casa.cozinha).temGeladeira = true;

            casa.quartos.Add(quarto1);
            casa.quartos.Add(quarto2);
            casa.banheiros.Add(banheiro1);
            casa.banheiros.Add(banheiro2);

            casa.mostraInfos();
            Console.WriteLine("O valor do IPTU é: " + casa.calculaIPTU());

            Console.Read();
        }
    }
}
