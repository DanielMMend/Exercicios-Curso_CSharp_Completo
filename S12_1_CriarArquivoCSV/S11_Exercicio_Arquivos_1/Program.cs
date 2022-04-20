using System.IO;
using System.Globalization;
using System.Collections.Generic;
using S11_Exercicio_Arquivos_1.Entities;

namespace S11_Exercicio_Arquivos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Endereço do arquivo "file.txt", contendo os dados dos produtos.
            string sourcePath = @"C:\Users\danie\source\repos\Curso CSharp Completo - Exercicios\S12_1_CriarArquivoCSV\S11_Exercicio_Arquivos_1\File\file.txt";
            //Cria uma pasta "Out" dentro da pasta onde o arquivo "file.txt" está localizado.
            Directory.CreateDirectory(@"C:\Users\danie\source\repos\Curso CSharp Completo - Exercicios\S12_1_CriarArquivoCSV\S11_Exercicio_Arquivos_1\File\Out");
            //Endereço para criar o arquivo "summary.csv", que é o obejtivo do exercicio.
            string targetPatch = @"C:\Users\danie\source\repos\Curso CSharp Completo - Exercicios\S12_1_CriarArquivoCSV\S11_Exercicio_Arquivos_1\File\Out\summary.csv";

            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(sourcePath))
            {
                while (sr.EndOfStream == false)
                {
                    string[] s = sr.ReadLine().Split(',');
                    string pName = s[0];
                    double pPrice = double.Parse(s[1], CultureInfo.InvariantCulture);
                    int pAmount = int.Parse(s[2]);

                    Product p = new Product(pName, pPrice, pAmount);
                    list.Add(p);
                }
            }

            using (StreamWriter sw = File.AppendText(targetPatch))
            {
                foreach (Product p in list)
                {
                    sw.WriteLine($"{p.Name},{(p.Price * p.Amount).ToString("F2", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}
