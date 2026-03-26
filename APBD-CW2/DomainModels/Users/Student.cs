namespace APBD_CW2.DomainModels.Users;

public class Student : User
{
    public override int GetMaxRentals() => 2;
}