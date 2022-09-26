using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public GameObject spawnerDown, spawnerUp, spawnerSpaceship;

    public Text scoreText;

    public GameObject helpText, jump, panel;
    
    public AudioSource bgMusic, spaceshipSound;

    private int score;

    public static bool died;

    void Start()
    {
        score = 0;
        died = false;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Spaceship")
        {
            SoundScript.instance.DieSound();
            Destroy(this.gameObject);

            foreach (Transform child in spawnerDown.transform)
                Destroy(child.gameObject);

            foreach (Transform child in spawnerUp.transform)
                Destroy(child.gameObject);

            foreach (Transform child in spawnerSpaceship.transform)
                Destroy(child.gameObject);

            helpText.SetActive(false);
            jump.SetActive(false);
            panel.SetActive(true);

            bgMusic.Stop();
            spaceshipSound.Stop();

            died = true;
        }
        else
        {
            SoundScript.instance.ObtainSound();
            Destroy(target.gameObject);

            if (target.tag == "CrystalBlue")
                score += 5;
            if (target.tag == "CrystalGold")
                score += 10;
            if (target.tag == "CrystalGreen")
                score += 15;
            if (target.tag == "CrystalIcy")
                score += 20;
            if (target.tag == "CrystalPurple")
                score += 25;
            if (target.tag == "CrystalRed")
                score += 30;
        }
        
        scoreText.text = "Crystals: " + score;

        if (score > PlayerPrefs.GetInt("CrystalsMax"))
            PlayerPrefs.SetInt("CrystalsMax", score);
    }
}
