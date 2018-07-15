using System;
public class Sospitos
{
    public Sospitos(string id, String nom)
    {
        Id = id;
        Nom = nom;
    }
    public string Id { get; set; }
    public string Nom { get; set; }

    public override bool Equals(Object obj)
    {
        // Check for null values and compare run-time types.
        if (obj == null || GetType() != obj.GetType())
            return false;

        Sospitos p = (Sospitos)obj;
        return (Id == p.Id);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}