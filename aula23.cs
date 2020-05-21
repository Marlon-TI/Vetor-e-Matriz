using System;
class aula22{
    static void Main(){
        
        int[] vetor1=new int[50];
        int[] vetor2=new int[50];
        int[] vetor3=new int[50];
        int[,] matriz=new int [2,5]{{11,22,00,44,55},{66,77,88,99,00}};

        Random random=new Random();
        for (int i=0;i<vetor1.Length;i++){
            vetor1[i]=random.Next(50);
        }

        System.Console.WriteLine("Elementos do vetor1");
        foreach(int n in vetor1){
            System.Console.WriteLine(n);
        }
        
        System.Console.WriteLine("BinarySearch");
        int procurado=33;
        int pos=Array.BinarySearch(vetor1,procurado);
        System.Console.WriteLine("Valor {0} esta na posição {1}",procurado,pos);
        System.Console.WriteLine("----------------------------------------");

        System.Console.WriteLine("Copy");
        Array.Copy(vetor1,vetor2,vetor1.Length);
        foreach(int n in vetor2){
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine("----------------------------------------");

        System.Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3,0);
        foreach(int n in vetor3){
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine("----------------------------------------");

        System.Console.WriteLine("GetLongLength");
        long qtdeElementosVetor=vetor1.GetLongLength(0);
        System.Console.WriteLine("Quantidade de elementos {0}",qtdeElementosVetor);
        System.Console.WriteLine("----------------------------------------");

        System.Console.WriteLine("GetLowerBound");
        int menorIndiceVetor=vetor1.GetLowerBound(0);
        int menorIndiceMatriz_D1=matriz.GetLowerBound(1);
        System.Console.WriteLine("Menor indice do valor {0}", menorIndiceVetor);
        System.Console.WriteLine("Menor indice do valor {0}", menorIndiceMatriz_D1);
        System.Console.WriteLine("----------------------------------------");


        System.Console.WriteLine("GetUpperBound");
        int MaiorIndiceVetor=vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz=matriz.GetUpperBound(1);
        System.Console.WriteLine("Maior indice de Valor vetor 1 {0}",MaiorIndiceVetor);
        System.Console.WriteLine("Maior indice de Valor matriz 1 {0}",MaiorIndiceMatriz);
        System.Console.WriteLine("----------------------------------------");

        System.Console.WriteLine("GetValue");
        int valor0=Convert.ToInt32(vetor1.GetValue(3));
        int valor1=Convert.ToInt32(matriz.GetValue(1,3));
        System.Console.WriteLine("Valor da posição 3 do vetor1: {0}",valor0);
        System.Console.WriteLine("Valor da posição linha 2 coluna 4 do Matriz: {0}",valor1);
        System.Console.WriteLine("--------------------------------------------");

        System.Console.WriteLine("IndexOf");
        int indice1=Array.IndexOf(vetor1,3);
        System.Console.WriteLine("Indice do primeiro valor 3: {0}",indice1);
        System.Console.WriteLine("---------------------------------------");

        System.Console.WriteLine("LastIndexOf");
        int indice2=Array.LastIndexOf(vetor1,33);
        System.Console.WriteLine("Indice do Ultimo valor 33: {0}",indice2);
        System.Console.WriteLine("-----------------------------------");

        Array.Reverse(vetor1);
        foreach(int n in vetor1){
            System.Console.WriteLine(n);
        }

        vetor2.SetValue(99,0);
        for(int i=0;i<vetor2.Length;i++){
            vetor2.SetValue(0,i);
        }

        System.Console.WriteLine("Vetor 2");
        foreach(int n in vetor2){
            System.Console.WriteLine(n);
        }

        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);

        System.Console.WriteLine("Vetor 1");
        foreach(int n in vetor1){
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine("Vetor 2");
        foreach(int n in vetor2){
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine("Vetor 3");
        foreach(int n in vetor3){
            System.Console.WriteLine(n);
        }

        System.Console.WriteLine("BinarySearch");
        int procurado1=33;
        int pos1=Array.BinarySearch(vetor1,procurado1);
        System.Console.WriteLine("Valor {0} esta na posição {1}",procurado1,pos1);
        System.Console.WriteLine("----------------------------------------");

    }
}