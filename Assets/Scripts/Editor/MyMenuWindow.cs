#if UNITY_EDITOR
namespace Lautaro
{
    using Sirenix.OdinInspector.Editor;
    using System.Linq;
    using UnityEngine;
    using Sirenix.Utilities.Editor;
    using Sirenix.Serialization;
    using UnityEditor;
    using Sirenix.Utilities;

    // 
    // Be sure to check out OdinMenuStyleExample.cs as well. It shows you various ways to customize the look and behaviour of OdinMenuTrees.
    // 

    public class LautaroWindow : OdinMenuEditorWindow
    {
        [MenuItem ( "Tools/LauLau/Spawn" )]
        private static void OpenWindow()
        {
            var window = GetWindow<LautaroWindow> ();
            window.position = GUIHelper.GetEditorWindowRect ().AlignCenter ( 800, 600 );
        }

     //   [SerializeField]
       // private SomeData someData = new SomeData (); // Take a look at SomeData.cs to see how serialization works in Editor Windows.

        protected override OdinMenuTree BuildMenuTree()
        {
            var spawns = GameFun.AllSpawns;

            OdinMenuTree tree = new OdinMenuTree ( supportsMultiSelect: true )
            {
                { "All Spawns",                           spawns,                           EditorIcons.PacmanGhost                       }//, //Draws the this.someData field in this case.
                //{ "Odin Settings",                  null,                           EditorIcons.SettingsCog                 },
                //{ "Odin Settings/Color Palettes",   ColorPaletteManager.Instance,   EditorIcons.EyeDropper                  },
                //{ "Odin Settings/AOT Generation",   AOTGenerationConfig.Instance,   EditorIcons.SmartPhone                  },
                //{ "Player Settings",                Resources.FindObjectsOfTypeAll<PlayerSettings>().FirstOrDefault()       },
                //{ "Some Class",                     this.someData                                                           }
            };

     

            return tree;
        }
    }
}
#endif
