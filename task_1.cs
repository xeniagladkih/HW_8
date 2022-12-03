//У даному прикладі використано антипатерн God object.
//А також порушено The Single Responsibility Principle.
//Цей принцип говорить про те, що кожен клас повинен вирішувати лише одну задачу.
//Це можна виправити наступним чином:
class Item
{

}
class Order
{
    private List<Item> itemList;
    internal List<Item> ItemList
    {
        get
        {
            return itemList;
        }
        set
        {
            itemList = value;
        }
    }
    public void CalculateTotalSum() {/*...*/}
    public void GetItems() {/*...*/}
    public void GetItemCount() {/*...*/}
    public void AddItem(Item item) {/*...*/}
    public void Update() {/*...*/}
}

class OrderRepository
{
    public void Load() {/*...*/}
    public void Save() {/*...*/}
}

class OrderDelete
{
    public void Delete() {/*...*/}
    public void DeleteItem(Item item) {/*...*/}
}
class PrintManager
{
    public void PrintOrder() {/*...*/}
    public void ShowOrder() {/*...*/}
}
