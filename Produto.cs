namespace fixingPOO {
    class Produto {
        public string Name;
        public double Price;
        public int Amount;
        

        public void addProdut(int a) {
            Amount += a; 
        }

        public void removeProdut(int a) {
            Amount -= a;
        }

        public double amountInStorage() {
            return Amount;
        }

        public double valueAmount() {
            return Price * Amount;
        }

        public override string ToString() {
            return Name 
                + ", $" + 
                Price.ToString("F2") + " O valor total em estoque é de: " 
                + valueAmount();
        }
    }

}
