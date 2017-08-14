namespace HRMS
{
    public interface IDataProvider
    {
        IDataProvider XmlDataProvider { get; set; }
        IDataProvider JsonDataProvider { get; set; }
    }
}