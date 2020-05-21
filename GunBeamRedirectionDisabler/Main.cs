using MelonLoader;
using NET_SDK;
using NET_SDK.Harmony;
using System;

namespace GunBeamRedirectionDisabler
{
    public static class BuildInfo
    {
        public const string Name = "GunBeamRedirectionDisabler"; // Name of the Mod.  (MUST BE SET)
        public const string Author = "Alternity"; // Author of the Mod.  (Set as null if none)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class GunBeamRedirectionDisabler : MelonMod
    {
        public static Patch Gun_AdjustAutoaimedPosition;

        public override void OnApplicationStart()
        {
            Instance instance = Manager.CreateInstance("GunBeamRedirectionDisabler");

            Gun_AdjustAutoaimedPosition = instance.Patch(SDK.GetClass("Gun").GetMethod("AdjustAutoaimedPosition"), typeof(GunBeamRedirectionDisabler).GetMethod("AdjustAutoaimedPosition"));
        }

        public static unsafe void AdjustAutoaimedPosition(IntPtr gun, IntPtr target, IntPtr intersection, int firepointHistoryIndex, bool forceForAutoplay)
        {
            /*
            Gun_AdjustAutoaimedPosition.InvokeOriginal(gun, new IntPtr[]
            {
                target,
                intersection,
                new IntPtr((void*)(&firepointHistoryIndex)),
                new IntPtr((void*)(&forceForAutoplay))
            });
            */
        }

        /*
        public override void OnLevelWasLoaded(int level)
        {
            MelonModLogger.Log("OnLevelWasLoaded: " + level.ToString());
        }

        public override void OnLevelWasInitialized(int level)
        {
            MelonModLogger.Log("OnLevelWasInitialized: " + level.ToString());
        }

        public override void OnUpdate()
        {
            MelonModLogger.Log("OnUpdate");
        }

        public override void OnFixedUpdate()
        {
            MelonModLogger.Log("OnFixedUpdate");
        }

        public override void OnLateUpdate()
        {
            MelonModLogger.Log("OnLateUpdate");
        }

        public override void OnGUI()
        {
            MelonModLogger.Log("OnGUI");
        }

        public override void OnApplicationQuit()
        {
            MelonModLogger.Log("OnApplicationQuit");
        }

        public override void OnModSettingsApplied()
        {
            MelonModLogger.Log("OnModSettingsApplied");
        }

        public override void VRChat_OnUiManagerInit() // Only works in VRChat
        {
            MelonModLogger.Log("VRChat_OnUiManagerInit");
        }
        */
    }
}
