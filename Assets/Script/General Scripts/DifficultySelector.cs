using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum difficulty
{
    easy,
    normal,
    hard
}

public class DifficultySelector : MonoBehaviour
{
    public static string setDifficulty;

    public void selectEasy()
    {
        setDifficulty = difficulty.easy.ToString();
        UnityEngine.Debug.Log("difficulty set to " + setDifficulty);
        //SceneManager.LoadScene(1);
        SceneManager.LoadScene(5); // go to samplelevel scene with set difficulty
    }

    public void selectNormal()
    {
        setDifficulty = difficulty.normal.ToString();
        UnityEngine.Debug.Log("difficulty set to " + setDifficulty);
        // SceneManager.LoadScene(1);
        SceneManager.LoadScene(5); // go to samplelevel scene with set difficulty
    }

    public void selectHard()
    {
        setDifficulty = difficulty.hard.ToString();
        UnityEngine.Debug.Log("difficulty set to " + setDifficulty);
        // SceneManager.LoadScene(1);
        SceneManager.LoadScene(5); // go to samplelevel scene with set difficulty
    }
}
