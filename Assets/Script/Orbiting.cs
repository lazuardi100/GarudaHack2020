using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbiting : MonoBehaviour
{
    public GameObject inti;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(inti.transform.position, Vector3.up, speed * Time.deltaTime);
    }
}
