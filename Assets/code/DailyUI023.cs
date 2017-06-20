using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class DailyUI023 : DailyUIBase 
{
//	public RectTransform FrameRT;
//	public InputField NameIF;
//	public InputField EmailIF;
//	public Button SubmitButton;
//	public Image BackgroundImage;
//	public CanvasGroup FrameCG;
//	public CanvasGroup TYFrame;
//	const float TransitionTime = 1f;
//
//	void Start () {
//
//		TYFrame.gameObject.SetActive (false);
//		SubmitButton.onClick.AddListener (onClick);
//
//
//
//		Vector3 dest = FrameRT.localPosition;
//		Vector3 start = dest + new Vector3 (-500, 0, 0);
//
//		FrameRT.localPosition = start;
//		DOTween.To (() => FrameRT.localPosition, x => FrameRT.localPosition = x, dest, TransitionTime);
//
//		Color DestColor = BackgroundImage.color;
//		Color StartColor = DestColor;
//		StartColor.a = 0;
//		BackgroundImage.color = StartColor;
//		DOTween.To (() => BackgroundImage.color, x => BackgroundImage.color = x, DestColor, TransitionTime);
//	}
//
//
//	void Update () {
//
//	}
//
//	void onClick() {
//		TYFrame.gameObject.SetActive (true);
//		Debug.LogFormat ("I am clicked {0}{1}", NameIF.text, EmailIF.text);
//
//		DOTween.To (() => FrameCG.alpha, x => FrameCG.alpha = x, 0, TransitionTime);
//		DOTween.To (() => TYFrame.alpha, x => TYFrame.alpha = x, 1, TransitionTime);
//
//		FrameCG.gameObject.SetActive (true);
//
//	}
}
