using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class DailyUI025 : DailyUIBase 
{
	public CanvasGroup MovieCG;
	public CanvasGroup TVCG;
	public CanvasGroup GamesCG;
	public CanvasGroup MusicCG;

	public Button MovieBtn;
	public Button TVBtn;
	public Button GamesBtn;
	public Button MusicBtn;

	public Sprite MovieGreen;
	public Sprite MovieWhite;
	public Sprite TVGreen;
	public Sprite TVWhite;
	public Sprite MusicGreen;
	public Sprite MusicWhite;
	public Sprite GamesWhite;
	public Sprite GamesGreen;

	const float TransitionTime = 1f;

	void Start () {

		MovieBtn.onClick.AddListener (onMovieClicked);
		TVBtn.onClick.AddListener (onTVClicked);
		GamesBtn.onClick.AddListener (onGamesClicked);
		MusicBtn.onClick.AddListener (onMusicClicked);

		DOTween.To (() => MovieCG.alpha, x => MovieCG.alpha = x, 1, TransitionTime);
	}

	void onMovieClicked() {
		MovieBtn.GetComponent<Image> ().sprite = MovieGreen;
		TVBtn.GetComponent<Image> ().sprite = TVWhite;
		MusicBtn.GetComponent<Image> ().sprite = MusicWhite;
		GamesBtn.GetComponent<Image> ().sprite = GamesWhite;

		DOTween.To (() => MovieCG.alpha, x => MovieCG.alpha = x, 1, TransitionTime);
		DOTween.To (() => TVCG.alpha, x => TVCG.alpha = x, 0, TransitionTime);
		DOTween.To (() => MusicCG.alpha, x => MusicCG.alpha = x, 0, TransitionTime);
		DOTween.To (() => GamesCG.alpha, x => GamesCG.alpha = x, 0, TransitionTime);
	}

	void onTVClicked() {
		MovieBtn.GetComponent<Image> ().sprite = MovieWhite;
		TVBtn.GetComponent<Image> ().sprite = TVGreen;
		MusicBtn.GetComponent<Image> ().sprite = MusicWhite;
		GamesBtn.GetComponent<Image> ().sprite = GamesWhite;

		DOTween.To (() => MovieCG.alpha, x => MovieCG.alpha = x, 0, TransitionTime);
		DOTween.To (() => TVCG.alpha, x => TVCG.alpha = x, 1, TransitionTime);
		DOTween.To (() => MusicCG.alpha, x => MusicCG.alpha = x, 0, TransitionTime);
		DOTween.To (() => GamesCG.alpha, x => GamesCG.alpha = x, 0, TransitionTime);
	}

	void onMusicClicked() {
		MovieBtn.GetComponent<Image> ().sprite = MovieWhite;
		TVBtn.GetComponent<Image> ().sprite = TVWhite;
		MusicBtn.GetComponent<Image> ().sprite = MusicGreen;
		GamesBtn.GetComponent<Image> ().sprite = GamesWhite;

		DOTween.To (() => MovieCG.alpha, x => MovieCG.alpha = x, 0, TransitionTime);
		DOTween.To (() => TVCG.alpha, x => TVCG.alpha = x, 0, TransitionTime);
		DOTween.To (() => MusicCG.alpha, x => MusicCG.alpha = x, 1, TransitionTime);
		DOTween.To (() => GamesCG.alpha, x => GamesCG.alpha = x, 0, TransitionTime);
	}

	void onGamesClicked() {
		MovieBtn.GetComponent<Image> ().sprite = MovieWhite;
		TVBtn.GetComponent<Image> ().sprite = TVWhite;
		MusicBtn.GetComponent<Image> ().sprite = MusicWhite;
		GamesBtn.GetComponent<Image> ().sprite = GamesGreen;

		DOTween.To (() => MovieCG.alpha, x => MovieCG.alpha = x, 0, TransitionTime);
		DOTween.To (() => TVCG.alpha, x => TVCG.alpha = x, 0, TransitionTime);
		DOTween.To (() => MusicCG.alpha, x => MusicCG.alpha = x, 0, TransitionTime);
		DOTween.To (() => GamesCG.alpha, x => GamesCG.alpha = x, 1, TransitionTime);
	}

}
