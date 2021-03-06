/*
 * @Author: fasthro
 * @Date: 2019-11-27 10:57:12
 * @Description: App Utils
 */
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using FastEngine.Core;
using LitJson;
using UnityEngine;

namespace FastEngine
{
    public static class AppUtils
    {
        /// <summary>
        /// FastAssets 根目录
        /// </summary>
        /// <returns></returns>
        public static string FastAssetsRootDirectory()
        {
            return FilePathUtils.Combine(Application.dataPath, "FastAssets");
        }

        #region Table

        /// <summary>
        /// Table excel 配置表目录
        /// </summary>
        /// <returns></returns>
        public static string TableExcelDirectory()
        {
            return FilePathUtils.Combine(FastAssetsRootDirectory(), "Table", "Excel");
        }

        /// <summary>
        /// Table 数据输出目录
        /// </summary>
        /// <returns></returns>
        public static string TableDataDirectory()
        {
            return FilePathUtils.Combine(FastAssetsRootDirectory(), "Table", "Data");
        }

        /// <summary>
        /// Table 数据Bundle根目录
        /// </summary>
        /// <returns></returns>
        public static string TableDataBundleRootDirectory()
        {
            return FilePathUtils.Combine("FastAssets", "Table", "Data");
        }

        /// <summary>
        /// Table 数据对象输出目录
        /// </summary>
        /// <returns></returns>
        public static string TableObjectDirectory()
        {
            return FilePathUtils.Combine(FastAssetsRootDirectory(), "Table", "TableObject");
        }

        #endregion

        #region i18n
        /// <summary>
        /// i18n excel 配置文件路径
        /// </summary>
        /// <returns></returns>
        public static string i18nExcelFilePath()
        {
            return FilePathUtils.Combine(FastAssetsRootDirectory(), "i18n", "Excel", "i18n.xlsx");
        }

        /// <summary>
        /// i18n data 目录
        /// </summary>
        /// <returns></returns>
        public static string i18nDataDirectory()
        {
            return FilePathUtils.Combine(FastAssetsRootDirectory(), "i18n", "Data");
        }

        /// <summary>
        /// i18n index 目录
        /// </summary>
        /// <returns></returns>
        public static string i18nIndexDirectory()
        {
            return FilePathUtils.Combine(FastAssetsRootDirectory(), "i18n", "Index");
        }
        #endregion

        #region editor

        /// <summary>
        /// 编辑器配置根目录
        /// </summary>
        /// <returns></returns>
        public static string EditorConfigRootDirectory()
        {
            return FilePathUtils.Combine(FastAssetsRootDirectory(), "EditorConfig");
        }

        /// <summary>
        /// 配置目录-Data数据目录
        /// </summary>
        /// <returns></returns>
        public static string ConfigDataDirectory()
        {
            return FilePathUtils.Combine(BundleRootDirectory(), "config");
        }

        /// <summary>
        /// 配置目录-Raw数据目录
        /// </summary>
        /// <returns></returns>
        public static string ConfigRawDirectory()
        {
            return FilePathUtils.Combine(AppRawPath(), "config/");
        }

        /// <summary>
        /// 配置目录-Resource目录
        /// </summary>
        /// <returns></returns>
        public static string ConfigResourceDirectory()
        {
            return "Config";
        }

        /// <summary>
        /// 配置目录-编辑器目录
        /// </summary>
        /// <returns></returns>
        public static string ConfigEditorDirectory()
        {
            return FilePathUtils.Combine(FastAssetsRootDirectory(), "Config");
        }
        #endregion

        /// <summary>
        /// 数据根目录
        /// </summary>
        /// <returns></returns>
        public static string DataRootDirectory()
        {
#if UNITY_EDITOR
            if (App.runModel == AppRunModel.Develop)
            {
                return Application.streamingAssetsPath;
            }
            else return FilePathUtils.Combine(FilePathUtils.GetTopDirectory(Application.dataPath), "PersistentData");
#else
            return Application.persistentDataPath;
#endif
        }

        /// <summary>
        /// 应用程序内容路径
        /// </summary>
        public static string AppRawPath()
        {
#if UNITY_EDITOR
            return Application.streamingAssetsPath + "/";
#else
            if(Application.platform == RuntimePlatform.Android)
            {
                return Application.streamingAssetsPath + "/";
            }
            else if(Application.platform == RuntimePlatform.IPhonePlayer)
            {
                return Application.dataPath + "/Raw/";
            }
            else return Application.streamingAssetsPath + "/";
#endif
        }

        /// <summary>
        /// 编辑器下持久化目录
        /// </summary>
        /// <returns></returns>
        public static string EditorPersistentDataRootDirectory()
        {
            return FilePathUtils.Combine(FilePathUtils.GetTopDirectory(Application.dataPath), "PersistentData");
        }

        /// <summary>
        /// 编辑器下配置文件目录
        /// </summary>
        /// <returns></returns>
        public static string EditorResourceConfigRootDirectory()
        {
            return FilePathUtils.Combine(Application.dataPath, "Resources", "Config");
        }

        /// <summary>
        /// Build 根目录
        /// </summary>
        /// <returns></returns>
        public static string BuildRootDirectory()
        {
            return FilePathUtils.Combine(FilePathUtils.GetTopDirectory(Application.dataPath), "Build");
        }

        /// <summary>
        /// Build 版本目录
        /// </summary>
        /// <returns></returns>
        public static string BuildVersionRootDirectory(VersionConfig version)
        {
            return FilePathUtils.Combine(BuildRootDirectory(), version.ToVersionString());
        }

        /// <summary>
        /// Build Resource 版本目录
        /// </summary>
        /// <returns></returns>
        public static string BuildVersionResourceRootDirectory(VersionConfig version)
        {
            return FilePathUtils.Combine(BuildVersionRootDirectory(version), version.ToResourceString());
        }

        /// <summary>
        /// Bundle根目录
        /// </summary>
        /// <returns></returns>
        public static string BundleRootDirectory()
        {
            if (!Application.isPlaying) return FilePathUtils.Combine(Application.streamingAssetsPath, PlatformUtils.PlatformId());
            return FilePathUtils.Combine(DataRootDirectory(), PlatformUtils.PlatformId());
        }

        /// <summary>
        /// 计算字符串的MD5值
        /// </summary>
        public static string MD5(string source)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.UTF8.GetBytes(source);
            byte[] md5Data = md5.ComputeHash(data, 0, data.Length);
            md5.Clear();

            string destString = "";
            for (int i = 0; i < md5Data.Length; i++)
            {
                destString += System.Convert.ToString(md5Data[i], 16).PadLeft(2, '0');
            }
            destString = destString.PadLeft(32, '0');
            return destString;
        }

        /// <summary>
        /// 计算文件的MD5值
        /// </summary>
        public static string MD5File(string file)
        {
            try
            {
                FileStream fs = new FileStream(file, FileMode.Open);
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(fs);
                fs.Close();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("md5file() fail, error:" + ex.Message);
            }
        }
    }
}