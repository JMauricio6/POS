namespace POS.Infraestructure.Persistences.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //Declaracion o matricula de nuestras interfaces a nivel de repository

        ICategoryRepository Category { get; }

        void SaveChanges();

        Task SaveChangesAsync();

    }
}
