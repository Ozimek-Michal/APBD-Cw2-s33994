namespace APBD_CW2.DomainModels.Users;

public class Employee : User
{
    public override int GetMaxRentals() => 5;
}