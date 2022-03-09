using NUnit.Framework;
using orderList;

namespace OrderListTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
            string[] list1 = new string[] { "Mumbai",
            "m n o p q r s t",
            "ӝ җ з ӟ ѕ ӡ и",
            "London",
            "New York",
            "Mahesh", 
            "Chris", 
            "Allen", 
            "Naveen", 
            "Monica", 
            "David",
            " ρ σ τ υ φ χ ψ ω Ϡ", 
            " ι κ λ μ ν ξ ο " };
            string[] orderedList = orderList.orderList.orderIt(list1);
            string[] validList = new string[] { " ι κ λ μ ν ξ ο "," ρ σ τ υ φ χ ψ ω Ϡ","Allen","Chris","David","London","m n o p q r s t","Mahesh","Monica","Mumbai","Naveen","New York","ӝ җ з ӟ ѕ ӡ и"};
            Assert.AreEqual(orderedList,validList);
    }
}