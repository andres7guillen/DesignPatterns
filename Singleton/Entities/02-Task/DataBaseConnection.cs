using System.Runtime.CompilerServices;

namespace Singleton.Entities._02_Task;

public class DataBaseConnection
{
    private static DataBaseConnection _instance;
    private bool isConnected;
    public string DbName { get; private set; }
    private DataBaseConnection(string dbName) 
    {
        DbName = dbName;
        this.isConnected = false;
    }

    public static DataBaseConnection GetInstance(string name) 
    {
        if (DataBaseConnection._instance == null) 
        {
            Console.WriteLine($"Database: {name} was creted");
            DataBaseConnection._instance = new DataBaseConnection(name);
        }
        return DataBaseConnection._instance;
    }

    public void Connect()
    {
        if (this.isConnected) 
        {
            Console.WriteLine($"Database: {this.DbName} has already connected");
            return;
        }
        Console.WriteLine($"Database {this.DbName} was connected");
        this.isConnected = true;
        return;
    }

    public void Disconnect() 
    {
        if (this.isConnected == false) 
        {
            Console.WriteLine($"Database {this.DbName} is not connected, so it cannot be disconnecteed.");
            return;
        }
        this.isConnected = false;
        Console.WriteLine($"Database {this.DbName}: was disconnected");
        return;
    }

}
