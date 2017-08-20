namespace EventMailingSystem
{
    public interface IEmployee:IData
    {
        int EmpId { get;}
        string Name { get; }
        string EmailId { get; }
        System.DateTime DateOfJoining { get; }
        System.DateTime DateOfBirth { get; }
    }
}