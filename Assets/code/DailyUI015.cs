using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

public class DailyUI015 : DailyUIBase
{
	public CanvasGroup OffCG;
	public CanvasGroup OnCG;
	public Button OnBtn1;
	public Button OffBtn1;
	public Button OnBtn2;
	public Button OffBtn2;
	const float TransitionTime = 2f;

	void Start(){
		OnBtn1.onClick.AddListener (OnBtnClicked);
		OffBtn1.onClick.AddListener (OffBtnClicked);
		OnBtn2.onClick.AddListener (OnBtnClicked);
		OffBtn2.onClick.AddListener (OffBtnClicked);
	}

	void OnBtnClicked(){
		DOTween.To (() => OffCG.alpha, x => OffCG.alpha = x, 0, TransitionTime);
		DOTween.To (() => OnCG.alpha, x => OnCG.alpha = x, 1, TransitionTime);
	}

	void OffBtnClicked(){
		DOTween.To (() => OnCG.alpha, x => OnCG.alpha = x, 0, TransitionTime);
		DOTween.To (() => OffCG.alpha, x => OffCG.alpha = x, 1, TransitionTime);
	}
}

