using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIInventoryDescription : MonoBehaviour
{
    [SerializeField]
    private Image itemImage;
    [SerializeField]
    private TMP_Text title;
    [SerializeField]
    private TMP_Text stat1,stat2,stat3;

    public void Awake()
    {
        ResetDescription();
    }

    public void ResetDescription()
    {
        itemImage.gameObject.SetActive(false);
        title.text = "";
        stat1.text = "";
        stat2.text = "";
        stat3.text = "";

    }

    public void SetDescription(Sprite sprite, string itemName,
        string stats1,string stats2,string stats3)
    {
        itemImage.gameObject.SetActive(true);
        itemImage.sprite = sprite;
        title.text = itemName;
        stat1.text = stats1;
        stat2.text = stats2;
        stat3.text = stats3;
    }
}

