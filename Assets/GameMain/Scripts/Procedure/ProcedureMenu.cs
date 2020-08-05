using GameFramework.Fsm;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace StarForcePractice
{
    public class ProcedureMenu : ProcedureBase
    {
        
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            Log.Debug("菜单流程进入...");
            GameEntry.UI.OpenUIForm("Assets/GameMain/UI/UIForms/MenuForm.prefab", "Default");
        }
    }
}

