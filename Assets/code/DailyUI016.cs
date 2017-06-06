using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class DailyUI016 : DailyUIBase 
{
	public RectTransform ThankYouRT;
	public Image BackgroundImage;

	public Button CloseButton;


	public CanvasGroup ThankYouFrameCG;
	public CanvasGroup ElwoodLovesYouFrame;

	const float TransitionTime = 2f;


	void Start () {
		CloseButton.onClick.AddListener (onCloseClicked);

		Vector3 dest = ThankYouRT.localPosition;
		Vector3 start = dest + new Vector3 (-500, 0, 0);

		ThankYouRT.localPosition = start;
		DOTween.To (() => ThankYouRT.localPosition, x => ThankYouRT.localPosition = x, dest, TransitionTime);

		Color DestColor = BackgroundImage.color;
		Color StartColor = DestColor;
		StartColor.a = 0;
		BackgroundImage.color = StartColor;
		DOTween.To (() => BackgroundImage.color, x => BackgroundImage.color = x, DestColor, TransitionTime);
	}

	void onCloseClicked() {
		Debug.Log ("CLOSE IS CLICKED");
		DOTween.To (() => ThankYouFrameCG.alpha, x => ThankYouFrameCG.alpha = x, 0, TransitionTime);
		DOTween.To (() => ElwoodLovesYouFrame.alpha, x => ElwoodLovesYouFrame.alpha = x, 1, TransitionTime);
	}
}
