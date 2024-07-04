using NSubstitute;
using NUnit.Framework;

public class character_with_inventory
{
    [Test]
    public void with_no_armor_takes_full_damage()
    {
        // ARRANGE
        ICharacter character= Substitute.For<ICharacter>();
        Inventory inventory= new Inventory(character);

        character.Inventory.Returns(inventory);

        // ACT
        int calculatedDamage = DamageCalculator.CalculateDamage(100, character);

        // ASSES
        Assert.AreEqual(100, calculatedDamage);
    }

    [Test]
    public void with_70_armor_takes_30_percent_damage()
    {
        // ARRANGE
        ICharacter character= Substitute.For<ICharacter>();
        Inventory inventory= new Inventory(character);
        Item pants= new Item() {EquipSlot = EquipSlots.Legs, Armor = 20};
        Item shield= new Item() {EquipSlot = EquipSlots.RightHand, Armor = 50};

        inventory.EquipItem(pants);
        inventory.EquipItem(shield);

        character.Inventory.Returns(inventory);

        // ACT
        int calculatedDamage = DamageCalculator.CalculateDamage(100, character);

        // ASSES
        Assert.AreEqual(30, calculatedDamage);
    }
}
