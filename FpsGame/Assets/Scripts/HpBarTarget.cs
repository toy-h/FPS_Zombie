using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 목적 : HP bar의 앞방향이 타깃의 앞 방향으로 향한다. 
//필요 속성 : 타깃
public class HpBarTarget : MonoBehaviour
{

    //필요 속성 : 타깃 
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {// 목적 : HP bar의 앞방향이 타깃의 앞 방향으로 향한다. 
        transform.forward = target.forward;
    }
}
