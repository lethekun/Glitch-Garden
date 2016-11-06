using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {
    public AudioClip[] levelMusicChangeArray;
    private AudioSource audioSource;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Dont destroy on load: " + name);
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = levelMusicChangeArray[0];
        audioSource.loop = false;
        audioSource.Play();
    }

	// Update is called once per frame
	void OnLevelWasLoaded (int level) {
        if (audioSource.clip == levelMusicChangeArray[level]) return;
        AudioClip thisLevelMusic = levelMusicChangeArray[level];
	    Debug.Log("Playing clip: " + thisLevelMusic);

        if (thisLevelMusic)
        {
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
        else
        {
            Debug.Log("No such clip");
        }
	}

    public void SetVolume(float volumeValue)
    {
        audioSource.volume = volumeValue;
    }
}
