using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClipArray;

  
    void Start()
    {
        StartCoroutine(Playdasounds());


    }
 IEnumerator Playdasounds()
 {
    for(int i = 0; i < audioClipArray.Length; i++){
            audioSource.clip = audioClipArray[i];
            audioSource.Play ();
           
           yield return new WaitWhile(()=>audioSource.isPlaying);
            audioSource.clip = audioClipArray[1];
            audioSource.loop = true;
    }
  
 }
    // Update is called once per frame
    void Update()
    {

    }
}
