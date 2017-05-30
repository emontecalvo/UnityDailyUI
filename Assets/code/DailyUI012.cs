using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class DailyUI012 : DailyUIBase 
{
	public RectTransform FrameRT;

	public Button BuyButton;
	public Image BackgroundImage;
	public CanvasGroup BuyFrameCG;
	public CanvasGroup CheckoutFrame;
	const float TransitionTime = 1f;
	// Use this for initialization
	void Start () {

		CheckoutFrame.gameObject.SetActive (false);
		BuyButton.onClick.AddListener (onClick);


		Vector3 dest = FrameRT.localPosition;
		Vector3 start = dest + new Vector3 (-500, 0, 0);

		FrameRT.localPosition = start;
		DOTween.To (() => FrameRT.localPosition, x => FrameRT.localPosition = x, dest, TransitionTime);

		Color DestColor = BackgroundImage.color;
		Color StartColor = DestColor;
		StartColor.a = 0;
		BackgroundImage.color = StartColor;
		DOTween.To (() => BackgroundImage.color, x => BackgroundImage.color = x, DestColor, TransitionTime);
	}

	// Update is called once per frame
	void Update () {

	}

	void onClick() {
		CheckoutFrame.gameObject.SetActive (true);

		DOTween.To (() => BuyFrameCG.alpha, x => BuyFrameCG.alpha = x, 0, TransitionTime);
		DOTween.To (() => CheckoutFrame.alpha, x => CheckoutFrame.alpha = x, 1, TransitionTime);

		BuyFrameCG.gameObject.SetActive (true);

	}
}
