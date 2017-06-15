using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class DailyUI020 : DailyUIBase 
{
	public CanvasGroup MapCG;
	public Button CloseButton;

	const float TransitionTime = 1f;

	void Start () {
		CloseButton.onClick.AddListener (OnCloseClicked);
	}

	void OnCloseClicked() {
		DOTween.To (() => MapCG.alpha, x => MapCG.alpha = x, 0, TransitionTime);
	}

}
