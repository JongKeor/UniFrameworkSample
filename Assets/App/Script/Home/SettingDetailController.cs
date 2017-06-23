using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniFramework;
using UnityEngine.UI;

public class SettingDetailController : BaseSceneController {
	private Button button;

	private Text text;
	public override void OnOpen (Dictionary<string, object> arguments)
	{
		base.OnOpen (arguments);
		button = this.canvases[0].GetComponentInChildren<Button>();
		text = this.canvases[0].GetComponentInChildren<Text>();
		text.text = this.gameObject.scene.GetHashCode().ToString();
		
		
		button.onClick.AddListener( ()=> {
			Parent.GetSceneController<StackSceneController>().Push("SettingDetail" );
		});

	}

	public override void OnClose ()
	{
		base.OnClose ();
	}
}
