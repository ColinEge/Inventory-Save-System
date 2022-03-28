using InventorySystem;
using System.IO;
using UnityEngine;

[RequireComponent(typeof(InventoryHolder))]
public class InventorySaveSystemHolder: MonoBehaviour
{
    [SerializeField] InventoryChannel inventoryChannel;
    InventoryHolder m_InventoryHolder;

    readonly string saveName = "InventorySave.json";

    private void Awake()
    {
        m_InventoryHolder = GetComponent<InventoryHolder>();
        inventoryChannel.OnInventoryExport += OnInventoryExport;
        inventoryChannel.OnInventoryImport += OnInventoryImport;
    }

    public void OnInventoryExport()
    {
        string jsonData = m_InventoryHolder.Inventory.SerialiseInventoryAsJSON();
        string fullPath = Application.dataPath + saveName;
        File.WriteAllText(fullPath, jsonData);
    }

    public void OnInventoryImport()
    {
        string fullPath = Application.dataPath + saveName;
        // if file exists
        if (File.Exists(fullPath))
        {
            string jsonData = File.ReadAllText(fullPath);
            inventoryChannel.OnInventoryClear();
            foreach (var item in m_InventoryHolder.Inventory.GetSlotsFromJSON(jsonData))
            {
                if (item.itemName != null && item.itemName != "")
                {
                    InventoryItem invItem = Resources.Load<InventoryItem>("ScriptableObjects/" + item.itemName);
                    inventoryChannel.OnInventoryItemLoot(invItem, item.quantity);
                }
            }
        }
    }
}
