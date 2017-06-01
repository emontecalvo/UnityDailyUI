using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

public class DailyUI010 : DailyUIBase
{
	public Button ShareIconBtn;
	public Button ShareIconExpandBtn;

	public CanvasGroup LeftPanelFrame;
	public CanvasGroup MiddlePanelFrame;
	public CanvasGroup RightPanelFrame;

	const float TransitionTime = 0.1f;

	bool IsExpanded = false;

	void Start(){
		ShareIconBtn.onClick.AddListener (OnShareClicked);
		ShareIconExpandBtn.onClick.AddListener (OnShareClicked);
	}

	void OnShareClicked(){
		if (!IsExpanded) {
			DOTween.To (() => MiddlePanelFrame.alpha, x => MiddlePanelFrame.alpha = x, 0, TransitionTime);
			DOTween.To (() => LeftPanelFrame.alpha, x => LeftPanelFrame.alpha = x, 1, TransitionTime);
			DOTween.To (() => RightPanelFrame.alpha, x => RightPanelFrame.alpha = x, 1, TransitionTime);
			IsExpanded = true;
		} else {
			DOTween.To (() => MiddlePanelFrame.alpha, x => MiddlePanelFrame.alpha = x, 1, TransitionTime);
			DOTween.To (() => LeftPanelFrame.alpha, x => LeftPanelFrame.alpha = x, 0, TransitionTime);
			DOTween.To (() => RightPanelFrame.alpha, x => RightPanelFrame.alpha = x, 0, TransitionTime);
			IsExpanded = false;
		}
	}
}
