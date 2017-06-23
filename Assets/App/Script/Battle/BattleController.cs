using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniFramework;
using UnityEngine.UI;

public class BattleController : BaseSceneController
{
    private Button button;

    public override void OnOpen(Dictionary<string, object> arguments)
    {
        base.OnOpen(arguments);
        button = this.canvases[0].GetComponentInChildren<Button>();
        button.onClick.AddListener(() =>
        {
            MessageBox.ShowYesNoMessageBox("Do you want to really leave ?", (result) =>
            {
                if (result == MessageBoxResult.Yes)
                {
                    Switch("Home");
                }
            });
        });
    }

    public override void OnClose()
    {
        base.OnClose();
    }
}
