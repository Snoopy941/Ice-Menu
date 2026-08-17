using GorillaLocomotion;
using HarmonyLib;
using Ice.Menu;
using Ice.Utilities;
using UnityEngine;

namespace Ice.Initialization;

[HarmonyPatch(typeof(GTPlayer), "LateUpdate")]
internal class MenuInitializer
{
	private static GameObject obj;

	[HarmonyPostfix]
	private static void Postfix()
	{
		if (!((UnityEngine.Object)(object)obj != (UnityEngine.Object)null))
		{
			obj = new GameObject("Ice");
			obj.AddComponent<Main>();
			obj.AddComponent<CoroutineHelper>();
			obj.AddComponent<NotificationLib>();
			obj.AddComponent<UpdateChecker>();
			obj.AddComponent<IceUI>();
			obj.AddComponent<CustomBoards>();
			obj.AddComponent<Ice.Mods.Categories.QoL>();
			obj.AddComponent<NetworkingLibrary>();
			UnityEngine.Object.DontDestroyOnLoad((UnityEngine.Object)(object)obj);
			UnityEngine.Debug.Log((object)"Ice initialized.");
		}
	}
}
