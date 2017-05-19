using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class DailyUI006 : DailyUIBase
{
	public Text NumOfFollowers;
	public Text FollowOrNot;
	public Button Follow;
	public long ActualNumber;

	bool IsFollowing = false;

	void Start(){
		Follow.onClick.AddListener (FollowCheck);
	}

	void FollowCheck(){
		if (IsFollowing == false) {
			ActualNumber += 1;
			FollowOrNot.text = "unfollow";
			IsFollowing = true;
			UpdateDisplay ();
		} else {
			ActualNumber -= 1;
			FollowOrNot.text = "follow";
			IsFollowing = false;
			UpdateDisplay ();
		}
	}

	void UpdateDisplay(){
		NumOfFollowers.text = ActualNumber.ToString("N0");
	}
}

