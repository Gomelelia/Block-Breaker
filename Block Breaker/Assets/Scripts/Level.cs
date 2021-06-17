using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int breakableBloks; // Serialized for dubugging purposes


    public void CountBreakableBlocs()
    {
        breakableBloks++;
    }
}
