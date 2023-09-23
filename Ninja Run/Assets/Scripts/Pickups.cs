using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public ParticleSystem PickupAnim;
    void Start()
    {
       PickupAnim.Stop();
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("coin")){
        score++;
        scoreText.text = score.ToString();
        Destroy(other.gameObject);

        PickupAnim.Play();
        }
    }
}
