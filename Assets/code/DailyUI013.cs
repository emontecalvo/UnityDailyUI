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

	public Button OneBtn;
	public Button TwoBtn;
	public Button ThreeBtn;
	public Button FourBtn;
	public Button FiveBtn;
	public Button SixBtn;
	public Button SevenBtn;
	public Button EightBtn;
	public Button NineBtn;
	public Button ZeroBtn;
	public Button ABtn;
	public Button BBtn;
	public Button CBtn;
	public Button DBtn;
	public Button EBtn;
	public Button FBtn;
	public Button GBtn;
	public Button HBtn;
	public Button IBtn;
	public Button JBtn;
	public Button KBtn;
	public Button LBtn;
	public Button MBtn;
	public Button NBtn;
	public Button OBtn;
	public Button PBtn;
	public Button QBtn;
	public Button RBtn;
	public Button SBtn;
	public Button TBtn;
	public Button UBtn;
	public Button VBtn;
	public Button WBtn;
	public Button XBtn;
	public Button YBtn;
	public Button ZBtn;
	public Button PaperclipBtn;
	public Button SmileyBtn;
	public Button PeriodBtn;
	public Button QuestionBtn;
	public Button ExclamationBtn;
	public Button MoneyBtn;
	public Button AndBtn;
	public Button AtBtn;
	public Button SpaceBtn;

	bool MessageNotSend = true;
	const float TransitionTime = 1f;
	public CanvasGroup TypingFrame;

	void Start(){
		SendMsgBtn.onClick.AddListener (MsgOrSendClicked);
		HBtn.onClick.AddListener (HBtnClicked);
		IBtn.onClick.AddListener (IBtnClicked);
	}

	void HBtnClicked() {
		TypingTextDisplay.text += "h";
	}

	void IBtnClicked() {
		TypingTextDisplay.text += "i";
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
		}
	}

}
