﻿using IdentityModel.Client;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Client
{
    public class Program
    {
        public static void Main(string[] args) => MainAsync().GetAwaiter().GetResult();

        private static async Task MainAsync()
        {
            //    // discover endpoints from metadata
            //    var disco = await DiscoveryClient.GetAsync("http://localhost:5000");
            //    if (disco.IsError)
            //    {
            //        Console.WriteLine(disco.Error);
            //        return;
            //    }

            //    // request token
            //    var tokenClient = new TokenClient(disco.TokenEndpoint, "client", "secret");
            //    var tokenResponse = await tokenClient.RequestClientCredentialsAsync("api1");

            //    if (tokenResponse.IsError)
            //    {
            //        Console.WriteLine(tokenResponse.Error);
            //        return;
            //    }

            //    Console.WriteLine(tokenResponse.Json);
            //    Console.WriteLine("\n\n");

            //    // call api
            //    var client = new HttpClient();
            //    client.SetBearerToken(tokenResponse.AccessToken);

            //    var response = await client.GetAsync("http://localhost:5001/identity");
            //    if (!response.IsSuccessStatusCode)
            //    {
            //        Console.WriteLine(response.StatusCode);
            //    }
            //    else
            //    {
            //        var content = await response.Content.ReadAsStringAsync();
            //        Console.WriteLine(JArray.Parse(content));
            //    }

            // 从元数据中发现客户端
            var disco = await DiscoveryClient.GetAsync("http://localhost:5000");

            // 请求令牌
            var tokenClient = new TokenClient(disco.TokenEndpoint, "ro.client", "secret");
            var tokenResponse = await tokenClient.RequestResourceOwnerPasswordAsync("wjk", "123", "api1");//使用用户名密码

            if (tokenResponse.IsError)
            {
                Console.WriteLine(tokenResponse.Error);
                return;
            }

            Console.WriteLine(tokenResponse.Json);
            Console.WriteLine("\n\n");

            var usclient = new HttpClient();
            usclient.SetBearerToken(tokenResponse.AccessToken);
            var re = await usclient.GetAsync("http://localhost:5000/connect/userinfo");
            Console.WriteLine(JArray.Parse(await re.Content.ReadAsStringAsync()));

            // call api
            var client = new HttpClient();
            client.SetBearerToken(tokenResponse.AccessToken);

            var response = await client.GetAsync("http://localhost:5001/identity");
            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                var content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(JArray.Parse(content));
            }
        }
    }
}
