using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public string namaPath;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath(namaPath),
            "time", speed, 
            "easetype", iTween.EaseType.linear,
            "looptype",iTween.LoopType.loop,
            "delay", 0f));
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
