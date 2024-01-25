namespace ASP.NET_Core.Models.Interfaces
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie? GetPieById(Int32 id);
    }
}
