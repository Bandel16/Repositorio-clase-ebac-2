using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Ejerciciosestructuras : MonoBehaviour
{
    int[] arreglo1=new int[4] { 8,5,7,2};
    HashSet<string> ejercicio3 = new HashSet<string>();
    Queue<string> colaFrases = new Queue<string>();
    Stack<string> pilaFrases = new Stack<string>();
    // Start is called before the first frame update
    void Start()
    {
        //Act1
        var Lista1 = Actividad1(5, 10, 25);
        foreach (var i in Lista1)
        {
            Debug.Log(i);
        }

        //Act2
        int[]arregloOrdenado= Actividad2(arreglo1);
        foreach(var i in arregloOrdenado)
        {
            Debug.Log(i.ToString());
        }

        //Act3
        HashSet<string> ejercicio3 = Actividad3();
        foreach(var frase in ejercicio3)
        {
            Debug.Log(frase);
        }

        //Act4
        Stack<string> pilaFrases = Actividad4();
        List<string>temporal = new List<string>();
        while(pilaFrases.Count > 0)
        {
            Debug.Log(pilaFrases.Peek());
            string frase=pilaFrases.Peek();
            temporal.Add(frase);
            pilaFrases.Pop();
            
        }
        temporal.Reverse();
        foreach (var x in temporal)
        {
            colaFrases.Enqueue(x);
        }

        foreach(var y in colaFrases)
        {
            Debug.Log(y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public List<int> Actividad1(int num1,int num2,int num3)
    {
        List<int> primeraLista=new List<int>();
        for (int i = 0; i < num1; i++)
        {
            primeraLista.Add(Random.Range(num2,num3));
        }
        return primeraLista;
    }

    public int[] Actividad2(int[]numeros)
    {
        return numeros.OrderByDescending(x => x).ToArray();
    }

    public HashSet<string> Actividad3()
    {
        HashSet<string> result = new HashSet<string>();
        result.Add("Mario");
        result.Add("Link");
        result.Add("Samus");
        result.Add("Fox");
        result.Add("Samus");

       

        return result;
    }

    //Crea una función que reciba una pila de strings, imprime sus contenidos y llena con ellos una cola de strings y ahora imprime los
    //elementos de la cola utilizando los métodos respectivos de cada estructura (push, pop, queue, dequeue y peek), puedes copiar los elementos de
    //la pila a la cola en el mismo uso del peek, esta función no retornará nada, solo imprimirá los valores en la consola.

    public Stack<string> Actividad4() {
        Stack<string> pilaStrings = new Stack<string>();
        
        pilaStrings.Push("Metroid");
        pilaStrings.Push("Metal Gear");
        pilaStrings.Push("Persona");
        pilaStrings.Push("Halo");
        pilaStrings.Push("Portal");
        return pilaStrings;
    }
}
