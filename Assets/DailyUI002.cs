using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class DailyUI002 : DailyUIBase
{
	public RectTransform MainFrame;

	public Button PayContinueBtn;
	public Button AddressContinueBtn;
	public Button ConfirmOrderBtn;

	public Image BackgroundImage002;

	public CanvasGroup MainFrameCG;
	public CanvasGroup AddressFrameCG;
	public CanvasGroup ConfirmFrameCG;
	public CanvasGroup Thankyou002FrameCG;

	const float TransitionTime002 = 1f;

	void Start () {
		PayContinueBtn.onClick.AddListener (onClick);
		AddressFrameCG.gameObject.SetActive (false);
		ConfirmFrameCG.gameObject.SetActive (false);
		Thankyou002FrameCG.gameObject.SetActive (false);

		Vector3 dest = MainFrame.localPosition;
		Vector3 start = dest + new Vector3 (-500, 0, 0);
		
		MainFrame.localPosition = start;
		DOTween.To (() => MainFrame.localPosition, x => MainFrame.localPosition = x, dest, TransitionTime002);
		
		Color DestColor = BackgroundImage002.color;
		Color StartColor = DestColor;
		StartColor.a = 0;
		BackgroundImage002.color = StartColor;
		DOTween.To (() => BackgroundImage002.color, x => BackgroundImage002.color = x, DestColor, TransitionTime002);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void onClick() {
		AddressFrameCG.gameObject.SetActive (true);
		DOTween.To (() => MainFrameCG.alpha, x => MainFrameCG.alpha = x, 0, TransitionTime002);
		DOTween.To (() => AddressFrameCG.alpha, x => AddressFrameCG.alpha = x, 1, TransitionTime002);
		AddressContinueBtn.onClick.AddListener (onSecondClick);
		MainFrameCG.gameObject.SetActive (false);
	}

	void onSecondClick() {
		ConfirmFrameCG.gameObject.SetActive (true);
		DOTween.To (() => AddressFrameCG.alpha, x => AddressFrameCG.alpha = x, 0, TransitionTime002);
		DOTween.To (() => ConfirmFrameCG.alpha, x => ConfirmFrameCG.alpha = x, 1, TransitionTime002);
		ConfirmOrderBtn.onClick.AddListener (onThirdClick);
		AddressFrameCG.gameObject.SetActive (false);
	}

	void onThirdClick() {
		Thankyou002FrameCG.gameObject.SetActive (true);
		DOTween.To (() => ConfirmFrameCG.alpha, x => ConfirmFrameCG.alpha = x, 0, TransitionTime002);
		DOTween.To (() => Thankyou002FrameCG.alpha, x => Thankyou002FrameCG.alpha = x, 1, TransitionTime002);
		ConfirmFrameCG.gameObject.SetActive (false);
	}
}













