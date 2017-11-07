using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MusicController : MonoBehaviour {

    [SerializeField]
    private PuzzleGameSaver puzzleGameSaver;

    private AudioSource bgMusicClip;

    private float musicVolume;

    void Awake() {
        GetAudioSource();
    }

	// Use this for initialization
	void Start () {
        musicVolume = puzzleGameSaver.musicVolume;
        PlayOrTurnOfMusic(musicVolume);

    }
	

	void GetAudioSource () {
        //bgMusicClip = GetAudioSource<AudioSource>();
        bgMusicClip = GetComponent<AudioSource>();

    }

    public void SetMusicVolume(float volume) {
        PlayOrTurnOfMusic(volume);
    }

    void PlayOrTurnOfMusic(float volume) {
        musicVolume = volume;
        bgMusicClip.volume = musicVolume;

        if (bgMusicClip.volume > 0)
        {
            if (!bgMusicClip.isPlaying)
            {
                bgMusicClip.Play();
            }

            puzzleGameSaver.musicVolume = musicVolume;
            puzzleGameSaver.SaveGameData();

        }
        else if (bgMusicClip.volume == 0)
        {
            if (bgMusicClip.isPlaying)
            {
                bgMusicClip.Stop();
            }

            puzzleGameSaver.musicVolume = musicVolume;
            puzzleGameSaver.SaveGameData();

        }
    }

    public float GetMusicVolume() {
        return this.musicVolume;
    }
}
