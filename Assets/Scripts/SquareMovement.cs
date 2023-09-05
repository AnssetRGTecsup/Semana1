using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMovement : MonoBehaviour
{
    public Color newColor  = Color.white;
    public SpriteRenderer spriteRenderer = null;
    public bool updateColor = false;

    private void Awake()
    {
        Debug.Log("Awake Call");

        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start Call");
        spriteRenderer.color = newColor;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update Call");
        if (updateColor)
        {
            spriteRenderer.color = newColor;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            DestroyThisGameObject();
        }
    }

    private void FixedUpdate()
    {
        Debug.Log("Fixed Update Call");
    }

    public void DestroyThisGameObject()
    {
        Destroy(this.gameObject);
    }

    private void OnDestroy()
    {
        Debug.Log("Destroy Call");
    }
}
