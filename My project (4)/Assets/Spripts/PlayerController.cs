using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Vector3 direction;

    public GameObject Sound;
    private SoundEffect sound;

    public float gravity  = -9.8f;
    public float strength =  5f  ;

    // Start is called before the first frame update
    void Start()
    {
        sound = Sound.gameObject.GetComponent<SoundEffect>();
    }
    private void OnEnable() {
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;
        direction = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * strength;
            sound.PlayFlapSound();
        }
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Obstacle")
        {
            sound.PlayHitSound();
            FindObjectOfType<GameManager>().GameOver();
        } else if (other.gameObject.tag == "Scoring"){
            sound.PlayPointSound();
            FindObjectOfType<GameManager>().Increasescore();
        }
    }
}
