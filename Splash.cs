using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour {
    private float timeLeft = 3f;
    public AudioClip splashClip;
    private LevelManager levelManager;
	// Use this for initialization
	void Start () {
        //AudioSource.PlayClipAtPoint(splashClip, transform.position);
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
    }
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            levelManager.LoadLevel("Start");
        }
	}
}
