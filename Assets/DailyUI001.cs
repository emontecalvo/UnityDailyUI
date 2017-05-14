using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class DailyUI001 : MonoBehaviour 
{
	public RectTransform FrameRT;
	public InputField NameIF;
	public InputField EmailIF;
	public Button SubmitButton;
	public Image BackgroundImage;
	public CanvasGroup FrameCG;
	public CanvasGroup TYFrame;
	const float TransitionTime = 1f;
	// Use this for initialization
	void Start () {

		TYFrame.gameObject.SetActive (false);
		SubmitButton.onClick.AddListener (onClick);
//		ShortcutExtensions46.DOAnchorPos;
//		MyRT.DOAnchorPos (new Vector2 (-1, 0), 1, true);

//		FrameRT.offsetMin = new Vector2 (-1000, 0);
//		FrameRT.offsetMax = new Vector2 (-1000, 0);

//		DOTween.To (() => FrameRT.offsetMin, x => FrameRT.offsetMin = x, new Vector2 (0, 0), 1f);
//		DOTween.To (() => FrameRT.offsetMax, x => FrameRT.offsetMax = x, new Vector2 (0, 0), 1f);


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
		TYFrame.gameObject.SetActive (true);
		Debug.LogFormat ("I am clicked {0}{1}", NameIF.text, EmailIF.text);

		DOTween.To (() => FrameCG.alpha, x => FrameCG.alpha = x, 0, TransitionTime);
		DOTween.To (() => TYFrame.alpha, x => TYFrame.alpha = x, 1, TransitionTime);

		FrameCG.gameObject.SetActive (true);

	}
}
