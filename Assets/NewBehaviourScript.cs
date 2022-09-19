using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClipArray;

    //bool hasplayedIntro = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Playdasounds());

        //audioSource.clip = audioClipArray[0];
        //audioSource.Play ();
       // hasplayedIntro = true;
        
       // audioSource.clip = audioClipArray[1];
       // audioSource.Play ();
    }
 IEnumerator Playdasounds()
 {
    //for(int i = 0; i < audioClipArray.Length; i++){
  audioSource.clip = audioClipArray[0];
            audioSource.Play ();
           //hasplayedIntro = true;
           yield return new WaitWhile(()=>audioSource.isPlaying);
           audioSource.clip = audioClipArray[1];
           audioSource.Play ();
    //}
  
 }
    // Update is called once per frame
    void Update()
    {
      // if(hasplayedIntro==false){
    //audioSource.clip = audioClipArray[0];
            //audioSource.Play ();
           //hasplayedIntro = true;
          
            //}

              // if(hasplayedIntro){
            //audioSource.clip = audioClipArray[1];
           // audioSource.Play ();
        
    }
}
