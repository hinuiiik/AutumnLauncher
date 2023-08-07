namespace AutumnLauncher;

public class Startup
{
    public void AppStart()
    {
        Directory.CreateDirectory(Configuration.DataDir);
        Directory.CreateDirectory(Configuration.ConfigDir);
        SqliteData.CreateDatabase();
    }
}