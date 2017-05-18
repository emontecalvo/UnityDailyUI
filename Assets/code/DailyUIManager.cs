using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class DailyUIManager : MonoBehaviour {
	
	public List<DailyUIBase> DaysList = new List<DailyUIBase>();
	public int CurrentDay;
	public Button PreviousBtn;
	public Button NextBtn;

	void Start () {
		SetCurrentDay (0);
		PreviousBtn.onClick.AddListener (onPreviousClicked);
		NextBtn.onClick.AddListener (onNextClicked);
	}

	void SetCurrentDay(int dayiwant){
		CurrentDay = dayiwant;
		for (int i = 0; i < DaysList.Count; i++) {
			DailyUIBase day = DaysList[i];
			if (i == dayiwant) {
				day.MakeActive();
			} else {
				day.MakeInactive();
			}
		}
	}

	void onPreviousClicked () {
		if (CurrentDay == 0) {
			SetCurrentDay(DaysList.Count - 1);
		} else {
			SetCurrentDay (CurrentDay - 1);	
		}

	}

	void onNextClicked() {
		if (CurrentDay == DaysList.Count - 1) {
			SetCurrentDay (0);
		} else {
			SetCurrentDay (CurrentDay + 1);
		}

	}



	// Update is called once per frame
	void Update () {
	
	}
}
