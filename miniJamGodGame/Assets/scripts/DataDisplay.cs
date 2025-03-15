using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DataDisplay : MonoBehaviour
{
    public TextMeshProUGUI FollwersText;
 
    public PlayerData playerData;


    private void Update()
    {
        FollwersText.text = playerData.followers.ToString();
    }
}
