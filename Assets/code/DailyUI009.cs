using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
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
	public AudioSource MusicPlayer;
	public List<AudioClip> ClipsList;
	public int CurrentClip = 0;

	bool PlayMusic = false;
	bool HeartClickedBool = false;

	void Start() {
		PlayOrPauseBtn.onClick.AddListener (PlayPauseClicked);
		HeartBtn.onClick.AddListener (HeartClicked);
		MusicBarSlider.maxValue = ClipsList [CurrentClip].length;
		MusicBarSlider.onValueChanged.AddListener (OnSkipAround);
	
	}

	void PlayPauseClicked(){
		if (!PlayMusic) {
			PlayMusic = true;
			PlayOrPauseBtn.image.sprite = PlayImage;
			MusicPlayer.Pause ();

		} else {
			PlayMusic = false;
			PlayOrPauseBtn.image.sprite = PauseImage;
			MusicPlayer.clip = ClipsList [CurrentClip];
			MusicPlayer.Play ();
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

	void OnSkipAround(float f){
		MusicPlayer.time = f;
	}

	void Update() {
		MusicBarSlider.value = MusicPlayer.time;
		MusicPlayedTxt.text = MusicPlayer.time.ToString();
		MusicLeftTxt.text = (ClipsList [CurrentClip].length - MusicPlayer.time).ToString();
	}

}
