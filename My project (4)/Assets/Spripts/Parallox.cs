using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallox : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public float animationSpeed = 1f;
    private void Awake() {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0f);
    }
}
