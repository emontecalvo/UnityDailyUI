using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class DailyUI028 : DailyUIBase 
{
	public CanvasGroup ContactPanelCG;
	public Button SendButton;

	const float TransitionTime = 1f;

	void Start () {
		SendButton.onClick.AddListener (OnSendClicked);
	}

	void OnSendClicked() {
		DOTween.To (() => ContactPanelCG.alpha, x => ContactPanelCG.alpha = x, 0, TransitionTime);
	}
}
