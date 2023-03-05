using System.Reflection;
using IPA;
using UnityEngine;
using IPALogger = IPA.Logging.Logger;

namespace Camera2TransparencyPatch
{
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin
    {
        internal static Plugin Instance { get; private set; }
        /// <summary>
        /// BSIPA を通してログメッセージを送信する場合に使用します。
        /// </summary>
        internal static IPALogger Log { get; private set; }

        [Init]
        public Plugin(IPALogger logger)
        {
            Instance = this;
            Log = logger;
        }

        [OnStart]
        public void OnApplicationStart()
        {
            Plugin.Log.Info("OnApplicationStart");
            var camera2Type = typeof(Camera2.Plugin);
            var shaderMat_LuminanceKeyField = camera2Type.GetField("ShaderMat_LuminanceKey", BindingFlags.Static | BindingFlags.NonPublic);
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Camera2TransparencyPatch.Shaders.custom_luminancekey"))
            {
                var bundle = AssetBundle.LoadFromStream(stream);
                shaderMat_LuminanceKeyField.SetValue(camera2Type, new Material(bundle.LoadAsset<Shader>("luminancekey.shader")));
                bundle.Unload(false);
            }
        }

        [OnExit]
        public void OnApplicationQuit()
        {

        }

    }
}
