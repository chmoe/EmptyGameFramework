//------------------------------------------------------------

using UnityEngine;

/// <summary>
/// 游戏入口。
/// </summary>
public partial class GameEntry : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("GameEntry Start");
        InitBuiltinComponents();
        // InitCustomComponents();
    }
}
