﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniFramework;
using UnityEngine.UI;

public class TitleController : BaseSceneController
{

    private Button button;

    public override void OnOpen(Dictionary<string, object> arguments)
    {
        base.OnOpen(arguments);
        button = this.canvases[0].GetComponentInChildren<Button>();
        button.onClick.AddListener(() =>
        {
            Switch("Home");
        });
    }

    public override void OnClose()
    {
        base.OnClose();
    }


}
