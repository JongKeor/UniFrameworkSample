using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniFramework;
using UnityEngine.UI;
using UniFramework.Extension;

public class HomeController : TabSceneController {

	private Button button1;
	private Button button2;


	

	public override void OnOpen (Dictionary<string, object> arguments)
	{
		base.OnOpen (arguments);
		button1 = this.canvases[0].gameObject.FindChildObjectByName("Button1").GetComponent<Button>();
		button1.onClick.AddListener( ()=> {
			SwitchTabScene(0);
		});

		button2 = this.canvases[0].gameObject.FindChildObjectByName("Button2").GetComponent<Button>();;
		button2.onClick.AddListener( ()=> {
			SwitchTabScene(1);
		});
	}

	public override void OnClose ()
	{
		base.OnClose ();
	}
}
