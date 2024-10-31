using System.Diagnostics.CodeAnalysis;

namespace fixingPOO {
    internal class Worker {
        public string name;
        public double payment;
        public double tax;

        public double liquid() {
            return payment - tax;
        }
        public void reajustment(double a) {
           payment = payment + (payment * a / 100.00);
        }

        public override string ToString() {
            return name + ", $ " + liquid() ;
        }
    }
}
