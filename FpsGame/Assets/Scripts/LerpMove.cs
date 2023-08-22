using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//목적:내가 A에서 B까지 3초 만에 가겠다. 
//필요속성 : pointA, pointB, 특정 시간 
public class LerpMove : MonoBehaviour
{
    //필요속성 : pointA, pointB, 특정 시간 
    public Transform pointA;
    public Transform pointB;
    public float duration;
    float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        transform.position = Vector3.Lerp(pointA.position, pointB.position, currentTime / duration);


   
    }
}
