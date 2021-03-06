/*
 * @Author: fasthro
 * @Date: 2019-11-09 14:15:36
 * @Description: AssetBundle 数据库
 */
using System.Collections.Generic;
using System.IO;
using LitJson;
using UnityEngine;

namespace FastEngine.Core
{
    /// <summary>
    /// 映射数据
    /// </summary>
    public class AssetBundleMappingData
    {
        // bundle name
        public string bundleName;
        // res name
        public string assetName;
    }

    public class AssetBundleDB
    {
        static bool initialized;

        #region manifest
        static AssetBundle manifestBundle;
        static AssetBundleManifest manifest;
        #endregion

        #region mapping
        static Dictionary<string, AssetBundleMappingData> mapping = new Dictionary<string, AssetBundleMappingData>();
        #endregion

        /// <summary>
        /// 初始化
        /// </summary>
        public static void Initialize()
        {
            initialized = true;

            // manifest
            manifestBundle = AssetBundle.LoadFromFile(FilePathUtils.Combine(AppUtils.BundleRootDirectory(), PlatformUtils.PlatformId()));
            manifest = manifestBundle.LoadAsset("AssetBundleManifest") as AssetBundleManifest;

            // mapping
            var ms = File.ReadAllText(FilePathUtils.Combine(AppUtils.BundleRootDirectory(), PlatformUtils.PlatformId() + ".json"));
            mapping = JsonMapper.ToObject<Dictionary<string, AssetBundleMappingData>>(ms);
        }

        /// <summary>
        /// 通过 bundleName 获取依赖列表
        /// </summary>
        /// <param name="bundleName"></param>
        /// <returns></returns>
        public static string[] GetDependencies(string bundleName)
        {
            if (!initialized) Initialize();
            return manifest.GetAllDependencies(bundleName);
        }

        /// <summary>
        /// 通过资源路径获取映射数据
        /// </summary>
        /// <param name="resPath">资源路径</param>
        /// <returns></returns>
        public static AssetBundleMappingData GetMappingData(string resPath)
        {
            if (!initialized) Initialize();
            AssetBundleMappingData data = null;
            mapping.TryGetValue(resPath, out data);
            if (data == null)
            {
                string result = resPath.Replace("Assets/", "");
                result = result.Replace(".png", "");
                result = result.Replace(".prefab", "");
                result = result.Replace(".mp3", "");
                result = result.Replace(".ogg", "");
                mapping.TryGetValue(result, out data);
            }
            if (data == null) Debug.LogError("assetbundle mapping data not exist:" + resPath);
            return data;
        }
    }
}