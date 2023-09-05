using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [Header("Player Properties")]
    [SerializeField] private Rigidbody2D myRigidbody2D;
    [SerializeField] private float velocityScale;

    [Header("Raycast Properties")]
    [SerializeField] private Color rayNormalColor = Color.white;
    [SerializeField] private Color rayHitColor = Color.green;
    [SerializeField] private LayerMask layerInterctions;

    // Start is called before the first frame update
    void Start()
    {
        if(myRigidbody2D == null)
        {
            myRigidbody2D= GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(xInput, yInput);

        myRigidbody2D.velocity = direction * velocityScale;

        RaycastHit2D raycastHit2D =
            Physics2D.Raycast(transform.position, direction, 10f, layerInterctions);

        if(raycastHit2D.collider != null)
        {
            Debug.DrawRay(transform.position, 
                direction.normalized * raycastHit2D.distance, rayHitColor);
            Debug.Log(raycastHit2D.collider.gameObject.name);
        }
        else
        {
            Debug.DrawRay(transform.position, 
                direction.normalized * 10f, rayNormalColor);
        }

        
    }
}
