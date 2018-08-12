using System.Collections;
using System.Collections.Generic;

public class Expense  {

    public int ExpenseId { get; set; }
    public int TripId { get; set; }
    public double TotalPrice { get; set; }
    public Person WhoPaid { get; set; }
    public List<ItemToPay> ItemsToPay { get; set; }
    public Currency Currency { get; set; }


    public Expense(Person whoPaid, Trip trip, Currency currency)
    {
        TripId = trip.Id;
        WhoPaid = whoPaid;
        Currency = currency;
        ItemsToPay = new List<ItemToPay>();
    }

    public void AddItem(string itemName, decimal price, Person whoConsumedItem)
    {
        ItemToPay item = new ItemToPay(itemName, price, WhoPaid, whoConsumedItem, Currency);
        ItemsToPay.Add(item);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
