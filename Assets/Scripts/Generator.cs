using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject[] objects;
    public int maxSpace = 12 ;
    public float waitTime = 0.5f;
    public bool generating = true;
    public int spaceDecreaseMax = 12;
    int genCount = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("GenerateItems");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GenerateItems()
    {
        while ( generating)
        {
            yield return new WaitForSeconds(waitTime);

            int objIndex = Random.Range(0, objects.Length + maxSpace );

            if ( objIndex < objects.Length)
            {
                GameObject obj = Instantiate(objects[objIndex], new Vector3(gameObject.transform.position.x, objects[objIndex].transform.position.y, objects[objIndex].transform.position.z), Quaternion.identity);
            }
            genCount++;
            if ( genCount > spaceDecreaseMax)
            {
                if ( maxSpace > 0)
                {
                    maxSpace--;
                }
                genCount = 0;
            }

        }

    }

}
