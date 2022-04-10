using UnityEngine;

namespace InventorySystem
{
    [CreateAssetMenu(fileName = "[ITEM] ", menuName = "ScriptableObjects/Inventory/InventoryItem")]
    public class InventoryItem : CompositeScriptableObject
    {
        private uint m_Uid;
        public string Name;
        public Sprite Sprite;
        public InventoryItemType ItemType;

        public uint Uid { get => m_Uid; set => m_Uid = value; }
    }
}
