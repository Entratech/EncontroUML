using System;
using System.Threading;
using System.Collections.Generic;

namespace Encontroremoto
{
    class Program
    {   
static void Main(string[] args)
        {

            List<PessoaFisica> listaPF = new List<PessoaFisica>();

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
|   Escolha uma das opções abaixo    |  
|         PESSOA FÍSICA              |                               
|     1 - Cadastrar pessoa física    |
|     2 - Listar pessoa física       |  
|     3 - Remover pessoa física      |
|                                    |
|         PESSOA JURÍDICA            |
|     4 - Cadastrar pessoa jurídica  |
|     5 - Listar pessoa jurídica     |
|     6 - Remover pessoa jurídica    |
|                                    |
|              0 - Sair              |
======================================
");
            opcao = Console.ReadLine();
            
            switch (opcao)
            {
                case "1":
                
                Endereco endPF = new Endereco();

            Console.WriteLine($"Digite seu logradouro");
            endPF.logradouro = Console.ReadLine();

            Console.WriteLine($"Digite o número");
            endPF.numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o complemento (aperte ENTER para vazio");
            endPF.complemento = Console.ReadLine();

            Console.WriteLine($"Este endereço é comercial S/N");
            string endComercial = Console.ReadLine().ToUpper();
            
            if (endComercial == "S")
            {
                endPF.enderecoComercial = true;
            }
            else
            {
                endPF.enderecoComercial = false;
            }

            PessoaFisica novapf = new PessoaFisica();
            
           Console.WriteLine($"Digite seu CPF (somente números");
           novapf.cpf = Console.ReadLine();
           
           Console.WriteLine($"Digite seu nome");
           novapf.nome = Console.ReadLine();
         
           Console.WriteLine($"Digite sua data de nascimento");
           novapf.dataNascimento = DateTime.Parse(Console.ReadLine());
            

            

            PessoaFisica pf = new PessoaFisica();
           // pf.ValidarDataNascimento(pf.dataNascimento);

           Console.WriteLine(pf.PagarImposto(novapf.rendimento).ToString("N2"));

            bool idadeValida = pf.ValidarDataNascimento(novapf.dataNascimento);
            Console.WriteLine(idadeValida);

            if(idadeValida == true)
            {
                System.Console.WriteLine($"Cadastro aprovado");
                listaPF.Add(novapf);
                Console.WriteLine(pf.PagarImposto(novapf.rendimento));
                
            }
            else
            {
                Console.WriteLine($"Cadastro recusado");
            }
                    break;
                   
                    case "2":
                    foreach (var cadaItem in listaPF)
                    {
                        Console.WriteLine($"{cadaItem.nome}, {cadaItem.cpf}, {cadaItem.dataNascimento}");
                    }

                    break;

                    case "3":

                    Console.WriteLine($"Digite o CPF que deseja remover");
                    string cpfProcurado = Console.ReadLine();

                    PessoaFisica pessoaEncontrada = listaPF.Find(cadaItem => cadaItem.cpf == cpfProcurado);
                    
                    if (pessoaEncontrada != null)
                    {
                        listaPF.Remove(pessoaEncontrada);
                        Console.WriteLine($"Cadastro Removido");
                    }
                    else
                    {
                        Console.WriteLine($"CPF não encontrado");
                    }

                    break;
                    
                    case "4": 
            
            
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
