// Consumer

using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

ConnectionFactory factory=new();

factory.Uri = new("amqps://rpjqjzap:SATQLbg_IDrbdTOZL8spYb8YwPkeO888@rabbit.lmq.cloudamqp.com/rpjqjzap");

using IConnection conn=factory.CreateConnection();
using IModel ch=conn.CreateModel();

ch.QueueDeclare(queue:"example-queue", exclusive:false);

EventingBasicConsumer consumer = new(ch);

consumer.Received += (sender,e) => {

    Console.WriteLine(Encoding.UTF8.GetString(e.Body.Span));

};

ch.BasicConsume(queue:"example-queue", autoAck:false, consumer);

Console.Read();