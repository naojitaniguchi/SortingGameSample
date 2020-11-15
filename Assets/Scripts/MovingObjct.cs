using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjct : MonoBehaviour
{
    public float speed = 1.0f ;
    public float DestroyX = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);

        if ( gameObject.transform.position.x > DestroyX)
        {
            Destroy(gameObject);
        }
    }
}
