using System.Threading.Tasks;

namespace GerenciadorTarefas.Communication.Responses;

public class ResponseTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Priority { get; set; } = string.Empty; //  Ex.: "alta", "média" ou "baixa"
    public DateTime FinishTaskUntil { get; set; }
    public string Status { get; set; } = string.Empty;  // Ex.: "concluída", "em andamento" ou "aguardando"

}


    