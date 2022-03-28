using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Inventory/InventoryChannel")]
public class InventoryChannel : ScriptableObject
{
    public delegate void InventoryItemLootCallback(InventorySystem.InventoryItem item, uint quantity);
    public InventoryItemLootCallback OnInventoryItemLoot;

    public void RaiseLootItem(InventorySystem.InventoryItem item)
    {
        OnInventoryItemLoot?.Invoke(item, 1);
    }

    public void RaiseLootItem(InventorySystem.InventoryItem item, uint quantity)
    {
        OnInventoryItemLoot?.Invoke(item, quantity);
    }

    // <-- New Block (I'd suggest moving this up to keep it more organised)
    public delegate void InventoryClearCallback(); 
    public InventoryClearCallback OnInventoryClear;

    public delegate void InventoryExportCallback();
    public InventoryExportCallback OnInventoryExport;

    public delegate void InventoryImportCallback();
    public InventoryImportCallback OnInventoryImport;

    public void RaiseInventoryClear()
    {
        OnInventoryClear?.Invoke();
    }

    public void RaiseInventoryExport()
    {
        OnInventoryExport?.Invoke();
    }

    public void RaiseInventoryImport()
    {
        OnInventoryImport?.Invoke();
    }

    // End new Block -->
}
