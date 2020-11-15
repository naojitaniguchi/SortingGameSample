using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pointText;
    public GameObject missText;
    int point = 0;
    int miss = 0;
    // private List<GameObject> hitList = new List<GameObject>();
    GameObject targetObject = null ;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
        targetObject = col.gameObject;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
        // spriteMove = -0.1f;
        targetObject = null;
    }


    public void need()
    {
        if (targetObject == null)
        {
            Debug.Log("Miss!!");
            miss++;
            missText.GetComponent<Text>().text = miss.ToString();
            return;
        }


        if ( targetObject.tag == "Needless")
        {
            Debug.Log("Miss!!");
            //targetObject = null;
            miss++;
            missText.GetComponent<Text>().text = miss.ToString();
            return;
        }

        if (targetObject.tag == "Need")
        {
            point++;
            Debug.Log(point);
            targetObject.gameObject.GetComponent<Animator>().Play("Hit");
            pointText.GetComponent<Text>().text = point.ToString();
            //targetObject = null;
            return;
        }

    }

    public void needless()
    {
        if (targetObject == null)
        {
            Debug.Log("Miss!!");
            miss++;
            missText.GetComponent<Text>().text = miss.ToString();
            return;
        }

        if (targetObject.tag == "Need")
        {
            Debug.Log("Miss!!");
            //targetObject = null;
            miss++;
            missText.GetComponent<Text>().text = miss.ToString();
            return;
        }
        if (targetObject.tag == "Needless")
        {
            point++;
            Debug.Log(point);
            targetObject.gameObject.GetComponent<Animator>().Play("Hit");
            //targetObject = null;
            pointText.GetComponent<Text>().text = point.ToString();
            return;
        }
    }
}
