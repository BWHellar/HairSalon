using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    private string _name;
    public string Name { get { return _name;} }

    private int _id;
    public string Name { get { return _id;} }

    public Stylist (string name, int id = 0)
    {
      _name = name;
      _id = id;
    }

    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"INSERT INTO stylist (name) VALUES (@this.Name);";
      MySqlParameter thisName = new MySqlParameter ("@thisName", this.Name);
      cmd.Parameters.Add(thisName);

      cmd.ExecuteNonQuery();
      this._id = (int) cmd.LastInsertedId;

      conn.Close();
      if(conn!=null) {conn.Dispose();}
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Stylist> GetAll()
    {
      return _instances;
    }
    public static Stylist Find(int _searchId)
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();

      MySQlCommand cmd = conn.CreateCommand() as MySqlCommand;
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
