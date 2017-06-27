using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class DailyUI026 : DailyUIBase 
{
	public RectTransform ThankyouRT;
	public CanvasGroup IntroCG;
	public CanvasGroup ThankyouCG;
	public Button SignupBtn;
	public Button CloseBtn;

	const float TransitionTime = 2f;

	void Start () {
		ThankyouRT.gameObject.SetActive (false);
		SignupBtn.onClick.AddListener (OnSignupClicked);
		CloseBtn.onClick.AddListener (OnCloseClicked);

	}

	void OnSignupClicked() {
		ThankyouRT.gameObject.SetActive (true);
		DOTween.To (() => IntroCG.alpha, x => IntroCG.alpha = x, 0, TransitionTime);
		DOTween.To (() => ThankyouCG.alpha, x => ThankyouCG.alpha = x, 1, TransitionTime);
	}

	void OnCloseClicked() {
		DOTween.To (() => ThankyouCG.alpha, x => ThankyouCG.alpha = x, 0, TransitionTime);
	}
}
