using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamingRoomBuilder : RoomBuilder
{
    public GameObject Tv, Wardrobe, Table, Sofa, Chair, Carpet, Armchair, Rooms;
    public Button ButtonTv, ButtonWardrobe, ButtonTable, ButtonSofa, ButtonChair, ButtonCarpet, ButtonArmchair, Entrance;
    private Room room = new Room();

    public override void AddArmchair()
    {
        room.Add(Armchair); ButtonArmchair.interactable = false;
    }

    public override void AddCarpet()
    {
        room.Add(Carpet); ButtonCarpet.interactable = false;
    }

    public override void AddChair()
    {
        room.Add(Chair); ButtonChair.interactable = false;
    }

    public override void AddSofa()
    {
        room.Add(Sofa); ButtonSofa.interactable = false;
    }

    public override void AddTable()
    {
        room.Add(Table); ButtonTable.interactable = false;
    }

    public override void AddTV()
    {

        room.Add(Tv); ButtonTv.interactable = false;
    }

    public override void AddWardrobe()
    {
        room.Add(Wardrobe); ButtonWardrobe.interactable = false;
    }

    public override Room GetRoom()
    {
        return room;
    }
    IEnumerator Corout()
    {
        if (room.parts != null)
        {
            
            for (int i = 0; i < room.parts.Count; i++)
            {
                Entrance.interactable = false;
                Instantiate(room.parts[i], Rooms.transform);
            }
            yield return new WaitForSeconds(1f);
            Entrance.interactable = true;
        }
    }
    public void ExitIkea()
    {
        GetRoom();
        StartCoroutine(Corout());
        room.parts.RemoveRange(0, room.parts.Count);
    }
}
