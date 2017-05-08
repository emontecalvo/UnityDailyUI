using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DailyUI001 : MonoBehaviour 
{
	public InputField NameIF;
	public InputField EmailIF;
	public Button SubmitButton;
	// Use this for initialization
	void Start () {
		SubmitButton.onClick.AddListener (onClick);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onClick() {
		Debug.LogFormat ("I am clicked {0}{1}", NameIF.text, EmailIF.text);
//		NameIF.text = null;
//		EmailIF.text = null;
	}
}
