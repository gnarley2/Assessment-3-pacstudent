using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newmusic1 : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClipArray;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;

        Scene currentScene = SceneManager.GetActiveScene();
        string scenename = currentScene.name;

        
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode){
        
        
           audioSource.clip = audioClipArray[0];
          
           
            audioSource.Play ();
        
    }

    // Update is called once per frame
    void Update()
    {

    }


}