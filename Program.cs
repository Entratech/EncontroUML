using System;
using System.Threading;

namespace Encontroremoto
{
    class Program
    {   
static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(@$"
==========================================
|    Bem vindo ao sistema de cadastro    |
|     de pessoa física e pessoa jurídica |
==========================================    
");

            BarraCarregamento("Iniciando");

                string opcao;

            do
            {
                Console.WriteLine(@$"
======================================
|            1 - Pessoa Física       |
|            2 - Pessoa Jurìdica     |
|                                    |
|            0 - Sair                |
======================================
");
            opcao = Console.ReadLine();
            
            switch (opcao)
            {
                case "1":
                
                Endereco endPF = new Endereco();

            endPF.logradouro = "Rua Salvador Bercari";
            endPF.numero = 7;
            endPF.complemento = "Na rua da auto escola";
            endPF.enderecoComercial = false;

            PessoaFisica novapf = new PessoaFisica();

            novapf.endereco = endPF;
            novapf.cpf="123456789";
            novapf.rendimento = 1500;
            novapf.dataNascimento = new DateTime(2001,08,11);
            novapf.nome = "João Vitor";

            

            PessoaFisica pf = new PessoaFisica();
           // pf.ValidarDataNascimento(pf.dataNascimento);

           Console.WriteLine(pf.PagarImposto(novapf.rendimento).ToString("N2"));

            bool idadeValida = pf.ValidarDataNascimento(novapf.dataNascimento);
            Console.WriteLine(idadeValida);

            if(idadeValida == true)
            {
                Console.WriteLine($"Cadastro aprovado");
            }
            else
            {
                Console.WriteLine($"Cadastro recusado");
            }
                    break;
                   
                    case "2": 
            
            
            PessoaJuridica pj = new PessoaJuridica();

            PessoaJuridica novapj = new PessoaJuridica();
           
            Endereco endPJ = new Endereco();

            endPJ.logradouro = "Rua Salvador Bercari";
            endPJ.numero = 7;
            endPJ.complemento = "Na rua da auto escola";
            endPJ.enderecoComercial = true;

            novapj.endereco = endPJ;
            novapj.cnpj = "1234567890001";
            novapj.razaoSocial = "Pessoa Juridica";
            novapj.rendimento = 8000;
            

            Console.WriteLine(pj.PagarImposto(novapj.rendimento).ToString("N2"));

            if (pj.ValidarCNPJ(novapj.cnpj))
            {
                Console.WriteLine("CNPJ válido");
            }
            else
            {
                Console.WriteLine("CNPJ Inválido");
            }
                    break;
                    
                        case "0":
                        
                        Console.WriteLine("Obrigado por utilizar o nosso sistema");
                        BarraCarregamento("Finalizando");
                        break;

                        default:
                         Console.WriteLine($"Opção inválida, digite uma opção válida");
                                
                        break;
            
            
            }
            
            } while (opcao != "0");
            
            

        

    static void BarraCarregamento(string textoCarregamento)
    {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(textoCarregamento);
            Thread.Sleep(500);
            

            for (var contador = 0; contador < 10; contador++)
            {           
                Console.Write($".");
                Thread.Sleep(500);
            }
            Console.ResetColor();
        }
            }
                } 
}  
