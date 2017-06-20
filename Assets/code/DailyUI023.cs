using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class DailyUI023 : DailyUIBase 
{

	public RectTransform Frame1RT;

	public CanvasGroup Frame1CG;
	public CanvasGroup Frame2CG;
	public CanvasGroup Frame3CG;
	public CanvasGroup CirclePanelCG;

	public Sprite BlackCircle;
	public Sprite ColorCircle;

	public Button CloseBtn;

	public Button CircleOne;
	public Button CircleTwo;
	public Button CircleThree;

	public Image BackgroundImage;

	const float TransitionTime = 1f;
	const float TransitionTimeSlow = 4f;

	void Start () {

		CircleOne.onClick.AddListener (showFrameOne);
		CircleTwo.onClick.AddListener (showFrameTwo);
		CircleThree.onClick.AddListener (showFrameThree);
		CloseBtn.onClick.AddListener (onCloseClicked);

		Frame1RT.gameObject.SetActive (true);


		Vector3 dest = Frame1RT.localPosition;
		Vector3 start = dest + new Vector3 (-500, 0, 0);
		Frame1RT.localPosition = start;
		DOTween.To (() => Frame1RT.localPosition, x => Frame1RT.localPosition = x, dest, TransitionTime);

		Color DestColor = BackgroundImage.color;
		Color StartColor = DestColor;
		StartColor.a = 0;
		BackgroundImage.color = StartColor;
		DOTween.To (() => BackgroundImage.color, x => BackgroundImage.color = x, DestColor, TransitionTime);

		DOTween.To (() => CirclePanelCG.alpha, x => CirclePanelCG.alpha = x, 1, TransitionTimeSlow);
	}

	void showFrameOne() {
		Frame1RT.gameObject.SetActive (true);

		DOTween.To (() => Frame1CG.alpha, x => Frame1CG.alpha = x, 1, TransitionTime);
		DOTween.To (() => Frame2CG.alpha, x => Frame2CG.alpha = x, 0, TransitionTime);
		DOTween.To (() => Frame3CG.alpha, x => Frame3CG.alpha = x, 0, TransitionTime);

		CircleOne.GetComponent<Image> ().sprite = BlackCircle;
		CircleTwo.GetComponent<Image> ().sprite = ColorCircle;
		CircleThree.GetComponent<Image> ().sprite = ColorCircle;
	}

	void showFrameTwo() {
		DOTween.To (() => Frame1CG.alpha, x => Frame1CG.alpha = x, 0, TransitionTime);
		DOTween.To (() => Frame2CG.alpha, x => Frame2CG.alpha = x, 1, TransitionTime);
		DOTween.To (() => Frame3CG.alpha, x => Frame3CG.alpha = x, 0, TransitionTime);
	
		CircleOne.GetComponent<Image> ().sprite = ColorCircle;
		CircleTwo.GetComponent<Image> ().sprite = BlackCircle;
		CircleThree.GetComponent<Image> ().sprite = ColorCircle;
	}

	void showFrameThree() {
		DOTween.To (() => Frame1CG.alpha, x => Frame1CG.alpha = x, 0, TransitionTime);
		DOTween.To (() => Frame2CG.alpha, x => Frame2CG.alpha = x, 0, TransitionTime);
		DOTween.To (() => Frame3CG.alpha, x => Frame3CG.alpha = x, 1, TransitionTime);

		CircleOne.GetComponent<Image> ().sprite = ColorCircle;
		CircleTwo.GetComponent<Image> ().sprite = ColorCircle;
		CircleThree.GetComponent<Image> ().sprite = BlackCircle;
	}

	void onCloseClicked() {
		DOTween.To (() => Frame3CG.alpha, x => Frame3CG.alpha = x, 0, TransitionTime);
		DOTween.To (() => CirclePanelCG.alpha, x => CirclePanelCG.alpha = x, 0, TransitionTime);
	}
}
