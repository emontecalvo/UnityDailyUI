using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

public class DailyUI021 : DailyUIBase
{
	public CanvasGroup SliderPanelCG;
	public Slider HomeTempSlider;
	public Text TemperatureText;

	public RectTransform CircleSlider;

	const float TransitionTime = 5f;

	public AnimationCurve TempToYOffset = new AnimationCurve();

	void Start(){
		SliderFadeIn ();
		HomeTempSlider.onValueChanged.AddListener (OnTempChanged);
	}

	void SliderFadeIn(){
		DOTween.To (() => SliderPanelCG.alpha, x => SliderPanelCG.alpha = x, 1, TransitionTime);
	}

	void OnTempChanged (float temp) {
		float yOffset = TempToYOffset.Evaluate (temp);
		TemperatureText.text = temp.ToString();
		CircleSlider.localPosition = new Vector3 (0, yOffset, 0);
	}
}
