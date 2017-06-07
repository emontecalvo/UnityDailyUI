using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class DailyUI017 : DailyUIBase 
{
	public CanvasGroup Paw1CG;
	public CanvasGroup Paw2CG;
	public CanvasGroup Paw3CG;
	public CanvasGroup Paw4CG;
	public CanvasGroup EmailCG;

	public Button CloseBtn;

	const float TransitionTime = 0.8f;

	void Start () {
		CloseBtn.onClick.AddListener (OnCloseClicked);
		DOTween.To (() => Paw1CG.alpha, x => Paw1CG.alpha = x, 1, TransitionTime).OnComplete(Paw2FadeIn);
	}

	void Paw2FadeIn() {
		DOTween.To (() => Paw2CG.alpha, x => Paw2CG.alpha = x, 1, TransitionTime).OnComplete(Paw3FadeIn);
	}

	void Paw3FadeIn() {
		DOTween.To (() => Paw3CG.alpha, x => Paw3CG.alpha = x, 1, TransitionTime).OnComplete(Paw4FadeIn);
	}

	void Paw4FadeIn() {
		DOTween.To (() => Paw4CG.alpha, x => Paw4CG.alpha = x, 1, TransitionTime);
	}

	void OnCloseClicked() {
		DOTween.To (() => EmailCG.alpha, x => EmailCG.alpha = x, 0, TransitionTime);
	}
}
