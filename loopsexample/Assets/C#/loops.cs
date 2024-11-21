using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int number = 0;

        while(number < 5)
        {
            //do something 
            Debug.Log(number);
            number++;
        }

        for(int i = 0;  i< 5; i++)
        {
            //do something 
            Debug.Log(i);
            Instantiate(Platform, new Vector2(Random.Range(-7f, 7f), Random.Range(-3f, 3f), Quaternion.identity);
        }




    }

    
}
