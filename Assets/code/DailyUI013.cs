using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

public class DailyUI013 : DailyUIBase
{
	public Button SendMsgBtn;
	public Text SendMsgBtnText;

	public Text SentTextDisplay;
	public Text TypingTextDisplay;

	public List<Button> TextButtons = new List<Button> ();


	public Button PaperclipBtn;
	public Button SmileyBtn;


	bool MessageNotSend = true;
	const float TransitionTime = 1f;
	public CanvasGroup TypingFrame;
	public CanvasGroup NewTextFrame;

	void Start(){
		SendMsgBtn.onClick.AddListener (MsgOrSendClicked);

		for (int i = 0; i < TextButtons.Count; i++) {
			int j = i;
			TextButtons [i].onClick.AddListener(() => { TextButtonClicked(j); });
		}

	}

	void TextButtonClicked(int k) {
		Button btn = TextButtons [k];
		Text letter = btn.GetComponentInChildren<Text> ();
		TypingTextDisplay.text += letter.text;
		SentTextDisplay.text = TypingTextDisplay.text;
	}

	void MsgOrSendClicked () {
		TypingTextDisplay.text = "";
		if (MessageNotSend) {
			SendMsgBtnText.text = "send";
			MessageNotSend = false;
			DOTween.To (() => TypingFrame.alpha, x => TypingFrame.alpha = x, 1, TransitionTime);
		} else {
			SendMsgBtnText.text = "tap to message";
			MessageNotSend = true;
			DOTween.To (() => TypingFrame.alpha, x => TypingFrame.alpha = x, 0, TransitionTime);
			DOTween.To (() => NewTextFrame.alpha, x => NewTextFrame.alpha = x, 1, TransitionTime);

		}
	}

}
