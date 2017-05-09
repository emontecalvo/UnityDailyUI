using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DailyUIManager : MonoBehaviour {
	public enum EScreenType{
		GalaxyS6, 
		IPhone7,
		Dev
	};
	public EScreenType ScreenType;
	public RectTransform Envelope;
	// Use this for initialization

	void OnValidate () {
		if (ScreenType == EScreenType.GalaxyS6) {
			Envelope.sizeDelta = new Vector2(1440, 2560);
		} 
		if (ScreenType == EScreenType.IPhone7) {
			Envelope.sizeDelta = new Vector2(750, 1334);
		} 
		if (ScreenType == EScreenType.Dev) {
			Envelope.sizeDelta = new Vector2(720, 1080);
		} 
	}
	void Start () {
	
	}


	// Update is called once per frame
	void Update () {
	
	}
}
