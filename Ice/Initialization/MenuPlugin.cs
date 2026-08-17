using BepInEx;

namespace Ice.Initialization;

[BepInPlugin("com.ice.icemodmenu.org", "Ice", "9.0")]
public class MenuPlugin : BaseUnityPlugin
{
	private void Awake()
	{
		Loader.Load();
	}
}
