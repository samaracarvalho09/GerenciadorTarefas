using GerenciadorTarefas.Communication.Enums;

namespace GerenciadorTarefas.Communication.Requests;

public class RequestRegisteredTasksJson
{
    public string Name { get; set; } = string.Empty;
    public TasksPriority Type { get; set; }

    public TasksStatus Status { get; set; }
}
