using System;
using System.Collections.Generic;

public class Hora
{
    public static DateTime ObterHoraAtual()
    {
        // Obter o horário atual UTC (Tempo Universal Coordenado)
        DateTime horarioAtualUTC = DateTime.UtcNow;

        // Definir o deslocamento para o horário de Brasília (GMT-3)
        TimeSpan deslocamentoBrasilia = TimeSpan.FromHours(-3);

        // Calcular o horário de Brasília
        DateTime horarioBrasilia = horarioAtualUTC + deslocamentoBrasilia;

        // Retornar o horário de Brasília
        return horarioBrasilia;
    }
}