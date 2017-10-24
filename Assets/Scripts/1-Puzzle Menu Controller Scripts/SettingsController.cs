using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsController : MonoBehaviour {


	[SerializeField]
	private GameObject settingsPanel;

	[SerializeField]
	private Animator settingsPanelAnime;


	public void OpenSettingsPanel(){

		settingsPanel.SetActive(true);
		settingsPanelAnime.Play("SlideIn");
	
	}

	public void CloseSettingsPanel()
	{
        StartCoroutine(CloseSettings());


	}

    IEnumerator CloseSettings()
    {
        settingsPanelAnime.Play("SlideOut");
        yield return new WaitForSeconds(1f);
        settingsPanel.SetActive(false);

    }
}
