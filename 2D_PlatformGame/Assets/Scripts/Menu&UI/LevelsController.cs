using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsController : MonoBehaviour
{
    // metoda wczytująca pierwszy poziom
    public void PlayEarth1()
    {
        SceneManager.LoadScene(1);
    }
    // metoda wczytująca drugi poziom
    public void PlayJupiter2()
    {
        SceneManager.LoadScene(2);
    }
    // metoda wczytująca trzeci poziom
    public void PlayMars3()
    {
        SceneManager.LoadScene(3);
    }
    //metoda wczytująca czwarty poziom
    public void PlayMercury4()
    {
        SceneManager.LoadScene(4);
    }
    //metoda wczytująca piąty poziom
    public void PlayNeptune5()
    {
        SceneManager.LoadScene(5);
    }
    //metoda wczytujaca szosty poziom
    public void PlayVenus6()
    {
        SceneManager.LoadScene(6);
    }
}
