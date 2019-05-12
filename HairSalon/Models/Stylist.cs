using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
  public class Stylist
  {
    private string _name;
    public string Name { get { return _name;} }

    private int _id;
    public int Id { get { return _id;} }

    public Stylist(string name, int id = 0)
    {
      _name = name;
      _id = id;
    }

    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();

      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"INSERT INTO stylist (name) VALUES (@thisName);";
      MySqlParameter name = new MySqlParameter("@thisName", this.Name);
      cmd.Parameters.Add(name);

      cmd.ExecuteNonQuery();
      this._id = (int) cmd.LastInsertedId;

      conn.Close();
      if(conn!=null)
      {
        conn.Dispose();
      }
    }

    public static void ClearAll()
    {
      MySqlConnection conn =DB.Connection();
      conn.Open();

      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"DELETE FROM stylist; DELETE FROM clients;";
      cmd.ExecuteNonQuery();

      conn.Close();
      if(conn!=null)
      {
        conn.Dispose();
      }
    }

    public static Stylist Find(int _findId)
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();

      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM stylist WHERE id = @findId";
      MySqlParameter findId = new MySqlParameter("@findId", _findId);
      cmd.Parameters.Add(findId);

      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;

      int stylistId = -1;
      string stylistName = "";
      while(rdr.Read())
      {
        stylistId = rdr. GetInt32(0);
        stylistName = rdr.GetString(1);
      }

      conn.Close();
      if(conn!=null)
      {
        conn.Dispose();
      }

      return new Stylist(stylistName, stylistId);
    }

    public void AddClient(Client client)
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();

      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"INSERT INTO client (name, stylistId) VALUES (@clientName, @thisId);";
      MySqlParameter clientName = new MySqlParameter("@clientName", client.Name);
      MySqlParameter thisId = new MySqlParameter("@thisId", this.Id);
      cmd.Parameters.Add(clientName);
      cmd.Parameters.Add(thisId);

      cmd.ExecuteNonQuery();
      client.Id = (int) cmd.LastInsertedId;
      client.StylistId = this.Id;

      conn.Close();
      if(conn!=null)
      {
        conn.Dispose();
      }
    }

    public List<Client> GetClients()
    {
      List<Client> allClient = new List<Client>{};
      MySqlConnection conn = DB.Connection();
      conn.Open();

      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM clients WHERE stylistId = @thisId;";
      MySqlParameter thisId = new MySqlParameter("@thisId", this._id);
      cmd.Parameters.Add(thisId);

      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        int clientId = rdr.GetInt32(0);
        string clientName = rdr.GetString(1);

        Client client = new Client(clientName, clientId, this._id);
        allClient.Add(client);
      }

      conn.Close();
      if(conn!=null)
      {
        conn.Dispose();
      }
      return allClient;
    }

    public static List<Stylist> GetStylist()
    {
      List<Stylist> showAllStylist = new List<Stylist>{};
      MySqlConnection conn = DB.Connection();
      conn.Open();

      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM stylist;";


      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        int id = rdr.GetInt32(0);
        string name = rdr.GetString(1);

        Stylist stylist = new Stylist(name, id);
        showAllStylist.Add(stylist);
      }

      conn.Close();
      if(conn!=null)
      {
        conn.Dispose();
      }
      return showAllStylist;
    }
  }
}
