using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyCharacter : MonoBehaviour
{
    Renderer render;
    [SerializeField]
    float colorPower = 1f;
    [SerializeField]
    Slider sldColorPower;

    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        render.material.SetFloat("_ColorPower", sldColorPower.value);
    }
}
