using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

public class ButtonEvent : MonoBehaviour
{
	[SerializeField] private Text Text;

	public void OnClick()
	{
		// Localization から指定したテーブル名とキーからエントリーを取得します
		var entry = LocalizationSettings.StringDatabase.GetTableEntry("TextTable", "Hello").Entry;

		Text.text = entry.Value;
	}
}
