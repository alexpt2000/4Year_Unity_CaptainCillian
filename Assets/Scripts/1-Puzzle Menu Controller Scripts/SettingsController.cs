using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour {

    [SerializeField]
    private MusicController musicController;

    [SerializeField]
	private GameObject settingsPanel;

	[SerializeField]
	private Animator settingsPanelAnime;

    [SerializeField]
    private Slider slider;

    public void OpenSettingsPanel(){
        slider.value = musicController.GetMusicVolume();
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

    public void GetVolume(float volume) {
        musicController.SetMusicVolume(volume);
    }
}
