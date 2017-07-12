using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class DailyUI029 : DailyUIBase 
{
	public CanvasGroup RitzPanelCG;
	public Button BookButton;

	const float TransitionTime = 1f;

	void Start () {
		DOTween.To (() => RitzPanelCG.alpha, x => RitzPanelCG.alpha = x, 1, TransitionTime);
		BookButton.onClick.AddListener (OnBookClicked);
	}

	void OnBookClicked() {
		DOTween.To (() => RitzPanelCG.alpha, x => RitzPanelCG.alpha = x, 0, TransitionTime);
	}
}
