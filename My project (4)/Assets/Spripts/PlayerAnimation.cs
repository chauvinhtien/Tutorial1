using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;

    private int spriteIndex;
    private void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Debug.Log(sprites.Length);
    }

    private void Start() {
        //call anotehr function repeating
        InvokeRepeating(nameof(AnimateSprite),0.15f, 0.15f);
    }
    private void AnimateSprite()
    {
        spriteIndex ++;
        if(spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }
        spriteRenderer.sprite = sprites[spriteIndex];
        Debug.Log(spriteIndex);
    }
}
