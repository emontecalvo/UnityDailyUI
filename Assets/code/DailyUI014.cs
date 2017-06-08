using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

public class DailyUI014 : DailyUIBase
{
	public CanvasGroup FullCloudCG;

	public CanvasGroup UmbrellaOneCG;
	public CanvasGroup UmbrellaTwoCG;
	public CanvasGroup UmbrellaThreeCG;
	public CanvasGroup UmbrellaFourCG;
	public CanvasGroup UmbrellaFiveCG;

	public CanvasGroup DarkBackgroundCG;
	public CanvasGroup LightBackgroundCG;

	public Image CloudOfRain;

	public Text MinuteTxt;
	public Text DecaSecondsTxt;
	public Text OnesSecondsTxt;
	int RemainingSeconds = 2;

	public int EnableTime = 0;
	public int CountdownTime = 65;

	const float TransitionTime = 2f;
	const float UmbrellaTransitionTime = 1.7f;

	bool CloudEmpty = false;

	void Start(){
		UmbrellaTwoFadeIn ();
	}

	void UmbrellaTwoFadeIn (){
		DOTween.To (() => UmbrellaOneCG.alpha, x => UmbrellaOneCG.alpha = x, 0, UmbrellaTransitionTime);
		if (!CloudEmpty) {
			DOTween.To (() => UmbrellaTwoCG.alpha, x => UmbrellaTwoCG.alpha = x, 1, UmbrellaTransitionTime).OnComplete (UmbrellaThreeFadeIn);
		} else {
			DOTween.To (() => UmbrellaOneCG.alpha, x => UmbrellaOneCG.alpha = x, 0, UmbrellaTransitionTime);
			RainOrShineFadeIn ();
		}
	}

	void UmbrellaThreeFadeIn(){
		DOTween.To (() => UmbrellaTwoCG.alpha, x => UmbrellaTwoCG.alpha = x, 0, UmbrellaTransitionTime);
		if (!CloudEmpty) {
			DOTween.To (() => UmbrellaThreeCG.alpha, x => UmbrellaThreeCG.alpha = x, 1, UmbrellaTransitionTime).OnComplete (UmbrellaFourFadeIn);
		} else {
			RainOrShineFadeIn ();
		}
	}

	void UmbrellaFourFadeIn(){
		DOTween.To (() => UmbrellaThreeCG.alpha, x => UmbrellaThreeCG.alpha = x, 0, UmbrellaTransitionTime);
		if (!CloudEmpty) {
			DOTween.To (() => UmbrellaFourCG.alpha, x => UmbrellaFourCG.alpha = x, 1, UmbrellaTransitionTime).OnComplete (RainOrShineFadeIn);
		} else {
			RainOrShineFadeIn ();
		}
	}

	void RainOrShineFadeIn(){
		if (CloudEmpty) {
			DOTween.To (() => UmbrellaFourCG.alpha, x => UmbrellaFourCG.alpha = x, 0, UmbrellaTransitionTime);
			DOTween.To (() => UmbrellaFiveCG.alpha, x => UmbrellaFiveCG.alpha = x, 1, UmbrellaTransitionTime);
			DOTween.To (() => DarkBackgroundCG.alpha, x => DarkBackgroundCG.alpha = x, 0, UmbrellaTransitionTime);
			DOTween.To (() => LightBackgroundCG.alpha, x => LightBackgroundCG.alpha = x, 1, UmbrellaTransitionTime);
		} else {
			DOTween.To (() => UmbrellaFourCG.alpha, x => UmbrellaFourCG.alpha = x, 0, UmbrellaTransitionTime);
			DOTween.To (() => UmbrellaOneCG.alpha, x => UmbrellaOneCG.alpha = x, 1, UmbrellaTransitionTime).OnComplete(UmbrellaTwoFadeIn);
		}
	}

	void Update() {
		if (RemainingSeconds != 0) {
			ShowCountdown ();
			CloudOfRain.fillAmount -= 1.0f / CountdownTime * Time.deltaTime;
		}
//		Debug.Log (Time.time.ToString () + " dt:" + Time.deltaTime.ToString());
	}

	// OnEnable = built-in Unity function, just like Update
	// OnEnable gets called only when this component is actually active in the scene
	void OnEnable() {
		EnableTime = (int)Time.time;
	}

	void ShowCountdown() {
		int currentTime = (int)Time.time;
		int timePassed = currentTime - EnableTime;
		RemainingSeconds = CountdownTime - timePassed;

		int minuteInt = RemainingSeconds / 60;
		int deciInt = RemainingSeconds % 60 / 10;
		int secondInt = RemainingSeconds % 10;

		MinuteTxt.text = minuteInt.ToString ();
		DecaSecondsTxt.text = deciInt.ToString ();
		OnesSecondsTxt.text = secondInt.ToString ();

		if (RemainingSeconds == 1 || RemainingSeconds == 0) {
			CloudEmpty = true;
		}
	}
}
