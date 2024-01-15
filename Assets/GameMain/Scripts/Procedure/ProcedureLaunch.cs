using System;
using UnityGameFramework.Runtime;
using GameFramework.Localization;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;
using UnityEngine;

public class ProcedureLaunch : ProcedureBase
{

    public const string Setting_Language = "Setting.Language";

    protected override void OnEnter(ProcedureOwner procedureOwner)
    {
        base.OnEnter(procedureOwner);
        Debug.Log("初始化。。。");
        // GameEntry.BuiltinData.InitBuildInfo();
        // InitLanguageSetting();
        // InitCurrentVariant();
    }

    protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
        // ChangeState<ProcedureSplash>(procedureOwner);
    }
    /**************************************************************************
     * 
     * 
     * 
     **************************************************************************/
    // private void InitLanguageSetting()
    // {
    //     if(GameEntry.Base.EditorResourceMode && GameEntry.Base.EditorLanguage != Language.Unspecified)
    //         return;

    //     Language language = GameEntry.Localization.Language;
    //     var list = UILanguage.GetUseLanguage();
    //     bool hasLanguage = false;
    //     for(int i = 0; i < list.Count; i++)
    //     {
    //         if(list[i] == language)
    //         {
    //             hasLanguage = true;
    //             break;
    //         }
    //     }
    //     if (!hasLanguage)
    //     {
    //         language = Language.English;
    //     }

    //     GameEntry.Localization.Language = language;
    // }
    // private void InitCurrentVariant()
    // {
    //     if(GameEntry.Base.EditorResourceMode)
    //         return;

    //     string curVariant = null;
    //     switch(GameEntry.Localization.Language) {
    //         case Language.ChineseSimplified:
    //             curVariant = "zh-cn";
    //             break;
    //         case Language.English:
    //             curVariant = "en-us";
    //             break;
    //         case Language.Japanese:
    //             curVariant = "ja-jp";
    //             break;
    //         default:
    //             curVariant = "zh-cn";
    //             break;
    //     }
    //     GameEntry.Resource.SetCurrentVariant(curVariant);
    // }
}
