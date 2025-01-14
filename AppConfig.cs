public class AppConfig
{
  public string AppDir { get; private set; }
  public string CacheDir { get; private set; }
  public string DataDir { get; private set; }
  public string DefaultVmName { get; set; } = "testvm";
  public string DefaultVmDistro { get; set; } = "Debian11";
  public string DefaultUser { get; set; } = "user";

  public AppConfig(string appName = "VmChamp", string sessionName = "default")
  {
    var homeDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
    this.AppDir = Path.Combine(homeDir, appName);
    this.CacheDir = Path.Combine(this.AppDir, sessionName, "cache");
    this.DataDir = Path.Combine(this.AppDir, sessionName, "vms");
  }
}