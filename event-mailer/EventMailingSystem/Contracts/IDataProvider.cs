namespace EventMailingSystem
{
    public interface IDataProvider
    {
        IDetail GetDetail(string filePath);
    }
}