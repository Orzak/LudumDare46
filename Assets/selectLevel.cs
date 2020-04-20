using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectLevel : MonoBehaviour
{
    public void select(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }


}
