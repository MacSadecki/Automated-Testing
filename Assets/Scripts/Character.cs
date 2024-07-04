using UnityEngine;

public class Character : MonoBehaviour, ICharacter
{
    public Inventory Inventory { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }

    public void OnItemEquipped(Item item)
    {
        Debug.Log($"{item} has been eqipped to {item.EquipSlot}");
    }
    
    public void OnItemUnequipped(Item item)
    {
        Debug.Log($"{item} has been uneqipped from {item.EquipSlot}");
    }
}