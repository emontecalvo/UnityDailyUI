using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class DailyUI007 : DailyUIBase
{
	public Slider VolumeSlider;
	public Slider DaysSlider;
	public Slider MoraleSlider;
	public Slider RandomEventsSlider;

	public Text VolumeTxt;
	public Text DaysTxt;
	public Text MoraleTxt;
	public Text RandomEventsTxt;
	const float TransitionTime = 3f;

	void Start() {
		VolumeSlider.onValueChanged.AddListener (OnVolumeChanged);
		DaysSlider.onValueChanged.AddListener (OnDaysChanged);
		MoraleSlider.onValueChanged.AddListener (OnMoraleChanged);
		RandomEventsSlider.onValueChanged.AddListener (OnRandomChanged);

		// command R = rename

		float VolumeStart = 100;
		float VolumeDestination = 0;
		VolumeSlider.value = VolumeStart;

		float DaysStart = 45;
		float DaysDestination = 0;
		DaysSlider.value = DaysStart;

		float MoraleStart = 100;
		float MoraleDestination = 0;
		MoraleSlider.value = MoraleStart;

		float RandomEventsStart = 30;
		float RandomEventsDestination = 0;
		RandomEventsSlider.value = RandomEventsStart;



		DOTween.To (() => VolumeSlider.value, x => VolumeSlider.value = x, VolumeDestination, TransitionTime);
		DOTween.To (() => DaysSlider.value, x => DaysSlider.value = x, DaysDestination, TransitionTime);
		DOTween.To (() => MoraleSlider.value, x => MoraleSlider.value = x, MoraleDestination, TransitionTime);
		DOTween.To (() => RandomEventsSlider.value, x => RandomEventsSlider.value = x, RandomEventsDestination, TransitionTime);















	}

	void OnVolumeChanged(float f) {
		VolumeTxt.text = f.ToString() + "%";
	}

	void OnDaysChanged(float f) {
		DaysTxt.text = f.ToString();
	}

	void OnMoraleChanged(float f) {
		MoraleTxt.text = f.ToString() + "%";
	}

	void OnRandomChanged(float f) {
		RandomEventsTxt.text = f.ToString();
	}
}

