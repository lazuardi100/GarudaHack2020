using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public string namaPath;
    // Start is called before the first frame update
    void Start()
    {
        iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath(namaPath),
            "time", 5, 
            "easetype", iTween.EaseType.easeInOutSine,
            "looptype",iTween.LoopType.loop ));
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
