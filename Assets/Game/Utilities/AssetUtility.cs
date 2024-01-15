//------------------------------------------------------------
using System.Text;
using GameFramework;
using GameFramework.Localization;

public static class AssetUtility
{
    public static string GetConfigAsset(string assetName, bool fromBytes)
    {
        return Utility.Text.Format("Assets/Game/Configs/{0}.{1}", assetName, fromBytes ? "bytes" : "txt");
    }

    public static string GetUIFormTableAsset(string assetName, bool fromBytes)
    {
        return Utility.Text.Format("Assets/Game/UIFormConfig/{0}.{1}", assetName, fromBytes ? "bytes" : "txt");
    }

    public static string GetDataTableAsset(string assetName, bool fromBytes)
    {
        return Utility.Text.Format("Assets/Game/DataTables/{0}.{1}", assetName, fromBytes ? "bytes" : "txt");
    }

    public static string GetFontAsset(string assetName)
    {
        return Utility.Text.Format("Assets/Game/UI/Fonts/{0}.ttf", assetName);
    }

    public static string GetSceneAsset(string assetName)
    {
        return Utility.Text.Format("Assets/Game/Scenes/{0}.unity", assetName);
    }

    public static string GetEntityAsset(string assetName)
    {
        return Utility.Text.Format("Assets/Game/Entities/{0}.prefab", assetName);
    }

    public static string GetUIFormAsset(string assetName)
    {
        return Utility.Text.Format("Assets/Game/UI/UIForms/{0}.prefab", assetName);
    }

    public static string GetLuaAsset(string assetName)
    {
        return Utility.Text.Format("Assets/Game/LuaScripts/{0}.lua", assetName);
    }

    public static string GetPrefabAsset(string assetName)
    {
        return $"Assets/Game/Prefabs/{assetName}.prefab";
    }
    public static string GetProtoAsset(string assetName)
    {
        return $"Assets/Game/Protocol/{assetName}.proto";
    }
    public static string GetUIPrefabAsset(string assetName)
    {
        return $"Assets/Game/UI/UIPrefabs/{assetName}.prefab";
    }
    public static string GetMaterialAsset(string assetName)
    {
        return $"Assets/Game/UI/UIMaterial/{assetName}.mat";
    }
    public static string GetMusicAsset(string assetName)
    {
        return $"Assets/Game/Audios/Musics/{assetName}.ogg";
    }
    public static string GetSoundAsset(string assetName)
    {
        return $"Assets/Game/Audios/Sounds/{assetName}.mp3";
    }
    public static string GetUISoundAsset(string assetName)
    {
        return $"Assets/Game/Audios/UISounds/{assetName}.mp3";
    }
    public static string GetDictionaryAsset(string assetName, bool fromBytes)
    {
        return Utility.Text.Format("Assets/Game/Localization/{0}/Dictionaries/{1}.{2}", GameEntry.Localization.Language.ToString(), assetName, fromBytes ? "bytes" : "xml");
    }
    public static string GetDictionaryAsset(string assetName)
    {
        return $"Assets/Game/Localization/{assetName}.xml";
    }
    public static string[] GetAllDictionaryAsset()
    {
        return new string[] {
                GetDictionaryAsset(GameFramework.Localization.Language.ChineseSimplified.ToString()),
                GetDictionaryAsset(GameFramework.Localization.Language.English.ToString()),
                GetDictionaryAsset(GameFramework.Localization.Language.Japanese.ToString()),
            };
    }
    public static string GetAtlasAsset(string assetName)
    {
        return $"Assets/Game/UI/Atlas/{assetName}.spriteatlas";
    }
    public static string GetLocalizationAtlasAsset(string assetName)
    {
        return $"Assets/Game/Localization/Atlas/{GameEntry.Localization.Language}/{assetName}.spriteatlas";
    }
    public static string GetEntityGalaxyAsset(string assetName, string param1 = null, string param2 = null)
    {
        return $"Assets/Game/Entities/Galaxy/{assetName}{param1}{param2}.prefab";
    }
    public static string GetEntityCityAsset(string assetName, string param1 = null)
    {
        return $"Assets/Game/Entities/City/{assetName}{param1}.prefab";
    }
    public static string GetEntityGalaxyBuildingAsset(string assetName)
    {
        return $"Assets/Game/Entities/Galaxy/{assetName}.prefab";
    }
    public static string GetEntityCityBuildingAsset(string assetName)
    {
        return $"Assets/Game/Entities/City/{assetName}.prefab";
    }
    public static string GetEntitySpaceAsset(string assetName)
    {
        return $"Assets/Game/Entities/Space/{assetName}.prefab";
    }
    public static string GetMiniShootAsset(string assetName)
    {
        return $"Assets/Game/Entities/MiniShoot/{assetName}.prefab";
    }
    public static string GetTMPSpriteAsset(string assetName)
    {
        return $"Assets/Game/TextMeshPro/TMP_SpriteAsset/{assetName}.asset";
    }
    public static string GetLocalizationSprite(string assetName)
    {
        string local = "";
        switch (GameEntry.Localization.Language)
        {
            case Language.ChineseSimplified:
                local += "cn";
                break;
            case Language.English:
                local += "en";
                break;
            case Language.Japanese:
                local += "ja";
                break;
        }
        return $"Assets/Game/UI/Sprite/Localization/{local}/{assetName}.png";
    }

    public static string GetLocalizationPrefab(string assetName)
    {
        string local = "";
        switch (GameEntry.Localization.Language)
        {
            case Language.ChineseSimplified:
                local += "cn";
                break;
            case Language.English:
                local += "en";
                break;
            case Language.Japanese:
                local += "ja";
                break;
        }
        return $"Assets/Game/Prefabs/Localization/{local}/{assetName}.prefab";
    }
}

