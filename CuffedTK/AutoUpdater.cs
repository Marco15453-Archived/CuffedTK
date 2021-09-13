using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.Loader;
using MEC;

namespace CuffedTK
{
    internal static class AutoUpdater
    {
        private const string Version = "1.4.0";
        private const string PluginName = "CuffedTK";
        private const string updateURL = "https://scp.4everyone.xyz/update";

        internal static async Task RunUpdater(int waitTime = 0)
        {
            if (waitTime != 0) await Task.Delay(waitTime);

            using (var client = new WebClient())
            {
                if (CuffedTK.Instance == null) return;
                var res = await client.DownloadStringTaskAsync($"{updateURL}/{PluginName}/version");
                if (res == "-1" || res == Version) return;

                var location = CuffedTK.Instance.GetPath();
                if (location == null)
                {
                    Log.Warn($"{PluginName} auto updater couldn't determine the plugin path. Make sure your plugin dll is named \"{PluginName}.dll\".");
                    return;
                }

                var githubVer = await client.DownloadStringTaskAsync($"{updateURL}/{PluginName}/github");
                if (githubVer == "-1") return;

                await client.DownloadFileTaskAsync($"https://github.com/Marco15453/{PluginName}/releases/download/{githubVer.Replace(" / ", "")}/{PluginName}.dll", location);
                Log.Info($"Updated {PluginName}, Please restart your server to complete the update.");
            }
        }

        internal static IEnumerator<float> AutoUpdates()
        {
            RunUpdater(10000);

            while (true)
            {
                yield return Timing.WaitForSeconds(7200);

                RunUpdater(10000);
            }
        }
    }
}
