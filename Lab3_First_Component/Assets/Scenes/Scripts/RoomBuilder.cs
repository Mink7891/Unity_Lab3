using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RoomBuilder : MonoBehaviour
{
    public abstract void AddTV();
    public abstract void AddWardrobe();
    public abstract void AddTable();
    public abstract void AddSofa();
    public abstract void AddChair();
    public abstract void AddCarpet();
    public abstract void AddArmchair();

    public abstract Room GetRoom();
}
