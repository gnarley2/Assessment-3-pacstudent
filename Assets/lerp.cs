using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerp : MonoBehaviour
{

    private Vector3 end = new Vector3(-50,500,0);
    private Vector3 start;
    private float duration = 3f;
    private float elapsedtime;
    // Start is called before the first frame update
    void Start()
    {
        start = new Vector3(2000,500,0);
    }

    // Update is called once per frame
    void Update()
    {
        elapsedtime += Time.deltaTime;
        float percentComplete = elapsedtime / duration;
while(true)
{
        transform.position = Vector3.Lerp(start, end, percentComplete);
}
    //    if(transform.position==end){
      //       lerpBACK();
      //  }
    }
    void lerpBACK(){
                elapsedtime += Time.deltaTime;
        float percentComplete = elapsedtime / duration;
            transform.position = Vector3.Lerp(end, start, percentComplete);
    }
}
