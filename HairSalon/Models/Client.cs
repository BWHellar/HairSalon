using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
  public class Client
  {

    private string _name;
    public string Name { get { return _name;} }

    private int _id;
    public int Id { get { return _id;} set { _id = value;} }

    private int _stylistId;
    public int StylistId { get { return _stylistId;} set { _stylistId =value;} }

    public Client (string name, int id = 0, int stylistId = 0)
    {
      _name = name;
      _id = id;
      _stylistId = stylistId;
    }

    public override bool Equals(object obj)
    {
      if(!(obj is Client)) return false;
      else
      {
        Client client = (Client) obj;
        return client.Name == this.Name && client.Id == this.Id;
      }
    }
  }
}
