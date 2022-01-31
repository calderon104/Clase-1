public class User
{
    public  String Name { get; set; }
    public string Surname { get; set; }


public User()
{
    
}
public User (string name, string surname)
{
    Name = name;
    Surname = surname;  
}
public String FullName()
{
    return $"{Name} {Surname}";
}
}
public class Yo{
    public string Pais { get; set; }
    public string Ciudad { get; set; }
    public string DondeVive(){
        return $"{Pais} {Ciudad}";

    }
}