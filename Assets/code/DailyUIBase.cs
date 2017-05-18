using UnityEngine;
using System.Collections;

public class DailyUIBase : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void MakeActive() {
		gameObject.SetActive (true);
	}

	public void MakeInactive() {
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
