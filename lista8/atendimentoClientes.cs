using System;
using System.Collections.Generic;
using System.Linq; // Adicione esta diretiva

public class AtendimentoClientes
{
    private List<int> caixas = new List<int>();
    private List<DateTime> horariosDeTermino = new List<DateTime>();
    public int numFuncionario = 3;
    public List<string> funcionarios = new List<string>();

    // Inicia o atendimento
    public void IniciarAtendimento(List<string> filaClientes, DateTime horario)
    {
        for(int i = 0; i < numFuncionario; i++)
        {
            caixas.Add(0);
            horariosDeTermino.Add(horario);
            funcionarios.Add("Funcionario " + (i+1));
        }
        
        Console.WriteLine("\nIniciando atendimento:\n");// inicia atendedimento

        while (filaClientes.Count > 0)
        {
            for (int i = 0; i < numFuncionario && filaClientes.Count > 0; i++)
            {
                string funcionario = funcionarios[i]; // Obtém o nome do funcionário

                if (caixas[i] == 0 && filaClientes.Count > 0)
                {
                    string cliente = filaClientes[0];
                    filaClientes.RemoveAt(0);
                    Console.WriteLine($"{horario}, {funcionario} chamando {cliente}");
                    caixas[i] = 1;
                }
            }
            // termina atendimento
            for (int i = 0; i < numFuncionario; i++)
            {
                string funcionario = funcionarios[i];

                if (i < caixas.Count && caixas[i] > 0)
                {
                    if (caixas[i] == 1)
                    {
                        int tempoAtendimento = TempoGasto();
                        horariosDeTermino[i] = horariosDeTermino[i].AddSeconds(tempoAtendimento);
                        Console.WriteLine($"\n{funcionario} terminou de atender e está livre.\nTempo gasto {tempoAtendimento}\nHora atual: {horariosDeTermino[i]}\n");
                        caixas[i] = 0;
                    }
                }
            }
            // Espera 1 segundo para simular a passagem do tempo
            System.Threading.Thread.Sleep(1000);
            horario = horario.AddSeconds(1);
        }
        Console.WriteLine("Todos os clientes foram atendidos.");
    }
    // Gera um tempo gasto aleatoriamente para atendimento
    private int TempoGasto()
    {
        Random random = new Random();
        return random.Next(5, 20); // Tempo de atendimento aleatório entre 5 e 20 segundos
    }
}