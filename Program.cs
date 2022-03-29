using System;

namespace Calculo_Media
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] notas = new float[4];
            float media = 0;
            int i =  0; //contador
            //Lendo as 4 notas
            for(i = 0; i < 4; i++)
            {
                Console.Write($"Digite a {i+1}ª nota: ");
                notas[i] = float.Parse(Console.ReadLine());
            }
            //calculando media
      
            for(i = 0; i < 4; i++)
                media += notas[i];
            media = media / 4;
            Console.WriteLine($"\nMEDIA: {media}");

            //Verificando se o aluno passou
            if (media < 6)
                Console.WriteLine("ALUNO REPROVADO !!");
            if (media >= 6 && media < 8)
                Console.WriteLine("ALUNO APROVADO!! SÓ QUE É MEDIOCRE");
            if (media >= 8 && media <= 9)
                Console.WriteLine("ALUNO APROVADO !! ELE É BOM");
            if(media > 9)
                Console.WriteLine("ALUNO APROVADO !! ELE É FERA");







        }
    }
}
