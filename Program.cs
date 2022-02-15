using System;
namespace Encontroremoto
{
    class Program
    {   
static void Main(string[] args)
        {
            // Endereco end = new Endereco();
            // end.logradouro = "X";
            // end.numero = 100;
            // end.complemento = "Próximo ao Senai";
            // end.enderecoComercial = false;

            // PessoaFisica novapf = new PessoaFisica();

            // novapf.endereco = end;
            // novapf.cpf = "123456789";
            // novapf.dataNascimento = new DateTime(2001,08,11);
            // novapf.nome = "João";

            // PessoaFisica pf = new PessoaFisica();
            // bool idadeValida = pf.ValidarDataNascimento(novapf.dataNascimento);

            // if (idadeValida == true)
            // {
            //     Console.WriteLine($"Cadastro Aprovado.");
            // }
            // else
            // {
            //     Console.WriteLine($"Cadastro Não Aprovado.");
            // }
            
            // pf.ValidarDataNascimento(pf.dataNascimento);
            // Console.WriteLine(pf.ValidarDataNascimento(novapf.dataNascimento));
            
            // Console.WriteLine(novapf.endereco.logradouro);
            // Console.WriteLine(novapf.endereco.numero);
            // Console.WriteLine(novapf.endereco.complemento);
            // Console.WriteLine(novapf.endereco.enderecoComercial);
            // Console.WriteLine($"Rua: {novapf.endereco.logradouro}, {novapf.endereco.numero}");
            // Console.WriteLine("Rua: " + novapf.endereco.logradouro + novapf.endereco.numero)

            Endereco end = new Endereco();

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
                Console.WriteLine($"Cadastro recusado");
            }

  }

    }
        }

