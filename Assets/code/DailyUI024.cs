using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class DailyUI024 : DailyUIBase 
{
	public RectTransform BoardingRT;
	public CanvasGroup IntroCG;
	public CanvasGroup BoardingPassCG;
	public Button ArrowBtn;

	public Image GraphImg;

	const float TransitionTime = 2f;

	void Start () {
		BoardingRT.gameObject.SetActive (false);
		ArrowBtn.onClick.AddListener (OnArrowClicked);
		ChangeSize1 ();
	}

	void OnArrowClicked() {
		BoardingRT.gameObject.SetActive (true);
		DOTween.To (() => IntroCG.alpha, x => IntroCG.alpha = x, 0, TransitionTime);
		DOTween.To (() => BoardingPassCG.alpha, x => BoardingPassCG.alpha = x, 1, TransitionTime);
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
