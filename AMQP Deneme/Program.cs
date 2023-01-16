


// See https://aka.ms/new-console-template for more information
using System.Net;
using Apache.NMS.AMQP;

Console.WriteLine("Hello, World!");



var connectionFactory = new ConnectionFactory();
connectionFactory.BrokerUri = new Uri("amqp://nftmarketplace.togg.cloud:8443");
var connection = await connectionFactory.CreateConnectionAsync("", "");
await connection.StartAsync();
var x = connection.MetaData;

Console.WriteLine("asdadasas");
Console.Read();