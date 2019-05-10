using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    private static List<Stylist> _instances = new List<Stylist>{};
    private string _name;
    private int _stylistId;
    private List<Client> _clients;

    public Stylist (string stylistName)
    {
      _name = stylistName;
      _instances.Add(this);
      _stylistId = _instances.Count;
      _clients = new List<Client>{};
    }
    public string GetStylistName()
    {
      return _name;
    }
    public int GetStylistId()
    {
      return _stylistId;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Stylist> GetAll()
    {
      return _instances;
    }
    public static Stylist Find(int searchStylistId)
    {
      return _instances [searchStylistId-1];
    }
    public List<Client> GetClient()
    {
      return _clients;
    }
    public void AddClient(Client client)
    {
      _clients.Add(client);
    }
  }
}
