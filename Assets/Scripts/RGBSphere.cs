using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RGBSphere : MonoBehaviour
{
    Renderer render;
    [SerializeField]
    Slider sldR;
    [SerializeField]
    Slider sldG;
    [SerializeField]
    Slider sldB;

    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        render.material.SetFloat("_Albedo_R", sldR.value);
        render.material.SetFloat("_Albedo_G", sldG.value);
        render.material.SetFloat("_Albedo_B", sldB.value);
    }
}
