using HarmonyLib;
using UnityEngine;

namespace Ice.Initialization;

public class Loader
{
	public static void Load()
	{
		new Harmony("com.ice.icemodmenu.org").PatchAll();
		UnityEngine.Debug.Log((object)$"Ice v{PluginInfo.menuVersion} initialized.");
	}
}