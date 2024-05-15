using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private bullet bullet;
    // Start is called before the first frame update
    void Start()
    {
    bullet = GameObject.Find("gun").GetComponent<bullet>();  
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + bullet.Points;
    }
}
