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

	public Button PlusBtn;
	public Button MinusBtn;
	public Text TotalTxt;
	int TotalNum = 129;

	const float TransitionTime = 1f;
	// Use this for initialization
	void Start () {

		CheckoutFrame.gameObject.SetActive (false);
		BuyButton.onClick.AddListener (onClick);
		PlusBtn.onClick.AddListener (onPlusClicked);
		MinusBtn.onClick.AddListener (onMinusClicked);


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

	void UpdateTotalDisplay() {
		TotalTxt.text = "$" + TotalNum.ToString();
	}

	void onClick() {
		CheckoutFrame.gameObject.SetActive (true);

		DOTween.To (() => BuyFrameCG.alpha, x => BuyFrameCG.alpha = x, 0, TransitionTime);
		DOTween.To (() => CheckoutFrame.alpha, x => CheckoutFrame.alpha = x, 1, TransitionTime);

		BuyFrameCG.gameObject.SetActive (true);

	}

	void onPlusClicked(){
		TotalNum += 129;
		UpdateTotalDisplay ();
	}

	void onMinusClicked(){
		if (TotalNum > 0) {
			TotalNum -= 129;
		} else {
			TotalNum = 0;
		}
		UpdateTotalDisplay ();
	}
}
