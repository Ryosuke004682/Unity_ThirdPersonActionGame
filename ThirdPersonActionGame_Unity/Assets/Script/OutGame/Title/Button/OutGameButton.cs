using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutGameButton : MonoBehaviour {
    [SerializeField , Tooltip("タイトルbuttonのプレハブを格納")] private GameObject buttonPrefab;
    [SerializeField , Tooltip("生成するボタンの数")]	 private int generateButton_Amount;
	[SerializeField , Tooltip("buttonのテキスト変更用")] private string[] buttonName;

	private Button[] buttons;

	private void Awake() => buttons = new Button[generateButton_Amount];

	private void Start() => GenerateButton();

	private void GenerateButton() {
		for(var i = 0; i < buttons.Length; i++) {
			buttons[i] = CreateButton(i, new Vector2(0, -100 * i));
			buttons[i].gameObject.SetActive(true);
		}
	}

	private Button CreateButton(int index , Vector2 position) {
		var buttonObject = Instantiate(buttonPrefab , transform);
		buttonObject.transform.localPosition = position;
		return buttonObject.GetComponent<Button>();
	}
}
