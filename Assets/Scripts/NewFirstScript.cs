using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewFirstScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        int score = 0;
        string playerName = "roy";
        float jumpForce = 5.82f;
        bool gameOver = false;

        float myNumber = 5.0f;
        float b = 2.0f;
        float c = b * 2.0f;
        myNumber += 15.2f;
        myNumber *= 3.0f;
        myNumber--;
        myNumber++;

        myNumber += b;

        Debug.Log(myNumber);

        int numa = 10;
        int numb = 15;

        if (numa < numb)
        {
            Debug.Log("numa is less than numb");
        }
        else if (numa > numb)
        {
            Debug.Log("numa is greater than numb");
        }
        else
        {
            Debug.Log("numba is equal to numb");
        }


        if(numa == 10 && numb == 10)
        {
            Debug.Log("numba is equal to numb");
        }

        if (numa == 10 || numb == 10)
        {
            Debug.Log("one of the numbers is 10");
        }

        Debug.Log(transform.position);
        Vector3 newVector = new Vector3(1, 1, 1);
        transform.position = newVector;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
