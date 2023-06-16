using UnityEditor;

namespace ChenPipi.PipiToolbox.Editor
{

    /// <summary>
    /// 资源工具
    /// </summary>
    /// <author>陈皮皮</author>
    /// <version>20221128</version>
    public static class AssetTool
    {

        /// <summary>
        /// 菜单项路径
        /// </summary>
        private const string k_MenuPath = PipiToolboxMenu.AssetsMenuBasePath + "Asset Tool/";

        /// <summary>
        /// 菜单项优先级
        /// </summary>
        private const int k_MenuPriority = PipiToolboxMenu.AssetsMenuBasePriority + 100;

        /// <summary>
        /// Log 头部信息
        /// </summary>
        private const string k_LogTag = "Asset";

        [MenuItem(k_MenuPath + "Reimport", false, k_MenuPriority)]
        private static void Menu_Reimport()
        {
            AssetUtility.ReimportAsset(Selection.activeObject);
        }
        
    }

}
