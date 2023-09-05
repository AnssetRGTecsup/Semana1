using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "ScriptableObjects/PlayerData", order = 0)]
public class PlayerData : ScriptableObject
{
    public string PlayerName;
    public string PlayerDescription;
    public int HP;
}
