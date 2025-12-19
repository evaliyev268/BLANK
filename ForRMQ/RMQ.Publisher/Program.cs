//Publisher



using RabbitMQ.Client;
using System.Text;

ConnectionFactory factory = new();

factory.Uri = new("amqps://rpjqjzap:SATQLbg_IDrbdTOZL8spYb8YwPkeO888@rabbit.lmq.cloudamqp.com/rpjqjzap");

using IConnection conn = factory.CreateConnection();
using IModel ch = conn.CreateModel();


ch.QueueDeclare(queue: "example-queue", exclusive: false);

byte[] message = Encoding.UTF8.GetBytes("Elvinus Valiyevus");

ch.BasicPublish(exchange: "", routingKey: "job-example", body: message);

Console.Read();
