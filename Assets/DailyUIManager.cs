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
	public Camera UICamera;
	public float ScaleReference = 600;
//	public AspectRatioFitter EnvelopeAF;
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
		UICamera.orthographicSize = Envelope.sizeDelta.y / 2;
//		float s = Envelope.sizeDelta.y / ScaleReference;
//		Envelope.localScale = new Vector3 (s, s, s);
//		var t = Envelope.sizeDelta;
//		t.x /= s;
//		t.y /= s;
//		Envelope.sizeDelta = t;
	}
	void Start () {
	
	}


	// Update is called once per frame
	void Update () {
	
	}
}
