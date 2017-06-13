using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class DailyUI018 : DailyUIBase 
{
	public CanvasGroup StatBoxesCG;
	public CanvasGroup GraphCG;
	public Button CloseButton;

	public Image GraphImg;

	const float TransitionTime = 1f;

	void Start () {
		CloseButton.onClick.AddListener (OnCloseClicked);
		ChangeSize1 ();
	}

	void OnCloseClicked() {
		DOTween.To (() => StatBoxesCG.alpha, x => StatBoxesCG.alpha = x, 0, TransitionTime);
		DOTween.To (() => GraphCG.alpha, x => GraphCG.alpha = x, 0, TransitionTime);
	}

	void ChangeSize1 () {
		GraphImg.rectTransform.DOScale (0.6f, 0.6f);
		ChangeSize2 ();
	}

	void ChangeSize2 () {
		GraphImg.rectTransform.DOScale (0.7f, 0.7f);
		ChangeSize25 ();
	}

	void ChangeSize25 () {
		GraphImg.rectTransform.DOScale (0.75f, 0.75f);
		ChangeSize3 ();
	}

	void ChangeSize3 () {
		GraphImg.rectTransform.DOScale (0.8f, 0.8f);
		ChangeSize35 ();
	}

	void ChangeSize35 () {
		GraphImg.rectTransform.DOScale (0.85f, 0.85f);
		ChangeSize4 ();
	}

	void ChangeSize4 () {
		GraphImg.rectTransform.DOScale (0.9f, 0.9f);
		ChangeSize45 ();
	}

	void ChangeSize45 () {
		GraphImg.rectTransform.DOScale (0.95f, 0.95f);
		ChangeSize5 ();
	}

	void ChangeSize5 () {
		GraphImg.rectTransform.DOScale (1f, 1f);
	}
	
}
