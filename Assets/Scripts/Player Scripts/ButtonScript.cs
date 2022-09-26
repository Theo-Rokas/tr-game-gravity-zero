using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    // MainMenu
    public void PlayGame()
    {
        StartCoroutine(PlayGameDelay(SoundScript.instance.ClickSound()));
    }

    public void Credits()
    {
        StartCoroutine(CreditsDelay(SoundScript.instance.ClickSound()));
    }

    public void QuitGame()
    {
        StartCoroutine(QuitGameDelay(SoundScript.instance.ClickSound()));
    }

    // PlayGame
    public void PlayAgain()
    {
        StartCoroutine(PlayAgainDelay(SoundScript.instance.ClickSound()));
    }

    public void GoToMenu()
    {
        StartCoroutine(GoToMenuDelay(SoundScript.instance.ClickSound()));
    }

    IEnumerator PlayGameDelay(float length)
    {
        yield return new WaitForSeconds(length);

        SceneManager.LoadScene("PlayGame");
    }

    IEnumerator CreditsDelay(float length)
    {
        yield return new WaitForSeconds(length);

        SceneManager.LoadScene("Credits");
    }

    IEnumerator QuitGameDelay(float length)
    {
        yield return new WaitForSeconds(length);

        Application.Quit();
    }

    IEnumerator PlayAgainDelay(float length)
    {
        yield return new WaitForSeconds(length);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator GoToMenuDelay(float length)
    {
        yield return new WaitForSeconds(length);

        Screen.orientation = ScreenOrientation.Portrait;

        SceneManager.LoadScene("MainMenu");        
    }
}
