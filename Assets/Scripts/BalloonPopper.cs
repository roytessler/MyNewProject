using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonPopper : MonoBehaviour
{
    public int clicksToPop = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("Clicking on balloon");
        
        clicksToPop--;//decrease clicks left to pop the below by one
        transform.localScale += new Vector3(0.2f, 0.2f, 0.2f); //increase the scale of the balloon by .2 on all 3 axes
        if (clicksToPop == 0)
        {
            Debug.Log("Popping balloon");
            Destroy(gameObject);//destroy the game object gameObject is a reference to object the script is attached to
        }

    }
}
