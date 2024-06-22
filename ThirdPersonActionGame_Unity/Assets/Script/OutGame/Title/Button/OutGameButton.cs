using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutGameButton : MonoBehaviour {
    [SerializeField , Tooltip("�^�C�g��button�̃v���n�u���i�[")] private GameObject buttonPrefab;
    [SerializeField , Tooltip("��������{�^���̐�")]	 private int generateButton_Amount;
	[SerializeField , Tooltip("button�̃e�L�X�g�ύX�p")] private string[] buttonName;

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
