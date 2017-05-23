using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class DailyUI009 : DailyUIBase
{
	public Button PlayOrPauseBtn;
	public Button PreviousSongBtn;
	public Button NextSongBtn;
	public Button HeartBtn;
	public Text MusicPlayedTxt;
	public Text MusicLeftTxt;
	public Slider MusicBarSlider;
	public Sprite PlayImage;
	public Sprite PauseImage;
	public Sprite HeartEmpty;
	public Sprite HeartFull;

	bool PlayMusic = false;
	bool HeartClickedBool = false;

	void Start() {
		PlayOrPauseBtn.onClick.AddListener (PlayPauseClicked);
		HeartBtn.onClick.AddListener (HeartClicked);
	
	}

	void PlayPauseClicked(){
		if (!PlayMusic) {
			PlayMusic = true;
			PlayOrPauseBtn.image.sprite = PlayImage;

		} else {
			PlayMusic = false;
			PlayOrPauseBtn.image.sprite = PauseImage;
		}
	}

	void HeartClicked(){
		if (!HeartClickedBool) {
			HeartBtn.image.sprite = HeartFull;
			HeartClickedBool = true;
		} else {
			HeartBtn.image.sprite = HeartEmpty;
			HeartClickedBool = false;
		}
	}


}
