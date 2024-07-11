namespace Journey.Infrastructure.Entities;
public class Trip // espelho do banco de dados
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public IList<Activity> Activities { get; set; } = []; // uma viagem pode ter várias atividades, por isso é uma lista
}
