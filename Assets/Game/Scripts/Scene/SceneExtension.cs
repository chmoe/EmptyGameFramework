using UnityEngine.SceneManagement;
using UnityGameFramework.Runtime;

public static class SceneExtension
{
    public static void UnloadAllScene(this SceneComponent sceneComponent)
    {
        string[] loadedSceneAssetNames = GameEntry.Scene.GetLoadedSceneAssetNames();
        for(int i = 0; i < loadedSceneAssetNames.Length; i++) {
            if (!sceneComponent.SceneIsUnloading(loadedSceneAssetNames[i]))
            {
                sceneComponent.UnloadScene(loadedSceneAssetNames[i]);
            }
        }
    }
    public static void LoadNewSceneByName(this SceneComponent sceneComponent, string sceneAssetName)
    {
        sceneAssetName = AssetUtility.GetSceneAsset(sceneAssetName);
        sceneComponent.UnloadAllScene();
        sceneComponent.LoadScene(sceneAssetName);
    }
    public static void LoadNewSceneByName(this SceneComponent sceneComponent, string sceneAssetName, int priority)
    {
        sceneAssetName = AssetUtility.GetSceneAsset(sceneAssetName);
        sceneComponent.UnloadAllScene();
        sceneComponent.LoadScene(sceneAssetName, priority);
    }
    public static void LoadNewSceneByName(this SceneComponent sceneComponent, string sceneAssetName, object userData)
    {
        sceneAssetName = AssetUtility.GetSceneAsset(sceneAssetName);
        sceneComponent.UnloadAllScene();
        sceneComponent.LoadScene(sceneAssetName, userData);
    }
    public static void LoadNewSceneByName(this SceneComponent sceneComponent, string sceneAssetName, int priority, object userData)
    {
        sceneAssetName = AssetUtility.GetSceneAsset(sceneAssetName);
        sceneComponent.UnloadAllScene();
        sceneComponent.LoadScene(sceneAssetName, priority, userData);
    }

    public static void SetActiveScene(this SceneComponent sceneComponent, string sceneName, bool active)
    {
        Scene activeScene = SceneManager.GetSceneByName(sceneName);
        var objs = activeScene.GetRootGameObjects();
        if(objs != null) {
            foreach(var obj in objs)
                obj.SetActive(active);
        }
    }
}
