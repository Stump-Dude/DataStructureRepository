using System.Collections;

public enum Type
{
    Weapon,
    Armor,
    Potion,
    Scroll
}

public enum Rarity
{
    Common,
    Uncommon,
    Rare,
    Epic,
    Legendary
}

public class Item
{
    public string name { get; }
    public Type type { get; set; }
    public Rarity rarity { get; set; }
    public int numberSlots { get; }
    public bool uniqueUse { get; }


    Item(string name, Type type, Rarity rarity, int numberSlots, bool uniqueUse)
    {
        this.name = name;
        this.type = type;
        this.rarity = rarity;
        this.numberSlots = numberSlots;
        this.uniqueUse = uniqueUse;
    }
}
public class Inventory
{
    Hashtable inventory = new Hashtable();

    int slotsOccupied;
    int maximumSLots;

    Item item = new Item("Sword", Type.Weapon, Rarity.Common, 1, false);
    bool InsertItem(Item item)
    {
        return true;
    }
    Item Remove(Item item)
    {
        return;
    }

    int NumberOfItems()
    {
        return 0;
    }

    int NumberOfSlots()
    {
        return 0;
    }

    CleanInventory()
    {

    }
}
