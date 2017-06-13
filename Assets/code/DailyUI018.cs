using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class DailyUI018 : DailyUIBase 
{
	public CanvasGroup StatBoxesCG;
	public CanvasGroup GraphCG;
	public Button CloseButton;

	const float TransitionTime = 1f;

	void Start () {
		CloseButton.onClick.AddListener (OnCloseClicked);
	}

	void OnCloseClicked() {
		DOTween.To (() => StatBoxesCG.alpha, x => StatBoxesCG.alpha = x, 0, TransitionTime);
		DOTween.To (() => GraphCG.alpha, x => GraphCG.alpha = x, 0, TransitionTime);
	}
}
