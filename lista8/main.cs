/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
using System.Collections.Generic;

class HelloWorld {
  static void Main() {
    // iniciando as classes
    Cliente cliente = new Cliente();
    AtendimentoClientes atendimento = new AtendimentoClientes();
    
    // variaveis 
    DateTime horario;
    List<string> filaClientes = new List<string>();
    
    //gerar clientes
    filaClientes = cliente.gerarFila();
    //inicia turno quantos funcionario estao presentes
    horario = Hora.ObterHoraAtual();
    //Inicia lista espera
    for(int i = 0; i < cliente.numCliente; i++)
    {
        Console.WriteLine($"{horario}, {filaClientes[i]} entrou na fila de espera ");
    }
    atendimento.IniciarAtendimento(filaClientes, horario);
    
    
    
  }
}
