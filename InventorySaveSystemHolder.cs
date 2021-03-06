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
        string fullPath = Application.dataPath + "/" + saveName;
        File.WriteAllText(fullPath, InventoryConverterHelper.ExportInventory(m_InventoryHolder));
    }

    public void OnInventoryImport()
    {
        string fullPath = Application.dataPath + "/" + saveName;
        // if file exists
        if (File.Exists(fullPath))
        {
            string jsonData = File.ReadAllText(fullPath);
            InventoryConverterHelper.ImportInventory(jsonData, inventoryChannel);
        }
    }
}
