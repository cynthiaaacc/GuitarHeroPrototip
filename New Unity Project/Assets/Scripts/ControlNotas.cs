using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlNotas : MonoBehaviour
{

    private SpriteRenderer SpriteRenderer;
    public Sprite nota;
    public Sprite notaPresionada;
    public KeyCode tecla;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(tecla))
        {
            SpriteRenderer.sprite = notaPresionada;
        }

        if(Input.GetKeyUp(tecla))
        {
            SpriteRenderer.sprite = nota;
        }
    }
}
