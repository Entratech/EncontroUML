using System;
namespace Encontroremoto
{
    class Program
    {   
static void Main(string[] args)
        {

          /*  Endereco end = new Endereco();

            end.logradouro = "Rua Salvador Bercari";
            end.numero = 7;
            end.complemento = "Na rua da auto escola";
            end.enderecoComercial = false;

            PessoaFisica novapf = new PessoaFisica();

            novapf.endereco = end;
            novapf.cpf="123456789";
            novapf.dataNascimento = new DateTime(2001,08,11);
            novapf.nome = "João Vitor";

            PessoaFisica pf = new PessoaFisica();
            pf.ValidarDataNascimento(pf.dataNascimento);

            bool idadeValida = pf.ValidarDataNascimento(novapf.dataNascimento);
            Console.WriteLine(idadeValida);

            if(idadeValida == true)
            {
                Console.WriteLine($"Cadastro aprovado");
            }
            else
            {
                Console.WriteLine($"Cadastro recusado"); */
             PessoaJuridica pj = new PessoaJuridica();

             PessoaJuridica novapj = new PessoaJuridica();
           
            Endereco end = new Endereco();

            end.logradouro = "Rua Salvador Bercari";
            end.numero = 7;
            end.complemento = "Na rua da auto escola";
            end.enderecoComercial = true;

            novapj.endereco = end;
            novapj.cnpj = "1234567890001";
            novapj.razaoSocial = "Pessoa Juridica";
            
            if (pj.ValidarCNPJ(novapj.cnpj))
            {
                Console.WriteLine("CNPJ válido");
            }
            else
            {
                Console.WriteLine("CNPJ Inválido");
            }
             } 
        }

    }
        

