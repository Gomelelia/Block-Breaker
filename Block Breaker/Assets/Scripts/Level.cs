using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    // parameters
    [SerializeField] int breakableBloks; // Serialized for dubugging purposes

    // cached reference
    SceneLoader sceneloader;

    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();  
    }
    public void CountBreakableBlocs()
    {
        breakableBloks++;
    }

    public void BlockDestroyed()
    {
        breakableBloks--;
        if (breakableBloks <=0)
        {
            sceneloader.LoadNextScene();
        }
    }

}
