using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class DailyUI027 : DailyUIBase 
{

	public CanvasGroup AboutLinksCG;
	public Image WelcomeLineImg;
	public Image ShopLineImg;
	public Image AboutLineImg;

	public Button WelcomeBtn;
	public Button ShopBtn;
	public Button AboutBtn;

	const float TransitionTime = 2f;

	void Start () {
		WelcomeBtn.onClick.AddListener (OnWelcomeClicked);
		ShopBtn.onClick.AddListener (OnShopClicked);
		AboutBtn.onClick.AddListener (OnAboutClicked);
	}

	void OnWelcomeClicked() {
		WelcomeLineImg.gameObject.SetActive (true);
		ShopLineImg.gameObject.SetActive (false);
		AboutLineImg.gameObject.SetActive (false);
		DOTween.To (() => AboutLinksCG.alpha, x => AboutLinksCG.alpha = x, 0, TransitionTime);

	}

	void OnShopClicked() {
		WelcomeLineImg.gameObject.SetActive (false);
		ShopLineImg.gameObject.SetActive (true);
		AboutLineImg.gameObject.SetActive (false);
		DOTween.To (() => AboutLinksCG.alpha, x => AboutLinksCG.alpha = x, 1, TransitionTime);
	}

	void OnAboutClicked() {
		WelcomeLineImg.gameObject.SetActive (false);
		ShopLineImg.gameObject.SetActive (false);
		AboutLineImg.gameObject.SetActive (true);
		DOTween.To (() => AboutLinksCG.alpha, x => AboutLinksCG.alpha = x, 0, TransitionTime);
	}

}
