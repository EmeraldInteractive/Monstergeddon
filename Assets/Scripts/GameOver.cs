using UnityEngine;
using UnityEngine.SceneManagement;
using Assets.Scripts.UI;
using MovementEffects;
using System.Collections.Generic;

public class GameOver : MonoBehaviour
{
    /*
     * Watch the countdown timer and when time reaches 0, end game and send back to main menu.
     */

    [SerializeField] GameObject GameOverUI;

    private void FixedUpdate()
    {
        CheckTimer();
    }

    void CheckTimer()
    {
        float timeIsUp = Countdown.countDown.CurrentTime;
        if (timeIsUp <= 0)
        {
            GameOverUI.gameObject.SetActive(true);
            Timing.RunCoroutine(_LoadMainMenu());
        }
        
    }

    IEnumerator<float> _LoadMainMenu()
    {
        yield return Timing.WaitForSeconds(5f);

        //0 will always be the main menu
        SceneManager.LoadScene(0);

        Timing.KillCoroutines();
    }
}
