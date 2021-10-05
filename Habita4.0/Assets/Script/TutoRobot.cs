using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoRobot : MonoBehaviour
{
    public GameObject infoRobot;

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("ImagenRobot");
    }
    IEnumerator ImagenRobot()
    {
        Time.timeScale = 0;
        yield return new WaitForSecondsRealtime(8);
        Time.timeScale = 1;
        infoRobot.SetActive(false);
    }
}
