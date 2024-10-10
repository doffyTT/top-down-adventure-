using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchanger : MonoBehaviour
{
    private SpriteRenderer sr;
    public Color[] colors;

    // Start is called before the first frame update
    void Start()
    {
        sr= GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("hit");
        sr.color = colors[Random.Range(0,colors.Length)];
    }







}


