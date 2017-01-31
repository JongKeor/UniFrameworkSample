using UnityEngine;
using System.Collections;
using UniFramework;
using UnityEngine.UI;
using System.Collections.Generic;

public class MyPageController : BaseSceneController
{
	private Button button;
	public override void OnLoad ()
	{
		base.OnLoad ();
		button = this.canvases[0].GetComponentInChildren<Button>();

		button.onClick.AddListener( ()=> {
			Switch("Battle");
		});


	}

	public override void OnOpen (Dictionary<string, object> arguments)
	{
		base.OnOpen (arguments);
	}

	public override void OnClose ()
	{
		base.OnClose ();
	}

}

