//using Classroom_7;

//Employee employee = new()
//{
//    fullName = "Semed Hudeynov",
//    address = "Ehmedli",
//    age = 27,
//};


//if (employee.address == null)
//{

//    employee.adress = "XXX";
//}
//Console.WriteLine(employee.GetFullData());


//Employee employee1 = new()
//{
//    fullName = "Semed Hudeynov",
//    address = "Ehmedli",
//    age = 27,
//};

//Employee employee2 = new()
//{
//    fullName = "Oruc Mehrabov",
//    address = "Yasamal",
//    age = 26,
//};

//Employee employee3 = new()
//{
//    fullName = "Ilham Abasli",
//    address = "Lokbatan",
//    age = 19,
//};

////string[] employees = { "sdsdsd", "Addasfdsad" };
//Employee[] employees = { employee1, employee2, employee3 };

//foreach (Employee item in employees) 
//{
//    Console.WriteLine(item.GetFullData());
//}



//Console.WriteLine(employee1.GetFullData());



//Book book = new Book();

//Console.WriteLine(book.Getdata());

//Book book = new Book("Xosrov", "Nizami");

//Console.WriteLine(book.Getdata());

//Book book = new();


//book book = new(100, "Azerbaycan");

//using Classroom_7.Models;

//User user1 = new User()
//{
//    id = 1,
//    fullName = "Aqshin Veliyev",
//    age = 25

//};

//User user2 = new User()
//{
//    id = 2,
//    fullName = "Haci Ehmedov",
//    age = 28,

//};

//User user3 = new User()
//{
//    id = 3,
//    fullName = "Metanet Abbasova",
//    age = 21,

//};

//User user4 = new User()
//{
//    id = 4,
//    fullName = "Meryem Eliyeva",
//    age = 23,
//};


//User[] people = { user 1, user2, user3, user4 };

////foreach (var item in people)
////{
////    Console.WriteLine(item.fullName);
////}

//foreach (var item in people)
//{
//    if (item.id == 2)
//    {

//        Console.WriteLine(item.fullName);
//        break;
//    }

//}

//var result = people.FirstOrDefault(m => m.id > 2);
//Console.WriteLine(result.fullName);

//var result = people.Where(m => m.id > 2).ToArray();
//foreach (var item in result) 

//{

//    Console.WriteLine(item.fullName);
//}


//var result = Array.FindAll(people, m => m.id > 1);
//foreach (var item in result)
//{
//    Console.WriteLine(item.fullName);
//}

//var result = Array.FindAll(people, m => m.age > 24 && m.age < 30);
//foreach (var it in result)
//{
//    Console.WriteLine(IThreadPoolWorkItem.fullName);

//}

//using Classroom_7;

//UserService service = new();
//service.ShowUser();

//using Classroom_7.Models;

//IServiceProvider.GetUserByID(3);

//User user = serviceGetUserBYId(3);
//Console.WriteLine(user.fullName);


using Classroom_7;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;

static void SearchByName(string searchText) 
{
    Product[] products1 = GetAllProducts;
    bool isExist=false;
    Product existProduct = products1.FirstOrDefault(m => m.name.Trim().ToLower().Contains(searchText));
    if (existProduct == null)
    {
        Console.WriteLine("Not Found");
        return;
    }
    Product[] resultProducts = products1.Where(m => m.name.Trim().ToLower().Contains(searchText.Trim().ToLower())).ToArray();
    foreach (Product product in resultProducts)
        {
            Console.WriteLine($"Id : {product.id} - Name : {product.name} - Price : {product.price} - Count : {product.count}");
        }


    {
        Console.WriteLine("Please Add Search text");
    }
    //bool isExist = false
    //
 
    foreach (Product product in products1)
    {
        if(product.name.Trim().ToLower().Contains(searchText.Trim().ToLower()))
        {
            Console.WriteLine($"Id : {product.id} - Name : {product.name} - Price : {product.price} - Count : {product.count}");
            isExist = true;
        }
        else
        {
            isExist = false;
            //Console.WriteLine("Not Found");
        }


    }


    if (!isExist) 
    {
        Console.WriteLine("Not Found");

    }

}

Console.WriteLine("Add Search text");
SearchText: string searchText = Console.ReadLine();
goto SearchText;


Product[] products = GetAllProducts();

if (searchText == " ")


    SearchByName("h");

static Product[] GetAllProducts() 
{
    Product product1 = new Product()
    {
        id = 1,
        name = "Iphone 13",
        price = 1200,
        count = 3,

    };

    Product product2 = new Product()
    {
        id = 2,
        name = "Samsung 12",
        price = 2200,
        count = 5,

    };


    Product product3 = new Product()
    {
        id = 3,
        name = "Xiaomi",
        price = 200,
        count = 200,

    };

    Product product4 = new Product()
    {
        id = 4,
        name = "Nokia",
        price = 1000,
        count = 100,

    };

    Product[] products = { product1, product2, product3, product4 };
    return products;
}