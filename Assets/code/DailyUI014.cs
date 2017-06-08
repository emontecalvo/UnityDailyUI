using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

public class DailyUI014 : DailyUIBase
{
	public CanvasGroup FullCloudCG;
	public CanvasGroup ThreeQuarterCloudCG;
	public CanvasGroup HalfCloudCG;
	public CanvasGroup QuarterCloudCG;
	public CanvasGroup EmptyCloudCG;

	public CanvasGroup UmbrellaOneCG;
	public CanvasGroup UmbrellaTwoCG;
	public CanvasGroup UmbrellaThreeCG;
	public CanvasGroup UmbrellaFourCG;
	public CanvasGroup UmbrellaFiveCG;

	public CanvasGroup DarkBackgroundCG;
	public CanvasGroup LightBackgroundCG;

	public Text MinuteTxt;
	public Text DecaSecondsTxt;
	public Text OnesSecondsTxt;

	public int EnableTime = 0;
	public int CountdownTime = 120;

	const float TransitionTime = 2f;
	const float UmbrellaTransitionTime = 1.7f;

	void Start(){
		ThreeQuarterFadeIn ();
	}

	void ThreeQuarterFadeIn (){
		DOTween.To (() => FullCloudCG.alpha, x => FullCloudCG.alpha = x, 0, TransitionTime);
		DOTween.To (() => UmbrellaOneCG.alpha, x => UmbrellaOneCG.alpha = x, 0, UmbrellaTransitionTime);
		DOTween.To (() => UmbrellaTwoCG.alpha, x => UmbrellaTwoCG.alpha = x, 1, UmbrellaTransitionTime);
		DOTween.To (() => ThreeQuarterCloudCG.alpha, x => ThreeQuarterCloudCG.alpha = x, 1, TransitionTime).OnComplete(HalfFadeIn);
	}

	void HalfFadeIn(){
		DOTween.To (() => ThreeQuarterCloudCG.alpha, x => ThreeQuarterCloudCG.alpha = x, 0, TransitionTime);
		DOTween.To (() => UmbrellaTwoCG.alpha, x => UmbrellaTwoCG.alpha = x, 0, UmbrellaTransitionTime);
		DOTween.To (() => UmbrellaThreeCG.alpha, x => UmbrellaThreeCG.alpha = x, 1, UmbrellaTransitionTime);
		DOTween.To (() => HalfCloudCG.alpha, x => HalfCloudCG.alpha = x, 1, TransitionTime).OnComplete(QuarterFadeIn);
	}

	void QuarterFadeIn(){
		DOTween.To (() => HalfCloudCG.alpha, x => HalfCloudCG.alpha = x, 0, TransitionTime);
		DOTween.To (() => UmbrellaThreeCG.alpha, x => UmbrellaThreeCG.alpha = x, 0, UmbrellaTransitionTime);
		DOTween.To (() => UmbrellaFourCG.alpha, x => UmbrellaFourCG.alpha = x, 1, UmbrellaTransitionTime);
		DOTween.To (() => QuarterCloudCG.alpha, x => QuarterCloudCG.alpha = x, 1, TransitionTime).OnComplete(EmptyFadeIn);
	}

	void EmptyFadeIn(){
		DOTween.To (() => QuarterCloudCG.alpha, x => QuarterCloudCG.alpha = x, 0, TransitionTime);
		DOTween.To (() => UmbrellaFourCG.alpha, x => UmbrellaFourCG.alpha = x, 0, UmbrellaTransitionTime);
		DOTween.To (() => UmbrellaFiveCG.alpha, x => UmbrellaFiveCG.alpha = x, 1, UmbrellaTransitionTime);
		DOTween.To (() => DarkBackgroundCG.alpha, x => DarkBackgroundCG.alpha = x, 0, UmbrellaTransitionTime);
		DOTween.To (() => LightBackgroundCG.alpha, x => LightBackgroundCG.alpha = x, 1, UmbrellaTransitionTime);
		DOTween.To (() => EmptyCloudCG.alpha, x => EmptyCloudCG.alpha = x, 1, TransitionTime).OnComplete(FullFadeIn);
	}

	void FullFadeIn(){
		DOTween.To (() => EmptyCloudCG.alpha, x => EmptyCloudCG.alpha = x, 0, TransitionTime);
		DOTween.To (() => UmbrellaFiveCG.alpha, x => UmbrellaFiveCG.alpha = x, 0, UmbrellaTransitionTime);
		DOTween.To (() => UmbrellaOneCG.alpha, x => UmbrellaOneCG.alpha = x, 1, UmbrellaTransitionTime);
		DOTween.To (() => LightBackgroundCG.alpha, x => LightBackgroundCG.alpha = x, 0, UmbrellaTransitionTime);
		DOTween.To (() => DarkBackgroundCG.alpha, x => DarkBackgroundCG.alpha = x, 1, UmbrellaTransitionTime);
		DOTween.To (() => FullCloudCG.alpha, x => FullCloudCG.alpha = x, 1, TransitionTime).OnComplete(ThreeQuarterFadeIn);
	}

	void Update() {
		ShowCountdown ();
		Debug.Log (Time.time.ToString () + " dt:" + Time.deltaTime.ToString());
	}

	// OnEnable = built-in Unity function, just like Update
	// OnEnable gets called only when this component is actually active in the scene
	void OnEnable() {
		EnableTime = (int)Time.time;
	}

	void ShowCountdown() {
		int currentTime = (int)Time.time;
		int timePassed = currentTime - EnableTime;
		int remainingSeconds = CountdownTime - timePassed;

		int minuteInt = remainingSeconds / 60;
		int deciInt = remainingSeconds % 60 / 10;
		int secondInt = remainingSeconds % 10;

		MinuteTxt.text = minuteInt.ToString ();
		DecaSecondsTxt.text = deciInt.ToString ();
		OnesSecondsTxt.text = secondInt.ToString ();
	}
}
