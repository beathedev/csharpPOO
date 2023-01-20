using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_List
{
    public class Casa
    {
        public int Tamanho { get; set; }
        public String Cor { get; set; }    
        public int QuantidadeDePortas { get; set; }
        public int QuantidadeDeJanelas { get; set; }    
        public decimal ValorCasa { get; set; }
        public bool CasaAlugada { get; set; }
 
        public Endereco EnderecoCasa { get; set; }

        public static int QuantidadeDeMoradores { get; set; }


        //Construtores
        public Casa()
        {
            
        }

        public Casa(int largura, int comprimento, string cor, int quantidadeDePortas, int quantidadeDeJanelas, decimal valorCasa)
        {
            Tamanho = CalcularArea(largura, comprimento);
            Cor = cor;
            QuantidadeDePortas  = quantidadeDePortas;
            QuantidadeDeJanelas = quantidadeDeJanelas;
            ValorCasa = valorCasa;
        }


        // Metódos
        public void VenderCasa()
        {
            Console.WriteLine("A casa foi vendida.");

        }

        public void AlugarCasa()
        {
            Console.WriteLine("A casa foi alugada.");
        }

        public int CalcularArea(int largura, int comprimento) 
        {
            Tamanho = largura * comprimento;
            return Tamanho;
        }

        public void InformacaoSobreCasa()
        {
            Console.Clear();
            Console.WriteLine("- - - - - - - - - - - - - - ");
            Console.WriteLine($"Tamanho da casa:    {Tamanho}");
            Console.WriteLine($"Cor da casa:    {Cor}");
            Console.WriteLine($"Quantidade de portas da casa:    {QuantidadeDePortas}");
            Console.WriteLine($"Quantidade de janelas da casa:    {QuantidadeDeJanelas}");
            Console.WriteLine($"Valor da casa:    {ValorCasa}");
            Console.WriteLine($"Endereco da casa:    {EnderecoCasa.Rua}, {EnderecoCasa.Numero} - {EnderecoCasa.Bairro}, {EnderecoCasa.Cep}.");
            Console.WriteLine($"Tipo de rua:    {EnderecoCasa.TipoRuaEnum}");
            Console.WriteLine("- - - - - - - - - - - - - - ");
            

        }

    }
}