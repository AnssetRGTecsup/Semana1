using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began )
            {
                Debug.Log(touch.position);
                Vector2 position = Camera.main.ScreenToWorldPoint( touch.position );
                Debug.Log(position);
                transform.position = position;

                Debug.Break();
            }
        }
    }
}
