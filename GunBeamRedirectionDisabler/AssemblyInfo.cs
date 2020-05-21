using System.Resources;
using System.Reflection;
using System.Runtime.InteropServices;
using MelonLoader;

[assembly: AssemblyTitle(GunBeamRedirectionDisabler.BuildInfo.Name)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(GunBeamRedirectionDisabler.BuildInfo.Company)]
[assembly: AssemblyProduct(GunBeamRedirectionDisabler.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + GunBeamRedirectionDisabler.BuildInfo.Author)]
[assembly: AssemblyTrademark(GunBeamRedirectionDisabler.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion(GunBeamRedirectionDisabler.BuildInfo.Version)]
[assembly: AssemblyFileVersion(GunBeamRedirectionDisabler.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonModInfo(typeof(GunBeamRedirectionDisabler.GunBeamRedirectionDisabler), GunBeamRedirectionDisabler.BuildInfo.Name, GunBeamRedirectionDisabler.BuildInfo.Version, GunBeamRedirectionDisabler.BuildInfo.Author, GunBeamRedirectionDisabler.BuildInfo.DownloadLink)]


// Create and Setup a MelonModGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonModGameAttribute is found or any of the Values for any MelonModGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonModGame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonModGame(null, null)]