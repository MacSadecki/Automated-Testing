using System.Collections;
using System.Collections.Generic;
using NSubstitute;
using NUnit.Framework;
using UnityEngine;



public class inventory 
{
    [Test]
    public void only_allows_one_weapon_to_be_eqipped_at_a_time()
    {
        // ARRANGE
        ICharacter character= Substitute.For<ICharacter>();
        Inventory inventory = new Inventory(character);
        Item sword = new Item() {EquipSlot = EquipSlots.LeftHand};
        Item spear = new Item() {EquipSlot = EquipSlots.LeftHand};

        // ACT
        inventory.EquipItem(sword);
        inventory.EquipItem(spear);

        // ASSERT
        Item equippedItem = inventory.GetItem(EquipSlots.LeftHand);
        Assert.AreEqual(spear, equippedItem);
    }

    [Test]
    public void tells_character_when_an_item_is_equipped_succesfully()
    {
        // ARRANGE
        ICharacter character= Substitute.For<ICharacter>();
        Inventory inventory = new Inventory(character);
        Item chest = new Item() {EquipSlot = EquipSlots.Chest};        

        // ACT
        inventory.EquipItem(chest);

        // ASSERT
        character.Received().OnItemEquipped(chest);
    }
}
