﻿using System;
using System.Collections.Generic;

class pilha_stack
{
    private Stack<string> pilha = new Stack<string>();

    public void Push(string valor)
    {
        pilha.Push(valor);
    }

    public string Pop()
    {
        if (pilha.Count == 0)
        {
            Console.WriteLine("A pilha está vazia. Não é possível realizar a operação Pop.");
            return null;
        }
        return pilha.Pop();
    }

    public string Peek()
    {
        if (pilha.Count == 0)
        {
            Console.WriteLine("A pilha está vazia. Não é possível realizar a operação Peek.");
            return null;
        }
        return pilha.Peek();
    }

    public bool IsEmpty()
    {
        return pilha.Count == 0;
    }

    public void PrintStack()
    {
        if (pilha.Count == 0)
        {
            Console.WriteLine("A pilha está vazia.");
            return;
        }

        Console.WriteLine("Conteúdo da Pilha:");
        foreach (var valor in pilha)
        {
            Console.WriteLine(valor);
        }
    }
}

class Program
{
    static void Main()
    {
        pilha_stack pilha_stack = new pilha_stack();

        // Adicionando valores à pilha
        pilha_stack.Push("valor 1");
        pilha_stack.Push("valor 2");
        pilha_stack.Push("valor 3");

        // Exibindo conteúdo da pilha
        Console.WriteLine("Inicial da Pilha:");
        pilha_stack.PrintStack();

        // Realizando operações Pop e Peek
        string popResult = pilha_stack.Pop();
        Console.WriteLine($"Removido (Pop): {popResult}");

        string peekResult = pilha_stack.Peek();
        Console.WriteLine($"Topo (Peek): {peekResult}");

        // Exibindo conteúdo da pilha após operações
        Console.WriteLine("Pilha Atual:");
        pilha_stack.PrintStack();
    }
}