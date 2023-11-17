using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUIButtonBehaviour : MonoBehaviour
{
    public Button ButtonObj { get; private set; }
    public TextMeshProUGUI Label { get; private set; }
    
    public InventoryItem InventoryItemObj { get; set; }

    protected virtual void Awake()
    {
        ButtonObj = GetComponent<Button>();
        Label = ButtonObj.GetComponentInChildren<TextMeshProUGUI>();
     
        if (ButtonObj != null)
        {
            ButtonObj.onClick.AddListener(HandleButtonClick);
        }
    }

    private void HandleButtonClick()
    {
        if (InventoryItemObj == null) return;
        InventoryItemObj.UsedOrPurchase = false;
        ButtonObj.interactable = false;
    }
}