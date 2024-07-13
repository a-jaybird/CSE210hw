

using Microsoft.Win32.SafeHandles;

public class Order{
private Customer customer;
float _shipping;
float _OrderTotal;
List<Product> products = new List<Product>();



public Customer GetCustomer(){
    return customer;
}
public void SetCustomer(Customer _customer){
    customer = _customer;
}
public void shippingPrice(){
    if(customer.USorNot()){
        _shipping = 5;
    } 
    else{
        _shipping = 35;
    }
}
public float FindOrderTotal(){
    if (_OrderTotal <= 0){
        foreach(Product p in products){
                _OrderTotal += p.FindTotal();

        }
        _OrderTotal+=_shipping;
    }
    return _OrderTotal;
}
public void SetProductList(List<Product> p){
    products = p;
}
// public Product productList(){

// }
public string PackingLabel(){
    string packLabel = "";
    foreach(Product p in products){
        packLabel += p.GetProduct() +", "+ p.GetProductId()+'\n';

    }
    return packLabel;
    }
public string ShippingLabel(){
    customer.GetName();
    customer.GetAddress().FullAddress();
    return  customer.GetName() +"\n" + customer.GetAddress().FullAddress();   
}
// how to order and bits
}
