using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

public class DailyUI010 : DailyUIBase
{
	public Button ShareIconBtn;

	void Start(){
		ShareIconBtn.onClick.AddListener (OnShareClicked);
	}

	void OnShareClicked(){
		Debug.Log ("I am clicked");
	}
}
