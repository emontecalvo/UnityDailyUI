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

	const float TransitionTime = 5f;

	void Start(){
		SliderFadeIn ();
		HomeTempSlider.onValueChanged.AddListener (OnTempChanged);
	}

	void SliderFadeIn(){
		DOTween.To (() => SliderPanelCG.alpha, x => SliderPanelCG.alpha = x, 1, TransitionTime);
	}

	void OnTempChanged (float f) {
		TemperatureText.text = f.ToString();
	}
}
