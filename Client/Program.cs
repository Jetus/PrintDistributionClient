using Models;

var model = new TestModel
{
    FirstName = "Dev",
    LastName = "Senior"
};

Console.WriteLine(model.FullName);