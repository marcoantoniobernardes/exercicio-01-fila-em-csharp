using System;
using System.Collections.Generic;

public class Cliente
{
    public int numCliente = 0;
    
    public List<string> gerarFila()
    {
        List<string> minhaLista = new List<string>();
        
        Random random = new Random();
        numCliente = random.Next(5, 10);
        
        for(int i = 0; i <= numCliente; i++)
        {
            minhaLista.Add("Cliente " + (i+1));
        }
        return minhaLista;
    }
    

}