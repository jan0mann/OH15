using System.Net.Http.Headers;

namespace WorldOfZuul;

class Inventory{
    public List<(RangeItemHeaderValue item, int count)> Items { get; set; }

    public Inventory(List<(RangeItemHeaderValue item, int count)> initial_items)
    {
        Items = initial_items;
    }

}
