using GerenciadorTarefas.Communication.Enums;

namespace GerenciadorTarefas.Communication.Responses;

public class TasksJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TasksPriority Priority { get; set; } // utilizando o ENUM
    public TasksStatus Status { get; set; }
    public DateTime FinishTaskUntil { get; set; }

}
