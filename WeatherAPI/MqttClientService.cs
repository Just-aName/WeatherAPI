using MQTTnet;
using MQTTnet.Client;
using System.Text.Json;
using System.Text;
using WeatherAPI.Models;
using System.Threading;

namespace WeatherAPI
{
    public class MqttClientService : BackgroundService
    {
        private readonly PeriodicTimer _timer = new(TimeSpan.FromMinutes(5));

        public RawDataModel? LastRecord { get; set; }

        protected  override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while(await _timer.WaitForNextTickAsync(stoppingToken) && !stoppingToken.IsCancellationRequested) 
            {
                try
                {
                    Console.WriteLine(RoundUp(DateTime.Now, TimeSpan.FromMinutes(5)).ToString());
                    await Handle_Received_Application_Message();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        public async Task Handle_Received_Application_Message()
        {


            var mqttFactory = new MqttFactory();

            using (var mqttClient = mqttFactory.CreateMqttClient())
            {
                var mqttClientOptions = new MqttClientOptionsBuilder().WithTcpServer("158.196.157.134", 9883).Build();

                // Setup message handling before connecting so that queued messages
                // are also handled properly. When there is no event handler attached all
                // received messages get lost.
                mqttClient.ApplicationMessageReceivedAsync += e =>
                {
                    Console.WriteLine("Received application message.");
                    Console.WriteLine($"+ Payload = {Encoding.UTF8.GetString(e.ApplicationMessage.Payload)}");
                    string res = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
                    MqttDataModel? resJson =
                        JsonSerializer.Deserialize<MqttDataModel>(res);

                    if (resJson != null)
                    {
                        LastRecord = new RawDataModel(resJson);
                        using (var dbContext = new WeatherContext())
                        {
                            dbContext.RawData.Add(new RawDataTableModel(resJson));  
                            dbContext.TodayRaw.Add(new TodayRawTableModel(resJson));
                            dbContext.SaveChanges();
                        }
                    }
                    else
                    {
                        LastRecord = null;
                    }

                    return Task.CompletedTask;
                };

                await mqttClient.ConnectAsync(mqttClientOptions, CancellationToken.None);

                var mqttSubscribeOptions = mqttFactory.CreateSubscribeOptionsBuilder()
                    .WithTopicFilter(
                        f =>
                        {
                            f.WithTopic("/devices/wh1080-fei-json");
                        })
                    .Build();

                await mqttClient.SubscribeAsync(mqttSubscribeOptions, CancellationToken.None);

                Console.WriteLine("MQTT client subscribed to topic.");
                await Task.Delay(5000);
                Console.WriteLine(this.LastRecord?.time.ToString() ?? "empty");

                /*
                Console.WriteLine("Press enter to exit.");
                Console.ReadLine();*/

            }

        }

        private DateTime RoundUp(DateTime dt, TimeSpan d)
        {
            return new DateTime((dt.Ticks + d.Ticks - 1) / d.Ticks * d.Ticks, dt.Kind);
        }
    }
}
