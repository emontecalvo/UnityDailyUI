using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class DailyUI004 : DailyUIBase
{
	public Text NumberDisplay;
	public float ActualNumber = 0.0f;
	public float Accumulator = 0.0f;
	public Button Zero;
	public Button One;
	public Button Two;
	public Button Three;
	public Button Four;
	public Button Five;
	public Button Six;
	public Button Seven;
	public Button Eight;
	public Button Nine;
	public Button Clear;

	public Button Minus;
	public Button Add;
	public Button Multiply;
	public Button Divide;
	public Button Equals;

	bool Added = false;
	bool Subtracted = false;
	bool Multiplied = false;
	bool Divided = false;

	void Start() {
		Zero.onClick.AddListener (OnZeroClicked);
		One.onClick.AddListener (OnOneClicked);
		Two.onClick.AddListener (OnTwoClicked);
		Three.onClick.AddListener (OnThreeClicked);
		Four.onClick.AddListener (OnFourClicked);
		Five.onClick.AddListener (OnFiveClicked);
		Six.onClick.AddListener (OnSixClicked);
		Seven.onClick.AddListener (OnSevenClicked);
		Eight.onClick.AddListener (OnEightClicked);
		Nine.onClick.AddListener (OnNineClicked);
		Clear.onClick.AddListener (OnClearClicked);

		Add.onClick.AddListener (OnAddClicked);
		Minus.onClick.AddListener (OnMinusClicked);
		Multiply.onClick.AddListener (OnMultiplyClicked);
		Divide.onClick.AddListener (OnDivideClicked);
		Equals.onClick.AddListener (OnEqualClicked);

	}

	void ActionsStop() {
		Add.interactable = false;
		Minus.interactable = false;
		Multiply.interactable = false;
		Divide.interactable = false;
	}

	void OnZeroClicked() {
		ActualNumber *= 10;
		UpdateNumberDisplay ();
	}

	void OnOneClicked() {
		ActualNumber *= 10;
		ActualNumber += 1;
		UpdateNumberDisplay ();
	}

	void OnTwoClicked() {
		ActualNumber *= 10;
		ActualNumber += 2;
		UpdateNumberDisplay ();
	}

	void OnThreeClicked() {
		ActualNumber *= 10;
		ActualNumber += 3;
		UpdateNumberDisplay ();
	}

	void OnFourClicked() {
		ActualNumber *= 10;
		ActualNumber += 4;
		UpdateNumberDisplay ();
	}

	void OnFiveClicked() {
		ActualNumber *= 10;
		ActualNumber += 5;
		UpdateNumberDisplay ();
	}

	void OnSixClicked() {
		ActualNumber *= 10;
		ActualNumber += 6;
		UpdateNumberDisplay ();
	}

	void OnSevenClicked() {
		ActualNumber *= 10;
		ActualNumber += 7;
		UpdateNumberDisplay ();
	}
	
	void OnEightClicked() {
		ActualNumber *= 10;
		ActualNumber += 8;
		UpdateNumberDisplay ();
	}

	void OnNineClicked() {
		ActualNumber *= 10;
		ActualNumber += 9;
		UpdateNumberDisplay ();
	}

	void OnClearClicked() {
		ActualNumber = 0;
		UpdateNumberDisplay ();
	}
	
	void OnAddClicked() {
		Accumulator = ActualNumber;
		ActualNumber = 0;
		Added = true;
		Subtracted = false;
		Multiplied = false;
		Divided = false;
		ActionsStop ();
	}

	void OnMinusClicked() {
		Accumulator = ActualNumber;
		ActualNumber = 0;
		Subtracted = true;
		Added = false;
		Multiplied = false;
		Divided = false;
		ActionsStop ();
	}
	
	void OnMultiplyClicked() {
		Accumulator = ActualNumber;
		ActualNumber = 0;
		Added = false;
		Subtracted = false;
		Multiplied = true;
		Divided = false;
		ActionsStop ();
	}

	void OnDivideClicked() {
		Accumulator = ActualNumber;
		ActualNumber = 0;
		Added = false;
		Subtracted = false;
		Multiplied = false;
		Divided = true;
		ActionsStop ();
	}
	
	void OnEqualClicked() {
		if (Added == true) {
			ActualNumber += Accumulator;
		} else if (Subtracted == true) {
			Accumulator -= ActualNumber;
			ActualNumber = Accumulator;
		} else if (Multiplied == true) {
			ActualNumber *= Accumulator;
		} else if (Divided == true) {
			Accumulator /= ActualNumber;
			ActualNumber = Accumulator;
		}

		UpdateNumberDisplay ();

		Add.interactable = true;
		Minus.interactable = true;
		Multiply.interactable = true;
		Divide.interactable = true;

		Added = false;
		Subtracted = false;
		Multiplied = false;
		Subtracted = false;
	}

	void UpdateNumberDisplay() {
		NumberDisplay.text = ActualNumber.ToString();
	}
}



