using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class DailyUI022 : DailyUIBase 
{
	public CanvasGroup SearchFrameCG;
	public CanvasGroup ResultsFrameCG;
	public Button SearchButton;

	public InputField SearchTxt;
	public Text ResultOneTxt;
	public Text ResultTwoTxt;
	public Text ResultThreeTxt;

	const float TransitionTime = 1f;
	const float TransitionTime2 = 2f;

	bool SearchClicked = false;

	void Start () {
		SearchButton.onClick.AddListener (OnSearchClicked);
		DOTween.To (() => SearchFrameCG.alpha, x => SearchFrameCG.alpha = x, 1, TransitionTime).OnComplete(ResultsFadeIn);
	}

	void ResultsFadeIn() {
		DOTween.To (() => ResultsFrameCG.alpha, x => ResultsFrameCG.alpha = x, 1, TransitionTime2);
	}

	void Update () {
		if (SearchTxt.text == "") {
			SearchClicked = false;
		} else if (!SearchClicked) {
			ResultOneTxt.text = SearchTxt.text;
			ResultTwoTxt.text = SearchTxt.text;
			ResultThreeTxt.text = SearchTxt.text;
		}
	}

	void OnGUI() {
		Event e = Event.current;
		if (e.keyCode == KeyCode.Return) {
			OnSearchClicked ();
		}
	}

	void OnSearchClicked() {
		SearchClicked = true;
		ResultOneTxt.text = (SearchTxt.text + " people");
		ResultTwoTxt.text = (SearchTxt.text + " world");
		ResultThreeTxt.text = (SearchTxt.text + " there");
	}
}
