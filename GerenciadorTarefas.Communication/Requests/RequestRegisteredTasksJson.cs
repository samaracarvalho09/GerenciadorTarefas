using GerenciadorTarefas.Communication.Enums;

namespace GerenciadorTarefas.Communication.Requests;

public class RequestRegisteredTasksJson
{
    public string Name { get; set; } = string.Empty;
    public TaskPriority Type { get; set; }
}
