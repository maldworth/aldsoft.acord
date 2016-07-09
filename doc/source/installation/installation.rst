Getting Started
===============
The package(s) are available on nuget. There are multiple packages because each one is built
against a specific version of the ACORD Standard. ACORD recommends that you always use the
latest version of the ACORD spec, and they do their best to avoid breaking changes and
maintain backwards compatibility.

The various ACORD versions are available in separate packages on `nuget <https://www.nuget.org/packages?q=Tags%3A%22acord%22>`_.

2 Minute Tutorial
-----------------

Open your .NET project.

.. sourcecode:: powershell

    nuget install-package aldsoft.acord.2.35.00

I chose to use ACORD version 2.35.00, you can choose a different one if you like.

The example below we used a simple console application, and constructed a very
basic (and incomplete) TXLife Request. The same object could have been constructed
without using the Fluent API builder, but then the user risks adding a TXLife Response
to the object (not allowed in the standard).

.. sourcecode:: csharp

    using Aldsoft.Acord.LA;
    ...
    static void Main(string[] args)
    {
        // Templates an Acord object with Fluent Builder
        var builder = TXLife_Type.CreateBuilder()
            .AddTXLifeRequest(new TXLifeRequest_Type { id = "1" })
            .Version("2.35.00")
            .AddUserAuthRequest(new UserAuthRequest_Type());

        // Builds the object from the builder template
        var txLife = builder.Build();

        // Serialize
        string xmlString;
        txLife.Serialize(out xmlString);
        Console.WriteLine(xmlString);

        // Deserialize
        var txLifeDeserialized = TXLife_Type.Deserialize(xmlString);
        Console.WriteLine(txLifeDeserialized.Version);

        Console.ReadKey();
    }
