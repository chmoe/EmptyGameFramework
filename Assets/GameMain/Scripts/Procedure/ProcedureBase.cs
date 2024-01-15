//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using GameFramework.Fsm;
public abstract class ProcedureBase : GameFramework.Procedure.ProcedureBase
{
    public void ChangeToState<TState>(IFsm<ProcedureBase> fsm) where TState : FsmState<ProcedureBase>
    {

    }
}