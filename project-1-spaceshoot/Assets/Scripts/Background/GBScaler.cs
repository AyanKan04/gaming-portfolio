using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GBScaler : MonoBehaviour
{
    public float scrollSpeed = 0.2f;
    private Material mat;
    private Vector2 offset = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
        offset = mat.GetTextureOffset("_MainTex");
    }
    private void Update()
    {
        offset.y += scrollSpeed * Time.deltaTime;
        mat.SetTextureOffset("_MainTex", offset);
    }
}
