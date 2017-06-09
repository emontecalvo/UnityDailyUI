using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class DailyUI019 : DailyUIBase 
{
	public RectTransform Frame1RT;
	public RectTransform Frame2RT;
	public RectTransform Frame3RT;
	public RectTransform Frame4RT;

	public CanvasGroup Panel2;
	public CanvasGroup Panel3;
	public CanvasGroup Panel4;

	const float TransitionTime = 1f;

	// Use this for initialization
	void Start () {
		Panel2.alpha = 0;
		Panel3.alpha = 0;
		Panel4.alpha = 0;
		Vector3 dest = Frame1RT.localPosition;
		Vector3 start = dest + new Vector3 (-500, 0, 0);

		Frame1RT.localPosition = start;
		DOTween.To (() => Frame1RT.localPosition, x => Frame1RT.localPosition = x, dest, TransitionTime).OnComplete(OnSecondFrame);
	}

	void OnSecondFrame(){
		Vector3 dest = Frame2RT.localPosition;
		Vector3 start = dest + new Vector3 (-500, 0, 0);
		Frame2RT.localPosition = start;
		Panel2.alpha = 1;
		DOTween.To (() => Frame2RT.localPosition, x => Frame2RT.localPosition = x, dest, TransitionTime).OnComplete(OnThirdFrame);
	}

	void OnThirdFrame(){
		Vector3 dest = Frame3RT.localPosition;
		Vector3 start = dest + new Vector3 (-500, 0, 0);
		Frame3RT.localPosition = start;
		Panel3.alpha = 1;
		DOTween.To (() => Frame3RT.localPosition, x => Frame3RT.localPosition = x, dest, TransitionTime).OnComplete(OnFourthFrame);
	}

	void OnFourthFrame() {
		Vector3 dest = Frame4RT.localPosition;
		Vector3 start = dest + new Vector3 (-500, 0, 0);
		Frame4RT.localPosition = start;
		Panel4.alpha = 1;
		DOTween.To (() => Frame4RT.localPosition, x => Frame4RT.localPosition = x, dest, TransitionTime);
	}
}
