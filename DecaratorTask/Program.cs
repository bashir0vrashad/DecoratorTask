using DecaratorTask;

IDataSource dataSource1 = new FileDataSource("aaaaaaaa");
IDataSource dataSource2 = new CompressionDecorator(new EncryptionDecorator(dataSource1));
dataSource2.writeData("Salam");
Console.WriteLine();
dataSource2.readData();