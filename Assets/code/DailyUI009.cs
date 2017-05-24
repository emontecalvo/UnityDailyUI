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

	public Image CurrentImg;
	public Image PreviousImg;
	public Image NextImg;

	public AudioSource MusicPlayer;
	public List<AudioClip> ClipsList;
	public List<Sprite> CoverImgList;
	public int CurrentClip = 0;

	bool PlayMusic = false;
	bool HeartClickedBool = false;

	void Start() {
		PlayOrPauseBtn.onClick.AddListener (PlayPauseClicked);
		HeartBtn.onClick.AddListener (HeartClicked);
		MusicBarSlider.maxValue = ClipsList [CurrentClip].length;
		MusicBarSlider.onValueChanged.AddListener (OnSkipAround);

		PreviousSongBtn.onClick.AddListener (OnPreviousClicked);
		NextSongBtn.onClick.AddListener (OnNextClicked);
	
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

	void OnPreviousClicked(){
		MusicPlayer.Stop ();
		if (CurrentClip == 0) {
			CurrentClip = 2;
		} else {
			CurrentClip -= 1;
		}
		CurrentImg.sprite = CoverImgList [CurrentClip];
		if (CurrentClip == 2) {
			NextImg.sprite = CoverImgList [0];
		} else {
			NextImg.sprite = CoverImgList [CurrentClip + 1];
		}
		if (CurrentClip == 0) {
			PreviousImg.sprite = CoverImgList [2];
		} else {
			PreviousImg.sprite = CoverImgList [CurrentClip - 1];
		}


		MusicPlayer.clip = ClipsList [CurrentClip];
		MusicPlayer.time = 0;
		MusicBarSlider.value = 0;
		MusicPlayer.Play ();
	}

	void OnNextClicked() {
		MusicPlayer.Stop ();
		if (CurrentClip == 2) {
			CurrentClip = 0;
		} else {
			CurrentClip += 1;
		}
		CurrentImg.sprite = CoverImgList [CurrentClip];
		if (CurrentClip == 2) {
			NextImg.sprite = CoverImgList [0];
		} else {
			NextImg.sprite = CoverImgList [CurrentClip + 1];
		}
		if (CurrentClip == 0) {
			PreviousImg.sprite = CoverImgList [2];
		} else {
			PreviousImg.sprite = CoverImgList [CurrentClip - 1];
		}
		MusicPlayer.clip = ClipsList [CurrentClip];
		MusicPlayer.time = 0;
		MusicBarSlider.value = 0;
		MusicPlayer.Play ();
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
