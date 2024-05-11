using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Treino.Models
{
    public class Treino
    {
         List<string> treino = new List<string>();
        Random random= new Random();
        public void AddTreino(){
         
        treino.Add("Peito");
        treino.Add("Bicips");
        treino.Add("Tricips");
        treino.Add("Costa");
        treino.Add("Ombro/Deltoide");
        treino.Add("Perna/Panturrilha");
        }

        public void VamosTreinar (){
           while(true){
            Console.WriteLine("Vamos Treinar!");
            Console.WriteLine("Digite: 1 para sortear seu treino.");
            Console.WriteLine("Digite: 2 para Cancelar.");
            Console.Write("Opção: ");

            string escolha = Console.ReadLine();

            if (escolha == "1"){
                if (treino.Count == 0){
                    Console.WriteLine("Todas os treinos ja fora feitos. Fim de treino!");
                    break;
                }
                int aleatorio = random.Next(0, treino.Count);
                string itemAleatorio = treino[aleatorio];
                treino.Remove(itemAleatorio);
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine(itemAleatorio);
                Console.WriteLine("------------------------------------------------------------");

            }  
            else if (escolha == "2"){
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("FIM DE JOGO!");
                Console.WriteLine("------------------------------------------------------------");
                break;
            }
            else {
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("Opção inválida.");
                Console.WriteLine("------------------------------------------------------------");
            }
           }
             }
    }
}