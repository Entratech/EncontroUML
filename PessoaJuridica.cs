using System;

namespace Encontroremoto
{
    public class PessoaJuridica : Pessoa
    {
        public string? cnpj { get; set; }
        
        public string? razaoSocial { get; set; }

        public override double PagarImposto(float rendimento)
        {
            if(rendimento <= 5000){
                
                return rendimento * (6 / 100);
            }
            else if(rendimento >= 5000 && rendimento <= 10000)
            {
                return rendimento * (8 / 100);
            }
            else
            {
                return rendimento * (10 /100);
            }

        }   

        
            public bool ValidarCNPJ(string cnpj){
                if(cnpj.Length<=14 && cnpj.Substring(cnpj.Length - 4) == "0001")
                {
                    return true;
                }
                     {
                      return false;
                     }
            }
        
    
        
        
        
    }
}