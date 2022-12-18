using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Room : MonoBehaviour
{
    public List<GameObject> parts = new List<GameObject>();
    public void Add(GameObject roomObject)
    {
        parts.Add(roomObject);
    }
}
