using System;

namespace Aula15TryCatch
{
    public class Permissao
    {
        public bool Permitir { get; set; }

        public void Autorizar(){
            Console.WriteLine("Deseja permitir o acesso? Digite true ou false para continuar");
            try{
              Permitir = Boolean.Parse (Console.ReadLine());  
            }catch(Exception){
                Console.WriteLine("Erro na aplicação: dados inválidos");
            }
        }
    }
}