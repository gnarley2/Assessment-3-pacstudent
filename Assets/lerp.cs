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
transform.position=start;
if(transform.position==start){
        transform.position = Vector3.Lerp(start, end, percentComplete);
}
        if(Vector3.Distance(transform.position, end)<0.01f){
            transform.position = start;
           // backtoSTART();
        }
        
}
void backtoSTART(){
            elapsedtime += Time.deltaTime;
        float percentComplete = elapsedtime / duration;

            transform.position = Vector3.Lerp(start, end, percentComplete);;

}
}

    
