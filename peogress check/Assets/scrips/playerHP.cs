using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerHP : MonoBehaviour
{
    public int health = 10;
    public Text healthText;
    public Slider healthSlider;
    public int Lives = 10;
    void Start()
    {
        healthText.text = "Health: " + health;
        healthSlider.maxValue = health;
        healthSlider.value = health;
        //PlayerPrefs.SetInt("Lives", lives);
        Lives = PlayerPrefs.GetInt("Lives");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ene")
        {
            health--;
            healthText.text = "Health : " + health;
            healthSlider.value = health;
            //same as health -= 1, or health = health

            if (health < 1)
            {
                if(Lives > 0)
                {
                    SceneManager.LoadScene(
                        SceneManager.GetActiveScene().name);
                    //SceneManager.LoadScene("lose");
                    PlayerPrefs.SetInt("Lives", Lives - 1);
                }
                else
                {
                    SceneManager.LoadScene("GameOver");
                }
                SceneManager.LoadScene(
                SceneManager.GetActiveScene().name);
                //SceneManager.Loadscene("Lose");
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enebullet")
        {
            health--;
            healthText.text = "Health : " + health;
            healthSlider.value = health;
            if (health < 1)
            {
                SceneManager.LoadScene(
                SceneManager.GetActiveScene().name);
                //SceneManager.Loadscene("Lose");
            }
        }
    }
}
