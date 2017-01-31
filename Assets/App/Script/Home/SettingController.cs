using UnityEngine;
using System.Collections;
using UniFramework;
using UnityEngine.UI;
using System.Collections.Generic;

public class SettingController : StackSceneController
{

	private Button button;
	public override void OnLoad ()
	{
		base.OnLoad ();
		button = this.canvases[0].GetComponentInChildren<Button>();
		button.onClick.AddListener( ()=> {
			Pop();
		});
	}

	public override void OnOpenChildScene (SceneInfo info)
	{
		base.OnOpenChildScene (info);
		if(this.childs.Count == 1){
			button.gameObject.SetActive(false);
		}
		else {
			button.gameObject.SetActive(true);
		}


	}
	public override void OnCloseChildScene (SceneInfo info)
	{
		base.OnCloseChildScene (info);
		if(this.childs.Count == 1){
			button.gameObject.SetActive(false);
		}
		else {
			button.gameObject.SetActive(true);
		}
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

