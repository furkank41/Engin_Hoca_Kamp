using intro.Entities;

IndividualCustomer customer1 = new IndividualCustomer();
IndividualCustomer customer2 = new IndividualCustomer();
CorporateCustomer customer3 = new CorporateCustomer();
CorporateCustomer customer4 = new CorporateCustomer();

BaseCustomer[] baseCustomer = new BaseCustomer[] { customer1, customer2, customer3, customer4 };

foreach (BaseCustomer item in baseCustomer)
{
    if (item is CorporateCustomer)
    {
        Console.WriteLine(((CorporateCustomer)item).TaxNumber);
    }
}