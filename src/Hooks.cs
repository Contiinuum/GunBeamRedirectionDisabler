using Harmony;
using System;
using System.Reflection;
using UnityEngine;

namespace AudicaModding
{
    internal static class Hooks
    {
        public static void ApplyHooks(HarmonyInstance instance)
        {
            instance.PatchAll(Assembly.GetExecutingAssembly());
        }

        [HarmonyPatch(typeof(Gun), "AdjustAutoaimedPosition", new Type[] { typeof(Target), typeof(Vector3), typeof(int), typeof(bool) })]
        private static class PatchAdjustPosition
        {
            private static bool Prefix()
            {
                return true;
            }
        }
	}
}