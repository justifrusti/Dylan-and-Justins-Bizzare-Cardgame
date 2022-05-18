using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BaseCard", menuName = "Cards/BaseCard", order = 100)]
public class BaseCard : ScriptableObject
{
    public string cardName;

    [Range(1, 20)]
    public int cardHP;
    [Range (0, 20)]
    public int cardDMG;
    [Range(0, 10)]
    public int cardCost;

    public GameObject cardObj;
}
