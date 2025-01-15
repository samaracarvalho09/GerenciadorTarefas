﻿namespace GerenciadorTarefas.Communication.Responses;

public class TasksJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Priority { get; set; } = string.Empty;
    public DateTime FinishTaskUntil { get; set; }
    public string Status { get; set; } = string.Empty;
}
