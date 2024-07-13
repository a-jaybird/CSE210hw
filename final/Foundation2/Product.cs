public class Product{
    private string product;
    private string productId;
    private float PricePerUnit;
    // float totalPrice;
    int quantity;

    public string GetProduct(){
        return product;
    }
    public void SetProduct(string _product){
        product = _product;
    }
    public string GetProductId(){
        return productId;
    }
    public void SetProductId(string _productId){
        productId = _productId;
    }

    // public float GetTotalPrice(){
    //     return totalPrice;
    // }

    public void SetPricePerUnit(float PPU){
        PricePerUnit =PPU;
    }

    public void SetQuantity(int _quantity){
        quantity =_quantity;
    }
   public float FindTotal(){
    
       return (PricePerUnit * quantity);

}


}