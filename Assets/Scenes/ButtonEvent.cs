using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

public class ButtonEvent : MonoBehaviour
{
	[SerializeField] private Text Text;

	public void OnClick()
	{
		// Localization ����w�肵���e�[�u�����ƃL�[����G���g���[���擾���܂�
		var entry = LocalizationSettings.StringDatabase.GetTableEntry("TextTable", "Hello").Entry;

		Text.text = entry.Value;
	}
}
