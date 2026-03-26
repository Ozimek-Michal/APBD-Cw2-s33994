namespace APBD_CW2.DomainModels.Users;

public abstract class User
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public abstract int GetMaxRentals();
}
